using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>HTML_CanGoBackAndForward_t</summary>
    public unsafe struct HTML_CanGoBackAndForward
    {
        /// <summary>HHTMLBrowser unBrowserHandle</summary>
        public HHTMLBrowser unBrowserHandle;
        /// <summary>bool bCanGoBack</summary>
        public bool bCanGoBack;
        /// <summary>bool bCanGoForward</summary>
        public bool bCanGoForward;
    }
}