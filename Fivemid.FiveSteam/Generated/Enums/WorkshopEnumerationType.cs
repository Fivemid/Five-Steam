using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Deprecated - Only used with the deprecated RemoteStorage based Workshop API.<br />
    /// <br />
    /// </summary>
    public enum WorkshopEnumerationType : int
    {
        /// <summary></summary>
        RankedByVote = 0,
        /// <summary></summary>
        Recent = 1,
        /// <summary></summary>
        Trending = 2,
        /// <summary></summary>
        FavoritesOfFriends = 3,
        /// <summary></summary>
        VotedByFriends = 4,
        /// <summary></summary>
        ContentByFriends = 5,
        /// <summary></summary>
        RecentFromFollowedUsers = 6
    }
}