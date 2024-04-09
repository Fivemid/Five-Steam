using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamController
    {
        public static ISteamController.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamController_v008", CallingConvention = Platform.CC)]
        private static extern ISteamController.Instance Accessor();
        /// <summary></summary>
        public static bool Init() => Instance.Init();
        /// <summary></summary>
        public static bool Shutdown() => Instance.Shutdown();
        /// <summary></summary>
        public static void RunFrame() => Instance.RunFrame();
        /// <summary></summary>
        public static int GetConnectedControllers(ControllerHandle* handlesOut) => Instance.GetConnectedControllers(handlesOut);
        /// <summary></summary>
        public static ControllerActionSetHandle GetActionSetHandle(UTF8StringPtr pszActionSetName) => Instance.GetActionSetHandle(pszActionSetName);
        /// <summary></summary>
        public static void ActivateActionSet(ControllerHandle controllerHandle, ControllerActionSetHandle actionSetHandle) => Instance.ActivateActionSet(controllerHandle, actionSetHandle);
        /// <summary></summary>
        public static ControllerActionSetHandle GetCurrentActionSet(ControllerHandle controllerHandle) => Instance.GetCurrentActionSet(controllerHandle);
        /// <summary></summary>
        public static void ActivateActionSetLayer(ControllerHandle controllerHandle, ControllerActionSetHandle actionSetLayerHandle) => Instance.ActivateActionSetLayer(controllerHandle, actionSetLayerHandle);
        /// <summary></summary>
        public static void DeactivateActionSetLayer(ControllerHandle controllerHandle, ControllerActionSetHandle actionSetLayerHandle) => Instance.DeactivateActionSetLayer(controllerHandle, actionSetLayerHandle);
        /// <summary></summary>
        public static void DeactivateAllActionSetLayers(ControllerHandle controllerHandle) => Instance.DeactivateAllActionSetLayers(controllerHandle);
        /// <summary></summary>
        public static int GetActiveActionSetLayers(ControllerHandle controllerHandle, ControllerActionSetHandle* handlesOut) => Instance.GetActiveActionSetLayers(controllerHandle, handlesOut);
        /// <summary></summary>
        public static ControllerDigitalActionHandle GetDigitalActionHandle(UTF8StringPtr pszActionName) => Instance.GetDigitalActionHandle(pszActionName);
        /// <summary></summary>
        public static InputDigitalActionData GetDigitalActionData(ControllerHandle controllerHandle, ControllerDigitalActionHandle digitalActionHandle) => Instance.GetDigitalActionData(controllerHandle, digitalActionHandle);
        /// <summary></summary>
        public static int GetDigitalActionOrigins(ControllerHandle controllerHandle, ControllerActionSetHandle actionSetHandle, ControllerDigitalActionHandle digitalActionHandle, ControllerActionOrigin* originsOut) => Instance.GetDigitalActionOrigins(controllerHandle, actionSetHandle, digitalActionHandle, originsOut);
        /// <summary></summary>
        public static ControllerAnalogActionHandle GetAnalogActionHandle(UTF8StringPtr pszActionName) => Instance.GetAnalogActionHandle(pszActionName);
        /// <summary></summary>
        public static InputAnalogActionData GetAnalogActionData(ControllerHandle controllerHandle, ControllerAnalogActionHandle analogActionHandle) => Instance.GetAnalogActionData(controllerHandle, analogActionHandle);
        /// <summary></summary>
        public static int GetAnalogActionOrigins(ControllerHandle controllerHandle, ControllerActionSetHandle actionSetHandle, ControllerAnalogActionHandle analogActionHandle, ControllerActionOrigin* originsOut) => Instance.GetAnalogActionOrigins(controllerHandle, actionSetHandle, analogActionHandle, originsOut);
        /// <summary></summary>
        public static UTF8StringPtr GetGlyphForActionOrigin(ControllerActionOrigin eOrigin) => Instance.GetGlyphForActionOrigin(eOrigin);
        /// <summary></summary>
        public static UTF8StringPtr GetStringForActionOrigin(ControllerActionOrigin eOrigin) => Instance.GetStringForActionOrigin(eOrigin);
        /// <summary></summary>
        public static void StopAnalogActionMomentum(ControllerHandle controllerHandle, ControllerAnalogActionHandle eAction) => Instance.StopAnalogActionMomentum(controllerHandle, eAction);
        /// <summary></summary>
        public static InputMotionData GetMotionData(ControllerHandle controllerHandle) => Instance.GetMotionData(controllerHandle);
        /// <summary></summary>
        public static void TriggerHapticPulse(ControllerHandle controllerHandle, SteamControllerPad eTargetPad, ushort usDurationMicroSec) => Instance.TriggerHapticPulse(controllerHandle, eTargetPad, usDurationMicroSec);
        /// <summary></summary>
        public static void TriggerRepeatedHapticPulse(ControllerHandle controllerHandle, SteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags) => Instance.TriggerRepeatedHapticPulse(controllerHandle, eTargetPad, usDurationMicroSec, usOffMicroSec, unRepeat, nFlags);
        /// <summary></summary>
        public static void TriggerVibration(ControllerHandle controllerHandle, ushort usLeftSpeed, ushort usRightSpeed) => Instance.TriggerVibration(controllerHandle, usLeftSpeed, usRightSpeed);
        /// <summary></summary>
        public static void SetLEDColor(ControllerHandle controllerHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags) => Instance.SetLEDColor(controllerHandle, nColorR, nColorG, nColorB, nFlags);
        /// <summary></summary>
        public static bool ShowBindingPanel(ControllerHandle controllerHandle) => Instance.ShowBindingPanel(controllerHandle);
        /// <summary></summary>
        public static SteamInputType GetInputTypeForHandle(ControllerHandle controllerHandle) => Instance.GetInputTypeForHandle(controllerHandle);
        /// <summary></summary>
        public static ControllerHandle GetControllerForGamepadIndex(int nIndex) => Instance.GetControllerForGamepadIndex(nIndex);
        /// <summary></summary>
        public static int GetGamepadIndexForController(ControllerHandle ulControllerHandle) => Instance.GetGamepadIndexForController(ulControllerHandle);
        /// <summary></summary>
        public static UTF8StringPtr GetStringForXboxOrigin(XboxOrigin eOrigin) => Instance.GetStringForXboxOrigin(eOrigin);
        /// <summary></summary>
        public static UTF8StringPtr GetGlyphForXboxOrigin(XboxOrigin eOrigin) => Instance.GetGlyphForXboxOrigin(eOrigin);
        /// <summary></summary>
        public static ControllerActionOrigin GetActionOriginFromXboxOrigin(ControllerHandle controllerHandle, XboxOrigin eOrigin) => Instance.GetActionOriginFromXboxOrigin(controllerHandle, eOrigin);
        /// <summary></summary>
        public static ControllerActionOrigin TranslateActionOrigin(SteamInputType eDestinationInputType, ControllerActionOrigin eSourceOrigin) => Instance.TranslateActionOrigin(eDestinationInputType, eSourceOrigin);
        /// <summary></summary>
        public static bool GetControllerBindingRevision(ControllerHandle controllerHandle, int* pMajor, int* pMinor) => Instance.GetControllerBindingRevision(controllerHandle, pMajor, pMinor);
    }
}