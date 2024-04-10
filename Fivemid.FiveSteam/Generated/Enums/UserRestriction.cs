using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EUserRestriction</summary>
    public enum UserRestriction : int
    {
        /// <summary>k_nUserRestrictionNone</summary>
        k_nUserRestrictionNone = 0,
        /// <summary>k_nUserRestrictionUnknown</summary>
        k_nUserRestrictionUnknown = 1,
        /// <summary>k_nUserRestrictionAnyChat</summary>
        k_nUserRestrictionAnyChat = 2,
        /// <summary>k_nUserRestrictionVoiceChat</summary>
        k_nUserRestrictionVoiceChat = 4,
        /// <summary>k_nUserRestrictionGroupChat</summary>
        k_nUserRestrictionGroupChat = 8,
        /// <summary>k_nUserRestrictionRating</summary>
        k_nUserRestrictionRating = 16,
        /// <summary>k_nUserRestrictionGameInvites</summary>
        k_nUserRestrictionGameInvites = 32,
        /// <summary>k_nUserRestrictionTrading</summary>
        k_nUserRestrictionTrading = 64
    }
}