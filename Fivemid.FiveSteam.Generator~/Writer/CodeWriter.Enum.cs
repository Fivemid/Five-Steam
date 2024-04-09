using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Fivemid.FiveSteam.Generator;

public partial class CodeWriter {
    private void Register(IEnumerable<SteamApiDefinition.EnumDefinition> definitions) {
        foreach (SteamApiDefinition.EnumDefinition definition in definitions.Where(d => !d.Name.IsPrimitive()))
            Register(definition);
    }

    private void Register(SteamApiDefinition.EnumDefinition definition) =>
        Convert.RegisterType(definition.Name, IdentifierName(EnumName(definition.Name)));

    private BaseTypeDeclarationSyntax[] Enums(IEnumerable<SteamApiDefinition.EnumDefinition> definitions) =>
        definitions.Select(Enum).ToArray();

    private BaseTypeDeclarationSyntax Enum(SteamApiDefinition.EnumDefinition definition) {
        string name = EnumName(definition.Name);
        return EnumDeclaration(name)
              .AddModifiers(Token(SyntaxKind.PublicKeyword))
              .WithBaseList(BaseList().AddTypes(SimpleBaseType(ParseTypeName("int"))))
              .AddMembers(
                   definition.Values.Select(
                                  value =>
                                      EnumMemberDeclaration(
                                              value.Name.StripPrefix("k_E")
                                                   .StripPrefix(name)
                                                   .StripPrefix(definition.Name)
                                                   .StripPrefix("_")
                                                   .PreventStartByDigit()
                                          )
                                         .WithEqualsValue(
                                              EqualsValueClause(value.Value.ToInitializerValue()))
                                         .WithLeadingTrivia(Comment($"/// <summary>{value.Name}</summary>"))
                              )
                             .ToArray()
               )
              .WithLeadingTrivia(Comment($"/// <summary>{definition.Name}</summary>"));
    }

    private static Dictionary<string, string> enumNameOverrides = new() {
        { "ESteamNetworkingConfigValue", "SteamNetworkingConfigValueType" },
        { "ECheckFileSignature", "CheckFileSignatureType" },
        { "ERemoteStorageLocalFileChange", "RemoteStorageLocalFileChangeType" }
    };

    private string EnumName(string name) =>
        enumNameOverrides.GetValueOrDefault(name, name.StripSuffix("_t").StripPrefix("E"));
}