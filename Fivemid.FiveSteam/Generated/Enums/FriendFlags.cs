using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Flags for enumerating friends list, or quickly checking the relationship between users.<br />
    /// <br />
    /// 
    /// </summary>
    public enum FriendFlags : int
    {
        /// <summary>None.</summary>
        FriendFlagNone = 0,
        /// <summary>Users that the current user has blocked from contacting.</summary>
        FriendFlagBlocked = 1,
        /// <summary>Users that have sent a friend invite to the current user.</summary>
        FriendFlagFriendshipRequested = 2,
        /// <summary>The current user's "regular" friends.</summary>
        FriendFlagImmediate = 4,
        /// <summary>Users that are in one of the same (small) Steam groups as the current user.</summary>
        FriendFlagClanMember = 8,
        /// <summary>
        ///             Users that are on the same game server; as set by
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamFriends#SetPlayedWith" class="bb_apilink">ISteamFriends::SetPlayedWith</a>.
        ///         </summary>
        FriendFlagOnGameServer = 16,
        /// <summary>Users that the current user has sent friend invites to.</summary>
        FriendFlagRequestingFriendship = 128,
        /// <summary>
        ///             Users that are currently sending additional info about themselves after a call to
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamFriends#RequestUserInformation" class="bb_apilink">ISteamFriends::RequestUserInformation</a>
        ///         </summary>
        FriendFlagRequestingInfo = 256,
        /// <summary>Users that the current user has ignored from contacting them.</summary>
        FriendFlagIgnored = 512,
        /// <summary>
        ///             Users that have ignored the current user; but the current user still knows about them.
        ///         </summary>
        FriendFlagIgnoredFriend = 1024,
        /// <summary>Users in one of the same chats.</summary>
        FriendFlagChatMember = 4096,
        /// <summary>Returns all friend flags.</summary>
        FriendFlagAll = 65535
    }
}