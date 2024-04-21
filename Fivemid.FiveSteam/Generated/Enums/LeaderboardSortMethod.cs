using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// The sort method used to set whether a higher or lower score is better. You can set the sort method
    /// when creating a leaderboard with
    /// <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#FindOrCreateLeaderboard" class="bb_apilink">ISteamUserStats::FindOrCreateLeaderboard</a>
    /// or in App Admin on the Steamworks website. You can retrieve the sort method for a given leaderboard
    /// with
    /// <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetLeaderboardSortMethod" class="bb_apilink">ISteamUserStats::GetLeaderboardSortMethod</a>.<br />
    /// <br />
    /// 
    /// </summary>
    public enum LeaderboardSortMethod : int
    {
        /// <summary>Only ever used when a leaderboard is invalid, you should never set this yourself.</summary>
        None = 0,
        /// <summary>The top-score is the lowest number.</summary>
        Ascending = 1,
        /// <summary>The top-score is the highest number.</summary>
        Descending = 2
    }
}