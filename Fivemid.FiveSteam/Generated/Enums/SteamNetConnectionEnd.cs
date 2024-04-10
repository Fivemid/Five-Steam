using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ESteamNetConnectionEnd</summary>
    public enum SteamNetConnectionEnd : int
    {
        /// <summary>k_ESteamNetConnectionEnd_Invalid</summary>
        Invalid = 0,
        /// <summary>k_ESteamNetConnectionEnd_App_Min</summary>
        App_Min = 1000,
        /// <summary>k_ESteamNetConnectionEnd_App_Generic</summary>
        App_Generic = 1000,
        /// <summary>k_ESteamNetConnectionEnd_App_Max</summary>
        App_Max = 1999,
        /// <summary>k_ESteamNetConnectionEnd_AppException_Min</summary>
        AppException_Min = 2000,
        /// <summary>k_ESteamNetConnectionEnd_AppException_Generic</summary>
        AppException_Generic = 2000,
        /// <summary>k_ESteamNetConnectionEnd_AppException_Max</summary>
        AppException_Max = 2999,
        /// <summary>k_ESteamNetConnectionEnd_Local_Min</summary>
        Local_Min = 3000,
        /// <summary>k_ESteamNetConnectionEnd_Local_OfflineMode</summary>
        Local_OfflineMode = 3001,
        /// <summary>k_ESteamNetConnectionEnd_Local_ManyRelayConnectivity</summary>
        Local_ManyRelayConnectivity = 3002,
        /// <summary>k_ESteamNetConnectionEnd_Local_HostedServerPrimaryRelay</summary>
        Local_HostedServerPrimaryRelay = 3003,
        /// <summary>k_ESteamNetConnectionEnd_Local_NetworkConfig</summary>
        Local_NetworkConfig = 3004,
        /// <summary>k_ESteamNetConnectionEnd_Local_Rights</summary>
        Local_Rights = 3005,
        /// <summary>k_ESteamNetConnectionEnd_Local_P2P_ICE_NoPublicAddresses</summary>
        Local_P2P_ICE_NoPublicAddresses = 3006,
        /// <summary>k_ESteamNetConnectionEnd_Local_Max</summary>
        Local_Max = 3999,
        /// <summary>k_ESteamNetConnectionEnd_Remote_Min</summary>
        Remote_Min = 4000,
        /// <summary>k_ESteamNetConnectionEnd_Remote_Timeout</summary>
        Remote_Timeout = 4001,
        /// <summary>k_ESteamNetConnectionEnd_Remote_BadCrypt</summary>
        Remote_BadCrypt = 4002,
        /// <summary>k_ESteamNetConnectionEnd_Remote_BadCert</summary>
        Remote_BadCert = 4003,
        /// <summary>k_ESteamNetConnectionEnd_Remote_BadProtocolVersion</summary>
        Remote_BadProtocolVersion = 4006,
        /// <summary>k_ESteamNetConnectionEnd_Remote_P2P_ICE_NoPublicAddresses</summary>
        Remote_P2P_ICE_NoPublicAddresses = 4007,
        /// <summary>k_ESteamNetConnectionEnd_Remote_Max</summary>
        Remote_Max = 4999,
        /// <summary>k_ESteamNetConnectionEnd_Misc_Min</summary>
        Misc_Min = 5000,
        /// <summary>k_ESteamNetConnectionEnd_Misc_Generic</summary>
        Misc_Generic = 5001,
        /// <summary>k_ESteamNetConnectionEnd_Misc_InternalError</summary>
        Misc_InternalError = 5002,
        /// <summary>k_ESteamNetConnectionEnd_Misc_Timeout</summary>
        Misc_Timeout = 5003,
        /// <summary>k_ESteamNetConnectionEnd_Misc_SteamConnectivity</summary>
        Misc_SteamConnectivity = 5005,
        /// <summary>k_ESteamNetConnectionEnd_Misc_NoRelaySessionsToClient</summary>
        Misc_NoRelaySessionsToClient = 5006,
        /// <summary>k_ESteamNetConnectionEnd_Misc_P2P_Rendezvous</summary>
        Misc_P2P_Rendezvous = 5008,
        /// <summary>k_ESteamNetConnectionEnd_Misc_P2P_NAT_Firewall</summary>
        Misc_P2P_NAT_Firewall = 5009,
        /// <summary>k_ESteamNetConnectionEnd_Misc_PeerSentNoConnection</summary>
        Misc_PeerSentNoConnection = 5010,
        /// <summary>k_ESteamNetConnectionEnd_Misc_Max</summary>
        Misc_Max = 5999,
        /// <summary>k_ESteamNetConnectionEnd__Force32Bit</summary>
        _Force32Bit = 2147483647
    }
}