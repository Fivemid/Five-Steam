using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when a browser surface has a pending paint. This is where you get the actual image data to render to the screen.<br />
    /// <br />
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct HTML_NeedsPaint : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.HTML_NeedsPaint;
        /// <summary>The handle of the surface that this callback is for.</summary>
        public HHTMLBrowser unBrowserHandle;
        /// <summary>A pointer to the B8G8R8A8 image data for this surface, valid until <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPI_RunCallbacks" class="bb_apilink">SteamAPI_RunCallbacks</a> is next called.</summary>
        public UTF8StringPtr pBGRA;
        /// <summary>The total width of the <code class="bb_code bb_code_inline nohighlight">pBGRA</code> texture.</summary>
        public uint unWide;
        /// <summary>The total height of the <code class="bb_code bb_code_inline nohighlight">pBGRA</code> texture.</summary>
        public uint unTall;
        /// <summary>The offset in X for the damage rect for this update.</summary>
        public uint unUpdateX;
        /// <summary>The offset in Y for the damage rect for this update.</summary>
        public uint unUpdateY;
        /// <summary>The width of the damage rect for this update.</summary>
        public uint unUpdateWide;
        /// <summary>The height of the damage rect for this update.</summary>
        public uint unUpdateTall;
        /// <summary>The horizontal scroll position the browser was at when this texture was rendered.</summary>
        public uint unScrollX;
        /// <summary>The veritcal scroll position the browser was at when this texture was rendered.</summary>
        public uint unScrollY;
        /// <summary>The scale factor the browser was at when this texture was rendered.</summary>
        public float flPageScale;
        /// <summary>Incremented on each new page load, you can use this to reject draws while navigating to new pages.</summary>
        public uint unPageSerial;
    }
}