using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>FriendGameInfo_t</summary>
    public unsafe struct FriendGameInfo
    {
        /// <summary>CGameID m_gameID</summary>
        public GameId gameID;
        /// <summary>uint32 m_unGameIP</summary>
        public uint unGameIP;
        /// <summary>uint16 m_usGamePort</summary>
        public ushort usGamePort;
        /// <summary>uint16 m_usQueryPort</summary>
        public ushort usQueryPort;
        /// <summary>CSteamID m_steamIDLobby</summary>
        public SteamId steamIDLobby;
    }
}