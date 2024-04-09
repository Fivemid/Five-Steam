using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>HTML_JSConfirm_t</summary>
    public unsafe struct HTML_JSConfirm
    {
        /// <summary>HHTMLBrowser unBrowserHandle</summary>
        public HHTMLBrowser unBrowserHandle;
        /// <summary>const char * pchMessage</summary>
        public UTF8StringPtr pchMessage;
    }
}