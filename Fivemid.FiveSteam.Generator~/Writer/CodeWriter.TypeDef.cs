using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Fivemid.FiveSteam.Generator;

public partial class CodeWriter {
    private void Register(IEnumerable<SteamApiDefinition.TypeDef> definitions) {
        foreach (SteamApiDefinition.TypeDef definition in definitions.Where(d => !d.Name.IsPrimitive()))
            Register(definition);
    }
    
    private void Register(SteamApiDefinition.TypeDef definition) =>
        Convert.RegisterType(definition.Name, TypeDefName(definition.Name));
    
    private BaseTypeDeclarationSyntax[] TypeDefs(IEnumerable<SteamApiDefinition.TypeDef> definitions) =>
        definitions.Where(d => !d.Name.IsPrimitive()).Select(TypeDef).ToArray();
    
    private BaseTypeDeclarationSyntax TypeDef(SteamApiDefinition.TypeDef definition) {
        IdentifierNameSyntax name      = TypeDefName(definition.Name);
        TypeSyntax           valueType = definition.Type.ToType();
        
        Convert.RegisterTypeDef(name, valueType);
        bool equatable = !valueType.ToString().StartsWith("global::Unity.Burst.FunctionPointer")
                      && !valueType.ToString().Contains('*')
                      && !valueType.ToString().StartsWith("UTF8String");
        
        return StructDeclaration(name.Identifier)
              .AddAttributeLists(StructLayoutAttribute())
              .AddModifiers(Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.UnsafeKeyword))
              .WithBaseList(equatable
                                ? BaseList().AddTypes(
                                    SimpleBaseType(GenericName("IEquatable").AddTypeArgumentListArguments(name)),
                                    SimpleBaseType(GenericName("IComparable").AddTypeArgumentListArguments(name))
                                )
                                : null)
              .AddMembers(FieldDeclaration(
                                  VariableDeclaration(definition.Type.ToType())
                                     .AddVariables(VariableDeclarator("value"))
                              )
                             .AddModifiers(Token(SyntaxKind.PublicKeyword)))
              .AddMembers(ParseMemberDeclaration(
                              $"public static implicit operator {name}({valueType} value) => new() {{ value = value }};")
                          !)
              .AddMembers(ParseMemberDeclaration(
                              $"public static implicit operator {valueType}({name} value) => value.value;")
                          !)
              .AddMembers(
                   equatable
                       ? [
                           ParseMemberDeclaration(
                               $"public override string ToString() => value.ToString();")
                           !,
                           ParseMemberDeclaration(
                               $"public override int GetHashCode() => value.GetHashCode();")
                           !,
                           ParseMemberDeclaration(
                               $"public override bool Equals(object p) => this.Equals(({name}) p);")
                           !,
                           ParseMemberDeclaration(
                               $"public bool Equals({name} p) => p.value == value;")
                           !,
                           ParseMemberDeclaration(
                               $"public static bool operator ==({name} a, {name} b) => a.Equals(b);")
                           !,
                           ParseMemberDeclaration(
                               $"public static bool operator !=({name} a, {name} b) => !a.Equals(b);")
                           !,
                           ParseMemberDeclaration(
                               $"public int CompareTo({name} other) => value.CompareTo(other.value);")
                           !
                       ]
                       : []
               )
              .WithLeadingTrivia(SimpleDescriptionDocumentation(definition.Name));
    }
    
    private IdentifierNameSyntax TypeDefName(string name) => IdentifierName(name.StripSuffix("_t"));
}