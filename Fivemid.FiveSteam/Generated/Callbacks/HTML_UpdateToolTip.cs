using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when the text of an existing tooltip has been updated.<br />
    /// <br />
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct HTML_UpdateToolTip
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.HTML_UpdateToolTip;
        /// <summary>The handle of the surface that this callback is for.</summary>
        public HHTMLBrowser unBrowserHandle;
        /// <summary>The new text of the tooltip.</summary>
        public UTF8StringPtr pchMsg;
    }
}