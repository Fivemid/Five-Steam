using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>HTML_BrowserRestarted_t</summary>
    public unsafe struct HTML_BrowserRestarted : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.HTML_BrowserRestarted;
        /// <summary>HHTMLBrowser unBrowserHandle</summary>
        public HHTMLBrowser unBrowserHandle;
        /// <summary>HHTMLBrowser unOldBrowserHandle</summary>
        public HHTMLBrowser unOldBrowserHandle;
    }
}