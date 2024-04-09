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
                                   MethodDeclaration(method.ReturnType.ToType(), Identifier(method.Name))
                                      .AddModifiers(Token(SyntaxKind.PublicKeyword))
                                      .AddParameterListParameters(
                                           method.Parameters.Select(InterfaceParameter).ToArray()
                                       )
                                      .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                           ).ToArray<MemberDeclarationSyntax>())
               .AddMembers(definition.Methods.Select(
                               method =>
                                   MethodDeclaration(method.ReturnType.ToType(), Identifier(method.Name))
                                      .AddAttributeLists(
                                           DllImportAttribute(method.FlatName)
                                       )
                                      .AddModifiers(Token(SyntaxKind.InternalKeyword), Token(SyntaxKind.StaticKeyword),
                                                    Token(SyntaxKind.ExternKeyword))
                                      .AddParameterListParameters(
                                           Parameter(Identifier("self")).WithType(ParseTypeName("void*")))
                                      .AddParameterListParameters(
                                           method.Parameters.Select(InterfaceParameter).ToArray()
                                       )
                                      .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                           ).ToArray<MemberDeclarationSyntax>())
               .AddMembers(
                    StructDeclaration("Instance")
                       .AddModifiers(Token(SyntaxKind.PublicKeyword))
                       .AddBaseListTypes(SimpleBaseType(IdentifierName(name)))
                       .AddMembers(
                            FieldDeclaration(VariableDeclaration(ParseTypeName("void*"))
                                                .AddVariables(VariableDeclarator("self")))
                               .AddModifiers(Token(SyntaxKind.PublicKeyword))
                        )
                       .AddMembers(definition.Methods.Select(
                                       method =>
                                           MethodDeclaration(method.ReturnType.ToType(), Identifier(method.Name))
                                              .AddModifiers(Token(SyntaxKind.PublicKeyword))
                                              .AddParameterListParameters(
                                                   method.Parameters.Select(InterfaceParameter).ToArray()
                                               )
                                              .WithExpressionBody(
                                                   ArrowExpressionClause(
                                                       InvocationExpression(ParseExpression($"{name}.{method.Name}"))
                                                          .AddArgumentListArguments(
                                                               Argument(IdentifierName("self"))
                                                           )
                                                          .AddArgumentListArguments(
                                                               method.Parameters.Select(InterfaceArgument).ToArray()
                                                           )
                                                   )
                                               )
                                              .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                                   ).ToArray<MemberDeclarationSyntax>())
                )
               .AddMembers(Enums(definition.Enums ?? []).ToArray<MemberDeclarationSyntax>())
               .WithLeadingTrivia(Comment($"/// <summary>{definition.Name}</summary>"));

        IEnumerable<BaseTypeDeclarationSyntax> accessorDeclarations =
            (definition.Accessors ?? []).Select(
                accessor =>
                    ClassDeclaration(accessor.Name)
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
                                           MethodDeclaration(method.ReturnType.ToType(), Identifier(method.Name))
                                              .AddModifiers(Token(SyntaxKind.PublicKeyword),
                                                            Token(SyntaxKind.StaticKeyword))
                                              .AddParameterListParameters(
                                                   method.Parameters.Select(InterfaceParameter).ToArray()
                                               )
                                              .WithExpressionBody(
                                                   ArrowExpressionClause(
                                                       InvocationExpression(ParseExpression($"Instance.{method.Name}"))
                                                          .AddArgumentListArguments(
                                                               method.Parameters.Select(InterfaceArgument).ToArray()
                                                           )
                                                   )
                                               )
                                              .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                                              .WithLeadingTrivia(Comment($"/// <summary>{method.Description ?? ""}</summary>"))
                                   ).ToArray<MemberDeclarationSyntax>())
            );

        return accessorDeclarations.Append(interfaceDeclaration);
    }

    private AttributeListSyntax DllImportAttribute(string entryPoint) =>
        AttributeList()
           .AddAttributes(
                Attribute(IdentifierName("DllImport"))
                   .AddArgumentListArguments(
                        AttributeArgument(ParseExpression("Platform.LibraryName")),
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

    private ParameterSyntax InterfaceParameter(SteamApiDefinition.InterfaceDefinition.Method.Parameter parameter) =>
        Parameter(Identifier(parameter.Name))
           .WithType(parameter.Type.ToType())
           .AddModifiers(parameter.Type.EndsWith('&')
                             ? [Token(SyntaxKind.RefKeyword)]
                             : []);

    private ArgumentSyntax InterfaceArgument(SteamApiDefinition.InterfaceDefinition.Method.Parameter parameter) =>
        Argument(IdentifierName(parameter.Name))
           .WithRefKindKeyword(parameter.Type.EndsWith('&')
                                   ? Token(SyntaxKind.RefKeyword)
                                   : Token(SyntaxKind.None));

    private string InterfaceName(string name) => name;
    private string WrapperName(string   name) => name.StripPrefix("I");
}