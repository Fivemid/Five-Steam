using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>A single entry in a leaderboard, as returned by <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetDownloadedLeaderboardEntry" class="bb_apilink">ISteamUserStats::GetDownloadedLeaderboardEntry</a>.<br />
    /// <br />
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct LeaderboardEntry
    {
        /// <summary>User who this entry belongs to. You can use <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetFriendPersonaName" class="bb_apilink">ISteamFriends::GetFriendPersonaName</a> and <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetSmallFriendAvatar" class="bb_apilink">ISteamFriends::GetSmallFriendAvatar</a> to get more info.</summary>
        public SteamId steamIDUser;
        /// <summary>The global rank of this entry ranging from [1..N], where N is the number of users with an entry in the leaderboard.</summary>
        public int nGlobalRank;
        /// <summary>The raw score as set in the leaderboard.</summary>
        public int nScore;
        /// <summary>The number of details available for this entry.</summary>
        public int cDetails;
        /// <summary>Handle for the UGC attached to the entry. <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#k_UGCHandleInvalid" class="bb_apilink">k_UGCHandleInvalid</a> if there is none.</summary>
        public UGCHandle hUGC;
    }
}