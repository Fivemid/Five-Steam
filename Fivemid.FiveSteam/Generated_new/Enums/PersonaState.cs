using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EPersonaState</summary>
    public enum PersonaState : int
    {
        /// <summary>k_EPersonaStateOffline</summary>
        Offline = 0,
        /// <summary>k_EPersonaStateOnline</summary>
        Online = 1,
        /// <summary>k_EPersonaStateBusy</summary>
        Busy = 2,
        /// <summary>k_EPersonaStateAway</summary>
        Away = 3,
        /// <summary>k_EPersonaStateSnooze</summary>
        Snooze = 4,
        /// <summary>k_EPersonaStateLookingToTrade</summary>
        LookingToTrade = 5,
        /// <summary>k_EPersonaStateLookingToPlay</summary>
        LookingToPlay = 6,
        /// <summary>k_EPersonaStateInvisible</summary>
        Invisible = 7,
        /// <summary>k_EPersonaStateMax</summary>
        Max = 8
    }
}