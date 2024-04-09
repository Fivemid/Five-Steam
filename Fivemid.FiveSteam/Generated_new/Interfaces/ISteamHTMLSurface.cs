using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ISteamHTMLSurface</summary>
    public unsafe interface ISteamHTMLSurface
    {
        public bool Init();
        public bool Shutdown();
        public SteamAPICall CreateBrowser(UTF8StringPtr pchUserAgent, UTF8StringPtr pchUserCSS);
        public void RemoveBrowser(HHTMLBrowser unBrowserHandle);
        public void LoadURL(HHTMLBrowser unBrowserHandle, UTF8StringPtr pchURL, UTF8StringPtr pchPostData);
        public void SetSize(HHTMLBrowser unBrowserHandle, uint unWidth, uint unHeight);
        public void StopLoad(HHTMLBrowser unBrowserHandle);
        public void Reload(HHTMLBrowser unBrowserHandle);
        public void GoBack(HHTMLBrowser unBrowserHandle);
        public void GoForward(HHTMLBrowser unBrowserHandle);
        public void AddHeader(HHTMLBrowser unBrowserHandle, UTF8StringPtr pchKey, UTF8StringPtr pchValue);
        public void ExecuteJavascript(HHTMLBrowser unBrowserHandle, UTF8StringPtr pchScript);
        public void MouseUp(HHTMLBrowser unBrowserHandle, ISteamHTMLSurface.HTMLMouseButton eMouseButton);
        public void MouseDown(HHTMLBrowser unBrowserHandle, ISteamHTMLSurface.HTMLMouseButton eMouseButton);
        public void MouseDoubleClick(HHTMLBrowser unBrowserHandle, ISteamHTMLSurface.HTMLMouseButton eMouseButton);
        public void MouseMove(HHTMLBrowser unBrowserHandle, int x, int y);
        public void MouseWheel(HHTMLBrowser unBrowserHandle, int nDelta);
        public void KeyDown(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, ISteamHTMLSurface.HTMLKeyModifiers eHTMLKeyModifiers, bool bIsSystemKey);
        public void KeyUp(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, ISteamHTMLSurface.HTMLKeyModifiers eHTMLKeyModifiers);
        public void KeyChar(HHTMLBrowser unBrowserHandle, uint cUnicodeChar, ISteamHTMLSurface.HTMLKeyModifiers eHTMLKeyModifiers);
        public void SetHorizontalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll);
        public void SetVerticalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll);
        public void SetKeyFocus(HHTMLBrowser unBrowserHandle, bool bHasKeyFocus);
        public void ViewSource(HHTMLBrowser unBrowserHandle);
        public void CopyToClipboard(HHTMLBrowser unBrowserHandle);
        public void PasteFromClipboard(HHTMLBrowser unBrowserHandle);
        public void Find(HHTMLBrowser unBrowserHandle, UTF8StringPtr pchSearchStr, bool bCurrentlyInFind, bool bReverse);
        public void StopFind(HHTMLBrowser unBrowserHandle);
        public void GetLinkAtPosition(HHTMLBrowser unBrowserHandle, int x, int y);
        public void SetCookie(UTF8StringPtr pchHostname, UTF8StringPtr pchKey, UTF8StringPtr pchValue, UTF8StringPtr pchPath, RTime32 nExpires, bool bSecure, bool bHTTPOnly);
        public void SetPageScaleFactor(HHTMLBrowser unBrowserHandle, float flZoom, int nPointX, int nPointY);
        public void SetBackgroundMode(HHTMLBrowser unBrowserHandle, bool bBackgroundMode);
        public void SetDPIScalingFactor(HHTMLBrowser unBrowserHandle, float flDPIScaling);
        public void OpenDeveloperTools(HHTMLBrowser unBrowserHandle);
        public void AllowStartRequest(HHTMLBrowser unBrowserHandle, bool bAllowed);
        public void JSDialogResponse(HHTMLBrowser unBrowserHandle, bool bResult);
        public void FileLoadDialogResponse(HHTMLBrowser unBrowserHandle, UTF8StringPtr* pchSelectedFiles);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamHTMLSurface_Init", CallingConvention = Platform.CC)]
        internal static extern bool Init(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamHTMLSurface_Shutdown", CallingConvention = Platform.CC)]
        internal static extern bool Shutdown(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamHTMLSurface_CreateBrowser", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall CreateBrowser(void* self, UTF8StringPtr pchUserAgent, UTF8StringPtr pchUserCSS);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamHTMLSurface_RemoveBrowser", CallingConvention = Platform.CC)]
        internal static extern void RemoveBrowser(void* self, HHTMLBrowser unBrowserHandle);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamHTMLSurface_LoadURL", CallingConvention = Platform.CC)]
        internal static extern void LoadURL(void* self, HHTMLBrowser unBrowserHandle, UTF8StringPtr pchURL, UTF8StringPtr pchPostData);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamHTMLSurface_SetSize", CallingConvention = Platform.CC)]
        internal static extern void SetSize(void* self, HHTMLBrowser unBrowserHandle, uint unWidth, uint unHeight);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamHTMLSurface_StopLoad", CallingConvention = Platform.CC)]
        internal static extern void StopLoad(void* self, HHTMLBrowser unBrowserHandle);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamHTMLSurface_Reload", CallingConvention = Platform.CC)]
        internal static extern void Reload(void* self, HHTMLBrowser unBrowserHandle);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamHTMLSurface_GoBack", CallingConvention = Platform.CC)]
        internal static extern void GoBack(void* self, HHTMLBrowser unBrowserHandle);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamHTMLSurface_GoForward", CallingConvention = Platform.CC)]
        internal static extern void GoForward(void* self, HHTMLBrowser unBrowserHandle);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamHTMLSurface_AddHeader", CallingConvention = Platform.CC)]
        internal static extern void AddHeader(void* self, HHTMLBrowser unBrowserHandle, UTF8StringPtr pchKey, UTF8StringPtr pchValue);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamHTMLSurface_ExecuteJavascript", CallingConvention = Platform.CC)]
        internal static extern void ExecuteJavascript(void* self, HHTMLBrowser unBrowserHandle, UTF8StringPtr pchScript);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamHTMLSurface_MouseUp", CallingConvention = Platform.CC)]
        internal static extern void MouseUp(void* self, HHTMLBrowser unBrowserHandle, ISteamHTMLSurface.HTMLMouseButton eMouseButton);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamHTMLSurface_MouseDown", CallingConvention = Platform.CC)]
        internal static extern void MouseDown(void* self, HHTMLBrowser unBrowserHandle, ISteamHTMLSurface.HTMLMouseButton eMouseButton);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamHTMLSurface_MouseDoubleClick", CallingConvention = Platform.CC)]
        internal static extern void MouseDoubleClick(void* self, HHTMLBrowser unBrowserHandle, ISteamHTMLSurface.HTMLMouseButton eMouseButton);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamHTMLSurface_MouseMove", CallingConvention = Platform.CC)]
        internal static extern void MouseMove(void* self, HHTMLBrowser unBrowserHandle, int x, int y);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamHTMLSurface_MouseWheel", CallingConvention = Platform.CC)]
        internal static extern void MouseWheel(void* self, HHTMLBrowser unBrowserHandle, int nDelta);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamHTMLSurface_KeyDown", CallingConvention = Platform.CC)]
        internal static extern void KeyDown(void* self, HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, ISteamHTMLSurface.HTMLKeyModifiers eHTMLKeyModifiers, bool bIsSystemKey);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamHTMLSurface_KeyUp", CallingConvention = Platform.CC)]
        internal static extern void KeyUp(void* self, HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, ISteamHTMLSurface.HTMLKeyModifiers eHTMLKeyModifiers);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamHTMLSurface_KeyChar", CallingConvention = Platform.CC)]
        internal static extern void KeyChar(void* self, HHTMLBrowser unBrowserHandle, uint cUnicodeChar, ISteamHTMLSurface.HTMLKeyModifiers eHTMLKeyModifiers);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamHTMLSurface_SetHorizontalScroll", CallingConvention = Platform.CC)]
        internal static extern void SetHorizontalScroll(void* self, HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamHTMLSurface_SetVerticalScroll", CallingConvention = Platform.CC)]
        internal static extern void SetVerticalScroll(void* self, HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamHTMLSurface_SetKeyFocus", CallingConvention = Platform.CC)]
        internal static extern void SetKeyFocus(void* self, HHTMLBrowser unBrowserHandle, bool bHasKeyFocus);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamHTMLSurface_ViewSource", CallingConvention = Platform.CC)]
        internal static extern void ViewSource(void* self, HHTMLBrowser unBrowserHandle);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamHTMLSurface_CopyToClipboard", CallingConvention = Platform.CC)]
        internal static extern void CopyToClipboard(void* self, HHTMLBrowser unBrowserHandle);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamHTMLSurface_PasteFromClipboard", CallingConvention = Platform.CC)]
        internal static extern void PasteFromClipboard(void* self, HHTMLBrowser unBrowserHandle);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamHTMLSurface_Find", CallingConvention = Platform.CC)]
        internal static extern void Find(void* self, HHTMLBrowser unBrowserHandle, UTF8StringPtr pchSearchStr, bool bCurrentlyInFind, bool bReverse);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamHTMLSurface_StopFind", CallingConvention = Platform.CC)]
        internal static extern void StopFind(void* self, HHTMLBrowser unBrowserHandle);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamHTMLSurface_GetLinkAtPosition", CallingConvention = Platform.CC)]
        internal static extern void GetLinkAtPosition(void* self, HHTMLBrowser unBrowserHandle, int x, int y);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamHTMLSurface_SetCookie", CallingConvention = Platform.CC)]
        internal static extern void SetCookie(void* self, UTF8StringPtr pchHostname, UTF8StringPtr pchKey, UTF8StringPtr pchValue, UTF8StringPtr pchPath, RTime32 nExpires, bool bSecure, bool bHTTPOnly);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamHTMLSurface_SetPageScaleFactor", CallingConvention = Platform.CC)]
        internal static extern void SetPageScaleFactor(void* self, HHTMLBrowser unBrowserHandle, float flZoom, int nPointX, int nPointY);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamHTMLSurface_SetBackgroundMode", CallingConvention = Platform.CC)]
        internal static extern void SetBackgroundMode(void* self, HHTMLBrowser unBrowserHandle, bool bBackgroundMode);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamHTMLSurface_SetDPIScalingFactor", CallingConvention = Platform.CC)]
        internal static extern void SetDPIScalingFactor(void* self, HHTMLBrowser unBrowserHandle, float flDPIScaling);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamHTMLSurface_OpenDeveloperTools", CallingConvention = Platform.CC)]
        internal static extern void OpenDeveloperTools(void* self, HHTMLBrowser unBrowserHandle);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamHTMLSurface_AllowStartRequest", CallingConvention = Platform.CC)]
        internal static extern void AllowStartRequest(void* self, HHTMLBrowser unBrowserHandle, bool bAllowed);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamHTMLSurface_JSDialogResponse", CallingConvention = Platform.CC)]
        internal static extern void JSDialogResponse(void* self, HHTMLBrowser unBrowserHandle, bool bResult);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamHTMLSurface_FileLoadDialogResponse", CallingConvention = Platform.CC)]
        internal static extern void FileLoadDialogResponse(void* self, HHTMLBrowser unBrowserHandle, UTF8StringPtr* pchSelectedFiles);
        public struct Instance : ISteamHTMLSurface
        {
            public void* self;
            public bool Init() => ISteamHTMLSurface.Init(self);
            public bool Shutdown() => ISteamHTMLSurface.Shutdown(self);
            public SteamAPICall CreateBrowser(UTF8StringPtr pchUserAgent, UTF8StringPtr pchUserCSS) => ISteamHTMLSurface.CreateBrowser(self, pchUserAgent, pchUserCSS);
            public void RemoveBrowser(HHTMLBrowser unBrowserHandle) => ISteamHTMLSurface.RemoveBrowser(self, unBrowserHandle);
            public void LoadURL(HHTMLBrowser unBrowserHandle, UTF8StringPtr pchURL, UTF8StringPtr pchPostData) => ISteamHTMLSurface.LoadURL(self, unBrowserHandle, pchURL, pchPostData);
            public void SetSize(HHTMLBrowser unBrowserHandle, uint unWidth, uint unHeight) => ISteamHTMLSurface.SetSize(self, unBrowserHandle, unWidth, unHeight);
            public void StopLoad(HHTMLBrowser unBrowserHandle) => ISteamHTMLSurface.StopLoad(self, unBrowserHandle);
            public void Reload(HHTMLBrowser unBrowserHandle) => ISteamHTMLSurface.Reload(self, unBrowserHandle);
            public void GoBack(HHTMLBrowser unBrowserHandle) => ISteamHTMLSurface.GoBack(self, unBrowserHandle);
            public void GoForward(HHTMLBrowser unBrowserHandle) => ISteamHTMLSurface.GoForward(self, unBrowserHandle);
            public void AddHeader(HHTMLBrowser unBrowserHandle, UTF8StringPtr pchKey, UTF8StringPtr pchValue) => ISteamHTMLSurface.AddHeader(self, unBrowserHandle, pchKey, pchValue);
            public void ExecuteJavascript(HHTMLBrowser unBrowserHandle, UTF8StringPtr pchScript) => ISteamHTMLSurface.ExecuteJavascript(self, unBrowserHandle, pchScript);
            public void MouseUp(HHTMLBrowser unBrowserHandle, ISteamHTMLSurface.HTMLMouseButton eMouseButton) => ISteamHTMLSurface.MouseUp(self, unBrowserHandle, eMouseButton);
            public void MouseDown(HHTMLBrowser unBrowserHandle, ISteamHTMLSurface.HTMLMouseButton eMouseButton) => ISteamHTMLSurface.MouseDown(self, unBrowserHandle, eMouseButton);
            public void MouseDoubleClick(HHTMLBrowser unBrowserHandle, ISteamHTMLSurface.HTMLMouseButton eMouseButton) => ISteamHTMLSurface.MouseDoubleClick(self, unBrowserHandle, eMouseButton);
            public void MouseMove(HHTMLBrowser unBrowserHandle, int x, int y) => ISteamHTMLSurface.MouseMove(self, unBrowserHandle, x, y);
            public void MouseWheel(HHTMLBrowser unBrowserHandle, int nDelta) => ISteamHTMLSurface.MouseWheel(self, unBrowserHandle, nDelta);
            public void KeyDown(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, ISteamHTMLSurface.HTMLKeyModifiers eHTMLKeyModifiers, bool bIsSystemKey) => ISteamHTMLSurface.KeyDown(self, unBrowserHandle, nNativeKeyCode, eHTMLKeyModifiers, bIsSystemKey);
            public void KeyUp(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, ISteamHTMLSurface.HTMLKeyModifiers eHTMLKeyModifiers) => ISteamHTMLSurface.KeyUp(self, unBrowserHandle, nNativeKeyCode, eHTMLKeyModifiers);
            public void KeyChar(HHTMLBrowser unBrowserHandle, uint cUnicodeChar, ISteamHTMLSurface.HTMLKeyModifiers eHTMLKeyModifiers) => ISteamHTMLSurface.KeyChar(self, unBrowserHandle, cUnicodeChar, eHTMLKeyModifiers);
            public void SetHorizontalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll) => ISteamHTMLSurface.SetHorizontalScroll(self, unBrowserHandle, nAbsolutePixelScroll);
            public void SetVerticalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll) => ISteamHTMLSurface.SetVerticalScroll(self, unBrowserHandle, nAbsolutePixelScroll);
            public void SetKeyFocus(HHTMLBrowser unBrowserHandle, bool bHasKeyFocus) => ISteamHTMLSurface.SetKeyFocus(self, unBrowserHandle, bHasKeyFocus);
            public void ViewSource(HHTMLBrowser unBrowserHandle) => ISteamHTMLSurface.ViewSource(self, unBrowserHandle);
            public void CopyToClipboard(HHTMLBrowser unBrowserHandle) => ISteamHTMLSurface.CopyToClipboard(self, unBrowserHandle);
            public void PasteFromClipboard(HHTMLBrowser unBrowserHandle) => ISteamHTMLSurface.PasteFromClipboard(self, unBrowserHandle);
            public void Find(HHTMLBrowser unBrowserHandle, UTF8StringPtr pchSearchStr, bool bCurrentlyInFind, bool bReverse) => ISteamHTMLSurface.Find(self, unBrowserHandle, pchSearchStr, bCurrentlyInFind, bReverse);
            public void StopFind(HHTMLBrowser unBrowserHandle) => ISteamHTMLSurface.StopFind(self, unBrowserHandle);
            public void GetLinkAtPosition(HHTMLBrowser unBrowserHandle, int x, int y) => ISteamHTMLSurface.GetLinkAtPosition(self, unBrowserHandle, x, y);
            public void SetCookie(UTF8StringPtr pchHostname, UTF8StringPtr pchKey, UTF8StringPtr pchValue, UTF8StringPtr pchPath, RTime32 nExpires, bool bSecure, bool bHTTPOnly) => ISteamHTMLSurface.SetCookie(self, pchHostname, pchKey, pchValue, pchPath, nExpires, bSecure, bHTTPOnly);
            public void SetPageScaleFactor(HHTMLBrowser unBrowserHandle, float flZoom, int nPointX, int nPointY) => ISteamHTMLSurface.SetPageScaleFactor(self, unBrowserHandle, flZoom, nPointX, nPointY);
            public void SetBackgroundMode(HHTMLBrowser unBrowserHandle, bool bBackgroundMode) => ISteamHTMLSurface.SetBackgroundMode(self, unBrowserHandle, bBackgroundMode);
            public void SetDPIScalingFactor(HHTMLBrowser unBrowserHandle, float flDPIScaling) => ISteamHTMLSurface.SetDPIScalingFactor(self, unBrowserHandle, flDPIScaling);
            public void OpenDeveloperTools(HHTMLBrowser unBrowserHandle) => ISteamHTMLSurface.OpenDeveloperTools(self, unBrowserHandle);
            public void AllowStartRequest(HHTMLBrowser unBrowserHandle, bool bAllowed) => ISteamHTMLSurface.AllowStartRequest(self, unBrowserHandle, bAllowed);
            public void JSDialogResponse(HHTMLBrowser unBrowserHandle, bool bResult) => ISteamHTMLSurface.JSDialogResponse(self, unBrowserHandle, bResult);
            public void FileLoadDialogResponse(HHTMLBrowser unBrowserHandle, UTF8StringPtr* pchSelectedFiles) => ISteamHTMLSurface.FileLoadDialogResponse(self, unBrowserHandle, pchSelectedFiles);
        }

        /// <summary>EHTMLMouseButton</summary>
        public enum HTMLMouseButton : int
        {
            /// <summary>eHTMLMouseButton_Left</summary>
            eHTMLMouseButton_Left = 0,
            /// <summary>eHTMLMouseButton_Right</summary>
            eHTMLMouseButton_Right = 1,
            /// <summary>eHTMLMouseButton_Middle</summary>
            eHTMLMouseButton_Middle = 2
        }

        /// <summary>EMouseCursor</summary>
        public enum MouseCursor : int
        {
            /// <summary>dc_user</summary>
            dc_user = 0,
            /// <summary>dc_none</summary>
            dc_none = 1,
            /// <summary>dc_arrow</summary>
            dc_arrow = 2,
            /// <summary>dc_ibeam</summary>
            dc_ibeam = 3,
            /// <summary>dc_hourglass</summary>
            dc_hourglass = 4,
            /// <summary>dc_waitarrow</summary>
            dc_waitarrow = 5,
            /// <summary>dc_crosshair</summary>
            dc_crosshair = 6,
            /// <summary>dc_up</summary>
            dc_up = 7,
            /// <summary>dc_sizenw</summary>
            dc_sizenw = 8,
            /// <summary>dc_sizese</summary>
            dc_sizese = 9,
            /// <summary>dc_sizene</summary>
            dc_sizene = 10,
            /// <summary>dc_sizesw</summary>
            dc_sizesw = 11,
            /// <summary>dc_sizew</summary>
            dc_sizew = 12,
            /// <summary>dc_sizee</summary>
            dc_sizee = 13,
            /// <summary>dc_sizen</summary>
            dc_sizen = 14,
            /// <summary>dc_sizes</summary>
            dc_sizes = 15,
            /// <summary>dc_sizewe</summary>
            dc_sizewe = 16,
            /// <summary>dc_sizens</summary>
            dc_sizens = 17,
            /// <summary>dc_sizeall</summary>
            dc_sizeall = 18,
            /// <summary>dc_no</summary>
            dc_no = 19,
            /// <summary>dc_hand</summary>
            dc_hand = 20,
            /// <summary>dc_blank</summary>
            dc_blank = 21,
            /// <summary>dc_middle_pan</summary>
            dc_middle_pan = 22,
            /// <summary>dc_north_pan</summary>
            dc_north_pan = 23,
            /// <summary>dc_north_east_pan</summary>
            dc_north_east_pan = 24,
            /// <summary>dc_east_pan</summary>
            dc_east_pan = 25,
            /// <summary>dc_south_east_pan</summary>
            dc_south_east_pan = 26,
            /// <summary>dc_south_pan</summary>
            dc_south_pan = 27,
            /// <summary>dc_south_west_pan</summary>
            dc_south_west_pan = 28,
            /// <summary>dc_west_pan</summary>
            dc_west_pan = 29,
            /// <summary>dc_north_west_pan</summary>
            dc_north_west_pan = 30,
            /// <summary>dc_alias</summary>
            dc_alias = 31,
            /// <summary>dc_cell</summary>
            dc_cell = 32,
            /// <summary>dc_colresize</summary>
            dc_colresize = 33,
            /// <summary>dc_copycur</summary>
            dc_copycur = 34,
            /// <summary>dc_verticaltext</summary>
            dc_verticaltext = 35,
            /// <summary>dc_rowresize</summary>
            dc_rowresize = 36,
            /// <summary>dc_zoomin</summary>
            dc_zoomin = 37,
            /// <summary>dc_zoomout</summary>
            dc_zoomout = 38,
            /// <summary>dc_help</summary>
            dc_help = 39,
            /// <summary>dc_custom</summary>
            dc_custom = 40,
            /// <summary>dc_last</summary>
            dc_last = 41
        }

        /// <summary>EHTMLKeyModifiers</summary>
        public enum HTMLKeyModifiers : int
        {
            /// <summary>k_eHTMLKeyModifier_None</summary>
            k_eHTMLKeyModifier_None = 0,
            /// <summary>k_eHTMLKeyModifier_AltDown</summary>
            k_eHTMLKeyModifier_AltDown = 1,
            /// <summary>k_eHTMLKeyModifier_CtrlDown</summary>
            k_eHTMLKeyModifier_CtrlDown = 2,
            /// <summary>k_eHTMLKeyModifier_ShiftDown</summary>
            k_eHTMLKeyModifier_ShiftDown = 4
        }
    }
}