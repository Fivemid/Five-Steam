using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// <br /><a href="https://partner.steamgames.com/doc/api/ISteamNetworkintgUtils#GetConfigValue" class="bb_apilink">ISteamNetworkintgUtils::GetConfigValue</a>
    /// Return value of <br /></summary>
    public enum SteamNetworkingGetConfigValueResult : int
    {
        /// <summary>No such configuration value</summary>
        SteamNetworkingGetConfigValue_BadValue = -1,
        /// <summary>Bad connection handle, etc</summary>
        SteamNetworkingGetConfigValue_BadScopeObj = -2,
        /// <summary>Couldn't fit the result in your buffer</summary>
        SteamNetworkingGetConfigValue_BufferTooSmall = -3,
        /// <summary></summary>
        SteamNetworkingGetConfigValue_OK = 1,
        /// <summary>A value was not set at this level, but the effective (inherited) value was returned.</summary>
        SteamNetworkingGetConfigValue_OKInherited = 2,
        /// <summary></summary>
        _Force32Bit = 2147483647
    }
}