using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Provided as the return response when refreshing Matchmaking Servers. See: <a href="https://partner.steamgames.com/doc/api/ISteamMatchmakingServers#RequestInternetServerList" class="bb_apilink">ISteamMatchmakingServers::RequestInternetServerList</a> for more information.<br />
    /// <br />
    /// </summary>
    public enum MatchMakingServerResponse : int
    {
        /// <summary>The server responded successfully.</summary>
        eServerResponded = 0,
        /// <summary>The server failed to respond.</summary>
        eServerFailedToRespond = 1,
        /// <summary>Only for the internet query type, returned in response callback if no servers of this type match.</summary>
        eNoServersListedOnMasterServer = 2
    }
}