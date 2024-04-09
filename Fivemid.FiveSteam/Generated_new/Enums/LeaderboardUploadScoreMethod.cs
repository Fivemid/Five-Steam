using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ELeaderboardUploadScoreMethod</summary>
    public enum LeaderboardUploadScoreMethod : int
    {
        /// <summary>k_ELeaderboardUploadScoreMethodNone</summary>
        None = 0,
        /// <summary>k_ELeaderboardUploadScoreMethodKeepBest</summary>
        KeepBest = 1,
        /// <summary>k_ELeaderboardUploadScoreMethodForceUpdate</summary>
        ForceUpdate = 2
    }
}