using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ISteamMatchmakingPingResponse</summary>
    public unsafe interface ISteamMatchmakingPingResponse
    {
        public void ServerResponded(ref gameserveritem server);
        public void ServerFailedToRespond();
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamMatchmakingPingResponse_ServerResponded", CallingConvention = Platform.CC)]
        internal static extern void ServerResponded(void* self, ref gameserveritem server);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamMatchmakingPingResponse_ServerFailedToRespond", CallingConvention = Platform.CC)]
        internal static extern void ServerFailedToRespond(void* self);
        public struct Instance : ISteamMatchmakingPingResponse
        {
            public void* self;
            public void ServerResponded(ref gameserveritem server) => ISteamMatchmakingPingResponse.ServerResponded(self, ref server);
            public void ServerFailedToRespond() => ISteamMatchmakingPingResponse.ServerFailedToRespond(self);
        }
    }
}