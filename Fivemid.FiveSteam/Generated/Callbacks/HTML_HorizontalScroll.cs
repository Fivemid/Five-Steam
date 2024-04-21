using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Provides details on the visibility and size of the horizontal scrollbar.<br />
    /// <br />
    /// 
    /// <br />
    /// <b>Associated Functions:</b>
    /// <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#SetHorizontalScroll" class="bb_apilink">ISteamHTMLSurface::SetHorizontalScroll</a>
    /// </summary>
    public unsafe struct HTML_HorizontalScroll : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.HTML_HorizontalScroll;
        /// <summary>The handle of the surface that this callback is for.</summary>
        public HHTMLBrowser unBrowserHandle;
        /// <summary>The maximum amount you can scroll horizontally.</summary>
        public uint unScrollMax;
        /// <summary>The current horizontal scroll position.</summary>
        public uint unScrollCurrent;
        /// <summary>The current page scale.</summary>
        public float flPageScale;
        /// <summary>Whether the horizontal scrollbar is visible.</summary>
        public bool bVisible;
        /// <summary>The total width of the page in pixels.</summary>
        public uint unPageSize;
    }
}