using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Called when the user tries to join a game from their friends list or after a user accepts an invite
    /// by a friend with
    /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#InviteUserToGame" class="bb_apilink">ISteamFriends::InviteUserToGame</a>.<br />
    /// <br />
    /// 
    /// <br />
    /// <b>Associated Functions:</b>
    /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#InviteUserToGame" class="bb_apilink">ISteamFriends::InviteUserToGame</a><br />
    /// <br />
    /// NOTE: This callback is made when joining a game. If the user is attempting to join a lobby, then the
    /// callback
    /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GameLobbyJoinRequested_t" class="bb_apilink">GameLobbyJoinRequested_t</a>
    /// will be made.
    /// </summary>
    public unsafe struct GameRichPresenceJoinRequested : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.GameRichPresenceJoinRequested;
        /// <summary>The friend they joined through. This will be invalid if not directly via a friend.</summary>
        public SteamId steamIDFriend;
        /// <summary>The value associated with the "connect" Rich Presence key.</summary>
        public UTF8String256 rgchConnect;
    }
}