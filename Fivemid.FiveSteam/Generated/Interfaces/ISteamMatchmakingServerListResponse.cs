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
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmakingServerListResponse_ServerResponded", CallingConvention = Platform.CC)]
        internal static extern void ServerResponded(void* self, HServerListRequest hRequest, int iServer);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmakingServerListResponse_ServerFailedToRespond", CallingConvention = Platform.CC)]
        internal static extern void ServerFailedToRespond(void* self, HServerListRequest hRequest, int iServer);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmakingServerListResponse_RefreshComplete", CallingConvention = Platform.CC)]
        internal static extern void RefreshComplete(void* self, HServerListRequest hRequest, MatchMakingServerResponse response);
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
        public struct Instance : ISteamMatchmakingServerListResponse
        {
            public void* self;
            public void ServerResponded(HServerListRequest hRequest, int iServer) => ISteamMatchmakingServerListResponse.ServerResponded(self, hRequest, iServer);
            public void ServerFailedToRespond(HServerListRequest hRequest, int iServer) => ISteamMatchmakingServerListResponse.ServerFailedToRespond(self, hRequest, iServer);
            public void RefreshComplete(HServerListRequest hRequest, MatchMakingServerResponse response) => ISteamMatchmakingServerListResponse.RefreshComplete(self, hRequest, response);
        }
    }
}