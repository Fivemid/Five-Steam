using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Describes the type of VR screenshots.<br />
    /// <br />
    /// </summary>
    public enum VRScreenshotType : int
    {
        /// <summary></summary>
        None = 0,
        /// <summary></summary>
        Mono = 1,
        /// <summary></summary>
        Stereo = 2,
        /// <summary></summary>
        MonoCubemap = 3,
        /// <summary></summary>
        MonoPanorama = 4,
        /// <summary></summary>
        StereoPanorama = 5
    }
}