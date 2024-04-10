using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ESteamNetworkingFakeIPType</summary>
    public enum SteamNetworkingFakeIPType : int
    {
        /// <summary>k_ESteamNetworkingFakeIPType_Invalid</summary>
        Invalid = 0,
        /// <summary>k_ESteamNetworkingFakeIPType_NotFake</summary>
        NotFake = 1,
        /// <summary>k_ESteamNetworkingFakeIPType_GlobalIPv4</summary>
        GlobalIPv4 = 2,
        /// <summary>k_ESteamNetworkingFakeIPType_LocalIPv4</summary>
        LocalIPv4 = 3,
        /// <summary>k_ESteamNetworkingFakeIPType__Force32Bit</summary>
        _Force32Bit = 2147483647
    }
}