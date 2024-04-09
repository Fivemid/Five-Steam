using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>GSClientKick_t</summary>
    public unsafe struct GSClientKick
    {
        /// <summary>CSteamID m_SteamID</summary>
        public SteamId SteamID;
        /// <summary>EDenyReason m_eDenyReason</summary>
        public DenyReason eDenyReason;
    }
}