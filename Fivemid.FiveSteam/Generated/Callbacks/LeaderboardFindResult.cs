using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Result when finding a leaderboard.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#FindOrCreateLeaderboard" class="bb_apilink">ISteamUserStats::FindOrCreateLeaderboard</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#FindLeaderboard" class="bb_apilink">ISteamUserStats::FindLeaderboard</a></summary>
    public unsafe struct LeaderboardFindResult : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.LeaderboardFindResult;
        /// <summary>Handle to the leaderboard that was searched for. <b>0</b> if no leaderboard was found.</summary>
        public SteamLeaderboard hSteamLeaderboard;
        /// <summary>Was the leaderboard found? <b>1</b> if it was, <b>0</b> if it wasn't.</summary>
        public byte bLeaderboardFound;
    }
}