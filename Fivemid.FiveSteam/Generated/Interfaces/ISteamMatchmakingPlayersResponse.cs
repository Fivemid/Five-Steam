using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for ISteamMatchmakingPlayersResponse
    public unsafe interface ISteamMatchmakingPlayersResponse
    {
        public void AddPlayerToList(UTF8StringPtr pchName, int nScore, float flTimePlayed);
        public void PlayersFailedToRespond();
        public void PlayersRefreshComplete();
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamMatchmakingPlayersResponse_AddPlayerToList", CallingConvention = Platform.CC)]
        internal static extern void AddPlayerToList(void* self, UTF8StringPtr pchName, int nScore, float flTimePlayed);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamMatchmakingPlayersResponse_PlayersFailedToRespond", CallingConvention = Platform.CC)]
        internal static extern void PlayersFailedToRespond(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamMatchmakingPlayersResponse_PlayersRefreshComplete", CallingConvention = Platform.CC)]
        internal static extern void PlayersRefreshComplete(void* self);
        public struct Instance : ISteamMatchmakingPlayersResponse
        {
            public void* self;
            public void AddPlayerToList(UTF8StringPtr pchName, int nScore, float flTimePlayed) => ISteamMatchmakingPlayersResponse.AddPlayerToList(self, pchName, nScore, flTimePlayed);
            public void PlayersFailedToRespond() => ISteamMatchmakingPlayersResponse.PlayersFailedToRespond(self);
            public void PlayersRefreshComplete() => ISteamMatchmakingPlayersResponse.PlayersRefreshComplete(self);
        }
    }
}