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
    
    private BaseTypeDeclarationSyntax[] CallbackStructs(SteamApiDefinition.CallbackStructDefinition[] definitions) =>
        definitions.Select(CallbackStruct)
                   .Append(CallbackIdentifier(definitions))
                   .ToArray();
    
    private BaseTypeDeclarationSyntax CallbackStruct(SteamApiDefinition.CallbackStructDefinition definition) {
        string name = CallbackStructName(definition.Name);
        
        return StructDeclaration(name)
              .AddAttributeLists(StructLayoutAttribute(definition.Fields.Length == 0))
              .AddModifiers(Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.UnsafeKeyword))
              .AddMembers(
                   FieldDeclaration(VariableDeclaration(IdentifierName("CallbackIdentifier"))
                                       .AddVariables(VariableDeclarator("IDENTIFIER")
                                                        .WithInitializer(
                                                             EqualsValueClause(
                                                                 ParseExpression($"CallbackIdentifier.{name}")))))
                      .AddModifiers(Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.StaticKeyword),
                                    Token(SyntaxKind.ReadOnlyKeyword))
               )
              .AddMembers(
                   definition.Fields.Select(
                       field =>
                           FieldDeclaration(
                                   VariableDeclaration(field.Type.ToType())
                                      .AddVariables(VariableDeclarator(field.Name.StripPrefix("m_"))))
                              .AddModifiers(Token(SyntaxKind.PublicKeyword))
                              .WithLeadingTrivia(SimpleDescriptionDocumentation($"{definition.Name}.{field.Name}"))
                   ).ToArray<MemberDeclarationSyntax>()
               )
              .AddMembers(Enums(definition.Enums ?? []).ToArray<MemberDeclarationSyntax>())
              .WithLeadingTrivia(SimpleDescriptionDocumentation(definition.Name));
    }
    
    private BaseTypeDeclarationSyntax CallbackIdentifier(
        IEnumerable<SteamApiDefinition.CallbackStructDefinition> definitions) =>
        EnumDeclaration("CallbackIdentifier")
           .AddModifiers(Token(SyntaxKind.PublicKeyword))
           .WithBaseList(BaseList().AddTypes(SimpleBaseType(ParseTypeName("int"))))
           .AddMembers(
                definitions.Select(
                                definition =>
                                    EnumMemberDeclaration(CallbackStructName(definition.Name))
                                       .WithEqualsValue(
                                            EqualsValueClause(
                                                LiteralExpression(SyntaxKind.NumericLiteralExpression,
                                                                  Literal(definition.CallbackId))))
                                       .WithLeadingTrivia(Comment($"/// <summary>{definition.Name}</summary>"))
                            )
                           .ToArray()
            );
    
    private string CallbackStructName(string name) => name.StripSuffix("_t");
}