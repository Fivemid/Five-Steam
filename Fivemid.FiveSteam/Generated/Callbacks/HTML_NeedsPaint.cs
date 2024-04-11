using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>HTML_NeedsPaint_t</summary>
    public unsafe struct HTML_NeedsPaint : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.HTML_NeedsPaint;
        /// <summary>HHTMLBrowser unBrowserHandle</summary>
        public HHTMLBrowser unBrowserHandle;
        /// <summary>const char * pBGRA</summary>
        public UTF8StringPtr pBGRA;
        /// <summary>uint32 unWide</summary>
        public uint unWide;
        /// <summary>uint32 unTall</summary>
        public uint unTall;
        /// <summary>uint32 unUpdateX</summary>
        public uint unUpdateX;
        /// <summary>uint32 unUpdateY</summary>
        public uint unUpdateY;
        /// <summary>uint32 unUpdateWide</summary>
        public uint unUpdateWide;
        /// <summary>uint32 unUpdateTall</summary>
        public uint unUpdateTall;
        /// <summary>uint32 unScrollX</summary>
        public uint unScrollX;
        /// <summary>uint32 unScrollY</summary>
        public uint unScrollY;
        /// <summary>float flPageScale</summary>
        public float flPageScale;
        /// <summary>uint32 unPageSerial</summary>
        public uint unPageSerial;
    }
}