using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>HTML_LinkAtPosition_t</summary>
    public unsafe struct HTML_LinkAtPosition
    {
        /// <summary>HHTMLBrowser unBrowserHandle</summary>
        public HHTMLBrowser unBrowserHandle;
        /// <summary>uint32 x</summary>
        public uint x;
        /// <summary>uint32 y</summary>
        public uint y;
        /// <summary>const char * pchURL</summary>
        public UTF8StringPtr pchURL;
        /// <summary>bool bInput</summary>
        public bool bInput;
        /// <summary>bool bLiveLink</summary>
        public bool bLiveLink;
    }
}