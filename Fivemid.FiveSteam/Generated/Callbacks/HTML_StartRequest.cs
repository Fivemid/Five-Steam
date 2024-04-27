using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when a browser wants to navigate to a new page.<div class="bb_callout bb_red bb_fixed"><div><b>NOTE:</b> You MUST call <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#AllowStartRequest" class="bb_apilink">ISteamHTMLSurface::AllowStartRequest</a> in response to this callback!</div></div><br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#LoadURL" class="bb_apilink">ISteamHTMLSurface::LoadURL</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct HTML_StartRequest
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.HTML_StartRequest;
        /// <summary>The handle of the surface that is navigating.</summary>
        public HHTMLBrowser unBrowserHandle;
        /// <summary>The url it wants to navigate to.</summary>
        public UTF8StringPtr pchURL;
        /// <summary>The html link target type (i.e _blank, _self, _parent, _top ).</summary>
        public UTF8StringPtr pchTarget;
        /// <summary>Any posted data for the request.</summary>
        public UTF8StringPtr pchPostData;
        /// <summary>True if this was a http/html redirect from the last load request.</summary>
        public bool bIsRedirect;
    }
}