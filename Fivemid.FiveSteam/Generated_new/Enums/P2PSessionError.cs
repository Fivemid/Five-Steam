using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EP2PSessionError</summary>
    public enum P2PSessionError : int
    {
        /// <summary>k_EP2PSessionErrorNone</summary>
        None = 0,
        /// <summary>k_EP2PSessionErrorNoRightsToApp</summary>
        NoRightsToApp = 2,
        /// <summary>k_EP2PSessionErrorTimeout</summary>
        Timeout = 4,
        /// <summary>k_EP2PSessionErrorNotRunningApp_DELETED</summary>
        NotRunningApp_DELETED = 1,
        /// <summary>k_EP2PSessionErrorDestinationNotLoggedIn_DELETED</summary>
        DestinationNotLoggedIn_DELETED = 3,
        /// <summary>k_EP2PSessionErrorMax</summary>
        Max = 5
    }
}