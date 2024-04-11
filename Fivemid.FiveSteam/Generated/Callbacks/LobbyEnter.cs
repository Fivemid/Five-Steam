using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>LobbyEnter_t</summary>
    public unsafe struct LobbyEnter : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.LobbyEnter;
        /// <summary>uint64 m_ulSteamIDLobby</summary>
        public ulong ulSteamIDLobby;
        /// <summary>uint32 m_rgfChatPermissions</summary>
        public uint rgfChatPermissions;
        /// <summary>bool m_bLocked</summary>
        public bool bLocked;
        /// <summary>uint32 m_EChatRoomEnterResponse</summary>
        public uint EChatRoomEnterResponse;
    }
}