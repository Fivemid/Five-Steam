using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary><br />
    /// <br />
    /// </summary>
    public enum LeaderboardUploadScoreMethod : int
    {
        /// <summary></summary>
        None = 0,
        /// <summary>Leaderboard will keep user's best score</summary>
        KeepBest = 1,
        /// <summary>Leaderboard will always replace score with specified</summary>
        ForceUpdate = 2
    }
}