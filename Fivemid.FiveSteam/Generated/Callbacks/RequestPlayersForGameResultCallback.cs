using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for RequestPlayersForGameResultCallback_t
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct RequestPlayersForGameResultCallback : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.RequestPlayersForGameResultCallback;
        /// missing documentation for RequestPlayersForGameResultCallback_t.m_eResult
        public Result eResult;
        /// missing documentation for RequestPlayersForGameResultCallback_t.m_ullSearchID
        public ulong ullSearchID;
        /// missing documentation for RequestPlayersForGameResultCallback_t.m_SteamIDPlayerFound
        public SteamId SteamIDPlayerFound;
        /// missing documentation for RequestPlayersForGameResultCallback_t.m_SteamIDLobby
        public SteamId SteamIDLobby;
        /// missing documentation for RequestPlayersForGameResultCallback_t.m_ePlayerAcceptState
        public RequestPlayersForGameResultCallback.PlayerAcceptState ePlayerAcceptState;
        /// missing documentation for RequestPlayersForGameResultCallback_t.m_nPlayerIndex
        public int nPlayerIndex;
        /// missing documentation for RequestPlayersForGameResultCallback_t.m_nTotalPlayersFound
        public int nTotalPlayersFound;
        /// missing documentation for RequestPlayersForGameResultCallback_t.m_nTotalPlayersAcceptedGame
        public int nTotalPlayersAcceptedGame;
        /// missing documentation for RequestPlayersForGameResultCallback_t.m_nSuggestedTeamIndex
        public int nSuggestedTeamIndex;
        /// missing documentation for RequestPlayersForGameResultCallback_t.m_ullUniqueGameID
        public ulong ullUniqueGameID;
        /// missing documentation for PlayerAcceptState_t
        public enum PlayerAcceptState : int
        {
            /// missing documentation for PlayerAcceptState_t.k_EStateUnknown
            StateUnknown = 0,
            /// missing documentation for PlayerAcceptState_t.k_EStatePlayerAccepted
            StatePlayerAccepted = 1,
            /// missing documentation for PlayerAcceptState_t.k_EStatePlayerDeclined
            StatePlayerDeclined = 2
        }
    }
}