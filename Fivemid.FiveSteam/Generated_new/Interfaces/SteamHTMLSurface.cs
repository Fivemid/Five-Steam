using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamHTMLSurface
    {
        public static ISteamHTMLSurface.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamHTMLSurface_v005", CallingConvention = Platform.CC)]
        private static extern ISteamHTMLSurface.Instance Accessor();
        /// <summary></summary>
        public static bool Init() => Instance.Init();
        /// <summary></summary>
        public static bool Shutdown() => Instance.Shutdown();
        /// <summary></summary>
        public static SteamAPICall CreateBrowser(UTF8StringPtr pchUserAgent, UTF8StringPtr pchUserCSS) => Instance.CreateBrowser(pchUserAgent, pchUserCSS);
        /// <summary></summary>
        public static void RemoveBrowser(HHTMLBrowser unBrowserHandle) => Instance.RemoveBrowser(unBrowserHandle);
        /// <summary></summary>
        public static void LoadURL(HHTMLBrowser unBrowserHandle, UTF8StringPtr pchURL, UTF8StringPtr pchPostData) => Instance.LoadURL(unBrowserHandle, pchURL, pchPostData);
        /// <summary></summary>
        public static void SetSize(HHTMLBrowser unBrowserHandle, uint unWidth, uint unHeight) => Instance.SetSize(unBrowserHandle, unWidth, unHeight);
        /// <summary></summary>
        public static void StopLoad(HHTMLBrowser unBrowserHandle) => Instance.StopLoad(unBrowserHandle);
        /// <summary></summary>
        public static void Reload(HHTMLBrowser unBrowserHandle) => Instance.Reload(unBrowserHandle);
        /// <summary></summary>
        public static void GoBack(HHTMLBrowser unBrowserHandle) => Instance.GoBack(unBrowserHandle);
        /// <summary></summary>
        public static void GoForward(HHTMLBrowser unBrowserHandle) => Instance.GoForward(unBrowserHandle);
        /// <summary></summary>
        public static void AddHeader(HHTMLBrowser unBrowserHandle, UTF8StringPtr pchKey, UTF8StringPtr pchValue) => Instance.AddHeader(unBrowserHandle, pchKey, pchValue);
        /// <summary></summary>
        public static void ExecuteJavascript(HHTMLBrowser unBrowserHandle, UTF8StringPtr pchScript) => Instance.ExecuteJavascript(unBrowserHandle, pchScript);
        /// <summary></summary>
        public static void MouseUp(HHTMLBrowser unBrowserHandle, ISteamHTMLSurface.HTMLMouseButton eMouseButton) => Instance.MouseUp(unBrowserHandle, eMouseButton);
        /// <summary></summary>
        public static void MouseDown(HHTMLBrowser unBrowserHandle, ISteamHTMLSurface.HTMLMouseButton eMouseButton) => Instance.MouseDown(unBrowserHandle, eMouseButton);
        /// <summary></summary>
        public static void MouseDoubleClick(HHTMLBrowser unBrowserHandle, ISteamHTMLSurface.HTMLMouseButton eMouseButton) => Instance.MouseDoubleClick(unBrowserHandle, eMouseButton);
        /// <summary></summary>
        public static void MouseMove(HHTMLBrowser unBrowserHandle, int x, int y) => Instance.MouseMove(unBrowserHandle, x, y);
        /// <summary></summary>
        public static void MouseWheel(HHTMLBrowser unBrowserHandle, int nDelta) => Instance.MouseWheel(unBrowserHandle, nDelta);
        /// <summary></summary>
        public static void KeyDown(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, ISteamHTMLSurface.HTMLKeyModifiers eHTMLKeyModifiers, bool bIsSystemKey) => Instance.KeyDown(unBrowserHandle, nNativeKeyCode, eHTMLKeyModifiers, bIsSystemKey);
        /// <summary></summary>
        public static void KeyUp(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, ISteamHTMLSurface.HTMLKeyModifiers eHTMLKeyModifiers) => Instance.KeyUp(unBrowserHandle, nNativeKeyCode, eHTMLKeyModifiers);
        /// <summary></summary>
        public static void KeyChar(HHTMLBrowser unBrowserHandle, uint cUnicodeChar, ISteamHTMLSurface.HTMLKeyModifiers eHTMLKeyModifiers) => Instance.KeyChar(unBrowserHandle, cUnicodeChar, eHTMLKeyModifiers);
        /// <summary></summary>
        public static void SetHorizontalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll) => Instance.SetHorizontalScroll(unBrowserHandle, nAbsolutePixelScroll);
        /// <summary></summary>
        public static void SetVerticalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll) => Instance.SetVerticalScroll(unBrowserHandle, nAbsolutePixelScroll);
        /// <summary></summary>
        public static void SetKeyFocus(HHTMLBrowser unBrowserHandle, bool bHasKeyFocus) => Instance.SetKeyFocus(unBrowserHandle, bHasKeyFocus);
        /// <summary></summary>
        public static void ViewSource(HHTMLBrowser unBrowserHandle) => Instance.ViewSource(unBrowserHandle);
        /// <summary></summary>
        public static void CopyToClipboard(HHTMLBrowser unBrowserHandle) => Instance.CopyToClipboard(unBrowserHandle);
        /// <summary></summary>
        public static void PasteFromClipboard(HHTMLBrowser unBrowserHandle) => Instance.PasteFromClipboard(unBrowserHandle);
        /// <summary></summary>
        public static void Find(HHTMLBrowser unBrowserHandle, UTF8StringPtr pchSearchStr, bool bCurrentlyInFind, bool bReverse) => Instance.Find(unBrowserHandle, pchSearchStr, bCurrentlyInFind, bReverse);
        /// <summary></summary>
        public static void StopFind(HHTMLBrowser unBrowserHandle) => Instance.StopFind(unBrowserHandle);
        /// <summary></summary>
        public static void GetLinkAtPosition(HHTMLBrowser unBrowserHandle, int x, int y) => Instance.GetLinkAtPosition(unBrowserHandle, x, y);
        /// <summary></summary>
        public static void SetCookie(UTF8StringPtr pchHostname, UTF8StringPtr pchKey, UTF8StringPtr pchValue, UTF8StringPtr pchPath, RTime32 nExpires, bool bSecure, bool bHTTPOnly) => Instance.SetCookie(pchHostname, pchKey, pchValue, pchPath, nExpires, bSecure, bHTTPOnly);
        /// <summary></summary>
        public static void SetPageScaleFactor(HHTMLBrowser unBrowserHandle, float flZoom, int nPointX, int nPointY) => Instance.SetPageScaleFactor(unBrowserHandle, flZoom, nPointX, nPointY);
        /// <summary></summary>
        public static void SetBackgroundMode(HHTMLBrowser unBrowserHandle, bool bBackgroundMode) => Instance.SetBackgroundMode(unBrowserHandle, bBackgroundMode);
        /// <summary></summary>
        public static void SetDPIScalingFactor(HHTMLBrowser unBrowserHandle, float flDPIScaling) => Instance.SetDPIScalingFactor(unBrowserHandle, flDPIScaling);
        /// <summary></summary>
        public static void OpenDeveloperTools(HHTMLBrowser unBrowserHandle) => Instance.OpenDeveloperTools(unBrowserHandle);
        /// <summary></summary>
        public static void AllowStartRequest(HHTMLBrowser unBrowserHandle, bool bAllowed) => Instance.AllowStartRequest(unBrowserHandle, bAllowed);
        /// <summary></summary>
        public static void JSDialogResponse(HHTMLBrowser unBrowserHandle, bool bResult) => Instance.JSDialogResponse(unBrowserHandle, bResult);
        /// <summary></summary>
        public static void FileLoadDialogResponse(HHTMLBrowser unBrowserHandle, UTF8StringPtr* pchSelectedFiles) => Instance.FileLoadDialogResponse(unBrowserHandle, pchSelectedFiles);
    }
}