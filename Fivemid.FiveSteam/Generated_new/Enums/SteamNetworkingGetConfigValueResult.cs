using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ESteamNetworkingGetConfigValueResult</summary>
    public enum SteamNetworkingGetConfigValueResult : int
    {
        /// <summary>k_ESteamNetworkingGetConfigValue_BadValue</summary>
        SteamNetworkingGetConfigValue_BadValue = -1,
        /// <summary>k_ESteamNetworkingGetConfigValue_BadScopeObj</summary>
        SteamNetworkingGetConfigValue_BadScopeObj = -2,
        /// <summary>k_ESteamNetworkingGetConfigValue_BufferTooSmall</summary>
        SteamNetworkingGetConfigValue_BufferTooSmall = -3,
        /// <summary>k_ESteamNetworkingGetConfigValue_OK</summary>
        SteamNetworkingGetConfigValue_OK = 1,
        /// <summary>k_ESteamNetworkingGetConfigValue_OKInherited</summary>
        SteamNetworkingGetConfigValue_OKInherited = 2,
        /// <summary>k_ESteamNetworkingGetConfigValueResult__Force32Bit</summary>
        _Force32Bit = 2147483647
    }
}