using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamIPAddress_t</summary>
    public unsafe struct SteamIPAddress
    {
        /// <summary>uint8 [16] m_rgubIPv6</summary>
        public FixedArray_byte16 rgubIPv6;
        /// <summary>ESteamIPType m_eType</summary>
        public SteamIPType eType;
    }
}