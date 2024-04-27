using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Someone has invited you to join a Lobby. Normally you don't need to do anything with this, as the Steam UI will also display a '&lt;user&gt; has invited you to the lobby, join?' notification and message.<br />
    /// <br />
    /// If the user outside a game chooses to join, your game will be launched with the parameter <code class="bb_code bb_code_inline nohighlight">+connect_lobby &lt;64-bit lobby id&gt;</code>, or with the callback <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GameLobbyJoinRequested_t" class="bb_apilink">GameLobbyJoinRequested_t</a> if they're already in-game.<br />
    /// <br />
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct LobbyInvite
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.LobbyInvite;
        /// <summary>Steam ID of the person that sent the invite.</summary>
        public ulong ulSteamIDUser;
        /// <summary>Steam ID of the lobby we're invited to.</summary>
        public ulong ulSteamIDLobby;
        /// <summary>Game ID of the lobby we're invited to.</summary>
        public ulong ulGameID;
    }
}