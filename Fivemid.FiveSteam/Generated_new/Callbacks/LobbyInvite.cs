using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>LobbyInvite_t</summary>
    public unsafe struct LobbyInvite
    {
        /// <summary>uint64 m_ulSteamIDUser</summary>
        public ulong ulSteamIDUser;
        /// <summary>uint64 m_ulSteamIDLobby</summary>
        public ulong ulSteamIDLobby;
        /// <summary>uint64 m_ulGameID</summary>
        public ulong ulGameID;
    }
}