using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ESteamIPv6ConnectivityState</summary>
    public enum SteamIPv6ConnectivityState : int
    {
        /// <summary>k_ESteamIPv6ConnectivityState_Unknown</summary>
        Unknown = 0,
        /// <summary>k_ESteamIPv6ConnectivityState_Good</summary>
        Good = 1,
        /// <summary>k_ESteamIPv6ConnectivityState_Bad</summary>
        Bad = 2
    }
}