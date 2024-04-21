using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamUser
    {
        public static ISteamUser.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamUser_v023", CallingConvention = Platform.CC)]
        private static extern ISteamUser.Instance Accessor();
        /// <summary>
        /// <code>HSteamUser GetHSteamUser();</code>
        /// Gets Steam user handle that this interface represents.<br />
        /// <br />
        /// This is only used internally by the API, and by a few select interfaces that support multi-user.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamClient#HSteamUser" class="bb_apilink">HSteamUser</a>
        /// </summary>
        /// 
        public static HSteamUser GetHSteamUser() => Instance.GetHSteamUser();
        /// <summary>
        /// <code>bool BLoggedOn();</code>
        /// Checks if the current user's Steam client is connected to the Steam servers.<br />
        /// <br />
        /// If it's not then no real-time services provided by the Steamworks API will be enabled. The Steam
        /// client will automatically be trying to recreate the connection as often as possible. When the
        /// connection is restored a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#SteamServersConnected_t" class="bb_apilink">SteamServersConnected_t</a>
        /// callback will be posted.<br />
        /// <br />
        /// You usually don't need to check for this yourself. All of the API calls that rely on this will check
        /// internally. Forcefully disabling stuff when the player loses access is usually not a very good
        /// experience for the player and you could be preventing them from accessing APIs that do not need a
        /// live connection to Steam.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the Steam client current has a live connection to the Steam servers;
        /// otherwise, <b>false</b> if there is no active connection due to either a networking issue
        /// on the local machine, or the Steam server is down/busy.
        /// </summary>
        /// 
        public static bool BLoggedOn() => Instance.BLoggedOn();
        /// <summary>
        /// <code>CSteamID GetSteamID();</code>
        /// Gets the Steam ID of the account currently logged into the Steam client. This is commonly called the
        /// 'current user', or 'local user'.<br />
        /// <br />
        /// A Steam ID is a unique identifier for a Steam accounts, Steam groups, Lobbies and Chat rooms, and
        /// used to differentiate users in all parts of the Steamworks API.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a><br />
        /// <br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>CSteamID steamID = SteamUser()-&gt;GetSteamID();</code>
        /// </summary>
        /// 
        public static SteamId GetSteamID() => Instance.GetSteamID();
        /// missing documentation
        public static int InitiateGameConnection_DEPRECATED(void* pAuthBlob, int cbMaxAuthBlob, SteamId steamIDGameServer, uint unIPServer, ushort usPortServer, bool bSecure) => Instance.InitiateGameConnection_DEPRECATED(pAuthBlob, cbMaxAuthBlob, steamIDGameServer, unIPServer, usPortServer, bSecure);
        /// missing documentation
        public static void TerminateGameConnection_DEPRECATED(uint unIPServer, ushort usPortServer) => Instance.TerminateGameConnection_DEPRECATED(unIPServer, usPortServer);
        /// <summary>
        /// <code>
        ///     void TrackAppUsageEvent( CGameID gameID, int eAppUsageEvent, const char *pchExtraInfo = "" );
        /// </code>
        /// 
        /// <br />
        /// Deprecated - Only used by only a few games to track usage events before
        /// <a href="https://partner.steamgames.com/doc/features/achievements" class="bb_doclink">Stats and Achievements</a>
        /// was introduced.
        /// </summary>
        /// <param name="gameID">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CGameID" class="bb_apilink">CGameID</a>
        ///         : </param>
        /// <param name="eAppUsageEvent">int: </param>
        /// <param name="pchExtraInfo">const char *: </param>
        public static void TrackAppUsageEvent(GameId gameID, int eAppUsageEvent, UTF8StringPtr pchExtraInfo) => Instance.TrackAppUsageEvent(gameID, eAppUsageEvent, pchExtraInfo);
        /// <summary>
        /// <code>bool GetUserDataFolder( char *pchBuffer, int cubBuffer );</code>
        /// 
        /// <br />
        /// Deprecated - You should use the
        /// <a href="https://partner.steamgames.com/doc/features/cloud" class="bb_doclink">Steam Cloud</a> API
        /// from
        /// <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage" class="bb_apilink">ISteamRemoteStorage</a>
        /// instead.<br />
        /// <br />
        /// <b>Returns:</b> bool
        /// </summary>
        /// <param name="pchBuffer">char *: </param>
        /// <param name="cubBuffer">int: </param>
        public static bool GetUserDataFolder(char* pchBuffer, int cubBuffer) => Instance.GetUserDataFolder(pchBuffer, cubBuffer);
        /// <summary>
        /// <code>void StartVoiceRecording();</code>
        /// Starts voice recording.<br />
        /// <br />
        /// Once started, use
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#GetAvailableVoice" class="bb_apilink">ISteamUser::GetAvailableVoice</a>
        /// and
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#GetVoice" class="bb_apilink">ISteamUser::GetVoice</a>
        /// to get the data, and then call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#StopVoiceRecording" class="bb_apilink">ISteamUser::StopVoiceRecording</a>
        /// when the user has released their push-to-talk hotkey or the game session has completed.<br />
        /// <br />
        /// See
        /// <a href="https://partner.steamgames.com/doc/features/voice" class="bb_doclink">Steam Voice</a> for
        /// more information.
        /// </summary>
        /// 
        public static void StartVoiceRecording() => Instance.StartVoiceRecording();
        /// <summary>
        /// <code>void StopVoiceRecording();</code>
        /// Stops voice recording.<br />
        /// <br />
        /// Because people often release push-to-talk keys early, the system will keep recording for a little
        /// bit after this function is called. As such,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#GetVoice" class="bb_apilink">ISteamUser::GetVoice</a>
        /// should continue to be called until it returns
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#k_EVoiceResultNotRecording" class="bb_apilink">k_EVoiceResultNotRecording</a>, only then will voice recording be stopped.
        /// </summary>
        /// 
        public static void StopVoiceRecording() => Instance.StopVoiceRecording();
        /// <summary>
        /// <code>
        ///     EVoiceResult GetAvailableVoice( uint32 *pcbCompressed, uint32 *pcbUncompressed_Deprecated = 0,
        ///     uint32 nUncompressedVoiceDesiredSampleRate_Deprecated = 0 );
        /// </code>
        /// 
        /// <br />
        /// Checks to see if there is captured audio data available from
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#GetVoice" class="bb_apilink">ISteamUser::GetVoice</a>, and gets the size of the data.<br />
        /// <br />
        /// Most applications will only use compressed data and should ignore the other parameters, which exist
        /// primarily for backwards compatibility. See
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#GetVoice" class="bb_apilink">ISteamUser::GetVoice</a>
        /// for further explanation of "uncompressed" data.<br />
        /// <br />
        /// See
        /// <a href="https://partner.steamgames.com/doc/features/voice" class="bb_doclink">Steam Voice</a> for
        /// more information.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#EVoiceResult" class="bb_apilink">EVoiceResult</a>
        /// </summary>
        /// <param name="pcbCompressed">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>
        ///             *
        ///         : Returns the size of the available voice data in bytes.</param>
        /// <param name="pcbUncompressed_Deprecated">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>
        ///             *
        ///         : Deprecated.</param>
        /// <param name="nUncompressedVoiceDesiredSampleRate_Deprecated">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>
        ///         : Deprecated.</param>
        public static VoiceResult GetAvailableVoice(uint* pcbCompressed, uint* pcbUncompressed_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) => Instance.GetAvailableVoice(pcbCompressed, pcbUncompressed_Deprecated, nUncompressedVoiceDesiredSampleRate_Deprecated);
        /// <summary>
        /// <code>
        ///     EVoiceResult GetVoice( bool bWantCompressed, void *pDestBuffer, uint32 cbDestBufferSize, uint32
        ///     *nBytesWritten, bool bWantUncompressed_Deprecated = false, void
        ///     *pUncompressedDestBuffer_Deprecated = 0, uint32 cbUncompressedDestBufferSize_Deprecated = 0,
        ///     uint32 *nUncompressBytesWritten_Deprecated = 0, uint32
        ///     nUncompressedVoiceDesiredSampleRate_Deprecated = 0 );
        /// </code>
        /// 
        /// <br />
        /// Read captured audio data from the microphone buffer.<br />
        /// <br />
        /// The compressed data can be transmitted by your application and decoded back into raw audio data
        /// using
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#DecompressVoice" class="bb_apilink">ISteamUser::DecompressVoice</a>
        /// on the other side. The compressed data provided is in an arbitrary format and is not meant to be
        /// played directly.<br />
        /// <br />
        /// This should be called once per frame, and at worst no more than four times a second to keep the
        /// microphone input delay as low as possible. Calling this any less may result in gaps in the returned
        /// stream.<br />
        /// <br />
        /// It is recommended that you pass in an 8 kilobytes or larger destination buffer for compressed audio.
        /// Static buffers are recommended for performance reasons. However, if you would like to allocate
        /// precisely the right amount of space for a buffer before each call you may use
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#GetAvailableVoice" class="bb_apilink">ISteamUser::GetAvailableVoice</a>
        /// to find out how much data is available to be read.<br />
        /// <br />
        /// <b>NOTE:</b> "Uncompressed" audio is a deprecated feature and should not be used by most
        /// applications. It is raw single-channel 16-bit PCM wave data which may have been run through
        /// preprocessing filters and/or had silence removed, so the uncompressed audio could have a shorter
        /// duration than you expect. There may be no data at all during long periods of silence. Also, fetching
        /// uncompressed audio will cause GetVoice to discard any leftover compressed audio, so you must fetch
        /// both types at once. Finally,
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#GetAvailableVoice" class="bb_apilink">ISteamUser::GetAvailableVoice</a>
        /// is not precisely accurate when the uncompressed size is requested. So if you really need to use
        /// uncompressed audio, you should call GetVoice frequently with two very large (20KiB+) output buffers
        /// instead of trying to allocate perfectly-sized buffers. But most applications should ignore all of
        /// these details and simply leave the "uncompressed" parameters as
        /// <b>NULL</b>/<b>0</b>.<br />
        /// <br />
        /// See
        /// <a href="https://partner.steamgames.com/doc/features/voice" class="bb_doclink">Steam Voice</a> for
        /// more information.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#EVoiceResult" class="bb_apilink">EVoiceResult</a>
        /// </summary>
        /// <param name="bWantCompressed">bool: This should always be <b>true</b>.</param>
        /// <param name="pDestBuffer">void *: The buffer where the audio data will be copied into.</param>
        /// <param name="cbDestBufferSize">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>
        ///         : 
        ///             The size of the buffer allocated for
        ///             <code class="bb_code bb_code_inline nohighlight">pDestBuffer</code>.
        ///         </param>
        /// <param name="nBytesWritten">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>
        ///             *
        ///         : 
        ///             Returns the number of bytes written into
        ///             <code class="bb_code bb_code_inline nohighlight">pDestBuffer</code>. This should always
        ///             be the size returned by
        ///             <code class="bb_code bb_code_inline nohighlight">ISteamUser::GetAvailableVoice</code>.
        ///         </param>
        /// <param name="bWantUncompressed_Deprecated">bool: Deprecated.</param>
        /// <param name="pUncompressedDestBuffer_Deprecated">void *: Deprecated.</param>
        /// <param name="cbUncompressedDestBufferSize_Deprecated">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>
        ///         : Deprecated.</param>
        /// <param name="nUncompressBytesWritten_Deprecated">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>
        ///             *
        ///         : Deprecated.</param>
        /// <param name="nUncompressedVoiceDesiredSampleRate_Deprecated">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>
        ///         : Deprecated.</param>
        public static VoiceResult GetVoice(bool bWantCompressed, void* pDestBuffer, uint cbDestBufferSize, uint* nBytesWritten, bool bWantUncompressed_Deprecated, void* pUncompressedDestBuffer_Deprecated, uint cbUncompressedDestBufferSize_Deprecated, uint* nUncompressBytesWritten_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) => Instance.GetVoice(bWantCompressed, pDestBuffer, cbDestBufferSize, nBytesWritten, bWantUncompressed_Deprecated, pUncompressedDestBuffer_Deprecated, cbUncompressedDestBufferSize_Deprecated, nUncompressBytesWritten_Deprecated, nUncompressedVoiceDesiredSampleRate_Deprecated);
        /// <summary>
        /// <code>
        ///     EVoiceResult DecompressVoice( const void *pCompressed, uint32 cbCompressed, void *pDestBuffer,
        ///     uint32 cbDestBufferSize, uint32 *nBytesWritten, uint32 nDesiredSampleRate );
        /// </code>
        /// 
        /// <br />
        /// Decodes the compressed voice data returned by
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#GetVoice" class="bb_apilink">ISteamUser::GetVoice</a>.<br />
        /// <br />
        /// The output data is raw single-channel 16-bit PCM audio. The decoder supports any sample rate from
        /// 11025 to 48000. See
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#GetVoiceOptimalSampleRate" class="bb_apilink">ISteamUser::GetVoiceOptimalSampleRate</a>
        /// for more information.<br />
        /// <br />
        /// It is recommended that you start with a 20KiB buffer and then reallocate as necessary.<br />
        /// <br />
        /// See
        /// <a href="https://partner.steamgames.com/doc/features/voice" class="bb_doclink">Steam Voice</a> for
        /// more information.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#EVoiceResult" class="bb_apilink">EVoiceResult</a><br />
        /// The internal sample rate of the Steam Voice decoder.
        /// </summary>
        /// <param name="pCompressed">const void *: 
        ///             The compressed data received from
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamUser#GetVoice" class="bb_apilink">ISteamUser::GetVoice</a>.
        ///         </param>
        /// <param name="cbCompressed">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>
        ///         : 
        ///             The size of the buffer passed into
        ///             <code class="bb_code bb_code_inline nohighlight">pCompressed</code>.
        ///         </param>
        /// <param name="pDestBuffer">void *: 
        ///             The buffer where the raw audio data will be returned. This can then be passed to your
        ///             audio subsystems for playback.
        ///         </param>
        /// <param name="cbDestBufferSize">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>
        ///         : 
        ///             The size of the buffer passed into
        ///             <code class="bb_code bb_code_inline nohighlight">pDestBuffer</code>.
        ///         </param>
        /// <param name="nBytesWritten">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>
        ///             *
        ///         : 
        ///             Returns the number of bytes written to
        ///             <code class="bb_code bb_code_inline nohighlight">pDestBuffer</code>, or size of the
        ///             buffer required to decompress the given data if
        ///             <code class="bb_code bb_code_inline nohighlight">cbDestBufferSize</code> is not large
        ///             enough (and
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#k_EVoiceResultBufferTooSmall" class="bb_apilink">k_EVoiceResultBufferTooSmall</a>
        ///             is returned).
        ///         </param>
        /// <param name="nDesiredSampleRate">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>
        ///         : 
        ///             The sample rate that will be returned. This can be from <b>11025</b> to
        ///             <b>48000</b>, you should either use the rate that works best for your audio
        ///             playback system, which likely takes the users audio hardware into account, or you can
        ///             use
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamUser#GetVoiceOptimalSampleRate" class="bb_apilink">ISteamUser::GetVoiceOptimalSampleRate</a>
        ///             to get the native sample rate of the Steam voice decoder.
        ///         </param>
        public static VoiceResult DecompressVoice(void* pCompressed, uint cbCompressed, void* pDestBuffer, uint cbDestBufferSize, uint* nBytesWritten, uint nDesiredSampleRate) => Instance.DecompressVoice(pCompressed, cbCompressed, pDestBuffer, cbDestBufferSize, nBytesWritten, nDesiredSampleRate);
        /// <summary>
        /// <code>uint32 GetVoiceOptimalSampleRate();</code>
        /// Gets the native sample rate of the Steam voice decoder.<br />
        /// <br />
        /// Using this sample rate for
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#DecompressVoice" class="bb_apilink">ISteamUser::DecompressVoice</a>
        /// will perform the least CPU processing. However, the final audio quality will depend on how well the
        /// audio device (and/or your application's audio output SDK) deals with lower sample rates. You may
        /// find that you get the best audio output quality when you ignore this function and use the native
        /// sample rate of your audio output device, which is usually 48000 or 44100.<br />
        /// <br />
        /// See
        /// <a href="https://partner.steamgames.com/doc/features/voice" class="bb_doclink">Steam Voice</a> for
        /// more information.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>
        /// </summary>
        /// 
        public static uint GetVoiceOptimalSampleRate() => Instance.GetVoiceOptimalSampleRate();
        /// <summary>
        /// <code>
        ///     HAuthTicket GetAuthSessionTicket( void *pTicket, int cbMaxTicket, uint32 *pcbTicket, const
        ///     SteamNetworkingIdentity *pIdentityRemote );
        /// </code>
        /// 
        /// <div class="bb_callout">
        ///     <div>
        ///         <strong>NOTE:</strong> This API can not be used to create a ticket for use by the
        ///         <a href="https://partner.steamgames.com/doc/webapi/ISteamUserAuth#AuthenticateUserTicket" class="bb_apilink">ISteamUserAuth/AuthenticateUserTicket</a>
        ///         Web API. Use the
        ///         <a href="https://partner.steamgames.com/doc/api/ISteamUser#GetAuthTicketForWebApi" class="bb_apilink">ISteamUser::GetAuthTicketForWebApi</a>
        ///         call instead
        ///     </div>
        /// </div>
        /// <br />
        /// Retrieve an authentication ticket to be sent to the entity who wishes to authenticate you.<br />
        /// <br />
        /// After calling this you can send the ticket to the entity where they can then call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#BeginAuthSession" class="bb_apilink">ISteamUser::BeginAuthSession</a>/<a href="https://partner.steamgames.com/doc/api/ISteamGameServer#BeginAuthSession" class="bb_apilink">ISteamGameServer::BeginAuthSession</a>
        /// to verify this entity's integrity.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#HAuthTicket" class="bb_apilink">HAuthTicket</a><br />
        /// Triggers a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#GetAuthSessionTicketResponse_t" class="bb_apilink">GetAuthSessionTicketResponse_t</a>
        /// callback.<br />
        /// A handle to the auth ticket. When you're done interacting with the entity you must call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#CancelAuthTicket" class="bb_apilink">ISteamUser::CancelAuthTicket</a>
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
        ///             <code class="bb_code bb_code_inline nohighlight">pTicket</code>. Typically a buffer size
        ///             of <b>1024</b> will be sufficient. However, in certain cases (e.g., when an
        ///             application has a large amount of available DLC), a larger buffer size may be required.
        ///         </param>
        /// <param name="pcbTicket">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>
        ///             *
        ///         : Returns the length of the actual ticket.</param>
        /// <param name="pIdentityRemote ">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#SteamNetworkingIdentity%20" class="bb_apilink">SteamNetworkingIdentity
        ///             </a>
        ///             *
        ///         : 
        ///             The identity of the remote system that will authenticate the ticket. If it is
        ///             peer-to-peer then the user steam ID. If it is a game server, then the game server steam
        ///             ID may be used if it was obtained from a trusted 3rd party, otherwise use the IP
        ///             address. If it is a service, a string identifier of that service if one if provided.
        ///         </param>
        public static HAuthTicket GetAuthSessionTicket(void* pTicket, int cbMaxTicket, uint* pcbTicket, SteamNetworkingIdentity* pSteamNetworkingIdentity) => Instance.GetAuthSessionTicket(pTicket, cbMaxTicket, pcbTicket, pSteamNetworkingIdentity);
        /// <summary>
        /// <code>HAuthTicket GetAuthTicketForWebApi( const char *pchIdentity );</code>
        /// 
        /// <br />
        /// Retrieve an authentication ticket to be sent to the entity that wishes to authenticate you using the
        /// <a href="https://partner.steamgames.com/doc/webapi/ISteamUserAuth#AuthenticateUserTicket" class="bb_apilink">ISteamUserAuth/AuthenticateUserTicket</a>
        /// Web API.
        /// <div class="bb_callout">
        ///     <div>
        ///         The calling application must wait for the
        ///         <a href="https://partner.steamgames.com/doc/api/ISteamUser#GetTicketForWebApiResponse_t" class="bb_apilink">GetTicketForWebApiResponse_t</a>
        ///         callback generated by the API call to access the ticket.
        ///     </div>
        /// </div>
        /// <br />
        /// It is best practice to use an identity string for each service that will consume tickets.
        /// <div class="bb_callout">
        ///     <div>
        ///         <strong>NOTE:</strong> This API can not be used to create a ticket for use by the
        ///         <a href="https://partner.steamgames.com/doc/api/ISteamUser#BeginAuthSession" class="bb_apilink">ISteamUser::BeginAuthSession</a>/<a href="https://partner.steamgames.com/doc/api/ISteamGameServer#BeginAuthSession" class="bb_apilink">ISteamGameServer::BeginAuthSession</a>
        ///         . Use the
        ///         <a href="https://partner.steamgames.com/doc/api/ISteamUser#GetAuthSessionTicket" class="bb_apilink">ISteamUser::GetAuthSessionTicket</a>
        ///         API instead
        ///     </div>
        /// </div>
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#HAuthTicket" class="bb_apilink">HAuthTicket</a><br />
        /// Triggers a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#GetTicketForWebApiResponse_t" class="bb_apilink">GetTicketForWebApiResponse_t</a>
        /// callback.<br />
        /// A handle to the auth ticket. When you're done interacting with the entity you must call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#CancelAuthTicket" class="bb_apilink">ISteamUser::CancelAuthTicket</a>
        /// on the handle.<br />
        /// <br />
        /// Returns
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#k_HAuthTicketInvalid" class="bb_apilink">k_HAuthTicketInvalid</a>
        /// if the call fails.<br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/features/auth" class="bb_doclink">User Authentication and Ownership</a>
        /// </summary>
        /// <param name="*pchIdentity ">
        ///             <a href="https://partner.steamgames.com/doc/api/const%20char%20" class="bb_apilink">const char
        ///             </a>
        ///             *
        ///         : 
        ///             The identity of the remote service that will authenticate the ticket. The service should
        ///             provide a string identifier. Pass null if none was provided.
        ///         </param>
        public static HAuthTicket GetAuthTicketForWebApi(UTF8StringPtr pchIdentity) => Instance.GetAuthTicketForWebApi(pchIdentity);
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
        /// This registers for additional
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#ValidateAuthTicketResponse_t" class="bb_apilink">ValidateAuthTicketResponse_t</a>
        /// callbacks if the entity goes offline or cancels the ticket. See
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#EAuthSessionResponse" class="bb_apilink">EAuthSessionResponse</a>
        /// for more information.<br />
        /// <br />
        /// When the multiplayer session terminates you must call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#EndAuthSession" class="bb_apilink">ISteamUser::EndAuthSession</a>.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#EBeginAuthSessionResult" class="bb_apilink">EBeginAuthSessionResult</a><br />
        /// Triggers a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#ValidateAuthTicketResponse_t" class="bb_apilink">ValidateAuthTicketResponse_t</a>
        /// callback.<br />
        /// <br />
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
        /// <param name="steamID">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The entity's Steam ID that sent this ticket.</param>
        public static BeginAuthSessionResult BeginAuthSession(void* pAuthTicket, int cbAuthTicket, SteamId steamID) => Instance.BeginAuthSession(pAuthTicket, cbAuthTicket, steamID);
        /// <summary>
        /// <code>void EndAuthSession( CSteamID steamID );</code>
        /// 
        /// <br />
        /// Ends an auth session that was started with
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#BeginAuthSession" class="bb_apilink">ISteamUser::BeginAuthSession</a>. This should be called when no longer playing with the specified entity.<br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/features/auth" class="bb_doclink">User Authentication and Ownership</a>
        /// </summary>
        /// <param name="steamID">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The entity to end the active auth session with.</param>
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
        /// <param name="hAuthTicket">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#HAuthTicket" class="bb_apilink">HAuthTicket</a>
        ///         : The active auth ticket to cancel.</param>
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
        /// <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#BeginAuthSession" class="bb_apilink">ISteamGameServer::BeginAuthSession</a><br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#EUserHasLicenseForAppResult" class="bb_apilink">EUserHasLicenseForAppResult</a><br />
        /// <br />
        /// <br />
        /// <b>See Also:</b>
        /// <a href="https://partner.steamgames.com/doc/features/auth" class="bb_doclink">User Authentication and Ownership</a>
        /// </summary>
        /// <param name="steamID">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : The Steam ID of the user that sent the auth ticket.</param>
        /// <param name="appID">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#AppId_t" class="bb_apilink">AppId_t</a>
        ///         : The DLC App ID to check if the user owns it.</param>
        public static UserHasLicenseForAppResult UserHasLicenseForApp(SteamId steamID, AppId appID) => Instance.UserHasLicenseForApp(steamID, appID);
        /// <summary>
        /// <code>bool BIsBehindNAT();</code>
        /// Checks if the current user looks like they are behind a NAT device.<br />
        /// <br />
        /// This is only valid if the user is connected to the Steam servers and may not catch all forms of
        /// NAT.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the current user is behind a NAT, otherwise <b>false</b>.
        /// </summary>
        /// 
        public static bool BIsBehindNAT() => Instance.BIsBehindNAT();
        /// <summary>
        /// <code>
        ///     void AdvertiseGame( CSteamID steamIDGameServer, uint32 unIPServer, uint16 usPortServer );
        /// </code>
        /// 
        /// <br />
        /// Set the rich presence data for an unsecured game server that the user is playing on. This allows
        /// friends to be able to view the game info and join your game.<br />
        /// <br />
        /// When you are using Steam authentication system this call is never required, the auth system
        /// automatically sets the appropriate rich presence.
        /// </summary>
        /// <param name="steamIDGameServer">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>
        ///         : 
        ///             This should be
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#k_steamIDNonSteamGS" class="bb_apilink">k_steamIDNonSteamGS</a>
        ///             if you're setting the IP/Port, otherwise it should be
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#k_steamIDNil" class="bb_apilink">k_steamIDNil</a>
        ///             if you're clearing this.
        ///         </param>
        /// <param name="unIPServer">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>
        ///         : The IP of the game server in host order, i.e 127.0.0.1 == 0x7f000001.</param>
        /// <param name="usPortServer">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#uint16" class="bb_apilink">uint16</a>
        ///         : The connection port of the game server, in host order.</param>
        public static void AdvertiseGame(SteamId steamIDGameServer, uint unIPServer, ushort usPortServer) => Instance.AdvertiseGame(steamIDGameServer, unIPServer, usPortServer);
        /// <summary>
        /// <code>
        ///     SteamAPICall_t RequestEncryptedAppTicket( void *pDataToInclude, int cbDataToInclude );
        /// </code>
        /// 
        /// <br />
        /// Requests an application ticket encrypted with the secret "encrypted app ticket key".<br />
        /// <br />
        /// The encryption key can be obtained from the
        /// <a href="https://partner.steamgames.com/apps/sdkauth/" target="_blank" rel="noreferrer">Encrypted App Ticket Key</a>
        /// page on the App Admin for your app.<br />
        /// <br />
        /// There can only be one
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#EncryptedAppTicketResponse_t" class="bb_apilink">EncryptedAppTicketResponse_t</a>
        /// pending, and this call is subject to a 60 second rate limit.<br />
        /// <br />
        /// After receiving the response you should call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#GetEncryptedAppTicket" class="bb_apilink">ISteamUser::GetEncryptedAppTicket</a>
        /// to get the ticket data, and then you need to send it to a secure server to be decrypted with the
        /// <a href="https://partner.steamgames.com/doc/api/SteamEncryptedAppTicket" class="bb_apilink">SteamEncryptedAppTicket</a>
        /// functions.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a>
        /// to be used with a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#EncryptedAppTicketResponse_t" class="bb_apilink">EncryptedAppTicketResponse_t</a>
        /// call result.<br />
        /// <br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     class CEncryptedAppTicketExample { public: void RetrieveEncryptedAppTicket(); private: void
        ///     OnEncryptedAppTicketResponse( EncryptedAppTicketResponse_t *pEncryptedAppTicketResponse, bool
        ///     bIOFailure ); CCallResult&lt; CEncryptedAppTicketExample, EncryptedAppTicketResponse_t &gt;
        ///     m_EncryptedAppTicketResponseCallResult; }; void
        ///     CEncryptedAppTicketExample::RetrieveEncryptedAppTicket() { SteamAPICall_t hSteamAPICall =
        ///     SteamUser()-&gt;RequestEncryptedAppTicket( &amp;k_unSecretData, sizeof( k_unSecretData ) );
        ///     m_EncryptedAppTicketResponseCallResult.Set( hSteamAPICall, this,
        ///     &amp;CEncryptedAppTicketExample::OnEncryptedAppTicketResponse ); } void
        ///     CEncryptedAppTicketExample::OnEncryptedAppTicketResponse( EncryptedAppTicketResponse_t
        ///     *pEncryptedAppTicketResponse, bool bIOFailure ) { if ( bIOFailure ) { printf( "There has been an
        ///     IO Failure when requesting the Encrypted App Ticket.\n" ); return; } switch (
        ///     pEncryptedAppTicketResponse-&gt;m_eResult ) { case k_EResultOK: { uint8 rgubTicket[1024]; uint32
        ///     cubTicket; if ( SteamUser()-&gt;GetEncryptedAppTicket( rgubTicket, sizeof( rgubTicket ),
        ///     &amp;cubTicket ) ) { // Normally at this point you would transmit the encrypted ticket to a
        ///     trusted service that knows the decryption key // This code is just to demonstrate the ticket
        ///     decrypting library DecryptTicket( rgubTicket, cubTicket ); } else printf( "GetEncryptedAppTicket
        ///     failed.\n" ); } break; case k_EResultNoConnection: printf( "Calling RequestEncryptedAppTicket
        ///     while not connected to steam results in this error.\n" ); break; case k_EResultDuplicateRequest:
        ///     printf( "Calling RequestEncryptedAppTicket while there is already a pending request results in
        ///     this error.\n" ); break; case k_EResultLimitExceeded: printf( "Calling RequestEncryptedAppTicket
        ///     more than once per minute returns this error.\n" ); break; } }
        /// </code>
        /// </summary>
        /// <param name="pDataToInclude">void *: The data which will be encrypted into the ticket.</param>
        /// <param name="cbDataToInclude">int: 
        ///             The total size in bytes of
        ///             <code class="bb_code bb_code_inline nohighlight">pDataToInclude</code>.
        ///         </param>
        public static SteamAPICall RequestEncryptedAppTicket(void* pDataToInclude, int cbDataToInclude) => Instance.RequestEncryptedAppTicket(pDataToInclude, cbDataToInclude);
        /// <summary>
        /// <code>
        ///     bool GetEncryptedAppTicket( void *pTicket, int cbMaxTicket, uint32 *pcbTicket );
        /// </code>
        /// 
        /// <br />
        /// Retrieve an encrypted ticket.<br />
        /// <br />
        /// This should be called after requesting an encrypted app ticket with
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#RequestEncryptedAppTicket" class="bb_apilink">ISteamUser::RequestEncryptedAppTicket</a>
        /// and receiving the
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#EncryptedAppTicketResponse_t" class="bb_apilink">EncryptedAppTicketResponse_t</a>
        /// call result.<br />
        /// <br />
        /// You should then pass this encrypted ticket to your secure servers to be decrypted using your secret
        /// key using
        /// <a href="https://partner.steamgames.com/doc/api/SteamEncryptedAppTicket#BDecryptTicket" class="bb_apilink">SteamEncryptedAppTicket::BDecryptTicket</a>.<br />
        /// <br />
        /// <b>NOTE:</b> If you call this without calling
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#RequestEncryptedAppTicket" class="bb_apilink">ISteamUser::RequestEncryptedAppTicket</a>, the call may succeed but you will likely get a stale ticket.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the call successfully returned an app ticket into
        /// <code class="bb_code bb_code_inline nohighlight">pTicket</code>.<br />
        /// <b>false</b> under the following conditions:<br />
        /// <ul class="bb_ul">
        ///     <li>
        ///         <code class="bb_code bb_code_inline nohighlight">pcbTicket</code> is <strong>NULL</strong><br />
        ///     </li>
        ///     <li>
        ///         <code class="bb_code bb_code_inline nohighlight">pTicket</code> is <strong>NULL</strong><br />
        ///     </li>
        ///     <li>
        ///         <code class="bb_code bb_code_inline nohighlight">pTicket</code> is too small to hold this
        ///         ticket.<br />
        ///     </li>
        ///     <li>
        ///         There was no ticket available. (Did you wait for
        ///         <a href="https://partner.steamgames.com/doc/api/ISteamUser#EncryptedAppTicketResponse_t" class="bb_apilink">EncryptedAppTicketResponse_t</a>?)
        ///     </li>
        /// </ul>
        /// </summary>
        /// <param name="pTicket">void *: The encrypted app ticket is copied into this buffer.</param>
        /// <param name="cbMaxTicket">int: 
        ///             The total size of the
        ///             <code class="bb_code bb_code_inline nohighlight">pTicket</code> buffer in bytes.
        ///         </param>
        /// <param name="pcbTicket">
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>
        ///             *
        ///         : 
        ///             Returns the number of bytes copied into
        ///             <code class="bb_code bb_code_inline nohighlight">pTicket</code>.
        ///         </param>
        public static bool GetEncryptedAppTicket(void* pTicket, int cbMaxTicket, uint* pcbTicket) => Instance.GetEncryptedAppTicket(pTicket, cbMaxTicket, pcbTicket);
        /// <summary>
        /// <code>int GetGameBadgeLevel( int nSeries, bool bFoil );</code>
        /// 
        /// <br />
        /// Gets the level of the users Steam badge for your game.<br />
        /// <br />
        /// The user can have two different badges for a series; the regular badge (max level 5) and the foil
        /// badge (max level 1).<br />
        /// <br />
        /// <b>Returns:</b> int<br />
        /// The level of the badge, 0 if they don't have it.
        /// </summary>
        /// <param name="nSeries">int: If you only have one set of cards, the series will be <b>1</b>.</param>
        /// <param name="bFoil">bool: Check if they have received the foil badge.</param>
        public static int GetGameBadgeLevel(int nSeries, bool bFoil) => Instance.GetGameBadgeLevel(nSeries, bFoil);
        /// <summary>
        /// <code>int GetPlayerSteamLevel();</code>
        /// Gets the Steam level of the user, as shown on their Steam community profile.<br />
        /// <br />
        /// <b>Returns:</b> int<br />
        /// The level of the current user.
        /// </summary>
        /// 
        public static int GetPlayerSteamLevel() => Instance.GetPlayerSteamLevel();
        /// <summary>
        /// <code>SteamAPICall_t RequestStoreAuthURL( const char *pchRedirectURL );</code>
        /// 
        /// <br />
        /// Requests a URL which authenticates an in-game browser for store check-out, and then redirects to the
        /// specified URL.<br />
        /// <br />
        /// As long as the in-game browser accepts and handles session cookies, Steam microtransaction checkout
        /// pages will automatically recognize the user instead of presenting a login page.<br />
        /// <br />
        /// <b>NOTE:</b> The URL has a very short lifetime to prevent history-snooping attacks, so you
        /// should only call this API when you are about to launch the browser, or else immediately navigate to
        /// the result URL using a hidden browser window.<br />
        /// <br />
        /// <b>NOTE:</b> The resulting authorization cookie has an expiration time of one day, so it
        /// would be a good idea to request and visit a new auth URL every 12 hours.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a>
        /// to be used with a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#StoreAuthURLResponse_t" class="bb_apilink">StoreAuthURLResponse_t</a>
        /// call result.<br />
        /// Returns
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#k_uAPICallInvalid" class="bb_apilink">k_uAPICallInvalid</a>
        /// if no connection to the Steam servers could be made.
        /// </summary>
        /// <param name="pchRedirectURL">const char *: </param>
        public static SteamAPICall RequestStoreAuthURL(UTF8StringPtr pchRedirectURL) => Instance.RequestStoreAuthURL(pchRedirectURL);
        /// <summary>
        /// <code>bool BIsPhoneVerified();</code>
        /// Checks whether the current user has verified their phone number.<br />
        /// <br />
        /// See the
        /// <a href="https://support.steampowered.com/kb_article.php?ref=8625-wrah-9030" target="_blank" rel="noreferrer">Steam Guard Mobile Authenticator</a>
        /// page on the customer facing Steam Support site for more information.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the current user has phone verification enabled; otherwise,
        /// <b>false</b>.
        /// </summary>
        /// 
        public static bool BIsPhoneVerified() => Instance.BIsPhoneVerified();
        /// <summary>
        /// <code>bool BIsTwoFactorEnabled();</code>
        /// Checks whether the current user has Steam Guard two factor authentication enabled on their
        /// account.<br />
        /// <br />
        /// See the
        /// <a href="https://support.steampowered.com/kb_article.php?ref=8625-wrah-9030" target="_blank" rel="noreferrer">Steam Guard Mobile Authenticator</a>
        /// page on the customer facing Steam Support site for more information.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the current user has two factor authentication enabled; otherwise,
        /// <b>false</b>.
        /// </summary>
        /// 
        public static bool BIsTwoFactorEnabled() => Instance.BIsTwoFactorEnabled();
        /// <summary>
        /// <code>bool BIsPhoneIdentifying();</code>
        /// Checks whether the user's phone number is used to uniquely identify them.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the current user's phone uniquely verifies their identity; otherwise,
        /// <b>false</b>.
        /// </summary>
        /// 
        public static bool BIsPhoneIdentifying() => Instance.BIsPhoneIdentifying();
        /// <summary>
        /// <code>bool BIsPhoneRequiringVerification();</code>
        /// Checks whether the current user's phone number is awaiting (re)verification.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if current user's phone is requiring verification; otherwise,
        /// <b>false</b>.
        /// </summary>
        /// 
        public static bool BIsPhoneRequiringVerification() => Instance.BIsPhoneRequiringVerification();
        /// missing documentation
        public static SteamAPICall GetMarketEligibility() => Instance.GetMarketEligibility();
        /// <summary>
        /// <code>SteamAPICall_t GetDurationControl();</code>
        /// <br />
        /// Retrieves anti indulgence / duration control for current user / game combination.<br />
        /// <br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a>
        /// to be used with a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#DurationControl_t" class="bb_apilink">DurationControl_t</a>
        /// call result.<br />
        /// Returns
        /// <a href="https://partner.steamgames.com/doc/api/steam_api#k_uAPICallInvalid" class="bb_apilink">k_uAPICallInvalid</a>
        /// if no connection to the Steam servers could be made.<br />
        /// <br />
        /// <b>Associated Functions:</b><br />
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#BSetDurationControlOnlineState" class="bb_apilink">ISteamUser::BSetDurationControlOnlineState</a>
        /// </summary>
        /// 
        public static SteamAPICall GetDurationControl() => Instance.GetDurationControl();
        /// <summary>
        /// <code>
        ///     bool BSetDurationControlOnlineState( EDurationControlOnlineState eNewState );
        /// </code>
        /// Allows the game to specify the offline/online gameplay state for steam china duration control.<br />
        /// <br />
        /// <b>Parameters:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#EDurationControlOnlineState" class="bb_apilink">EDurationControlOnlineState</a><br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the online state was set successfully; otherwise,
        /// <b>false</b>.<br />
        /// <br />
        /// <b>Associated Functions:</b><br />
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#GetDurationControl" class="bb_apilink">ISteamUser::GetDurationControl</a>
        /// </summary>
        /// 
        public static bool BSetDurationControlOnlineState(DurationControlOnlineState eNewState) => Instance.BSetDurationControlOnlineState(eNewState);
    }
}