using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when page history status has changed the ability to go backwards and forward.<br />
    /// <br />
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct HTML_CanGoBackAndForward
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.HTML_CanGoBackAndForward;
        /// <summary>The handle of the surface that this callback is for.</summary>
        public HHTMLBrowser unBrowserHandle;
        /// <summary>Returns whether you can navigate backwards.</summary>
        public bool bCanGoBack;
        /// <summary>Returns whether you can navigate forward.</summary>
        public bool bCanGoForward;
    }
}