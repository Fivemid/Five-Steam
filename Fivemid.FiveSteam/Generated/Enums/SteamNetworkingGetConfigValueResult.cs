using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for ESteamNetworkingGetConfigValueResult
    public enum SteamNetworkingGetConfigValueResult : int
    {
        /// missing documentation for ESteamNetworkingGetConfigValueResult.k_ESteamNetworkingGetConfigValue_BadValue
        SteamNetworkingGetConfigValue_BadValue = -1,
        /// missing documentation for ESteamNetworkingGetConfigValueResult.k_ESteamNetworkingGetConfigValue_BadScopeObj
        SteamNetworkingGetConfigValue_BadScopeObj = -2,
        /// missing documentation for ESteamNetworkingGetConfigValueResult.k_ESteamNetworkingGetConfigValue_BufferTooSmall
        SteamNetworkingGetConfigValue_BufferTooSmall = -3,
        /// missing documentation for ESteamNetworkingGetConfigValueResult.k_ESteamNetworkingGetConfigValue_OK
        SteamNetworkingGetConfigValue_OK = 1,
        /// missing documentation for ESteamNetworkingGetConfigValueResult.k_ESteamNetworkingGetConfigValue_OKInherited
        SteamNetworkingGetConfigValue_OKInherited = 2,
        /// missing documentation for ESteamNetworkingGetConfigValueResult.k_ESteamNetworkingGetConfigValueResult__Force32Bit
        _Force32Bit = 2147483647
    }
}