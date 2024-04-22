using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>A chat (text or binary) message for this lobby has been received. After getting this you must use <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#GetLobbyChatEntry" class="bb_apilink">ISteamMatchmaking::GetLobbyChatEntry</a> to retrieve the contents of this message.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#SendLobbyChatMsg" class="bb_apilink">ISteamMatchmaking::SendLobbyChatMsg</a></summary>
    public unsafe struct LobbyChatMsg : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.LobbyChatMsg;
        /// <summary>The Steam ID of the lobby this message was sent in.</summary>
        public ulong ulSteamIDLobby;
        /// <summary>Steam ID of the user who sent this message. Note that it could have been the local user.</summary>
        public ulong ulSteamIDUser;
        /// <summary>Type of message received. This is actually a <a href="https://partner.steamgames.com/doc/api/steam_api#EChatEntryType" class="bb_apilink">EChatEntryType</a>.</summary>
        public byte eChatEntryType;
        /// <summary>The index of the chat entry to use with <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#GetLobbyChatEntry" class="bb_apilink">ISteamMatchmaking::GetLobbyChatEntry</a>, this is not valid outside of the scope of this callback and should never be stored.</summary>
        public uint iChatID;
    }
}