using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Type of data request, used when downloading leaderboard entries with
    /// <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#DownloadLeaderboardEntries" class="bb_apilink">ISteamUserStats::DownloadLeaderboardEntries</a>.<br />
    /// <br />
    /// 
    /// </summary>
    public enum LeaderboardDataRequest : int
    {
        /// <summary>
        ///             Used to query for a sequential range of leaderboard entries by leaderboard rank. The
        ///             start and end parameters control the requested range. For example, you can display the
        ///             top 10 on a leaderboard for your game by setting start to 1 and end to 10.
        ///         </summary>
        Global = 0,
        /// <summary>
        ///             Used to retrieve leaderboard entries relative a user's entry. The start parameter is the
        ///             number of entries to retrieve before the current user's entry, and the end parameter is
        ///             the number of entries after the current user's entry. The current user's entry is always
        ///             included. For example, if the current user is #5 on the leaderboard, setting start to -2
        ///             and end to 2 will return 5 entries: ranks #3 through #7. If there are not enough entries
        ///             in the leaderboard before or after the user's entry, Steam will adjust the range to try
        ///             to return the number of entries requested. For example, if the user is #1 on the
        ///             leaderboard and start is set to -2, end is set to 2, Steam will return the first 5
        ///             entries in the leaderboard.
        ///         </summary>
        GlobalAroundUser = 1,
        /// <summary>
        ///             Used to retrieve all leaderboard entries for friends of the current user. The start and
        ///             end parameters are ignored.
        ///         </summary>
        Friends = 2,
        /// <summary>
        ///             Used internally, do not use with
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#DownloadLeaderboardEntries" class="bb_apilink">ISteamUserStats::DownloadLeaderboardEntries</a>! Doing so is undefined behavior.
        ///         </summary>
        Users = 3
    }
}