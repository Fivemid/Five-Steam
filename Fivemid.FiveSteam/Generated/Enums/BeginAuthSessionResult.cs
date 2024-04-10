using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EBeginAuthSessionResult</summary>
    public enum BeginAuthSessionResult : int
    {
        /// <summary>k_EBeginAuthSessionResultOK</summary>
        OK = 0,
        /// <summary>k_EBeginAuthSessionResultInvalidTicket</summary>
        InvalidTicket = 1,
        /// <summary>k_EBeginAuthSessionResultDuplicateRequest</summary>
        DuplicateRequest = 2,
        /// <summary>k_EBeginAuthSessionResultInvalidVersion</summary>
        InvalidVersion = 3,
        /// <summary>k_EBeginAuthSessionResultGameMismatch</summary>
        GameMismatch = 4,
        /// <summary>k_EBeginAuthSessionResultExpiredTicket</summary>
        ExpiredTicket = 5
    }
}