using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EUserUGCListSortOrder</summary>
    public enum UserUGCListSortOrder : int
    {
        /// <summary>k_EUserUGCListSortOrder_CreationOrderDesc</summary>
        CreationOrderDesc = 0,
        /// <summary>k_EUserUGCListSortOrder_CreationOrderAsc</summary>
        CreationOrderAsc = 1,
        /// <summary>k_EUserUGCListSortOrder_TitleAsc</summary>
        TitleAsc = 2,
        /// <summary>k_EUserUGCListSortOrder_LastUpdatedDesc</summary>
        LastUpdatedDesc = 3,
        /// <summary>k_EUserUGCListSortOrder_SubscriptionDateDesc</summary>
        SubscriptionDateDesc = 4,
        /// <summary>k_EUserUGCListSortOrder_VoteScoreDesc</summary>
        VoteScoreDesc = 5,
        /// <summary>k_EUserUGCListSortOrder_ForModeration</summary>
        ForModeration = 6
    }
}