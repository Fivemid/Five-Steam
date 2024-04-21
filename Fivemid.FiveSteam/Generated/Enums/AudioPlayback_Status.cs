using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Specifies the current playback status.<br />
    /// <br />
    /// 
    /// </summary>
    public enum AudioPlayback_Status : int
    {
        /// <summary>The Steam music interface probably isn't enabled.</summary>
        AudioPlayback_Undefined = 0,
        /// <summary>Steam Music is currently playing.</summary>
        AudioPlayback_Playing = 1,
        /// <summary>Steam Music is currently paused.</summary>
        AudioPlayback_Paused = 2,
        /// <summary>Steam Music is currently stopped.</summary>
        AudioPlayback_Idle = 3
    }
}