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
        ExpressionSyntax initializer =
            constantInitializerOverrides.TryGetValue(definition.Name, out string? initializerString)
                ? ParseExpression(initializerString)
                : definition.Value.ToInitializerValue();
        
        TypeSyntax type = definition.Type.ToType();
        return FieldDeclaration(
                VariableDeclaration(type)
                   .AddVariables(VariableDeclarator(definition.Name)
                                    .WithInitializer(
                                         EqualsValueClause(initializer)))
            ).AddModifiers(Token(SyntaxKind.PublicKeyword))
             .AddModifiers(
                  definition.Type.IsPrimitive()
                      ? [Token(SyntaxKind.ConstKeyword)]
                      : [Token(SyntaxKind.StaticKeyword), Token(SyntaxKind.ReadOnlyKeyword)]
              )
             .WithLeadingTrivia(SimpleDescriptionDocumentation(definition.Name));
    }
    
    private SyntaxTrivia[] SimpleDescriptionDocumentation(
        string objectPath
    ) {
        if (Documentation.VALUE.GetObject(objectPath) is { } documentation)
            return DocComment($"""
                               <summary>{documentation.Description}</summary>
                               """);
        
        return DocComment($"missing documentation for {objectPath}");
    }
    
    private static readonly Dictionary<string, string> constantInitializerOverrides = new() {
        { "HSERVERQUERY_INVALID", "unchecked((int)0xffffffff)" },
        { "k_SteamItemInstanceIDInvalid", "~0ul" },
        { "k_SteamDatagramPOPID_dev", "((uint)'d' << 16) | ((uint)'e' << 8) | (uint)'v'" }
    };
}