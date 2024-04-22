using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when scores for a leaderboard have been downloaded and are ready to be retrieved.<br />
    /// After calling you must use <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetDownloadedLeaderboardEntry" class="bb_apilink">ISteamUserStats::GetDownloadedLeaderboardEntry</a> to retrieve the info for each downloaded entry.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#DownloadLeaderboardEntries" class="bb_apilink">ISteamUserStats::DownloadLeaderboardEntries</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#DownloadLeaderboardEntriesForUsers" class="bb_apilink">ISteamUserStats::DownloadLeaderboardEntriesForUsers</a></summary>
    public unsafe struct LeaderboardScoresDownloaded : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.LeaderboardScoresDownloaded;
        /// <summary>Handle to the leaderboard that these entries belong to.</summary>
        public SteamLeaderboard hSteamLeaderboard;
        /// <summary>The handle to pass into <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetDownloadedLeaderboardEntry" class="bb_apilink">ISteamUserStats::GetDownloadedLeaderboardEntry</a> to retrieve the info for each downloaded entry.</summary>
        public SteamLeaderboardEntries hSteamLeaderboardEntries;
        /// <summary>The number of entries downloaded.</summary>
        public int cEntryCount;
    }
}