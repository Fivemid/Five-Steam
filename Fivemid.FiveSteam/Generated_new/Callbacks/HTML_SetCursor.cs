using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>HTML_SetCursor_t</summary>
    public unsafe struct HTML_SetCursor
    {
        /// <summary>HHTMLBrowser unBrowserHandle</summary>
        public HHTMLBrowser unBrowserHandle;
        /// <summary>uint32 eMouseCursor</summary>
        public uint eMouseCursor;
    }
}