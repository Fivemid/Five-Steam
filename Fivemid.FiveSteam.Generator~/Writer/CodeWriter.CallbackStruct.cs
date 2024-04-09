using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Fivemid.FiveSteam.Generator;

public partial class CodeWriter {
    private void Register(IEnumerable<SteamApiDefinition.CallbackStructDefinition> definitions) {
        foreach (SteamApiDefinition.CallbackStructDefinition definition in
                 definitions.Where(d => !d.Name.IsPrimitive()))
            Register(definition);
    }

    private void Register(SteamApiDefinition.CallbackStructDefinition definition) {
        Convert.RegisterType(definition.Name, IdentifierName(CallbackStructName(definition.Name)));

        foreach (SteamApiDefinition.EnumDefinition subEnum in definition.Enums ?? []) {
            Convert.RegisterType($"{definition.Name}::{subEnum.Name}", 
                                 ParseTypeName($"{CallbackStructName(definition.Name)}.{EnumName(subEnum.Name)}"));
        }
    }

    private BaseTypeDeclarationSyntax[] CallbackStructs(
        IEnumerable<SteamApiDefinition.CallbackStructDefinition> definitions) =>
        definitions.Select(CallbackStruct).ToArray();

    private BaseTypeDeclarationSyntax CallbackStruct(SteamApiDefinition.CallbackStructDefinition definition) {
        string name = CallbackStructName(definition.Name);

        // TODO use callback id
        return StructDeclaration(name)
              .AddModifiers(Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.UnsafeKeyword))
              .AddMembers(
                   definition.Fields.Select(
                       field =>
                           FieldDeclaration(
                                   VariableDeclaration(field.Type.ToType())
                                      .AddVariables(VariableDeclarator(field.Name.StripPrefix("m_"))))
                              .AddModifiers(Token(SyntaxKind.PublicKeyword))
                              .WithLeadingTrivia(Comment($"/// <summary>{field.Type} {field.Name}</summary>"))
                   ).ToArray<MemberDeclarationSyntax>()
               )
              .AddMembers(Enums(definition.Enums ?? []).ToArray<MemberDeclarationSyntax>())
              .WithLeadingTrivia(Comment($"/// <summary>{definition.Name}</summary>"));
    }

    private string CallbackStructName(string name) => name.StripSuffix("_t");
}