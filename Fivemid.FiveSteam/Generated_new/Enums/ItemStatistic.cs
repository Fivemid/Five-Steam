using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EItemStatistic</summary>
    public enum ItemStatistic : int
    {
        /// <summary>k_EItemStatistic_NumSubscriptions</summary>
        NumSubscriptions = 0,
        /// <summary>k_EItemStatistic_NumFavorites</summary>
        NumFavorites = 1,
        /// <summary>k_EItemStatistic_NumFollowers</summary>
        NumFollowers = 2,
        /// <summary>k_EItemStatistic_NumUniqueSubscriptions</summary>
        NumUniqueSubscriptions = 3,
        /// <summary>k_EItemStatistic_NumUniqueFavorites</summary>
        NumUniqueFavorites = 4,
        /// <summary>k_EItemStatistic_NumUniqueFollowers</summary>
        NumUniqueFollowers = 5,
        /// <summary>k_EItemStatistic_NumUniqueWebsiteViews</summary>
        NumUniqueWebsiteViews = 6,
        /// <summary>k_EItemStatistic_ReportScore</summary>
        ReportScore = 7,
        /// <summary>k_EItemStatistic_NumSecondsPlayed</summary>
        NumSecondsPlayed = 8,
        /// <summary>k_EItemStatistic_NumPlaytimeSessions</summary>
        NumPlaytimeSessions = 9,
        /// <summary>k_EItemStatistic_NumComments</summary>
        NumComments = 10,
        /// <summary>k_EItemStatistic_NumSecondsPlayedDuringTimePeriod</summary>
        NumSecondsPlayedDuringTimePeriod = 11,
        /// <summary>k_EItemStatistic_NumPlaytimeSessionsDuringTimePeriod</summary>
        NumPlaytimeSessionsDuringTimePeriod = 12
    }
}