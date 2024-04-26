using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for SteamNetConnectionRealTimeLaneStatus_t
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct SteamNetConnectionRealTimeLaneStatus
    {
        /// missing documentation for SteamNetConnectionRealTimeLaneStatus_t.m_cbPendingUnreliable
        public int cbPendingUnreliable;
        /// missing documentation for SteamNetConnectionRealTimeLaneStatus_t.m_cbPendingReliable
        public int cbPendingReliable;
        /// missing documentation for SteamNetConnectionRealTimeLaneStatus_t.m_cbSentUnackedReliable
        public int cbSentUnackedReliable;
        /// missing documentation for SteamNetConnectionRealTimeLaneStatus_t._reservePad1
        public int _reservePad1;
        /// missing documentation for SteamNetConnectionRealTimeLaneStatus_t.m_usecQueueTime
        public SteamNetworkingMicroseconds usecQueueTime;
        /// missing documentation for SteamNetConnectionRealTimeLaneStatus_t.reserved
        public FixedArray_uint10 reserved;
    }
}