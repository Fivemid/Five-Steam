using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Result indicating that a leaderboard score has been uploaded.<br />
    /// <br />
    /// 
    /// <br />
    /// <b>Associated Functions:</b>
    /// <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#UploadLeaderboardScore" class="bb_apilink">ISteamUserStats::UploadLeaderboardScore</a>
    /// </summary>
    public unsafe struct LeaderboardScoreUploaded : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.LeaderboardScoreUploaded;
        /// <summary>
        ///             Was the call successful? Returns <b>1</b> if the call was successful,
        ///             <b>0</b> on failure.<br />
        ///             The amount of details sent exceeds
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#k_cLeaderboardDetailsMax" class="bb_apilink">k_cLeaderboardDetailsMax</a>.<br />
        ///             The leaderboard is set to "Trusted" in App Admin on Steamworks website, and will only
        ///             accept scores sent from the Steam Web API.
        ///         </summary>
        public byte bSuccess;
        /// <summary>Handle to the leaderboard that this score was uploaded to.</summary>
        public SteamLeaderboard hSteamLeaderboard;
        /// <summary>The score that was attempted to set.</summary>
        public int nScore;
        /// <summary>
        ///             <b>true</b> if the score on the leaderboard changed otherwise
        ///             <b>false</b> if the existing score was better.
        ///         </summary>
        public byte bScoreChanged;
        /// <summary>The new global rank of the user on this leaderboard.</summary>
        public int nGlobalRankNew;
        /// <summary>
        ///             The previous global rank of the user on this leaderboard; <b>0</b> if the user
        ///             had no existing entry in the leaderboard.
        ///         </summary>
        public int nGlobalRankPrevious;
    }
}