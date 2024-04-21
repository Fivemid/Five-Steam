using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for SteamNetConnectionRealTimeStatus_t
    public unsafe struct SteamNetConnectionRealTimeStatus
    {
        /// missing documentation for SteamNetConnectionRealTimeStatus_t.m_eState
        public SteamNetworkingConnectionState eState;
        /// missing documentation for SteamNetConnectionRealTimeStatus_t.m_nPing
        public int nPing;
        /// missing documentation for SteamNetConnectionRealTimeStatus_t.m_flConnectionQualityLocal
        public float flConnectionQualityLocal;
        /// missing documentation for SteamNetConnectionRealTimeStatus_t.m_flConnectionQualityRemote
        public float flConnectionQualityRemote;
        /// missing documentation for SteamNetConnectionRealTimeStatus_t.m_flOutPacketsPerSec
        public float flOutPacketsPerSec;
        /// missing documentation for SteamNetConnectionRealTimeStatus_t.m_flOutBytesPerSec
        public float flOutBytesPerSec;
        /// missing documentation for SteamNetConnectionRealTimeStatus_t.m_flInPacketsPerSec
        public float flInPacketsPerSec;
        /// missing documentation for SteamNetConnectionRealTimeStatus_t.m_flInBytesPerSec
        public float flInBytesPerSec;
        /// missing documentation for SteamNetConnectionRealTimeStatus_t.m_nSendRateBytesPerSecond
        public int nSendRateBytesPerSecond;
        /// missing documentation for SteamNetConnectionRealTimeStatus_t.m_cbPendingUnreliable
        public int cbPendingUnreliable;
        /// missing documentation for SteamNetConnectionRealTimeStatus_t.m_cbPendingReliable
        public int cbPendingReliable;
        /// missing documentation for SteamNetConnectionRealTimeStatus_t.m_cbSentUnackedReliable
        public int cbSentUnackedReliable;
        /// missing documentation for SteamNetConnectionRealTimeStatus_t.m_usecQueueTime
        public SteamNetworkingMicroseconds usecQueueTime;
        /// missing documentation for SteamNetConnectionRealTimeStatus_t.reserved
        public FixedArray_uint16 reserved;
    }
}