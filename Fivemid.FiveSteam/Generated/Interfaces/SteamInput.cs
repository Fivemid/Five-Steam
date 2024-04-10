using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamInput
    {
        public static ISteamInput.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamInput_v006", CallingConvention = Platform.CC)]
        private static extern ISteamInput.Instance Accessor();
        /// <summary>
        /// <code>bool Init();</code>
        /// Must be called when starting use of the
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInput" class="bb_apilink">ISteamInput</a>
        /// interface.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// Always returns <b>true</b>.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>SteamInput()-&gt;Init();</code>
        /// </summary>
        /// 
        public static bool Init(bool bExplicitlyCallRunFrame) => Instance.Init(bExplicitlyCallRunFrame);
        /// <summary>
        /// <code>bool Shutdown();</code>
        /// Must be called when ending use of the
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInput" class="bb_apilink">ISteamInput</a>
        /// interface.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// Always returns <b>true</b>.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>SteamInput()-&gt;Shutdown();</code>
        /// </summary>
        /// 
        public static bool Shutdown() => Instance.Shutdown();
        /// missing documentation
        public static bool SetInputActionManifestFilePath(UTF8StringPtr pchInputActionManifestAbsolutePath) => Instance.SetInputActionManifestFilePath(pchInputActionManifestAbsolutePath);
        /// <summary>
        /// <code>void RunFrame();</code>
        /// Synchronize API state with the latest Steam Controller inputs available. This is performed
        /// automatically by SteamAPI_RunCallbacks, but for the absolute lowest possible latency, you can call
        /// this directly before reading controller state.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>SteamInput()-&gt;RunFrame();</code>
        /// </summary>
        /// 
        public static void RunFrame(bool bReservedValue) => Instance.RunFrame(bReservedValue);
        /// missing documentation
        public static bool BWaitForData(bool bWaitForever, uint unTimeout) => Instance.BWaitForData(bWaitForever, unTimeout);
        /// missing documentation
        public static bool BNewDataAvailable() => Instance.BNewDataAvailable();
        /// <summary>
        /// <code>int GetConnectedControllers( InputHandle_t *handlesOut );</code>
        /// 
        /// <br />
        /// Enumerates currently connected controllers by filling handlesOut with controller handles.<br />
        /// <br />
        /// <b>Returns:</b> int<br />
        /// The number of handles written to
        /// <code class="bb_code bb_code_inline nohighlight">handlesOut</code>.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     InputHandle_t *inputHandles = new InputHandle_t[]; SteamInput()-&gt;GetConnectedControllers(
        ///     inputHandles );
        /// </code>
        /// </summary>
        /// <param name="handlesOut">InputHandle_t
        ///             *: 
        ///             This must point to a
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamInput#STEAM_INPUT_MAX_COUNT" class="bb_apilink">STEAM_INPUT_MAX_COUNT</a>
        ///             sized array of InputHandle_t.
        ///         </param>
        public static int GetConnectedControllers(InputHandle* handlesOut) => Instance.GetConnectedControllers(handlesOut);
        /// missing documentation
        public static void EnableDeviceCallbacks() => Instance.EnableDeviceCallbacks();
        /// missing documentation
        public static void EnableActionEventCallbacks(SteamInputActionEventCallbackPointer pCallback) => Instance.EnableActionEventCallbacks(pCallback);
        /// <summary>
        /// <code>
        ///     InputActionSetHandle_t GetActionSetHandle( const char *pszActionSetName );
        /// </code>
        /// 
        /// <br />
        /// Lookup the handle for an Action Set. Best to do this once on startup, and store the handles for all
        /// future API calls.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInput#InputActionSetHandle_t" class="bb_apilink">InputActionSetHandle_t</a><br />
        /// The handle of the specified action set.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     InputActionSetHandle_t fightingSetHandle = SteamInput()-&gt;GetActionSetHandle( "fighting" );
        /// </code>
        /// </summary>
        /// <param name="pszActionSetName">const char *: The string identifier of an action set defined in the game's VDF file.</param>
        public static InputActionSetHandle GetActionSetHandle(UTF8StringPtr pszActionSetName) => Instance.GetActionSetHandle(pszActionSetName);
        /// <summary>
        /// <code>
        ///     void ActivateActionSet( InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle );
        /// </code>
        /// 
        /// <br />
        /// Reconfigure the controller to use the specified action set (i.e. "Menu", "Walk", or "Drive").<br />
        /// <br />
        /// This is cheap, and can be safely called repeatedly. It's often easier to repeatedly call it in your
        /// state loops, instead of trying to place it in all of your state transitions.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     void updateStateLoop() { switch( currentState ) { case MENU: SteamInput()-&gt;ActivateActionSet(
        ///     inputHandle1, menuSetHandle ); doMenuStuff(); break; case WALKING:
        ///     SteamInput()-&gt;ActivateActionSet( inputHandle1, walkingSetHandle ); doWalkingStuff(); break;
        ///     case DRIVING: SteamInput()-&gt;ActivateActionSet( inputHandle1, drivingSetHandle );
        ///     doDrivingStuff(); break; case FIGHTING: SteamInput()-&gt;ActivateActionSet( inputHandle1,
        ///     fightingSetHandle ); doFightingStuff(); break; } }
        /// </code>
        /// <div class="bb_callout bb_green">
        ///     <div>
        ///         <h3>Activate All Controllers</h3>
        ///         Oftentimes, you'll want to activate all the controllers at once, rather than a single
        ///         device. For this you should use the constant
        ///         <a href="https://partner.steamgames.com/doc/api/ISteamInput#constants" class="bb_doclink">STEAM_INPUT_HANDLE_ALL_CONTROLLERS</a>
        ///         as your controller handle. You can likewise use this value in any other function that calls
        ///         for an individual controller handle.
        ///     </div>
        /// </div>
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     void updateStateLoop() { switch( currentState ) { case MENU: SteamInput()-&gt;ActivateActionSet(
        ///     STEAM_INPUT_HANDLE_ALL_CONTROLLERS, menuSetHandle ); doMenuStuff(); break; case WALKING:
        ///     SteamInput()-&gt;ActivateActionSet( STEAM_INPUT_HANDLE_ALL_CONTROLLERS, walkingSetHandle );
        ///     doWalkingStuff(); break; case DRIVING: SteamInput()-&gt;ActivateActionSet(
        ///     STEAM_INPUT_HANDLE_ALL_CONTROLLERS, drivingSetHandle ); doDrivingStuff(); break; case FIGHTING:
        ///     SteamInput()-&gt;ActivateActionSet( STEAM_INPUT_HANDLE_ALL_CONTROLLERS, fightingSetHandle );
        ///     doFightingStuff(); break; } }
        /// </code>
        /// </summary>
        /// <param name="inputHandle">InputHandle_t: The handle of the controller you want to activate an action set for.</param>
        /// <param name="actionSetHandle">InputActionSetHandle_t: The handle of the action set you want to activate.</param>
        public static void ActivateActionSet(InputHandle inputHandle, InputActionSetHandle actionSetHandle) => Instance.ActivateActionSet(inputHandle, actionSetHandle);
        /// <summary>
        /// <code>
        ///     InputActionSetHandle_t GetCurrentActionSet( InputHandle_t inputHandle );
        /// </code>
        /// 
        /// <br />
        /// Get the currently active action set for the specified controller.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInput#InputActionSetHandle_t" class="bb_apilink">InputActionSetHandle_t</a><br />
        /// The handle of the action set activated for the specified controller.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     InputActionSetHandle_t controller1Set = SteamInput()-&gt;GetCurrentActionSet(controller1Handle);
        /// </code>
        /// </summary>
        /// <param name="inputHandle">InputHandle_t: The handle of the controller you want to query.</param>
        public static InputActionSetHandle GetCurrentActionSet(InputHandle inputHandle) => Instance.GetCurrentActionSet(inputHandle);
        /// <summary>
        /// <code>
        ///     void ActivateActionSetLayer( InputHandle_t inputHandle, InputActionSetHandle_t
        ///     actionSetLayerHandle );
        /// </code>
        /// 
        /// <br />
        /// Reconfigure the controller to use the specified action set layer.<br />
        /// <br />
        /// See the
        /// <a href="https://partner.steamgames.com/doc/features/steam_controller/action_set_layers" class="bb_doclink">Action Set Layers</a>
        /// article for full details and an in-depth practical example.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     SteamInput()-&gt;ActivateActionSetLayer( inputHandle1, myActionSetLayer );
        /// </code>
        /// </summary>
        /// <param name="inputHandle">InputHandle_t: The handle of the controller you want to activate an action set layer for.</param>
        /// <param name="actionSetHandle">InputActionSetHandle_t: The handle of the action set layer you want to activate.</param>
        public static void ActivateActionSetLayer(InputHandle inputHandle, InputActionSetHandle actionSetLayerHandle) => Instance.ActivateActionSetLayer(inputHandle, actionSetLayerHandle);
        /// <summary>
        /// <code>
        ///     void DeactivateActionSetLayer( InputHandle_t inputHandle, InputActionSetHandle_t
        ///     actionSetLayerHandle );
        /// </code>
        /// 
        /// <br />
        /// Reconfigure the controller to stop using the specified action set layer.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     SteamInput()-&gt;DeactivateActionSetLayer( inputHandle1, myActionSetLayer );
        /// </code>
        /// </summary>
        /// <param name="inputHandle">InputHandle_t: The handle of the controller you want to deactivate an action set layer for.</param>
        /// <param name="actionSetHandle">InputActionSetHandle_t: The handle of the action set layer you want to deactivate.</param>
        public static void DeactivateActionSetLayer(InputHandle inputHandle, InputActionSetHandle actionSetLayerHandle) => Instance.DeactivateActionSetLayer(inputHandle, actionSetLayerHandle);
        /// <summary>
        /// <code>void DeactivateAllActionSetLayers( InputHandle_t inputHandle );</code>
        /// 
        /// <br />
        /// Reconfigure the controller to stop using all action set layers.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>SteamInput()-&gt;DeactivateAllActionSetLayers( inputHandle1 );</code>
        /// </summary>
        /// <param name="inputHandle">InputHandle_t: The handle of the controller you want to deactivate all action set layers for.</param>
        public static void DeactivateAllActionSetLayers(InputHandle inputHandle) => Instance.DeactivateAllActionSetLayers(inputHandle);
        /// <summary>
        /// <code>
        ///     int GetActiveActionSetLayers( InputHandle_t inputHandle, InputActionSetHandle_t *handlesOut );
        /// </code>
        /// 
        /// <br />
        /// Fill an array with all of the currently active action set layers for a specified controller
        /// handle.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     InputHandle_t *handlesOut = new InputHandle_t []; SteamInput()-&gt;GetActiveActionSetLayers(
        ///     inputHandle1, &amp;handlesOut );
        /// </code>
        /// </summary>
        /// <param name="inputHandle">InputHandle_t: The handle of the controller you want to get active action set layers for.</param>
        /// <param name="handlesOut">InputActionSetHandle_t*: 
        ///             This must point to a
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamInput#STEAM_INPUT_MAX_COUNT" class="bb_apilink">STEAM_INPUT_MAX_COUNT</a>
        ///             sized array of InputHandle_t.
        ///         </param>
        public static int GetActiveActionSetLayers(InputHandle inputHandle, InputActionSetHandle* handlesOut) => Instance.GetActiveActionSetLayers(inputHandle, handlesOut);
        /// <summary>
        /// <code>
        ///     InputDigitalActionHandle_t GetDigitalActionHandle( const char *pszActionName );
        /// </code>
        /// 
        /// <br />
        /// Get the handle of the specified digital action.<br />
        /// <br />
        /// <b>NOTE:</b> This function does not take an action set handle parameter. That means that
        /// each action in your VDF file must have a unique string identifier. In other words, if you use an
        /// action called "up" in two different action sets, this function will only ever return one of them and
        /// the other will be ignored.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInput#InputDigitalActionHandle_t" class="bb_apilink">InputDigitalActionHandle_t</a><br />
        /// The handle of the specified digital action.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     InputDigitalActionHandle_t punchHandle = SteamInput()-&gt;GetDigitalActionHandle( "punch" );
        /// </code>
        /// </summary>
        /// <param name="pszActionName">const char *: The string identifier of the digital action defined in the game's VDF file.</param>
        public static InputDigitalActionHandle GetDigitalActionHandle(UTF8StringPtr pszActionName) => Instance.GetDigitalActionHandle(pszActionName);
        /// <summary>
        /// <code>
        ///     InputDigitalActionData_t GetDigitalActionData( InputHandle_t inputHandle,
        ///     InputDigitalActionHandle_t digitalActionHandle );
        /// </code>
        /// 
        /// <br />
        /// Returns the current state of the supplied digital game action.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInput#InputDigitalActionData_t" class="bb_apilink">InputDigitalActionData_t</a><br />
        /// The current state of the specified digital action.
        /// </summary>
        /// <param name="inputHandle">InputHandle_t: The handle of the controller you want to query.</param>
        /// <param name="digitalActionHandle">InputDigitalActionHandle_t: The handle of the digital action you want to query.</param>
        public static InputDigitalActionData GetDigitalActionData(InputHandle inputHandle, InputDigitalActionHandle digitalActionHandle) => Instance.GetDigitalActionData(inputHandle, digitalActionHandle);
        /// <summary>
        /// <code>
        ///     int GetDigitalActionOrigins( InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle,
        ///     InputDigitalActionHandle_t digitalActionHandle, EInputActionOrigin *originsOut );
        /// </code>
        /// 
        /// <br />
        /// Get the origin(s) for a digital action within an action set by filling
        /// <code class="bb_code bb_code_inline nohighlight">originsOut</code> with
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInput#EInputActionOrigin" class="bb_apilink">EInputActionOrigin</a>
        /// handles. Use this to display the appropriate on-screen prompt for the action.<br />
        /// <br />
        /// <b>Returns:</b> int<br />
        /// The number of origins supplied in
        /// <code class="bb_code bb_code_inline nohighlight">originsOut</code>.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     EInputActionOrigin *origins = new EInputActionOrigin[];
        ///     SteamInput()-&gt;GetDigitalActionOrigins( controller1Handle, fightingSetHandle, punchHandle,
        ///     origins );
        /// </code>
        /// </summary>
        /// <param name="inputHandle">InputHandle_t: The handle of the controller you want to query.</param>
        /// <param name="actionSetHandle">InputActionSetHandle_t: The handle of the action set you want to query.</param>
        /// <param name="digitalActionHandle">InputDigitalActionHandle_t: The handle of the digital action you want to query.</param>
        /// <param name="originsOut">EInputActionOrigin
        ///             *: 
        ///             A
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamInput#STEAM_INPUT_MAX_ORIGINS" class="bb_apilink">STEAM_INPUT_MAX_ORIGINS</a>
        ///             sized array of
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamInput#EInputActionOrigin" class="bb_apilink">EInputActionOrigin</a>
        ///             handles.
        ///         </param>
        public static int GetDigitalActionOrigins(InputHandle inputHandle, InputActionSetHandle actionSetHandle, InputDigitalActionHandle digitalActionHandle, InputActionOrigin* originsOut) => Instance.GetDigitalActionOrigins(inputHandle, actionSetHandle, digitalActionHandle, originsOut);
        /// missing documentation
        public static UTF8StringPtr GetStringForDigitalActionName(InputDigitalActionHandle eActionHandle) => Instance.GetStringForDigitalActionName(eActionHandle);
        /// <summary>
        /// <code>
        ///     InputAnalogActionHandle_t GetAnalogActionHandle( const char *pszActionName );
        /// </code>
        /// 
        /// <br />
        /// Get the handle of the specified Analog action.<br />
        /// <br />
        /// <b>NOTE:</b> This function does not take an action set handle parameter. That means that
        /// each action in your VDF file must have a unique string identifier. In other words, if you use an
        /// action called "up" in two different action sets, this function will only ever return one of them and
        /// the other will be ignored.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInput#InputAnalogActionHandle_t" class="bb_apilink">InputAnalogActionHandle_t</a><br />
        /// The handle of the specified analog action.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     InputAnalogActionHandle_t moveHandle = SteamInput()-&gt;GetAnalogActionHandle( "move" );
        /// </code>
        /// </summary>
        /// <param name="pszActionName">const char *: The string identifier of the analog action defined in the game's VDF file.</param>
        public static InputAnalogActionHandle GetAnalogActionHandle(UTF8StringPtr pszActionName) => Instance.GetAnalogActionHandle(pszActionName);
        /// <summary>
        /// <code>
        ///     InputAnalogActionData_t GetAnalogActionData( InputHandle_t inputHandle,
        ///     InputAnalogActionHandle_t analogActionHandle );
        /// </code>
        /// 
        /// <br />
        /// Returns the current state of the supplied analog game action.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInput#InputAnalogActionData_t" class="bb_apilink">InputAnalogActionData_t</a><br />
        /// The current state of the specified analog action.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     InputAnalogActionData_t data = SteamInput()-&gt;GetAnalogActionData( controller1Handle,
        ///     moveHandle );
        /// </code>
        /// </summary>
        /// <param name="inputHandle">InputHandle_t: The handle of the controller you want to query.</param>
        /// <param name="analogActionHandle">InputAnalogActionHandle_t: The handle of the analog action you want to query.</param>
        public static InputAnalogActionData GetAnalogActionData(InputHandle inputHandle, InputAnalogActionHandle analogActionHandle) => Instance.GetAnalogActionData(inputHandle, analogActionHandle);
        /// <summary>
        /// <code>
        ///     int GetAnalogActionOrigins( InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle,
        ///     InputAnalogActionHandle_t analogActionHandle, EInputActionOrigin *originsOut );
        /// </code>
        /// 
        /// <br />
        /// Get the origin(s) for an analog action within an action set by filling originsOut with
        /// EInputActionOrigin handles. Use this to display the appropriate on-screen prompt for the action.<br />
        /// <br />
        /// <b>Returns:</b> int<br />
        /// The number of origins supplied in
        /// <code class="bb_code bb_code_inline nohighlight">originsOut</code>.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     EInputActionOrigin *origins = new EInputActionOrigin[]; SteamInput()-&gt;GetAnalogActionOrigins(
        ///     controller1Handle, walkingSetHandle, moveHandle, origins );
        /// </code>
        /// </summary>
        /// <param name="inputHandle">InputHandle_t: The handle of the controller you want to query.</param>
        /// <param name="actionSetHandle">InputActionSetHandle_t: The handle of the action set you want to query.</param>
        /// <param name="analogActionHandle">InputAnalogActionHandle_t: The handle of the analog action you want to query.</param>
        /// <param name="originsOut">EInputActionOrigin
        ///             *: 
        ///             A
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamInput#STEAM_INPUT_MAX_ORIGINS" class="bb_apilink">STEAM_INPUT_MAX_ORIGINS</a>
        ///             sized array of
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamInput#EInputActionOrigin" class="bb_apilink">EInputActionOrigin</a>
        ///             handles.
        ///         </param>
        public static int GetAnalogActionOrigins(InputHandle inputHandle, InputActionSetHandle actionSetHandle, InputAnalogActionHandle analogActionHandle, InputActionOrigin* originsOut) => Instance.GetAnalogActionOrigins(inputHandle, actionSetHandle, analogActionHandle, originsOut);
        /// missing documentation
        public static UTF8StringPtr GetGlyphPNGForActionOrigin(InputActionOrigin eOrigin, SteamInputGlyphSize eSize, uint unFlags) => Instance.GetGlyphPNGForActionOrigin(eOrigin, eSize, unFlags);
        /// missing documentation
        public static UTF8StringPtr GetGlyphSVGForActionOrigin(InputActionOrigin eOrigin, uint unFlags) => Instance.GetGlyphSVGForActionOrigin(eOrigin, unFlags);
        /// missing documentation
        public static UTF8StringPtr GetGlyphForActionOrigin_Legacy(InputActionOrigin eOrigin) => Instance.GetGlyphForActionOrigin_Legacy(eOrigin);
        /// <summary>
        /// <code>const char * GetStringForActionOrigin( EInputActionOrigin eOrigin );</code>
        /// 
        /// <br />
        /// Returns a localized string (from Steam's language setting) for the specified origin.<br />
        /// <br />
        /// <b>Returns:</b> const char *<br />
        /// <br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     EInputActionOrigin *origins = new EInputActionOrigin[];
        ///     SteamInput()-&gt;GetDigitalActionOrigins( controller1Handle, fightingSetHandle, punchHandle,
        ///     origins ); const char * punchString = SteamInput()-&gt;GetStringForActionOrigin( origins[0] );
        ///     printf("punch = %s\n",punchString);
        /// </code>
        /// </summary>
        /// <param name="eOrigin">EInputActionOrigin: </param>
        public static UTF8StringPtr GetStringForActionOrigin(InputActionOrigin eOrigin) => Instance.GetStringForActionOrigin(eOrigin);
        /// missing documentation
        public static UTF8StringPtr GetStringForAnalogActionName(InputAnalogActionHandle eActionHandle) => Instance.GetStringForAnalogActionName(eActionHandle);
        /// <summary>
        /// <code>
        ///     void StopAnalogActionMomentum( InputHandle_t inputHandle, InputAnalogActionHandle_t eAction );
        /// </code>
        /// 
        /// <br />
        /// Stops the momentum of an analog action (where applicable, i.e. a touchpad w/ virtual trackball
        /// settings).<br />
        /// <br />
        /// <b>NOTE:</b><br />
        /// This will also stop all associated haptics. This is useful for situations where you want to indicate
        /// to the user that the limit of an action has been reached, such as spinning a carousel or scrolling a
        /// webpage.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     SteamInput()-&gt;StopAnalogActionMomentum( controller1Handle, moveHandle );
        /// </code>
        /// </summary>
        /// <param name="inputHandle">InputHandle_t: The handle of the controller to affect.</param>
        /// <param name="eAction">InputAnalogActionHandle_t: The analog action to stop momentum for.</param>
        public static void StopAnalogActionMomentum(InputHandle inputHandle, InputAnalogActionHandle eAction) => Instance.StopAnalogActionMomentum(inputHandle, eAction);
        /// <summary>
        /// <code>InputMotionData_t GetMotionData( InputHandle_t inputHandle );</code>
        /// 
        /// <br />
        /// Returns raw motion data for the specified controller.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInput#InputMotionData_t" class="bb_apilink">InputMotionData_t</a><br />
        /// <br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     InputMotionData_t motionData = SteamInput()-&gt;GetControllerMotionData( inputHandle );
        /// </code>
        /// </summary>
        /// <param name="inputHandle">InputHandle_t: The handle of the controller you want to get motion data for.</param>
        public static InputMotionData GetMotionData(InputHandle inputHandle) => Instance.GetMotionData(inputHandle);
        /// <summary>
        /// <code>
        ///     void TriggerVibration( InputHandle_t inputHandle, unsigned short usLeftSpeed, unsigned short
        ///     usRightSpeed );
        /// </code>
        /// 
        /// <br />
        /// Trigger a vibration event on supported controllers.<br />
        /// <br />
        /// <b>Notes:</b><br />
        /// This API call will be ignored for incompatible controller models.<br />
        /// This generates the traditional "rumble" vibration effect.<br />
        /// The VSC will emulate traditional rumble using its haptics.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>SteamInput()-&gt;TriggerVibration( controller1Handle, 10000, 10000 );</code>
        /// </summary>
        /// <param name="inputHandle">InputHandle_t: The handle of the controller to affect.</param>
        /// <param name="usLeftSpeed">unsigned short: The intensity value for the left rumble motor.</param>
        /// <param name="usRightSpeed">unsigned short: The intensity value of the right rumble motor.</param>
        public static void TriggerVibration(InputHandle inputHandle, ushort usLeftSpeed, ushort usRightSpeed) => Instance.TriggerVibration(inputHandle, usLeftSpeed, usRightSpeed);
        /// <summary>
        /// <code>
        ///     void TriggerVibrationExtended( InputHandle_t inputHandle, unsigned short usLeftSpeed, unsigned
        ///     short usRightSpeed );
        /// </code>
        /// 
        /// <br />
        /// Trigger a vibration event on supported controllers, including Xbox Impulse Trigger motor values.<br />
        /// <br />
        /// <b>Notes:</b><br />
        /// On Windows support for Xbox Impulse Trigger motor values requires user installation of the Xbox
        /// Extended Feature support driver.<br />
        /// The Steam Controller and Steam Deck will emulate traditional rumble using their haptics.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     SteamInput()-&gt;TriggerVibrationExtended( controller1Handle, 10000, 10000, 10000, 10000 );
        /// </code>
        /// </summary>
        /// <param name="inputHandle">InputHandle_t: The handle of the controller to affect.</param>
        /// <param name="usLeftSpeed">unsigned short: The intensity value for the left rumble motor.</param>
        /// <param name="usRightSpeed">unsigned short: The intensity value of the right rumble motor.</param>
        /// <param name="usLeftTriggerSpeed">unsigned short: The intensity value for the left Xbox Impulse Trigger motor.</param>
        /// <param name="usRightTriggerSpeed">unsigned short: The intensity value of the right Xbox Impulse Trigger motor.</param>
        public static void TriggerVibrationExtended(InputHandle inputHandle, ushort usLeftSpeed, ushort usRightSpeed, ushort usLeftTriggerSpeed, ushort usRightTriggerSpeed) => Instance.TriggerVibrationExtended(inputHandle, usLeftSpeed, usRightSpeed, usLeftTriggerSpeed, usRightTriggerSpeed);
        /// missing documentation
        public static void TriggerSimpleHapticEvent(InputHandle inputHandle, ControllerHapticLocation eHapticLocation, byte nIntensity, char nGainDB, byte nOtherIntensity, char nOtherGainDB) => Instance.TriggerSimpleHapticEvent(inputHandle, eHapticLocation, nIntensity, nGainDB, nOtherIntensity, nOtherGainDB);
        /// <summary>
        /// <code>
        ///     void SetLEDColor( InputHandle_t inputHandle, uint8 nColorR, uint8 nColorG, uint8 nColorB,
        ///     unsigned int nFlags );
        /// </code>
        /// 
        /// <br />
        /// Set the controller LED color on supported controllers.<br />
        /// <br />
        /// <b>Notes:</b><br />
        /// The VSC does not support any color but white, and will interpret the RGB values as a greyscale value
        /// affecting the brightness of the Steam button LED.<br />
        /// The DS4 responds to full color information and uses the values to set the color &amp; brightness of
        /// the lightbar.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     // Restore the user default color for controller 1: SteamInput()-&gt;SetLEDColor(
        ///     controller1Handle, 0, 0, 0, k_ESteamControllerLEDFlag_RestoreUserDefault ); // Set the color to
        ///     magenta for controller 2: SteamInput()-&gt;SetLEDColor( controller2Handle, 255, 0, 255,
        ///     k_ESteamControllerLEDFlag_SetColor );
        /// </code>
        /// </summary>
        /// <param name="inputHandle">InputHandle_t: The handle of the controller to affect.</param>
        /// <param name="nColorR">uint8: The red component of the color to set (0-255).</param>
        /// <param name="nColorG">uint8: The green component of the color to set (0-255).</param>
        /// <param name="nColorB">uint8: The blue component of the color to set (0-255).</param>
        /// <param name="nFlags">unsigned int: 
        ///             Bit-masked flags combined from values defined in
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamInput#ESteamControllerLEDFlag" class="bb_apilink">ESteamControllerLEDFlag</a>.
        ///         </param>
        public static void SetLEDColor(InputHandle inputHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags) => Instance.SetLEDColor(inputHandle, nColorR, nColorG, nColorB, nFlags);
        /// missing documentation
        public static void Legacy_TriggerHapticPulse(InputHandle inputHandle, SteamControllerPad eTargetPad, ushort usDurationMicroSec) => Instance.Legacy_TriggerHapticPulse(inputHandle, eTargetPad, usDurationMicroSec);
        /// missing documentation
        public static void Legacy_TriggerRepeatedHapticPulse(InputHandle inputHandle, SteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags) => Instance.Legacy_TriggerRepeatedHapticPulse(inputHandle, eTargetPad, usDurationMicroSec, usOffMicroSec, unRepeat, nFlags);
        /// <summary>
        /// <code>bool ShowBindingPanel( InputHandle_t inputHandle );</code>
        /// 
        /// <br />
        /// Invokes the Steam overlay and brings up the binding screen.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> for success; <b>false</b> if overlay is disabled/unavailable. If the
        /// player is using Big Picture Mode the configuration will open in the overlay. In desktop mode a popup
        /// window version of Big Picture will be created and open the configuration.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>SteamInput()-&gt;ShowBindingPanel( myControllerHandle );</code>
        /// </summary>
        /// <param name="inputHandle">InputHandle_t: The handle of the controller you want to bring up the binding screen for.</param>
        public static bool ShowBindingPanel(InputHandle inputHandle) => Instance.ShowBindingPanel(inputHandle);
        /// <summary>
        /// <code>ESteamInputType GetInputTypeForHandle( InputHandle_t inputHandle );</code>
        /// 
        /// <br />
        /// Returns the input type (device model) for the specified controller. This tells you if a given
        /// controller is a Steam controller, Xbox 360 controller, PS4 controller, etc.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInput#ESteamInputType" class="bb_apilink">ESteamInputType</a><br />
        /// <br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     ESteamInputType inputType = SteamInput()-&gt;GetInputTypeForHandle(controller1Handle);
        ///     switch(inputType) { case k_ESteamInputType_Unknown: printf("unknown!\n"); break; case
        ///     k_ESteamInputType_SteamController: printf("Steam controller!\n"); break; case
        ///     k_ESteamInputType_XBox360Controller: printf("XBox 360 controller!\n"); break; case
        ///     k_ESteamInputType_XBoxOneController: printf("XBox One controller!\n"); break; case
        ///     k_ESteamInputType_GenericXInput: printf("Generic XInput!\n"); break; case
        ///     k_ESteamInputType_PS4Controller: printf("PS4 controller!\n"); break; }
        /// </code>
        /// </summary>
        /// <param name="inputHandle">InputHandle_t: The handle of the controller whose input type (device model) you want to query</param>
        public static SteamInputType GetInputTypeForHandle(InputHandle inputHandle) => Instance.GetInputTypeForHandle(inputHandle);
        /// <summary>
        /// <code>InputHandle_t GetControllerForGamepadIndex( int nIndex );</code>
        /// 
        /// <br />
        /// Returns the associated controller handle for the specified emulated gamepad. Can be used with
        /// GetInputTypeForHandle to determine the type of controller using Steam Input Gamepad Emulation.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamInput#InputHandle_t" class="bb_apilink">InputHandle_t</a><br />
        /// <br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     // Replace with the XInput Slot you are querying for. This number is between 0 and 3 int
        ///     nXinputSlotIndex = 0; InputHandle_t inputHandle = SteamInput()-&gt;GetControllerForGamepadIndex(
        ///     nXinputSlotIndex ); if ( inputHandle == 0 ) { // Valid Input handles are non-zero, this is a
        ///     normal Xbox controller. } else { ESteamInputType inputType =
        ///     SteamInput()-&gt;GetInputTypeForHandle( inputHandle ); switch( inputType ) { case
        ///     k_ESteamInputType_Unknown: printf( "unknown!\n" ); break; case
        ///     k_ESteamInputType_SteamController: printf( "Steam controller!\n" ); break; case
        ///     k_ESteamInputType_XBox360Controller: printf( "XBox 360 controller!\n" ); break; case
        ///     k_ESteamInputType_XBoxOneController: printf( "XBox One controller!\n" ); break; case
        ///     k_ESteamInputType_GenericXInput: printf( "Generic XInput!\n" ); break; case
        ///     k_ESteamInputType_PS4Controller: printf( "PS4 controller!\n" ); break; } }
        /// </code>
        /// </summary>
        /// <param name="nIndex">int: The index of the emulated gamepad you want to get a controller handle for.</param>
        public static InputHandle GetControllerForGamepadIndex(int nIndex) => Instance.GetControllerForGamepadIndex(nIndex);
        /// <summary>
        /// <code>int GetGamepadIndexForController( InputHandle_t ulControllerHandle );</code>
        /// 
        /// <br />
        /// Returns the associated gamepad index for the specified controller, if emulating a gamepad.<br />
        /// <br />
        /// <b>Returns:</b> int<br />
        /// <br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     int gamepadIndex = SteamInput()-&gt;GetGamepadIndexForController( controller1Handle );
        /// </code>
        /// </summary>
        /// <param name="ulControllerHandle">InputHandle_t: The handle of the controller you want to get a gamepad index for.</param>
        public static int GetGamepadIndexForController(InputHandle ulinputHandle) => Instance.GetGamepadIndexForController(ulinputHandle);
        /// missing documentation
        public static UTF8StringPtr GetStringForXboxOrigin(XboxOrigin eOrigin) => Instance.GetStringForXboxOrigin(eOrigin);
        /// missing documentation
        public static UTF8StringPtr GetGlyphForXboxOrigin(XboxOrigin eOrigin) => Instance.GetGlyphForXboxOrigin(eOrigin);
        /// <summary>
        /// <code>
        ///     EInputActionOrigin GetActionOriginFromXboxOrigin( InputHandle_t inputHandle, EXboxOrigin eOrigin
        ///     );
        /// </code>
        /// 
        /// <br />
        /// <b>Returns:</b> EInputActionOrigin<br />
        /// <br />
        /// Get an action origin that you can use in your glyph look up table or passed into
        /// GetGlyphForActionOrigin or GetStringForActionOrigin<br />
        /// <br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     int nXinputSlot = 1; // Substitute whatever the correct Xinput slot is for your player
        ///     InputHandle_t controller1Handle = GetControllerForGamepadIndex( nXinputSlot );
        ///     EInputActionOrigin buttonOrigin = SteamInput()-&gt;GetActionOriginFromXboxOrigin(
        ///     controller1Handle, k_EXboxOrigin_A ); // Gets the image from the Steam client . const char
        ///     *localGlyphPath = SteamInput()-&gt;GetGlyphForActionOrigin( buttonOrigin ); printf( "path =
        ///     %s\n", localGlyphPath ); // "path = C:\Program Files
        ///     (x86)\Steam\tenfoot\resource\images\library\controller\api\ps4_button_x.png" //a function from
        ///     the game that turns a file path into a usable game texture glyphTextureID =
        ///     loadButtonGlyphTextureFromLocalPath( localGlyphPath );
        /// </code>
        /// </summary>
        /// <param name="inputHandle">InputHandle_t: 
        ///             The handle of the controller to affect. You can use GetControllerForGamepadIndex to get
        ///             this handle
        ///         </param>
        /// <param name="eOrigin">EXboxOrigin: This is the button you want to get the image for ex: k_EXboxOrigin_A</param>
        public static InputActionOrigin GetActionOriginFromXboxOrigin(InputHandle inputHandle, XboxOrigin eOrigin) => Instance.GetActionOriginFromXboxOrigin(inputHandle, eOrigin);
        /// <summary>
        /// <code>
        ///     EInputActionOrigin TranslateActionOrigin( ESteamInputType eDestinationInputType,
        ///     EInputActionOrigin eSourceOrigin );
        /// </code>
        /// 
        /// <br />
        /// <b>Returns:</b> EInputActionOrigin<br />
        /// <br />
        /// Get the equivalent origin for a given controller type or the closest controller type that existed in
        /// the SDK you built into your game if eDestinationInputType is k_ESteamInputType_Unknown. This action
        /// origin can be used in your glyph look up table or passed into GetGlyphForActionOrigin or
        /// GetStringForActionOrigin<br />
        /// <br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     int nXinputSlot = 1; // Substitutes whatever the correct Xinput slot is for your player
        ///     InputHandle_t controller1Handle = GetControllerForGamepadIndex( nXinputSlot );
        ///     EInputActionOrigin buttonOrigin = SteamInput()-&gt;GetActionOriginFromXboxOrigin(
        ///     controller1Handle, k_EXboxOrigin_A ); //i.e, k_EInputActionOrigin_PS4_X if ( buttonOrigin &gt;=
        ///     k_EInputActionOrigin_Count ) { // We didn't ship any art in our game for this origin! I guess
        ///     Steam has added support for // a new controller. Let's get the closest value that was supported
        ///     by the SDK we built against buttonOrigin = SteamInput()-&gt;TranslateActionOrigin(
        ///     k_ESteamInputType_Unknown, buttonOrigin ) } // This is a function from the game itself that
        ///     tries to get custom glyph art int glyphTextureID = getHardCodedButtonGlyphTexture( actionOrigin
        ///     );
        /// </code>
        /// </summary>
        /// <param name="inputHandle">InputHandle_t: 
        ///             The handle of the controller to affect. You can use GetControllerForGamepadIndex to get
        ///             this handle
        ///         </param>
        /// <param name="eDestinationInputType">ESteamInputType: 
        ///             The controller type you want to translate to. Steam will pick the closest type from your
        ///             SDK version if k_ESteamInputType_Unknown is used
        ///         </param>
        /// <param name="eSourceOrigin">EInputActionOrigin: This is the button you want to translate</param>
        public static InputActionOrigin TranslateActionOrigin(SteamInputType eDestinationInputType, InputActionOrigin eSourceOrigin) => Instance.TranslateActionOrigin(eDestinationInputType, eSourceOrigin);
        /// <summary>
        /// <code>
        ///     bool GetDeviceBindingRevision( InputHandle_t inputHandle, int *pMajor, int *pMinor );
        /// </code>
        /// 
        /// <br />
        /// <b>Returns:</b> bool - true if a device binding was successfully found and false if the
        /// binding is still loading.<br />
        /// <br />
        /// Gets the major and minor device binding revisions for Steam Input API configurations. Major
        /// revisions are to be used when changing the number of action sets or otherwise reworking
        /// configurations to the degree that older configurations are no longer usable. When a user's binding
        /// disagrees with the major revision of the current official configuration Steam will forcibly update
        /// the user to the new configuration. New configurations will need to be made for every controller when
        /// updating the major revision. Minor revisions are for small changes such as adding a new optional
        /// action or updating localization in the configuration. When updating the minor revision you generally
        /// can update a single configuration and check the "Use Action Block" to apply the action block changes
        /// to the other configurations.<br />
        /// <br />
        /// <b>Example Code:</b><br />
        /// <code>
        ///     int nMajorRevision = -1; int nMinorRevision= -1; const int nCurrentMajorRevision = 1; const int
        ///     nCurrentMinorRevision = 1; if ( GetDeviceBindingRevision( inputHandle, &amp;nMajorRevision ,
        ///     &amp;nMinorRevision ) ) { if ( nMinorRevision != nCurrentMinorRevision ) { // The minor version
        ///     out of date, but that's ok // next time they edit their config this will get fixed } if (
        ///     nMajorRevision != nCurrentMajorRevision ) { // This should only happen briefly while Steam
        ///     detects // and then force-updates the user to the latest official config } } else { // The
        ///     configuration isn't loaded for this controller yet }
        /// </code>
        /// <br />
        /// <b>Example In-game Action File Usage:</b><br />
        /// <code>
        ///     "In Game Actions" { "major_revision" "0" "minor_revision" "1" "actions" { ...
        /// </code>
        /// </summary>
        /// <param name="inputHandle">InputHandle_t: The handle of the controller to query.</param>
        /// <param name="pMajor">int *: Pointer to int that Major binding revision will be populated into</param>
        /// <param name="pMinor">int *: Pointer to int that Minor binding revision will be populated into</param>
        public static bool GetDeviceBindingRevision(InputHandle inputHandle, int* pMajor, int* pMinor) => Instance.GetDeviceBindingRevision(inputHandle, pMajor, pMinor);
        /// <summary>
        /// <code>uint32 GetRemotePlaySessionID( InputHandle_t inputHandle );</code>
        /// 
        /// <br />
        /// <b>Returns:</b> uint32 - Steam Remote Play session ID<br />
        /// <br />
        /// Get the Steam Remote Play session ID associated with a device, or 0 if there is no session
        /// associated with it. See isteamremoteplay.h for more information on Steam Remote Play sessions.
        /// </summary>
        /// <param name="inputHandle">InputHandle_t: The handle of the controller to query.</param>
        public static uint GetRemotePlaySessionID(InputHandle inputHandle) => Instance.GetRemotePlaySessionID(inputHandle);
        /// missing documentation
        public static ushort GetSessionInputConfigurationSettings() => Instance.GetSessionInputConfigurationSettings();
        /// <summary>
        /// <code>
        ///     void SetDualSenseTriggerEffect( InputHandle_t inputHandle, const ScePadTriggerEffectParam
        ///     *pParam );
        /// </code>
        /// 
        /// <br />
        /// Set the trigger effect for a DualSense controller.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     ScePadTriggerEffectParam param; memset( &amp;param, 0, sizeof( param ) ); param.triggerMask =
        ///     SCE_PAD_TRIGGER_EFFECT_TRIGGER_MASK_R2;
        ///     param.command[SCE_PAD_TRIGGER_EFFECT_PARAM_INDEX_FOR_R2].mode =
        ///     SCE_PAD_TRIGGER_EFFECT_MODE_VIBRATION;
        ///     param.command[SCE_PAD_TRIGGER_EFFECT_PARAM_INDEX_FOR_R2].commandData.vibrationParam.position =
        ///     5; param.command[SCE_PAD_TRIGGER_EFFECT_PARAM_INDEX_FOR_R2].commandData.vibrationParam.amplitude
        ///     = 5;
        ///     param.command[SCE_PAD_TRIGGER_EFFECT_PARAM_INDEX_FOR_R2].commandData.vibrationParam.frequency =
        ///     8; SteamInput()-&gt;SetDualSenseTriggerEffect( controller1Handle, &amp;param );
        /// </code>
        /// </summary>
        /// <param name="inputHandle">InputHandle_t: The handle of the controller to affect.</param>
        /// <param name="pParam">ScePadTriggerEffectParam: The trigger parameter, defined in isteamdualsense.h</param>
        public static void SetDualSenseTriggerEffect(InputHandle inputHandle, Unknown* pParam) => Instance.SetDualSenseTriggerEffect(inputHandle, pParam);
    }
}