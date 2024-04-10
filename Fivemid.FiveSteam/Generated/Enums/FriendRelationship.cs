using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EFriendRelationship</summary>
    public enum FriendRelationship : int
    {
        /// <summary>k_EFriendRelationshipNone</summary>
        None = 0,
        /// <summary>k_EFriendRelationshipBlocked</summary>
        Blocked = 1,
        /// <summary>k_EFriendRelationshipRequestRecipient</summary>
        RequestRecipient = 2,
        /// <summary>k_EFriendRelationshipFriend</summary>
        Friend = 3,
        /// <summary>k_EFriendRelationshipRequestInitiator</summary>
        RequestInitiator = 4,
        /// <summary>k_EFriendRelationshipIgnored</summary>
        Ignored = 5,
        /// <summary>k_EFriendRelationshipIgnoredFriend</summary>
        IgnoredFriend = 6,
        /// <summary>k_EFriendRelationshipSuggested_DEPRECATED</summary>
        Suggested_DEPRECATED = 7,
        /// <summary>k_EFriendRelationshipMax</summary>
        Max = 8
    }
}