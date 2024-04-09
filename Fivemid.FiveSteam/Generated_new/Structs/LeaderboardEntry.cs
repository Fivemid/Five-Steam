using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>LeaderboardEntry_t</summary>
    public unsafe struct LeaderboardEntry
    {
        /// <summary>CSteamID m_steamIDUser</summary>
        public SteamId steamIDUser;
        /// <summary>int32 m_nGlobalRank</summary>
        public int nGlobalRank;
        /// <summary>int32 m_nScore</summary>
        public int nScore;
        /// <summary>int32 m_cDetails</summary>
        public int cDetails;
        /// <summary>UGCHandle_t m_hUGC</summary>
        public UGCHandle hUGC;
    }
}