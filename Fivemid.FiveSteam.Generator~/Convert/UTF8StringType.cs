using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Fivemid.FiveSteam.Generator;

public readonly record struct UTF8StringType(int Size, string NativeType) : IType {
    public string     TypeIdentifier => $"UTF8String{Size}";
    public TypeSyntax ToType()       => IdentifierName(TypeIdentifier);
}