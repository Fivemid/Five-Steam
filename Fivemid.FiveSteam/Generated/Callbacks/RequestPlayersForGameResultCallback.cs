using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>RequestPlayersForGameResultCallback_t</summary>
    public unsafe struct RequestPlayersForGameResultCallback : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.RequestPlayersForGameResultCallback;
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>uint64 m_ullSearchID</summary>
        public ulong ullSearchID;
        /// <summary>CSteamID m_SteamIDPlayerFound</summary>
        public SteamId SteamIDPlayerFound;
        /// <summary>CSteamID m_SteamIDLobby</summary>
        public SteamId SteamIDLobby;
        /// <summary>RequestPlayersForGameResultCallback_t::PlayerAcceptState_t m_ePlayerAcceptState</summary>
        public RequestPlayersForGameResultCallback.PlayerAcceptState ePlayerAcceptState;
        /// <summary>int32 m_nPlayerIndex</summary>
        public int nPlayerIndex;
        /// <summary>int32 m_nTotalPlayersFound</summary>
        public int nTotalPlayersFound;
        /// <summary>int32 m_nTotalPlayersAcceptedGame</summary>
        public int nTotalPlayersAcceptedGame;
        /// <summary>int32 m_nSuggestedTeamIndex</summary>
        public int nSuggestedTeamIndex;
        /// <summary>uint64 m_ullUniqueGameID</summary>
        public ulong ullUniqueGameID;
        /// <summary>PlayerAcceptState_t</summary>
        public enum PlayerAcceptState : int
        {
            /// <summary>k_EStateUnknown</summary>
            StateUnknown = 0,
            /// <summary>k_EStatePlayerAccepted</summary>
            StatePlayerAccepted = 1,
            /// <summary>k_EStatePlayerDeclined</summary>
            StatePlayerDeclined = 2
        }
    }
}