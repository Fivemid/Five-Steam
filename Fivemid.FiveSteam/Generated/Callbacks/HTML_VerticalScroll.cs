using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>HTML_VerticalScroll_t</summary>
    public unsafe struct HTML_VerticalScroll : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.HTML_VerticalScroll;
        /// <summary>HHTMLBrowser unBrowserHandle</summary>
        public HHTMLBrowser unBrowserHandle;
        /// <summary>uint32 unScrollMax</summary>
        public uint unScrollMax;
        /// <summary>uint32 unScrollCurrent</summary>
        public uint unScrollCurrent;
        /// <summary>float flPageScale</summary>
        public float flPageScale;
        /// <summary>bool bVisible</summary>
        public bool bVisible;
        /// <summary>uint32 unPageSize</summary>
        public uint unPageSize;
    }
}