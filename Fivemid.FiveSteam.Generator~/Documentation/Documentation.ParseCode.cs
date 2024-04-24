using System.Text.RegularExpressions;
using HtmlAgilityPack;

namespace Fivemid.FiveSteam.Generator;

public partial class Documentation {
    private Object? ParseCodeDefinition(HtmlNode node) {
        string description;
        
        {
            List<HtmlNode> descriptionNodes = [];
            HtmlNode       element          = node;
            while (element.PreviousSibling != null
                && !element.PreviousSibling.Name.Equals("h2")
                && !element.PreviousSibling.HasClass("bb_code")) {
                element = element.PreviousSibling;
            }
            
            do {
                if (element != node)
                    descriptionNodes.Add(element);
                element = element.NextSibling;
            } while (element != null
                  && !element.Name.Equals("h2")
                  && (element == node || !element.HasClass("bb_code")));
            
            description = FormatDescription(descriptionNodes);
        }
        
        string?      name     = null;
        List<Object> children = [];
        CodeLine[]   lines    = node.InnerText.Split('\n').Select(CodeLine.Parse).ToArray();
        
        if (lines[0] is not CodeLine.Code firstLine)
            return null;
        
        
        if (firstLine.Content.StartsWith("struct ")) {
            name = firstLine.Content.StripPrefix("struct ");
            List<CodeLine.Comment> previousComments = [];
            foreach (CodeLine line in lines) {
                if (line is CodeLine.Code code) {
                    Match match = CodeStructFieldRegex().Match(code.Content);
                    if (match.Success) {
                        children.Add(
                            new Object(
                                Name: match.Groups[1].Value,
                                Description: code.EndOfLineComment ??
                                             string.Join('\n', previousComments.Select(c => c.Text)),
                                Type: null,
                                Value: null,
                                BaseType: null,
                                Children: []
                            ));
                    }
                }
                
                if (line is CodeLine.Comment comment)
                    previousComments.Add(comment);
                else
                    previousComments.Clear();
            }
        } else if (firstLine.Content.StartsWith("enum ")) {
            name = firstLine.Content.StripPrefix("enum ");
            List<CodeLine.Comment> previousComments = [];
            foreach (CodeLine line in lines) {
                if (line is CodeLine.Code code) {
                    Match match = CodeEnumValueRegex().Match(code.Content);
                    if (match.Success) {
                        children.Add(
                            new Object(
                                Name: match.Groups[1].Value,
                                Description: code.EndOfLineComment ??
                                             string.Join('\n', previousComments.Select(c => c.Text)),
                                Type: null,
                                Value: match.Groups[2].Value,
                                BaseType: null,
                                Children: []
                            ));
                    }
                }
                
                if (line is CodeLine.Comment comment)
                    previousComments.Add(comment);
                else
                    previousComments.Clear();
            }
        } else {
            Match match = CodeConstRegex().Match(firstLine.Content);
            if (match.Success) {
                name = match.Groups[1].Value;
            }
        }
        
        if (name is null)
            return null;
        
        return new Object(
            Name: name,
            Description: description,
            Type: null,
            Value: null,
            BaseType: null,
            Children: children.ToArray()
        );
    }
    
    private record CodeLine {
        public record Code(string Content, string? EndOfLineComment) : CodeLine;
        
        public record Comment(string Text) : CodeLine;
        
        public record Empty : CodeLine;
        
        public static CodeLine Parse(string line) {
            line = line.Trim();
            if (line.Length == 0)
                return new Empty();
            if (line.StartsWith("//"))
                return new Comment(line.StripPrefix("//")
                                       .StripPrefix("/")
                                       .Trim());
            if (line.Contains("//")) {
                string[] split = line.Split("//");
                return new Code(split[0].Trim(), split[1].StripPrefix("/").Trim());
            }
            
            return new Code(line, null);
        }
    }
    
    [GeneratedRegex(@"(\w+) = (.+),?")]
    private static partial Regex CodeEnumValueRegex();
    
    [GeneratedRegex(@"\w+ [*&]*(\w+)(\[\d*\])?;")]
    private static partial Regex CodeStructFieldRegex();
    
    [GeneratedRegex(@"const \w+ (\w+) = .*;")]
    private static partial Regex CodeConstRegex();
}