using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Fivemid.FiveSteam.Generator;

public readonly partial record struct FunctionPointerType(TypeSyntax[] Parameters, string NativeType) : IType {
    public TypeSyntax ToType() =>
        ParseTypeName($"global::Unity.Burst.FunctionPointer<FunctionPointerDelegates.{DelegateType}>");

    public IdentifierNameSyntax DelegateType => IdentifierName(
        string.Join('_', Parameters.Select(p =>
                                               NonWordRegex()
                                                  .Replace(p.ToString().Replace("*", "Ptr"), "_")
                    )));

    public override int GetHashCode() =>
        NativeType.GetHashCode();

    public bool Equals(FunctionPointerType other) =>
        NativeType.Equals(other.NativeType);

    [GeneratedRegex(@"\W")]
    private static partial Regex NonWordRegex();
}