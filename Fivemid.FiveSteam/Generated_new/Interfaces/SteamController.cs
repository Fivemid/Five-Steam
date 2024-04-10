using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamController
    {
        public static ISteamController.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamController_v008", CallingConvention = Platform.CC)]
        private static extern ISteamController.Instance Accessor();
        /// missing documentation
        public static bool Init() => Instance.Init();
        /// missing documentation
        public static bool Shutdown() => Instance.Shutdown();
        /// missing documentation
        public static void RunFrame() => Instance.RunFrame();
        /// missing documentation
        public static int GetConnectedControllers(ControllerHandle* handlesOut) => Instance.GetConnectedControllers(handlesOut);
        /// missing documentation
        public static ControllerActionSetHandle GetActionSetHandle(UTF8StringPtr pszActionSetName) => Instance.GetActionSetHandle(pszActionSetName);
        /// missing documentation
        public static void ActivateActionSet(ControllerHandle controllerHandle, ControllerActionSetHandle actionSetHandle) => Instance.ActivateActionSet(controllerHandle, actionSetHandle);
        /// missing documentation
        public static ControllerActionSetHandle GetCurrentActionSet(ControllerHandle controllerHandle) => Instance.GetCurrentActionSet(controllerHandle);
        /// missing documentation
        public static void ActivateActionSetLayer(ControllerHandle controllerHandle, ControllerActionSetHandle actionSetLayerHandle) => Instance.ActivateActionSetLayer(controllerHandle, actionSetLayerHandle);
        /// missing documentation
        public static void DeactivateActionSetLayer(ControllerHandle controllerHandle, ControllerActionSetHandle actionSetLayerHandle) => Instance.DeactivateActionSetLayer(controllerHandle, actionSetLayerHandle);
        /// missing documentation
        public static void DeactivateAllActionSetLayers(ControllerHandle controllerHandle) => Instance.DeactivateAllActionSetLayers(controllerHandle);
        /// missing documentation
        public static int GetActiveActionSetLayers(ControllerHandle controllerHandle, ControllerActionSetHandle* handlesOut) => Instance.GetActiveActionSetLayers(controllerHandle, handlesOut);
        /// missing documentation
        public static ControllerDigitalActionHandle GetDigitalActionHandle(UTF8StringPtr pszActionName) => Instance.GetDigitalActionHandle(pszActionName);
        /// missing documentation
        public static InputDigitalActionData GetDigitalActionData(ControllerHandle controllerHandle, ControllerDigitalActionHandle digitalActionHandle) => Instance.GetDigitalActionData(controllerHandle, digitalActionHandle);
        /// missing documentation
        public static int GetDigitalActionOrigins(ControllerHandle controllerHandle, ControllerActionSetHandle actionSetHandle, ControllerDigitalActionHandle digitalActionHandle, ControllerActionOrigin* originsOut) => Instance.GetDigitalActionOrigins(controllerHandle, actionSetHandle, digitalActionHandle, originsOut);
        /// missing documentation
        public static ControllerAnalogActionHandle GetAnalogActionHandle(UTF8StringPtr pszActionName) => Instance.GetAnalogActionHandle(pszActionName);
        /// missing documentation
        public static InputAnalogActionData GetAnalogActionData(ControllerHandle controllerHandle, ControllerAnalogActionHandle analogActionHandle) => Instance.GetAnalogActionData(controllerHandle, analogActionHandle);
        /// missing documentation
        public static int GetAnalogActionOrigins(ControllerHandle controllerHandle, ControllerActionSetHandle actionSetHandle, ControllerAnalogActionHandle analogActionHandle, ControllerActionOrigin* originsOut) => Instance.GetAnalogActionOrigins(controllerHandle, actionSetHandle, analogActionHandle, originsOut);
        /// missing documentation
        public static UTF8StringPtr GetGlyphForActionOrigin(ControllerActionOrigin eOrigin) => Instance.GetGlyphForActionOrigin(eOrigin);
        /// missing documentation
        public static UTF8StringPtr GetStringForActionOrigin(ControllerActionOrigin eOrigin) => Instance.GetStringForActionOrigin(eOrigin);
        /// missing documentation
        public static void StopAnalogActionMomentum(ControllerHandle controllerHandle, ControllerAnalogActionHandle eAction) => Instance.StopAnalogActionMomentum(controllerHandle, eAction);
        /// missing documentation
        public static InputMotionData GetMotionData(ControllerHandle controllerHandle) => Instance.GetMotionData(controllerHandle);
        /// missing documentation
        public static void TriggerHapticPulse(ControllerHandle controllerHandle, SteamControllerPad eTargetPad, ushort usDurationMicroSec) => Instance.TriggerHapticPulse(controllerHandle, eTargetPad, usDurationMicroSec);
        /// missing documentation
        public static void TriggerRepeatedHapticPulse(ControllerHandle controllerHandle, SteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags) => Instance.TriggerRepeatedHapticPulse(controllerHandle, eTargetPad, usDurationMicroSec, usOffMicroSec, unRepeat, nFlags);
        /// missing documentation
        public static void TriggerVibration(ControllerHandle controllerHandle, ushort usLeftSpeed, ushort usRightSpeed) => Instance.TriggerVibration(controllerHandle, usLeftSpeed, usRightSpeed);
        /// missing documentation
        public static void SetLEDColor(ControllerHandle controllerHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags) => Instance.SetLEDColor(controllerHandle, nColorR, nColorG, nColorB, nFlags);
        /// missing documentation
        public static bool ShowBindingPanel(ControllerHandle controllerHandle) => Instance.ShowBindingPanel(controllerHandle);
        /// missing documentation
        public static SteamInputType GetInputTypeForHandle(ControllerHandle controllerHandle) => Instance.GetInputTypeForHandle(controllerHandle);
        /// missing documentation
        public static ControllerHandle GetControllerForGamepadIndex(int nIndex) => Instance.GetControllerForGamepadIndex(nIndex);
        /// missing documentation
        public static int GetGamepadIndexForController(ControllerHandle ulControllerHandle) => Instance.GetGamepadIndexForController(ulControllerHandle);
        /// missing documentation
        public static UTF8StringPtr GetStringForXboxOrigin(XboxOrigin eOrigin) => Instance.GetStringForXboxOrigin(eOrigin);
        /// missing documentation
        public static UTF8StringPtr GetGlyphForXboxOrigin(XboxOrigin eOrigin) => Instance.GetGlyphForXboxOrigin(eOrigin);
        /// missing documentation
        public static ControllerActionOrigin GetActionOriginFromXboxOrigin(ControllerHandle controllerHandle, XboxOrigin eOrigin) => Instance.GetActionOriginFromXboxOrigin(controllerHandle, eOrigin);
        /// missing documentation
        public static ControllerActionOrigin TranslateActionOrigin(SteamInputType eDestinationInputType, ControllerActionOrigin eSourceOrigin) => Instance.TranslateActionOrigin(eDestinationInputType, eSourceOrigin);
        /// missing documentation
        public static bool GetControllerBindingRevision(ControllerHandle controllerHandle, int* pMajor, int* pMinor) => Instance.GetControllerBindingRevision(controllerHandle, pMajor, pMinor);
    }
}