using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when the browser wants to display a Javascript alert dialog, call <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#JSDialogResponse" class="bb_apilink">ISteamHTMLSurface::JSDialogResponse</a> when the user dismisses this dialog; or right away to ignore it.<br />
    /// <br />
    /// </summary>
    public unsafe struct HTML_JSAlert : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.HTML_JSAlert;
        /// <summary>The handle of the surface that this call was for.</summary>
        public HHTMLBrowser unBrowserHandle;
        /// <summary>The message associated with the dialog.</summary>
        public UTF8StringPtr pchMessage;
    }
}