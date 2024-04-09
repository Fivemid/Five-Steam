using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>LeaderboardFindResult_t</summary>
    public unsafe struct LeaderboardFindResult
    {
        /// <summary>SteamLeaderboard_t m_hSteamLeaderboard</summary>
        public SteamLeaderboard hSteamLeaderboard;
        /// <summary>uint8 m_bLeaderboardFound</summary>
        public byte bLeaderboardFound;
    }
}