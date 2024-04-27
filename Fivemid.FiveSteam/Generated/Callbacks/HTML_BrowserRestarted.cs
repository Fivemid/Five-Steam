using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for HTML_BrowserRestarted_t
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct HTML_BrowserRestarted
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.HTML_BrowserRestarted;
        /// missing documentation for HTML_BrowserRestarted_t.unBrowserHandle
        public HHTMLBrowser unBrowserHandle;
        /// missing documentation for HTML_BrowserRestarted_t.unOldBrowserHandle
        public HHTMLBrowser unOldBrowserHandle;
    }
}