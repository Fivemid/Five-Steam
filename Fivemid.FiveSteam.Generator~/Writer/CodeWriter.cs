using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Fivemid.FiveSteam.Generator;

public partial class CodeWriter(string baseFolder) {
    public void Write(SteamApiDefinition apiDefinition) {
        ClearBaseFolder();
        Register(apiDefinition);

        Write(Path.Combine(baseFolder, "Enums"),      Enums(apiDefinition.Enums));
        Write(Path.Combine(baseFolder, "TypeDefs"),   TypeDefs(apiDefinition.TypeDefs));
        Write(Path.Combine(baseFolder, "Structs"),    Structs(apiDefinition.Structs));
        Write(Path.Combine(baseFolder, "Callbacks"),  CallbackStructs(apiDefinition.CallbackStructs));
        Write(Path.Combine(baseFolder, "Interfaces"), Interfaces(apiDefinition.Interfaces));

        Write(baseFolder, Constants(apiDefinition.Constants));

        Write(Path.Combine(baseFolder, "Utility"), UTF8Strings(Convert.seenUTF8StringTypes));
        Write(Path.Combine(baseFolder, "Utility"), FixedArrays(Convert.seenFixedArrayTypes));
        Write(Path.Combine(baseFolder, "Utility"), FunctionPointers(Convert.seenFunctionPointerTypes));
    }

    private void ClearBaseFolder() {
        foreach (string existingFile in Directory.EnumerateFiles(baseFolder, "*", SearchOption.AllDirectories)) {
            File.Delete(existingFile);
        }

        foreach (var existingDirectory in Directory.EnumerateDirectories(baseFolder)) {
            Directory.Delete(existingDirectory, true);
        }
    }

    private void Register(SteamApiDefinition apiDefinition) {
        Register(apiDefinition.Enums);
        Register(apiDefinition.TypeDefs);
        Register(apiDefinition.Structs);
        Register(apiDefinition.CallbackStructs);
        Register(apiDefinition.Interfaces);
    }

    private void Write(string folder, BaseTypeDeclarationSyntax[] declarations) {
        if (!Directory.Exists(folder))
            Directory.CreateDirectory(folder);
        foreach (BaseTypeDeclarationSyntax declaration in declarations)
            Write(folder, declaration);
    }

    private void Write(string folder, BaseTypeDeclarationSyntax declaration) {
        string sourceText = CompilationUnit()
                           .AddUsings(
                                UsingDirective(IdentifierName("System")),
                                UsingDirective(IdentifierName("System.Runtime.InteropServices"))
                            )
                           .AddMembers(
                                NamespaceDeclaration(
                                        IdentifierName("Fivemid.FiveSteam"))
                                   .AddMembers(declaration)
                            )
                           .NormalizeWhitespace()
                           .GetText()
                           .ToString();
        File.WriteAllText(
            Path.Combine(folder, $"{declaration.Identifier}.cs"),
            sourceText
        );
    }
}