using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamDatagramHostedAddress</summary>
    public unsafe struct SteamDatagramHostedAddress
    {
        /// <summary>int m_cbSize</summary>
        public int cbSize;
        /// <summary>char [128] m_data</summary>
        public UTF8String128 data;
    }
}