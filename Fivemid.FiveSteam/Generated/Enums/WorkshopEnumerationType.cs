using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EWorkshopEnumerationType</summary>
    public enum WorkshopEnumerationType : int
    {
        /// <summary>k_EWorkshopEnumerationTypeRankedByVote</summary>
        RankedByVote = 0,
        /// <summary>k_EWorkshopEnumerationTypeRecent</summary>
        Recent = 1,
        /// <summary>k_EWorkshopEnumerationTypeTrending</summary>
        Trending = 2,
        /// <summary>k_EWorkshopEnumerationTypeFavoritesOfFriends</summary>
        FavoritesOfFriends = 3,
        /// <summary>k_EWorkshopEnumerationTypeVotedByFriends</summary>
        VotedByFriends = 4,
        /// <summary>k_EWorkshopEnumerationTypeContentByFriends</summary>
        ContentByFriends = 5,
        /// <summary>k_EWorkshopEnumerationTypeRecentFromFollowedUsers</summary>
        RecentFromFollowedUsers = 6
    }
}