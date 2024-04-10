using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ELeaderboardDataRequest</summary>
    public enum LeaderboardDataRequest : int
    {
        /// <summary>k_ELeaderboardDataRequestGlobal</summary>
        Global = 0,
        /// <summary>k_ELeaderboardDataRequestGlobalAroundUser</summary>
        GlobalAroundUser = 1,
        /// <summary>k_ELeaderboardDataRequestFriends</summary>
        Friends = 2,
        /// <summary>k_ELeaderboardDataRequestUsers</summary>
        Users = 3
    }
}