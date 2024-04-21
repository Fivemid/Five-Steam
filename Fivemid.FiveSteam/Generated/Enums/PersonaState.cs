using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// List of states a Steam friend can be in.<br />
    /// <br />
    /// 
    /// </summary>
    public enum PersonaState : int
    {
        /// <summary>Friend is not currently logged on.</summary>
        Offline = 0,
        /// <summary>Friend is logged on.</summary>
        Online = 1,
        /// <summary>Friend is logged on, but set to "Do not disturb."</summary>
        Busy = 2,
        /// <summary>Auto-away feature.</summary>
        Away = 3,
        /// <summary>Auto-away for a long time.</summary>
        Snooze = 4,
        /// <summary>Online, trading.</summary>
        LookingToTrade = 5,
        /// <summary>Online, wanting to play.</summary>
        LookingToPlay = 6,
        /// missing documentation for EPersonaState.k_EPersonaStateInvisible
        Invisible = 7,
        /// <summary>The total number of states. Only used for looping and validation.</summary>
        Max = 8
    }
}