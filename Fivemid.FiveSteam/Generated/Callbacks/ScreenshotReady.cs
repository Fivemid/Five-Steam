using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ScreenshotReady_t</summary>
    public unsafe struct ScreenshotReady : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.ScreenshotReady;
        /// <summary>ScreenshotHandle m_hLocal</summary>
        public ScreenshotHandle hLocal;
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
    }
}