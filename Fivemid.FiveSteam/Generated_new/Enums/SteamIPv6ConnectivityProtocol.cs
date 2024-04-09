using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ESteamIPv6ConnectivityProtocol</summary>
    public enum SteamIPv6ConnectivityProtocol : int
    {
        /// <summary>k_ESteamIPv6ConnectivityProtocol_Invalid</summary>
        Invalid = 0,
        /// <summary>k_ESteamIPv6ConnectivityProtocol_HTTP</summary>
        HTTP = 1,
        /// <summary>k_ESteamIPv6ConnectivityProtocol_UDP</summary>
        UDP = 2
    }
}