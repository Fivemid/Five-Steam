using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Steam API call failure results returned by <a href="https://partner.steamgames.com/doc/api/ISteamUtils#GetAPICallFailureReason" class="bb_apilink">ISteamUtils::GetAPICallFailureReason</a>.<br />
    /// <br />
    /// </summary>
    public enum SteamAPICallFailure : int
    {
        /// <summary>No failure.</summary>
        None = -1,
        /// <summary>The local Steam process has stopped responding, it may have been forcefully closed or is frozen.</summary>
        SteamGone = 0,
        /// <summary>The network connection to the Steam servers has been lost, or was already broken.<br />
        /// A <a href="https://partner.steamgames.com/doc/api/ISteamUser#SteamServersDisconnected_t" class="bb_apilink">SteamServersDisconnected_t</a> callback will be sent around the same time, and a <a href="https://partner.steamgames.com/doc/api/ISteamUser#SteamServersConnected_t" class="bb_apilink">SteamServersConnected_t</a> callback will be sent when the client is able to talk to the Steam servers again.</summary>
        NetworkFailure = 1,
        /// <summary>The <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> handle passed in no longer exists.</summary>
        InvalidHandle = 2,
        /// <summary><a href="https://partner.steamgames.com/doc/api/ISteamUtils#GetAPICallResult" class="bb_apilink">GetAPICallResult</a> was called with the wrong callback type for this API call.</summary>
        MismatchedCallback = 3
    }
}