using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>servernetadr_t</summary>
    public unsafe struct servernetadr
    {
        /// <summary>uint16 m_usConnectionPort</summary>
        public ushort usConnectionPort;
        /// <summary>uint16 m_usQueryPort</summary>
        public ushort usQueryPort;
        /// <summary>uint32 m_unIP</summary>
        public uint unIP;
    }
}