using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamMatchmakingServers
    {
        public static ISteamMatchmakingServers.Instance Instance => Accessor();

        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_SteamMatchmakingServers_v002", CallingConvention = Platform.CC)]
        private static extern ISteamMatchmakingServers.Instance Accessor();
        /// <summary><code>HServerListRequest RequestInternetServerList( AppId_t iApp, MatchMakingKeyValuePair_t **ppchFilters, uint32 nFilters, ISteamMatchmakingServerListResponse *pRequestServersResponse );</code><br />
        /// Request a new list of game servers from the 'internet' server list.<br />
        /// <br />
        /// See <a href="https://partner.steamgames.com/doc/api/ISteamMatchmakingServers#MatchMakingKeyValuePair_t" class="bb_apilink">MatchMakingKeyValuePair_t</a> for more information.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#HServerListRequest" class="bb_apilink">HServerListRequest</a><br />
        /// Triggers a <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#LobbyChatUpdate_t" class="bb_apilink">LobbyChatUpdate_t</a> callback.<br />
        /// A new asynchronous server list request object.<br />
        /// <br />
        /// <b>NOTE:</b> This request object must be released by calling <a href="https://partner.steamgames.com/doc/api/ISteamMatchmakingServers#ReleaseRequest" class="bb_apilink">ISteamMatchmakingServers::ReleaseRequest</a> when you're done using it!</summary>
        /// <param name="iApp"><a href="https://partner.steamgames.com/doc/api/steam_api#AppId_t" class="bb_apilink">AppId_t</a>: The app to get the server list of.</param>
        /// <param name="ppchFilters"><a href="https://partner.steamgames.com/doc/api/ISteamMatchmakingServers#MatchMakingKeyValuePair_t" class="bb_apilink">MatchMakingKeyValuePair_t</a> **: An array of filters to only retrieve servers the user cares about.</param>
        /// <param name="nFilters"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The number of filters in <code class="bb_code bb_code_inline nohighlight">ppchFilters</code> array.</param>
        /// <param name="pRequestServersResponse">ISteamMatchmakingServerListResponse *: This must be the object that inherits from <code class="bb_code bb_code_inline nohighlight">ISteamMatchmakingServerListResponse</code>. Typically <code class="bb_code bb_code_inline nohighlight">this</code>.</param>
        public static HServerListRequest RequestInternetServerList(AppId iApp, MatchMakingKeyValuePair** ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse.Instance* pRequestServersResponse) => Instance.RequestInternetServerList(iApp, ppchFilters, nFilters, pRequestServersResponse);
        /// <summary><code>HServerListRequest RequestLANServerList( AppId_t iApp, ISteamMatchmakingServerListResponse *pRequestServersResponse );</code><br />
        /// Request a new list of game servers from the 'LAN' server list.<br />
        /// <br />
        /// See <a href="https://partner.steamgames.com/doc/api/ISteamMatchmakingServers#MatchMakingKeyValuePair_t" class="bb_apilink">MatchMakingKeyValuePair_t</a> for more information.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#HServerListRequest" class="bb_apilink">HServerListRequest</a><br />
        /// A new asynchronous server list request object.<br />
        /// <br />
        /// <b>NOTE:</b> This request object must be released by calling <a href="https://partner.steamgames.com/doc/api/ISteamMatchmakingServers#ReleaseRequest" class="bb_apilink">ISteamMatchmakingServers::ReleaseRequest</a> when you're done using it!</summary>
        /// <param name="iApp"><a href="https://partner.steamgames.com/doc/api/steam_api#AppId_t" class="bb_apilink">AppId_t</a>: The app to request the server list of.</param>
        /// <param name="pRequestServersResponse">ISteamMatchmakingServerListResponse *: This must be the object that inherits from <code class="bb_code bb_code_inline nohighlight">ISteamMatchmakingServerListResponse</code>. Typically <code class="bb_code bb_code_inline nohighlight">this</code>.</param>
        public static HServerListRequest RequestLANServerList(AppId iApp, ISteamMatchmakingServerListResponse.Instance* pRequestServersResponse) => Instance.RequestLANServerList(iApp, pRequestServersResponse);
        /// <summary><code>HServerListRequest RequestFriendsServerList( AppId_t iApp, MatchMakingKeyValuePair_t **ppchFilters, uint32 nFilters, ISteamMatchmakingServerListResponse *pRequestServersResponse );</code><br />
        /// Request a new list of game servers from the 'friends' server list.<br />
        /// <br />
        /// See <a href="https://partner.steamgames.com/doc/api/ISteamMatchmakingServers#MatchMakingKeyValuePair_t" class="bb_apilink">MatchMakingKeyValuePair_t</a> for more information.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#HServerListRequest" class="bb_apilink">HServerListRequest</a><br />
        /// A new asynchronous server list request object.<br />
        /// <br />
        /// <b>NOTE:</b> This request object must be released by calling <a href="https://partner.steamgames.com/doc/api/ISteamMatchmakingServers#ReleaseRequest" class="bb_apilink">ISteamMatchmakingServers::ReleaseRequest</a> when you're done using it!</summary>
        /// <param name="iApp"><a href="https://partner.steamgames.com/doc/api/steam_api#AppId_t" class="bb_apilink">AppId_t</a>: The app to request the server list of.</param>
        /// <param name="ppchFilters"><a href="https://partner.steamgames.com/doc/api/ISteamMatchmakingServers#MatchMakingKeyValuePair_t" class="bb_apilink">MatchMakingKeyValuePair_t</a> **: An array of filters to only retrieve servers the user cares about.</param>
        /// <param name="nFilters"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The number of filters in <code class="bb_code bb_code_inline nohighlight">ppchFilters</code> array.</param>
        /// <param name="pRequestServersResponse">ISteamMatchmakingServerListResponse *: This must be the object that inherits from <code class="bb_code bb_code_inline nohighlight">ISteamMatchmakingServerListResponse</code>. Typically <code class="bb_code bb_code_inline nohighlight">this</code>.</param>
        public static HServerListRequest RequestFriendsServerList(AppId iApp, MatchMakingKeyValuePair** ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse.Instance* pRequestServersResponse) => Instance.RequestFriendsServerList(iApp, ppchFilters, nFilters, pRequestServersResponse);
        /// <summary><code>HServerListRequest RequestFavoritesServerList( AppId_t iApp, MatchMakingKeyValuePair_t **ppchFilters, uint32 nFilters, ISteamMatchmakingServerListResponse *pRequestServersResponse );</code><br />
        /// Request a new list of game servers from the 'favorites' server list.<br />
        /// <br />
        /// See <a href="https://partner.steamgames.com/doc/api/ISteamMatchmakingServers#MatchMakingKeyValuePair_t" class="bb_apilink">MatchMakingKeyValuePair_t</a> for more information.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#HServerListRequest" class="bb_apilink">HServerListRequest</a><br />
        /// A new asynchronous server list request object.<br />
        /// <br />
        /// <b>NOTE:</b> This request object must be released by calling <a href="https://partner.steamgames.com/doc/api/ISteamMatchmakingServers#ReleaseRequest" class="bb_apilink">ISteamMatchmakingServers::ReleaseRequest</a> when you're done using it!</summary>
        /// <param name="iApp"><a href="https://partner.steamgames.com/doc/api/steam_api#AppId_t" class="bb_apilink">AppId_t</a>: The app to request the server list of.</param>
        /// <param name="ppchFilters"><a href="https://partner.steamgames.com/doc/api/ISteamMatchmakingServers#MatchMakingKeyValuePair_t" class="bb_apilink">MatchMakingKeyValuePair_t</a> **: An array of filters to only retrieve servers the user cares about.</param>
        /// <param name="nFilters"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The number of filters in <code class="bb_code bb_code_inline nohighlight">ppchFilters</code> array.</param>
        /// <param name="pRequestServersResponse">ISteamMatchmakingServerListResponse *: This must be the object that inherits from <code class="bb_code bb_code_inline nohighlight">ISteamMatchmakingServerListResponse</code>. Typically <code class="bb_code bb_code_inline nohighlight">this</code>.</param>
        public static HServerListRequest RequestFavoritesServerList(AppId iApp, MatchMakingKeyValuePair** ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse.Instance* pRequestServersResponse) => Instance.RequestFavoritesServerList(iApp, ppchFilters, nFilters, pRequestServersResponse);
        /// <summary><code>HServerListRequest RequestHistoryServerList( AppId_t iApp, MatchMakingKeyValuePair_t **ppchFilters, uint32 nFilters, ISteamMatchmakingServerListResponse *pRequestServersResponse );</code><br />
        /// Request a new list of game servers from the 'history' server list.<br />
        /// <br />
        /// See <a href="https://partner.steamgames.com/doc/api/ISteamMatchmakingServers#MatchMakingKeyValuePair_t" class="bb_apilink">MatchMakingKeyValuePair_t</a> for more information.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#HServerListRequest" class="bb_apilink">HServerListRequest</a><br />
        /// A new asynchronous server list request object.<br />
        /// <br />
        /// <b>NOTE:</b> This request object must be released by calling <a href="https://partner.steamgames.com/doc/api/ISteamMatchmakingServers#ReleaseRequest" class="bb_apilink">ISteamMatchmakingServers::ReleaseRequest</a> when you're done using it!</summary>
        /// <param name="iApp"><a href="https://partner.steamgames.com/doc/api/steam_api#AppId_t" class="bb_apilink">AppId_t</a>: The app to get the server list of.</param>
        /// <param name="ppchFilters"><a href="https://partner.steamgames.com/doc/api/ISteamMatchmakingServers#MatchMakingKeyValuePair_t" class="bb_apilink">MatchMakingKeyValuePair_t</a> **: An array of filters to only retrieve servers the user cares about.</param>
        /// <param name="nFilters"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The number of filters in <code class="bb_code bb_code_inline nohighlight">ppchFilters</code> array.</param>
        /// <param name="pRequestServersResponse">ISteamMatchmakingServerListResponse *: This must be the object that inherits from <code class="bb_code bb_code_inline nohighlight">ISteamMatchmakingServerListResponse</code>. Typically <code class="bb_code bb_code_inline nohighlight">this</code>.</param>
        public static HServerListRequest RequestHistoryServerList(AppId iApp, MatchMakingKeyValuePair** ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse.Instance* pRequestServersResponse) => Instance.RequestHistoryServerList(iApp, ppchFilters, nFilters, pRequestServersResponse);
        /// <summary><code>HServerListRequest RequestSpectatorServerList( AppId_t iApp, MatchMakingKeyValuePair_t **ppchFilters, uint32 nFilters, ISteamMatchmakingServerListResponse *pRequestServersResponse );</code><br />
        /// Request a new list of game servers from the 'spectator' server list.<br />
        /// <br />
        /// See <a href="https://partner.steamgames.com/doc/api/ISteamMatchmakingServers#MatchMakingKeyValuePair_t" class="bb_apilink">MatchMakingKeyValuePair_t</a> for more information.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#HServerListRequest" class="bb_apilink">HServerListRequest</a><br />
        /// A new asynchronous server list request object.<br />
        /// <br />
        /// <b>NOTE:</b> This request object must be released by calling <a href="https://partner.steamgames.com/doc/api/ISteamMatchmakingServers#ReleaseRequest" class="bb_apilink">ISteamMatchmakingServers::ReleaseRequest</a> when you're done using it!</summary>
        /// <param name="iApp"><a href="https://partner.steamgames.com/doc/api/steam_api#AppId_t" class="bb_apilink">AppId_t</a>: The app to request the server list of.</param>
        /// <param name="ppchFilters"><a href="https://partner.steamgames.com/doc/api/ISteamMatchmakingServers#MatchMakingKeyValuePair_t" class="bb_apilink">MatchMakingKeyValuePair_t</a> **: An array of filters to only retrieve servers the user cares about.</param>
        /// <param name="nFilters"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The number of filters in <code class="bb_code bb_code_inline nohighlight">ppchFilters</code> array.</param>
        /// <param name="pRequestServersResponse">ISteamMatchmakingServerListResponse *: This must be the object that inherits from <code class="bb_code bb_code_inline nohighlight">ISteamMatchmakingServerListResponse</code>. Typically <code class="bb_code bb_code_inline nohighlight">this</code>.</param>
        public static HServerListRequest RequestSpectatorServerList(AppId iApp, MatchMakingKeyValuePair** ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse.Instance* pRequestServersResponse) => Instance.RequestSpectatorServerList(iApp, ppchFilters, nFilters, pRequestServersResponse);
        /// <summary><code>void ReleaseRequest( HServerListRequest hServerListRequest );</code><br />
        /// Releases the asynchronous server list request object and cancels any pending query on it if there's a pending query in progress.<br />
        /// <br />
        /// The <code class="bb_code bb_code_inline nohighlight">RefreshComplete</code> callback will not be posted when request is released.</summary>
        /// <param name="hServerListRequest"><a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#HServerListRequest" class="bb_apilink">HServerListRequest</a>: The asynchronous server list request object to release.</param>
        public static void ReleaseRequest(HServerListRequest hServerListRequest) => Instance.ReleaseRequest(hServerListRequest);
        /// <summary><code>gameserveritem_t * GetServerDetails( HServerListRequest hRequest, int iServer );</code><br />
        /// Get the details of a given server in the list. <br />
        /// <br />
        /// You can get the valid range of index values by calling <a href="https://partner.steamgames.com/doc/api/ISteamMatchmakingServers#GetServerCount" class="bb_apilink">ISteamMatchmakingServers::GetServerCount</a>.<br />
        /// <br />
        /// You will also receive index values in <code class="bb_code bb_code_inline nohighlight">ISteamMatchmakingServerListResponse::ServerResponded</code> callbacks.<br />
        /// <br />
        /// <b>Returns:</b> gameserveritem_t *</summary>
        /// <param name="hRequest"><a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#HServerListRequest" class="bb_apilink">HServerListRequest</a>: The handle to the server list request.</param>
        /// <param name="iServer">int: The index of the server to get the details of, from 0 to <a href="https://partner.steamgames.com/doc/api/ISteamMatchmakingServers#GetServerCount" class="bb_apilink">ISteamMatchmakingServers::GetServerCount</a>.</param>
        public static gameserveritem* GetServerDetails(HServerListRequest hRequest, int iServer) => Instance.GetServerDetails(hRequest, iServer);
        /// <summary><code>void CancelQuery( HServerListRequest hRequest );</code><br />
        /// Cancel an outstanding server list request.<br />
        /// You should call this to cancel any in-progress requests before destructing a callback object that may have been passed<br />
        /// to one of the below request calls. Not doing so may result in a crash when a callback occurs on the destructed object.<br />
        /// Canceling a query does not release the allocated request handle. The request handle must be released using <a href="https://partner.steamgames.com/doc/api/ISteamMatchmakingServers#ReleaseRequest" class="bb_apilink">ISteamMatchmakingServers::ReleaseRequest</a>.</summary>
        /// <param name="hRequest"><a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#HServerListRequest" class="bb_apilink">HServerListRequest</a>: The handle to the server list request.</param>
        public static void CancelQuery(HServerListRequest hRequest) => Instance.CancelQuery(hRequest);
        /// <summary><code>void RefreshQuery( HServerListRequest hRequest );</code><br />
        /// Ping every server in your list again but don't update the list of servers.<br />
        /// <br />
        /// The query callback installed when the server list was requested will be used again to post notifications and <code class="bb_code bb_code_inline nohighlight">RefreshComplete</code> will be called again, so the callback must remain valid until it completes or the request is released with <a href="https://partner.steamgames.com/doc/api/ISteamMatchmakingServers#ReleaseRequest" class="bb_apilink">ISteamMatchmakingServers::ReleaseRequest</a>.</summary>
        /// <param name="hRequest"><a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#HServerListRequest" class="bb_apilink">HServerListRequest</a>: The handle to the server list request.</param>
        public static void RefreshQuery(HServerListRequest hRequest) => Instance.RefreshQuery(hRequest);
        /// <summary><code>bool IsRefreshing( HServerListRequest hRequest );</code><br />
        /// Checks if the server list request is currently refreshing.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if <code class="bb_code bb_code_inline nohighlight">hRequest</code> is valid, and is currently refreshing; otherwise, <b>false</b>.</summary>
        /// <param name="hRequest"><a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#HServerListRequest" class="bb_apilink">HServerListRequest</a>: The handle to the server list request.</param>
        public static bool IsRefreshing(HServerListRequest hRequest) => Instance.IsRefreshing(hRequest);
        /// <summary><code>int GetServerCount( HServerListRequest hRequest );</code><br />
        /// Gets the number of servers in the given list.<br />
        /// <br />
        /// This is used for iterating with <a href="https://partner.steamgames.com/doc/api/ISteamMatchmakingServers#GetServerDetails" class="bb_apilink">ISteamMatchmakingServers::GetServerDetails</a>.<br />
        /// <br />
        /// <b>Returns:</b> int<br />
        /// The number of servers in a server list request object.<br />
        /// <br />
        /// Returns <b>0</b> if <code class="bb_code bb_code_inline nohighlight">hRequest</code> is invalid.</summary>
        /// <param name="hRequest"><a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#HServerListRequest" class="bb_apilink">HServerListRequest</a>: The handle to the server list request.</param>
        public static int GetServerCount(HServerListRequest hRequest) => Instance.GetServerCount(hRequest);
        /// <summary><code>void RefreshServer( HServerListRequest hRequest, int iServer );</code><br />
        /// Refreshes a single server inside of a query.<br />
        /// <br />
        /// If you want to refresh all of the servers then you should use <a href="https://partner.steamgames.com/doc/api/ISteamMatchmakingServers#RefreshQuery" class="bb_apilink">ISteamMatchmakingServers::RefreshQuery</a>.</summary>
        /// <param name="hRequest"><a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#HServerListRequest" class="bb_apilink">HServerListRequest</a>: The handle to the server list request.</param>
        /// <param name="iServer">int: The index of the server to refresh, from 0 to <a href="https://partner.steamgames.com/doc/api/ISteamMatchmakingServers#GetServerCount" class="bb_apilink">ISteamMatchmakingServers::GetServerCount</a>.</param>
        public static void RefreshServer(HServerListRequest hRequest, int iServer) => Instance.RefreshServer(hRequest, iServer);
        /// <summary><code>HServerQuery PingServer( uint32 unIP, uint16 usPort, ISteamMatchmakingPingResponse *pRequestServersResponse );</code><br />
        /// Queries an individual game servers directly via IP/Port to request an updated ping time and other details from the server.<br />
        /// <br />
        /// You must inherit from the <code class="bb_code bb_code_inline nohighlight">ISteamMatchmakingPingResponse</code> object to receive this callback.<h4>ISteamMatchmakingPingResponse</h4>Callback interface for receiving responses after pinging an individual server.<br />
        /// <br />
        /// If you are destructing an object that implements this interface then you should call <a href="https://partner.steamgames.com/doc/api/ISteamMatchmakingServers#CancelServerQuery" class="bb_apilink">ISteamMatchmakingServers::CancelServerQuery</a> passing in the handle to the query which is in progress. Failure to cancel in progress queries when destructing a callback handler may result in a crash when a callback later occurs.<br />
        /// <br />
        /// <b>Member functions:</b><br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#HServerQuery" class="bb_apilink">HServerQuery</a><br />
        /// Handle to the outstanding server query.</summary>
        /// 
        public static HServerQuery PingServer(uint unIP, ushort usPort, ISteamMatchmakingPingResponse.Instance* pRequestServersResponse) => Instance.PingServer(unIP, usPort, pRequestServersResponse);
        /// <summary><code>HServerQuery PlayerDetails( uint32 unIP, uint16 usPort, ISteamMatchmakingPlayersResponse *pRequestServersResponse );</code><br />
        /// Queries an individual game servers directly via IP/Port to request the list of players currently playing on the server.<br />
        /// <br />
        /// You must inherit from the <code class="bb_code bb_code_inline nohighlight">ISteamMatchmakingPlayersResponse</code> object to receive this callback.<h4>ISteamMatchmakingPlayersResponse</h4>Callback interface for receiving responses after pinging an individual server.<br />
        /// <br />
        /// If you are destructing an object that implements this interface then you should call <a href="https://partner.steamgames.com/doc/api/ISteamMatchmakingServers#CancelServerQuery" class="bb_apilink">ISteamMatchmakingServers::CancelServerQuery</a> passing in the handle to the query which is in progress. Failure to cancel in progress queries when destructing a callback handler may result in a crash when a callback later occurs.<br />
        /// <br />
        /// <b>Member functions:</b><br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#HServerQuery" class="bb_apilink">HServerQuery</a><br />
        /// Handle to the outstanding server query.</summary>
        /// 
        public static HServerQuery PlayerDetails(uint unIP, ushort usPort, ISteamMatchmakingPlayersResponse.Instance* pRequestServersResponse) => Instance.PlayerDetails(unIP, usPort, pRequestServersResponse);
        /// <summary><code>HServerQuery ServerRules( uint32 unIP, uint16 usPort, ISteamMatchmakingRulesResponse *pRequestServersResponse );</code><br />
        /// Queries an individual game servers directly via IP/Port to request the list of rules that the server is running. (See <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#SetKeyValue" class="bb_apilink">ISteamGameServer::SetKeyValue</a> to set the rules on the server side.)<br />
        /// <br />
        /// You must inherit from the <code class="bb_code bb_code_inline nohighlight">ISteamMatchmakingRulesResponse</code> object to receive this callback.<h4>ISteamMatchmakingRulesResponse</h4>Callback interface for receiving responses after pinging an individual server.<br />
        /// <br />
        /// If you are destructing an object that implements this interface then you should call <a href="https://partner.steamgames.com/doc/api/ISteamMatchmakingServers#CancelServerQuery" class="bb_apilink">ISteamMatchmakingServers::CancelServerQuery</a> passing in the handle to the query which is in progress. Failure to cancel in progress queries when destructing a callback handler may result in a crash when a callback later occurs.<br />
        /// <br />
        /// <b>Member functions:</b><br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#HServerQuery" class="bb_apilink">HServerQuery</a><br />
        /// Handle to the outstanding server query.</summary>
        /// 
        public static HServerQuery ServerRules(uint unIP, ushort usPort, ISteamMatchmakingRulesResponse.Instance* pRequestServersResponse) => Instance.ServerRules(unIP, usPort, pRequestServersResponse);
        /// <summary><code>void CancelServerQuery( HServerQuery hServerQuery );</code><br />
        /// Cancel an outstanding individual server query.<br />
        /// <br />
        /// The calls that create this type of query are:<br />
        /// <ul class="bb_ul ">	<li> <a href="https://partner.steamgames.com/doc/api/ISteamMatchmakingServers#PingServer" class="bb_apilink">ISteamMatchmakingServers::PingServer</a><br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/ISteamMatchmakingServers#PlayerDetails" class="bb_apilink">ISteamMatchmakingServers::PlayerDetails</a><br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/ISteamMatchmakingServers#ServerRules" class="bb_apilink">ISteamMatchmakingServers::ServerRules</a></li></ul><br />
        /// You should call this to cancel any in-progress requests before destructing a callback object that may have been passed to one of the above calls to avoid crashing when callbacks occur.</summary>
        /// <param name="hServerQuery"><a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#HServerQuery" class="bb_apilink">HServerQuery</a>: The server query to cancel.</param>
        public static void CancelServerQuery(HServerQuery hServerQuery) => Instance.CancelServerQuery(hServerQuery);
    }
}