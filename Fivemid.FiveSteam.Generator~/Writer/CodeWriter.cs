using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Fivemid.FiveSteam.Generator;

public partial class CodeWriter(string baseFolder) {
    private readonly HashSet<string> wroteFiles = [];
    
    public void Write(SteamApiDefinition apiDefinition) {
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
        
        ClearOldFiles();
    }
    
    private void ClearOldFiles() {
        foreach (string existingFile in Directory.EnumerateFiles(baseFolder, "*.cs", SearchOption.AllDirectories)) {
            if (!wroteFiles.Contains(existingFile)) {
                File.Delete(existingFile);
                string metaFile = existingFile.StripPrefix(".cs") + ".meta";
                if (File.Exists(metaFile))
                    File.Delete(metaFile);
            }
        }
        
        ClearEmptyDirectories(baseFolder);
        
        return;
        
        void ClearEmptyDirectories(string directory) {
            foreach (string subDirectory in Directory.EnumerateDirectories(directory)) {
                ClearEmptyDirectories(subDirectory);
                if (!Directory.EnumerateFileSystemEntries(subDirectory).Any())
                    Directory.Delete(subDirectory);
            }
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
        string file = Path.Combine(folder, $"{declaration.Identifier}.cs");
        File.WriteAllText(
            file,
            sourceText
        );
        wroteFiles.Add(file);
    }
    
    private SyntaxTrivia[] DocComment(string text) =>
        text.Split("\n")
            .Select(line => Comment($"/// {line}"))
            .ToArray();
}