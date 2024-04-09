using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>LobbyCreated_t</summary>
    public unsafe struct LobbyCreated
    {
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>uint64 m_ulSteamIDLobby</summary>
        public ulong ulSteamIDLobby;
    }
}