using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when the browser has been requested to close due to user interaction; usually because of a javascript <code class="bb_code bb_code_inline nohighlight">window.close()</code> call.<br />
    /// <br />
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct HTML_CloseBrowser
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.HTML_CloseBrowser;
        /// <summary>The handle of the surface that this callback is for.</summary>
        public HHTMLBrowser unBrowserHandle;
    }
}