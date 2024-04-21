using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for ESteamNetworkingAvailability
    public enum SteamNetworkingAvailability : int
    {
        /// missing documentation for ESteamNetworkingAvailability.k_ESteamNetworkingAvailability_CannotTry
        CannotTry = -102,
        /// missing documentation for ESteamNetworkingAvailability.k_ESteamNetworkingAvailability_Failed
        Failed = -101,
        /// missing documentation for ESteamNetworkingAvailability.k_ESteamNetworkingAvailability_Previously
        Previously = -100,
        /// missing documentation for ESteamNetworkingAvailability.k_ESteamNetworkingAvailability_Retrying
        Retrying = -10,
        /// missing documentation for ESteamNetworkingAvailability.k_ESteamNetworkingAvailability_NeverTried
        NeverTried = 1,
        /// missing documentation for ESteamNetworkingAvailability.k_ESteamNetworkingAvailability_Waiting
        Waiting = 2,
        /// missing documentation for ESteamNetworkingAvailability.k_ESteamNetworkingAvailability_Attempting
        Attempting = 3,
        /// missing documentation for ESteamNetworkingAvailability.k_ESteamNetworkingAvailability_Current
        Current = 100,
        /// missing documentation for ESteamNetworkingAvailability.k_ESteamNetworkingAvailability_Unknown
        Unknown = 0,
        /// missing documentation for ESteamNetworkingAvailability.k_ESteamNetworkingAvailability__Force32bit
        _Force32bit = 2147483647
    }
}