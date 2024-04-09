using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ESteamNetworkingIdentityType</summary>
    public enum SteamNetworkingIdentityType : int
    {
        /// <summary>k_ESteamNetworkingIdentityType_Invalid</summary>
        Invalid = 0,
        /// <summary>k_ESteamNetworkingIdentityType_SteamID</summary>
        SteamID = 16,
        /// <summary>k_ESteamNetworkingIdentityType_XboxPairwiseID</summary>
        XboxPairwiseID = 17,
        /// <summary>k_ESteamNetworkingIdentityType_SonyPSN</summary>
        SonyPSN = 18,
        /// <summary>k_ESteamNetworkingIdentityType_GoogleStadia</summary>
        GoogleStadia = 19,
        /// <summary>k_ESteamNetworkingIdentityType_IPAddress</summary>
        IPAddress = 1,
        /// <summary>k_ESteamNetworkingIdentityType_GenericString</summary>
        GenericString = 2,
        /// <summary>k_ESteamNetworkingIdentityType_GenericBytes</summary>
        GenericBytes = 3,
        /// <summary>k_ESteamNetworkingIdentityType_UnknownType</summary>
        UnknownType = 4,
        /// <summary>k_ESteamNetworkingIdentityType__Force32bit</summary>
        _Force32bit = 2147483647
    }
}