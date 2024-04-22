using HtmlAgilityPack;

namespace Fivemid.FiveSteam.Generator;

public partial class Documentation {
    public void FixHtml(HtmlDocument document) {
        FixTables(document);
        return;
        
        static void FixTables(HtmlDocument document) {
            List<HtmlNode> toRemove = [];
            FindNodesToRemove(document.DocumentNode);
            
            foreach (HtmlNode node in toRemove) {
                foreach (HtmlNode child in node.ChildNodes) {
                    node.ParentNode.InsertAfter(child, node);
                }
                
                node.Remove();
            }
            
            return;
            
            void FindNodesToRemove(HtmlNode node, bool withinTable = false) {
                switch (node.Name) {
                    case "table":
                        withinTable = true;
                        break;
                }
                
                foreach (HtmlNode child in node.ChildNodes) {
                    FindNodesToRemove(child, withinTable);
                }
                
                switch (node.Name) {
                    case "td" or "th" or "tbody":
                        if (!withinTable) {
                            toRemove.Add(node);
                        }
                        
                        break;
                }
            }
        }
    }
}