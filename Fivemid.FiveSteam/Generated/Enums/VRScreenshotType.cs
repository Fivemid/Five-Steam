using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EVRScreenshotType</summary>
    public enum VRScreenshotType : int
    {
        /// <summary>k_EVRScreenshotType_None</summary>
        None = 0,
        /// <summary>k_EVRScreenshotType_Mono</summary>
        Mono = 1,
        /// <summary>k_EVRScreenshotType_Stereo</summary>
        Stereo = 2,
        /// <summary>k_EVRScreenshotType_MonoCubemap</summary>
        MonoCubemap = 3,
        /// <summary>k_EVRScreenshotType_MonoPanorama</summary>
        MonoPanorama = 4,
        /// <summary>k_EVRScreenshotType_StereoPanorama</summary>
        StereoPanorama = 5
    }
}