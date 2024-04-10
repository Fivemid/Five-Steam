using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamNetConnectionRealTimeStatus_t</summary>
    public unsafe struct SteamNetConnectionRealTimeStatus
    {
        /// <summary>ESteamNetworkingConnectionState m_eState</summary>
        public SteamNetworkingConnectionState eState;
        /// <summary>int m_nPing</summary>
        public int nPing;
        /// <summary>float m_flConnectionQualityLocal</summary>
        public float flConnectionQualityLocal;
        /// <summary>float m_flConnectionQualityRemote</summary>
        public float flConnectionQualityRemote;
        /// <summary>float m_flOutPacketsPerSec</summary>
        public float flOutPacketsPerSec;
        /// <summary>float m_flOutBytesPerSec</summary>
        public float flOutBytesPerSec;
        /// <summary>float m_flInPacketsPerSec</summary>
        public float flInPacketsPerSec;
        /// <summary>float m_flInBytesPerSec</summary>
        public float flInBytesPerSec;
        /// <summary>int m_nSendRateBytesPerSecond</summary>
        public int nSendRateBytesPerSecond;
        /// <summary>int m_cbPendingUnreliable</summary>
        public int cbPendingUnreliable;
        /// <summary>int m_cbPendingReliable</summary>
        public int cbPendingReliable;
        /// <summary>int m_cbSentUnackedReliable</summary>
        public int cbSentUnackedReliable;
        /// <summary>SteamNetworkingMicroseconds m_usecQueueTime</summary>
        public SteamNetworkingMicroseconds usecQueueTime;
        /// <summary>uint32 [16] reserved</summary>
        public FixedArray_uint16 reserved;
    }
}