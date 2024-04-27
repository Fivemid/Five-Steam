using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when the current page in a browser gets a new title.<br />
    /// <br />
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct HTML_ChangedTitle
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.HTML_ChangedTitle;
        /// <summary>The handle of the surface that this callback is for.</summary>
        public HHTMLBrowser unBrowserHandle;
        /// <summary>The new title of the page.</summary>
        public UTF8StringPtr pchTitle;
    }
}