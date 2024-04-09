using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Fivemid.FiveSteam.Generator;

public interface IType {
    public TypeSyntax ToType();
    public string     NativeType { get; }
}