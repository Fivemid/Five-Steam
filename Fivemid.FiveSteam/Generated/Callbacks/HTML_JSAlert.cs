using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>HTML_JSAlert_t</summary>
    public unsafe struct HTML_JSAlert
    {
        /// <summary>HHTMLBrowser unBrowserHandle</summary>
        public HHTMLBrowser unBrowserHandle;
        /// <summary>const char * pchMessage</summary>
        public UTF8StringPtr pchMessage;
    }
}