using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Fivemid.FiveSteam.Generator;

public partial class CodeWriter {
    private void Register(IEnumerable<SteamApiDefinition.InterfaceDefinition> definitions) {
        foreach (SteamApiDefinition.InterfaceDefinition definition in definitions.Where(d => !d.Name.IsPrimitive()))
            Register(definition);
    }
    
    private void Register(SteamApiDefinition.InterfaceDefinition definition) {
        Convert.RegisterType(definition.Name, InterfaceInstanceType(definition));
        
        foreach (SteamApiDefinition.EnumDefinition subEnum in definition.Enums ?? []) {
            Convert.RegisterType($"{definition.Name}::{subEnum.Name}",
                                 ParseTypeName($"{InterfaceName(definition.Name)}.{EnumName(subEnum.Name)}"));
        }
    }
    
    private BaseTypeDeclarationSyntax[] Interfaces(IEnumerable<SteamApiDefinition.InterfaceDefinition> definitions) =>
        definitions.Where(d => !d.Name.IsPrimitive()).SelectMany(Interface).ToArray();
    
    private IEnumerable<BaseTypeDeclarationSyntax> Interface(SteamApiDefinition.InterfaceDefinition definition) {
        string name = InterfaceName(definition.Name);
        
        BaseTypeDeclarationSyntax interfaceDeclaration =
            InterfaceDeclaration(name)
               .AddModifiers(Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.UnsafeKeyword))
               .AddMembers(definition.Methods.Select(
                               method =>
                                   MethodDeclaration(method.ReturnType.ToType(), MethodName(method.Name))
                                      .AddModifiers(Token(SyntaxKind.PublicKeyword))
                                      .AddParameterListParameters(
                                           method.Parameters.Select(MethodParameter).ToArray()
                                       )
                                      .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                           ).ToArray<MemberDeclarationSyntax>())
               .AddMembers(definition.Methods.Select(
                               method =>
                                   MethodDeclaration(method.ReturnType.ToType(), MethodName(method.Name))
                                      .AddAttributeLists(
                                           DllImportAttribute(method.FlatName)
                                       )
                                      .AddModifiers(Token(SyntaxKind.InternalKeyword), Token(SyntaxKind.StaticKeyword),
                                                    Token(SyntaxKind.ExternKeyword))
                                      .AddParameterListParameters(
                                           Parameter(Identifier("self")).WithType(ParseTypeName("void*")))
                                      .AddParameterListParameters(
                                           method.Parameters.Select(MethodParameter).ToArray()
                                       )
                                      .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                           ).ToArray<MemberDeclarationSyntax>())
               .AddMembers(
                    StructDeclaration("Instance")
                       .AddAttributeLists(StructLayoutAttribute())
                       .AddModifiers(Token(SyntaxKind.PublicKeyword))
                       .AddBaseListTypes(SimpleBaseType(IdentifierName(name)))
                       .AddMembers(
                            FieldDeclaration(VariableDeclaration(ParseTypeName("void*"))
                                                .AddVariables(VariableDeclarator("self")))
                               .AddModifiers(Token(SyntaxKind.PublicKeyword))
                        )
                       .AddMembers(definition.Methods.Select(
                                       method =>
                                           MethodDeclaration(method.ReturnType.ToType(), MethodName(method.Name))
                                              .AddModifiers(Token(SyntaxKind.PublicKeyword))
                                              .AddParameterListParameters(
                                                   method.Parameters.Select(MethodParameter).ToArray()
                                               )
                                              .WithExpressionBody(
                                                   ArrowExpressionClause(
                                                       InvocationExpression(
                                                               ParseExpression($"{name}.{MethodName(method.Name)}"))
                                                          .AddArgumentListArguments(
                                                               Argument(IdentifierName("self"))
                                                           )
                                                          .AddArgumentListArguments(
                                                               method.Parameters.Select(MethodArgument).ToArray()
                                                           )
                                                   )
                                               )
                                              .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                                   ).ToArray<MemberDeclarationSyntax>())
                )
               .AddMembers(Enums(definition.Enums ?? []).ToArray<MemberDeclarationSyntax>())
               .WithLeadingTrivia(SimpleDescriptionDocumentation(definition.Name));
        
