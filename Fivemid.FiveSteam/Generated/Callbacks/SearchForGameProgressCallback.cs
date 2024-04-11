using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SearchForGameProgressCallback_t</summary>
    public unsafe struct SearchForGameProgressCallback : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SearchForGameProgressCallback;
        /// <summary>uint64 m_ullSearchID</summary>
        public ulong ullSearchID;
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>CSteamID m_lobbyID</summary>
        public SteamId lobbyID;
        /// <summary>CSteamID m_steamIDEndedSearch</summary>
        public SteamId steamIDEndedSearch;
        /// <summary>int32 m_nSecondsRemainingEstimate</summary>
        public int nSecondsRemainingEstimate;
        /// <summary>int32 m_cPlayersSearching</summary>
        public int cPlayersSearching;
    }
}