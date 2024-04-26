using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Interface to create a new steam instance or to connect to an existing steam instance, whether it's in a different process or is local.<br />
    /// <br />
    /// In most scenarios this is all handled automatically via <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPI_Init" class="bb_apilink">SteamAPI_Init</a>.<br />
    /// You'll only ever need to use these APIs if you have a more complex versioning scheme, or if you want to implement a multiplexed gameserver where a single process is handling multiple games at once with independent gameserver Steam IDs.</summary>
    public unsafe interface ISteamClient
    {
        public HSteamPipe CreateSteamPipe();
        public bool BReleaseSteamPipe(HSteamPipe hSteamPipe);
        public HSteamUser ConnectToGlobalUser(HSteamPipe hSteamPipe);
        public HSteamUser CreateLocalUser(HSteamPipe* phSteamPipe, AccountType eAccountType);
        public void ReleaseUser(HSteamPipe hSteamPipe, HSteamUser hUser);
        public ISteamUser.Instance* GetISteamUser(HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        public ISteamGameServer.Instance* GetISteamGameServer(HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        public void SetLocalIPBinding(ref SteamIPAddress unIP, ushort usPort);
        public ISteamFriends.Instance* GetISteamFriends(HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        public ISteamUtils.Instance* GetISteamUtils(HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        public ISteamMatchmaking.Instance* GetISteamMatchmaking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        public ISteamMatchmakingServers.Instance* GetISteamMatchmakingServers(HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        public void* GetISteamGenericInterface(HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        public ISteamUserStats.Instance* GetISteamUserStats(HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        public ISteamGameServerStats.Instance* GetISteamGameServerStats(HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        public ISteamApps.Instance* GetISteamApps(HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        public ISteamNetworking.Instance* GetISteamNetworking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        public ISteamRemoteStorage.Instance* GetISteamRemoteStorage(HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        public ISteamScreenshots.Instance* GetISteamScreenshots(HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        public ISteamGameSearch.Instance* GetISteamGameSearch(HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        public uint GetIPCCallCount();
        public void SetWarningMessageHook(Unknown pFunction);
        public bool BShutdownIfAllPipesClosed();
        public ISteamHTTP.Instance* GetISteamHTTP(HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        public ISteamController.Instance* GetISteamController(HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        public ISteamUGC.Instance* GetISteamUGC(HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        public ISteamMusic.Instance* GetISteamMusic(HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        public ISteamMusicRemote.Instance* GetISteamMusicRemote(HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        public ISteamHTMLSurface.Instance* GetISteamHTMLSurface(HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        public ISteamInventory.Instance* GetISteamInventory(HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        public ISteamParentalSettings.Instance* GetISteamParentalSettings(HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        public ISteamInput.Instance* GetISteamInput(HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        public ISteamParties.Instance* GetISteamParties(HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        public ISteamRemotePlay.Instance* GetISteamRemotePlay(HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamClient_CreateSteamPipe", CallingConvention = Platform.CC)]
        internal static extern HSteamPipe CreateSteamPipe(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamClient_BReleaseSteamPipe", CallingConvention = Platform.CC)]
        internal static extern bool BReleaseSteamPipe(void* self, HSteamPipe hSteamPipe);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamClient_ConnectToGlobalUser", CallingConvention = Platform.CC)]
        internal static extern HSteamUser ConnectToGlobalUser(void* self, HSteamPipe hSteamPipe);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamClient_CreateLocalUser", CallingConvention = Platform.CC)]
        internal static extern HSteamUser CreateLocalUser(void* self, HSteamPipe* phSteamPipe, AccountType eAccountType);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamClient_ReleaseUser", CallingConvention = Platform.CC)]
        internal static extern void ReleaseUser(void* self, HSteamPipe hSteamPipe, HSteamUser hUser);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamClient_GetISteamUser", CallingConvention = Platform.CC)]
        internal static extern ISteamUser.Instance* GetISteamUser(void* self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamClient_GetISteamGameServer", CallingConvention = Platform.CC)]
        internal static extern ISteamGameServer.Instance* GetISteamGameServer(void* self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamClient_SetLocalIPBinding", CallingConvention = Platform.CC)]
        internal static extern void SetLocalIPBinding(void* self, ref SteamIPAddress unIP, ushort usPort);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamClient_GetISteamFriends", CallingConvention = Platform.CC)]
        internal static extern ISteamFriends.Instance* GetISteamFriends(void* self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamClient_GetISteamUtils", CallingConvention = Platform.CC)]
        internal static extern ISteamUtils.Instance* GetISteamUtils(void* self, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamClient_GetISteamMatchmaking", CallingConvention = Platform.CC)]
        internal static extern ISteamMatchmaking.Instance* GetISteamMatchmaking(void* self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamClient_GetISteamMatchmakingServers", CallingConvention = Platform.CC)]
        internal static extern ISteamMatchmakingServers.Instance* GetISteamMatchmakingServers(void* self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamClient_GetISteamGenericInterface", CallingConvention = Platform.CC)]
        internal static extern void* GetISteamGenericInterface(void* self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamClient_GetISteamUserStats", CallingConvention = Platform.CC)]
        internal static extern ISteamUserStats.Instance* GetISteamUserStats(void* self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamClient_GetISteamGameServerStats", CallingConvention = Platform.CC)]
        internal static extern ISteamGameServerStats.Instance* GetISteamGameServerStats(void* self, HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamClient_GetISteamApps", CallingConvention = Platform.CC)]
        internal static extern ISteamApps.Instance* GetISteamApps(void* self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamClient_GetISteamNetworking", CallingConvention = Platform.CC)]
        internal static extern ISteamNetworking.Instance* GetISteamNetworking(void* self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamClient_GetISteamRemoteStorage", CallingConvention = Platform.CC)]
        internal static extern ISteamRemoteStorage.Instance* GetISteamRemoteStorage(void* self, HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamClient_GetISteamScreenshots", CallingConvention = Platform.CC)]
        internal static extern ISteamScreenshots.Instance* GetISteamScreenshots(void* self, HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamClient_GetISteamGameSearch", CallingConvention = Platform.CC)]
        internal static extern ISteamGameSearch.Instance* GetISteamGameSearch(void* self, HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamClient_GetIPCCallCount", CallingConvention = Platform.CC)]
        internal static extern uint GetIPCCallCount(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamClient_SetWarningMessageHook", CallingConvention = Platform.CC)]
        internal static extern void SetWarningMessageHook(void* self, Unknown pFunction);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamClient_BShutdownIfAllPipesClosed", CallingConvention = Platform.CC)]
        internal static extern bool BShutdownIfAllPipesClosed(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamClient_GetISteamHTTP", CallingConvention = Platform.CC)]
        internal static extern ISteamHTTP.Instance* GetISteamHTTP(void* self, HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamClient_GetISteamController", CallingConvention = Platform.CC)]
        internal static extern ISteamController.Instance* GetISteamController(void* self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamClient_GetISteamUGC", CallingConvention = Platform.CC)]
        internal static extern ISteamUGC.Instance* GetISteamUGC(void* self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamClient_GetISteamMusic", CallingConvention = Platform.CC)]
        internal static extern ISteamMusic.Instance* GetISteamMusic(void* self, HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamClient_GetISteamMusicRemote", CallingConvention = Platform.CC)]
        internal static extern ISteamMusicRemote.Instance* GetISteamMusicRemote(void* self, HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamClient_GetISteamHTMLSurface", CallingConvention = Platform.CC)]
        internal static extern ISteamHTMLSurface.Instance* GetISteamHTMLSurface(void* self, HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamClient_GetISteamInventory", CallingConvention = Platform.CC)]
        internal static extern ISteamInventory.Instance* GetISteamInventory(void* self, HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamClient_GetISteamParentalSettings", CallingConvention = Platform.CC)]
        internal static extern ISteamParentalSettings.Instance* GetISteamParentalSettings(void* self, HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamClient_GetISteamInput", CallingConvention = Platform.CC)]
        internal static extern ISteamInput.Instance* GetISteamInput(void* self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamClient_GetISteamParties", CallingConvention = Platform.CC)]
        internal static extern ISteamParties.Instance* GetISteamParties(void* self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamClient_GetISteamRemotePlay", CallingConvention = Platform.CC)]
        internal static extern ISteamRemotePlay.Instance* GetISteamRemotePlay(void* self, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion);
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
        public struct Instance : ISteamClient
        {
            public void* self;
            public HSteamPipe CreateSteamPipe() => ISteamClient.CreateSteamPipe(self);
            public bool BReleaseSteamPipe(HSteamPipe hSteamPipe) => ISteamClient.BReleaseSteamPipe(self, hSteamPipe);
            public HSteamUser ConnectToGlobalUser(HSteamPipe hSteamPipe) => ISteamClient.ConnectToGlobalUser(self, hSteamPipe);
            public HSteamUser CreateLocalUser(HSteamPipe* phSteamPipe, AccountType eAccountType) => ISteamClient.CreateLocalUser(self, phSteamPipe, eAccountType);
            public void ReleaseUser(HSteamPipe hSteamPipe, HSteamUser hUser) => ISteamClient.ReleaseUser(self, hSteamPipe, hUser);
            public ISteamUser.Instance* GetISteamUser(HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion) => ISteamClient.GetISteamUser(self, hSteamUser, hSteamPipe, pchVersion);
            public ISteamGameServer.Instance* GetISteamGameServer(HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion) => ISteamClient.GetISteamGameServer(self, hSteamUser, hSteamPipe, pchVersion);
            public void SetLocalIPBinding(ref SteamIPAddress unIP, ushort usPort) => ISteamClient.SetLocalIPBinding(self, ref unIP, usPort);
            public ISteamFriends.Instance* GetISteamFriends(HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion) => ISteamClient.GetISteamFriends(self, hSteamUser, hSteamPipe, pchVersion);
            public ISteamUtils.Instance* GetISteamUtils(HSteamPipe hSteamPipe, UTF8StringPtr pchVersion) => ISteamClient.GetISteamUtils(self, hSteamPipe, pchVersion);
            public ISteamMatchmaking.Instance* GetISteamMatchmaking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion) => ISteamClient.GetISteamMatchmaking(self, hSteamUser, hSteamPipe, pchVersion);
            public ISteamMatchmakingServers.Instance* GetISteamMatchmakingServers(HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion) => ISteamClient.GetISteamMatchmakingServers(self, hSteamUser, hSteamPipe, pchVersion);
            public void* GetISteamGenericInterface(HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion) => ISteamClient.GetISteamGenericInterface(self, hSteamUser, hSteamPipe, pchVersion);
            public ISteamUserStats.Instance* GetISteamUserStats(HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion) => ISteamClient.GetISteamUserStats(self, hSteamUser, hSteamPipe, pchVersion);
            public ISteamGameServerStats.Instance* GetISteamGameServerStats(HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion) => ISteamClient.GetISteamGameServerStats(self, hSteamuser, hSteamPipe, pchVersion);
            public ISteamApps.Instance* GetISteamApps(HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion) => ISteamClient.GetISteamApps(self, hSteamUser, hSteamPipe, pchVersion);
            public ISteamNetworking.Instance* GetISteamNetworking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion) => ISteamClient.GetISteamNetworking(self, hSteamUser, hSteamPipe, pchVersion);
            public ISteamRemoteStorage.Instance* GetISteamRemoteStorage(HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion) => ISteamClient.GetISteamRemoteStorage(self, hSteamuser, hSteamPipe, pchVersion);
            public ISteamScreenshots.Instance* GetISteamScreenshots(HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion) => ISteamClient.GetISteamScreenshots(self, hSteamuser, hSteamPipe, pchVersion);
            public ISteamGameSearch.Instance* GetISteamGameSearch(HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion) => ISteamClient.GetISteamGameSearch(self, hSteamuser, hSteamPipe, pchVersion);
            public uint GetIPCCallCount() => ISteamClient.GetIPCCallCount(self);
            public void SetWarningMessageHook(Unknown pFunction) => ISteamClient.SetWarningMessageHook(self, pFunction);
            public bool BShutdownIfAllPipesClosed() => ISteamClient.BShutdownIfAllPipesClosed(self);
            public ISteamHTTP.Instance* GetISteamHTTP(HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion) => ISteamClient.GetISteamHTTP(self, hSteamuser, hSteamPipe, pchVersion);
            public ISteamController.Instance* GetISteamController(HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion) => ISteamClient.GetISteamController(self, hSteamUser, hSteamPipe, pchVersion);
            public ISteamUGC.Instance* GetISteamUGC(HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion) => ISteamClient.GetISteamUGC(self, hSteamUser, hSteamPipe, pchVersion);
            public ISteamMusic.Instance* GetISteamMusic(HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion) => ISteamClient.GetISteamMusic(self, hSteamuser, hSteamPipe, pchVersion);
            public ISteamMusicRemote.Instance* GetISteamMusicRemote(HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion) => ISteamClient.GetISteamMusicRemote(self, hSteamuser, hSteamPipe, pchVersion);
            public ISteamHTMLSurface.Instance* GetISteamHTMLSurface(HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion) => ISteamClient.GetISteamHTMLSurface(self, hSteamuser, hSteamPipe, pchVersion);
            public ISteamInventory.Instance* GetISteamInventory(HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion) => ISteamClient.GetISteamInventory(self, hSteamuser, hSteamPipe, pchVersion);
            public ISteamParentalSettings.Instance* GetISteamParentalSettings(HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion) => ISteamClient.GetISteamParentalSettings(self, hSteamuser, hSteamPipe, pchVersion);
            public ISteamInput.Instance* GetISteamInput(HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion) => ISteamClient.GetISteamInput(self, hSteamUser, hSteamPipe, pchVersion);
            public ISteamParties.Instance* GetISteamParties(HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion) => ISteamClient.GetISteamParties(self, hSteamUser, hSteamPipe, pchVersion);
            public ISteamRemotePlay.Instance* GetISteamRemotePlay(HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringPtr pchVersion) => ISteamClient.GetISteamRemotePlay(self, hSteamUser, hSteamPipe, pchVersion);
        }
    }
}