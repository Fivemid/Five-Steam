using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>AudioPlayback_Status</summary>
    public enum AudioPlayback_Status : int
    {
        /// <summary>AudioPlayback_Undefined</summary>
        AudioPlayback_Undefined = 0,
        /// <summary>AudioPlayback_Playing</summary>
        AudioPlayback_Playing = 1,
        /// <summary>AudioPlayback_Paused</summary>
        AudioPlayback_Paused = 2,
        /// <summary>AudioPlayback_Idle</summary>
        AudioPlayback_Idle = 3
    }
}