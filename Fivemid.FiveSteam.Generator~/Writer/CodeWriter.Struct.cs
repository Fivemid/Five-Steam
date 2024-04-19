using System.Dynamic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Fivemid.FiveSteam.Generator;

public partial class CodeWriter {
    private void Register(IEnumerable<SteamApiDefinition.StructDefinition> definitions) {
        foreach (SteamApiDefinition.StructDefinition definition in definitions.Where(d => !d.Name.IsPrimitive()))
            Register(definition);
    }
    
    private void Register(SteamApiDefinition.StructDefinition definition) =>
        Convert.RegisterType(definition.Name, IdentifierName(StructName(definition.Name)));
    
    private BaseTypeDeclarationSyntax[] Structs(IEnumerable<SteamApiDefinition.StructDefinition> definitions) =>
        definitions.Where(d => !d.Name.IsPrimitive()).Select(Struct).ToArray();
    
    private BaseTypeDeclarationSyntax Struct(SteamApiDefinition.StructDefinition definition) {
        string name = StructName(definition.Name);
        
        return StructDeclaration(name)
              .AddModifiers(Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.UnsafeKeyword))
              .AddMembers(
                   definition.Fields.Where(f => !excludeFieldType.Contains(f.Type)).Select(
                       field =>
                           FieldDeclaration(
                                   VariableDeclaration(field.Type.ToType())
                                      .AddVariables(VariableDeclarator(field.Name.StripPrefix("m_"))))
                              .AddModifiers(Token(SyntaxKind.PublicKeyword))
                              .WithLeadingTrivia(Comment($"/// <summary>{field.Type} {field.Name}</summary>"))
                   ).ToArray<MemberDeclarationSyntax>()
               )
              .AddMembers((definition.Methods ?? []).Select(
                              method =>
                                  MethodDeclaration(method.ReturnType.ToType(), MethodName(method.Name))
                                     .AddAttributeLists(
                                          DllImportAttribute(method.FlatName)
                                      )
                                     .AddModifiers(Token(SyntaxKind.InternalKeyword), Token(SyntaxKind.StaticKeyword),
                                                   Token(SyntaxKind.ExternKeyword))
                                     .AddParameterListParameters(
                                          Parameter(Identifier("self")).WithType(PointerType(IdentifierName(name))))
                                     .AddParameterListParameters(
                                          method.Parameters.Select(MethodParameter).ToArray()
                                      )
                                     .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                          ).ToArray<MemberDeclarationSyntax>())
              .AddMembers((definition.Methods ?? []).Select(
                              method => {
                                  InvocationExpressionSyntax invocation =
                                      InvocationExpression(IdentifierName(MethodName(method.Name)))
                                         .AddArgumentListArguments(
                                              Argument(IdentifierName("self"))
                                          )
                                         .AddArgumentListArguments(
                                              method.Parameters.Select(MethodArgument).ToArray()
                                          );
                                  return MethodDeclaration(method.ReturnType.ToType(), MethodName(method.Name))
                                        .AddModifiers(Token(SyntaxKind.PublicKeyword))
                                        .AddParameterListParameters(
                                             method.Parameters.Select(MethodParameter).ToArray()
                                         )
                                        .AddBodyStatements(
                                             FixedStatement(
                                                 VariableDeclaration(PointerType(IdentifierName(name)))
                                                    .AddVariables(VariableDeclarator("self")
                                                                     .WithInitializer(
                                                                          EqualsValueClause(PrefixUnaryExpression(
                                                                                  SyntaxKind.AddressOfExpression,
                                                                                  ThisExpression())))),
                                                 method.ReturnType.Equals("void")
                                                     ? ExpressionStatement(invocation)
                                                     : ReturnStatement(invocation)
                                             )
                                         );
                              }).ToArray<MemberDeclarationSyntax>())
              .WithLeadingTrivia(Comment($"/// <summary>{definition.Name}</summary>"));
    }
    
    private static HashSet<string> excludeFieldType = ["SteamInputActionEvent_t::AnalogAction_t"];
    
    private string StructName(string name) => name.StripSuffix("_t");
}