using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary><br />
    /// <br />
    /// </summary>
    public unsafe struct SteamPartyBeaconLocation
    {
        /// <summary>The location type.</summary>
        public SteamPartyBeaconLocationType eType;
        /// <summary>Opaque identifier of this location.</summary>
        public ulong ulLocationID;
    }
}