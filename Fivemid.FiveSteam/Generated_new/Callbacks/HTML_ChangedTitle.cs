using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>HTML_ChangedTitle_t</summary>
    public unsafe struct HTML_ChangedTitle
    {
        /// <summary>HHTMLBrowser unBrowserHandle</summary>
        public HHTMLBrowser unBrowserHandle;
        /// <summary>const char * pchTitle</summary>
        public UTF8StringPtr pchTitle;
    }
}