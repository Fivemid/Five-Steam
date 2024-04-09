using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Fivemid.FiveSteam.Generator;

public partial class CodeWriter {
    private BaseTypeDeclarationSyntax[] UTF8Strings(IEnumerable<UTF8StringType> types) =>
        types.Select(UTF8String).ToArray();

    private BaseTypeDeclarationSyntax UTF8String(UTF8StringType type) {
        return StructDeclaration(type.TypeIdentifier)
              .AddModifiers(Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.UnsafeKeyword))
              .AddMembers(FieldDeclaration(
                                  VariableDeclaration(ParseTypeName("char"))
                                     .AddVariables(VariableDeclarator("values")
                                                      .AddArgumentListArguments(
                                                           Argument(LiteralExpression(
                                                                        SyntaxKind.NumericLiteralExpression,
                                                                        Literal(type.Size)))))
                              )
                             .AddModifiers(Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.FixedKeyword)))
              .WithLeadingTrivia(Comment($"/// <summary>{type.NativeType}</summary>"));
    }
}