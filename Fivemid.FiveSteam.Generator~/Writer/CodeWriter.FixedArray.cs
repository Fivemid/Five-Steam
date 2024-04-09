using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Fivemid.FiveSteam.Generator;

public partial class CodeWriter {
    private BaseTypeDeclarationSyntax[] FixedArrays(IEnumerable<FixedArrayType> types) =>
        types.Select(FixedArray).ToArray();

    private BaseTypeDeclarationSyntax FixedArray(FixedArrayType type) {
        return StructDeclaration(type.TypeIdentifier)
              .AddModifiers(Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.UnsafeKeyword))
              .AddMembers(FieldDeclaration(
                                  VariableDeclaration(type.ElementType)
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