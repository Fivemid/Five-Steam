using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ESteamNetworkingConnectionState</summary>
    public enum SteamNetworkingConnectionState : int
    {
        /// <summary>k_ESteamNetworkingConnectionState_None</summary>
        None = 0,
        /// <summary>k_ESteamNetworkingConnectionState_Connecting</summary>
        Connecting = 1,
        /// <summary>k_ESteamNetworkingConnectionState_FindingRoute</summary>
        FindingRoute = 2,
        /// <summary>k_ESteamNetworkingConnectionState_Connected</summary>
        Connected = 3,
        /// <summary>k_ESteamNetworkingConnectionState_ClosedByPeer</summary>
        ClosedByPeer = 4,
        /// <summary>k_ESteamNetworkingConnectionState_ProblemDetectedLocally</summary>
        ProblemDetectedLocally = 5,
        /// <summary>k_ESteamNetworkingConnectionState_FinWait</summary>
        FinWait = -1,
        /// <summary>k_ESteamNetworkingConnectionState_Linger</summary>
        Linger = -2,
        /// <summary>k_ESteamNetworkingConnectionState_Dead</summary>
        Dead = -3,
        /// <summary>k_ESteamNetworkingConnectionState__Force32Bit</summary>
        _Force32Bit = 2147483647
    }
}