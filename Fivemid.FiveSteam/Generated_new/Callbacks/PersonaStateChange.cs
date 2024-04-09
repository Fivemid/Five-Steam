using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>PersonaStateChange_t</summary>
    public unsafe struct PersonaStateChange
    {
        /// <summary>uint64 m_ulSteamID</summary>
        public ulong ulSteamID;
        /// <summary>int m_nChangeFlags</summary>
        public int nChangeFlags;
    }
}