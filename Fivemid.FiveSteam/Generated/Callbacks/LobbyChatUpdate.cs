using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>LobbyChatUpdate_t</summary>
    public unsafe struct LobbyChatUpdate : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.LobbyChatUpdate;
        /// <summary>uint64 m_ulSteamIDLobby</summary>
        public ulong ulSteamIDLobby;
        /// <summary>uint64 m_ulSteamIDUserChanged</summary>
        public ulong ulSteamIDUserChanged;
        /// <summary>uint64 m_ulSteamIDMakingChange</summary>
        public ulong ulSteamIDMakingChange;
        /// <summary>uint32 m_rgfChatMemberStateChange</summary>
        public uint rgfChatMemberStateChange;
    }
}