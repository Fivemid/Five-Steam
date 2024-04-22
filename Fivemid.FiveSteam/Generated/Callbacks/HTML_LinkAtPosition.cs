using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Result of a call to <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#GetLinkAtPosition" class="bb_apilink">ISteamHTMLSurface::GetLinkAtPosition</a><br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#GetLinkAtPosition" class="bb_apilink">ISteamHTMLSurface::GetLinkAtPosition</a></summary>
    public unsafe struct HTML_LinkAtPosition : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.HTML_LinkAtPosition;
        /// <summary>The handle of the surface that this call was for.</summary>
        public HHTMLBrowser unBrowserHandle;
        /// <summary>Unused.</summary>
        public uint x;
        /// <summary>Unused.</summary>
        public uint y;
        /// <summary>The URL found at this position. <b>NULL</b> if no link was found.</summary>
        public UTF8StringPtr pchURL;
        /// <summary>Was the position an input field?</summary>
        public bool bInput;
        /// <summary></summary>
        public bool bLiveLink;
    }
}