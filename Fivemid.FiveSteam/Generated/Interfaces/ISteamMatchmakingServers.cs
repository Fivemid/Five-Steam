using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Functions which provide access to the game server browser.<br />
    /// <br />
    /// See <a href="https://partner.steamgames.com/doc/features/multiplayer/game_servers" class="bb_doclink">Game Servers</a> for more information.</summary>
    public unsafe interface ISteamMatchmakingServers
    {
        public HServerListRequest RequestInternetServerList(AppId iApp, MatchMakingKeyValuePair** ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse.Instance* pRequestServersResponse);
        public HServerListRequest RequestLANServerList(AppId iApp, ISteamMatchmakingServerListResponse.Instance* pRequestServersResponse);
        public HServerListRequest RequestFriendsServerList(AppId iApp, MatchMakingKeyValuePair** ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse.Instance* pRequestServersResponse);
        public HServerListRequest RequestFavoritesServerList(AppId iApp, MatchMakingKeyValuePair** ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse.Instance* pRequestServersResponse);
        public HServerListRequest RequestHistoryServerList(AppId iApp, MatchMakingKeyValuePair** ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse.Instance* pRequestServersResponse);
        public HServerListRequest RequestSpectatorServerList(AppId iApp, MatchMakingKeyValuePair** ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse.Instance* pRequestServersResponse);
        public void ReleaseRequest(HServerListRequest hServerListRequest);
        public gameserveritem* GetServerDetails(HServerListRequest hRequest, int iServer);
        public void CancelQuery(HServerListRequest hRequest);
        public void RefreshQuery(HServerListRequest hRequest);
        public bool IsRefreshing(HServerListRequest hRequest);
        public int GetServerCount(HServerListRequest hRequest);
        public void RefreshServer(HServerListRequest hRequest, int iServer);
        public HServerQuery PingServer(uint unIP, ushort usPort, ISteamMatchmakingPingResponse.Instance* pRequestServersResponse);
        public HServerQuery PlayerDetails(uint unIP, ushort usPort, ISteamMatchmakingPlayersResponse.Instance* pRequestServersResponse);
        public HServerQuery ServerRules(uint unIP, ushort usPort, ISteamMatchmakingRulesResponse.Instance* pRequestServersResponse);
        public void CancelServerQuery(HServerQuery hServerQuery);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmakingServers_RequestInternetServerList", CallingConvention = Platform.CC)]
        internal static extern HServerListRequest RequestInternetServerList(void* self, AppId iApp, MatchMakingKeyValuePair** ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse.Instance* pRequestServersResponse);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmakingServers_RequestLANServerList", CallingConvention = Platform.CC)]
        internal static extern HServerListRequest RequestLANServerList(void* self, AppId iApp, ISteamMatchmakingServerListResponse.Instance* pRequestServersResponse);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmakingServers_RequestFriendsServerList", CallingConvention = Platform.CC)]
        internal static extern HServerListRequest RequestFriendsServerList(void* self, AppId iApp, MatchMakingKeyValuePair** ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse.Instance* pRequestServersResponse);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmakingServers_RequestFavoritesServerList", CallingConvention = Platform.CC)]
        internal static extern HServerListRequest RequestFavoritesServerList(void* self, AppId iApp, MatchMakingKeyValuePair** ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse.Instance* pRequestServersResponse);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmakingServers_RequestHistoryServerList", CallingConvention = Platform.CC)]
        internal static extern HServerListRequest RequestHistoryServerList(void* self, AppId iApp, MatchMakingKeyValuePair** ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse.Instance* pRequestServersResponse);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmakingServers_RequestSpectatorServerList", CallingConvention = Platform.CC)]
        internal static extern HServerListRequest RequestSpectatorServerList(void* self, AppId iApp, MatchMakingKeyValuePair** ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse.Instance* pRequestServersResponse);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmakingServers_ReleaseRequest", CallingConvention = Platform.CC)]
        internal static extern void ReleaseRequest(void* self, HServerListRequest hServerListRequest);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmakingServers_GetServerDetails", CallingConvention = Platform.CC)]
        internal static extern gameserveritem* GetServerDetails(void* self, HServerListRequest hRequest, int iServer);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmakingServers_CancelQuery", CallingConvention = Platform.CC)]
        internal static extern void CancelQuery(void* self, HServerListRequest hRequest);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmakingServers_RefreshQuery", CallingConvention = Platform.CC)]
        internal static extern void RefreshQuery(void* self, HServerListRequest hRequest);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmakingServers_IsRefreshing", CallingConvention = Platform.CC)]
        internal static extern bool IsRefreshing(void* self, HServerListRequest hRequest);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmakingServers_GetServerCount", CallingConvention = Platform.CC)]
        internal static extern int GetServerCount(void* self, HServerListRequest hRequest);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmakingServers_RefreshServer", CallingConvention = Platform.CC)]
        internal static extern void RefreshServer(void* self, HServerListRequest hRequest, int iServer);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmakingServers_PingServer", CallingConvention = Platform.CC)]
        internal static extern HServerQuery PingServer(void* self, uint unIP, ushort usPort, ISteamMatchmakingPingResponse.Instance* pRequestServersResponse);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmakingServers_PlayerDetails", CallingConvention = Platform.CC)]
        internal static extern HServerQuery PlayerDetails(void* self, uint unIP, ushort usPort, ISteamMatchmakingPlayersResponse.Instance* pRequestServersResponse);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmakingServers_ServerRules", CallingConvention = Platform.CC)]
        internal static extern HServerQuery ServerRules(void* self, uint unIP, ushort usPort, ISteamMatchmakingRulesResponse.Instance* pRequestServersResponse);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamMatchmakingServers_CancelServerQuery", CallingConvention = Platform.CC)]
        internal static extern void CancelServerQuery(void* self, HServerQuery hServerQuery);
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct Instance : ISteamMatchmakingServers
        {
            public void* self;
            public HServerListRequest RequestInternetServerList(AppId iApp, MatchMakingKeyValuePair** ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse.Instance* pRequestServersResponse) => ISteamMatchmakingServers.RequestInternetServerList(self, iApp, ppchFilters, nFilters, pRequestServersResponse);
            public HServerListRequest RequestLANServerList(AppId iApp, ISteamMatchmakingServerListResponse.Instance* pRequestServersResponse) => ISteamMatchmakingServers.RequestLANServerList(self, iApp, pRequestServersResponse);
            public HServerListRequest RequestFriendsServerList(AppId iApp, MatchMakingKeyValuePair** ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse.Instance* pRequestServersResponse) => ISteamMatchmakingServers.RequestFriendsServerList(self, iApp, ppchFilters, nFilters, pRequestServersResponse);
            public HServerListRequest RequestFavoritesServerList(AppId iApp, MatchMakingKeyValuePair** ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse.Instance* pRequestServersResponse) => ISteamMatchmakingServers.RequestFavoritesServerList(self, iApp, ppchFilters, nFilters, pRequestServersResponse);
            public HServerListRequest RequestHistoryServerList(AppId iApp, MatchMakingKeyValuePair** ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse.Instance* pRequestServersResponse) => ISteamMatchmakingServers.RequestHistoryServerList(self, iApp, ppchFilters, nFilters, pRequestServersResponse);
            public HServerListRequest RequestSpectatorServerList(AppId iApp, MatchMakingKeyValuePair** ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse.Instance* pRequestServersResponse) => ISteamMatchmakingServers.RequestSpectatorServerList(self, iApp, ppchFilters, nFilters, pRequestServersResponse);
            public void ReleaseRequest(HServerListRequest hServerListRequest) => ISteamMatchmakingServers.ReleaseRequest(self, hServerListRequest);
            public gameserveritem* GetServerDetails(HServerListRequest hRequest, int iServer) => ISteamMatchmakingServers.GetServerDetails(self, hRequest, iServer);
            public void CancelQuery(HServerListRequest hRequest) => ISteamMatchmakingServers.CancelQuery(self, hRequest);
            public void RefreshQuery(HServerListRequest hRequest) => ISteamMatchmakingServers.RefreshQuery(self, hRequest);
            public bool IsRefreshing(HServerListRequest hRequest) => ISteamMatchmakingServers.IsRefreshing(self, hRequest);
            public int GetServerCount(HServerListRequest hRequest) => ISteamMatchmakingServers.GetServerCount(self, hRequest);
            public void RefreshServer(HServerListRequest hRequest, int iServer) => ISteamMatchmakingServers.RefreshServer(self, hRequest, iServer);
            public HServerQuery PingServer(uint unIP, ushort usPort, ISteamMatchmakingPingResponse.Instance* pRequestServersResponse) => ISteamMatchmakingServers.PingServer(self, unIP, usPort, pRequestServersResponse);
            public HServerQuery PlayerDetails(uint unIP, ushort usPort, ISteamMatchmakingPlayersResponse.Instance* pRequestServersResponse) => ISteamMatchmakingServers.PlayerDetails(self, unIP, usPort, pRequestServersResponse);
            public HServerQuery ServerRules(uint unIP, ushort usPort, ISteamMatchmakingRulesResponse.Instance* pRequestServersResponse) => ISteamMatchmakingServers.ServerRules(self, unIP, usPort, pRequestServersResponse);
            public void CancelServerQuery(HServerQuery hServerQuery) => ISteamMatchmakingServers.CancelServerQuery(self, hServerQuery);
        }
    }
}