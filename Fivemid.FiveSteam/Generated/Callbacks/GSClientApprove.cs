using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>GSClientApprove_t</summary>
    public unsafe struct GSClientApprove
    {
        /// <summary>CSteamID m_SteamID</summary>
        public SteamId SteamID;
        /// <summary>CSteamID m_OwnerSteamID</summary>
        public SteamId OwnerSteamID;
    }
}