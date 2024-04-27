using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Provides details on the visibility and size of the vertical scrollbar.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#SetVerticalScroll" class="bb_apilink">ISteamHTMLSurface::SetVerticalScroll</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct HTML_VerticalScroll
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.HTML_VerticalScroll;
        /// <summary>The handle of the surface that this callback is for.</summary>
        public HHTMLBrowser unBrowserHandle;
        /// <summary>The maximum amount you can scroll vertically.</summary>
        public uint unScrollMax;
        /// <summary>The current vertical scroll position.</summary>
        public uint unScrollCurrent;
        /// <summary>The current page scale.</summary>
        public float flPageScale;
        /// <summary>Whether the vertical scrollbar is visible.</summary>
        public bool bVisible;
        /// <summary>The total height of the page in pixels.</summary>
        public uint unPageSize;
    }
}