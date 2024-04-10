using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamNetworkPingLocation_t</summary>
    public unsafe struct SteamNetworkPingLocation
    {
        /// <summary>uint8 [512] m_data</summary>
        public FixedArray_byte512 data;
    }
}