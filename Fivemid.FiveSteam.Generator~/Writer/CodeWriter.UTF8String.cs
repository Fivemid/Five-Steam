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
              .AddBaseListTypes(SimpleBaseType(ParseTypeName("global::Unity.Collections.IUTF8Bytes")))
              .AddMembers(FieldDeclaration(
                                  VariableDeclaration(ParseTypeName("char"))
                                     .AddVariables(VariableDeclarator("values")
                                                      .AddArgumentListArguments(
                                                           Argument(LiteralExpression(
                                                                        SyntaxKind.NumericLiteralExpression,
                                                                        Literal(type.Size)))))
                              )
                             .AddModifiers(Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.FixedKeyword)))
              .AddMembers(
                   MethodDeclaration(ParseTypeName("string"), Identifier("ToString"))
                      .AddModifiers(Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.OverrideKeyword))
                      .AddBodyStatements(
                           ParseStatement("""
                                          fixed (char* ptr = values)
                                             return Marshal.PtrToStringUTF8((IntPtr)ptr);
                                          """)
                       )
               )
              .AddMembers(
                   PropertyDeclaration(ParseTypeName("bool"), Identifier("IsEmpty"))
                      .AddModifiers(Token(SyntaxKind.PublicKeyword))
                      .WithExpressionBody(
                           ArrowExpressionClause(
                               ParseExpression("""values[0] == '\0'""")
                           )
                       )
                      .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
               )
              .AddMembers(
                   MethodDeclaration(ParseTypeName("byte*"), Identifier("GetUnsafePtr"))
                      .AddModifiers(Token(SyntaxKind.PublicKeyword))
                      .AddBodyStatements(
                           ParseStatement("""
                                          fixed (char* ptr = values)
                                             return (byte*)ptr;
                                          """)
                       )
               )
              .AddMembers(
                   MethodDeclaration(ParseTypeName("bool"), Identifier("TryResize"))
                      .AddModifiers(Token(SyntaxKind.PublicKeyword))
                      .AddParameterListParameters(
                           Parameter(Identifier("newLength"))
                              .WithType(ParseTypeName("int")),
                           Parameter(Identifier("clearOptions"))
                              .WithType(ParseTypeName("global::Unity.Collections.NativeArrayOptions"))
                              .WithDefault(
                                   EqualsValueClause(
                                       ParseExpression("global::Unity.Collections.NativeArrayOptions.ClearMemory")))
                       )
                      .WithExpressionBody(
                           ArrowExpressionClause(
                               ParseExpression("false")
                           )
                       )
                      .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
               )
              .WithLeadingTrivia(Comment($"/// <summary>{type.NativeType}</summary>"));
    }
}