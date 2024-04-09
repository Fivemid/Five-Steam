using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ESteamNetworkingConfigValue</summary>
    public enum SteamNetworkingConfigValueType : int
    {
        /// <summary>k_ESteamNetworkingConfig_Invalid</summary>
        SteamNetworkingConfig_Invalid = 0,
        /// <summary>k_ESteamNetworkingConfig_TimeoutInitial</summary>
        SteamNetworkingConfig_TimeoutInitial = 24,
        /// <summary>k_ESteamNetworkingConfig_TimeoutConnected</summary>
        SteamNetworkingConfig_TimeoutConnected = 25,
        /// <summary>k_ESteamNetworkingConfig_SendBufferSize</summary>
        SteamNetworkingConfig_SendBufferSize = 9,
        /// <summary>k_ESteamNetworkingConfig_RecvBufferSize</summary>
        SteamNetworkingConfig_RecvBufferSize = 47,
        /// <summary>k_ESteamNetworkingConfig_RecvBufferMessages</summary>
        SteamNetworkingConfig_RecvBufferMessages = 48,
        /// <summary>k_ESteamNetworkingConfig_RecvMaxMessageSize</summary>
        SteamNetworkingConfig_RecvMaxMessageSize = 49,
        /// <summary>k_ESteamNetworkingConfig_RecvMaxSegmentsPerPacket</summary>
        SteamNetworkingConfig_RecvMaxSegmentsPerPacket = 50,
        /// <summary>k_ESteamNetworkingConfig_ConnectionUserData</summary>
        SteamNetworkingConfig_ConnectionUserData = 40,
        /// <summary>k_ESteamNetworkingConfig_SendRateMin</summary>
        SteamNetworkingConfig_SendRateMin = 10,
        /// <summary>k_ESteamNetworkingConfig_SendRateMax</summary>
        SteamNetworkingConfig_SendRateMax = 11,
        /// <summary>k_ESteamNetworkingConfig_NagleTime</summary>
        SteamNetworkingConfig_NagleTime = 12,
        /// <summary>k_ESteamNetworkingConfig_IP_AllowWithoutAuth</summary>
        SteamNetworkingConfig_IP_AllowWithoutAuth = 23,
        /// <summary>k_ESteamNetworkingConfig_MTU_PacketSize</summary>
        SteamNetworkingConfig_MTU_PacketSize = 32,
        /// <summary>k_ESteamNetworkingConfig_MTU_DataSize</summary>
        SteamNetworkingConfig_MTU_DataSize = 33,
        /// <summary>k_ESteamNetworkingConfig_Unencrypted</summary>
        SteamNetworkingConfig_Unencrypted = 34,
        /// <summary>k_ESteamNetworkingConfig_SymmetricConnect</summary>
        SteamNetworkingConfig_SymmetricConnect = 37,
        /// <summary>k_ESteamNetworkingConfig_LocalVirtualPort</summary>
        SteamNetworkingConfig_LocalVirtualPort = 38,
        /// <summary>k_ESteamNetworkingConfig_DualWifi_Enable</summary>
        SteamNetworkingConfig_DualWifi_Enable = 39,
        /// <summary>k_ESteamNetworkingConfig_EnableDiagnosticsUI</summary>
        SteamNetworkingConfig_EnableDiagnosticsUI = 46,
        /// <summary>k_ESteamNetworkingConfig_FakePacketLoss_Send</summary>
        SteamNetworkingConfig_FakePacketLoss_Send = 2,
        /// <summary>k_ESteamNetworkingConfig_FakePacketLoss_Recv</summary>
        SteamNetworkingConfig_FakePacketLoss_Recv = 3,
        /// <summary>k_ESteamNetworkingConfig_FakePacketLag_Send</summary>
        SteamNetworkingConfig_FakePacketLag_Send = 4,
        /// <summary>k_ESteamNetworkingConfig_FakePacketLag_Recv</summary>
        SteamNetworkingConfig_FakePacketLag_Recv = 5,
        /// <summary>k_ESteamNetworkingConfig_FakePacketReorder_Send</summary>
        SteamNetworkingConfig_FakePacketReorder_Send = 6,
        /// <summary>k_ESteamNetworkingConfig_FakePacketReorder_Recv</summary>
        SteamNetworkingConfig_FakePacketReorder_Recv = 7,
        /// <summary>k_ESteamNetworkingConfig_FakePacketReorder_Time</summary>
        SteamNetworkingConfig_FakePacketReorder_Time = 8,
        /// <summary>k_ESteamNetworkingConfig_FakePacketDup_Send</summary>
        SteamNetworkingConfig_FakePacketDup_Send = 26,
        /// <summary>k_ESteamNetworkingConfig_FakePacketDup_Recv</summary>
        SteamNetworkingConfig_FakePacketDup_Recv = 27,
        /// <summary>k_ESteamNetworkingConfig_FakePacketDup_TimeMax</summary>
        SteamNetworkingConfig_FakePacketDup_TimeMax = 28,
        /// <summary>k_ESteamNetworkingConfig_PacketTraceMaxBytes</summary>
        SteamNetworkingConfig_PacketTraceMaxBytes = 41,
        /// <summary>k_ESteamNetworkingConfig_FakeRateLimit_Send_Rate</summary>
        SteamNetworkingConfig_FakeRateLimit_Send_Rate = 42,
        /// <summary>k_ESteamNetworkingConfig_FakeRateLimit_Send_Burst</summary>
        SteamNetworkingConfig_FakeRateLimit_Send_Burst = 43,
        /// <summary>k_ESteamNetworkingConfig_FakeRateLimit_Recv_Rate</summary>
        SteamNetworkingConfig_FakeRateLimit_Recv_Rate = 44,
        /// <summary>k_ESteamNetworkingConfig_FakeRateLimit_Recv_Burst</summary>
        SteamNetworkingConfig_FakeRateLimit_Recv_Burst = 45,
        /// <summary>k_ESteamNetworkingConfig_OutOfOrderCorrectionWindowMicroseconds</summary>
        SteamNetworkingConfig_OutOfOrderCorrectionWindowMicroseconds = 51,
        /// <summary>k_ESteamNetworkingConfig_Callback_ConnectionStatusChanged</summary>
        SteamNetworkingConfig_Callback_ConnectionStatusChanged = 201,
        /// <summary>k_ESteamNetworkingConfig_Callback_AuthStatusChanged</summary>
        SteamNetworkingConfig_Callback_AuthStatusChanged = 202,
        /// <summary>k_ESteamNetworkingConfig_Callback_RelayNetworkStatusChanged</summary>
        SteamNetworkingConfig_Callback_RelayNetworkStatusChanged = 203,
        /// <summary>k_ESteamNetworkingConfig_Callback_MessagesSessionRequest</summary>
        SteamNetworkingConfig_Callback_MessagesSessionRequest = 204,
        /// <summary>k_ESteamNetworkingConfig_Callback_MessagesSessionFailed</summary>
        SteamNetworkingConfig_Callback_MessagesSessionFailed = 205,
        /// <summary>k_ESteamNetworkingConfig_Callback_CreateConnectionSignaling</summary>
        SteamNetworkingConfig_Callback_CreateConnectionSignaling = 206,
        /// <summary>k_ESteamNetworkingConfig_Callback_FakeIPResult</summary>
        SteamNetworkingConfig_Callback_FakeIPResult = 207,
        /// <summary>k_ESteamNetworkingConfig_P2P_STUN_ServerList</summary>
        SteamNetworkingConfig_P2P_STUN_ServerList = 103,
        /// <summary>k_ESteamNetworkingConfig_P2P_Transport_ICE_Enable</summary>
        SteamNetworkingConfig_P2P_Transport_ICE_Enable = 104,
        /// <summary>k_ESteamNetworkingConfig_P2P_Transport_ICE_Penalty</summary>
        SteamNetworkingConfig_P2P_Transport_ICE_Penalty = 105,
        /// <summary>k_ESteamNetworkingConfig_P2P_Transport_SDR_Penalty</summary>
        SteamNetworkingConfig_P2P_Transport_SDR_Penalty = 106,
        /// <summary>k_ESteamNetworkingConfig_P2P_TURN_ServerList</summary>
        SteamNetworkingConfig_P2P_TURN_ServerList = 107,
        /// <summary>k_ESteamNetworkingConfig_P2P_TURN_UserList</summary>
        SteamNetworkingConfig_P2P_TURN_UserList = 108,
        /// <summary>k_ESteamNetworkingConfig_P2P_TURN_PassList</summary>
        SteamNetworkingConfig_P2P_TURN_PassList = 109,
        /// <summary>k_ESteamNetworkingConfig_P2P_Transport_ICE_Implementation</summary>
        SteamNetworkingConfig_P2P_Transport_ICE_Implementation = 110,
        /// <summary>k_ESteamNetworkingConfig_SDRClient_ConsecutitivePingTimeoutsFailInitial</summary>
        SteamNetworkingConfig_SDRClient_ConsecutitivePingTimeoutsFailInitial = 19,
        /// <summary>k_ESteamNetworkingConfig_SDRClient_ConsecutitivePingTimeoutsFail</summary>
        SteamNetworkingConfig_SDRClient_ConsecutitivePingTimeoutsFail = 20,
        /// <summary>k_ESteamNetworkingConfig_SDRClient_MinPingsBeforePingAccurate</summary>
        SteamNetworkingConfig_SDRClient_MinPingsBeforePingAccurate = 21,
        /// <summary>k_ESteamNetworkingConfig_SDRClient_SingleSocket</summary>
        SteamNetworkingConfig_SDRClient_SingleSocket = 22,
        /// <summary>k_ESteamNetworkingConfig_SDRClient_ForceRelayCluster</summary>
        SteamNetworkingConfig_SDRClient_ForceRelayCluster = 29,
        /// <summary>k_ESteamNetworkingConfig_SDRClient_DevTicket</summary>
        SteamNetworkingConfig_SDRClient_DevTicket = 30,
        /// <summary>k_ESteamNetworkingConfig_SDRClient_ForceProxyAddr</summary>
        SteamNetworkingConfig_SDRClient_ForceProxyAddr = 31,
        /// <summary>k_ESteamNetworkingConfig_SDRClient_FakeClusterPing</summary>
        SteamNetworkingConfig_SDRClient_FakeClusterPing = 36,
        /// <summary>k_ESteamNetworkingConfig_SDRClient_LimitPingProbesToNearestN</summary>
        SteamNetworkingConfig_SDRClient_LimitPingProbesToNearestN = 60,
        /// <summary>k_ESteamNetworkingConfig_LogLevel_AckRTT</summary>
        SteamNetworkingConfig_LogLevel_AckRTT = 13,
        /// <summary>k_ESteamNetworkingConfig_LogLevel_PacketDecode</summary>
        SteamNetworkingConfig_LogLevel_PacketDecode = 14,
        /// <summary>k_ESteamNetworkingConfig_LogLevel_Message</summary>
        SteamNetworkingConfig_LogLevel_Message = 15,
        /// <summary>k_ESteamNetworkingConfig_LogLevel_PacketGaps</summary>
        SteamNetworkingConfig_LogLevel_PacketGaps = 16,
        /// <summary>k_ESteamNetworkingConfig_LogLevel_P2PRendezvous</summary>
        SteamNetworkingConfig_LogLevel_P2PRendezvous = 17,
        /// <summary>k_ESteamNetworkingConfig_LogLevel_SDRRelayPings</summary>
        SteamNetworkingConfig_LogLevel_SDRRelayPings = 18,
        /// <summary>k_ESteamNetworkingConfig_ECN</summary>
        SteamNetworkingConfig_ECN = 999,
        /// <summary>k_ESteamNetworkingConfig_DELETED_EnumerateDevVars</summary>
        SteamNetworkingConfig_DELETED_EnumerateDevVars = 35,
        /// <summary>k_ESteamNetworkingConfigValue__Force32Bit</summary>
        SteamNetworkingConfigValue__Force32Bit = 2147483647
    }
}