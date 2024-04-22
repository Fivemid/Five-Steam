using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamUtils
    {
        public static ISteamUtils.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamUtils_v010", CallingConvention = Platform.CC)]
        private static extern ISteamUtils.Instance Accessor();
        /// <summary><code>uint32 GetSecondsSinceAppActive();</code>Returns the number of seconds since the application was active.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a></summary>
        /// 
        public static uint GetSecondsSinceAppActive() => Instance.GetSecondsSinceAppActive();
        /// <summary><code>uint32 GetSecondsSinceComputerActive();</code>Returns the number of seconds since the user last moved the mouse.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a></summary>
        /// 
        public static uint GetSecondsSinceComputerActive() => Instance.GetSecondsSinceComputerActive();
        /// <summary><code>EUniverse GetConnectedUniverse();</code>Gets the universe that the current client is connecting to. (Valve use only.)<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#EUniverse" class="bb_apilink">EUniverse</a><br />
        /// [type]EUniverse[/type]</summary>
        /// 
        public static Universe GetConnectedUniverse() => Instance.GetConnectedUniverse();
        /// <summary><code>uint32 GetServerRealTime();</code>Returns the Steam server time in Unix epoch format. (Number of seconds since Jan 1, 1970 UTC)<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a></summary>
        /// 
        public static uint GetServerRealTime() => Instance.GetServerRealTime();
        /// <summary><code>const char * GetIPCountry();</code>Returns the 2 digit ISO 3166-1-alpha-2 format country code which client is running in.<br />
        /// e.g "US" or "UK".<br />
        /// <br />
        /// This is looked up via an IP-to-location database.<br />
        /// <br />
        /// <b>Returns:</b> const char *</summary>
        /// 
        public static UTF8StringPtr GetIPCountry() => Instance.GetIPCountry();
        /// <summary><code>bool GetImageSize( int iImage, uint32 *pnWidth, uint32 *pnHeight );</code><br />
        /// Gets the size of a Steam image handle.<br />
        /// <br />
        /// This must be called before calling <a href="https://partner.steamgames.com/doc/api/ISteamUtils#GetImageRGBA" class="bb_apilink">ISteamUtils::GetImageRGBA</a> to create an appropriately sized buffer that will be filled with the raw image data.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success if the image handle is valid and the sizes were filled out, otherwise <b>false</b>.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetSmallFriendAvatar" class="bb_apilink">ISteamFriends::GetSmallFriendAvatar</a>, <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetMediumFriendAvatar" class="bb_apilink">ISteamFriends::GetMediumFriendAvatar</a>, <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetLargeFriendAvatar" class="bb_apilink">ISteamFriends::GetLargeFriendAvatar</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetAchievementIcon" class="bb_apilink">ISteamUserStats::GetAchievementIcon</a></summary>
        /// <param name="iImage">int: The image handle to get the size for.</param>
        /// <param name="pnWidth"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a> *: Returns the width of the image.</param>
        /// <param name="pnHeight"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a> *: Returns the height of the image.</param>
        public static bool GetImageSize(int iImage, uint* pnWidth, uint* pnHeight) => Instance.GetImageSize(iImage, pnWidth, pnHeight);
        /// <summary><code>bool GetImageRGBA( int iImage, uint8 *pubDest, int nDestBufferSize );</code><br />
        /// Gets the image bytes from an image handle.<br />
        /// <br />
        /// Prior to calling this you must get the size of the image by calling <a href="https://partner.steamgames.com/doc/api/ISteamUtils#GetImageSize" class="bb_apilink">ISteamUtils::GetImageSize</a> so that you can create your buffer with an appropriate size. You can then allocate your buffer with the width and height as: width * height * 4. The image is provided in RGBA format. This call can be somewhat expensive as it converts from the compressed type (JPG, PNG, TGA) and provides no internal caching of returned buffer, thus it is highly recommended to only call this once per image handle and cache the result. This function is only used for Steam Avatars and Achievement images and those are not expected to change mid game.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success if the image handle is valid and the buffer was filled out, otherwise <b>false</b>.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetSmallFriendAvatar" class="bb_apilink">ISteamFriends::GetSmallFriendAvatar</a>, <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetMediumFriendAvatar" class="bb_apilink">ISteamFriends::GetMediumFriendAvatar</a>, <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetLargeFriendAvatar" class="bb_apilink">ISteamFriends::GetLargeFriendAvatar</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetAchievementIcon" class="bb_apilink">ISteamUserStats::GetAchievementIcon</a><br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>HGAMETEXTURE GetSteamImageAsTexture( int iImage )
        /// {
        /// 	HGAMETEXTURE hTexture = 0;
        /// 
        /// 	// You should first check if you have already cached this image using something like a dictionary/map
        /// 	// with iImage as the key and then return the texture handle associated with it if it exists.
        /// 	// If it doesn't exist, continue on, and add the texture to the map before returning at the end of the function.
        /// 
        /// 	// If we have to check the size of the image.
        /// 	uint32 uAvatarWidth, uAvatarHeight;
        /// 	bool success = SteamUtils()-&gt;GetImageSize( iImage, &amp;uAvatarWidth, &amp;uAvatarHeight );
        /// 	if ( !success ) {
        /// 		// Log a warning message.
        /// 		return hTexture;
        /// 	}
        /// 
        /// 	// Get the actual raw RGBA data from Steam and turn it into a texture in our game engine
        /// 	const int uImageSizeInBytes = uAvatarWidth * uAvatarHeight * 4;
        /// 	uint8 *pAvatarRGBA = new uint8[uImageSizeInBytes];
        /// 	success = SteamUtils()-&gt;GetImageRGBA( iImage, pAvatarRGBA, uImageSizeInBytes );
        /// 	if( !success )
        /// 	{
        /// 		// Do something to convert the RGBA texture into your internal texture format for displaying.
        /// 		// hTexture = m_pGameEngine-&gt;HCreateTexture( pAvatarRGBA, uAvatarWidth, uAvatarHeight );
        /// 		// And add the texture to the cache
        /// 	}
        /// 
        /// 	// Don't forget to free the memory!
        /// 	delete[] pAvatarRGBA;
        /// 
        /// 	return hTexture;
        /// }</code></summary>
        /// <param name="iImage">int: The handle to the image that will be obtained.</param>
        /// <param name="pubDest"><a href="https://partner.steamgames.com/doc/api/steam_api#uint8" class="bb_apilink">uint8</a> *: The buffer that will be filled.</param>
        /// <param name="nDestBufferSize">int: The total size of the <code class="bb_code bb_code_inline nohighlight">pubDest</code> buffer.</param>
        public static bool GetImageRGBA(int iImage, byte* pubDest, int nDestBufferSize) => Instance.GetImageRGBA(iImage, pubDest, nDestBufferSize);
        /// <summary><code>uint8 GetCurrentBatteryPower();</code>Gets the current amount of battery power on the computer.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#uint8" class="bb_apilink">uint8</a><br />
        /// The current battery power ranging between [0..100]%. Returns 255 when the user is on AC power.</summary>
        /// 
        public static byte GetCurrentBatteryPower() => Instance.GetCurrentBatteryPower();
        /// <summary><code>uint32 GetAppID();</code>Gets the App ID of the current process.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a><br />
        /// Returns the AppId.</summary>
        /// 
        public static uint GetAppID() => Instance.GetAppID();
        /// <summary><code>void SetOverlayNotificationPosition( ENotificationPosition eNotificationPosition );</code><br />
        /// Sets which corner the Steam overlay notification popup should display itself in.<br />
        /// <br />
        /// You can also set the distance from the specified corner by using <a href="https://partner.steamgames.com/doc/api/ISteamUtils#SetOverlayNotificationInset" class="bb_apilink">ISteamUtils::SetOverlayNotificationInset</a>.<br />
        /// <br />
        /// This position is per-game and is reset each launch.</summary>
        /// <param name="eNotificationPosition"><a href="https://partner.steamgames.com/doc/api/steam_api#ENotificationPosition" class="bb_apilink">ENotificationPosition</a>: </param>
        public static void SetOverlayNotificationPosition(NotificationPosition eNotificationPosition) => Instance.SetOverlayNotificationPosition(eNotificationPosition);
        /// <summary><code>bool IsAPICallCompleted( SteamAPICall_t hSteamAPICall, bool *pbFailed );</code><br />
        /// Checks if an API Call is completed. Provides the backend of the CallResult wrapper.<br />
        /// <br />
        /// It's generally not recommended that you use this yourself.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the API Call is valid and has completed, otherwise <b>false</b>.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUtils#GetAPICallResult" class="bb_apilink">ISteamUtils::GetAPICallResult</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUtils#GetAPICallFailureReason" class="bb_apilink">ISteamUtils::GetAPICallFailureReason</a></summary>
        /// <param name="hSteamAPICall"><a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a>: The API Call handle to check.</param>
        /// <param name="pbFailed">bool *: Returns whether the API call has encountered a failure (<b>true</b>) or not (<b>false</b>).</param>
        public static bool IsAPICallCompleted(SteamAPICall hSteamAPICall, bool* pbFailed) => Instance.IsAPICallCompleted(hSteamAPICall, pbFailed);
        /// <summary><code>ESteamAPICallFailure GetAPICallFailureReason( SteamAPICall_t hSteamAPICall );</code><br />
        /// Used to get the failure reason of a call result.<br />
        /// <br />
        /// The primary usage for this function is debugging. The failure reasons are typically out of your control and tend to not be very important. Just keep retrying your API Call until it works.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUtils#ESteamAPICallFailure" class="bb_apilink">ESteamAPICallFailure</a><br />
        /// [type]ESteamAPICallFailure[/type]<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUtils#IsAPICallCompleted" class="bb_apilink">ISteamUtils::IsAPICallCompleted</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUtils#GetAPICallResult" class="bb_apilink">ISteamUtils::GetAPICallResult</a><br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>void CHTMLSurface::OnBrowserReady( HTML_BrowserReady_t *pBrowserReady, bool bIOFailure )
        /// {
        /// 	if ( bIOFailure ) {
        /// 		SteamUtils()-&gt;GetAPICallFailureReason( handle ); // handle must be stored separately.
        /// 		return;
        /// 	}
        /// }</code></summary>
        /// <param name="hSteamAPICall"><a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a>: The Steam API Call handle to check the failure for.</param>
        public static SteamAPICallFailure GetAPICallFailureReason(SteamAPICall hSteamAPICall) => Instance.GetAPICallFailureReason(hSteamAPICall);
        /// <summary><code>bool GetAPICallResult( SteamAPICall_t hSteamAPICall, void *pCallback, int cubCallback, int iCallbackExpected, bool *pbFailed );</code><br />
        /// Gets the content of a completed API Call. Provided for the backend of the CallResult wrapper.<br />
        /// <br />
        /// It's generally not recommended that you use this manually.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success if the API Call is valid and has completed, otherwise <b>false</b>.<br />
        /// <br />
        /// If the call is successful, it copies the callback into <code class="bb_code bb_code_inline nohighlight">pCallback</code> and returns failures in <code class="bb_code bb_code_inline nohighlight">pbFailed</code>.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUtils#IsAPICallCompleted" class="bb_apilink">ISteamUtils::IsAPICallCompleted</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUtils#GetAPICallFailureReason" class="bb_apilink">ISteamUtils::GetAPICallFailureReason</a></summary>
        /// <param name="hSteamAPICall"><a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a>: The handle to the API Call.</param>
        /// <param name="pCallback">void *: Returns the callback into the preallocated memory provided.</param>
        /// <param name="cubCallback">int: The size of pCallback that you are passing in.</param>
        /// <param name="iCallbackExpected">int: The k_iCallback number associated with the callback.</param>
        /// <param name="pbFailed">bool *: Returns if the API call has encountered a failure.</param>
        public static bool GetAPICallResult(SteamAPICall hSteamAPICall, void* pCallback, int cubCallback, int iCallbackExpected, bool* pbFailed) => Instance.GetAPICallResult(hSteamAPICall, pCallback, cubCallback, iCallbackExpected, pbFailed);
        /// <summary><code>uint32 GetIPCCallCount();</code>Returns the number of IPC calls made since the last time this function was called.<br />
        /// <br />
        /// Used for perf debugging so you can determine how many IPC (Inter-Process Communication) calls your game makes per frame<br />
        /// Every IPC call is at minimum a thread context switch if not a process one so you want to rate control how often you do them.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a></summary>
        /// 
        public static uint GetIPCCallCount() => Instance.GetIPCCallCount();
        /// <summary><code>void SetWarningMessageHook( SteamAPIWarningMessageHook_t pFunction );</code><br />
        /// Sets a warning message hook to receive SteamAPI warnings and info messages in a callback function.<br />
        /// <br />
        /// The function prototype must match the definition in SteamAPIWarningMessageHook_t. This includes the extern "C" linkage and __cdecl calling convention.<br />
        /// <br />
        /// 'int nSeverity' is the severity; 0 for msg, 1 for warning. If you are running in through a debugger only warnings will be sent. If you add -debug_steamapi to the command-line then informational messages will also be sent.<br />
        /// 'const char * pchDebugText' is the text of the message.<br />
        /// Callbacks will occur directly after the API function is called that generated the warning or message<br />
        /// <br />
        /// Passing NULL will unhook.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>extern "C" void __cdecl SteamAPIDebugTextHook( int nSeverity, const char *pchDebugText )
        /// {
        /// 	::OutputDebugString( pchDebugText );
        /// 	if ( nSeverity &gt;= 1 )
        /// 	{
        /// 		// place to set a breakpoint for catching API errors
        /// 		int x = 3;
        /// 		x = x;
        /// 	}
        /// }
        /// 
        /// void EnableWarningMessageHook()
        /// {
        /// 	SteamUtils()-&gt;SetWarningMessageHook( &amp;SteamAPIDebugTextHook );
        /// }</code></summary>
        /// <param name="pFunction">SteamAPIWarningMessageHook_t: Function pointer to the callback function.</param>
        public static void SetWarningMessageHook(Unknown pFunction) => Instance.SetWarningMessageHook(pFunction);
        /// <summary><code>bool IsOverlayEnabled();</code>Checks if the <a href="https://partner.steamgames.com/doc/features/overlay" class="bb_doclink">Steam Overlay</a> is running &amp; the user can access it.<br />
        /// <br />
        /// The overlay process could take a few seconds to start &amp; hook the game process, so this function will initially return false while the overlay is loading.<br />
        /// <br />
        /// <b>Returns:</b> bool</summary>
        /// 
        public static bool IsOverlayEnabled() => Instance.IsOverlayEnabled();
        /// <summary><code>bool BOverlayNeedsPresent();</code>Checks if the Overlay needs a present. Only required if using event driven render updates.<br />
        /// <br />
        /// Typically this call is unneeded if your game has a constantly running frame loop that calls the D3D Present API, or OGL SwapBuffers API every frame as is the case in most games. However, if you have a game that only refreshes the screen on an event driven basis then that can break the overlay, as it uses your Present/SwapBuffers calls to drive it's internal frame loop and it may also need to Present() to the screen any time a notification happens or when the overlay is brought up over the game by a user. You can use this API to ask the overlay if it currently need a present in that case, and then you can check for this periodically (roughly 33hz is desirable) and make sure you refresh the screen with Present or SwapBuffers to allow the overlay to do its work.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the overlay needs you to refresh the screen, otherwise <b>false</b>.</summary>
        /// 
        public static bool BOverlayNeedsPresent() => Instance.BOverlayNeedsPresent();
        /// <summary><code>SteamAPICall_t CheckFileSignature( const char *szFileName );</code><br />
        /// Deprecated.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamUtils#CheckFileSignature_t" class="bb_apilink">CheckFileSignature_t</a> call result.</summary>
        /// <param name="szFileName">const char *: .</param>
        public static SteamAPICall CheckFileSignature(UTF8StringPtr szFileName) => Instance.CheckFileSignature(szFileName);
        /// <summary><code>bool ShowGamepadTextInput( EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, const char *pchDescription, uint32 unCharMax, const char *pchExistingText );</code><br />
        /// Activates the Big Picture text input dialog which only supports gamepad input.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the big picture overlay is running; otherwise, <b>false</b>.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUtils#GetEnteredGamepadTextLength" class="bb_apilink">ISteamUtils::GetEnteredGamepadTextLength</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUtils#GetEnteredGamepadTextInput" class="bb_apilink">ISteamUtils::GetEnteredGamepadTextInput</a></summary>
        /// <param name="eInputMode"><a href="https://partner.steamgames.com/doc/api/ISteamUtils#EGamepadTextInputMode" class="bb_apilink">EGamepadTextInputMode</a>: Selects the input mode to use, either Normal or Password (hidden text)</param>
        /// <param name="eLineInputMode"><a href="https://partner.steamgames.com/doc/api/ISteamUtils#EGamepadTextInputLineMode" class="bb_apilink">EGamepadTextInputLineMode</a>: Controls whether to use single or multi line input.</param>
        /// <param name="pchDescription">const char *: Sets the description that should inform the user what the input dialog is for.</param>
        /// <param name="unCharMax"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The maximum number of characters that the user can input.</param>
        /// <param name="pchExistingText">const char *: Sets the preexisting text which the user can edit.</param>
        public static bool ShowGamepadTextInput(GamepadTextInputMode eInputMode, GamepadTextInputLineMode eLineInputMode, UTF8StringPtr pchDescription, uint unCharMax, UTF8StringPtr pchExistingText) => Instance.ShowGamepadTextInput(eInputMode, eLineInputMode, pchDescription, unCharMax, pchExistingText);
        /// <summary><code>uint32 GetEnteredGamepadTextLength();</code>Gets the length of the gamepad text input from the Big Picture overlay.<br />
        /// <br />
        /// This must be called within the <a href="https://partner.steamgames.com/doc/api/ISteamUtils#GamepadTextInputDismissed_t" class="bb_apilink">GamepadTextInputDismissed_t</a> callback, and only if <code class="bb_code bb_code_inline nohighlight">GamepadTextInputDismissed_t.m_bSubmitted</code> is true.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a><br />
        /// <br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUtils#ShowGamepadTextInput" class="bb_apilink">ISteamUtils::ShowGamepadTextInput</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUtils#GetEnteredGamepadTextInput" class="bb_apilink">ISteamUtils::GetEnteredGamepadTextInput</a><br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>void OnGamepadTextInputDismissed_t( GamepadTextInputDismissed_t* pCallback )
        /// {
        ///     // The user canceled,
        ///     if ( !pCallback.m_bSubmitted )
        ///         return;
        /// 
        ///     // Use some max input length that we passed into ShowGamepadTextInput, +1 for the null terminator.
        ///     const uint32 MAX_INPUT_LENGTH = 64 + 1;
        /// 
        ///     uint32 length = SteamUtils()-&gt;GetEnteredGamepadTextLength();
        ///     const char* szTextInput[MAX_INPUT_LENGTH];
        ///     bool success = SteamUtils()-&gt;GetEnteredGamepadTextInput( szTextInput, length );
        /// 
        ///     if ( !success )
        ///     {
        ///         // Log an error. This should only ever happen if length is &gt; MaxInputLength
        ///         return;
        ///     }
        /// 
        ///     // Display the updated string
        /// }</code></summary>
        /// 
        public static uint GetEnteredGamepadTextLength() => Instance.GetEnteredGamepadTextLength();
        /// <summary><code>bool GetEnteredGamepadTextInput( char *pchText, uint32 cchText );</code><br />
        /// Gets the gamepad text input from the Big Picture overlay.<br />
        /// <br />
        /// This must be called within the <a href="https://partner.steamgames.com/doc/api/ISteamUtils#GamepadTextInputDismissed_t" class="bb_apilink">GamepadTextInputDismissed_t</a> callback, and only if <code class="bb_code bb_code_inline nohighlight">GamepadTextInputDismissed_t.m_bSubmitted</code> is true.<br />
        /// <br />
        /// Provides the text input as UTF-8.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if there was text to receive and <code class="bb_code bb_code_inline nohighlight">cchText</code> is the same size as GamepadTextInputDismissed_t.m_unSubmittedText; otherwise, <b>false</b>.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUtils#ShowGamepadTextInput" class="bb_apilink">ISteamUtils::ShowGamepadTextInput</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUtils#GetEnteredGamepadTextLength" class="bb_apilink">ISteamUtils::GetEnteredGamepadTextLength</a><br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>void OnGamepadTextInputDismissed_t( GamepadTextInputDismissed_t* pCallback )
        /// {
        ///     // The user canceled,
        ///     if ( !pCallback.m_bSubmitted )
        ///         return;
        /// 
        ///     // Use some max input length that we passed into ShowGamepadTextInput, +1 for the null terminator.
        ///     const uint32 MAX_INPUT_LENGTH = 64 + 1;
        /// 
        ///     uint32 length = SteamUtils()-&gt;GetEnteredGamepadTextLength();
        ///     char* szTextInput[MAX_INPUT_LENGTH];
        ///     bool success = SteamUtils()-&gt;GetEnteredGamepadTextInput( szTextInput, length );
        /// 
        ///     if ( !success )
        ///     {
        ///         // Log an error. This should only ever happen if length is &gt; MaxInputLength
        ///         return;
        ///     }
        /// 
        ///     // Display the updated string
        /// }</code></summary>
        /// <param name="pchText">char *: A preallocated buffer to copy the text input string into.</param>
        /// <param name="cchText"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The size of the <code class="bb_code bb_code_inline nohighlight">pchText</code> buffer.</param>
        public static bool GetEnteredGamepadTextInput(char* pchText, uint cchText) => Instance.GetEnteredGamepadTextInput(pchText, cchText);
        /// <summary><code>const char * GetSteamUILanguage();</code>Returns the language the steam client is running in.<br />
        /// <br />
        /// You probably want <a href="https://partner.steamgames.com/doc/api/ISteamApps#GetCurrentGameLanguage" class="bb_apilink">ISteamApps::GetCurrentGameLanguage</a> instead, this should only be used in very special cases.<br />
        /// <br />
        /// For a full list of languages see <a href="https://partner.steamgames.com/doc/store/localization/languages" class="bb_doclink">Supported Languages</a>.<br />
        /// <br />
        /// <b>Returns:</b> const char *<br />
        /// <br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamApps#GetCurrentGameLanguage" class="bb_apilink">ISteamApps::GetCurrentGameLanguage</a>, <a href="https://partner.steamgames.com/doc/api/ISteamApps#GetAvailableGameLanguages" class="bb_apilink">ISteamApps::GetAvailableGameLanguages</a></summary>
        /// 
        public static UTF8StringPtr GetSteamUILanguage() => Instance.GetSteamUILanguage();
        /// <summary><code>bool IsSteamRunningInVR();</code>Checks if Steam is running in VR mode.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if Steam itself is running in VR mode; otherwise, <b>false</b>.</summary>
        /// 
        public static bool IsSteamRunningInVR() => Instance.IsSteamRunningInVR();
        /// <summary><code>void SetOverlayNotificationInset( int nHorizontalInset, int nVerticalInset );</code><br />
        /// Sets the inset of the overlay notification from the corner specified by <a href="https://partner.steamgames.com/doc/api/ISteamUtils#SetOverlayNotificationPosition" class="bb_apilink">ISteamUtils::SetOverlayNotificationPosition</a>.<br />
        /// <br />
        /// A value of (0, 0) resets the position into the corner.<br />
        /// <br />
        /// This position is per-game and is reset each launch.</summary>
        /// <param name="nHorizontalInset">int: The horizontal (left-right) distance in pixels from the corner.</param>
        /// <param name="nVerticalInset">int: The vertical (up-down) distance in pixels from the corner.</param>
        public static void SetOverlayNotificationInset(int nHorizontalInset, int nVerticalInset) => Instance.SetOverlayNotificationInset(nHorizontalInset, nVerticalInset);
        /// <summary><code>bool IsSteamInBigPictureMode();</code>Checks if Steam &amp; the Steam Overlay are running in Big Picture mode.<br />
        /// <br />
        /// Games must be launched through the Steam client to enable the Big Picture overlay.<br />
        /// During development, a game can be added as a non-steam game to the developer's library to test this feature.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the Big Picture overlay is available; otherwise, <b>false</b>.<br />
        /// This will always return <b>false</b> if your app is not the 'game' <a href="https://partner.steamgames.com/doc/store/application#types_of_applications" class="bb_doclink">application type</a>.</summary>
        /// 
        public static bool IsSteamInBigPictureMode() => Instance.IsSteamInBigPictureMode();
        /// <summary><code>void StartVRDashboard();</code>Asks Steam to create and render the OpenVR dashboard.</summary>
        /// 
        public static void StartVRDashboard() => Instance.StartVRDashboard();
        /// <summary><code>bool IsVRHeadsetStreamingEnabled();</code>Checks if the HMD view is being streamed via Steam Remote Play.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if VR is enabled and the HMD view is currently being streamed; otherwise, <b>false</b>.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUtils#SetVRHeadsetStreamingEnabled" class="bb_apilink">ISteamUtils::SetVRHeadsetStreamingEnabled</a></summary>
        /// 
        public static bool IsVRHeadsetStreamingEnabled() => Instance.IsVRHeadsetStreamingEnabled();
        /// <summary><code>void SetVRHeadsetStreamingEnabled( bool bEnabled );</code><br />
        /// Set whether the HMD content will be streamed via Steam Remote Play.<br />
        /// <br />
        /// If this is enabled, then the scene in the HMD headset will be streamed, and remote input will not be allowed. Otherwise if this is disabled, then the application window will be streamed instead, and remote input will be allowed. VR games default to enabled unless "VRHeadsetStreaming" "0" is in the extended appinfo for a game.<br />
        /// <br />
        /// This is useful for games that have asymmetric multiplayer gameplay.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUtils#IsVRHeadsetStreamingEnabled" class="bb_apilink">ISteamUtils::IsVRHeadsetStreamingEnabled</a></summary>
        /// <param name="bEnabled">bool: Turns VR HMD Streaming on (<b>true</b>) or off (<b>false</b>).</param>
        public static void SetVRHeadsetStreamingEnabled(bool bEnabled) => Instance.SetVRHeadsetStreamingEnabled(bEnabled);
        /// <summary><code>bool IsSteamChinaLauncher();</code>Returns whether the current launcher is a Steam China launcher. You can cause the client to behave as the Steam China launcher by adding -dev -steamchina to the command line when running Steam.</summary>
        /// 
        public static bool IsSteamChinaLauncher() => Instance.IsSteamChinaLauncher();
        /// <summary><code>bool InitFilterText();</code>Initializes text filtering, loading dictionaries for the language the game is running in.<br />
        /// <br />
        /// Users can customize the text filter behavior in their <a href="https://store.steampowered.com/account/preferences#CommunityContentPreferences" target="_blank" rel="noreferrer">Steam Account preferences</a><br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if initialization succeeds, <b>false</b> if filtering is unavailable for the game's language, in which case <a href="https://partner.steamgames.com/doc/api/ISteamUtils#FilterText" class="bb_apilink">ISteamUtils::FilterText</a>() will act as a passthrough.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUtils#FilterText" class="bb_apilink">ISteamUtils::FilterText</a></summary>
        /// 
        public static bool InitFilterText(uint unFilterOptions) => Instance.InitFilterText(unFilterOptions);
        /// <summary><code>int FilterText( ETextFilteringContext eContext, CSteamID sourceSteamID, const char *pchInputMessage, char *pchOutFilteredText, uint32 nByteSizeOutFilteredText );</code>Filters the provided input message and places the filtered result into pchOutFilteredText. Legally required filtering is always applied. Additional filtering may occur, based on the context and user settings.<br />
        /// <br />
        /// <b>Returns:</b> int<br />
        /// Returns the number of characters (not bytes) filtered.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUtils#InitFilterText" class="bb_apilink">ISteamUtils::InitFilterText</a></summary>
        /// <param name="eContext"><a href="https://partner.steamgames.com/doc/api/steam_api#ETextFilteringContext" class="bb_apilink">ETextFilteringContext</a>: the type of content in the input string</param>
        /// <param name="sourceSteamID"><a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>: the Steam ID that is the source of the input string (e.g. the player with the name, or who said the chat text)</param>
        /// <param name="pchInputText">const char*: the input string that should be filtered, which can be ASCII or UTF-8</param>
        /// <param name="pchOutFilteredText">char*: where the output will be placed, even if no filtering is performed</param>
        /// <param name="nByteSizeOutFilteredText ">uint32: the size (in bytes) of pchOutFilteredText, should be at least strlen(pchInputText)+1</param>
        public static int FilterText(TextFilteringContext eContext, SteamId sourceSteamID, UTF8StringPtr pchInputMessage, char* pchOutFilteredText, uint nByteSizeOutFilteredText) => Instance.FilterText(eContext, sourceSteamID, pchInputMessage, pchOutFilteredText, nByteSizeOutFilteredText);
        /// missing documentation
        public static SteamIPv6ConnectivityState GetIPv6ConnectivityState(SteamIPv6ConnectivityProtocol eProtocol) => Instance.GetIPv6ConnectivityState(eProtocol);
        /// <summary><code>bool IsSteamRunningOnSteamDeck();</code>Checks if Steam is running on a Steam Deck device.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if Steam itself is running on a Steam Deck device; otherwise, <b>false</b>.</summary>
        /// 
        public static bool IsSteamRunningOnSteamDeck() => Instance.IsSteamRunningOnSteamDeck();
        /// <summary><code>bool ShowFloatingGamepadTextInput( EFloatingGamepadTextInputMode eKeyboardMode, int nTextFieldXPosition, int nTextFieldYPosition, int nTextFieldWidth, int nTextFieldHeight );</code><br />
        /// Opens a floating keyboard over the game content and sends OS keyboard keys directly to the game.<br />
        /// The text field position is specified in pixels relative the origin of the game window and is used to position the floating keyboard in a way that doesn't cover the text field.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the floating keyboard was shown, otherwise, <b>false</b>.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUtils#FloatingGamepadTextInputDismissed_t" class="bb_apilink">ISteamUtils::FloatingGamepadTextInputDismissed_t</a></summary>
        /// <param name="eKeyboardMode"><a href="https://partner.steamgames.com/doc/api/ISteamUtils#EFloatingGamepadTextInputMode" class="bb_apilink">EFloatingGamepadTextInputMode</a>: Selects the keyboard type to use</param>
        /// <param name="nTextFieldXPosition">int: X coordinate of text field which shouldn't be obscured by the floating keyboard</param>
        /// <param name="nTextFieldYPosition">int: Y coordinate of text field which shouldn't be obscured by the floating keyboard</param>
        /// <param name="nTextFieldWidth">int: width of text field which shouldn't be obscured by the floating keyboard</param>
        /// <param name="nTextFieldHeight ">int: height  of text field which shouldn't be obscured by the floating keyboard</param>
        public static bool ShowFloatingGamepadTextInput(FloatingGamepadTextInputMode eKeyboardMode, int nTextFieldXPosition, int nTextFieldYPosition, int nTextFieldWidth, int nTextFieldHeight) => Instance.ShowFloatingGamepadTextInput(eKeyboardMode, nTextFieldXPosition, nTextFieldYPosition, nTextFieldWidth, nTextFieldHeight);
        /// <summary><code>void SetGameLauncherMode( bool bLauncherMode);</code>In game launchers that don't have controller support you can call this to have Steam Input translate the controller input into mouse/kb to navigate the launcher</summary>
        /// <param name="bLauncherMode">bool: Whether a launcher is active or not</param>
        public static void SetGameLauncherMode(bool bLauncherMode) => Instance.SetGameLauncherMode(bLauncherMode);
        /// missing documentation
        public static bool DismissFloatingGamepadTextInput() => Instance.DismissFloatingGamepadTextInput();
        /// missing documentation
        public static bool DismissGamepadTextInput() => Instance.DismissGamepadTextInput();
    }
}