using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when a browser has finished loading a page.<br />
    /// <br />
    /// </summary>
    public unsafe struct HTML_FinishedRequest : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.HTML_FinishedRequest;
        /// <summary>The handle of the surface that this call was for.</summary>
        public HHTMLBrowser unBrowserHandle;
        /// <summary>The URL that was loaded.</summary>
        public UTF8StringPtr pchURL;
        /// <summary>The title of the page that got loaded.</summary>
        public UTF8StringPtr pchPageTitle;
    }
}