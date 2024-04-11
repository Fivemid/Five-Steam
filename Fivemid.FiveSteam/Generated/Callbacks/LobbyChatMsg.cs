using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>LobbyChatMsg_t</summary>
    public unsafe struct LobbyChatMsg : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.LobbyChatMsg;
        /// <summary>uint64 m_ulSteamIDLobby</summary>
        public ulong ulSteamIDLobby;
        /// <summary>uint64 m_ulSteamIDUser</summary>
        public ulong ulSteamIDUser;
        /// <summary>uint8 m_eChatEntryType</summary>
        public byte eChatEntryType;
        /// <summary>uint32 m_iChatID</summary>
        public uint iChatID;
    }
}