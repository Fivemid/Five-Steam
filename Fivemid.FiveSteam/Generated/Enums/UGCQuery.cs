using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EUGCQuery</summary>
    public enum UGCQuery : int
    {
        /// <summary>k_EUGCQuery_RankedByVote</summary>
        RankedByVote = 0,
        /// <summary>k_EUGCQuery_RankedByPublicationDate</summary>
        RankedByPublicationDate = 1,
        /// <summary>k_EUGCQuery_AcceptedForGameRankedByAcceptanceDate</summary>
        AcceptedForGameRankedByAcceptanceDate = 2,
        /// <summary>k_EUGCQuery_RankedByTrend</summary>
        RankedByTrend = 3,
        /// <summary>k_EUGCQuery_FavoritedByFriendsRankedByPublicationDate</summary>
        FavoritedByFriendsRankedByPublicationDate = 4,
        /// <summary>k_EUGCQuery_CreatedByFriendsRankedByPublicationDate</summary>
        CreatedByFriendsRankedByPublicationDate = 5,
        /// <summary>k_EUGCQuery_RankedByNumTimesReported</summary>
        RankedByNumTimesReported = 6,
        /// <summary>k_EUGCQuery_CreatedByFollowedUsersRankedByPublicationDate</summary>
        CreatedByFollowedUsersRankedByPublicationDate = 7,
        /// <summary>k_EUGCQuery_NotYetRated</summary>
        NotYetRated = 8,
        /// <summary>k_EUGCQuery_RankedByTotalVotesAsc</summary>
        RankedByTotalVotesAsc = 9,
        /// <summary>k_EUGCQuery_RankedByVotesUp</summary>
        RankedByVotesUp = 10,
        /// <summary>k_EUGCQuery_RankedByTextSearch</summary>
        RankedByTextSearch = 11,
        /// <summary>k_EUGCQuery_RankedByTotalUniqueSubscriptions</summary>
        RankedByTotalUniqueSubscriptions = 12,
        /// <summary>k_EUGCQuery_RankedByPlaytimeTrend</summary>
        RankedByPlaytimeTrend = 13,
        /// <summary>k_EUGCQuery_RankedByTotalPlaytime</summary>
        RankedByTotalPlaytime = 14,
        /// <summary>k_EUGCQuery_RankedByAveragePlaytimeTrend</summary>
        RankedByAveragePlaytimeTrend = 15,
        /// <summary>k_EUGCQuery_RankedByLifetimeAveragePlaytime</summary>
        RankedByLifetimeAveragePlaytime = 16,
        /// <summary>k_EUGCQuery_RankedByPlaytimeSessionsTrend</summary>
        RankedByPlaytimeSessionsTrend = 17,
        /// <summary>k_EUGCQuery_RankedByLifetimePlaytimeSessions</summary>
        RankedByLifetimePlaytimeSessions = 18,
        /// <summary>k_EUGCQuery_RankedByLastUpdatedDate</summary>
        RankedByLastUpdatedDate = 19
    }
}