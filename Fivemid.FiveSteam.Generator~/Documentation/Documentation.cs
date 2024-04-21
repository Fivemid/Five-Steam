using System.Text;
using HtmlAgilityPack;

namespace Fivemid.FiveSteam.Generator;

public class Documentation {
    private static HashSet<string> exclude = [];
    
    public static readonly Documentation VALUE =
        new("Data/SteamworksDocumentation/docs/api");
    
    public Documentation(string folder) {
        foreach (string file in Directory.EnumerateFiles(folder, "*.html", SearchOption.AllDirectories)) {
            if (exclude.Contains(Path.GetFileName(file)))
                continue;
            Parse(file);
        }
    }
    
    private void Parse(string file) {
        HtmlDocument doc = new();
        doc.Load(file);
        
        Interface @interface = ParseInterface(doc);
        interfaces.Add(@interface.Name, @interface);
        AddObject(@interface, @interface.Name);
        foreach (Object @object in @interface.Objects)
            AddObject(@object, @object.Name);
        return;
        
        void AddObject(Object @object, string path) {
            objects.TryAdd(path, @object);
            foreach (Object child in @object.Children)
                AddObject(child, $"{path}.{child.Name}");
        }
    }
    
    private Interface ParseInterface(HtmlDocument doc) {
        HtmlNode header = doc.DocumentNode.SelectSingleNode("/h1");
        string name = header
                     .InnerText.StripSuffix(" Interface").Trim();
        List<HtmlNode> descriptionNodes = [];
        
        {
            HtmlNode following = header.NextSibling;
            while (following != null && !following.Name.Equals("h2")) {
                descriptionNodes.Add(following);
                following = following.NextSibling;
            }
        }
        
        string description = FormatDescription(descriptionNodes);
        
        Object[] objects =
            (doc.DocumentNode.SelectNodes("""/h2[@class="bb_subsection"]""")
               ?.ToArray() ?? [])
           .Select(ParseSubsection)
           .ToArray();
        
        Object[] looseObjects =
            (doc.DocumentNode.SelectNodes("""/table""")?.ToArray() ?? [])
           .Where(t => !usedTables.Contains(t))
           .SelectMany(ParseTable)
           .ToArray();
        
        return new Interface(name, description, objects.Concat(looseObjects).ToArray());
    }
    
    private readonly HashSet<HtmlNode> usedTables = [];
    
    private Object ParseSubsection(HtmlNode node) {
        string name = node.InnerText.Trim();
        
        List<HtmlNode> descriptionNodes = [];
        HtmlNode?      childrenNode     = null;
        
        {
            HtmlNode following = node.NextSibling;
            while (following != null && !following.Name.Equals("h2")) {
                if (following.Name.Equals("table"))
                    childrenNode = following;
                else
                    descriptionNodes.Add(following);
                following = following.NextSibling;
            }
        }
        
        string description = FormatDescription(descriptionNodes);
        
        Object[] children;
        if (childrenNode == null) {
            children = [];
        } else {
            usedTables.Add(childrenNode);
            children = ParseTable(childrenNode);
        }
        
        return new Object(Name: name,
                          Description: description,
                          Type: null,
                          Value: null,
                          BaseType: null,
                          Children: children
        );
    }
    
    private Object[] ParseTable(HtmlNode node) {
        string[] headers = node.SelectNodes("""child::tr[1]/th""")
                               .Select(n => n.InnerText)
                               .ToArray();
        
        return node
              .SelectNodes("""child::tr[position() > 1]""")
              .Select(n => ParseChild(n, headers))
              .Where(c => c != null)
              .OfType<Object>()
              .ToArray();
    }
    
    private Object? ParseChild(HtmlNode node, string[] headers) {
        HtmlNode[] nodes = node.SelectNodes("""child::td""").ToArray();
        
        if (Get("Name",        false) is not { } name
         || Get("Description", true) is not { } description)
            return null;
        
        return new Object(
            Name: name,
            Description: description,
            Type: Get("Type",         true),
            Value: Get("Value",       true),
            BaseType: Get("BaseType", true),
            Children: []
        );
        
        
        string? Get(string header, bool rich) {
            for (int index = 0; index < headers.Length; index++) {
                if (headers[index].Equals(header)) {
                    return rich
                               ? FormatDescription(nodes[index].ChildNodes)
                               : nodes[index].InnerText;
                }
            }
            
            return null;
        }
    }
    
    private string FormatDescription(IEnumerable<HtmlNode> nodes) {
        StringBuilder builder = new();
        foreach (HtmlNode node in nodes) {
            HtmlNode n = node;
            if (n.Name.Equals("strong")) {
                n      = n.Clone();
                n.Name = "b";
            }
            
            if (n.Name.Equals("div")) {
                if (n.HasClass("bb_code")) {
                    n = n.Clone();
                    n.RemoveClass();
                    n.Name = "code";
                }
            }
            
            builder.Append(n.OuterHtml.Replace("<br>", "<br />"));
        }
        
        return builder.ToString();
    }
    
    private Dictionary<string, Interface> interfaces = [];
    private Dictionary<string, Object>    objects    = [];
    
    public Interface? GetInterface(string name) => interfaces.GetValueOrDefault(name);
    public Object?    GetObject(string    path) => objects.GetValueOrDefault(path);
    
    public record Interface(string Name, string Description, Object[] Objects)
        : Object(Name, Description, null, null, null, Objects);
    
    public record Object(
        string   Name,
        string   Description,
        string?  Type,
        string?  Value,
        string?  BaseType,
        Object[] Children
    ) {
        public Object? GetChild(string name) =>
            Children.FirstOrDefault(c => c.Name.Equals(name));
    }
}