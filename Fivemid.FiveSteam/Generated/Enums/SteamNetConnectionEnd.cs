using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for ESteamNetConnectionEnd
    public enum SteamNetConnectionEnd : int
    {
        /// missing documentation for ESteamNetConnectionEnd.k_ESteamNetConnectionEnd_Invalid
        Invalid = 0,
        /// missing documentation for ESteamNetConnectionEnd.k_ESteamNetConnectionEnd_App_Min
        App_Min = 1000,
        /// missing documentation for ESteamNetConnectionEnd.k_ESteamNetConnectionEnd_App_Generic
        App_Generic = 1000,
        /// missing documentation for ESteamNetConnectionEnd.k_ESteamNetConnectionEnd_App_Max
        App_Max = 1999,
        /// missing documentation for ESteamNetConnectionEnd.k_ESteamNetConnectionEnd_AppException_Min
        AppException_Min = 2000,
        /// missing documentation for ESteamNetConnectionEnd.k_ESteamNetConnectionEnd_AppException_Generic
        AppException_Generic = 2000,
        /// missing documentation for ESteamNetConnectionEnd.k_ESteamNetConnectionEnd_AppException_Max
        AppException_Max = 2999,
        /// missing documentation for ESteamNetConnectionEnd.k_ESteamNetConnectionEnd_Local_Min
        Local_Min = 3000,
        /// missing documentation for ESteamNetConnectionEnd.k_ESteamNetConnectionEnd_Local_OfflineMode
        Local_OfflineMode = 3001,
        /// missing documentation for ESteamNetConnectionEnd.k_ESteamNetConnectionEnd_Local_ManyRelayConnectivity
        Local_ManyRelayConnectivity = 3002,
        /// missing documentation for ESteamNetConnectionEnd.k_ESteamNetConnectionEnd_Local_HostedServerPrimaryRelay
        Local_HostedServerPrimaryRelay = 3003,
        /// missing documentation for ESteamNetConnectionEnd.k_ESteamNetConnectionEnd_Local_NetworkConfig
        Local_NetworkConfig = 3004,
        /// missing documentation for ESteamNetConnectionEnd.k_ESteamNetConnectionEnd_Local_Rights
        Local_Rights = 3005,
        /// missing documentation for ESteamNetConnectionEnd.k_ESteamNetConnectionEnd_Local_P2P_ICE_NoPublicAddresses
        Local_P2P_ICE_NoPublicAddresses = 3006,
        /// missing documentation for ESteamNetConnectionEnd.k_ESteamNetConnectionEnd_Local_Max
        Local_Max = 3999,
        /// missing documentation for ESteamNetConnectionEnd.k_ESteamNetConnectionEnd_Remote_Min
        Remote_Min = 4000,
        /// missing documentation for ESteamNetConnectionEnd.k_ESteamNetConnectionEnd_Remote_Timeout
        Remote_Timeout = 4001,
        /// missing documentation for ESteamNetConnectionEnd.k_ESteamNetConnectionEnd_Remote_BadCrypt
        Remote_BadCrypt = 4002,
        /// missing documentation for ESteamNetConnectionEnd.k_ESteamNetConnectionEnd_Remote_BadCert
        Remote_BadCert = 4003,
        /// missing documentation for ESteamNetConnectionEnd.k_ESteamNetConnectionEnd_Remote_BadProtocolVersion
        Remote_BadProtocolVersion = 4006,
        /// missing documentation for ESteamNetConnectionEnd.k_ESteamNetConnectionEnd_Remote_P2P_ICE_NoPublicAddresses
        Remote_P2P_ICE_NoPublicAddresses = 4007,
        /// missing documentation for ESteamNetConnectionEnd.k_ESteamNetConnectionEnd_Remote_Max
        Remote_Max = 4999,
        /// missing documentation for ESteamNetConnectionEnd.k_ESteamNetConnectionEnd_Misc_Min
        Misc_Min = 5000,
        /// missing documentation for ESteamNetConnectionEnd.k_ESteamNetConnectionEnd_Misc_Generic
        Misc_Generic = 5001,
        /// missing documentation for ESteamNetConnectionEnd.k_ESteamNetConnectionEnd_Misc_InternalError
        Misc_InternalError = 5002,
        /// missing documentation for ESteamNetConnectionEnd.k_ESteamNetConnectionEnd_Misc_Timeout
        Misc_Timeout = 5003,
        /// missing documentation for ESteamNetConnectionEnd.k_ESteamNetConnectionEnd_Misc_SteamConnectivity
        Misc_SteamConnectivity = 5005,
        /// missing documentation for ESteamNetConnectionEnd.k_ESteamNetConnectionEnd_Misc_NoRelaySessionsToClient
        Misc_NoRelaySessionsToClient = 5006,
        /// missing documentation for ESteamNetConnectionEnd.k_ESteamNetConnectionEnd_Misc_P2P_Rendezvous
        Misc_P2P_Rendezvous = 5008,
        /// missing documentation for ESteamNetConnectionEnd.k_ESteamNetConnectionEnd_Misc_P2P_NAT_Firewall
        Misc_P2P_NAT_Firewall = 5009,
        /// missing documentation for ESteamNetConnectionEnd.k_ESteamNetConnectionEnd_Misc_PeerSentNoConnection
        Misc_PeerSentNoConnection = 5010,
        /// missing documentation for ESteamNetConnectionEnd.k_ESteamNetConnectionEnd_Misc_Max
        Misc_Max = 5999,
        /// missing documentation for ESteamNetConnectionEnd.k_ESteamNetConnectionEnd__Force32Bit
        _Force32Bit = 2147483647
    }
}