using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>GSClientGroupStatus_t</summary>
    public unsafe struct GSClientGroupStatus
    {
        /// <summary>CSteamID m_SteamIDUser</summary>
        public SteamId SteamIDUser;
        /// <summary>CSteamID m_SteamIDGroup</summary>
        public SteamId SteamIDGroup;
        /// <summary>bool m_bMember</summary>
        public bool bMember;
        /// <summary>bool m_bOfficer</summary>
        public bool bOfficer;
    }
}