using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EUserUGCList</summary>
    public enum UserUGCList : int
    {
        /// <summary>k_EUserUGCList_Published</summary>
        Published = 0,
        /// <summary>k_EUserUGCList_VotedOn</summary>
        VotedOn = 1,
        /// <summary>k_EUserUGCList_VotedUp</summary>
        VotedUp = 2,
        /// <summary>k_EUserUGCList_VotedDown</summary>
        VotedDown = 3,
        /// <summary>k_EUserUGCList_WillVoteLater</summary>
        WillVoteLater = 4,
        /// <summary>k_EUserUGCList_Favorited</summary>
        Favorited = 5,
        /// <summary>k_EUserUGCList_Subscribed</summary>
        Subscribed = 6,
        /// <summary>k_EUserUGCList_UsedOrPlayed</summary>
        UsedOrPlayed = 7,
        /// <summary>k_EUserUGCList_Followed</summary>
        Followed = 8
    }
}