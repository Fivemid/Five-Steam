using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>HTML_OpenLinkInNewTab_t</summary>
    public unsafe struct HTML_OpenLinkInNewTab
    {
        /// <summary>HHTMLBrowser unBrowserHandle</summary>
        public HHTMLBrowser unBrowserHandle;
        /// <summary>const char * pchURL</summary>
        public UTF8StringPtr pchURL;
    }
}