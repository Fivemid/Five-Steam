using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ESteamNetworkingSocketsDebugOutputType</summary>
    public enum SteamNetworkingSocketsDebugOutputType : int
    {
        /// <summary>k_ESteamNetworkingSocketsDebugOutputType_None</summary>
        None = 0,
        /// <summary>k_ESteamNetworkingSocketsDebugOutputType_Bug</summary>
        Bug = 1,
        /// <summary>k_ESteamNetworkingSocketsDebugOutputType_Error</summary>
        Error = 2,
        /// <summary>k_ESteamNetworkingSocketsDebugOutputType_Important</summary>
        Important = 3,
        /// <summary>k_ESteamNetworkingSocketsDebugOutputType_Warning</summary>
        Warning = 4,
        /// <summary>k_ESteamNetworkingSocketsDebugOutputType_Msg</summary>
        Msg = 5,
        /// <summary>k_ESteamNetworkingSocketsDebugOutputType_Verbose</summary>
        Verbose = 6,
        /// <summary>k_ESteamNetworkingSocketsDebugOutputType_Debug</summary>
        Debug = 7,
        /// <summary>k_ESteamNetworkingSocketsDebugOutputType_Everything</summary>
        Everything = 8,
        /// <summary>k_ESteamNetworkingSocketsDebugOutputType__Force32Bit</summary>
        _Force32Bit = 2147483647
    }
}