using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for HTML_BrowserRestarted_t
    public unsafe struct HTML_BrowserRestarted : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.HTML_BrowserRestarted;
        /// missing documentation for HTML_BrowserRestarted_t.unBrowserHandle
        public HHTMLBrowser unBrowserHandle;
        /// missing documentation for HTML_BrowserRestarted_t.unOldBrowserHandle
        public HHTMLBrowser unOldBrowserHandle;
    }
}