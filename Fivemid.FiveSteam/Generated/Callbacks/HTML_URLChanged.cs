using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>HTML_URLChanged_t</summary>
    public unsafe struct HTML_URLChanged : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.HTML_URLChanged;
        /// <summary>HHTMLBrowser unBrowserHandle</summary>
        public HHTMLBrowser unBrowserHandle;
        /// <summary>const char * pchURL</summary>
        public UTF8StringPtr pchURL;
        /// <summary>const char * pchPostData</summary>
        public UTF8StringPtr pchPostData;
        /// <summary>bool bIsRedirect</summary>
        public bool bIsRedirect;
        /// <summary>const char * pchPageTitle</summary>
        public UTF8StringPtr pchPageTitle;
        /// <summary>bool bNewNavigation</summary>
        public bool bNewNavigation;
    }
}