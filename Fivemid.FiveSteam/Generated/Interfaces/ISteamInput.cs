using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Steam Input API is a flexible action-based API that supports all major controller types - Xbox, PlayStation, Nintendo Switch Pro, and Steam Controllers.<br />
    /// <br />
    /// See the <a href="https://partner.steamgames.com/doc/features/steam_controller" class="bb_doclink">Steam Input</a> documentation for more information.</summary>
    public unsafe interface ISteamInput
    {
        public bool Init(bool bExplicitlyCallRunFrame);
        public bool Shutdown();
        public bool SetInputActionManifestFilePath(UTF8StringPtr pchInputActionManifestAbsolutePath);
        public void RunFrame(bool bReservedValue);
        public bool BWaitForData(bool bWaitForever, uint unTimeout);
        public bool BNewDataAvailable();
        public int GetConnectedControllers(InputHandle* handlesOut);
        public void EnableDeviceCallbacks();
        public void EnableActionEventCallbacks(SteamInputActionEventCallbackPointer pCallback);
        public InputActionSetHandle GetActionSetHandle(UTF8StringPtr pszActionSetName);
        public void ActivateActionSet(InputHandle inputHandle, InputActionSetHandle actionSetHandle);
        public InputActionSetHandle GetCurrentActionSet(InputHandle inputHandle);
        public void ActivateActionSetLayer(InputHandle inputHandle, InputActionSetHandle actionSetLayerHandle);
        public void DeactivateActionSetLayer(InputHandle inputHandle, InputActionSetHandle actionSetLayerHandle);
        public void DeactivateAllActionSetLayers(InputHandle inputHandle);
        public int GetActiveActionSetLayers(InputHandle inputHandle, InputActionSetHandle* handlesOut);
        public InputDigitalActionHandle GetDigitalActionHandle(UTF8StringPtr pszActionName);
        public InputDigitalActionData GetDigitalActionData(InputHandle inputHandle, InputDigitalActionHandle digitalActionHandle);
        public int GetDigitalActionOrigins(InputHandle inputHandle, InputActionSetHandle actionSetHandle, InputDigitalActionHandle digitalActionHandle, InputActionOrigin* originsOut);
        public UTF8StringPtr GetStringForDigitalActionName(InputDigitalActionHandle eActionHandle);
        public InputAnalogActionHandle GetAnalogActionHandle(UTF8StringPtr pszActionName);
        public InputAnalogActionData GetAnalogActionData(InputHandle inputHandle, InputAnalogActionHandle analogActionHandle);
        public int GetAnalogActionOrigins(InputHandle inputHandle, InputActionSetHandle actionSetHandle, InputAnalogActionHandle analogActionHandle, InputActionOrigin* originsOut);
        public UTF8StringPtr GetGlyphPNGForActionOrigin(InputActionOrigin eOrigin, SteamInputGlyphSize eSize, uint unFlags);
        public UTF8StringPtr GetGlyphSVGForActionOrigin(InputActionOrigin eOrigin, uint unFlags);
        public UTF8StringPtr GetGlyphForActionOrigin_Legacy(InputActionOrigin eOrigin);
        public UTF8StringPtr GetStringForActionOrigin(InputActionOrigin eOrigin);
        public UTF8StringPtr GetStringForAnalogActionName(InputAnalogActionHandle eActionHandle);
        public void StopAnalogActionMomentum(InputHandle inputHandle, InputAnalogActionHandle eAction);
        public InputMotionData GetMotionData(InputHandle inputHandle);
        public void TriggerVibration(InputHandle inputHandle, ushort usLeftSpeed, ushort usRightSpeed);
        public void TriggerVibrationExtended(InputHandle inputHandle, ushort usLeftSpeed, ushort usRightSpeed, ushort usLeftTriggerSpeed, ushort usRightTriggerSpeed);
        public void TriggerSimpleHapticEvent(InputHandle inputHandle, ControllerHapticLocation eHapticLocation, byte nIntensity, byte nGainDB, byte nOtherIntensity, byte nOtherGainDB);
        public void SetLEDColor(InputHandle inputHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags);
        public void Legacy_TriggerHapticPulse(InputHandle inputHandle, SteamControllerPad eTargetPad, ushort usDurationMicroSec);
        public void Legacy_TriggerRepeatedHapticPulse(InputHandle inputHandle, SteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags);
        public bool ShowBindingPanel(InputHandle inputHandle);
        public SteamInputType GetInputTypeForHandle(InputHandle inputHandle);
        public InputHandle GetControllerForGamepadIndex(int nIndex);
        public int GetGamepadIndexForController(InputHandle ulinputHandle);
        public UTF8StringPtr GetStringForXboxOrigin(XboxOrigin eOrigin);
        public UTF8StringPtr GetGlyphForXboxOrigin(XboxOrigin eOrigin);
        public InputActionOrigin GetActionOriginFromXboxOrigin(InputHandle inputHandle, XboxOrigin eOrigin);
        public InputActionOrigin TranslateActionOrigin(SteamInputType eDestinationInputType, InputActionOrigin eSourceOrigin);
        public bool GetDeviceBindingRevision(InputHandle inputHandle, int* pMajor, int* pMinor);
        public uint GetRemotePlaySessionID(InputHandle inputHandle);
        public ushort GetSessionInputConfigurationSettings();
        public void SetDualSenseTriggerEffect(InputHandle inputHandle, Unknown* pParam);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_Init", CallingConvention = Platform.CC)]
        internal static extern bool Init(void* self, bool bExplicitlyCallRunFrame);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_Shutdown", CallingConvention = Platform.CC)]
        internal static extern bool Shutdown(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_SetInputActionManifestFilePath", CallingConvention = Platform.CC)]
        internal static extern bool SetInputActionManifestFilePath(void* self, UTF8StringPtr pchInputActionManifestAbsolutePath);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_RunFrame", CallingConvention = Platform.CC)]
        internal static extern void RunFrame(void* self, bool bReservedValue);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_BWaitForData", CallingConvention = Platform.CC)]
        internal static extern bool BWaitForData(void* self, bool bWaitForever, uint unTimeout);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_BNewDataAvailable", CallingConvention = Platform.CC)]
        internal static extern bool BNewDataAvailable(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_GetConnectedControllers", CallingConvention = Platform.CC)]
        internal static extern int GetConnectedControllers(void* self, InputHandle* handlesOut);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_EnableDeviceCallbacks", CallingConvention = Platform.CC)]
        internal static extern void EnableDeviceCallbacks(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_EnableActionEventCallbacks", CallingConvention = Platform.CC)]
        internal static extern void EnableActionEventCallbacks(void* self, SteamInputActionEventCallbackPointer pCallback);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_GetActionSetHandle", CallingConvention = Platform.CC)]
        internal static extern InputActionSetHandle GetActionSetHandle(void* self, UTF8StringPtr pszActionSetName);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_ActivateActionSet", CallingConvention = Platform.CC)]
        internal static extern void ActivateActionSet(void* self, InputHandle inputHandle, InputActionSetHandle actionSetHandle);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_GetCurrentActionSet", CallingConvention = Platform.CC)]
        internal static extern InputActionSetHandle GetCurrentActionSet(void* self, InputHandle inputHandle);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_ActivateActionSetLayer", CallingConvention = Platform.CC)]
        internal static extern void ActivateActionSetLayer(void* self, InputHandle inputHandle, InputActionSetHandle actionSetLayerHandle);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_DeactivateActionSetLayer", CallingConvention = Platform.CC)]
        internal static extern void DeactivateActionSetLayer(void* self, InputHandle inputHandle, InputActionSetHandle actionSetLayerHandle);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_DeactivateAllActionSetLayers", CallingConvention = Platform.CC)]
        internal static extern void DeactivateAllActionSetLayers(void* self, InputHandle inputHandle);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_GetActiveActionSetLayers", CallingConvention = Platform.CC)]
        internal static extern int GetActiveActionSetLayers(void* self, InputHandle inputHandle, InputActionSetHandle* handlesOut);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_GetDigitalActionHandle", CallingConvention = Platform.CC)]
        internal static extern InputDigitalActionHandle GetDigitalActionHandle(void* self, UTF8StringPtr pszActionName);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_GetDigitalActionData", CallingConvention = Platform.CC)]
        internal static extern InputDigitalActionData GetDigitalActionData(void* self, InputHandle inputHandle, InputDigitalActionHandle digitalActionHandle);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_GetDigitalActionOrigins", CallingConvention = Platform.CC)]
        internal static extern int GetDigitalActionOrigins(void* self, InputHandle inputHandle, InputActionSetHandle actionSetHandle, InputDigitalActionHandle digitalActionHandle, InputActionOrigin* originsOut);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_GetStringForDigitalActionName", CallingConvention = Platform.CC)]
        internal static extern UTF8StringPtr GetStringForDigitalActionName(void* self, InputDigitalActionHandle eActionHandle);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_GetAnalogActionHandle", CallingConvention = Platform.CC)]
        internal static extern InputAnalogActionHandle GetAnalogActionHandle(void* self, UTF8StringPtr pszActionName);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_GetAnalogActionData", CallingConvention = Platform.CC)]
        internal static extern InputAnalogActionData GetAnalogActionData(void* self, InputHandle inputHandle, InputAnalogActionHandle analogActionHandle);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_GetAnalogActionOrigins", CallingConvention = Platform.CC)]
        internal static extern int GetAnalogActionOrigins(void* self, InputHandle inputHandle, InputActionSetHandle actionSetHandle, InputAnalogActionHandle analogActionHandle, InputActionOrigin* originsOut);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_GetGlyphPNGForActionOrigin", CallingConvention = Platform.CC)]
        internal static extern UTF8StringPtr GetGlyphPNGForActionOrigin(void* self, InputActionOrigin eOrigin, SteamInputGlyphSize eSize, uint unFlags);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_GetGlyphSVGForActionOrigin", CallingConvention = Platform.CC)]
        internal static extern UTF8StringPtr GetGlyphSVGForActionOrigin(void* self, InputActionOrigin eOrigin, uint unFlags);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_GetGlyphForActionOrigin_Legacy", CallingConvention = Platform.CC)]
        internal static extern UTF8StringPtr GetGlyphForActionOrigin_Legacy(void* self, InputActionOrigin eOrigin);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_GetStringForActionOrigin", CallingConvention = Platform.CC)]
        internal static extern UTF8StringPtr GetStringForActionOrigin(void* self, InputActionOrigin eOrigin);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_GetStringForAnalogActionName", CallingConvention = Platform.CC)]
        internal static extern UTF8StringPtr GetStringForAnalogActionName(void* self, InputAnalogActionHandle eActionHandle);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_StopAnalogActionMomentum", CallingConvention = Platform.CC)]
        internal static extern void StopAnalogActionMomentum(void* self, InputHandle inputHandle, InputAnalogActionHandle eAction);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_GetMotionData", CallingConvention = Platform.CC)]
        internal static extern InputMotionData GetMotionData(void* self, InputHandle inputHandle);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_TriggerVibration", CallingConvention = Platform.CC)]
        internal static extern void TriggerVibration(void* self, InputHandle inputHandle, ushort usLeftSpeed, ushort usRightSpeed);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_TriggerVibrationExtended", CallingConvention = Platform.CC)]
        internal static extern void TriggerVibrationExtended(void* self, InputHandle inputHandle, ushort usLeftSpeed, ushort usRightSpeed, ushort usLeftTriggerSpeed, ushort usRightTriggerSpeed);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_TriggerSimpleHapticEvent", CallingConvention = Platform.CC)]
        internal static extern void TriggerSimpleHapticEvent(void* self, InputHandle inputHandle, ControllerHapticLocation eHapticLocation, byte nIntensity, byte nGainDB, byte nOtherIntensity, byte nOtherGainDB);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_SetLEDColor", CallingConvention = Platform.CC)]
        internal static extern void SetLEDColor(void* self, InputHandle inputHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_Legacy_TriggerHapticPulse", CallingConvention = Platform.CC)]
        internal static extern void Legacy_TriggerHapticPulse(void* self, InputHandle inputHandle, SteamControllerPad eTargetPad, ushort usDurationMicroSec);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_Legacy_TriggerRepeatedHapticPulse", CallingConvention = Platform.CC)]
        internal static extern void Legacy_TriggerRepeatedHapticPulse(void* self, InputHandle inputHandle, SteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_ShowBindingPanel", CallingConvention = Platform.CC)]
        internal static extern bool ShowBindingPanel(void* self, InputHandle inputHandle);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_GetInputTypeForHandle", CallingConvention = Platform.CC)]
        internal static extern SteamInputType GetInputTypeForHandle(void* self, InputHandle inputHandle);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_GetControllerForGamepadIndex", CallingConvention = Platform.CC)]
        internal static extern InputHandle GetControllerForGamepadIndex(void* self, int nIndex);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_GetGamepadIndexForController", CallingConvention = Platform.CC)]
        internal static extern int GetGamepadIndexForController(void* self, InputHandle ulinputHandle);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_GetStringForXboxOrigin", CallingConvention = Platform.CC)]
        internal static extern UTF8StringPtr GetStringForXboxOrigin(void* self, XboxOrigin eOrigin);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_GetGlyphForXboxOrigin", CallingConvention = Platform.CC)]
        internal static extern UTF8StringPtr GetGlyphForXboxOrigin(void* self, XboxOrigin eOrigin);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_GetActionOriginFromXboxOrigin", CallingConvention = Platform.CC)]
        internal static extern InputActionOrigin GetActionOriginFromXboxOrigin(void* self, InputHandle inputHandle, XboxOrigin eOrigin);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_TranslateActionOrigin", CallingConvention = Platform.CC)]
        internal static extern InputActionOrigin TranslateActionOrigin(void* self, SteamInputType eDestinationInputType, InputActionOrigin eSourceOrigin);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_GetDeviceBindingRevision", CallingConvention = Platform.CC)]
        internal static extern bool GetDeviceBindingRevision(void* self, InputHandle inputHandle, int* pMajor, int* pMinor);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_GetRemotePlaySessionID", CallingConvention = Platform.CC)]
        internal static extern uint GetRemotePlaySessionID(void* self, InputHandle inputHandle);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_GetSessionInputConfigurationSettings", CallingConvention = Platform.CC)]
        internal static extern ushort GetSessionInputConfigurationSettings(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamInput_SetDualSenseTriggerEffect", CallingConvention = Platform.CC)]
        internal static extern void SetDualSenseTriggerEffect(void* self, InputHandle inputHandle, Unknown* pParam);
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
        public struct Instance : ISteamInput
        {
            public void* self;
            public bool Init(bool bExplicitlyCallRunFrame) => ISteamInput.Init(self, bExplicitlyCallRunFrame);
            public bool Shutdown() => ISteamInput.Shutdown(self);
            public bool SetInputActionManifestFilePath(UTF8StringPtr pchInputActionManifestAbsolutePath) => ISteamInput.SetInputActionManifestFilePath(self, pchInputActionManifestAbsolutePath);
            public void RunFrame(bool bReservedValue) => ISteamInput.RunFrame(self, bReservedValue);
            public bool BWaitForData(bool bWaitForever, uint unTimeout) => ISteamInput.BWaitForData(self, bWaitForever, unTimeout);
            public bool BNewDataAvailable() => ISteamInput.BNewDataAvailable(self);
            public int GetConnectedControllers(InputHandle* handlesOut) => ISteamInput.GetConnectedControllers(self, handlesOut);
            public void EnableDeviceCallbacks() => ISteamInput.EnableDeviceCallbacks(self);
            public void EnableActionEventCallbacks(SteamInputActionEventCallbackPointer pCallback) => ISteamInput.EnableActionEventCallbacks(self, pCallback);
            public InputActionSetHandle GetActionSetHandle(UTF8StringPtr pszActionSetName) => ISteamInput.GetActionSetHandle(self, pszActionSetName);
            public void ActivateActionSet(InputHandle inputHandle, InputActionSetHandle actionSetHandle) => ISteamInput.ActivateActionSet(self, inputHandle, actionSetHandle);
            public InputActionSetHandle GetCurrentActionSet(InputHandle inputHandle) => ISteamInput.GetCurrentActionSet(self, inputHandle);
            public void ActivateActionSetLayer(InputHandle inputHandle, InputActionSetHandle actionSetLayerHandle) => ISteamInput.ActivateActionSetLayer(self, inputHandle, actionSetLayerHandle);
            public void DeactivateActionSetLayer(InputHandle inputHandle, InputActionSetHandle actionSetLayerHandle) => ISteamInput.DeactivateActionSetLayer(self, inputHandle, actionSetLayerHandle);
            public void DeactivateAllActionSetLayers(InputHandle inputHandle) => ISteamInput.DeactivateAllActionSetLayers(self, inputHandle);
            public int GetActiveActionSetLayers(InputHandle inputHandle, InputActionSetHandle* handlesOut) => ISteamInput.GetActiveActionSetLayers(self, inputHandle, handlesOut);
            public InputDigitalActionHandle GetDigitalActionHandle(UTF8StringPtr pszActionName) => ISteamInput.GetDigitalActionHandle(self, pszActionName);
            public InputDigitalActionData GetDigitalActionData(InputHandle inputHandle, InputDigitalActionHandle digitalActionHandle) => ISteamInput.GetDigitalActionData(self, inputHandle, digitalActionHandle);
            public int GetDigitalActionOrigins(InputHandle inputHandle, InputActionSetHandle actionSetHandle, InputDigitalActionHandle digitalActionHandle, InputActionOrigin* originsOut) => ISteamInput.GetDigitalActionOrigins(self, inputHandle, actionSetHandle, digitalActionHandle, originsOut);
            public UTF8StringPtr GetStringForDigitalActionName(InputDigitalActionHandle eActionHandle) => ISteamInput.GetStringForDigitalActionName(self, eActionHandle);
            public InputAnalogActionHandle GetAnalogActionHandle(UTF8StringPtr pszActionName) => ISteamInput.GetAnalogActionHandle(self, pszActionName);
            public InputAnalogActionData GetAnalogActionData(InputHandle inputHandle, InputAnalogActionHandle analogActionHandle) => ISteamInput.GetAnalogActionData(self, inputHandle, analogActionHandle);
            public int GetAnalogActionOrigins(InputHandle inputHandle, InputActionSetHandle actionSetHandle, InputAnalogActionHandle analogActionHandle, InputActionOrigin* originsOut) => ISteamInput.GetAnalogActionOrigins(self, inputHandle, actionSetHandle, analogActionHandle, originsOut);
            public UTF8StringPtr GetGlyphPNGForActionOrigin(InputActionOrigin eOrigin, SteamInputGlyphSize eSize, uint unFlags) => ISteamInput.GetGlyphPNGForActionOrigin(self, eOrigin, eSize, unFlags);
            public UTF8StringPtr GetGlyphSVGForActionOrigin(InputActionOrigin eOrigin, uint unFlags) => ISteamInput.GetGlyphSVGForActionOrigin(self, eOrigin, unFlags);
            public UTF8StringPtr GetGlyphForActionOrigin_Legacy(InputActionOrigin eOrigin) => ISteamInput.GetGlyphForActionOrigin_Legacy(self, eOrigin);
            public UTF8StringPtr GetStringForActionOrigin(InputActionOrigin eOrigin) => ISteamInput.GetStringForActionOrigin(self, eOrigin);
            public UTF8StringPtr GetStringForAnalogActionName(InputAnalogActionHandle eActionHandle) => ISteamInput.GetStringForAnalogActionName(self, eActionHandle);
            public void StopAnalogActionMomentum(InputHandle inputHandle, InputAnalogActionHandle eAction) => ISteamInput.StopAnalogActionMomentum(self, inputHandle, eAction);
            public InputMotionData GetMotionData(InputHandle inputHandle) => ISteamInput.GetMotionData(self, inputHandle);
            public void TriggerVibration(InputHandle inputHandle, ushort usLeftSpeed, ushort usRightSpeed) => ISteamInput.TriggerVibration(self, inputHandle, usLeftSpeed, usRightSpeed);
            public void TriggerVibrationExtended(InputHandle inputHandle, ushort usLeftSpeed, ushort usRightSpeed, ushort usLeftTriggerSpeed, ushort usRightTriggerSpeed) => ISteamInput.TriggerVibrationExtended(self, inputHandle, usLeftSpeed, usRightSpeed, usLeftTriggerSpeed, usRightTriggerSpeed);
            public void TriggerSimpleHapticEvent(InputHandle inputHandle, ControllerHapticLocation eHapticLocation, byte nIntensity, byte nGainDB, byte nOtherIntensity, byte nOtherGainDB) => ISteamInput.TriggerSimpleHapticEvent(self, inputHandle, eHapticLocation, nIntensity, nGainDB, nOtherIntensity, nOtherGainDB);
            public void SetLEDColor(InputHandle inputHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags) => ISteamInput.SetLEDColor(self, inputHandle, nColorR, nColorG, nColorB, nFlags);
            public void Legacy_TriggerHapticPulse(InputHandle inputHandle, SteamControllerPad eTargetPad, ushort usDurationMicroSec) => ISteamInput.Legacy_TriggerHapticPulse(self, inputHandle, eTargetPad, usDurationMicroSec);
            public void Legacy_TriggerRepeatedHapticPulse(InputHandle inputHandle, SteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags) => ISteamInput.Legacy_TriggerRepeatedHapticPulse(self, inputHandle, eTargetPad, usDurationMicroSec, usOffMicroSec, unRepeat, nFlags);
            public bool ShowBindingPanel(InputHandle inputHandle) => ISteamInput.ShowBindingPanel(self, inputHandle);
            public SteamInputType GetInputTypeForHandle(InputHandle inputHandle) => ISteamInput.GetInputTypeForHandle(self, inputHandle);
            public InputHandle GetControllerForGamepadIndex(int nIndex) => ISteamInput.GetControllerForGamepadIndex(self, nIndex);
            public int GetGamepadIndexForController(InputHandle ulinputHandle) => ISteamInput.GetGamepadIndexForController(self, ulinputHandle);
            public UTF8StringPtr GetStringForXboxOrigin(XboxOrigin eOrigin) => ISteamInput.GetStringForXboxOrigin(self, eOrigin);
            public UTF8StringPtr GetGlyphForXboxOrigin(XboxOrigin eOrigin) => ISteamInput.GetGlyphForXboxOrigin(self, eOrigin);
            public InputActionOrigin GetActionOriginFromXboxOrigin(InputHandle inputHandle, XboxOrigin eOrigin) => ISteamInput.GetActionOriginFromXboxOrigin(self, inputHandle, eOrigin);
            public InputActionOrigin TranslateActionOrigin(SteamInputType eDestinationInputType, InputActionOrigin eSourceOrigin) => ISteamInput.TranslateActionOrigin(self, eDestinationInputType, eSourceOrigin);
            public bool GetDeviceBindingRevision(InputHandle inputHandle, int* pMajor, int* pMinor) => ISteamInput.GetDeviceBindingRevision(self, inputHandle, pMajor, pMinor);
            public uint GetRemotePlaySessionID(InputHandle inputHandle) => ISteamInput.GetRemotePlaySessionID(self, inputHandle);
            public ushort GetSessionInputConfigurationSettings() => ISteamInput.GetSessionInputConfigurationSettings(self);
            public void SetDualSenseTriggerEffect(InputHandle inputHandle, Unknown* pParam) => ISteamInput.SetDualSenseTriggerEffect(self, inputHandle, pParam);
        }
    }
}