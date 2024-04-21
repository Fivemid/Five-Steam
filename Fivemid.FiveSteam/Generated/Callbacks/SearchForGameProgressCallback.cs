using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for SearchForGameProgressCallback_t
    public unsafe struct SearchForGameProgressCallback : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SearchForGameProgressCallback;
        /// missing documentation for SearchForGameProgressCallback_t.m_ullSearchID
        public ulong ullSearchID;
        /// missing documentation for SearchForGameProgressCallback_t.m_eResult
        public Result eResult;
        /// missing documentation for SearchForGameProgressCallback_t.m_lobbyID
        public SteamId lobbyID;
        /// missing documentation for SearchForGameProgressCallback_t.m_steamIDEndedSearch
        public SteamId steamIDEndedSearch;
        /// missing documentation for SearchForGameProgressCallback_t.m_nSecondsRemainingEstimate
        public int nSecondsRemainingEstimate;
        /// missing documentation for SearchForGameProgressCallback_t.m_cPlayersSearching
        public int cPlayersSearching;
    }
}