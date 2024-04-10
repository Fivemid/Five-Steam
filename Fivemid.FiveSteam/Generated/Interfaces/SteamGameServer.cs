using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamGameServer
    {
        public static ISteamGameServer.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamGameServer_v015", CallingConvention = Platform.CC)]
        private static extern ISteamGameServer.Instance Accessor();
        /// <summary>
        /// <code>void SetProduct( const char *pszProduct );</code>
        /// 
        /// <br />
        /// Sets the game product identifier. This is currently used by the master server for version checking
        /// purposes.<br />
        /// <br />
        /// Converting the games app ID to a string for this is recommended.<br />
        /// <br />
        /// <b>NOTE:</b> This is required for all game servers and can only be set before calling
        /// <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#LogOn" class="bb_apilink">ISteamGameServer::LogOn</a>
        /// or
        /// <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#LogOnAnonymous" class="bb_apilink">ISteamGameServer::LogOnAnonymous</a>.
        /// </summary>
        /// <param name="pszProduct">const char *: 
        ///             The unique identifier for your game. Must not be <b>NULL</b> or an empty
        ///             string ("").
        ///         </param>
        public static void SetProduct(UTF8StringPtr pszProduct) => Instance.SetProduct(pszProduct);
        /// <summary>
        /// <code>void SetGameDescription( const char *pszGameDescription );</code>
        /// 
        /// <br />
        /// Sets the game description. Setting this to the full name of your game is recommended.<br />
        /// <br />
        /// <b>NOTE:</b> This is required for all game servers and can only be set before calling
        /// <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#LogOn" class="bb_apilink">ISteamGameServer::LogOn</a>
        /// or
        /// <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#LogOnAnonymous" class="bb_apilink">ISteamGameServer::LogOnAnonymous</a>.
        /// </summary>
        /// <param name="pszGameDescription">const char *: 
        ///             The description of your game. Must not be <b>NULL</b> or an empty string ("").
        ///             This can not be longer than
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamMatchmakingServers#k_cbMaxGameServerGameDescription" class="bb_apilink">k_cbMaxGameServerGameDescription</a>.
        ///         </param>
        public static void SetGameDescription(UTF8StringPtr pszGameDescription) => Instance.SetGameDescription(pszGameDescription);
        /// <summary>
        /// <code>void SetModDir( const char *pszModDir );</code>
        /// 
        /// <br />
        /// Sets the game directory.<br />
        /// <br />
        /// This should be the same directory game where gets installed into. Just the folder name, not the
        /// whole path. e.g. "Spacewar".<br />
        /// <br />
        /// <b>NOTE:</b> This is required for all game servers and can only be set before calling
        /// <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#LogOn" class="bb_apilink">ISteamGameServer::LogOn</a>
        /// or
        /// <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#LogOnAnonymous" class="bb_apilink">ISteamGameServer::LogOnAnonymous</a>.
        /// </summary>
        /// <param name="pszModDir">const char *: 
        ///             The game directory to set. Must not be <b>NULL</b> or an empty string ("").
        ///             This can not be longer than
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamMatchmakingServers#k_cbMaxGameServerGameDir" class="bb_apilink">k_cbMaxGameServerGameDir</a>.
        ///         </param>
        public static void SetModDir(UTF8StringPtr pszModDir) => Instance.SetModDir(pszModDir);
        /// <summary>
        /// <code>void SetDedicatedServer( bool bDedicated );</code>
        /// 
        /// <br />
        /// Sets the whether this is a dedicated server or a listen server. The default is listen server.<br />
        /// <br />
        /// <b>NOTE:</b> This only be set before calling
        /// <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#LogOn" class="bb_apilink">ISteamGameServer::LogOn</a>
        /// or
        /// <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#LogOnAnonymous" class="bb_apilink">ISteamGameServer::LogOnAnonymous</a>.
        /// </summary>
        /// <param name="bDedicated">bool: 
        ///             Is this a dedicated server (<b>true</b>) or a listen server
        ///             (<b>false</b>)?
        ///         </param>
        public static void SetDedicatedServer(bool bDedicated) => Instance.SetDedicatedServer(bDedicated);
        /// <summary>
        /// <code>void LogOn( const char *pszToken );</code>
        /// 
        /// <br />
        /// Begin process to login to a persistent game server account.<br />
        /// <br />
        /// <b>Returns:</b> void<br />
        /// Triggers a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#SteamServerConnectFailure_t" class="bb_apilink">SteamServerConnectFailure_t</a>
        /// callback.<br />
        /// Triggers a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#SteamServersConnected_t" class="bb_apilink">SteamServersConnected_t</a>
        /// callback.<br />
        /// Triggers a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#SteamServersDisconnected_t" class="bb_apilink">SteamServersDisconnected_t</a>
        /// callback.<br />
        /// <br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#LogOnAnonymous" class="bb_apilink">ISteamGameServer::LogOnAnonymous</a>
        /// </summary>
        /// <param name="pszToken">const char *: </param>
        public static void LogOn(UTF8StringPtr pszToken) => Instance.LogOn(pszToken);
        /// <summary>
        /// <code>void LogOnAnonymous();</code>
        /// Login to a generic, anonymous account.<br />
        /// <br />
        /// <b>Returns:</b> void<br />
        /// Triggers a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#SteamServerConnectFailure_t" class="bb_apilink">SteamServerConnectFailure_t</a>
        /// callback.<br />
        /// Triggers a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#SteamServersConnected_t" class="bb_apilink">SteamServersConnected_t</a>
        /// callback.<br />
        /// Triggers a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#SteamServersDisconnected_t" class="bb_apilink">SteamServersDisconnected_t</a>
        /// callback.<br />
        /// <br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#LogOn" class="bb_apilink">ISteamGameServer::LogOn</a>
        /// </summary>
        /// 
        public static void LogOnAnonymous() => Instance.LogOnAnonymous();
        /// <summary>
        /// <code>void LogOff();</code>
        /// Begin process of logging the game server out of steam.<br />
        /// <br />
        /// <b>Returns:</b> void<br />
        /// Triggers a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#SteamServerConnectFailure_t" class="bb_apilink">SteamServerConnectFailure_t</a>
        /// callback.<br />
        /// Triggers a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#SteamServersConnected_t" class="bb_apilink">SteamServersConnected_t</a>
        /// callback.<br />
        /// Triggers a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#SteamServersDisconnected_t" class="bb_apilink">SteamServersDisconnected_t</a>
        /// callback.
        /// </summary>
        /// 
        public static void LogOff() => Instance.LogOff();
        /// <summary>
        /// <code>bool BLoggedOn();</code>
        /// Checks if the game server is logged on.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the game server is logged on; otherwise, <b>false</b>.
        /// </summary>
        /// 
        public static bool BLoggedOn() => Instance.BLoggedOn();
        /// <summary>
        /// <code>bool BSecure();</code>
        /// Checks whether the game server is in "Secure" mode.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the game server secure; otherwise, <b>false</b>.<br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_gameserver#EServerMode" class="bb_apilink">EServerMode</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#GSPolicyResponse_t" class="bb_apilink">GSPolicyResponse_t</a>
        /// </summary>
        /// 
        public static bool BSecure() => Instance.BSecure();
        /// <summary>
        /// <code>CSteamID GetSteamID();</code>
        /// Gets the Steam ID of the game server.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        /// </summary>
        /// 
        public static SteamId GetSteamID() => Instance.GetSteamID();
        /// <summary>
        /// <code>bool WasRestartRequested();</code>
        /// Checks if the master server has alerted us that we are out of date.<br />
        /// <br />
        /// This reverts back to <b>false</b> after calling this function.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the master server wants this game server to update and restart; otherwise,
        /// <b>false</b>.
        /// </summary>
        /// 
        public static bool WasRestartRequested() => Instance.WasRestartRequested();
        /// <summary>
        /// <code>void SetMaxPlayerCount( int cPlayersMax );</code>
        /// 
        /// <br />
        /// Sets the maximum number of players allowed on the server at once.<br />
        /// <br />
        /// This value may be changed at any time.
        /// </summary>
        /// <param name="cPlayersMax">int: The new maximum number of players allowed on this server.</param>
        public static void SetMaxPlayerCount(int cPlayersMax) => Instance.SetMaxPlayerCount(cPlayersMax);
        /// <summary>
        /// <code>void SetBotPlayerCount( int cBotplayers );</code>
        /// 
        /// <br />
        /// Sets the number of bot/AI players on the game server. The default value is 0.
        /// </summary>
        /// <param name="cBotplayers">int: The number of bot/AI players currently playing on the server.</param>
        public static void SetBotPlayerCount(int cBotplayers) => Instance.SetBotPlayerCount(cBotplayers);
        /// <summary>
        /// <code>void SetServerName( const char *pszServerName );</code>
        /// 
        /// <br />
        /// Sets the name of server as it will appear in the server browser.
        /// </summary>
        /// <param name="pszServerName">const char *: 
        ///             The new server name to set. Must not be <b>NULL</b> or an empty string ("").
        ///             This can not be longer than
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamMatchmakingServers#k_cbMaxGameServerName" class="bb_apilink">k_cbMaxGameServerName</a>.
        ///         </param>
        public static void SetServerName(UTF8StringPtr pszServerName) => Instance.SetServerName(pszServerName);
        /// <summary>
        /// <code>void SetMapName( const char *pszMapName );</code>
        /// 
        /// <br />
        /// Sets the name of map to report in the server browser.
        /// </summary>
        /// <param name="pszMapName">const char *: 
        ///             The new map name to set. Must not be <b>NULL</b> or an empty string (""). This
        ///             can not be longer than
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamMatchmakingServers#k_cbMaxGameServerMapName" class="bb_apilink">k_cbMaxGameServerMapName</a>.
        ///         </param>
        public static void SetMapName(UTF8StringPtr pszMapName) => Instance.SetMapName(pszMapName);
        /// <summary>
        /// <code>void SetPasswordProtected( bool bPasswordProtected );</code>
        /// 
        /// <br />
        /// Set whether the game server will require a password once when the user tries to join.
        /// </summary>
        /// <param name="bPasswordProtected">bool: 
        ///             Enable (<b>true</b>) or disable (<b>false</b>) password protection.
        ///         </param>
        public static void SetPasswordProtected(bool bPasswordProtected) => Instance.SetPasswordProtected(bPasswordProtected);
        /// <summary>
        /// <code>void SetSpectatorPort( uint16 unSpectatorPort );</code>
        /// 
        /// <br />
        /// Set whether the game server allows spectators, and what port they should connect on. The default
        /// value is 0, meaning the service is not used.
        /// </summary>
        /// <param name="unSpectatorPort">uint16: The port for spectators to join.</param>
        public static void SetSpectatorPort(ushort unSpectatorPort) => Instance.SetSpectatorPort(unSpectatorPort);
        /// <summary>
        /// <code>void SetSpectatorServerName( const char *pszSpectatorServerName );</code>
        /// 
        /// <br />
        /// Sets the name of the spectator server. This is only used if spectator port is nonzero.
        /// </summary>
        /// <param name="pszSpectatorServerName">const char *: 
        ///             The spectator server name to set. Must not be <b>NULL</b> or an empty string
        ///             (""). This can not be longer than
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamMatchmakingServers#k_cbMaxGameServerMapName" class="bb_apilink">k_cbMaxGameServerMapName</a>.
        ///         </param>
        public static void SetSpectatorServerName(UTF8StringPtr pszSpectatorServerName) => Instance.SetSpectatorServerName(pszSpectatorServerName);
        /// <summary>
        /// <code>void ClearAllKeyValues();</code>
        /// Clears the whole list of key/values that are sent in rules queries.<br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#SetKeyValue" class="bb_apilink">ISteamGameServer::SetKeyValue</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmakingServers#ServerRules" class="bb_apilink">ISteamMatchmakingServers::ServerRules</a>
        /// </summary>
        /// 
        public static void ClearAllKeyValues() => Instance.ClearAllKeyValues();
        /// <summary>
        /// <code>void SetKeyValue( const char *pKey, const char *pValue );</code>
        /// 
        /// <br />
        /// Add/update a rules key/value pair.<br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#ClearAllKeyValues" class="bb_apilink">ISteamGameServer::ClearAllKeyValues</a>,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmakingServers#ServerRules" class="bb_apilink">ISteamMatchmakingServers::ServerRules</a>
        /// </summary>
        /// <param name="pKey">const char *: </param>
        /// <param name="pValue">const char *: </param>
        public static void SetKeyValue(UTF8StringPtr pKey, UTF8StringPtr pValue) => Instance.SetKeyValue(pKey, pValue);
        /// <summary>
        /// <code>void SetGameTags( const char *pchGameTags );</code>
        /// 
        /// <br />
        /// Sets a string defining the "gametags" for this server, this is optional, but if set it allows users
        /// to filter in the matchmaking/server-browser interfaces based on the value.<br />
        /// <br />
        /// This is usually formatted as a comma or semicolon separated list.<br />
        /// <br />
        /// Don't set this unless it actually changes, its only uploaded to the master once; when acknowledged.
        /// </summary>
        /// <param name="pchGameTags">const char *: 
        ///             The new "gametags" value to set. Must not be <b>NULL</b> or an empty string
        ///             (""). This can not be longer than
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamMatchmakingServers#k_cbMaxGameServerTags" class="bb_apilink">k_cbMaxGameServerTags</a>.
        ///         </param>
        public static void SetGameTags(UTF8StringPtr pchGameTags) => Instance.SetGameTags(pchGameTags);
        /// <summary>
        /// <code>void SetGameData( const char *pchGameData );</code>
        /// 
        /// <br />
        /// Sets a string defining the "gamedata" for this server, this is optional, but if set it allows users
        /// to filter in the matchmaking/server-browser interfaces based on the value.<br />
        /// <br />
        /// This is usually formatted as a comma or semicolon separated list.<br />
        /// <br />
        /// Don't set this unless it actually changes, its only uploaded to the master once; when acknowledged.
        /// </summary>
        /// <param name="pchGameData">const char *: 
        ///             The new "gamedata" value to set. Must not be <b>NULL</b> or an empty string
        ///             (""). This can not be longer than
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamMatchmakingServers#k_cbMaxGameServerGameData" class="bb_apilink">k_cbMaxGameServerGameData</a>.
        ///         </param>
        public static void SetGameData(UTF8StringPtr pchGameData) => Instance.SetGameData(pchGameData);
        /// <summary>
        /// <code>void SetRegion( const char *pszRegion );</code>
        /// 
        /// <br />
        /// Region identifier. This is an optional field, the default value is an empty string, meaning the
        /// "world" region.
        /// </summary>
        /// <param name="pszRegion">const char *: </param>
        public static void SetRegion(UTF8StringPtr pszRegion) => Instance.SetRegion(pszRegion);
        /// missing documentation
        public static void SetAdvertiseServerActive(bool bActive) => Instance.SetAdvertiseServerActive(bActive);
        /// <summary>
        /// <code>
        ///     HAuthTicket GetAuthSessionTicket( void *pTicket, int cbMaxTicket, uint32 *pcbTicket );
        /// </code>
        /// 
        /// <br />
        /// Retrieve a authentication ticket to be sent to the entity who wishes to authenticate you.<br />
        /// <br />
        /// After calling this you can send the ticket to the entity where they can then call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#BeginAuthSession" class="bb_apilink">ISteamUser::BeginAuthSession</a>
        /// to verify this entities integrity.<br />
        /// <br />
        /// When creating a ticket for use by the
        /// <a href="https://partner.steamgames.com/doc/webapi/ISteamUserAuth#AuthenticateUserTicket" class="bb_apilink">ISteamUserAuth/AuthenticateUserTicket</a>
        /// Web API, the calling application should wait for the
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#GetAuthSessionTicketResponse_t" class="bb_apilink">GetAuthSessionTicketResponse_t</a>
        /// callback generated by the API call before attempting to use the ticket to ensure that the ticket has
        /// been communicated to the server. If this callback does not come in a timely fashion (10 - 20
        /// seconds), then your client is not connected to Steam, and the AuthenticateUserTicket call will fail
        /// because it can not authenticate the user.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#HAuthTicket" class="bb_apilink">HAuthTicket</a><br />
        /// Triggers a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#GetAuthSessionTicketResponse_t" class="bb_apilink">GetAuthSessionTicketResponse_t</a>
        /// callback.<br />
        /// A handle to the auth ticket. When you're done interacting with the entity you must call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#CancelAuthTicket" class="bb_apilink">ISteamGameServer::CancelAuthTicket</a>
        /// on the handle.<br />
        /// <br />
        /// Returns
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#k_HAuthTicketInvalid" class="bb_apilink">k_HAuthTicketInvalid</a>
        /// if the call fails.<br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/features/auth" class="bb_doclink">User Authentication and Ownership</a>
        /// </summary>
        /// <param name="pTicket">void *: 
        ///             The buffer where the new auth ticket will be copied into if the call was successful.
        ///         </param>
        /// <param name="cbMaxTicket">int: 
        ///             The size of the buffer allocated for
        ///             <code class="bb_code bb_code_inline nohighlight">pTicket</code>. This should be
        ///             <b>1024</b>.
        ///         </param>
        /// <param name="pcbTicket">uint32
        ///             *: Returns the length of the actual ticket.</param>
        public static HAuthTicket GetAuthSessionTicket(void* pTicket, int cbMaxTicket, uint* pcbTicket, SteamNetworkingIdentity* pSnid) => Instance.GetAuthSessionTicket(pTicket, cbMaxTicket, pcbTicket, pSnid);
        /// <summary>
        /// <code>
        ///     EBeginAuthSessionResult BeginAuthSession( const void *pAuthTicket, int cbAuthTicket, CSteamID
        ///     steamID );
        /// </code>
        /// 
        /// <br />
        /// Authenticate the ticket from the entity Steam ID to be sure it is valid and isn't reused. Note that
        /// identity is not confirmed until the callback
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#ValidateAuthTicketResponse_t" class="bb_apilink">ValidateAuthTicketResponse_t</a>
        /// is received and the return value in that callback is checked for success.<br />
        /// <br />
        /// The ticket is created on the entity with
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#GetAuthSessionTicket" class="bb_apilink">ISteamUser::GetAuthSessionTicket</a>
        /// or
        /// <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#GetAuthSessionTicket" class="bb_apilink">ISteamGameServer::GetAuthSessionTicket</a>
        /// and then needs to be provided over the network for the other end to validate.<br />
        /// <br />
        /// This registers for
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#ValidateAuthTicketResponse_t" class="bb_apilink">ValidateAuthTicketResponse_t</a>
        /// callbacks if the entity goes offline or cancels the ticket. See
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#EAuthSessionResponse" class="bb_apilink">EAuthSessionResponse</a>
        /// for more information.<br />
        /// <br />
        /// When the multiplayer session terminates you must call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#EndAuthSession" class="bb_apilink">ISteamGameServer::EndAuthSession</a>.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#EBeginAuthSessionResult" class="bb_apilink">EBeginAuthSessionResult</a><br />
        /// <br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/features/auth" class="bb_doclink">User Authentication and Ownership</a>
        /// </summary>
        /// <param name="pAuthTicket">const void *: The auth ticket to validate.</param>
        /// <param name="cbAuthTicket">int: 
        ///             The size in bytes of the auth ticket. This must be the
        ///             <code class="bb_code bb_code_inline nohighlight">pcbTicket</code> size provided by the
        ///             call that created this ticket.
        ///         </param>
        /// <param name="steamID">CSteamID: The entity's Steam ID that sent this ticket.</param>
        public static BeginAuthSessionResult BeginAuthSession(void* pAuthTicket, int cbAuthTicket, SteamId steamID) => Instance.BeginAuthSession(pAuthTicket, cbAuthTicket, steamID);
        /// <summary>
        /// <code>void EndAuthSession( CSteamID steamID );</code>
        /// 
        /// <br />
        /// Ends an auth session that was started with
        /// <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#BeginAuthSession" class="bb_apilink">ISteamGameServer::BeginAuthSession</a>. This should be called when no longer playing with the specified entity.<br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/features/auth" class="bb_doclink">User Authentication and Ownership</a>
        /// </summary>
        /// <param name="steamID">CSteamID: The entity to end the active auth session with.</param>
        public static void EndAuthSession(SteamId steamID) => Instance.EndAuthSession(steamID);
        /// <summary>
        /// <code>void CancelAuthTicket( HAuthTicket hAuthTicket );</code>
        /// 
        /// <br />
        /// Cancels an auth ticket received from
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#GetAuthSessionTicket" class="bb_apilink">ISteamUser::GetAuthSessionTicket</a>. This should be called when no longer playing with the specified entity.<br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/features/auth" class="bb_doclink">User Authentication and Ownership</a>
        /// </summary>
        /// <param name="hAuthTicket">HAuthTicket: The active auth ticket to cancel.</param>
        public static void CancelAuthTicket(HAuthTicket hAuthTicket) => Instance.CancelAuthTicket(hAuthTicket);
        /// <summary>
        /// <code>
        ///     EUserHasLicenseForAppResult UserHasLicenseForApp( CSteamID steamID, AppId_t appID );
        /// </code>
        /// 
        /// <br />
        /// Checks if the user owns a specific piece of
        /// <a href="https://partner.steamgames.com/doc/store/application/dlc" class="bb_doclink">Downloadable Content (DLC)</a>.<br />
        /// <br />
        /// This can only be called after sending the users auth ticket to
        /// <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#BeginAuthSession" class="bb_apilink">ISteamGameServer::BeginAuthSession</a>/<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#EUserHasLicenseForAppResult" class="bb_apilink">EUserHasLicenseForAppResult</a><br />
        /// <br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/features/auth" class="bb_doclink">User Authentication and Ownership</a>
        /// </summary>
        /// <param name="steamID">CSteamID: The Steam ID of the user that sent the auth ticket.</param>
        /// <param name="appID">AppId_t: The DLC App ID to check if the user owns it.</param>
        public static UserHasLicenseForAppResult UserHasLicenseForApp(SteamId steamID, AppId appID) => Instance.UserHasLicenseForApp(steamID, appID);
        /// <summary>
        /// <code>
        ///     bool RequestUserGroupStatus( CSteamID steamIDUser, CSteamID steamIDGroup );
        /// </code>
        /// 
        /// <br />
        /// Checks if a user is in the specified Steam group.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// Triggers a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#GSClientGroupStatus_t" class="bb_apilink">GSClientGroupStatus_t</a>
        /// callback.<br />
        /// <b>true</b> if the call was successfully sent out to the Steam servers; otherwise,
        /// <b>false</b> if we're not connected to the steam servers or an invalid user or group was
        /// provided.
        /// </summary>
        /// <param name="steamIDUser">CSteamID: The user to check the group status of.</param>
        /// <param name="steamIDGroup">CSteamID: The group to check.</param>
        public static bool RequestUserGroupStatus(SteamId steamIDUser, SteamId steamIDGroup) => Instance.RequestUserGroupStatus(steamIDUser, steamIDGroup);
        /// <summary>
        /// <code>void GetGameplayStats();</code>
        /// Deprecated - Will be removed in a future release of the SDK.<br />
        /// <br />
        /// <b>Returns:</b> void<br />
        /// Triggers a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#GSGameplayStats_t" class="bb_apilink">GSGameplayStats_t</a>
        /// callback.
        /// </summary>
        /// 
        public static void GetGameplayStats() => Instance.GetGameplayStats();
        /// <summary>
        /// <code>SteamAPICall_t GetServerReputation();</code>
        /// Deprecated - Will be removed in a future release of the SDK.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a>
        /// to be used with a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#GSReputation_t" class="bb_apilink">GSReputation_t</a>
        /// call result.
        /// </summary>
        /// 
        public static SteamAPICall GetServerReputation() => Instance.GetServerReputation();
        /// <summary>
        /// <code>uint32 GetPublicIP();</code>
        /// Gets the public IP of the server according to Steam.<br />
        /// <br />
        /// This is useful when the server is behind NAT and you want to advertise its IP in a lobby for other
        /// clients to directly connect to.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a><br />
        /// The public IP in host order, i.e 127.0.0.1 == 0x7f000001.<br />
        /// <br />
        /// Returns <b>0</b> if the IP could not be determined.
        /// </summary>
        /// 
        public static SteamIPAddress GetPublicIP() => Instance.GetPublicIP();
        /// <summary>
        /// <code>
        ///     bool HandleIncomingPacket( const void *pData, int cbData, uint32 srcIP, uint16 srcPort );
        /// </code>
        /// 
        /// <br />
        /// Handles a Steam master server packet when in GameSocketShare mode.<br />
        /// <br />
        /// When in GameSocketShare mode, instead of ISteamGameServer creating its own socket to talk to the
        /// master server on, it lets the game use its socket to forward messages<br />
        /// back and forth. This prevents us from requiring server ops to open up yet another port in their
        /// firewalls.<br />
        /// <br />
        /// This should be called whenever a packet that starts with 0xFFFFFFFF comes in. That means it's for
        /// us.<br />
        /// <br />
        /// The IP and port parameters are used when you've elected to multiplex the game server's UDP socket
        /// rather than having the master server updater use its own sockets.<br />
        /// <br />
        /// Source engine games use this to simplify the job of the server admins, so they don't have to open up
        /// more ports on their firewalls.<br />
        /// <br />
        /// Only <b>AFTER</b> calling this, you should call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#GetNextOutgoingPacket" class="bb_apilink">ISteamGameServer::GetNextOutgoingPacket</a>.<br />
        /// <br />
        /// GameSocketShare mode can be enabled when calling
        /// <a href="https://partner.steamgames.com/doc/api/steam_gameserver#SteamGameServer_Init" class="bb_apilink">SteamGameServer_Init</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool
        /// </summary>
        /// <param name="pData">const void *: The data from the incoming packet.</param>
        /// <param name="cbData">int: The size of <code class="bb_code bb_code_inline nohighlight">pData</code> in bytes.</param>
        /// <param name="srcIP">uint32: 
        ///             The IP address that this packet was sent to in host order, i.e 127.0.0.1 == 0x7f000001.
        ///         </param>
        /// <param name="srcPort">uint16: The port that this packet was sent through, in host order.</param>
        public static bool HandleIncomingPacket(void* pData, int cbData, uint srcIP, ushort srcPort) => Instance.HandleIncomingPacket(pData, cbData, srcIP, srcPort);
        /// <summary>
        /// <code>
        ///     int GetNextOutgoingPacket( void *pOut, int cbMaxOut, uint32 *pNetAdr, uint16 *pPort );
        /// </code>
        /// 
        /// <br />
        /// Gets a packet that the master server updater needs to send out on UDP when in GameSocketShare
        /// mode.<br />
        /// <br />
        /// <b>NOTE:</b> This should only ever be called AFTER calling
        /// <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#HandleIncomingPacket" class="bb_apilink">ISteamGameServer::HandleIncomingPacket</a>
        /// for any packets that came in that frame!<br />
        /// <br />
        /// <b>NOTE:</b> This MUST be called repeatedly each frame until it returns 0 when in
        /// GameSocketShare mode.<br />
        /// <br />
        /// GameSocketShare mode can be enabled when calling
        /// <a href="https://partner.steamgames.com/doc/api/steam_gameserver#SteamGameServer_Init" class="bb_apilink">SteamGameServer_Init</a>.<br />
        /// <br />
        /// <b>Returns:</b> int<br />
        /// The length of the packet that needs to be to sent, or 0 if there are no more packets to send this
        /// frame.
        /// </summary>
        /// <param name="pOut">void *: 
        ///             Returns the packet that needs to be sent by copying it into this buffer. The packet may
        ///             be up to 16KiB so allocate accordingly.
        ///         </param>
        /// <param name="cbMaxOut">int: 
        ///             The size of the buffer provided to
        ///             <code class="bb_code bb_code_inline nohighlight">pOut</code>, should be 16 * 1024.
        ///         </param>
        /// <param name="pNetAdr">uint32
        ///             *: 
        ///             Returns the The IP address that this packet needs to be sent to in host order, i.e
        ///             127.0.0.1 == 0x7f000001.
        ///         </param>
        /// <param name="pPort">uint16
        ///             *: Returns the port that this packet needs to be sent through, in host order.</param>
        public static int GetNextOutgoingPacket(void* pOut, int cbMaxOut, uint* pNetAdr, ushort* pPort) => Instance.GetNextOutgoingPacket(pOut, cbMaxOut, pNetAdr, pPort);
        /// <summary>
        /// <code>SteamAPICall_t AssociateWithClan( CSteamID steamIDClan );</code>
        /// 
        /// <br />
        /// associate this game server with this clan for the purposes of computing player compatibility.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a>
        /// to be used with a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#AssociateWithClanResult_t" class="bb_apilink">AssociateWithClanResult_t</a>
        /// call result.
        /// </summary>
        /// <param name="steamIDClan">CSteamID: The Steam ID of the group you want to be associated with.</param>
        public static SteamAPICall AssociateWithClan(SteamId steamIDClan) => Instance.AssociateWithClan(steamIDClan);
        /// <summary>
        /// <code>
        ///     SteamAPICall_t ComputeNewPlayerCompatibility( CSteamID steamIDNewPlayer );
        /// </code>
        /// 
        /// <br />
        /// Checks if any of the current players don't want to play with this new player that is attempting to
        /// join - or vice versa; based on the frenemy system.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a>
        /// to be used with a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#ComputeNewPlayerCompatibilityResult_t" class="bb_apilink">ComputeNewPlayerCompatibilityResult_t</a>
        /// call result.
        /// </summary>
        /// <param name="steamIDNewPlayer">CSteamID: The Steam ID of the player that is attempting to join.</param>
        public static SteamAPICall ComputeNewPlayerCompatibility(SteamId steamIDNewPlayer) => Instance.ComputeNewPlayerCompatibility(steamIDNewPlayer);
        /// missing documentation
        public static bool SendUserConnectAndAuthenticate_DEPRECATED(uint unIPClient, void* pvAuthBlob, uint cubAuthBlobSize, SteamId* pSteamIDUser) => Instance.SendUserConnectAndAuthenticate_DEPRECATED(unIPClient, pvAuthBlob, cubAuthBlobSize, pSteamIDUser);
        /// <summary>
        /// <code>CSteamID CreateUnauthenticatedUserConnection();</code>
        /// Creates a fake user (ie, a bot) which will be listed as playing on the server, but skips
        /// validation.<br />
        /// <br />
        /// <b>NOTE:</b> This is part of the old user authentication API and should not be mixed with
        /// the new API.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a><br />
        /// Returns the Steam ID for the bot to be tracked with.<br />
        /// <br />
        /// You should call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#SendUserDisconnect" class="bb_apilink">ISteamGameServer::SendUserDisconnect</a>
        /// when this user leaves the server just like you would for a real user.
        /// </summary>
        /// 
        public static SteamId CreateUnauthenticatedUserConnection() => Instance.CreateUnauthenticatedUserConnection();
        /// missing documentation
        public static void SendUserDisconnect_DEPRECATED(SteamId steamIDUser) => Instance.SendUserDisconnect_DEPRECATED(steamIDUser);
        /// <summary>
        /// <code>
        ///     bool BUpdateUserData( CSteamID steamIDUser, const char *pchPlayerName, uint32 uScore );
        /// </code>
        /// 
        /// <br />
        /// Update the data to be displayed in the server browser and matchmaking interfaces for a user
        /// currently connected to the server.<br />
        /// <br />
        /// <b>NOTE:</b> This is part of the old user authentication API and should not be mixed with
        /// the new API.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the call was successful; otherwise <b>false</b> if there was a
        /// failure (ie, <code class="bb_code bb_code_inline nohighlight">steamIDUser</code> is not a player on
        /// the current server.)<br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/features/auth" class="bb_doclink">User Authentication and Ownership</a>
        /// </summary>
        /// <param name="steamIDUser">CSteamID: The Steam ID of the user.</param>
        /// <param name="pchPlayerName">const char *: The name of the user.</param>
        /// <param name="uScore">uint32: The current score of the user.</param>
        public static bool BUpdateUserData(SteamId steamIDUser, UTF8StringPtr pchPlayerName, uint uScore) => Instance.BUpdateUserData(steamIDUser, pchPlayerName, uScore);
    }
}