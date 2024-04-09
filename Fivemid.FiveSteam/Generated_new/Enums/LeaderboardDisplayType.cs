using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ELeaderboardDisplayType</summary>
    public enum LeaderboardDisplayType : int
    {
        /// <summary>k_ELeaderboardDisplayTypeNone</summary>
        None = 0,
        /// <summary>k_ELeaderboardDisplayTypeNumeric</summary>
        Numeric = 1,
        /// <summary>k_ELeaderboardDisplayTypeTimeSeconds</summary>
        TimeSeconds = 2,
        /// <summary>k_ELeaderboardDisplayTypeTimeMilliSeconds</summary>
        TimeMilliSeconds = 3
    }
}