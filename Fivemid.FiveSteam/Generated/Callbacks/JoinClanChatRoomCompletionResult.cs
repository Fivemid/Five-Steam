using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>JoinClanChatRoomCompletionResult_t</summary>
    public unsafe struct JoinClanChatRoomCompletionResult : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.JoinClanChatRoomCompletionResult;
        /// <summary>CSteamID m_steamIDClanChat</summary>
        public SteamId steamIDClanChat;
        /// <summary>EChatRoomEnterResponse m_eChatRoomEnterResponse</summary>
        public ChatRoomEnterResponse eChatRoomEnterResponse;
    }
}