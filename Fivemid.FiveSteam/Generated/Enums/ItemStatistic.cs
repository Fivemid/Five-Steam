using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Used to retrieve item statistics with <a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetQueryUGCStatistic" class="bb_apilink">ISteamUGC::GetQueryUGCStatistic</a>.<br />
    /// <br />
    /// </summary>
    public enum ItemStatistic : int
    {
        /// <summary>Gets the number of subscriptions.</summary>
        NumSubscriptions = 0,
        /// <summary>Gets the number of favorites.</summary>
        NumFavorites = 1,
        /// <summary>Gets the number of followers.</summary>
        NumFollowers = 2,
        /// <summary>Gets the number of unique subscriptions.</summary>
        NumUniqueSubscriptions = 3,
        /// <summary>Gets the number of unique favorites.</summary>
        NumUniqueFavorites = 4,
        /// <summary>Gets the number of unique followers.</summary>
        NumUniqueFollowers = 5,
        /// <summary>Gets the number of unique views the item has on its Steam Workshop page.</summary>
        NumUniqueWebsiteViews = 6,
        /// <summary>Gets the number of times the item has been reported.</summary>
        ReportScore = 7,
        /// <summary>Gets the total number of seconds this item has been used across all players.</summary>
        NumSecondsPlayed = 8,
        /// <summary>Gets the total number of play sessions this item has been used in.</summary>
        NumPlaytimeSessions = 9,
        /// <summary>Gets the number of comments on the items that steam has on its Steam Workshop page.</summary>
        NumComments = 10,
        /// <summary>Gets the number of seconds this item has been used over the given time period.</summary>
        NumSecondsPlayedDuringTimePeriod = 11,
        /// <summary>Gets the number of sessions this item has been used in over the given time period.</summary>
        NumPlaytimeSessionsDuringTimePeriod = 12
    }
}