using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>A browser has created a new HTML window.<br />
    /// <br />
    /// </summary>
    public unsafe struct HTML_NewWindow : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.HTML_NewWindow;
        /// <summary>The handle of the surface that this callback is for.</summary>
        public HHTMLBrowser unBrowserHandle;
        /// <summary>The URL to load in the new window.</summary>
        public UTF8StringPtr pchURL;
        /// <summary>The x pos into the page to display the popup.</summary>
        public uint unX;
        /// <summary>The y pos into the page to display the popup.</summary>
        public uint unY;
        /// <summary>The total width of the pBGRA texture.</summary>
        public uint unWide;
        /// <summary>The total height of the pBGRA texture.</summary>
        public uint unTall;
        /// missing documentation for HTML_NewWindow_t.unNewWindow_BrowserHandle_IGNORE
        public HHTMLBrowser unNewWindow_BrowserHandle_IGNORE;
    }
}