using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EChatRoomEnterResponse</summary>
    public enum ChatRoomEnterResponse : int
    {
        /// <summary>k_EChatRoomEnterResponseSuccess</summary>
        Success = 1,
        /// <summary>k_EChatRoomEnterResponseDoesntExist</summary>
        DoesntExist = 2,
        /// <summary>k_EChatRoomEnterResponseNotAllowed</summary>
        NotAllowed = 3,
        /// <summary>k_EChatRoomEnterResponseFull</summary>
        Full = 4,
        /// <summary>k_EChatRoomEnterResponseError</summary>
        Error = 5,
        /// <summary>k_EChatRoomEnterResponseBanned</summary>
        Banned = 6,
        /// <summary>k_EChatRoomEnterResponseLimited</summary>
        Limited = 7,
        /// <summary>k_EChatRoomEnterResponseClanDisabled</summary>
        ClanDisabled = 8,
        /// <summary>k_EChatRoomEnterResponseCommunityBan</summary>
        CommunityBan = 9,
        /// <summary>k_EChatRoomEnterResponseMemberBlockedYou</summary>
        MemberBlockedYou = 10,
        /// <summary>k_EChatRoomEnterResponseYouBlockedMember</summary>
        YouBlockedMember = 11,
        /// <summary>k_EChatRoomEnterResponseRatelimitExceeded</summary>
        RatelimitExceeded = 15
    }
}