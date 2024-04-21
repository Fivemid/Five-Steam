using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// A touchpad region on a Steam Controller Device.<br />
    /// <br />
    /// <b>Notes:</b><br />
    /// On the VSC, the values correspond to the left &amp; right haptic touchpads.<br />
    /// On the DS4, the values correspond to the left &amp; right halves of the single, central touchpad.<br />
    /// <br />
    /// 
    /// </summary>
    public enum SteamControllerPad : int
    {
        /// <summary>The left touchpad region on a Steam Controller Device. Compatible models: VSC, DS4</summary>
        Left = 0,
        /// <summary>The right region on a Steam Controller Device. Compatible models: VSC, DS4</summary>
        Right = 1
    }
}