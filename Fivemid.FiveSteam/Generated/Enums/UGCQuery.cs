using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Used with <a href="https://partner.steamgames.com/doc/api/ISteamUGC#CreateQueryAllUGCRequest" class="bb_apilink">ISteamUGC::CreateQueryAllUGCRequest</a> to specify the sorting and filtering for queries across all available UGC.<br />
    /// <br />
    /// </summary>
    public enum UGCQuery : int
    {
        /// <summary>Sort by vote popularity all-time</summary>
        RankedByVote = 0,
        /// <summary>Sort by publication date descending</summary>
        RankedByPublicationDate = 1,
        /// <summary>Sort by date accepted (for mtx items)</summary>
        AcceptedForGameRankedByAcceptanceDate = 2,
        /// <summary>Sort by vote popularity within the given "trend" period  (set in <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetRankedByTrendDays" class="bb_apilink">ISteamUGC::SetRankedByTrendDays</a>)</summary>
        RankedByTrend = 3,
        /// <summary>Filter to items the user's friends have favorited, sorted by publication date descending</summary>
        FavoritedByFriendsRankedByPublicationDate = 4,
        /// <summary>Filter to items created by friends, sorted by publication date descending</summary>
        CreatedByFriendsRankedByPublicationDate = 5,
        /// <summary>Sort by report weight descending</summary>
        RankedByNumTimesReported = 6,
        /// <summary>Filter to items created by users that the current user has followed, sorted by publication date descending</summary>
        CreatedByFollowedUsersRankedByPublicationDate = 7,
        /// <summary>Filtered to the user's voting queue</summary>
        NotYetRated = 8,
        /// <summary>Sort by total # of votes ascending (used internally for building the user's voting queue)</summary>
        RankedByTotalVotesAsc = 9,
        /// <summary>Sort by number of votes up descending. Will use the "trend" period if specified (set in <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetRankedByTrendDays" class="bb_apilink">ISteamUGC::SetRankedByTrendDays</a>)</summary>
        RankedByVotesUp = 10,
        /// <summary>Sort by keyword text search relevancy</summary>
        RankedByTextSearch = 11,
        /// <summary>Sort by lifetime total unique # of subscribers descending</summary>
        RankedByTotalUniqueSubscriptions = 12,
        /// <summary>Sort by total playtime in the "trend" period descending (set with <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetRankedByTrendDays" class="bb_apilink">ISteamUGC::SetRankedByTrendDays</a>)</summary>
        RankedByPlaytimeTrend = 13,
        /// <summary>Sort by total lifetime playtime descending.</summary>
        RankedByTotalPlaytime = 14,
        /// <summary>Sort by average playtime in the "trend" period descending (set in <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetRankedByTrendDays" class="bb_apilink">ISteamUGC::SetRankedByTrendDays</a>)</summary>
        RankedByAveragePlaytimeTrend = 15,
        /// <summary>Soft by lifetime average playtime descending.</summary>
        RankedByLifetimeAveragePlaytime = 16,
        /// <summary>Sort by number of play sessions in the "trend" period descending (set in <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetRankedByTrendDays" class="bb_apilink">ISteamUGC::SetRankedByTrendDays</a>)</summary>
        RankedByPlaytimeSessionsTrend = 17,
        /// <summary>Sort by number of lifetime play sessions descending.</summary>
        RankedByLifetimePlaytimeSessions = 18,
        /// <summary>Sort by last updated time.</summary>
        RankedByLastUpdatedDate = 19
    }
}