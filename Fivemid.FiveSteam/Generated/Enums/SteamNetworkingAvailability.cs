using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ESteamNetworkingAvailability</summary>
    public enum SteamNetworkingAvailability : int
    {
        /// <summary>k_ESteamNetworkingAvailability_CannotTry</summary>
        CannotTry = -102,
        /// <summary>k_ESteamNetworkingAvailability_Failed</summary>
        Failed = -101,
        /// <summary>k_ESteamNetworkingAvailability_Previously</summary>
        Previously = -100,
        /// <summary>k_ESteamNetworkingAvailability_Retrying</summary>
        Retrying = -10,
        /// <summary>k_ESteamNetworkingAvailability_NeverTried</summary>
        NeverTried = 1,
        /// <summary>k_ESteamNetworkingAvailability_Waiting</summary>
        Waiting = 2,
        /// <summary>k_ESteamNetworkingAvailability_Attempting</summary>
        Attempting = 3,
        /// <summary>k_ESteamNetworkingAvailability_Current</summary>
        Current = 100,
        /// <summary>k_ESteamNetworkingAvailability_Unknown</summary>
        Unknown = 0,
        /// <summary>k_ESteamNetworkingAvailability__Force32bit</summary>
        _Force32bit = 2147483647
    }
}