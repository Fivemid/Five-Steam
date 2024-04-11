using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>LeaderboardFindResult_t</summary>
    public unsafe struct LeaderboardFindResult : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.LeaderboardFindResult;
        /// <summary>SteamLeaderboard_t m_hSteamLeaderboard</summary>
        public SteamLeaderboard hSteamLeaderboard;
        /// <summary>uint8 m_bLeaderboardFound</summary>
        public byte bLeaderboardFound;
    }
}