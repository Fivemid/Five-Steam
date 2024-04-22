using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// <br />
    /// Configuration options<br /></summary>
    public enum SteamNetworkingConfigValueType : int
    {
        /// <summary></summary>
        SteamNetworkingConfig_Invalid = 0,
        /// <summary>[connection int32] Timeout value (in ms) to use when first connecting</summary>
        SteamNetworkingConfig_TimeoutInitial = 24,
        /// <summary>[connection int32] Timeout value (in ms) to use after connection is established</summary>
        SteamNetworkingConfig_TimeoutConnected = 25,
        /// <summary>[connection int32] Upper limit of buffered pending bytes to be sent,
        /// if this is reached SendMessage will return k_EResultLimitExceeded
        /// Default is 512k (524288 bytes)</summary>
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
        /// <summary>[connection int32] Minimum/maximum send rate clamp, 0 is no limit.
        /// This value will control the min/max allowed sending rate that
        /// bandwidth estimation is allowed to reach.  Default is 0 (no-limit)</summary>
        SteamNetworkingConfig_SendRateMin = 10,
        /// <summary></summary>
        SteamNetworkingConfig_SendRateMax = 11,
        /// <summary>[connection int32] Nagle time, in microseconds.  When SendMessage is called, if
        /// the outgoing message is less than the size of the MTU, it will be
        /// queued for a delay equal to the Nagle timer value.  This is to ensure
        /// that if the application sends several small messages rapidly, they are
        /// coalesced into a single packet.
        /// See historical RFC 896.  Value is in microseconds.
        /// Default is 5000us (5ms).</summary>
        SteamNetworkingConfig_NagleTime = 12,
        /// <summary>[connection int32] Don't automatically fail IP connections that don't have
        /// strong auth.  On clients, this means we will attempt the connection even if
        /// we don't know our identity or can't get a cert.  On the server, it means that
        /// we won't automatically reject a connection due to a failure to authenticate.
        /// (You can examine the incoming connection and decide whether to accept it.)</summary>
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
        /// <summary>[global float, 0--100] Randomly discard N pct of packets instead of sending/recv
        /// This is a global option only, since it is applied at a low level
        /// where we don't have much context</summary>
        SteamNetworkingConfig_FakePacketLoss_Send = 2,
        /// <summary></summary>
        SteamNetworkingConfig_FakePacketLoss_Recv = 3,
        /// <summary>[global int32].  Delay all outbound/inbound packets by N ms</summary>
        SteamNetworkingConfig_FakePacketLag_Send = 4,
        /// <summary></summary>
        SteamNetworkingConfig_FakePacketLag_Recv = 5,
        /// <summary>[global float] 0-100 Percentage of packets we will add additional delay
        /// to (causing them to be reordered)</summary>
        SteamNetworkingConfig_FakePacketReorder_Send = 6,
        /// <summary></summary>
        SteamNetworkingConfig_FakePacketReorder_Recv = 7,
        /// <summary>[global int32] Extra delay, in ms, to apply to reordered packets.</summary>
        SteamNetworkingConfig_FakePacketReorder_Time = 8,
        /// <summary>[global float 0--100] Globally duplicate some percentage of packets we send</summary>
        SteamNetworkingConfig_FakePacketDup_Send = 26,
        /// <summary></summary>
        SteamNetworkingConfig_FakePacketDup_Recv = 27,
        /// <summary>[global int32] Amount of delay, in ms, to delay duplicated packets.
        /// (We chose a random delay between 0 and this value)</summary>
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
        /// <summary>[int32 global] If the first N pings to a port all fail, mark that port as unavailable for
        /// a while, and try a different one.  Some ISPs and routers may drop the first
        /// packet, so setting this to 1 may greatly disrupt communications.</summary>
        SteamNetworkingConfig_SDRClient_ConsecutitivePingTimeoutsFailInitial = 19,
        /// <summary>[int32 global] If N consecutive pings to a port fail, after having received successful
        /// communication, mark that port as unavailable for a while, and try a
        /// different one.</summary>
        SteamNetworkingConfig_SDRClient_ConsecutitivePingTimeoutsFail = 20,
        /// <summary>[int32 global] Minimum number of lifetime pings we need to send, before we think our estimate
        /// is solid.  The first ping to each cluster is very often delayed because of NAT,
        /// routers not having the best route, etc.  Until we've sent a sufficient number
        /// of pings, our estimate is often inaccurate.  Keep pinging until we get this
        /// many pings.</summary>
        SteamNetworkingConfig_SDRClient_MinPingsBeforePingAccurate = 21,
        /// <summary>[int32 global] Set all steam datagram traffic to originate from the same
        /// local port. By default, we open up a new UDP socket (on a different local
        /// port) for each relay.  This is slightly less optimal, but it works around
        /// some routers that don't implement NAT properly.  If you have intermittent
        /// problems talking to relays that might be NAT related, try toggling
        /// this flag</summary>
        SteamNetworkingConfig_SDRClient_SingleSocket = 22,
        /// <summary>[global string] Code of relay cluster to force use.  If not empty, we will
        /// only use relays in that cluster.  E.g. 'iad'</summary>
        SteamNetworkingConfig_SDRClient_ForceRelayCluster = 29,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_SDRClient_DevTicket
        SteamNetworkingConfig_SDRClient_DevTicket = 30,
        /// <summary>[global string] For debugging.  Override list of relays from the config with
        /// this set (maybe just one).  Comma-separated list.</summary>
        SteamNetworkingConfig_SDRClient_ForceProxyAddr = 31,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_SDRClient_FakeClusterPing
        SteamNetworkingConfig_SDRClient_FakeClusterPing = 36,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_SDRClient_LimitPingProbesToNearestN
        SteamNetworkingConfig_SDRClient_LimitPingProbesToNearestN = 60,
        /// <summary>[connection int32] RTT calculations for inline pings and replies</summary>
        SteamNetworkingConfig_LogLevel_AckRTT = 13,
        /// <summary>[connection int32] log SNP packets send</summary>
        SteamNetworkingConfig_LogLevel_PacketDecode = 14,
        /// <summary>[connection int32] log each message send/recv</summary>
        SteamNetworkingConfig_LogLevel_Message = 15,
        /// <summary>[connection int32] dropped packets</summary>
        SteamNetworkingConfig_LogLevel_PacketGaps = 16,
        /// <summary>[connection int32] P2P rendezvous messages</summary>
        SteamNetworkingConfig_LogLevel_P2PRendezvous = 17,
        /// <summary>[global int32] Ping relays</summary>
        SteamNetworkingConfig_LogLevel_SDRRelayPings = 18,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_ECN
        SteamNetworkingConfig_ECN = 999,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_DELETED_EnumerateDevVars
        SteamNetworkingConfig_DELETED_EnumerateDevVars = 35,
        /// missing documentation for ESteamNetworkingConfigValue.k_ESteamNetworkingConfigValue__Force32Bit
        SteamNetworkingConfigValue__Force32Bit = 2147483647
    }
}