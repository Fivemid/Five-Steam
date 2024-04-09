using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Fivemid.FiveSteam.Generator;

public partial class CodeWriter {
    private void Register(IEnumerable<SteamApiDefinition.StructDefinition> definitions) {
        foreach (SteamApiDefinition.StructDefinition definition in definitions.Where(d => !d.Name.IsPrimitive()))
            Register(definition);
    }

    private void Register(SteamApiDefinition.StructDefinition definition) =>
        Convert.RegisterType(definition.Name, IdentifierName(StructName(definition.Name)));

    private BaseTypeDeclarationSyntax[] Structs(IEnumerable<SteamApiDefinition.StructDefinition> definitions) =>
        definitions.Where(d => !d.Name.IsPrimitive()).Select(Struct).ToArray();

    private BaseTypeDeclarationSyntax Struct(SteamApiDefinition.StructDefinition definition) {
        string name = StructName(definition.Name);

        return StructDeclaration(name)
              .AddModifiers(Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.UnsafeKeyword))
              .AddMembers(
                   definition.Fields.Where(f => !excludeFieldType.Contains(f.Type)).Select(
                       field =>
                           FieldDeclaration(
                                   VariableDeclaration(field.Type.ToType())
                                      .AddVariables(VariableDeclarator(field.Name.StripPrefix("m_"))))
                              .AddModifiers(Token(SyntaxKind.PublicKeyword))
                              .WithLeadingTrivia(Comment($"/// <summary>{field.Type} {field.Name}</summary>"))
                   ).ToArray<MemberDeclarationSyntax>()
               )
              .WithLeadingTrivia(Comment($"/// <summary>{definition.Name}</summary>"));
    }

    private static HashSet<string> excludeFieldType = ["SteamInputActionEvent_t::AnalogAction_t"];

    private string StructName(string name) => name.StripSuffix("_t");
}