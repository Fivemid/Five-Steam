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
              .AddAttributeLists(StructLayoutAttribute())
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
              .AddMembers(MethodDeclaration(ParseTypeName("string"), Identifier("ToString"))
                         .AddModifiers(Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.OverrideKeyword))
                         .AddBodyStatements(
                              ParseStatement("""
                                             fixed (char* ptr = values)
                                                return Marshal.PtrToStringUTF8((IntPtr)ptr);
                                             """)
                          )
               )
              .WithLeadingTrivia(Comment($"/// <summary>{type.NativeType}</summary>"));
    }
}