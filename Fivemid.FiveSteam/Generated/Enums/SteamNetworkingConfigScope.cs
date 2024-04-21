using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for ESteamNetworkingConfigScope
    public enum SteamNetworkingConfigScope : int
    {
        /// missing documentation for ESteamNetworkingConfigScope.k_ESteamNetworkingConfig_Global
        SteamNetworkingConfig_Global = 1,
        /// missing documentation for ESteamNetworkingConfigScope.k_ESteamNetworkingConfig_SocketsInterface
        SteamNetworkingConfig_SocketsInterface = 2,
        /// missing documentation for ESteamNetworkingConfigScope.k_ESteamNetworkingConfig_ListenSocket
        SteamNetworkingConfig_ListenSocket = 3,
        /// missing documentation for ESteamNetworkingConfigScope.k_ESteamNetworkingConfig_Connection
        SteamNetworkingConfig_Connection = 4,
        /// missing documentation for ESteamNetworkingConfigScope.k_ESteamNetworkingConfigScope__Force32Bit
        _Force32Bit = 2147483647
    }
}