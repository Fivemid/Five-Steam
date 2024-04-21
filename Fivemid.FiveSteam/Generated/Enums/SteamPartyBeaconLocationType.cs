using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Types of locations where beacons can be posted.<br />
    /// <br />
    /// 
    /// </summary>
    public enum SteamPartyBeaconLocationType : int
    {
        /// <summary>Invalid location type.</summary>
        Invalid = 0,
        /// <summary>A Steam Chat Room Group.</summary>
        ChatGroup = 1,
        /// <summary>Value is always one greater than the largest valid location type value.</summary>
        Max = 2
    }
}