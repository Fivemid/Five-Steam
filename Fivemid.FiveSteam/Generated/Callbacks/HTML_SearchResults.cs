using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Results from a search.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#Find" class="bb_apilink">ISteamHTMLSurface::Find</a></summary>
    public unsafe struct HTML_SearchResults : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.HTML_SearchResults;
        /// <summary>The handle of the surface that this callback is for.</summary>
        public HHTMLBrowser unBrowserHandle;
        /// <summary>The number of matching results found.</summary>
        public uint unResults;
        /// <summary>The ordinal of the current match relative to <code class="bb_code bb_code_inline nohighlight">unResults</code>.</summary>
        public uint unCurrentMatch;
    }
}