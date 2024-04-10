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
    }

    private Interface ParseInterface(HtmlDocument doc) {
        HtmlNode header = doc.DocumentNode.SelectSingleNode("/h1");
        string name = header
                     .InnerText.StripSuffix(" Interface").Trim();
        string description = header.NextSibling.InnerText.Trim();

        Method[] methods =
            (doc.DocumentNode.SelectNodes("""/h2[@class="bb_subsection" and following::*[@class="bb_code cpp"]]""")
               ?.ToArray() ?? [])
           .Select(ParseMethod)
           .ToArray();

        return new Interface(name, description, methods);
    }

    private Method ParseMethod(HtmlNode node) {
        string name = node.InnerText.Trim();

        List<HtmlNode> descriptionNodes = [];
        HtmlNode?      parametersNode   = null;

        {
            HtmlNode following = node.NextSibling;
            while (following != null && !following.Name.Equals("h2")) {
                if (following.Name.Equals("table"))
                    parametersNode = following;
                else
                    descriptionNodes.Add(following);
                following = following.NextSibling;
            }
        }

        string description = FormatDescription(descriptionNodes);

        Parameter[] parameters =
            (parametersNode?
            .SelectNodes("""child::tr[position() > 1]""")
           ?.ToArray() ?? [])
           .Select(ParseParameter)
           .ToArray();

        return new Method(name, description, parameters);
    }

    private Parameter ParseParameter(HtmlNode node) {
        HtmlNode[] nodes = node.SelectNodes("""child::td""").ToArray();
        return new Parameter(nodes[0].InnerText.Trim(), nodes[1].InnerText.Trim(), FormatDescription(nodes[2].ChildNodes));
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

    public Interface? GetInterface(string name) => interfaces.GetValueOrDefault(name);

    public record Interface(string Name, string Description, Method[] Methods) {
        public Method? GetMethod(string name) =>
            Methods.FirstOrDefault(m => m.Name == name);
    }

    public record Method(string Name, string Description, Parameter[] Parameters);

    public record Parameter(string Name, string Type, string Description);
}