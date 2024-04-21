using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Called when a user has joined a Steam group chat that we are in.<br />
    /// <br />
    /// 
    /// <br />
    /// <b>Associated Functions:</b>
    /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#JoinClanChatRoom" class="bb_apilink">ISteamFriends::JoinClanChatRoom</a>
    /// </summary>
    public unsafe struct GameConnectedChatJoin : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.GameConnectedChatJoin;
        /// <summary>The Steam ID of the chat that a user has joined.</summary>
        public SteamId steamIDClanChat;
        /// <summary>The Steam ID of the user that has joined the chat.</summary>
        public SteamId steamIDUser;
    }
}