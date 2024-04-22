using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Lobby search filter options. These can be set with <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#AddRequestLobbyListStringFilter" class="bb_apilink">ISteamMatchmaking::AddRequestLobbyListStringFilter</a> and <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#AddRequestLobbyListNearValueFilter" class="bb_apilink">ISteamMatchmaking::AddRequestLobbyListNearValueFilter</a>.<br />
    /// <br />
    /// </summary>
    public enum LobbyComparison : int
    {
        /// <summary>The lobbies value must be equal to or less than this one.</summary>
        EqualToOrLessThan = -2,
        /// <summary>The lobbies value must be less than this one.</summary>
        LessThan = -1,
        /// <summary>The lobbies value must match this this one exactly.</summary>
        Equal = 0,
        /// <summary>The lobbies value must be greater than this one.</summary>
        GreaterThan = 1,
        /// <summary>The lobbies value must be equal to or greater than this one.</summary>
        EqualToOrGreaterThan = 2,
        /// <summary>The lobbies value must not match this this.</summary>
        NotEqual = 3
    }
}