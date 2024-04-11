using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>LeaderboardUGCSet_t</summary>
    public unsafe struct LeaderboardUGCSet : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.LeaderboardUGCSet;
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>SteamLeaderboard_t m_hSteamLeaderboard</summary>
        public SteamLeaderboard hSteamLeaderboard;
    }
}