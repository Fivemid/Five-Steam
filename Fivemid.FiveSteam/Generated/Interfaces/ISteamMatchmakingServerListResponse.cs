using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for ISteamMatchmakingServerListResponse
    public unsafe interface ISteamMatchmakingServerListResponse
    {
        public void ServerResponded(HServerListRequest hRequest, int iServer);
        public void ServerFailedToRespond(HServerListRequest hRequest, int iServer);
        public void RefreshComplete(HServerListRequest hRequest, MatchMakingServerResponse response);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamMatchmakingServerListResponse_ServerResponded", CallingConvention = Platform.CC)]
        internal static extern void ServerResponded(void* self, HServerListRequest hRequest, int iServer);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamMatchmakingServerListResponse_ServerFailedToRespond", CallingConvention = Platform.CC)]
        internal static extern void ServerFailedToRespond(void* self, HServerListRequest hRequest, int iServer);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamMatchmakingServerListResponse_RefreshComplete", CallingConvention = Platform.CC)]
        internal static extern void RefreshComplete(void* self, HServerListRequest hRequest, MatchMakingServerResponse response);
        public struct Instance : ISteamMatchmakingServerListResponse
        {
            public void* self;
            public void ServerResponded(HServerListRequest hRequest, int iServer) => ISteamMatchmakingServerListResponse.ServerResponded(self, hRequest, iServer);
            public void ServerFailedToRespond(HServerListRequest hRequest, int iServer) => ISteamMatchmakingServerListResponse.ServerFailedToRespond(self, hRequest, iServer);
            public void RefreshComplete(HServerListRequest hRequest, MatchMakingServerResponse response) => ISteamMatchmakingServerListResponse.RefreshComplete(self, hRequest, response);
        }
    }
}