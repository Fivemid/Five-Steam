using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Fivemid.FiveSteam.Generator;

public partial class CodeWriter {
    private BaseTypeDeclarationSyntax FunctionPointers(IEnumerable<FunctionPointerType> types) =>
        StructDeclaration("FunctionPointerDelegates")
           .AddModifiers(Token(SyntaxKind.PublicKeyword))
           .AddMembers(types.Select(FunctionPointer).ToArray<MemberDeclarationSyntax>());

    private DelegateDeclarationSyntax FunctionPointer(FunctionPointerType type) {
        return DelegateDeclaration(ParseTypeName("void"), type.DelegateType.Identifier)
              .AddModifiers(Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.UnsafeKeyword))
              .AddParameterListParameters(type.Parameters
                                              .Select((p, index) => Parameter(Identifier($"arg{index}")).WithType(p))
                                              .ToArray())
              .WithLeadingTrivia(
                   Comment(
                       $"/// <summary>{type.NativeType} -> {type.Parameters.Length} -> {type.Parameters.Last().ToString()}</summary>"));
    }
}