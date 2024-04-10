using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EFriendFlags</summary>
    public enum FriendFlags : int
    {
        /// <summary>k_EFriendFlagNone</summary>
        FriendFlagNone = 0,
        /// <summary>k_EFriendFlagBlocked</summary>
        FriendFlagBlocked = 1,
        /// <summary>k_EFriendFlagFriendshipRequested</summary>
        FriendFlagFriendshipRequested = 2,
        /// <summary>k_EFriendFlagImmediate</summary>
        FriendFlagImmediate = 4,
        /// <summary>k_EFriendFlagClanMember</summary>
        FriendFlagClanMember = 8,
        /// <summary>k_EFriendFlagOnGameServer</summary>
        FriendFlagOnGameServer = 16,
        /// <summary>k_EFriendFlagRequestingFriendship</summary>
        FriendFlagRequestingFriendship = 128,
        /// <summary>k_EFriendFlagRequestingInfo</summary>
        FriendFlagRequestingInfo = 256,
        /// <summary>k_EFriendFlagIgnored</summary>
        FriendFlagIgnored = 512,
        /// <summary>k_EFriendFlagIgnoredFriend</summary>
        FriendFlagIgnoredFriend = 1024,
        /// <summary>k_EFriendFlagChatMember</summary>
        FriendFlagChatMember = 4096,
        /// <summary>k_EFriendFlagAll</summary>
        FriendFlagAll = 65535
    }
}