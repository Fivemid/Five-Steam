using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Posted when the user has attempted to join a Steam group chat via
    /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#JoinClanChatRoom" class="bb_apilink">ISteamFriends::JoinClanChatRoom</a><br />
    /// <br />
    /// 
    /// <br />
    /// <b>Associated Functions:</b>
    /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#JoinClanChatRoom" class="bb_apilink">ISteamFriends::JoinClanChatRoom</a>
    /// </summary>
    public unsafe struct JoinClanChatRoomCompletionResult : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.JoinClanChatRoomCompletionResult;
        /// <summary>The Steam ID of the chat that the user has joined.</summary>
        public SteamId steamIDClanChat;
        /// <summary>The result of the operation.</summary>
        public ChatRoomEnterResponse eChatRoomEnterResponse;
    }
}