using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when a browser wants you to display an informational message. This is most commonly used when you hover over links.<br />
    /// <br />
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct HTML_StatusText
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.HTML_StatusText;
        /// <summary>The handle of the surface that this callback is for.</summary>
        public HHTMLBrowser unBrowserHandle;
        /// <summary>The text of the status message to display.</summary>
        public UTF8StringPtr pchMsg;
    }
}