using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>HTML_StartRequest_t</summary>
    public unsafe struct HTML_StartRequest
    {
        /// <summary>HHTMLBrowser unBrowserHandle</summary>
        public HHTMLBrowser unBrowserHandle;
        /// <summary>const char * pchURL</summary>
        public UTF8StringPtr pchURL;
        /// <summary>const char * pchTarget</summary>
        public UTF8StringPtr pchTarget;
        /// <summary>const char * pchPostData</summary>
        public UTF8StringPtr pchPostData;
        /// <summary>bool bIsRedirect</summary>
        public bool bIsRedirect;
    }
}