using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>OverlayBrowserProtocolNavigation_t</summary>
    public unsafe struct OverlayBrowserProtocolNavigation : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.OverlayBrowserProtocolNavigation;
        /// <summary>char [1024] rgchURI</summary>
        public UTF8String1024 rgchURI;
    }
}