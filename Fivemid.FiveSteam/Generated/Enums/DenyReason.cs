using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Result values when a client failed to join or has been kicked from a game server. Obtained from <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#GSClientDeny_t" class="bb_apilink">GSClientDeny_t</a> and <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#GSClientKick_t" class="bb_apilink">GSClientKick_t</a>.<br />
    /// <br />
    /// </summary>
    public enum DenyReason : int
    {
        /// <summary>Unknown.</summary>
        DenyInvalid = 0,
        /// <summary>The client and server are not the same version.</summary>
        DenyInvalidVersion = 1,
        /// <summary>Generic.</summary>
        DenyGeneric = 2,
        /// <summary>The client is not logged on.</summary>
        DenyNotLoggedOn = 3,
        /// <summary>The client does not have a license to play this game.</summary>
        DenyNoLicense = 4,
        /// <summary>The client is VAC banned.</summary>
        DenyCheater = 5,
        /// <summary>The client is logged in elsewhere.</summary>
        DenyLoggedInElseWhere = 6,
        /// <summary></summary>
        DenyUnknownText = 7,
        /// <summary></summary>
        DenyIncompatibleAnticheat = 8,
        /// <summary></summary>
        DenyMemoryCorruption = 9,
        /// <summary></summary>
        DenyIncompatibleSoftware = 10,
        /// <summary>The server lost connection to steam.</summary>
        DenySteamConnectionLost = 11,
        /// <summary>The server had a general error connecting to Steam.</summary>
        DenySteamConnectionError = 12,
        /// <summary>The server timed out connecting to Steam.</summary>
        DenySteamResponseTimedOut = 13,
        /// <summary>The client has not authed with Steam yet.</summary>
        DenySteamValidationStalled = 14,
        /// <summary>The owner of the shared game has left, called for each guest of the owner.</summary>
        DenySteamOwnerLeftGuestUser = 15
    }
}