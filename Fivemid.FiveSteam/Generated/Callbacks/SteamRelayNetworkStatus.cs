using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for SteamRelayNetworkStatus_t
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct SteamRelayNetworkStatus
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SteamRelayNetworkStatus;
        /// missing documentation for SteamRelayNetworkStatus_t.m_eAvail
        public SteamNetworkingAvailability eAvail;
        /// missing documentation for SteamRelayNetworkStatus_t.m_bPingMeasurementInProgress
        public int bPingMeasurementInProgress;
        /// missing documentation for SteamRelayNetworkStatus_t.m_eAvailNetworkConfig
        public SteamNetworkingAvailability eAvailNetworkConfig;
        /// missing documentation for SteamRelayNetworkStatus_t.m_eAvailAnyRelay
        public SteamNetworkingAvailability eAvailAnyRelay;
        /// missing documentation for SteamRelayNetworkStatus_t.m_debugMsg
        public UTF8String256 debugMsg;
    }
}