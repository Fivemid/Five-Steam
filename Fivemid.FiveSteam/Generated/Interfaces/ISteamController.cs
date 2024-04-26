using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for ISteamController
    public unsafe interface ISteamController
    {
        public bool Init();
        public bool Shutdown();
        public void RunFrame();
        public int GetConnectedControllers(ControllerHandle* handlesOut);
        public ControllerActionSetHandle GetActionSetHandle(UTF8StringPtr pszActionSetName);
        public void ActivateActionSet(ControllerHandle controllerHandle, ControllerActionSetHandle actionSetHandle);
        public ControllerActionSetHandle GetCurrentActionSet(ControllerHandle controllerHandle);
        public void ActivateActionSetLayer(ControllerHandle controllerHandle, ControllerActionSetHandle actionSetLayerHandle);
        public void DeactivateActionSetLayer(ControllerHandle controllerHandle, ControllerActionSetHandle actionSetLayerHandle);
        public void DeactivateAllActionSetLayers(ControllerHandle controllerHandle);
        public int GetActiveActionSetLayers(ControllerHandle controllerHandle, ControllerActionSetHandle* handlesOut);
        public ControllerDigitalActionHandle GetDigitalActionHandle(UTF8StringPtr pszActionName);
        public InputDigitalActionData GetDigitalActionData(ControllerHandle controllerHandle, ControllerDigitalActionHandle digitalActionHandle);
        public int GetDigitalActionOrigins(ControllerHandle controllerHandle, ControllerActionSetHandle actionSetHandle, ControllerDigitalActionHandle digitalActionHandle, ControllerActionOrigin* originsOut);
        public ControllerAnalogActionHandle GetAnalogActionHandle(UTF8StringPtr pszActionName);
        public InputAnalogActionData GetAnalogActionData(ControllerHandle controllerHandle, ControllerAnalogActionHandle analogActionHandle);
        public int GetAnalogActionOrigins(ControllerHandle controllerHandle, ControllerActionSetHandle actionSetHandle, ControllerAnalogActionHandle analogActionHandle, ControllerActionOrigin* originsOut);
        public UTF8StringPtr GetGlyphForActionOrigin(ControllerActionOrigin eOrigin);
        public UTF8StringPtr GetStringForActionOrigin(ControllerActionOrigin eOrigin);
        public void StopAnalogActionMomentum(ControllerHandle controllerHandle, ControllerAnalogActionHandle eAction);
        public InputMotionData GetMotionData(ControllerHandle controllerHandle);
        public void TriggerHapticPulse(ControllerHandle controllerHandle, SteamControllerPad eTargetPad, ushort usDurationMicroSec);
        public void TriggerRepeatedHapticPulse(ControllerHandle controllerHandle, SteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags);
        public void TriggerVibration(ControllerHandle controllerHandle, ushort usLeftSpeed, ushort usRightSpeed);
        public void SetLEDColor(ControllerHandle controllerHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags);
        public bool ShowBindingPanel(ControllerHandle controllerHandle);
        public SteamInputType GetInputTypeForHandle(ControllerHandle controllerHandle);
        public ControllerHandle GetControllerForGamepadIndex(int nIndex);
        public int GetGamepadIndexForController(ControllerHandle ulControllerHandle);
        public UTF8StringPtr GetStringForXboxOrigin(XboxOrigin eOrigin);
        public UTF8StringPtr GetGlyphForXboxOrigin(XboxOrigin eOrigin);
        public ControllerActionOrigin GetActionOriginFromXboxOrigin(ControllerHandle controllerHandle, XboxOrigin eOrigin);
        public ControllerActionOrigin TranslateActionOrigin(SteamInputType eDestinationInputType, ControllerActionOrigin eSourceOrigin);
        public bool GetControllerBindingRevision(ControllerHandle controllerHandle, int* pMajor, int* pMinor);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamController_Init", CallingConvention = Platform.CC)]
        internal static extern bool Init(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamController_Shutdown", CallingConvention = Platform.CC)]
        internal static extern bool Shutdown(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamController_RunFrame", CallingConvention = Platform.CC)]
        internal static extern void RunFrame(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamController_GetConnectedControllers", CallingConvention = Platform.CC)]
        internal static extern int GetConnectedControllers(void* self, ControllerHandle* handlesOut);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamController_GetActionSetHandle", CallingConvention = Platform.CC)]
        internal static extern ControllerActionSetHandle GetActionSetHandle(void* self, UTF8StringPtr pszActionSetName);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamController_ActivateActionSet", CallingConvention = Platform.CC)]
        internal static extern void ActivateActionSet(void* self, ControllerHandle controllerHandle, ControllerActionSetHandle actionSetHandle);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamController_GetCurrentActionSet", CallingConvention = Platform.CC)]
        internal static extern ControllerActionSetHandle GetCurrentActionSet(void* self, ControllerHandle controllerHandle);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamController_ActivateActionSetLayer", CallingConvention = Platform.CC)]
        internal static extern void ActivateActionSetLayer(void* self, ControllerHandle controllerHandle, ControllerActionSetHandle actionSetLayerHandle);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamController_DeactivateActionSetLayer", CallingConvention = Platform.CC)]
        internal static extern void DeactivateActionSetLayer(void* self, ControllerHandle controllerHandle, ControllerActionSetHandle actionSetLayerHandle);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamController_DeactivateAllActionSetLayers", CallingConvention = Platform.CC)]
        internal static extern void DeactivateAllActionSetLayers(void* self, ControllerHandle controllerHandle);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamController_GetActiveActionSetLayers", CallingConvention = Platform.CC)]
        internal static extern int GetActiveActionSetLayers(void* self, ControllerHandle controllerHandle, ControllerActionSetHandle* handlesOut);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamController_GetDigitalActionHandle", CallingConvention = Platform.CC)]
        internal static extern ControllerDigitalActionHandle GetDigitalActionHandle(void* self, UTF8StringPtr pszActionName);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamController_GetDigitalActionData", CallingConvention = Platform.CC)]
        internal static extern InputDigitalActionData GetDigitalActionData(void* self, ControllerHandle controllerHandle, ControllerDigitalActionHandle digitalActionHandle);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamController_GetDigitalActionOrigins", CallingConvention = Platform.CC)]
        internal static extern int GetDigitalActionOrigins(void* self, ControllerHandle controllerHandle, ControllerActionSetHandle actionSetHandle, ControllerDigitalActionHandle digitalActionHandle, ControllerActionOrigin* originsOut);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamController_GetAnalogActionHandle", CallingConvention = Platform.CC)]
        internal static extern ControllerAnalogActionHandle GetAnalogActionHandle(void* self, UTF8StringPtr pszActionName);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamController_GetAnalogActionData", CallingConvention = Platform.CC)]
        internal static extern InputAnalogActionData GetAnalogActionData(void* self, ControllerHandle controllerHandle, ControllerAnalogActionHandle analogActionHandle);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamController_GetAnalogActionOrigins", CallingConvention = Platform.CC)]
        internal static extern int GetAnalogActionOrigins(void* self, ControllerHandle controllerHandle, ControllerActionSetHandle actionSetHandle, ControllerAnalogActionHandle analogActionHandle, ControllerActionOrigin* originsOut);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamController_GetGlyphForActionOrigin", CallingConvention = Platform.CC)]
        internal static extern UTF8StringPtr GetGlyphForActionOrigin(void* self, ControllerActionOrigin eOrigin);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamController_GetStringForActionOrigin", CallingConvention = Platform.CC)]
        internal static extern UTF8StringPtr GetStringForActionOrigin(void* self, ControllerActionOrigin eOrigin);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamController_StopAnalogActionMomentum", CallingConvention = Platform.CC)]
        internal static extern void StopAnalogActionMomentum(void* self, ControllerHandle controllerHandle, ControllerAnalogActionHandle eAction);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamController_GetMotionData", CallingConvention = Platform.CC)]
        internal static extern InputMotionData GetMotionData(void* self, ControllerHandle controllerHandle);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamController_TriggerHapticPulse", CallingConvention = Platform.CC)]
        internal static extern void TriggerHapticPulse(void* self, ControllerHandle controllerHandle, SteamControllerPad eTargetPad, ushort usDurationMicroSec);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamController_TriggerRepeatedHapticPulse", CallingConvention = Platform.CC)]
        internal static extern void TriggerRepeatedHapticPulse(void* self, ControllerHandle controllerHandle, SteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamController_TriggerVibration", CallingConvention = Platform.CC)]
        internal static extern void TriggerVibration(void* self, ControllerHandle controllerHandle, ushort usLeftSpeed, ushort usRightSpeed);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamController_SetLEDColor", CallingConvention = Platform.CC)]
        internal static extern void SetLEDColor(void* self, ControllerHandle controllerHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamController_ShowBindingPanel", CallingConvention = Platform.CC)]
        internal static extern bool ShowBindingPanel(void* self, ControllerHandle controllerHandle);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamController_GetInputTypeForHandle", CallingConvention = Platform.CC)]
        internal static extern SteamInputType GetInputTypeForHandle(void* self, ControllerHandle controllerHandle);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamController_GetControllerForGamepadIndex", CallingConvention = Platform.CC)]
        internal static extern ControllerHandle GetControllerForGamepadIndex(void* self, int nIndex);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamController_GetGamepadIndexForController", CallingConvention = Platform.CC)]
        internal static extern int GetGamepadIndexForController(void* self, ControllerHandle ulControllerHandle);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamController_GetStringForXboxOrigin", CallingConvention = Platform.CC)]
        internal static extern UTF8StringPtr GetStringForXboxOrigin(void* self, XboxOrigin eOrigin);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamController_GetGlyphForXboxOrigin", CallingConvention = Platform.CC)]
        internal static extern UTF8StringPtr GetGlyphForXboxOrigin(void* self, XboxOrigin eOrigin);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamController_GetActionOriginFromXboxOrigin", CallingConvention = Platform.CC)]
        internal static extern ControllerActionOrigin GetActionOriginFromXboxOrigin(void* self, ControllerHandle controllerHandle, XboxOrigin eOrigin);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamController_TranslateActionOrigin", CallingConvention = Platform.CC)]
        internal static extern ControllerActionOrigin TranslateActionOrigin(void* self, SteamInputType eDestinationInputType, ControllerActionOrigin eSourceOrigin);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamController_GetControllerBindingRevision", CallingConvention = Platform.CC)]
        internal static extern bool GetControllerBindingRevision(void* self, ControllerHandle controllerHandle, int* pMajor, int* pMinor);
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
        public struct Instance : ISteamController
        {
            public void* self;
            public bool Init() => ISteamController.Init(self);
            public bool Shutdown() => ISteamController.Shutdown(self);
            public void RunFrame() => ISteamController.RunFrame(self);
            public int GetConnectedControllers(ControllerHandle* handlesOut) => ISteamController.GetConnectedControllers(self, handlesOut);
            public ControllerActionSetHandle GetActionSetHandle(UTF8StringPtr pszActionSetName) => ISteamController.GetActionSetHandle(self, pszActionSetName);
            public void ActivateActionSet(ControllerHandle controllerHandle, ControllerActionSetHandle actionSetHandle) => ISteamController.ActivateActionSet(self, controllerHandle, actionSetHandle);
            public ControllerActionSetHandle GetCurrentActionSet(ControllerHandle controllerHandle) => ISteamController.GetCurrentActionSet(self, controllerHandle);
            public void ActivateActionSetLayer(ControllerHandle controllerHandle, ControllerActionSetHandle actionSetLayerHandle) => ISteamController.ActivateActionSetLayer(self, controllerHandle, actionSetLayerHandle);
            public void DeactivateActionSetLayer(ControllerHandle controllerHandle, ControllerActionSetHandle actionSetLayerHandle) => ISteamController.DeactivateActionSetLayer(self, controllerHandle, actionSetLayerHandle);
            public void DeactivateAllActionSetLayers(ControllerHandle controllerHandle) => ISteamController.DeactivateAllActionSetLayers(self, controllerHandle);
            public int GetActiveActionSetLayers(ControllerHandle controllerHandle, ControllerActionSetHandle* handlesOut) => ISteamController.GetActiveActionSetLayers(self, controllerHandle, handlesOut);
            public ControllerDigitalActionHandle GetDigitalActionHandle(UTF8StringPtr pszActionName) => ISteamController.GetDigitalActionHandle(self, pszActionName);
            public InputDigitalActionData GetDigitalActionData(ControllerHandle controllerHandle, ControllerDigitalActionHandle digitalActionHandle) => ISteamController.GetDigitalActionData(self, controllerHandle, digitalActionHandle);
            public int GetDigitalActionOrigins(ControllerHandle controllerHandle, ControllerActionSetHandle actionSetHandle, ControllerDigitalActionHandle digitalActionHandle, ControllerActionOrigin* originsOut) => ISteamController.GetDigitalActionOrigins(self, controllerHandle, actionSetHandle, digitalActionHandle, originsOut);
            public ControllerAnalogActionHandle GetAnalogActionHandle(UTF8StringPtr pszActionName) => ISteamController.GetAnalogActionHandle(self, pszActionName);
            public InputAnalogActionData GetAnalogActionData(ControllerHandle controllerHandle, ControllerAnalogActionHandle analogActionHandle) => ISteamController.GetAnalogActionData(self, controllerHandle, analogActionHandle);
            public int GetAnalogActionOrigins(ControllerHandle controllerHandle, ControllerActionSetHandle actionSetHandle, ControllerAnalogActionHandle analogActionHandle, ControllerActionOrigin* originsOut) => ISteamController.GetAnalogActionOrigins(self, controllerHandle, actionSetHandle, analogActionHandle, originsOut);
            public UTF8StringPtr GetGlyphForActionOrigin(ControllerActionOrigin eOrigin) => ISteamController.GetGlyphForActionOrigin(self, eOrigin);
            public UTF8StringPtr GetStringForActionOrigin(ControllerActionOrigin eOrigin) => ISteamController.GetStringForActionOrigin(self, eOrigin);
            public void StopAnalogActionMomentum(ControllerHandle controllerHandle, ControllerAnalogActionHandle eAction) => ISteamController.StopAnalogActionMomentum(self, controllerHandle, eAction);
            public InputMotionData GetMotionData(ControllerHandle controllerHandle) => ISteamController.GetMotionData(self, controllerHandle);
            public void TriggerHapticPulse(ControllerHandle controllerHandle, SteamControllerPad eTargetPad, ushort usDurationMicroSec) => ISteamController.TriggerHapticPulse(self, controllerHandle, eTargetPad, usDurationMicroSec);
            public void TriggerRepeatedHapticPulse(ControllerHandle controllerHandle, SteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags) => ISteamController.TriggerRepeatedHapticPulse(self, controllerHandle, eTargetPad, usDurationMicroSec, usOffMicroSec, unRepeat, nFlags);
            public void TriggerVibration(ControllerHandle controllerHandle, ushort usLeftSpeed, ushort usRightSpeed) => ISteamController.TriggerVibration(self, controllerHandle, usLeftSpeed, usRightSpeed);
            public void SetLEDColor(ControllerHandle controllerHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags) => ISteamController.SetLEDColor(self, controllerHandle, nColorR, nColorG, nColorB, nFlags);
            public bool ShowBindingPanel(ControllerHandle controllerHandle) => ISteamController.ShowBindingPanel(self, controllerHandle);
            public SteamInputType GetInputTypeForHandle(ControllerHandle controllerHandle) => ISteamController.GetInputTypeForHandle(self, controllerHandle);
            public ControllerHandle GetControllerForGamepadIndex(int nIndex) => ISteamController.GetControllerForGamepadIndex(self, nIndex);
            public int GetGamepadIndexForController(ControllerHandle ulControllerHandle) => ISteamController.GetGamepadIndexForController(self, ulControllerHandle);
            public UTF8StringPtr GetStringForXboxOrigin(XboxOrigin eOrigin) => ISteamController.GetStringForXboxOrigin(self, eOrigin);
            public UTF8StringPtr GetGlyphForXboxOrigin(XboxOrigin eOrigin) => ISteamController.GetGlyphForXboxOrigin(self, eOrigin);
            public ControllerActionOrigin GetActionOriginFromXboxOrigin(ControllerHandle controllerHandle, XboxOrigin eOrigin) => ISteamController.GetActionOriginFromXboxOrigin(self, controllerHandle, eOrigin);
            public ControllerActionOrigin TranslateActionOrigin(SteamInputType eDestinationInputType, ControllerActionOrigin eSourceOrigin) => ISteamController.TranslateActionOrigin(self, eDestinationInputType, eSourceOrigin);
            public bool GetControllerBindingRevision(ControllerHandle controllerHandle, int* pMajor, int* pMinor) => ISteamController.GetControllerBindingRevision(self, controllerHandle, pMajor, pMinor);
        }
    }
}