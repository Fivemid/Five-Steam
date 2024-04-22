using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when Rich Presence data has been updated for a user, this can happen automatically when friends in the same game update their rich presence, or after a call to <a href="https://partner.steamgames.com/doc/api/ISteamFriends#RequestFriendRichPresence" class="bb_apilink">ISteamFriends::RequestFriendRichPresence</a>.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamFriends#RequestFriendRichPresence" class="bb_apilink">ISteamFriends::RequestFriendRichPresence</a></summary>
    public unsafe struct FriendRichPresenceUpdate : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.FriendRichPresenceUpdate;
        /// <summary>The Steam ID of the user who's rich presence has changed.</summary>
        public SteamId steamIDFriend;
        /// <summary>The App ID of the game. This should always be the current game.</summary>
        public AppId nAppID;
    }
}