using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when a chat message has been received in a Steam group chat that we are in.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamFriends#JoinClanChatRoom" class="bb_apilink">ISteamFriends::JoinClanChatRoom</a></summary>
    public unsafe struct GameConnectedClanChatMsg : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.GameConnectedClanChatMsg;
        /// <summary>The Steam ID of the chat that the message was received in.</summary>
        public SteamId steamIDClanChat;
        /// <summary>The Steam ID of the user that sent the message.</summary>
        public SteamId steamIDUser;
        /// <summary>The index of the message to get the actual data from with <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetClanChatMessage" class="bb_apilink">ISteamFriends::GetClanChatMessage</a>.</summary>
        public int iMessageID;
    }
}