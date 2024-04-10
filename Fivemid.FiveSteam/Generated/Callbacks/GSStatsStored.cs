using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>GSStatsStored_t</summary>
    public unsafe struct GSStatsStored
    {
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>CSteamID m_steamIDUser</summary>
        public SteamId steamIDUser;
    }
}