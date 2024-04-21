using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Chat Entry Types.<br />
    /// <br />
    /// Returned by
    /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetFriendMessage" class="bb_apilink">ISteamFriends::GetFriendMessage</a>,
    /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetClanChatMessage" class="bb_apilink">ISteamFriends::GetClanChatMessage</a>
    /// and
    /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#GetLobbyChatEntry" class="bb_apilink">ISteamMatchmaking::GetLobbyChatEntry</a>.<br />
    /// <br />
    /// 
    /// </summary>
    public enum ChatEntryType : int
    {
        /// <summary>Invalid.</summary>
        Invalid = 0,
        /// <summary>Normal text message from another user.</summary>
        ChatMsg = 1,
        /// <summary>The other user is typing, not used in multi-user chat.</summary>
        Typing = 2,
        /// <summary>Invite from other user into that users current game.</summary>
        InviteGame = 3,
        /// <summary>Text emote message (Deprecated, should be treated as ChatMsg).</summary>
        Emote = 4,
        /// <summary>A user has left the conversation (closed the chat window).</summary>
        LeftConversation = 6,
        /// <summary>User has entered the conversation, used in multi-user chat and group chat.</summary>
        Entered = 7,
        /// <summary>User was kicked (Data: Steam ID of the user performing the kick).</summary>
        WasKicked = 8,
        /// <summary>User was banned (Data: Steam ID of the user performing the ban).</summary>
        WasBanned = 9,
        /// <summary>User disconnected.</summary>
        Disconnected = 10,
        /// <summary>A chat message from user's chat history or offline message.</summary>
        HistoricalChat = 11,
        /// <summary>A link was removed by the chat filter.</summary>
        LinkBlocked = 14
    }
}