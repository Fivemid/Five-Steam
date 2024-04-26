using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when the browser is navigating to a new url<br />
    /// <br />
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct HTML_URLChanged : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.HTML_URLChanged;
        /// <summary>The handle of the surface that this callback is for.</summary>
        public HHTMLBrowser unBrowserHandle;
        /// <summary>The url that the browser is navigating to.</summary>
        public UTF8StringPtr pchURL;
        /// <summary>Any posted data for the request, NULL if there was none.</summary>
        public UTF8StringPtr pchPostData;
        /// <summary><b>true</b> if this was a http/html redirect from the last load request, otherwise <b>false</b>.</summary>
        public bool bIsRedirect;
        /// <summary>The title of the page.</summary>
        public UTF8StringPtr pchPageTitle;
        /// <summary>This is <b>true</b> if the page has changed rather than just a call to the browser history API.</summary>
        public bool bNewNavigation;
    }
}