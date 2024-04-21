using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for ESteamNetworkingConfigValue
    public enum SteamNetworkingConfigValueType : int
    {
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_Invalid
        SteamNetworkingConfig_Invalid = 0,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_TimeoutInitial
        SteamNetworkingConfig_TimeoutInitial = 24,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_TimeoutConnected
        SteamNetworkingConfig_TimeoutConnected = 25,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_SendBufferSize
        SteamNetworkingConfig_SendBufferSize = 9,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_RecvBufferSize
        SteamNetworkingConfig_RecvBufferSize = 47,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_RecvBufferMessages
        SteamNetworkingConfig_RecvBufferMessages = 48,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_RecvMaxMessageSize
        SteamNetworkingConfig_RecvMaxMessageSize = 49,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_RecvMaxSegmentsPerPacket
        SteamNetworkingConfig_RecvMaxSegmentsPerPacket = 50,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_ConnectionUserData
        SteamNetworkingConfig_ConnectionUserData = 40,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_SendRateMin
        SteamNetworkingConfig_SendRateMin = 10,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_SendRateMax
        SteamNetworkingConfig_SendRateMax = 11,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_NagleTime
        SteamNetworkingConfig_NagleTime = 12,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_IP_AllowWithoutAuth
        SteamNetworkingConfig_IP_AllowWithoutAuth = 23,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_MTU_PacketSize
        SteamNetworkingConfig_MTU_PacketSize = 32,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_MTU_DataSize
        SteamNetworkingConfig_MTU_DataSize = 33,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_Unencrypted
        SteamNetworkingConfig_Unencrypted = 34,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_SymmetricConnect
        SteamNetworkingConfig_SymmetricConnect = 37,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_LocalVirtualPort
        SteamNetworkingConfig_LocalVirtualPort = 38,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_DualWifi_Enable
        SteamNetworkingConfig_DualWifi_Enable = 39,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_EnableDiagnosticsUI
        SteamNetworkingConfig_EnableDiagnosticsUI = 46,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_FakePacketLoss_Send
        SteamNetworkingConfig_FakePacketLoss_Send = 2,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_FakePacketLoss_Recv
        SteamNetworkingConfig_FakePacketLoss_Recv = 3,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_FakePacketLag_Send
        SteamNetworkingConfig_FakePacketLag_Send = 4,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_FakePacketLag_Recv
        SteamNetworkingConfig_FakePacketLag_Recv = 5,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_FakePacketReorder_Send
        SteamNetworkingConfig_FakePacketReorder_Send = 6,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_FakePacketReorder_Recv
        SteamNetworkingConfig_FakePacketReorder_Recv = 7,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_FakePacketReorder_Time
        SteamNetworkingConfig_FakePacketReorder_Time = 8,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_FakePacketDup_Send
        SteamNetworkingConfig_FakePacketDup_Send = 26,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_FakePacketDup_Recv
        SteamNetworkingConfig_FakePacketDup_Recv = 27,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_FakePacketDup_TimeMax
        SteamNetworkingConfig_FakePacketDup_TimeMax = 28,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_PacketTraceMaxBytes
        SteamNetworkingConfig_PacketTraceMaxBytes = 41,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_FakeRateLimit_Send_Rate
        SteamNetworkingConfig_FakeRateLimit_Send_Rate = 42,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_FakeRateLimit_Send_Burst
        SteamNetworkingConfig_FakeRateLimit_Send_Burst = 43,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_FakeRateLimit_Recv_Rate
        SteamNetworkingConfig_FakeRateLimit_Recv_Rate = 44,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_FakeRateLimit_Recv_Burst
        SteamNetworkingConfig_FakeRateLimit_Recv_Burst = 45,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_OutOfOrderCorrectionWindowMicroseconds
        SteamNetworkingConfig_OutOfOrderCorrectionWindowMicroseconds = 51,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_Callback_ConnectionStatusChanged
        SteamNetworkingConfig_Callback_ConnectionStatusChanged = 201,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_Callback_AuthStatusChanged
        SteamNetworkingConfig_Callback_AuthStatusChanged = 202,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_Callback_RelayNetworkStatusChanged
        SteamNetworkingConfig_Callback_RelayNetworkStatusChanged = 203,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_Callback_MessagesSessionRequest
        SteamNetworkingConfig_Callback_MessagesSessionRequest = 204,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_Callback_MessagesSessionFailed
        SteamNetworkingConfig_Callback_MessagesSessionFailed = 205,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_Callback_CreateConnectionSignaling
        SteamNetworkingConfig_Callback_CreateConnectionSignaling = 206,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_Callback_FakeIPResult
        SteamNetworkingConfig_Callback_FakeIPResult = 207,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_P2P_STUN_ServerList
        SteamNetworkingConfig_P2P_STUN_ServerList = 103,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_P2P_Transport_ICE_Enable
        SteamNetworkingConfig_P2P_Transport_ICE_Enable = 104,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_P2P_Transport_ICE_Penalty
        SteamNetworkingConfig_P2P_Transport_ICE_Penalty = 105,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_P2P_Transport_SDR_Penalty
        SteamNetworkingConfig_P2P_Transport_SDR_Penalty = 106,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_P2P_TURN_ServerList
        SteamNetworkingConfig_P2P_TURN_ServerList = 107,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_P2P_TURN_UserList
        SteamNetworkingConfig_P2P_TURN_UserList = 108,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_P2P_TURN_PassList
        SteamNetworkingConfig_P2P_TURN_PassList = 109,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_P2P_Transport_ICE_Implementation
        SteamNetworkingConfig_P2P_Transport_ICE_Implementation = 110,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_SDRClient_ConsecutitivePingTimeoutsFailInitial
        SteamNetworkingConfig_SDRClient_ConsecutitivePingTimeoutsFailInitial = 19,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_SDRClient_ConsecutitivePingTimeoutsFail
        SteamNetworkingConfig_SDRClient_ConsecutitivePingTimeoutsFail = 20,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_SDRClient_MinPingsBeforePingAccurate
        SteamNetworkingConfig_SDRClient_MinPingsBeforePingAccurate = 21,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_SDRClient_SingleSocket
        SteamNetworkingConfig_SDRClient_SingleSocket = 22,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_SDRClient_ForceRelayCluster
        SteamNetworkingConfig_SDRClient_ForceRelayCluster = 29,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_SDRClient_DevTicket
        SteamNetworkingConfig_SDRClient_DevTicket = 30,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_SDRClient_ForceProxyAddr
        SteamNetworkingConfig_SDRClient_ForceProxyAddr = 31,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_SDRClient_FakeClusterPing
        SteamNetworkingConfig_SDRClient_FakeClusterPing = 36,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_SDRClient_LimitPingProbesToNearestN
        SteamNetworkingConfig_SDRClient_LimitPingProbesToNearestN = 60,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_LogLevel_AckRTT
        SteamNetworkingConfig_LogLevel_AckRTT = 13,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_LogLevel_PacketDecode
        SteamNetworkingConfig_LogLevel_PacketDecode = 14,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_LogLevel_Message
        SteamNetworkingConfig_LogLevel_Message = 15,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_LogLevel_PacketGaps
        SteamNetworkingConfig_LogLevel_PacketGaps = 16,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_LogLevel_P2PRendezvous
        SteamNetworkingConfig_LogLevel_P2PRendezvous = 17,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_LogLevel_SDRRelayPings
        SteamNetworkingConfig_LogLevel_SDRRelayPings = 18,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_ECN
        SteamNetworkingConfig_ECN = 999,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_DELETED_EnumerateDevVars
        SteamNetworkingConfig_DELETED_EnumerateDevVars = 35,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfigValue__Force32Bit
        SteamNetworkingConfigValue__Force32Bit = 2147483647
    }
}