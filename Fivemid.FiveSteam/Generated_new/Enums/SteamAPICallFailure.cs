using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ESteamAPICallFailure</summary>
    public enum SteamAPICallFailure : int
    {
        /// <summary>k_ESteamAPICallFailureNone</summary>
        None = -1,
        /// <summary>k_ESteamAPICallFailureSteamGone</summary>
        SteamGone = 0,
        /// <summary>k_ESteamAPICallFailureNetworkFailure</summary>
        NetworkFailure = 1,
        /// <summary>k_ESteamAPICallFailureInvalidHandle</summary>
        InvalidHandle = 2,
        /// <summary>k_ESteamAPICallFailureMismatchedCallback</summary>
        MismatchedCallback = 3
    }
}