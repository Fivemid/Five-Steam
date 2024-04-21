using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for ESteamNetworkingConnectionState
    public enum SteamNetworkingConnectionState : int
    {
        /// missing documentation for ESteamNetworkingConnectionState.k_ESteamNetworkingConnectionState_None
        None = 0,
        /// missing documentation for ESteamNetworkingConnectionState.k_ESteamNetworkingConnectionState_Connecting
        Connecting = 1,
        /// missing documentation for ESteamNetworkingConnectionState.k_ESteamNetworkingConnectionState_FindingRoute
        FindingRoute = 2,
        /// missing documentation for ESteamNetworkingConnectionState.k_ESteamNetworkingConnectionState_Connected
        Connected = 3,
        /// missing documentation for ESteamNetworkingConnectionState.k_ESteamNetworkingConnectionState_ClosedByPeer
        ClosedByPeer = 4,
        /// missing documentation for ESteamNetworkingConnectionState.k_ESteamNetworkingConnectionState_ProblemDetectedLocally
        ProblemDetectedLocally = 5,
        /// missing documentation for ESteamNetworkingConnectionState.k_ESteamNetworkingConnectionState_FinWait
        FinWait = -1,
        /// missing documentation for ESteamNetworkingConnectionState.k_ESteamNetworkingConnectionState_Linger
        Linger = -2,
        /// missing documentation for ESteamNetworkingConnectionState.k_ESteamNetworkingConnectionState_Dead
        Dead = -3,
        /// missing documentation for ESteamNetworkingConnectionState.k_ESteamNetworkingConnectionState__Force32Bit
        _Force32Bit = 2147483647
    }
}