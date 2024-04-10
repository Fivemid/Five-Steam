using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamMatchmaking
    {
        public static ISteamMatchmaking.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamMatchmaking_v009", CallingConvention = Platform.CC)]
        private static extern ISteamMatchmaking.Instance Accessor();
        /// <summary>
        /// <code>int GetFavoriteGameCount();</code>
        /// Gets the number of favorite and recent game servers the user has stored locally.<br />
        /// <br />
        /// <b>Returns:</b> int<br />
        /// <br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#AddFavoriteGame" class="bb_apilink">ISteamMatchmaking::AddFavoriteGame</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#RemoveFavoriteGame" class="bb_apilink">ISteamMatchmaking::RemoveFavoriteGame</a>
        /// </summary>
        /// 
        public static int GetFavoriteGameCount() => Instance.GetFavoriteGameCount();
        /// <summary>
        /// <code>
        ///     bool GetFavoriteGame( int iGame, AppId_t *pnAppID, uint32 *pnIP, uint16 *pnConnPort, uint16
        ///     *pnQueryPort, uint32 *punFlags, uint32 *pRTime32LastPlayedOnServer );
        /// </code>
        /// 
        /// <br />
        /// Gets the details of the favorite game server by index.<br />
        /// <br />
        /// <b>NOTE:</b> You must call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#GetFavoriteGameCount" class="bb_apilink">ISteamMatchmaking::GetFavoriteGameCount</a>
        /// before calling this.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the details were successfully retrieved. <b>false</b> if
        /// <code class="bb_code bb_code_inline nohighlight">iGame</code> was an invalid index.<br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#AddFavoriteGame" class="bb_apilink">ISteamMatchmaking::AddFavoriteGame</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#RemoveFavoriteGame" class="bb_apilink">ISteamMatchmaking::RemoveFavoriteGame</a>
        /// </summary>
        /// <param name="iGame">int: 
        ///             The index of the favorite game server to get the details of. This must be between 0 and
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#GetFavoriteGameCount" class="bb_apilink">ISteamMatchmaking::GetFavoriteGameCount</a>
        ///         </param>
        /// <param name="pnAppID">AppId_t
        ///             *: Returns the App ID this server is for.</param>
        /// <param name="pnIP">uint32
        ///             *: Returns the IP address of the server in host order, i.e 127.0.0.1 == 0x7f000001.</param>
        /// <param name="pnConnPort">uint16
        ///             *: Returns the port used to connect to the server, in host order.</param>
        /// <param name="pnQueryPort">uint16
        ///             *: Returns the port used to query the server, in host order.</param>
        /// <param name="punFlags">uint32
        ///             *: 
        ///             Returns whether the server is on the favorites list or the history list. See
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#k_unFavoriteFlagNone" class="bb_apilink">k_unFavoriteFlagNone</a>
        ///             for more information.
        ///         </param>
        /// <param name="pRTime32LastPlayedOnServer">uint32
        ///             *: 
        ///             Returns the time the server was last added to the favorites list in Unix epoch format
        ///             (seconds since Jan 1st, 1970).
        ///         </param>
        public static bool GetFavoriteGame(int iGame, AppId* pnAppID, uint* pnIP, ushort* pnConnPort, ushort* pnQueryPort, uint* punFlags, uint* pRTime32LastPlayedOnServer) => Instance.GetFavoriteGame(iGame, pnAppID, pnIP, pnConnPort, pnQueryPort, punFlags, pRTime32LastPlayedOnServer);
        /// <summary>
        /// <code>
        ///     int AddFavoriteGame( AppId_t nAppID, uint32 nIP, uint16 nConnPort, uint16 nQueryPort, uint32
        ///     unFlags, uint32 rTime32LastPlayedOnServer );
        /// </code>
        /// 
        /// <br />
        /// Adds the game server to the local favorites list or updates the time played of the server if it
        /// already exists in the list.<br />
        /// <br />
        /// <b>Returns:</b> int
        /// </summary>
        /// <param name="nAppID">AppId_t: The App ID of the game.</param>
        /// <param name="nIP">uint32: The IP address of the server in host order, i.e 127.0.0.1 == 0x7f000001.</param>
        /// <param name="nConnPort">uint16: The port used to connect to the server, in host order.</param>
        /// <param name="nQueryPort">uint16: The port used to query the server, in host order.</param>
        /// <param name="unFlags">uint32: 
        ///             Sets the whether the server should be added to the favorites list or history list. See
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#k_unFavoriteFlagNone" class="bb_apilink">k_unFavoriteFlagNone</a>
        ///             for more information.
        ///         </param>
        /// <param name="rTime32LastPlayedOnServer">uint32: This should be the current time in Unix epoch format (seconds since Jan 1st, 1970).</param>
        public static int AddFavoriteGame(AppId nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer) => Instance.AddFavoriteGame(nAppID, nIP, nConnPort, nQueryPort, unFlags, rTime32LastPlayedOnServer);
        /// <summary>
        /// <code>
        ///     bool RemoveFavoriteGame( AppId_t nAppID, uint32 nIP, uint16 nConnPort, uint16 nQueryPort, uint32
        ///     unFlags );
        /// </code>
        /// 
        /// <br />
        /// Removes the game server from the local favorites list.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the server was removed; otherwise, <b>false</b> if the specified
        /// server was not on the users local favorites list.
        /// </summary>
        /// <param name="nAppID">AppId_t: The App ID of the game.</param>
        /// <param name="nIP">uint32: The IP address of the server in host order, i.e 127.0.0.1 == 0x7f000001.</param>
        /// <param name="nConnPort">uint16: The port used to connect to the server, in host order.</param>
        /// <param name="nQueryPort">uint16: The port used to query the server, in host order.</param>
        /// <param name="unFlags">uint32: 
        ///             Whether the server is on the favorites list or history list. See
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#k_unFavoriteFlagNone" class="bb_apilink">k_unFavoriteFlagNone</a>
        ///             for more information.
        ///         </param>
        public static bool RemoveFavoriteGame(AppId nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags) => Instance.RemoveFavoriteGame(nAppID, nIP, nConnPort, nQueryPort, unFlags);
        /// <summary>
        /// <code>SteamAPICall_t RequestLobbyList();</code>
        /// Get a filtered list of relevant lobbies.<br />
        /// <br />
        /// There can only be one active lobby search at a time. The old request will be canceled if a new one
        /// is started. Depending on the users connection to the Steam back-end, this call can take from 300ms
        /// to 5 seconds to complete, and has a timeout of 20 seconds.<br />
        /// <br />
        /// <b>NOTE:</b> To filter the results you MUST call the
        /// <code class="bb_code bb_code_inline nohighlight">AddRequestLobbyList*</code> functions before
        /// calling this. The filters are cleared on each call to this function.<br />
        /// <br />
        /// <b>NOTE:</b> If
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#AddRequestLobbyListDistanceFilter" class="bb_apilink">ISteamMatchmaking::AddRequestLobbyListDistanceFilter</a>
        /// is not called,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#k_ELobbyDistanceFilterDefault" class="bb_apilink">k_ELobbyDistanceFilterDefault</a>
        /// will be used, which will only find matches in the same or nearby regions.<br />
        /// <br />
        /// <b>NOTE:</b> This will only return lobbies that are not full, and only lobbies that are
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#k_ELobbyTypePublic" class="bb_apilink">k_ELobbyTypePublic</a>
        /// or
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#k_ELobbyTypeInvisible" class="bb_apilink">k_ELobbyTypeInvisible</a>, and are set to joinable with
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#SetLobbyJoinable" class="bb_apilink">ISteamMatchmaking::SetLobbyJoinable</a>.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a>
        /// to be used with a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#LobbyMatchList_t" class="bb_apilink">LobbyMatchList_t</a>
        /// call result.<br />
        /// <b>NOTE:</b> This also returns as a callback for compatibility with older applications,
        /// but you should use the call result if possible.<br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#AddRequestLobbyListStringFilter" class="bb_apilink">ISteamMatchmaking::AddRequestLobbyListStringFilter</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#AddRequestLobbyListNumericalFilter" class="bb_apilink">ISteamMatchmaking::AddRequestLobbyListNumericalFilter</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#AddRequestLobbyListNearValueFilter" class="bb_apilink">ISteamMatchmaking::AddRequestLobbyListNearValueFilter</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#AddRequestLobbyListFilterSlotsAvailable" class="bb_apilink">ISteamMatchmaking::AddRequestLobbyListFilterSlotsAvailable</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#AddRequestLobbyListDistanceFilter" class="bb_apilink">ISteamMatchmaking::AddRequestLobbyListDistanceFilter</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#AddRequestLobbyListResultCountFilter" class="bb_apilink">ISteamMatchmaking::AddRequestLobbyListResultCountFilter</a><br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     class CLobbyListManager { CCallResult&lt; CLobbyListManager, LobbyMatchList_t &gt;
        ///     m_CallResultLobbyMatchList; void FindLobbies() { //
        ///     SteamMatchmaking()-&gt;AddRequestLobbyListFilter*() functions would be called here, before
        ///     RequestLobbyList() SteamAPICall_t hSteamAPICall = SteamMatchmaking()-&gt;RequestLobbyList();
        ///     m_CallResultLobbyMatchList.Set( hSteamAPICall, this, &amp;CLobbyListManager::OnLobbyMatchList );
        ///     } void OnLobbyMatchList( LobbyMatchList_t *pLobbyMatchList, bool bIOFailure ) { // lobby list
        ///     has been retrieved from Steam back-end, use results } }
        /// </code>
        /// </summary>
        /// 
        public static SteamAPICall RequestLobbyList() => Instance.RequestLobbyList();
        /// <summary>
        /// <code>
        ///     void AddRequestLobbyListStringFilter( const char *pchKeyToMatch, const char *pchValueToMatch,
        ///     ELobbyComparison eComparisonType );
        /// </code>
        /// 
        /// <br />
        /// Adds a string comparison filter to the next
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#RequestLobbyList" class="bb_apilink">ISteamMatchmaking::RequestLobbyList</a>
        /// call.
        /// </summary>
        /// <param name="pchKeyToMatch">const char *: 
        ///             The filter key name to match. This can not be longer than
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#k_nMaxLobbyKeyLength" class="bb_apilink">k_nMaxLobbyKeyLength</a>.
        ///         </param>
        /// <param name="pchValueToMatch">const char *: The string to match.</param>
        /// <param name="eComparisonType">ELobbyComparison: The type of comparison to make.</param>
        public static void AddRequestLobbyListStringFilter(UTF8StringPtr pchKeyToMatch, UTF8StringPtr pchValueToMatch, LobbyComparison eComparisonType) => Instance.AddRequestLobbyListStringFilter(pchKeyToMatch, pchValueToMatch, eComparisonType);
        /// <summary>
        /// <code>
        ///     void AddRequestLobbyListNumericalFilter( const char *pchKeyToMatch, int nValueToMatch,
        ///     ELobbyComparison eComparisonType );
        /// </code>
        /// 
        /// <br />
        /// Adds a numerical comparison filter to the next
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#RequestLobbyList" class="bb_apilink">ISteamMatchmaking::RequestLobbyList</a>
        /// call.
        /// </summary>
        /// <param name="pchKeyToMatch">const char *: 
        ///             The filter key name to match. This can not be longer than
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#k_nMaxLobbyKeyLength" class="bb_apilink">k_nMaxLobbyKeyLength</a>.
        ///         </param>
        /// <param name="nValueToMatch">int: The number to match.</param>
        /// <param name="eComparisonType">ELobbyComparison: The type of comparison to make.</param>
        public static void AddRequestLobbyListNumericalFilter(UTF8StringPtr pchKeyToMatch, int nValueToMatch, LobbyComparison eComparisonType) => Instance.AddRequestLobbyListNumericalFilter(pchKeyToMatch, nValueToMatch, eComparisonType);
        /// <summary>
        /// <code>
        ///     void AddRequestLobbyListNearValueFilter( const char *pchKeyToMatch, int nValueToBeCloseTo );
        /// </code>
        /// 
        /// <br />
        /// Sorts the results closest to the specified value.<br />
        /// <br />
        /// Near filters don't actually filter out values, they just influence how the results are sorted. You
        /// can specify multiple near filters, with the first near filter influencing the most, and the last
        /// near filter influencing the least.
        /// </summary>
        /// <param name="pchKeyToMatch">const char *: 
        ///             The filter key name to match. This can not be longer than
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#k_nMaxLobbyKeyLength" class="bb_apilink">k_nMaxLobbyKeyLength</a>.
        ///         </param>
        /// <param name="nValueToBeCloseTo">int: The value that lobbies will be sorted on.</param>
        public static void AddRequestLobbyListNearValueFilter(UTF8StringPtr pchKeyToMatch, int nValueToBeCloseTo) => Instance.AddRequestLobbyListNearValueFilter(pchKeyToMatch, nValueToBeCloseTo);
        /// <summary>
        /// <code>void AddRequestLobbyListFilterSlotsAvailable( int nSlotsAvailable );</code>
        /// 
        /// <br />
        /// Filters to only return lobbies with the specified number of open slots available.
        /// </summary>
        /// <param name="nSlotsAvailable">int: The number of open slots that must be open.</param>
        public static void AddRequestLobbyListFilterSlotsAvailable(int nSlotsAvailable) => Instance.AddRequestLobbyListFilterSlotsAvailable(nSlotsAvailable);
        /// <summary>
        /// <code>
        ///     void AddRequestLobbyListDistanceFilter( ELobbyDistanceFilter eLobbyDistanceFilter );
        /// </code>
        /// 
        /// <br />
        /// Sets the physical distance for which we should search for lobbies, this is based on the users IP
        /// address and a IP location map on the Steam backed.
        /// </summary>
        /// <param name="eLobbyDistanceFilter">ELobbyDistanceFilter: Specifies the maximum distance.</param>
        public static void AddRequestLobbyListDistanceFilter(LobbyDistanceFilter eLobbyDistanceFilter) => Instance.AddRequestLobbyListDistanceFilter(eLobbyDistanceFilter);
        /// <summary>
        /// <code>void AddRequestLobbyListResultCountFilter( int cMaxResults );</code>
        /// 
        /// <br />
        /// Sets the maximum number of lobbies to return. The lower the count the faster it is to download the
        /// lobby results &amp; details to the client.
        /// </summary>
        /// <param name="cMaxResults">int: The maximum number of lobbies to return.</param>
        public static void AddRequestLobbyListResultCountFilter(int cMaxResults) => Instance.AddRequestLobbyListResultCountFilter(cMaxResults);
        /// <summary>
        /// <code>
        ///     void AddRequestLobbyListCompatibleMembersFilter( CSteamID steamIDLobby );
        /// </code>
        /// 
        /// <br />
        /// Unused - Checks the player compatibility based on the frenemy system.
        /// </summary>
        /// <param name="steamIDLobby">CSteamID: </param>
        public static void AddRequestLobbyListCompatibleMembersFilter(SteamId steamIDLobby) => Instance.AddRequestLobbyListCompatibleMembersFilter(steamIDLobby);
        /// <summary>
        /// <code>CSteamID GetLobbyByIndex( int iLobby );</code>
        /// 
        /// <br />
        /// Gets the Steam ID of the lobby at the specified index after receiving the
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#RequestLobbyList" class="bb_apilink">ISteamMatchmaking::RequestLobbyList</a>
        /// results.<br />
        /// <br />
        /// <b>NOTE:</b> This should only be called after a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#LobbyMatchList_t" class="bb_apilink">LobbyMatchList_t</a>
        /// call result is received.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a><br />
        /// Returns
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#k_steamIDNil" class="bb_apilink">k_steamIDNil</a>
        /// if the provided index is invalid or there are no lobbies found.
        /// </summary>
        /// <param name="iLobby">int: 
        ///             The index of the lobby to get the Steam ID of, from 0 to
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#LobbyMatchList_t" class="bb_apilink">LobbyMatchList_t</a>.m_nLobbiesMatching.
        ///         </param>
        public static SteamId GetLobbyByIndex(int iLobby) => Instance.GetLobbyByIndex(iLobby);
        /// <summary>
        /// <code>SteamAPICall_t CreateLobby( ELobbyType eLobbyType, int cMaxMembers );</code>
        /// 
        /// <br />
        /// Create a new matchmaking lobby.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a>
        /// to be used with a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#LobbyCreated_t" class="bb_apilink">LobbyCreated_t</a>
        /// call result.<br />
        /// Triggers a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#LobbyEnter_t" class="bb_apilink">LobbyEnter_t</a>
        /// callback.<br />
        /// Triggers a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#LobbyDataUpdate_t" class="bb_apilink">LobbyDataUpdate_t</a>
        /// callback.<br />
        /// If the results returned via the
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#LobbyCreated_t" class="bb_apilink">LobbyCreated_t</a>
        /// call result indicate success then the lobby is joined &amp; ready to use at this point.<br />
        /// <br />
        /// The
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#LobbyEnter_t" class="bb_apilink">LobbyEnter_t</a>
        /// callback is also received since the local user has joined their own lobby.
        /// </summary>
        /// <param name="eLobbyType">ELobbyType: 
        ///             The type and visibility of this lobby. This can be changed later via
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#SetLobbyType" class="bb_apilink">ISteamMatchmaking::SetLobbyType</a>.
        ///         </param>
        /// <param name="cMaxMembers">int: The maximum number of players that can join this lobby. This can not be above 250.</param>
        public static SteamAPICall CreateLobby(LobbyType eLobbyType, int cMaxMembers) => Instance.CreateLobby(eLobbyType, cMaxMembers);
        /// <summary>
        /// <code>SteamAPICall_t JoinLobby( CSteamID steamIDLobby );</code>
        /// 
        /// <br />
        /// Joins an existing lobby.<br />
        /// <br />
        /// The lobby Steam ID can be obtained either from a search with
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#RequestLobbyList" class="bb_apilink">ISteamMatchmaking::RequestLobbyList</a>, joining on a friend, or from an invite.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a>
        /// to be used with a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#LobbyEnter_t" class="bb_apilink">LobbyEnter_t</a>
        /// call result.<br />
        /// Triggers a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#LobbyDataUpdate_t" class="bb_apilink">LobbyDataUpdate_t</a>
        /// callback.
        /// </summary>
        /// <param name="steamIDLobby">CSteamID: The Steam ID of the lobby to join.</param>
        public static SteamAPICall JoinLobby(SteamId steamIDLobby) => Instance.JoinLobby(steamIDLobby);
        /// <summary>
        /// <code>void LeaveLobby( CSteamID steamIDLobby );</code>
        /// 
        /// <br />
        /// Leave a lobby that the user is currently in; this will take effect immediately on the client side,
        /// other users in the lobby will be notified by a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#LobbyChatUpdate_t" class="bb_apilink">LobbyChatUpdate_t</a>
        /// callback.
        /// </summary>
        /// <param name="steamIDLobby">CSteamID: The lobby to leave.</param>
        public static void LeaveLobby(SteamId steamIDLobby) => Instance.LeaveLobby(steamIDLobby);
        /// <summary>
        /// <code>
        ///     bool InviteUserToLobby( CSteamID steamIDLobby, CSteamID steamIDInvitee );
        /// </code>
        /// 
        /// <br />
        /// Invite another user to the lobby.<br />
        /// <br />
        /// If the specified user clicks the join link, a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GameLobbyJoinRequested_t" class="bb_apilink">GameLobbyJoinRequested_t</a>
        /// callback will be posted if the user is in-game,<br />
        /// or if the game isn't running yet then the game will be automatically launched with the command line
        /// parameter
        /// <code class="bb_code bb_code_inline nohighlight">+connect_lobby &lt;64-bit lobby Steam ID&gt;</code>
        /// instead.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the invite was successfully sent; otherwise, <b>false</b> if the
        /// local user isn't in a lobby, no connection to Steam could be made, or the specified user is
        /// invalid.<br />
        /// <br />
        /// <b>NOTE:</b> This call doesn't check if the other user was successfully invited.
        /// </summary>
        /// <param name="steamIDLobby">CSteamID: The Steam ID of the lobby to invite the user to.</param>
        /// <param name="steamIDInvitee">CSteamID: The Steam ID of the person who will be invited.</param>
        public static bool InviteUserToLobby(SteamId steamIDLobby, SteamId steamIDInvitee) => Instance.InviteUserToLobby(steamIDLobby, steamIDInvitee);
        /// <summary>
        /// <code>int GetNumLobbyMembers( CSteamID steamIDLobby );</code>
        /// 
        /// <br />
        /// Gets the number of users in a lobby.<br />
        /// <br />
        /// <b>NOTE:</b> The current user must be in the lobby to retrieve the Steam IDs of other
        /// users in that lobby.<br />
        /// <br />
        /// This is used for iteration, after calling this then
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#GetLobbyMemberByIndex" class="bb_apilink">ISteamMatchmaking::GetLobbyMemberByIndex</a>
        /// can be used to get the Steam ID of each person in the lobby. Persona information for other lobby
        /// members (name, avatar, etc.) is automatically received and accessible via the
        /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends" class="bb_apilink">ISteamFriends</a>
        /// interface.<br />
        /// <br />
        /// <b>Returns:</b> int<br />
        /// The number of members in the lobby, <b>0</b> if the current user has no data from the
        /// lobby.
        /// </summary>
        /// <param name="steamIDLobby">CSteamID: The Steam ID of the lobby to get the number of members of.</param>
        public static int GetNumLobbyMembers(SteamId steamIDLobby) => Instance.GetNumLobbyMembers(steamIDLobby);
        /// <summary>
        /// <code>CSteamID GetLobbyMemberByIndex( CSteamID steamIDLobby, int iMember );</code>
        /// 
        /// <br />
        /// Gets the Steam ID of the lobby member at the given index.<br />
        /// <br />
        /// <b>NOTE:</b> You must call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#GetNumLobbyMembers" class="bb_apilink">ISteamMatchmaking::GetNumLobbyMembers</a>
        /// before calling this.<br />
        /// <br />
        /// <b>NOTE:</b> The current user must be in the lobby to retrieve the Steam IDs of other
        /// users in that lobby.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a><br />
        /// Invalid indices return
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#k_steamIDNil" class="bb_apilink">k_steamIDNil</a>.
        /// </summary>
        /// <param name="steamIDLobby">CSteamID: 
        ///             This MUST be the same lobby used in the previous call to
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#GetNumLobbyMembers" class="bb_apilink">ISteamMatchmaking::GetNumLobbyMembers</a>!
        ///         </param>
        /// <param name="iMember">int: 
        ///             An index between 0 and
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#GetNumLobbyMembers" class="bb_apilink">ISteamMatchmaking::GetNumLobbyMembers</a>.
        ///         </param>
        public static SteamId GetLobbyMemberByIndex(SteamId steamIDLobby, int iMember) => Instance.GetLobbyMemberByIndex(steamIDLobby, iMember);
        /// <summary>
        /// <code>
        ///     const char * GetLobbyData( CSteamID steamIDLobby, const char *pchKey );
        /// </code>
        /// 
        /// <br />
        /// Gets the metadata associated with the specified key from the specified lobby.<br />
        /// <br />
        /// <b>NOTE:</b> This can only get metadata from lobbies that the client knows about, either
        /// after receiving a list of lobbies from
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#LobbyMatchList_t" class="bb_apilink">LobbyMatchList_t</a>, retrieving the data with
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#RequestLobbyData" class="bb_apilink">ISteamMatchmaking::RequestLobbyData</a>
        /// or after joining a lobby.<br />
        /// <br />
        /// <b>Returns:</b> const char *<br />
        /// Returns an empty string ("") if no value is set for this key, or if
        /// <code class="bb_code bb_code_inline nohighlight">steamIDLobby</code> is invalid.
        /// </summary>
        /// <param name="steamIDLobby">CSteamID: The Steam ID of the lobby to get the metadata from.</param>
        /// <param name="pchKey">const char *: The key to get the value of.</param>
        public static UTF8StringPtr GetLobbyData(SteamId steamIDLobby, UTF8StringPtr pchKey) => Instance.GetLobbyData(steamIDLobby, pchKey);
        /// <summary>
        /// <code>
        ///     bool SetLobbyData( CSteamID steamIDLobby, const char *pchKey, const char *pchValue );
        /// </code>
        /// 
        /// <br />
        /// Sets a key/value pair in the lobby metadata. This can be used to set the the lobby name, current
        /// map, game mode, etc.<br />
        /// <br />
        /// This can only be set by the owner of the lobby. Lobby members should use
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#SetLobbyMemberData" class="bb_apilink">ISteamMatchmaking::SetLobbyMemberData</a>
        /// instead.<br />
        /// <br />
        /// Each user in the lobby will be receive notification of the lobby data change via a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#LobbyDataUpdate_t" class="bb_apilink">LobbyDataUpdate_t</a>
        /// callback, and any new users joining will receive any existing data.<br />
        /// <br />
        /// This will only send the data if it has changed. There is a slight delay before sending the data so
        /// you can call this repeatedly to set all the data you need to and it will automatically be batched up
        /// and sent after the last sequential call.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the data has been set successfully. <b>false</b> if
        /// <code class="bb_code bb_code_inline nohighlight">steamIDLobby</code> was invalid, or the key/value
        /// are too long.
        /// </summary>
        /// <param name="steamIDLobby">CSteamID: The Steam ID of the lobby to set the metadata for.</param>
        /// <param name="pchKey">const char *: 
        ///             The key to set the data for. This can not be longer than
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#k_nMaxLobbyKeyLength" class="bb_apilink">k_nMaxLobbyKeyLength</a>.
        ///         </param>
        /// <param name="pchValue">const char *: 
        ///             The value to set. This can not be longer than
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamFriends#k_cubChatMetadataMax" class="bb_apilink">k_cubChatMetadataMax</a>.
        ///         </param>
        public static bool SetLobbyData(SteamId steamIDLobby, UTF8StringPtr pchKey, UTF8StringPtr pchValue) => Instance.SetLobbyData(steamIDLobby, pchKey, pchValue);
        /// <summary>
        /// <code>int GetLobbyDataCount( CSteamID steamIDLobby );</code>
        /// 
        /// <br />
        /// Gets the number of metadata keys set on the specified lobby.<br />
        /// <br />
        /// <b>NOTE:</b> This can only get metadata from lobbies that the client knows about, either
        /// after receiving a list of lobbies from
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#LobbyMatchList_t" class="bb_apilink">LobbyMatchList_t</a>, retrieving the data with
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#RequestLobbyData" class="bb_apilink">ISteamMatchmaking::RequestLobbyData</a>
        /// or after joining a lobby.<br />
        /// <br />
        /// This is used for iteration, after calling this then
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#GetLobbyDataByIndex" class="bb_apilink">ISteamMatchmaking::GetLobbyDataByIndex</a>
        /// can be used to get the key/value pair of each piece of metadata.<br />
        /// <br />
        /// <b>NOTE:</b> This should typically only ever be used for debugging purposes.<br />
        /// <br />
        /// <b>Returns:</b> int<br />
        /// Returns <b>0</b> if
        /// <code class="bb_code bb_code_inline nohighlight">steamIDLobby</code> is invalid.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     void ListLobbyData( CSteamID lobbyID ) { int nData = SteamMatchmaking()-&gt;GetLobbyDataCount(
        ///     lobbyID ); char key[k_nMaxLobbyKeyLength]; char value[k_cubChatMetadataMax]; for( int i = 0; i
        ///     &lt; nData; ++i ) { bool bSuccess = SteamMatchmaking()-&gt;GetLobbyDataByIndex( lobbyID, i, key,
        ///     k_nMaxLobbyKeyLength, value, k_cubChatMetadataMax ); if ( bSuccess ) { printf( "Lobby Data %d,
        ///     Key: \"%s\" - Value: \"%s\"\n", i, key, value ); } } }
        /// </code>
        /// </summary>
        /// <param name="steamIDLobby">CSteamID: The Steam ID of the lobby to get the data count from.</param>
        public static int GetLobbyDataCount(SteamId steamIDLobby) => Instance.GetLobbyDataCount(steamIDLobby);
        /// <summary>
        /// <code>
        ///     bool GetLobbyDataByIndex( CSteamID steamIDLobby, int iLobbyData, char *pchKey, int
        ///     cchKeyBufferSize, char *pchValue, int cchValueBufferSize );
        /// </code>
        /// 
        /// <br />
        /// Gets a lobby metadata key/value pair by index.<br />
        /// <br />
        /// <b>NOTE:</b> You must call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#GetLobbyDataCount" class="bb_apilink">ISteamMatchmaking::GetLobbyDataCount</a>
        /// before calling this.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success; otherwise, <b>false</b> if the
        /// <code class="bb_code bb_code_inline nohighlight">steamIDLobby</code> or
        /// <code class="bb_code bb_code_inline nohighlight">iLobbyData</code> are invalid.
        /// </summary>
        /// <param name="steamIDLobby">CSteamID: 
        ///             This MUST be the same lobby used in the previous call to
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#GetLobbyDataCount" class="bb_apilink">ISteamMatchmaking::GetLobbyDataCount</a>!
        ///         </param>
        /// <param name="iLobbyData">int: 
        ///             An index between 0 and
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#GetLobbyDataCount" class="bb_apilink">ISteamMatchmaking::GetLobbyDataCount</a>.
        ///         </param>
        /// <param name="pchKey">char *: Returns the name of the key at the specified index by copying it into this buffer.</param>
        /// <param name="cchKeyBufferSize">int: 
        ///             The size of the buffer allocated for
        ///             <code class="bb_code bb_code_inline nohighlight">pchKey</code>. This typically should be
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#k_nMaxLobbyKeyLength" class="bb_apilink">k_nMaxLobbyKeyLength</a>.
        ///         </param>
        /// <param name="pchValue">char *: 
        ///             Returns the value associated with the key at the specified index by copying it into this
        ///             buffer.
        ///         </param>
        /// <param name="cchValueBufferSize">int: 
        ///             The size of the buffer allocated for
        ///             <code class="bb_code bb_code_inline nohighlight">pchValue</code>. This typically should
        ///             be
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamFriends#k_cubChatMetadataMax" class="bb_apilink">k_cubChatMetadataMax</a>.
        ///         </param>
        public static bool GetLobbyDataByIndex(SteamId steamIDLobby, int iLobbyData, char* pchKey, int cchKeyBufferSize, char* pchValue, int cchValueBufferSize) => Instance.GetLobbyDataByIndex(steamIDLobby, iLobbyData, pchKey, cchKeyBufferSize, pchValue, cchValueBufferSize);
        /// <summary>
        /// <code>bool DeleteLobbyData( CSteamID steamIDLobby, const char *pchKey );</code>
        /// 
        /// <br />
        /// Removes a metadata key from the lobby.<br />
        /// <br />
        /// This can only be done by the owner of the lobby.<br />
        /// <br />
        /// This will only send the data if the key existed. There is a slight delay before sending the data so
        /// you can call this repeatedly to set all the data you need to and it will automatically be batched up
        /// and sent after the last sequential call.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the key/value was successfully deleted; otherwise,
        /// <b>false</b> if <code class="bb_code bb_code_inline nohighlight">steamIDLobby</code> or
        /// <code class="bb_code bb_code_inline nohighlight">pchKey</code> are invalid.
        /// </summary>
        /// <param name="steamIDLobby">CSteamID: The Steam ID of the lobby to delete the metadata for.</param>
        /// <param name="pchKey">const char *: The key to delete the data for.</param>
        public static bool DeleteLobbyData(SteamId steamIDLobby, UTF8StringPtr pchKey) => Instance.DeleteLobbyData(steamIDLobby, pchKey);
        /// <summary>
        /// <code>
        ///     const char * GetLobbyMemberData( CSteamID steamIDLobby, CSteamID steamIDUser, const char *pchKey
        ///     );
        /// </code>
        /// 
        /// <br />
        /// Gets per-user metadata from another player in the specified lobby.<br />
        /// <br />
        /// This can only be queried from members in lobbies that you are currently in.<br />
        /// <br />
        /// <b>Returns:</b> const char *<br />
        /// Returns <b>NULL</b> if
        /// <code class="bb_code bb_code_inline nohighlight">steamIDLobby</code> is invalid, or
        /// <code class="bb_code bb_code_inline nohighlight">steamIDUser</code> is not in the lobby.<br />
        /// <br />
        /// Returns an empty string ("") if <code class="bb_code bb_code_inline nohighlight">pchKey</code> is
        /// not set for the player.<br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#SetLobbyMemberData" class="bb_apilink">ISteamMatchmaking::SetLobbyMemberData</a>
        /// </summary>
        /// <param name="steamIDLobby">CSteamID: The Steam ID of the lobby that the other player is in.</param>
        /// <param name="steamIDUser">CSteamID: The Steam ID of the player to get the metadata from.</param>
        /// <param name="pchKey">const char *: The key to get the value of.</param>
        public static UTF8StringPtr GetLobbyMemberData(SteamId steamIDLobby, SteamId steamIDUser, UTF8StringPtr pchKey) => Instance.GetLobbyMemberData(steamIDLobby, steamIDUser, pchKey);
        /// <summary>
        /// <code>
        ///     void SetLobbyMemberData( CSteamID steamIDLobby, const char *pchKey, const char *pchValue );
        /// </code>
        /// 
        /// <br />
        /// Sets per-user metadata for the local user.<br />
        /// <br />
        /// Each user in the lobby will be receive notification of the lobby data change via a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#LobbyDataUpdate_t" class="bb_apilink">LobbyDataUpdate_t</a>
        /// callback, and any new users joining will receive any existing data.<br />
        /// <br />
        /// There is a slight delay before sending the data so you can call this repeatedly to set all the data
        /// you need to and it will automatically be batched up and sent after the last sequential call.<br />
        /// <br />
        /// <b>Returns:</b> void<br />
        /// Triggers a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#LobbyDataUpdate_t" class="bb_apilink">LobbyDataUpdate_t</a>
        /// callback.<br />
        /// <br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#GetLobbyMemberData" class="bb_apilink">ISteamMatchmaking::GetLobbyMemberData</a>
        /// </summary>
        /// <param name="steamIDLobby">CSteamID: The Steam ID of the lobby to set our metadata in.</param>
        /// <param name="pchKey">const char *: 
        ///             The key to set the data for. This can not be longer than
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#k_nMaxLobbyKeyLength" class="bb_apilink">k_nMaxLobbyKeyLength</a>.
        ///         </param>
        /// <param name="pchValue">const char *: 
        ///             The value to set. This can not be longer than
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamFriends#k_cubChatMetadataMax" class="bb_apilink">k_cubChatMetadataMax</a>.
        ///         </param>
        public static void SetLobbyMemberData(SteamId steamIDLobby, UTF8StringPtr pchKey, UTF8StringPtr pchValue) => Instance.SetLobbyMemberData(steamIDLobby, pchKey, pchValue);
        /// <summary>
        /// <code>
        ///     bool SendLobbyChatMsg( CSteamID steamIDLobby, const void *pvMsgBody, int cubMsgBody );
        /// </code>
        /// 
        /// <br />
        /// Broadcasts a chat (text or binary data) message to the all of the users in the lobby.<br />
        /// <br />
        /// All users in the lobby (including the local user) will receive a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#LobbyChatMsg_t" class="bb_apilink">LobbyChatMsg_t</a>
        /// callback with the message.<br />
        /// <br />
        /// If you're sending binary data, you should prefix a header to the message so that you know to treat
        /// it as your custom data rather than a plain old text message.<br />
        /// <br />
        /// For communication that needs to be arbitrated (for example having a user pick from a set of
        /// characters, and making sure only one user has picked a character), you can use the lobby owner as
        /// the decision maker.
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#GetLobbyOwner" class="bb_apilink">ISteamMatchmaking::GetLobbyOwner</a>
        /// returns the current lobby owner. There is guaranteed to always be one and only one lobby member who
        /// is the owner. So for the choose-a-character scenario, the user who is picking a character would send
        /// the binary message 'I want to be Zoe', the lobby owner would see that message, see if it was OK, and
        /// broadcast the appropriate result (user X is Zoe).<br />
        /// <br />
        /// These messages are sent via the Steam back-end, and so the bandwidth available is limited. For
        /// higher-volume traffic like voice or game data, you'll want to use the
        /// <a href="https://partner.steamgames.com/doc/features/multiplayer/networking" class="bb_doclink">Steam Networking API</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// Triggers a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#LobbyChatMsg_t" class="bb_apilink">LobbyChatMsg_t</a>
        /// callback.<br />
        /// <b>true</b> if the message was successfully sent. <b>false</b> if the message is
        /// too small or too large, or no connection to Steam could be made.
        /// </summary>
        /// <param name="steamIDLobby">CSteamID: The Steam ID of the lobby to send the chat message to.</param>
        /// <param name="pvMsgBody">const void *: This can be text or binary data, up to 4 Kilobytes in size.</param>
        /// <param name="cubMsgBody">int: 
        ///             The size in bytes of <code class="bb_code bb_code_inline nohighlight">pvMsgBody</code>,
        ///             if it's a text message then this should be strlen( text ) + 1 to include the null
        ///             terminator.
        ///         </param>
        public static bool SendLobbyChatMsg(SteamId steamIDLobby, void* pvMsgBody, int cubMsgBody) => Instance.SendLobbyChatMsg(steamIDLobby, pvMsgBody, cubMsgBody);
        /// <summary>
        /// <code>
        ///     int GetLobbyChatEntry( CSteamID steamIDLobby, int iChatID, CSteamID *pSteamIDUser, void *pvData,
        ///     int cubData, EChatEntryType *peChatEntryType );
        /// </code>
        /// 
        /// <br />
        /// Gets the data from a lobby chat message after receiving a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#LobbyChatMsg_t" class="bb_apilink">LobbyChatMsg_t</a>
        /// callback.<br />
        /// <br />
        /// <b>Returns:</b> int<br />
        /// The number of bytes copied into
        /// <code class="bb_code bb_code_inline nohighlight">pvData</code>.<br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#SendLobbyChatMsg" class="bb_apilink">ISteamMatchmaking::SendLobbyChatMsg</a>
        /// </summary>
        /// <param name="steamIDLobby">CSteamID: 
        ///             The Steam ID of the lobby to get the chat entry from. This should almost always be
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#LobbyChatMsg_t" class="bb_apilink">LobbyChatMsg_t</a>::<code class="bb_code bb_code_inline nohighlight">m_ulSteamIDUser</code>.
        ///         </param>
        /// <param name="iChatID">int: 
        ///             The index of the chat entry in the lobby. This should almost always be
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#LobbyChatMsg_t" class="bb_apilink">LobbyChatMsg_t</a>::<code class="bb_code bb_code_inline nohighlight">m_iChatID</code>.
        ///         </param>
        /// <param name="pSteamIDUser">CSteamID
        ///             *: 
        ///             If set then this returns the Steam ID of the user who sent this message. Usually
        ///             unneeded since it will be the same as
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#LobbyChatMsg_t" class="bb_apilink">LobbyChatMsg_t</a>::<code class="bb_code bb_code_inline nohighlight">m_ulSteamIDUser</code>.
        ///         </param>
        /// <param name="pvData">void *: 
        ///             Returns the message data by copying it into this buffer. This buffer should be up to 4
        ///             Kilobytes.
        ///         </param>
        /// <param name="cubData">int: 
        ///             The size of the buffer allocated for
        ///             <code class="bb_code bb_code_inline nohighlight">pvData</code>.
        ///         </param>
        /// <param name="peChatEntryType">EChatEntryType
        ///             *: 
        ///             If set then this will just always return
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#k_EChatEntryTypeChatMsg" class="bb_apilink">k_EChatEntryTypeChatMsg</a>. This can usually just be set to <b>NULL</b>.
        ///         </param>
        public static int GetLobbyChatEntry(SteamId steamIDLobby, int iChatID, SteamId* pSteamIDUser, void* pvData, int cubData, ChatEntryType* peChatEntryType) => Instance.GetLobbyChatEntry(steamIDLobby, iChatID, pSteamIDUser, pvData, cubData, peChatEntryType);
        /// <summary>
        /// <code>bool RequestLobbyData( CSteamID steamIDLobby );</code>
        /// 
        /// <br />
        /// Refreshes all of the metadata for a lobby that you're not in right now.<br />
        /// <br />
        /// You will never do this for lobbies you're a member of, that data will always be up to date. You can
        /// use this to refresh lobbies that you have obtained from
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#RequestLobbyList" class="bb_apilink">ISteamMatchmaking::RequestLobbyList</a>
        /// or that are available via friends.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// Triggers a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#LobbyDataUpdate_t" class="bb_apilink">LobbyDataUpdate_t</a>
        /// callback.<br />
        /// <b>true</b> if the request was successfully sent to the server. <b>false</b> if
        /// no connection to Steam could be made, or
        /// <code class="bb_code bb_code_inline nohighlight">steamIDLobby</code> is invalid.<br />
        /// <br />
        /// If the specified lobby doesn't exist,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#LobbyDataUpdate_t" class="bb_apilink">LobbyDataUpdate_t</a>::<code class="bb_code bb_code_inline nohighlight">m_bSuccess</code> will be set to
        /// <b>false</b>.
        /// </summary>
        /// <param name="steamIDLobby">CSteamID: The Steam ID of the lobby to refresh the metadata of.</param>
        public static bool RequestLobbyData(SteamId steamIDLobby) => Instance.RequestLobbyData(steamIDLobby);
        /// <summary>
        /// <code>
        ///     void SetLobbyGameServer( CSteamID steamIDLobby, uint32 unGameServerIP, uint16 unGameServerPort,
        ///     CSteamID steamIDGameServer );
        /// </code>
        /// 
        /// <br />
        /// Sets the game server associated with the lobby.<br />
        /// <br />
        /// This can only be set by the owner of the lobby.<br />
        /// <br />
        /// Either the IP/Port or the Steam ID of the game server must be valid, depending on how you want the
        /// clients to be able to connect.<br />
        /// <br />
        /// A
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#LobbyGameCreated_t" class="bb_apilink">LobbyGameCreated_t</a>
        /// callback will be sent to all players in the lobby, usually at this point, the users will join the
        /// specified game server.<br />
        /// <br />
        /// <b>Returns:</b> void<br />
        /// Triggers a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#LobbyGameCreated_t" class="bb_apilink">LobbyGameCreated_t</a>
        /// callback.<br />
        /// <br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#GetLobbyGameServer" class="bb_apilink">ISteamMatchmaking::GetLobbyGameServer</a>
        /// </summary>
        /// <param name="steamIDLobby">CSteamID: The Steam ID of the lobby to set the game server information for.</param>
        /// <param name="unGameServerIP">uint32: Sets the IP address of the game server, in host order, i.e 127.0.0.1 == 0x7f000001.</param>
        /// <param name="unGameServerPort">uint16: Sets the connection port of the game server, in host order.</param>
        /// <param name="steamIDGameServer">CSteamID: 
        ///             Sets the Steam ID of the game server. Use
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#k_steamIDNil" class="bb_apilink">k_steamIDNil</a>
        ///             if you're not setting this.
        ///         </param>
        public static void SetLobbyGameServer(SteamId steamIDLobby, uint unGameServerIP, ushort unGameServerPort, SteamId steamIDGameServer) => Instance.SetLobbyGameServer(steamIDLobby, unGameServerIP, unGameServerPort, steamIDGameServer);
        /// <summary>
        /// <code>
        ///     bool GetLobbyGameServer( CSteamID steamIDLobby, uint32 *punGameServerIP, uint16
        ///     *punGameServerPort, CSteamID *psteamIDGameServer );
        /// </code>
        /// 
        /// <br />
        /// Gets the details of a game server set in a lobby.<br />
        /// <br />
        /// Either the IP/Port or the Steam ID of the game server has to be valid, depending on how you want the
        /// clients to be able to connect.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the lobby is valid and has a valid game server set; otherwise,
        /// <b>false</b>.<br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#SetLobbyGameServer" class="bb_apilink">ISteamMatchmaking::SetLobbyGameServer</a>
        /// </summary>
        /// <param name="steamIDLobby">CSteamID: The Steam ID of the lobby to get the game server information from.</param>
        /// <param name="punGameServerIP">uint32
        ///             *: 
        ///             Returns the IP address of the game server, in host order, i.e 127.0.0.1 == 0x7f000001,
        ///             if it's set.
        ///         </param>
        /// <param name="punGameServerPort">uint16
        ///             *: Returns the connection port of the game server, in host order, if it's set.</param>
        /// <param name="psteamIDGameServer">CSteamID
        ///             *: Returns the Steam ID of the game server, if it's set.</param>
        public static bool GetLobbyGameServer(SteamId steamIDLobby, uint* punGameServerIP, ushort* punGameServerPort, SteamId* psteamIDGameServer) => Instance.GetLobbyGameServer(steamIDLobby, punGameServerIP, punGameServerPort, psteamIDGameServer);
        /// <summary>
        /// <code>bool SetLobbyMemberLimit( CSteamID steamIDLobby, int cMaxMembers );</code>
        /// 
        /// <br />
        /// Set the maximum number of players that can join the lobby.<br />
        /// <br />
        /// This is also set when you create the lobby with
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#CreateLobby" class="bb_apilink">ISteamMatchmaking::CreateLobby</a>.<br />
        /// This can only be set by the owner of the lobby.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the limit was successfully set.<br />
        /// <b>false</b> if you are not the owner of the specified lobby.
        /// </summary>
        /// <param name="steamIDLobby">CSteamID: The Steam ID of the lobby to set the member limit for.</param>
        /// <param name="cMaxMembers">int: The maximum number of players allowed in this lobby. This can not be above 250.</param>
        public static bool SetLobbyMemberLimit(SteamId steamIDLobby, int cMaxMembers) => Instance.SetLobbyMemberLimit(steamIDLobby, cMaxMembers);
        /// <summary>
        /// <code>int GetLobbyMemberLimit( CSteamID steamIDLobby );</code>
        /// 
        /// <br />
        /// The current limit on the # of users who can join the lobby.<br />
        /// Returns <b>0</b> if no limit is defined.<br />
        /// <br />
        /// <b>Returns:</b> int<br />
        /// Returns <b>0</b> if no metadata is available for the specified lobby.
        /// </summary>
        /// <param name="steamIDLobby">CSteamID: The Steam ID of the lobby to get the member limit of.</param>
        public static int GetLobbyMemberLimit(SteamId steamIDLobby) => Instance.GetLobbyMemberLimit(steamIDLobby);
        /// <summary>
        /// <code>bool SetLobbyType( CSteamID steamIDLobby, ELobbyType eLobbyType );</code>
        /// 
        /// <br />
        /// Updates what type of lobby this is.<br />
        /// <br />
        /// This is also set when you create the lobby with
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#CreateLobby" class="bb_apilink">ISteamMatchmaking::CreateLobby</a>.<br />
        /// This can only be set by the owner of the lobby.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success; otherwise, <b>false</b> if you're not the owner of the
        /// lobby.
        /// </summary>
        /// <param name="steamIDLobby">CSteamID: The Steam ID of the lobby to set the type of.</param>
        /// <param name="eLobbyType">ELobbyType: The new lobby type to that will be set.</param>
        public static bool SetLobbyType(SteamId steamIDLobby, LobbyType eLobbyType) => Instance.SetLobbyType(steamIDLobby, eLobbyType);
        /// <summary>
        /// <code>bool SetLobbyJoinable( CSteamID steamIDLobby, bool bLobbyJoinable );</code>
        /// 
        /// <br />
        /// Sets whether or not a lobby is joinable by other players. This always defaults to enabled for a new
        /// lobby.<br />
        /// <br />
        /// If joining is disabled, then no players can join, even if they are a friend or have been invited.<br />
        /// <br />
        /// Lobbies with joining disabled will not be returned from a lobby search.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success; otherwise, <b>false</b> if you're not the owner of the
        /// lobby.
        /// </summary>
        /// <param name="steamIDLobby">CSteamID: The Steam ID of the lobby</param>
        /// <param name="bLobbyJoinable">bool: 
        ///             Enable (<b>true</b>) or disable (<b>false</b>) allowing users to
        ///             join this lobby?
        ///         </param>
        public static bool SetLobbyJoinable(SteamId steamIDLobby, bool bLobbyJoinable) => Instance.SetLobbyJoinable(steamIDLobby, bLobbyJoinable);
        /// <summary>
        /// <code>CSteamID GetLobbyOwner( CSteamID steamIDLobby );</code>
        /// 
        /// <br />
        /// Returns the current lobby owner.<br />
        /// <br />
        /// <b>NOTE:</b> You must be a member of the lobby to access this.<br />
        /// <br />
        /// There always one lobby owner - if the current owner leaves, another user in the lobby will become
        /// the owner automatically. It is possible (but rare) to join a lobby just as the owner is leaving,
        /// thus entering a lobby with self as the owner.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a><br />
        /// Returns
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#k_steamIDNil" class="bb_apilink">k_steamIDNil</a>
        /// if you're not in the lobby.<br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#SetLobbyOwner" class="bb_apilink">ISteamMatchmaking::SetLobbyOwner</a>
        /// </summary>
        /// <param name="steamIDLobby">CSteamID: The Steam ID of the lobby to get the owner of.</param>
        public static SteamId GetLobbyOwner(SteamId steamIDLobby) => Instance.GetLobbyOwner(steamIDLobby);
        /// <summary>
        /// <code>
        ///     bool SetLobbyOwner( CSteamID steamIDLobby, CSteamID steamIDNewOwner );
        /// </code>
        /// 
        /// <br />
        /// Changes who the lobby owner is.<br />
        /// <br />
        /// This can only be set by the owner of the lobby. This will trigger a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#LobbyDataUpdate_t" class="bb_apilink">LobbyDataUpdate_t</a>
        /// for all of the users in the lobby, each user should update their local state to reflect the new
        /// owner. This is typically accomplished by displaying a crown icon next to the owners name.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// Triggers a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#LobbyDataUpdate_t" class="bb_apilink">LobbyDataUpdate_t</a>
        /// callback.<br />
        /// <b>true</b> if the owner was successfully changed.<br />
        /// <b>false</b> if you're not the current owner of the lobby,
        /// <code class="bb_code bb_code_inline nohighlight">steamIDNewOwner</code> is not a member in the
        /// lobby, or if no connection to Steam could be made.<br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#GetLobbyOwner" class="bb_apilink">ISteamMatchmaking::GetLobbyOwner</a>
        /// </summary>
        /// <param name="steamIDLobby">CSteamID: The Steam ID of the lobby where the owner change will take place.</param>
        /// <param name="steamIDNewOwner">CSteamID: 
        ///             The Steam ID of the user that will be the new owner of the lobby, they must be in the
        ///             lobby.
        ///         </param>
        public static bool SetLobbyOwner(SteamId steamIDLobby, SteamId steamIDNewOwner) => Instance.SetLobbyOwner(steamIDLobby, steamIDNewOwner);
        /// <summary>
        /// <code>
        ///     bool SetLinkedLobby( CSteamID steamIDLobby, CSteamID steamIDLobbyDependent );
        /// </code>
        /// 
        /// <br />
        /// Unused - Link two lobbies for the purposes of checking player compatibility using the frenemy
        /// system.<br />
        /// <br />
        /// You must be the lobby owner of both lobbies.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the request was successfully sent to the Steam server.<br />
        /// <b>false</b> if the local user isn't the owner of both lobbies, or no connection to Steam
        /// could be made.
        /// </summary>
        /// <param name="steamIDLobby">CSteamID: The Steam ID of the primary lobby.</param>
        /// <param name="steamIDLobbyDependent">CSteamID: The Steam ID that will be linked to the primary lobby.</param>
        public static bool SetLinkedLobby(SteamId steamIDLobby, SteamId steamIDLobbyDependent) => Instance.SetLinkedLobby(steamIDLobby, steamIDLobbyDependent);
    }
}