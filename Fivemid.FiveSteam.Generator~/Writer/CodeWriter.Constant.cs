using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Fivemid.FiveSteam.Generator;

public partial class CodeWriter {
    private TypeDeclarationSyntax Constants(IEnumerable<SteamApiDefinition.Const> definitions) =>
        TypeDeclaration(SyntaxKind.StructDeclaration, "FiveSteamConstants")
           .AddModifiers(Token(SyntaxKind.PublicKeyword))
           .AddMembers(definitions.Select(Constant).ToArray<MemberDeclarationSyntax>());

    private FieldDeclarationSyntax Constant(SteamApiDefinition.Const definition) {
        ExpressionSyntax initializer;

        if (constantInitializerOverrides.TryGetValue(definition.Name, out string? initializerString)) {
            initializer = ParseExpression(initializerString);
        } else {
            initializer = definition.Value.ToInitializerValue();
        }

        return FieldDeclaration(
                VariableDeclaration(definition.Type.ToType())
                   .AddVariables(VariableDeclarator(definition.Name)
                                    .WithInitializer(
                                         EqualsValueClause(initializer)))
            ).AddModifiers(Token(SyntaxKind.PublicKeyword),
                           Token(SyntaxKind.StaticKeyword),
                           Token(SyntaxKind.ReadOnlyKeyword))
             .WithLeadingTrivia(Comment($"/// <summary>{definition.Name}</summary>")); // TODO sometimes use const
    }

    private static Dictionary<string, string> constantInitializerOverrides = new() {
        { "HSERVERQUERY_INVALID", "unchecked((int)0xffffffff)" },
        { "k_SteamItemInstanceIDInvalid", "~0ul" },
        { "k_SteamDatagramPOPID_dev", "((uint)'d' << 16) | ((uint)'e' << 8) | (uint)'v'" }
    };
}