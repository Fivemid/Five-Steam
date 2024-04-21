using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Lobby search distance filters when requesting the lobby list. Lobby results are sorted from closest
    /// to farthest. This can be set with
    /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#AddRequestLobbyListDistanceFilter" class="bb_apilink">ISteamMatchmaking::AddRequestLobbyListDistanceFilter</a>.<br />
    /// <br />
    /// 
    /// </summary>
    public enum LobbyDistanceFilter : int
    {
        /// <summary>Only lobbies in the same immediate region will be returned.</summary>
        Close = 0,
        /// <summary>Only lobbies in the same region or nearby regions will be returned.</summary>
        Default = 1,
        /// <summary>
        ///             For games that don't have many latency requirements, will return lobbies about half-way
        ///             around the globe.
        ///         </summary>
        Far = 2,
        /// <summary>
        ///             No filtering, will match lobbies as far as India to NY (not recommended, expect multiple
        ///             seconds of latency between the clients).
        ///         </summary>
        Worldwide = 3
    }
}