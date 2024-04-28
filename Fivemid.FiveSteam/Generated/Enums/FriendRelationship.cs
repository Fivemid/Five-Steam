using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Declares the set of relationships that Steam users may have.<br />
    /// <br />
    /// </summary>
    public enum FriendRelationship : int
    {
        /// <summary>The users have no relationship.</summary>
        None = 0,
        /// <summary>The user has just clicked Ignore on an friendship invite. This doesn't get stored.</summary>
        Blocked = 1,
        /// <summary>The user has requested to be friends with the current user.</summary>
        RequestRecipient = 2,
        /// <summary>A "regular" friend.</summary>
        Friend = 3,
        /// <summary>The current user has sent a friend invite.</summary>
        RequestInitiator = 4,
        /// <summary>The current user has explicit blocked this other user from comments/chat/etc. This is stored.</summary>
        Ignored = 5,
        /// <summary>The user has ignored the current user.</summary>
        IgnoredFriend = 6,
        /// <summary>Deprecated -- Unused.</summary>
        Suggested_DEPRECATED = 7,
        /// <summary>The total number of friend relationships used for looping and verification.</summary>
        Max = 8
    }
}