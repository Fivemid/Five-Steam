using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SearchForGameResultCallback_t</summary>
    public unsafe struct SearchForGameResultCallback
    {
        /// <summary>uint64 m_ullSearchID</summary>
        public ulong ullSearchID;
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>int32 m_nCountPlayersInGame</summary>
        public int nCountPlayersInGame;
        /// <summary>int32 m_nCountAcceptedGame</summary>
        public int nCountAcceptedGame;
        /// <summary>CSteamID m_steamIDHost</summary>
        public SteamId steamIDHost;
        /// <summary>bool m_bFinalCallback</summary>
        public bool bFinalCallback;
    }
}