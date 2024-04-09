using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamInput
    {
        public static ISteamInput.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamInput_v006", CallingConvention = Platform.CC)]
        private static extern ISteamInput.Instance Accessor();
        /// <summary></summary>
        public static bool Init(bool bExplicitlyCallRunFrame) => Instance.Init(bExplicitlyCallRunFrame);
        /// <summary></summary>
        public static bool Shutdown() => Instance.Shutdown();
        /// <summary></summary>
        public static bool SetInputActionManifestFilePath(UTF8StringPtr pchInputActionManifestAbsolutePath) => Instance.SetInputActionManifestFilePath(pchInputActionManifestAbsolutePath);
        /// <summary></summary>
        public static void RunFrame(bool bReservedValue) => Instance.RunFrame(bReservedValue);
        /// <summary></summary>
        public static bool BWaitForData(bool bWaitForever, uint unTimeout) => Instance.BWaitForData(bWaitForever, unTimeout);
        /// <summary></summary>
        public static bool BNewDataAvailable() => Instance.BNewDataAvailable();
        /// <summary></summary>
        public static int GetConnectedControllers(InputHandle* handlesOut) => Instance.GetConnectedControllers(handlesOut);
        /// <summary></summary>
        public static void EnableDeviceCallbacks() => Instance.EnableDeviceCallbacks();
        /// <summary></summary>
        public static void EnableActionEventCallbacks(SteamInputActionEventCallbackPointer pCallback) => Instance.EnableActionEventCallbacks(pCallback);
        /// <summary></summary>
        public static InputActionSetHandle GetActionSetHandle(UTF8StringPtr pszActionSetName) => Instance.GetActionSetHandle(pszActionSetName);
        /// <summary></summary>
        public static void ActivateActionSet(InputHandle inputHandle, InputActionSetHandle actionSetHandle) => Instance.ActivateActionSet(inputHandle, actionSetHandle);
        /// <summary></summary>
        public static InputActionSetHandle GetCurrentActionSet(InputHandle inputHandle) => Instance.GetCurrentActionSet(inputHandle);
        /// <summary></summary>
        public static void ActivateActionSetLayer(InputHandle inputHandle, InputActionSetHandle actionSetLayerHandle) => Instance.ActivateActionSetLayer(inputHandle, actionSetLayerHandle);
        /// <summary></summary>
        public static void DeactivateActionSetLayer(InputHandle inputHandle, InputActionSetHandle actionSetLayerHandle) => Instance.DeactivateActionSetLayer(inputHandle, actionSetLayerHandle);
        /// <summary></summary>
        public static void DeactivateAllActionSetLayers(InputHandle inputHandle) => Instance.DeactivateAllActionSetLayers(inputHandle);
        /// <summary></summary>
        public static int GetActiveActionSetLayers(InputHandle inputHandle, InputActionSetHandle* handlesOut) => Instance.GetActiveActionSetLayers(inputHandle, handlesOut);
        /// <summary></summary>
        public static InputDigitalActionHandle GetDigitalActionHandle(UTF8StringPtr pszActionName) => Instance.GetDigitalActionHandle(pszActionName);
        /// <summary></summary>
        public static InputDigitalActionData GetDigitalActionData(InputHandle inputHandle, InputDigitalActionHandle digitalActionHandle) => Instance.GetDigitalActionData(inputHandle, digitalActionHandle);
        /// <summary></summary>
        public static int GetDigitalActionOrigins(InputHandle inputHandle, InputActionSetHandle actionSetHandle, InputDigitalActionHandle digitalActionHandle, InputActionOrigin* originsOut) => Instance.GetDigitalActionOrigins(inputHandle, actionSetHandle, digitalActionHandle, originsOut);
        /// <summary></summary>
        public static UTF8StringPtr GetStringForDigitalActionName(InputDigitalActionHandle eActionHandle) => Instance.GetStringForDigitalActionName(eActionHandle);
        /// <summary></summary>
        public static InputAnalogActionHandle GetAnalogActionHandle(UTF8StringPtr pszActionName) => Instance.GetAnalogActionHandle(pszActionName);
        /// <summary></summary>
        public static InputAnalogActionData GetAnalogActionData(InputHandle inputHandle, InputAnalogActionHandle analogActionHandle) => Instance.GetAnalogActionData(inputHandle, analogActionHandle);
        /// <summary></summary>
        public static int GetAnalogActionOrigins(InputHandle inputHandle, InputActionSetHandle actionSetHandle, InputAnalogActionHandle analogActionHandle, InputActionOrigin* originsOut) => Instance.GetAnalogActionOrigins(inputHandle, actionSetHandle, analogActionHandle, originsOut);
        /// <summary></summary>
        public static UTF8StringPtr GetGlyphPNGForActionOrigin(InputActionOrigin eOrigin, SteamInputGlyphSize eSize, uint unFlags) => Instance.GetGlyphPNGForActionOrigin(eOrigin, eSize, unFlags);
        /// <summary></summary>
        public static UTF8StringPtr GetGlyphSVGForActionOrigin(InputActionOrigin eOrigin, uint unFlags) => Instance.GetGlyphSVGForActionOrigin(eOrigin, unFlags);
        /// <summary></summary>
        public static UTF8StringPtr GetGlyphForActionOrigin_Legacy(InputActionOrigin eOrigin) => Instance.GetGlyphForActionOrigin_Legacy(eOrigin);
        /// <summary></summary>
        public static UTF8StringPtr GetStringForActionOrigin(InputActionOrigin eOrigin) => Instance.GetStringForActionOrigin(eOrigin);
        /// <summary></summary>
        public static UTF8StringPtr GetStringForAnalogActionName(InputAnalogActionHandle eActionHandle) => Instance.GetStringForAnalogActionName(eActionHandle);
        /// <summary></summary>
        public static void StopAnalogActionMomentum(InputHandle inputHandle, InputAnalogActionHandle eAction) => Instance.StopAnalogActionMomentum(inputHandle, eAction);
        /// <summary></summary>
        public static InputMotionData GetMotionData(InputHandle inputHandle) => Instance.GetMotionData(inputHandle);
        /// <summary></summary>
        public static void TriggerVibration(InputHandle inputHandle, ushort usLeftSpeed, ushort usRightSpeed) => Instance.TriggerVibration(inputHandle, usLeftSpeed, usRightSpeed);
        /// <summary></summary>
        public static void TriggerVibrationExtended(InputHandle inputHandle, ushort usLeftSpeed, ushort usRightSpeed, ushort usLeftTriggerSpeed, ushort usRightTriggerSpeed) => Instance.TriggerVibrationExtended(inputHandle, usLeftSpeed, usRightSpeed, usLeftTriggerSpeed, usRightTriggerSpeed);
        /// <summary></summary>
        public static void TriggerSimpleHapticEvent(InputHandle inputHandle, ControllerHapticLocation eHapticLocation, byte nIntensity, char nGainDB, byte nOtherIntensity, char nOtherGainDB) => Instance.TriggerSimpleHapticEvent(inputHandle, eHapticLocation, nIntensity, nGainDB, nOtherIntensity, nOtherGainDB);
        /// <summary></summary>
        public static void SetLEDColor(InputHandle inputHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags) => Instance.SetLEDColor(inputHandle, nColorR, nColorG, nColorB, nFlags);
        /// <summary></summary>
        public static void Legacy_TriggerHapticPulse(InputHandle inputHandle, SteamControllerPad eTargetPad, ushort usDurationMicroSec) => Instance.Legacy_TriggerHapticPulse(inputHandle, eTargetPad, usDurationMicroSec);
        /// <summary></summary>
        public static void Legacy_TriggerRepeatedHapticPulse(InputHandle inputHandle, SteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags) => Instance.Legacy_TriggerRepeatedHapticPulse(inputHandle, eTargetPad, usDurationMicroSec, usOffMicroSec, unRepeat, nFlags);
        /// <summary></summary>
        public static bool ShowBindingPanel(InputHandle inputHandle) => Instance.ShowBindingPanel(inputHandle);
        /// <summary></summary>
        public static SteamInputType GetInputTypeForHandle(InputHandle inputHandle) => Instance.GetInputTypeForHandle(inputHandle);
        /// <summary></summary>
        public static InputHandle GetControllerForGamepadIndex(int nIndex) => Instance.GetControllerForGamepadIndex(nIndex);
        /// <summary></summary>
        public static int GetGamepadIndexForController(InputHandle ulinputHandle) => Instance.GetGamepadIndexForController(ulinputHandle);
        /// <summary></summary>
        public static UTF8StringPtr GetStringForXboxOrigin(XboxOrigin eOrigin) => Instance.GetStringForXboxOrigin(eOrigin);
        /// <summary></summary>
        public static UTF8StringPtr GetGlyphForXboxOrigin(XboxOrigin eOrigin) => Instance.GetGlyphForXboxOrigin(eOrigin);
        /// <summary></summary>
        public static InputActionOrigin GetActionOriginFromXboxOrigin(InputHandle inputHandle, XboxOrigin eOrigin) => Instance.GetActionOriginFromXboxOrigin(inputHandle, eOrigin);
        /// <summary></summary>
        public static InputActionOrigin TranslateActionOrigin(SteamInputType eDestinationInputType, InputActionOrigin eSourceOrigin) => Instance.TranslateActionOrigin(eDestinationInputType, eSourceOrigin);
        /// <summary></summary>
        public static bool GetDeviceBindingRevision(InputHandle inputHandle, int* pMajor, int* pMinor) => Instance.GetDeviceBindingRevision(inputHandle, pMajor, pMinor);
        /// <summary></summary>
        public static uint GetRemotePlaySessionID(InputHandle inputHandle) => Instance.GetRemotePlaySessionID(inputHandle);
        /// <summary></summary>
        public static ushort GetSessionInputConfigurationSettings() => Instance.GetSessionInputConfigurationSettings();
        /// <summary></summary>
        public static void SetDualSenseTriggerEffect(InputHandle inputHandle, Unknown* pParam) => Instance.SetDualSenseTriggerEffect(inputHandle, pParam);
    }
}