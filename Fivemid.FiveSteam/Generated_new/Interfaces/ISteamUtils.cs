using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ISteamUtils</summary>
    public unsafe interface ISteamUtils
    {
        public uint GetSecondsSinceAppActive();
        public uint GetSecondsSinceComputerActive();
        public Universe GetConnectedUniverse();
        public uint GetServerRealTime();
        public UTF8StringPtr GetIPCountry();
        public bool GetImageSize(int iImage, uint* pnWidth, uint* pnHeight);
        public bool GetImageRGBA(int iImage, byte* pubDest, int nDestBufferSize);
        public byte GetCurrentBatteryPower();
        public uint GetAppID();
        public void SetOverlayNotificationPosition(NotificationPosition eNotificationPosition);
        public bool IsAPICallCompleted(SteamAPICall hSteamAPICall, bool* pbFailed);
        public SteamAPICallFailure GetAPICallFailureReason(SteamAPICall hSteamAPICall);
        public bool GetAPICallResult(SteamAPICall hSteamAPICall, void* pCallback, int cubCallback, int iCallbackExpected, bool* pbFailed);
        public uint GetIPCCallCount();
        public void SetWarningMessageHook(Unknown pFunction);
        public bool IsOverlayEnabled();
        public bool BOverlayNeedsPresent();
        public SteamAPICall CheckFileSignature(UTF8StringPtr szFileName);
        public bool ShowGamepadTextInput(GamepadTextInputMode eInputMode, GamepadTextInputLineMode eLineInputMode, UTF8StringPtr pchDescription, uint unCharMax, UTF8StringPtr pchExistingText);
        public uint GetEnteredGamepadTextLength();
        public bool GetEnteredGamepadTextInput(char* pchText, uint cchText);
        public UTF8StringPtr GetSteamUILanguage();
        public bool IsSteamRunningInVR();
        public void SetOverlayNotificationInset(int nHorizontalInset, int nVerticalInset);
        public bool IsSteamInBigPictureMode();
        public void StartVRDashboard();
        public bool IsVRHeadsetStreamingEnabled();
        public void SetVRHeadsetStreamingEnabled(bool bEnabled);
        public bool IsSteamChinaLauncher();
        public bool InitFilterText(uint unFilterOptions);
        public int FilterText(TextFilteringContext eContext, SteamId sourceSteamID, UTF8StringPtr pchInputMessage, char* pchOutFilteredText, uint nByteSizeOutFilteredText);
        public SteamIPv6ConnectivityState GetIPv6ConnectivityState(SteamIPv6ConnectivityProtocol eProtocol);
        public bool IsSteamRunningOnSteamDeck();
        public bool ShowFloatingGamepadTextInput(FloatingGamepadTextInputMode eKeyboardMode, int nTextFieldXPosition, int nTextFieldYPosition, int nTextFieldWidth, int nTextFieldHeight);
        public void SetGameLauncherMode(bool bLauncherMode);
        public bool DismissFloatingGamepadTextInput();
        public bool DismissGamepadTextInput();
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUtils_GetSecondsSinceAppActive", CallingConvention = Platform.CC)]
        internal static extern uint GetSecondsSinceAppActive(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUtils_GetSecondsSinceComputerActive", CallingConvention = Platform.CC)]
        internal static extern uint GetSecondsSinceComputerActive(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUtils_GetConnectedUniverse", CallingConvention = Platform.CC)]
        internal static extern Universe GetConnectedUniverse(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUtils_GetServerRealTime", CallingConvention = Platform.CC)]
        internal static extern uint GetServerRealTime(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUtils_GetIPCountry", CallingConvention = Platform.CC)]
        internal static extern UTF8StringPtr GetIPCountry(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUtils_GetImageSize", CallingConvention = Platform.CC)]
        internal static extern bool GetImageSize(void* self, int iImage, uint* pnWidth, uint* pnHeight);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUtils_GetImageRGBA", CallingConvention = Platform.CC)]
        internal static extern bool GetImageRGBA(void* self, int iImage, byte* pubDest, int nDestBufferSize);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUtils_GetCurrentBatteryPower", CallingConvention = Platform.CC)]
        internal static extern byte GetCurrentBatteryPower(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUtils_GetAppID", CallingConvention = Platform.CC)]
        internal static extern uint GetAppID(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUtils_SetOverlayNotificationPosition", CallingConvention = Platform.CC)]
        internal static extern void SetOverlayNotificationPosition(void* self, NotificationPosition eNotificationPosition);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUtils_IsAPICallCompleted", CallingConvention = Platform.CC)]
        internal static extern bool IsAPICallCompleted(void* self, SteamAPICall hSteamAPICall, bool* pbFailed);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUtils_GetAPICallFailureReason", CallingConvention = Platform.CC)]
        internal static extern SteamAPICallFailure GetAPICallFailureReason(void* self, SteamAPICall hSteamAPICall);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUtils_GetAPICallResult", CallingConvention = Platform.CC)]
        internal static extern bool GetAPICallResult(void* self, SteamAPICall hSteamAPICall, void* pCallback, int cubCallback, int iCallbackExpected, bool* pbFailed);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUtils_GetIPCCallCount", CallingConvention = Platform.CC)]
        internal static extern uint GetIPCCallCount(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUtils_SetWarningMessageHook", CallingConvention = Platform.CC)]
        internal static extern void SetWarningMessageHook(void* self, Unknown pFunction);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUtils_IsOverlayEnabled", CallingConvention = Platform.CC)]
        internal static extern bool IsOverlayEnabled(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUtils_BOverlayNeedsPresent", CallingConvention = Platform.CC)]
        internal static extern bool BOverlayNeedsPresent(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUtils_CheckFileSignature", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall CheckFileSignature(void* self, UTF8StringPtr szFileName);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUtils_ShowGamepadTextInput", CallingConvention = Platform.CC)]
        internal static extern bool ShowGamepadTextInput(void* self, GamepadTextInputMode eInputMode, GamepadTextInputLineMode eLineInputMode, UTF8StringPtr pchDescription, uint unCharMax, UTF8StringPtr pchExistingText);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUtils_GetEnteredGamepadTextLength", CallingConvention = Platform.CC)]
        internal static extern uint GetEnteredGamepadTextLength(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUtils_GetEnteredGamepadTextInput", CallingConvention = Platform.CC)]
        internal static extern bool GetEnteredGamepadTextInput(void* self, char* pchText, uint cchText);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUtils_GetSteamUILanguage", CallingConvention = Platform.CC)]
        internal static extern UTF8StringPtr GetSteamUILanguage(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUtils_IsSteamRunningInVR", CallingConvention = Platform.CC)]
        internal static extern bool IsSteamRunningInVR(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUtils_SetOverlayNotificationInset", CallingConvention = Platform.CC)]
        internal static extern void SetOverlayNotificationInset(void* self, int nHorizontalInset, int nVerticalInset);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUtils_IsSteamInBigPictureMode", CallingConvention = Platform.CC)]
        internal static extern bool IsSteamInBigPictureMode(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUtils_StartVRDashboard", CallingConvention = Platform.CC)]
        internal static extern void StartVRDashboard(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUtils_IsVRHeadsetStreamingEnabled", CallingConvention = Platform.CC)]
        internal static extern bool IsVRHeadsetStreamingEnabled(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUtils_SetVRHeadsetStreamingEnabled", CallingConvention = Platform.CC)]
        internal static extern void SetVRHeadsetStreamingEnabled(void* self, bool bEnabled);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUtils_IsSteamChinaLauncher", CallingConvention = Platform.CC)]
        internal static extern bool IsSteamChinaLauncher(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUtils_InitFilterText", CallingConvention = Platform.CC)]
        internal static extern bool InitFilterText(void* self, uint unFilterOptions);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUtils_FilterText", CallingConvention = Platform.CC)]
        internal static extern int FilterText(void* self, TextFilteringContext eContext, SteamId sourceSteamID, UTF8StringPtr pchInputMessage, char* pchOutFilteredText, uint nByteSizeOutFilteredText);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUtils_GetIPv6ConnectivityState", CallingConvention = Platform.CC)]
        internal static extern SteamIPv6ConnectivityState GetIPv6ConnectivityState(void* self, SteamIPv6ConnectivityProtocol eProtocol);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUtils_IsSteamRunningOnSteamDeck", CallingConvention = Platform.CC)]
        internal static extern bool IsSteamRunningOnSteamDeck(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUtils_ShowFloatingGamepadTextInput", CallingConvention = Platform.CC)]
        internal static extern bool ShowFloatingGamepadTextInput(void* self, FloatingGamepadTextInputMode eKeyboardMode, int nTextFieldXPosition, int nTextFieldYPosition, int nTextFieldWidth, int nTextFieldHeight);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUtils_SetGameLauncherMode", CallingConvention = Platform.CC)]
        internal static extern void SetGameLauncherMode(void* self, bool bLauncherMode);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUtils_DismissFloatingGamepadTextInput", CallingConvention = Platform.CC)]
        internal static extern bool DismissFloatingGamepadTextInput(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamUtils_DismissGamepadTextInput", CallingConvention = Platform.CC)]
        internal static extern bool DismissGamepadTextInput(void* self);
        public struct Instance : ISteamUtils
        {
            public void* self;
            public uint GetSecondsSinceAppActive() => ISteamUtils.GetSecondsSinceAppActive(self);
            public uint GetSecondsSinceComputerActive() => ISteamUtils.GetSecondsSinceComputerActive(self);
            public Universe GetConnectedUniverse() => ISteamUtils.GetConnectedUniverse(self);
            public uint GetServerRealTime() => ISteamUtils.GetServerRealTime(self);
            public UTF8StringPtr GetIPCountry() => ISteamUtils.GetIPCountry(self);
            public bool GetImageSize(int iImage, uint* pnWidth, uint* pnHeight) => ISteamUtils.GetImageSize(self, iImage, pnWidth, pnHeight);
            public bool GetImageRGBA(int iImage, byte* pubDest, int nDestBufferSize) => ISteamUtils.GetImageRGBA(self, iImage, pubDest, nDestBufferSize);
            public byte GetCurrentBatteryPower() => ISteamUtils.GetCurrentBatteryPower(self);
            public uint GetAppID() => ISteamUtils.GetAppID(self);
            public void SetOverlayNotificationPosition(NotificationPosition eNotificationPosition) => ISteamUtils.SetOverlayNotificationPosition(self, eNotificationPosition);
            public bool IsAPICallCompleted(SteamAPICall hSteamAPICall, bool* pbFailed) => ISteamUtils.IsAPICallCompleted(self, hSteamAPICall, pbFailed);
            public SteamAPICallFailure GetAPICallFailureReason(SteamAPICall hSteamAPICall) => ISteamUtils.GetAPICallFailureReason(self, hSteamAPICall);
            public bool GetAPICallResult(SteamAPICall hSteamAPICall, void* pCallback, int cubCallback, int iCallbackExpected, bool* pbFailed) => ISteamUtils.GetAPICallResult(self, hSteamAPICall, pCallback, cubCallback, iCallbackExpected, pbFailed);
            public uint GetIPCCallCount() => ISteamUtils.GetIPCCallCount(self);
            public void SetWarningMessageHook(Unknown pFunction) => ISteamUtils.SetWarningMessageHook(self, pFunction);
            public bool IsOverlayEnabled() => ISteamUtils.IsOverlayEnabled(self);
            public bool BOverlayNeedsPresent() => ISteamUtils.BOverlayNeedsPresent(self);
            public SteamAPICall CheckFileSignature(UTF8StringPtr szFileName) => ISteamUtils.CheckFileSignature(self, szFileName);
            public bool ShowGamepadTextInput(GamepadTextInputMode eInputMode, GamepadTextInputLineMode eLineInputMode, UTF8StringPtr pchDescription, uint unCharMax, UTF8StringPtr pchExistingText) => ISteamUtils.ShowGamepadTextInput(self, eInputMode, eLineInputMode, pchDescription, unCharMax, pchExistingText);
            public uint GetEnteredGamepadTextLength() => ISteamUtils.GetEnteredGamepadTextLength(self);
            public bool GetEnteredGamepadTextInput(char* pchText, uint cchText) => ISteamUtils.GetEnteredGamepadTextInput(self, pchText, cchText);
            public UTF8StringPtr GetSteamUILanguage() => ISteamUtils.GetSteamUILanguage(self);
            public bool IsSteamRunningInVR() => ISteamUtils.IsSteamRunningInVR(self);
            public void SetOverlayNotificationInset(int nHorizontalInset, int nVerticalInset) => ISteamUtils.SetOverlayNotificationInset(self, nHorizontalInset, nVerticalInset);
            public bool IsSteamInBigPictureMode() => ISteamUtils.IsSteamInBigPictureMode(self);
            public void StartVRDashboard() => ISteamUtils.StartVRDashboard(self);
            public bool IsVRHeadsetStreamingEnabled() => ISteamUtils.IsVRHeadsetStreamingEnabled(self);
            public void SetVRHeadsetStreamingEnabled(bool bEnabled) => ISteamUtils.SetVRHeadsetStreamingEnabled(self, bEnabled);
            public bool IsSteamChinaLauncher() => ISteamUtils.IsSteamChinaLauncher(self);
            public bool InitFilterText(uint unFilterOptions) => ISteamUtils.InitFilterText(self, unFilterOptions);
            public int FilterText(TextFilteringContext eContext, SteamId sourceSteamID, UTF8StringPtr pchInputMessage, char* pchOutFilteredText, uint nByteSizeOutFilteredText) => ISteamUtils.FilterText(self, eContext, sourceSteamID, pchInputMessage, pchOutFilteredText, nByteSizeOutFilteredText);
            public SteamIPv6ConnectivityState GetIPv6ConnectivityState(SteamIPv6ConnectivityProtocol eProtocol) => ISteamUtils.GetIPv6ConnectivityState(self, eProtocol);
            public bool IsSteamRunningOnSteamDeck() => ISteamUtils.IsSteamRunningOnSteamDeck(self);
            public bool ShowFloatingGamepadTextInput(FloatingGamepadTextInputMode eKeyboardMode, int nTextFieldXPosition, int nTextFieldYPosition, int nTextFieldWidth, int nTextFieldHeight) => ISteamUtils.ShowFloatingGamepadTextInput(self, eKeyboardMode, nTextFieldXPosition, nTextFieldYPosition, nTextFieldWidth, nTextFieldHeight);
            public void SetGameLauncherMode(bool bLauncherMode) => ISteamUtils.SetGameLauncherMode(self, bLauncherMode);
            public bool DismissFloatingGamepadTextInput() => ISteamUtils.DismissFloatingGamepadTextInput(self);
            public bool DismissGamepadTextInput() => ISteamUtils.DismissGamepadTextInput(self);
        }
    }
}