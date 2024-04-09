using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>UserStatsReceived_t</summary>
    public unsafe struct UserStatsReceived
    {
        /// <summary>uint64 m_nGameID</summary>
        public ulong nGameID;
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>CSteamID m_steamIDUser</summary>
        public SteamId steamIDUser;
    }
}