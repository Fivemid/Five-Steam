using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>LobbyDataUpdate_t</summary>
    public unsafe struct LobbyDataUpdate
    {
        /// <summary>uint64 m_ulSteamIDLobby</summary>
        public ulong ulSteamIDLobby;
        /// <summary>uint64 m_ulSteamIDMember</summary>
        public ulong ulSteamIDMember;
        /// <summary>uint8 m_bSuccess</summary>
        public byte bSuccess;
    }
}