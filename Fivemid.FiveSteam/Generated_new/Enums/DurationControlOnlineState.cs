using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EDurationControlOnlineState</summary>
    public enum DurationControlOnlineState : int
    {
        /// <summary>k_EDurationControlOnlineState_Invalid</summary>
        Invalid = 0,
        /// <summary>k_EDurationControlOnlineState_Offline</summary>
        Offline = 1,
        /// <summary>k_EDurationControlOnlineState_Online</summary>
        Online = 2,
        /// <summary>k_EDurationControlOnlineState_OnlineHighPri</summary>
        OnlineHighPri = 3
    }
}