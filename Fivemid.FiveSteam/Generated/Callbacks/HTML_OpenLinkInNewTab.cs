using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>The browser has requested to load a url in a new tab.<br />
    /// <br />
    /// </summary>
    public unsafe struct HTML_OpenLinkInNewTab : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.HTML_OpenLinkInNewTab;
        /// <summary>The handle of the surface that this callback is for.</summary>
        public HHTMLBrowser unBrowserHandle;
        /// <summary>The URL that the browser wants to load.</summary>
        public UTF8StringPtr pchURL;
    }
}