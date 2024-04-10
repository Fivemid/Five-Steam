using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamNetConnectionRealTimeLaneStatus_t</summary>
    public unsafe struct SteamNetConnectionRealTimeLaneStatus
    {
        /// <summary>int m_cbPendingUnreliable</summary>
        public int cbPendingUnreliable;
        /// <summary>int m_cbPendingReliable</summary>
        public int cbPendingReliable;
        /// <summary>int m_cbSentUnackedReliable</summary>
        public int cbSentUnackedReliable;
        /// <summary>int _reservePad1</summary>
        public int _reservePad1;
        /// <summary>SteamNetworkingMicroseconds m_usecQueueTime</summary>
        public SteamNetworkingMicroseconds usecQueueTime;
        /// <summary>uint32 [10] reserved</summary>
        public FixedArray_uint10 reserved;
    }
}