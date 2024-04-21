using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// User restriction flags. These are returned by
    /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetUserRestrictions" class="bb_apilink">ISteamFriends::GetUserRestrictions</a>.<br />
    /// <br />
    /// 
    /// </summary>
    public enum UserRestriction : int
    {
        /// <summary>No known chat/content restriction.</summary>
        k_nUserRestrictionNone = 0,
        /// <summary>We don't know yet, the user is offline.</summary>
        k_nUserRestrictionUnknown = 1,
        /// <summary>User is not allowed to (or can't) send/recv any chat.</summary>
        k_nUserRestrictionAnyChat = 2,
        /// <summary>User is not allowed to (or can't) send/recv voice chat.</summary>
        k_nUserRestrictionVoiceChat = 4,
        /// <summary>User is not allowed to (or can't) send/recv group chat.</summary>
        k_nUserRestrictionGroupChat = 8,
        /// <summary>User is too young according to rating in current region.</summary>
        k_nUserRestrictionRating = 16,
        /// <summary>User cannot send or recv game invites, for example if they are on mobile.</summary>
        k_nUserRestrictionGameInvites = 32,
        /// <summary>User cannot participate in trading, for example if they are on a console or mobile.</summary>
        k_nUserRestrictionTrading = 64
    }
}