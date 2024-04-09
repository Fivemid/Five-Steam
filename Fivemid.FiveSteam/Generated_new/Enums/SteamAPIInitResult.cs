using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ESteamAPIInitResult</summary>
    public enum SteamAPIInitResult : int
    {
        /// <summary>k_ESteamAPIInitResult_OK</summary>
        OK = 0,
        /// <summary>k_ESteamAPIInitResult_FailedGeneric</summary>
        FailedGeneric = 1,
        /// <summary>k_ESteamAPIInitResult_NoSteamClient</summary>
        NoSteamClient = 2,
        /// <summary>k_ESteamAPIInitResult_VersionMismatch</summary>
        VersionMismatch = 3
    }
}