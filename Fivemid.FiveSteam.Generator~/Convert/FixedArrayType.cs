using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Fivemid.FiveSteam.Generator;

public readonly record struct FixedArrayType(TypeSyntax ElementType, int Size, string NativeType) : IType {
    public string     TypeIdentifier => $"FixedArray_{ElementType.ToString()}{Size}";
    public TypeSyntax ToType()       => IdentifierName(TypeIdentifier);
    
    public override int GetHashCode() =>
        NativeType.GetHashCode();

    public bool Equals(FixedArrayType other) =>
        NativeType.Equals(other.NativeType);
}