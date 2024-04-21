using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for OverlayBrowserProtocolNavigation_t
    public unsafe struct OverlayBrowserProtocolNavigation : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.OverlayBrowserProtocolNavigation;
        /// missing documentation for OverlayBrowserProtocolNavigation_t.rgchURI
        public UTF8String1024 rgchURI;
    }
}