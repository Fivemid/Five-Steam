using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>HTML_StatusText_t</summary>
    public unsafe struct HTML_StatusText
    {
        /// <summary>HHTMLBrowser unBrowserHandle</summary>
        public HHTMLBrowser unBrowserHandle;
        /// <summary>const char * pchMsg</summary>
        public UTF8StringPtr pchMsg;
    }
}