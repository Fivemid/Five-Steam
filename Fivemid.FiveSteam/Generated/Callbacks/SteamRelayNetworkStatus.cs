using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamRelayNetworkStatus_t</summary>
    public unsafe struct SteamRelayNetworkStatus : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SteamRelayNetworkStatus;
        /// <summary>ESteamNetworkingAvailability m_eAvail</summary>
        public SteamNetworkingAvailability eAvail;
        /// <summary>int m_bPingMeasurementInProgress</summary>
        public int bPingMeasurementInProgress;
        /// <summary>ESteamNetworkingAvailability m_eAvailNetworkConfig</summary>
        public SteamNetworkingAvailability eAvailNetworkConfig;
        /// <summary>ESteamNetworkingAvailability m_eAvailAnyRelay</summary>
        public SteamNetworkingAvailability eAvailAnyRelay;
        /// <summary>char [256] m_debugMsg</summary>
        public UTF8String256 debugMsg;
    }
}