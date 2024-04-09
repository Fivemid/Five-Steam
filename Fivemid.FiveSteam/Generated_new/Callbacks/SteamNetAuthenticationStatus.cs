using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamNetAuthenticationStatus_t</summary>
    public unsafe struct SteamNetAuthenticationStatus
    {
        /// <summary>ESteamNetworkingAvailability m_eAvail</summary>
        public SteamNetworkingAvailability eAvail;
        /// <summary>char [256] m_debugMsg</summary>
        public UTF8String256 debugMsg;
    }
}