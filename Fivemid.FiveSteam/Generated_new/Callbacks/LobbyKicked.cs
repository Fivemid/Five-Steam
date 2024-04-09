using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>LobbyKicked_t</summary>
    public unsafe struct LobbyKicked
    {
        /// <summary>uint64 m_ulSteamIDLobby</summary>
        public ulong ulSteamIDLobby;
        /// <summary>uint64 m_ulSteamIDAdmin</summary>
        public ulong ulSteamIDAdmin;
        /// <summary>uint8 m_bKickedDueToDisconnect</summary>
        public byte bKickedDueToDisconnect;
    }
}