using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamGameServerUtils
    {
        public static ISteamUtils.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamGameServerUtils_v010", CallingConvention = Platform.CC)]
        private static extern ISteamUtils.Instance Accessor();
        /// <summary></summary>
        public static uint GetSecondsSinceAppActive() => Instance.GetSecondsSinceAppActive();
        /// <summary></summary>
        public static uint GetSecondsSinceComputerActive() => Instance.GetSecondsSinceComputerActive();
        /// <summary></summary>
        public static Universe GetConnectedUniverse() => Instance.GetConnectedUniverse();
        /// <summary></summary>
        public static uint GetServerRealTime() => Instance.GetServerRealTime();
        /// <summary></summary>
        public static UTF8StringPtr GetIPCountry() => Instance.GetIPCountry();
        /// <summary></summary>
        public static bool GetImageSize(int iImage, uint* pnWidth, uint* pnHeight) => Instance.GetImageSize(iImage, pnWidth, pnHeight);
        /// <summary></summary>
        public static bool GetImageRGBA(int iImage, byte* pubDest, int nDestBufferSize) => Instance.GetImageRGBA(iImage, pubDest, nDestBufferSize);
        /// <summary></summary>
        public static byte GetCurrentBatteryPower() => Instance.GetCurrentBatteryPower();
        /// <summary></summary>
        public static uint GetAppID() => Instance.GetAppID();
        /// <summary></summary>
        public static void SetOverlayNotificationPosition(NotificationPosition eNotificationPosition) => Instance.SetOverlayNotificationPosition(eNotificationPosition);
        /// <summary></summary>
        public static bool IsAPICallCompleted(SteamAPICall hSteamAPICall, bool* pbFailed) => Instance.IsAPICallCompleted(hSteamAPICall, pbFailed);
        /// <summary></summary>
        public static SteamAPICallFailure GetAPICallFailureReason(SteamAPICall hSteamAPICall) => Instance.GetAPICallFailureReason(hSteamAPICall);
        /// <summary></summary>
        public static bool GetAPICallResult(SteamAPICall hSteamAPICall, void* pCallback, int cubCallback, int iCallbackExpected, bool* pbFailed) => Instance.GetAPICallResult(hSteamAPICall, pCallback, cubCallback, iCallbackExpected, pbFailed);
        /// <summary></summary>
        public static uint GetIPCCallCount() => Instance.GetIPCCallCount();
        /// <summary></summary>
        public static void SetWarningMessageHook(Unknown pFunction) => Instance.SetWarningMessageHook(pFunction);
        /// <summary></summary>
        public static bool IsOverlayEnabled() => Instance.IsOverlayEnabled();
        /// <summary></summary>
        public static bool BOverlayNeedsPresent() => Instance.BOverlayNeedsPresent();
        /// <summary></summary>
        public static SteamAPICall CheckFileSignature(UTF8StringPtr szFileName) => Instance.CheckFileSignature(szFileName);
        /// <summary></summary>
        public static bool ShowGamepadTextInput(GamepadTextInputMode eInputMode, GamepadTextInputLineMode eLineInputMode, UTF8StringPtr pchDescription, uint unCharMax, UTF8StringPtr pchExistingText) => Instance.ShowGamepadTextInput(eInputMode, eLineInputMode, pchDescription, unCharMax, pchExistingText);
        /// <summary></summary>
        public static uint GetEnteredGamepadTextLength() => Instance.GetEnteredGamepadTextLength();
        /// <summary></summary>
        public static bool GetEnteredGamepadTextInput(char* pchText, uint cchText) => Instance.GetEnteredGamepadTextInput(pchText, cchText);
        /// <summary></summary>
        public static UTF8StringPtr GetSteamUILanguage() => Instance.GetSteamUILanguage();
        /// <summary></summary>
        public static bool IsSteamRunningInVR() => Instance.IsSteamRunningInVR();
        /// <summary></summary>
        public static void SetOverlayNotificationInset(int nHorizontalInset, int nVerticalInset) => Instance.SetOverlayNotificationInset(nHorizontalInset, nVerticalInset);
        /// <summary></summary>
        public static bool IsSteamInBigPictureMode() => Instance.IsSteamInBigPictureMode();
        /// <summary></summary>
        public static void StartVRDashboard() => Instance.StartVRDashboard();
        /// <summary></summary>
        public static bool IsVRHeadsetStreamingEnabled() => Instance.IsVRHeadsetStreamingEnabled();
        /// <summary></summary>
        public static void SetVRHeadsetStreamingEnabled(bool bEnabled) => Instance.SetVRHeadsetStreamingEnabled(bEnabled);
        /// <summary></summary>
        public static bool IsSteamChinaLauncher() => Instance.IsSteamChinaLauncher();
        /// <summary></summary>
        public static bool InitFilterText(uint unFilterOptions) => Instance.InitFilterText(unFilterOptions);
        /// <summary></summary>
        public static int FilterText(TextFilteringContext eContext, SteamId sourceSteamID, UTF8StringPtr pchInputMessage, char* pchOutFilteredText, uint nByteSizeOutFilteredText) => Instance.FilterText(eContext, sourceSteamID, pchInputMessage, pchOutFilteredText, nByteSizeOutFilteredText);
        /// <summary></summary>
        public static SteamIPv6ConnectivityState GetIPv6ConnectivityState(SteamIPv6ConnectivityProtocol eProtocol) => Instance.GetIPv6ConnectivityState(eProtocol);
        /// <summary></summary>
        public static bool IsSteamRunningOnSteamDeck() => Instance.IsSteamRunningOnSteamDeck();
        /// <summary></summary>
        public static bool ShowFloatingGamepadTextInput(FloatingGamepadTextInputMode eKeyboardMode, int nTextFieldXPosition, int nTextFieldYPosition, int nTextFieldWidth, int nTextFieldHeight) => Instance.ShowFloatingGamepadTextInput(eKeyboardMode, nTextFieldXPosition, nTextFieldYPosition, nTextFieldWidth, nTextFieldHeight);
        /// <summary></summary>
        public static void SetGameLauncherMode(bool bLauncherMode) => Instance.SetGameLauncherMode(bLauncherMode);
        /// <summary></summary>
        public static bool DismissFloatingGamepadTextInput() => Instance.DismissFloatingGamepadTextInput();
        /// <summary></summary>
        public static bool DismissGamepadTextInput() => Instance.DismissGamepadTextInput();
    }
}