using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EDenyReason</summary>
    public enum DenyReason : int
    {
        /// <summary>k_EDenyInvalid</summary>
        DenyInvalid = 0,
        /// <summary>k_EDenyInvalidVersion</summary>
        DenyInvalidVersion = 1,
        /// <summary>k_EDenyGeneric</summary>
        DenyGeneric = 2,
        /// <summary>k_EDenyNotLoggedOn</summary>
        DenyNotLoggedOn = 3,
        /// <summary>k_EDenyNoLicense</summary>
        DenyNoLicense = 4,
        /// <summary>k_EDenyCheater</summary>
        DenyCheater = 5,
        /// <summary>k_EDenyLoggedInElseWhere</summary>
        DenyLoggedInElseWhere = 6,
        /// <summary>k_EDenyUnknownText</summary>
        DenyUnknownText = 7,
        /// <summary>k_EDenyIncompatibleAnticheat</summary>
        DenyIncompatibleAnticheat = 8,
        /// <summary>k_EDenyMemoryCorruption</summary>
        DenyMemoryCorruption = 9,
        /// <summary>k_EDenyIncompatibleSoftware</summary>
        DenyIncompatibleSoftware = 10,
        /// <summary>k_EDenySteamConnectionLost</summary>
        DenySteamConnectionLost = 11,
        /// <summary>k_EDenySteamConnectionError</summary>
        DenySteamConnectionError = 12,
        /// <summary>k_EDenySteamResponseTimedOut</summary>
        DenySteamResponseTimedOut = 13,
        /// <summary>k_EDenySteamValidationStalled</summary>
        DenySteamValidationStalled = 14,
        /// <summary>k_EDenySteamOwnerLeftGuestUser</summary>
        DenySteamOwnerLeftGuestUser = 15
    }
}