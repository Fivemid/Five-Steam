using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>A new browser was created and is ready for use.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface#CreateBrowser" class="bb_apilink">ISteamHTMLSurface::CreateBrowser</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct HTML_BrowserReady : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.HTML_BrowserReady;
        /// <summary>This is the handle to the browser that was just created, which you can use with future calls to <a href="https://partner.steamgames.com/doc/api/ISteamHTMLSurface" class="bb_apilink">ISteamHTMLSurface</a>.</summary>
        public HHTMLBrowser unBrowserHandle;
    }
}