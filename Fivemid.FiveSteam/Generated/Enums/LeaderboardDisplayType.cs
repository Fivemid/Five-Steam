using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// The display type used by the Steam Community web site to know how to format the leaderboard scores
    /// when displayed. You can set the display type when creating a leaderboard with
    /// <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#FindOrCreateLeaderboard" class="bb_apilink">ISteamUserStats::FindOrCreateLeaderboard</a>
    /// or in the Steamworks partner backend. You can retrieve the display type for a given leaderboard with
    /// <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetLeaderboardDisplayType" class="bb_apilink">ISteamUserStats::GetLeaderboardDisplayType</a>.<br />
    /// <br />
    /// 
    /// </summary>
    public enum LeaderboardDisplayType : int
    {
        /// <summary>
        ///             This is only ever used when a leaderboard is invalid, you should never set this
        ///             yourself.
        ///         </summary>
        None = 0,
        /// <summary>The score is just a simple numerical value.</summary>
        Numeric = 1,
        /// <summary>The score represents a time, in seconds.</summary>
        TimeSeconds = 2,
        /// <summary>The score represents a time, in milliseconds.</summary>
        TimeMilliSeconds = 3
    }
}