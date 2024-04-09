using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>LeaderboardScoreUploaded_t</summary>
    public unsafe struct LeaderboardScoreUploaded
    {
        /// <summary>uint8 m_bSuccess</summary>
        public byte bSuccess;
        /// <summary>SteamLeaderboard_t m_hSteamLeaderboard</summary>
        public SteamLeaderboard hSteamLeaderboard;
        /// <summary>int32 m_nScore</summary>
        public int nScore;
        /// <summary>uint8 m_bScoreChanged</summary>
        public byte bScoreChanged;
        /// <summary>int m_nGlobalRankNew</summary>
        public int nGlobalRankNew;
        /// <summary>int m_nGlobalRankPrevious</summary>
        public int nGlobalRankPrevious;
    }
}