using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// <br />
    /// Different configuration values have different data types<br /></summary>
    public enum SteamNetworkingConfigDataType : int
    {
        /// <summary></summary>
        SteamNetworkingConfig_Int32 = 1,
        /// <summary></summary>
        SteamNetworkingConfig_Int64 = 2,
        /// <summary></summary>
        SteamNetworkingConfig_Float = 3,
        /// <summary></summary>
        SteamNetworkingConfig_String = 4,
        /// missing documentation for ESteamNetworkingConfigDataType.k_ESteamNetworkingConfig_Ptr
        SteamNetworkingConfig_Ptr = 5,
        /// missing documentation for ESteamNetworkingConfigDataType.k_ESteamNetworkingConfigDataType__Force32Bit
        _Force32Bit = 2147483647
    }
}