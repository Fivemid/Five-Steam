using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Chat Room Enter Responses.<br />
    /// <br />
    /// </summary>
    public enum ChatRoomEnterResponse : int
    {
        /// <summary>Success.</summary>
        Success = 1,
        /// <summary>Chat doesn't exist (probably closed).</summary>
        DoesntExist = 2,
        /// <summary>General Denied - You don't have the permissions needed to join the chat.</summary>
        NotAllowed = 3,
        /// <summary>Chat room has reached its maximum size.</summary>
        Full = 4,
        /// <summary>Unexpected Error.</summary>
        Error = 5,
        /// <summary>You are banned from this chat room and may not join.</summary>
        Banned = 6,
        /// <summary>Joining this chat is not allowed because you are a limited user (no value on account).</summary>
        Limited = 7,
        /// <summary>Attempt to join a clan chat when the clan is locked or disabled.</summary>
        ClanDisabled = 8,
        /// <summary>Attempt to join a chat when the user has a community lock on their account.</summary>
        CommunityBan = 9,
        /// <summary>Join failed - a user that is in the chat has blocked you from joining.</summary>
        MemberBlockedYou = 10,
        /// <summary>Join failed - you have blocked a user that is already in the chat.</summary>
        YouBlockedMember = 11,
        /// <summary>Join failed - too many join attempts in a very short period of time.</summary>
        RatelimitExceeded = 15
    }
}