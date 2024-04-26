using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for SearchForGameResultCallback_t
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct SearchForGameResultCallback : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SearchForGameResultCallback;
        /// missing documentation for SearchForGameResultCallback_t.m_ullSearchID
        public ulong ullSearchID;
        /// missing documentation for SearchForGameResultCallback_t.m_eResult
        public Result eResult;
        /// missing documentation for SearchForGameResultCallback_t.m_nCountPlayersInGame
        public int nCountPlayersInGame;
        /// missing documentation for SearchForGameResultCallback_t.m_nCountAcceptedGame
        public int nCountAcceptedGame;
        /// missing documentation for SearchForGameResultCallback_t.m_steamIDHost
        public SteamId steamIDHost;
        /// missing documentation for SearchForGameResultCallback_t.m_bFinalCallback
        public bool bFinalCallback;
    }
}