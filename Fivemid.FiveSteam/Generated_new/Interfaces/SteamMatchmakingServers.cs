using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamMatchmakingServers
    {
        public static ISteamMatchmakingServers.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamMatchmakingServers_v002", CallingConvention = Platform.CC)]
        private static extern ISteamMatchmakingServers.Instance Accessor();
        /// <summary></summary>
        public static HServerListRequest RequestInternetServerList(AppId iApp, MatchMakingKeyValuePair** ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse.Instance* pRequestServersResponse) => Instance.RequestInternetServerList(iApp, ppchFilters, nFilters, pRequestServersResponse);
        /// <summary></summary>
        public static HServerListRequest RequestLANServerList(AppId iApp, ISteamMatchmakingServerListResponse.Instance* pRequestServersResponse) => Instance.RequestLANServerList(iApp, pRequestServersResponse);
        /// <summary></summary>
        public static HServerListRequest RequestFriendsServerList(AppId iApp, MatchMakingKeyValuePair** ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse.Instance* pRequestServersResponse) => Instance.RequestFriendsServerList(iApp, ppchFilters, nFilters, pRequestServersResponse);
        /// <summary></summary>
        public static HServerListRequest RequestFavoritesServerList(AppId iApp, MatchMakingKeyValuePair** ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse.Instance* pRequestServersResponse) => Instance.RequestFavoritesServerList(iApp, ppchFilters, nFilters, pRequestServersResponse);
        /// <summary></summary>
        public static HServerListRequest RequestHistoryServerList(AppId iApp, MatchMakingKeyValuePair** ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse.Instance* pRequestServersResponse) => Instance.RequestHistoryServerList(iApp, ppchFilters, nFilters, pRequestServersResponse);
        /// <summary></summary>
        public static HServerListRequest RequestSpectatorServerList(AppId iApp, MatchMakingKeyValuePair** ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse.Instance* pRequestServersResponse) => Instance.RequestSpectatorServerList(iApp, ppchFilters, nFilters, pRequestServersResponse);
        /// <summary></summary>
        public static void ReleaseRequest(HServerListRequest hServerListRequest) => Instance.ReleaseRequest(hServerListRequest);
        /// <summary></summary>
        public static gameserveritem* GetServerDetails(HServerListRequest hRequest, int iServer) => Instance.GetServerDetails(hRequest, iServer);
        /// <summary></summary>
        public static void CancelQuery(HServerListRequest hRequest) => Instance.CancelQuery(hRequest);
        /// <summary></summary>
        public static void RefreshQuery(HServerListRequest hRequest) => Instance.RefreshQuery(hRequest);
        /// <summary></summary>
        public static bool IsRefreshing(HServerListRequest hRequest) => Instance.IsRefreshing(hRequest);
        /// <summary></summary>
        public static int GetServerCount(HServerListRequest hRequest) => Instance.GetServerCount(hRequest);
        /// <summary></summary>
        public static void RefreshServer(HServerListRequest hRequest, int iServer) => Instance.RefreshServer(hRequest, iServer);
        /// <summary></summary>
        public static HServerQuery PingServer(uint unIP, ushort usPort, ISteamMatchmakingPingResponse.Instance* pRequestServersResponse) => Instance.PingServer(unIP, usPort, pRequestServersResponse);
        /// <summary></summary>
        public static HServerQuery PlayerDetails(uint unIP, ushort usPort, ISteamMatchmakingPlayersResponse.Instance* pRequestServersResponse) => Instance.PlayerDetails(unIP, usPort, pRequestServersResponse);
        /// <summary></summary>
        public static HServerQuery ServerRules(uint unIP, ushort usPort, ISteamMatchmakingRulesResponse.Instance* pRequestServersResponse) => Instance.ServerRules(unIP, usPort, pRequestServersResponse);
        /// <summary></summary>
        public static void CancelServerQuery(HServerQuery hServerQuery) => Instance.CancelServerQuery(hServerQuery);
    }
}