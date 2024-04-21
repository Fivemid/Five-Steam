using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Called when the user tries to join a lobby from their friends list or from an invite. The game
    /// client should attempt to connect to specified lobby when this is received. If the game isn't running
    /// yet then the game will be automatically launched with the command line parameter
    /// <code class="bb_code bb_code_inline nohighlight">+connect_lobby &lt;64-bit lobby Steam ID&gt;</code>
    /// instead.<br />
    /// <br />
    /// 
    /// <br />
    /// NOTE: This callback is made when joining a lobby. If the user is attempting to join a game but not a
    /// lobby, then the callback
    /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GameRichPresenceJoinRequested_t" class="bb_apilink">GameRichPresenceJoinRequested_t</a>
    /// will be made.
    /// </summary>
    public unsafe struct GameLobbyJoinRequested : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.GameLobbyJoinRequested;
        /// <summary>The Steam ID of the lobby to connect to.</summary>
        public SteamId steamIDLobby;
        /// <summary>The friend they joined through. This will be invalid if not directly via a friend.</summary>
        public SteamId steamIDFriend;
    }
}