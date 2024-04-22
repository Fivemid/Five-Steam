using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when a browser wants to change the mouse cursor.<br />
    /// <br />
    /// </summary>
    public unsafe struct HTML_SetCursor : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.HTML_SetCursor;
        /// <summary>The handle of the surface that this callback is for.</summary>
        public HHTMLBrowser unBrowserHandle;
        /// <summary>The <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#EMouseCursor" class="bb_apilink">EMouseCursor</a> to display.</summary>
        public uint eMouseCursor;
    }
}