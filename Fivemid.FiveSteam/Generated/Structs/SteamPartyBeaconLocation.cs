using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamPartyBeaconLocation_t</summary>
    public unsafe struct SteamPartyBeaconLocation
    {
        /// <summary>ESteamPartyBeaconLocationType m_eType</summary>
        public SteamPartyBeaconLocationType eType;
        /// <summary>uint64 m_ulLocationID</summary>
        public ulong ulLocationID;
    }
}