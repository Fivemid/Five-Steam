using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>LobbyGameCreated_t</summary>
    public unsafe struct LobbyGameCreated
    {
        /// <summary>uint64 m_ulSteamIDLobby</summary>
        public ulong ulSteamIDLobby;
        /// <summary>uint64 m_ulSteamIDGameServer</summary>
        public ulong ulSteamIDGameServer;
        /// <summary>uint32 m_unIP</summary>
        public uint unIP;
        /// <summary>uint16 m_usPort</summary>
        public ushort usPort;
    }
}