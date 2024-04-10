using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ESteamNetworkingConfigDataType</summary>
    public enum SteamNetworkingConfigDataType : int
    {
        /// <summary>k_ESteamNetworkingConfig_Int32</summary>
        SteamNetworkingConfig_Int32 = 1,
        /// <summary>k_ESteamNetworkingConfig_Int64</summary>
        SteamNetworkingConfig_Int64 = 2,
        /// <summary>k_ESteamNetworkingConfig_Float</summary>
        SteamNetworkingConfig_Float = 3,
        /// <summary>k_ESteamNetworkingConfig_String</summary>
        SteamNetworkingConfig_String = 4,
        /// <summary>k_ESteamNetworkingConfig_Ptr</summary>
        SteamNetworkingConfig_Ptr = 5,
        /// <summary>k_ESteamNetworkingConfigDataType__Force32Bit</summary>
        _Force32Bit = 2147483647
    }
}