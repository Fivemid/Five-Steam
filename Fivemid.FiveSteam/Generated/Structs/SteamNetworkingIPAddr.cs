using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamNetworkingIPAddr</summary>
    public unsafe struct SteamNetworkingIPAddr
    {
        /// <summary>uint8 [16] m_ipv6</summary>
        public FixedArray_byte16 ipv6;
        /// <summary>uint16 m_port</summary>
        public ushort port;
    }
}