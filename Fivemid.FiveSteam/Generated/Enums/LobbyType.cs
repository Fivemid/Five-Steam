using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Specifies the lobby type, this is set from
    /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#CreateLobby" class="bb_apilink">ISteamMatchmaking::CreateLobby</a>
    /// and
    /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#SetLobbyType" class="bb_apilink">ISteamMatchmaking::SetLobbyType</a>.<br />
    /// <br />
    /// 
    /// </summary>
    public enum LobbyType : int
    {
        /// <summary>The only way to join the lobby is from an invite.</summary>
        Private = 0,
        /// <summary>Joinable by friends and invitees, but does not show up in the lobby list.</summary>
        FriendsOnly = 1,
        /// <summary>Returned by search and visible to friends.</summary>
        Public = 2,
        /// <summary>
        ///             Returned by search, but not visible to other friends.<br />
        ///             This is useful if you want a user in two lobbies, for example matching groups together.
        ///             A user can be in only one regular lobby, and up to two invisible lobbies.
        ///         </summary>
        Invisible = 3,
        /// missing documentation for ELobbyType.k_ELobbyTypePrivateUnique
        PrivateUnique = 4
    }
}