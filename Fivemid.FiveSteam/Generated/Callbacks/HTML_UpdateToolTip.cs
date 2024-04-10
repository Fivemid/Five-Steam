using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>HTML_UpdateToolTip_t</summary>
    public unsafe struct HTML_UpdateToolTip
    {
        /// <summary>HHTMLBrowser unBrowserHandle</summary>
        public HHTMLBrowser unBrowserHandle;
        /// <summary>const char * pchMsg</summary>
        public UTF8StringPtr pchMsg;
    }
}