using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ReservationNotificationCallback_t</summary>
    public unsafe struct ReservationNotificationCallback
    {
        /// <summary>PartyBeaconID_t m_ulBeaconID</summary>
        public PartyBeaconID ulBeaconID;
        /// <summary>CSteamID m_steamIDJoiner</summary>
        public SteamId steamIDJoiner;
    }
}