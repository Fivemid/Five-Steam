using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EChatEntryType</summary>
    public enum ChatEntryType : int
    {
        /// <summary>k_EChatEntryTypeInvalid</summary>
        Invalid = 0,
        /// <summary>k_EChatEntryTypeChatMsg</summary>
        ChatMsg = 1,
        /// <summary>k_EChatEntryTypeTyping</summary>
        Typing = 2,
        /// <summary>k_EChatEntryTypeInviteGame</summary>
        InviteGame = 3,
        /// <summary>k_EChatEntryTypeEmote</summary>
        Emote = 4,
        /// <summary>k_EChatEntryTypeLeftConversation</summary>
        LeftConversation = 6,
        /// <summary>k_EChatEntryTypeEntered</summary>
        Entered = 7,
        /// <summary>k_EChatEntryTypeWasKicked</summary>
        WasKicked = 8,
        /// <summary>k_EChatEntryTypeWasBanned</summary>
        WasBanned = 9,
        /// <summary>k_EChatEntryTypeDisconnected</summary>
        Disconnected = 10,
        /// <summary>k_EChatEntryTypeHistoricalChat</summary>
        HistoricalChat = 11,
        /// <summary>k_EChatEntryTypeLinkBlocked</summary>
        LinkBlocked = 14
    }
}