using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>HTML_SearchResults_t</summary>
    public unsafe struct HTML_SearchResults
    {
        /// <summary>HHTMLBrowser unBrowserHandle</summary>
        public HHTMLBrowser unBrowserHandle;
        /// <summary>uint32 unResults</summary>
        public uint unResults;
        /// <summary>uint32 unCurrentMatch</summary>
        public uint unCurrentMatch;
    }
}