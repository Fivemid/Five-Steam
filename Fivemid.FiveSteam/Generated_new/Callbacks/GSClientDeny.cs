using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>GSClientDeny_t</summary>
    public unsafe struct GSClientDeny
    {
        /// <summary>CSteamID m_SteamID</summary>
        public SteamId SteamID;
        /// <summary>EDenyReason m_eDenyReason</summary>
        public DenyReason eDenyReason;
        /// <summary>char [128] m_rgchOptionalText</summary>
        public UTF8String128 rgchOptionalText;
    }
}