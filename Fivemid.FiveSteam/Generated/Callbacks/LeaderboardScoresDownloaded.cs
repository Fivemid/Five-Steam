using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>LeaderboardScoresDownloaded_t</summary>
    public unsafe struct LeaderboardScoresDownloaded : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.LeaderboardScoresDownloaded;
        /// <summary>SteamLeaderboard_t m_hSteamLeaderboard</summary>
        public SteamLeaderboard hSteamLeaderboard;
        /// <summary>SteamLeaderboardEntries_t m_hSteamLeaderboardEntries</summary>
        public SteamLeaderboardEntries hSteamLeaderboardEntries;
        /// <summary>int m_cEntryCount</summary>
        public int cEntryCount;
    }
}