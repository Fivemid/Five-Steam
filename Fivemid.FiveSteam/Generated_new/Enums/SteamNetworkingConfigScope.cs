using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ESteamNetworkingConfigScope</summary>
    public enum SteamNetworkingConfigScope : int
    {
        /// <summary>k_ESteamNetworkingConfig_Global</summary>
        SteamNetworkingConfig_Global = 1,
        /// <summary>k_ESteamNetworkingConfig_SocketsInterface</summary>
        SteamNetworkingConfig_SocketsInterface = 2,
        /// <summary>k_ESteamNetworkingConfig_ListenSocket</summary>
        SteamNetworkingConfig_ListenSocket = 3,
        /// <summary>k_ESteamNetworkingConfig_Connection</summary>
        SteamNetworkingConfig_Connection = 4,
        /// <summary>k_ESteamNetworkingConfigScope__Force32Bit</summary>
        _Force32Bit = 2147483647
    }
}