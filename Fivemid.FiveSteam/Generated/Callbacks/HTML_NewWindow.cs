using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>HTML_NewWindow_t</summary>
    public unsafe struct HTML_NewWindow : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.HTML_NewWindow;
        /// <summary>HHTMLBrowser unBrowserHandle</summary>
        public HHTMLBrowser unBrowserHandle;
        /// <summary>const char * pchURL</summary>
        public UTF8StringPtr pchURL;
        /// <summary>uint32 unX</summary>
        public uint unX;
        /// <summary>uint32 unY</summary>
        public uint unY;
        /// <summary>uint32 unWide</summary>
        public uint unWide;
        /// <summary>uint32 unTall</summary>
        public uint unTall;
        /// <summary>HHTMLBrowser unNewWindow_BrowserHandle_IGNORE</summary>
        public HHTMLBrowser unNewWindow_BrowserHandle_IGNORE;
    }
}