        IEnumerable<BaseTypeDeclarationSyntax> accessorDeclarations =
            (definition.Accessors ?? []).Select(
                accessor =>
                    ClassDeclaration(accessor.Name.StripSuffix("_SteamAPI"))
                       .AddModifiers(Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.UnsafeKeyword),
                                     Token(SyntaxKind.StaticKeyword))
                       .AddMembers(
                            PropertyDeclaration(InterfaceInstanceType(definition),
                                                Identifier("Instance"))
                               .AddModifiers(Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.StaticKeyword))
                               .WithExpressionBody(ArrowExpressionClause(
                                                       InvocationExpression(IdentifierName("Accessor"))
                                                   ))
                               .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                        )
                       .AddMembers(
                            MethodDeclaration(InterfaceInstanceType(definition), Identifier("Accessor"))
                               .AddModifiers(Token(SyntaxKind.PrivateKeyword), Token(SyntaxKind.StaticKeyword),
                                             Token(SyntaxKind.ExternKeyword))
                               .AddAttributeLists(DllImportAttribute(accessor.NameFlat))
                               .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                        )
                       .AddMembers(definition.Methods.Select(
                                       method =>
                                           MethodDeclaration(method.ReturnType.ToType(), MethodName(method.Name))
                                              .AddModifiers(Token(SyntaxKind.PublicKeyword),
                                                            Token(SyntaxKind.StaticKeyword))
                                              .AddParameterListParameters(
                                                   method.Parameters.Select(MethodParameter).ToArray()
                                               )
                                              .WithExpressionBody(
                                                   ArrowExpressionClause(
                                                       InvocationExpression(
                                                               ParseExpression($"Instance.{MethodName(method.Name)}"))
                                                          .AddArgumentListArguments(
                                                               method.Parameters.Select(MethodArgument).ToArray()
                                                           )
                                                   )
                                               )
                                              .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                                              .WithLeadingTrivia(
                                                   InterfaceMethodDocumentation(definition, method))
                                   ).ToArray<MemberDeclarationSyntax>())
            );
        
        return accessorDeclarations.Append(interfaceDeclaration);
    }
    
    private SyntaxTrivia[] InterfaceMethodDocumentation(
        SteamApiDefinition.InterfaceDefinition @interface,
        SteamApiDefinition.Method              method
    ) {
        if (Documentation.VALUE.GetInterface(@interface.Name)?.GetChild(method.Name) is { } documentation)
            return DocComment($"""
                               <summary>{documentation.Description}</summary>
                               {string.Join('\n', documentation.Children.Select(p => $"""<param name="{p.Name}">{p.Type}: {p.Description}</param>"""))}
                               """);
        
        return DocComment("missing documentation");
    }
    
    private AttributeListSyntax DllImportAttribute(string entryPoint) =>
        AttributeList()
           .AddAttributes(
                Attribute(IdentifierName("DllImport"))
                   .AddArgumentListArguments(
                        AttributeArgument(ParseExpression("Platform.LIBRARY_NAME")),
                        AttributeArgument(
                                LiteralExpression(
                                    SyntaxKind.StringLiteralExpression,
                                    Literal(entryPoint)))
                           .WithNameEquals(NameEquals("EntryPoint")),
                        AttributeArgument(ParseExpression("Platform.CC"))
                           .WithNameEquals(NameEquals("CallingConvention"))
                    )
            );
    
    private TypeSyntax InterfaceInstanceType(SteamApiDefinition.InterfaceDefinition definition) =>
        ParseTypeName($"{InterfaceName(definition.Name)}.Instance");
    
    private ParameterSyntax MethodParameter(SteamApiDefinition.Method.Parameter parameter) =>
        Parameter(Identifier(parameter.Name))
           .WithType(parameter.Type.ToType())
           .AddModifiers(parameter.Type.EndsWith('&')
                             ? [Token(SyntaxKind.RefKeyword)]
                             : []);
    
    private ArgumentSyntax MethodArgument(SteamApiDefinition.Method.Parameter parameter) =>
        Argument(IdentifierName(parameter.Name))
           .WithRefKindKeyword(parameter.Type.EndsWith('&')
                                   ? Token(SyntaxKind.RefKeyword)
                                   : Token(SyntaxKind.None));
    
    private SyntaxToken MethodName(string name) => Identifier(methodNameOverride.GetValueOrDefault(name, name));
    
    private string InterfaceName(string name) => name;
    
    private static readonly Dictionary<string, string> methodNameOverride = new() {
        { "operator<", "LessThan" },
        { "operator=", "Assign" },
        { "operator==", "Equals" },
    };
}