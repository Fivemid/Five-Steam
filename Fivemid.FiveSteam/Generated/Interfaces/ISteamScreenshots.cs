using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Functions for adding screenshots to the user's screenshot library.<br />
    /// <br />
    /// See <a href="https://partner.steamgames.com/doc/features/screenshots" class="bb_doclink">Steam Screenshots</a> for more information.</summary>
    public unsafe interface ISteamScreenshots
    {
        public ScreenshotHandle WriteScreenshot(void* pubRGB, uint cubRGB, int nWidth, int nHeight);
        public ScreenshotHandle AddScreenshotToLibrary(UTF8StringPtr pchFilename, UTF8StringPtr pchThumbnailFilename, int nWidth, int nHeight);
        public void TriggerScreenshot();
        public void HookScreenshots(bool bHook);
        public bool SetLocation(ScreenshotHandle hScreenshot, UTF8StringPtr pchLocation);
        public bool TagUser(ScreenshotHandle hScreenshot, SteamId steamID);
        public bool TagPublishedFile(ScreenshotHandle hScreenshot, PublishedFileId unPublishedFileID);
        public bool IsScreenshotsHooked();
        public ScreenshotHandle AddVRScreenshotToLibrary(VRScreenshotType eType, UTF8StringPtr pchFilename, UTF8StringPtr pchVRFilename);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamScreenshots_WriteScreenshot", CallingConvention = Platform.CC)]
        internal static extern ScreenshotHandle WriteScreenshot(void* self, void* pubRGB, uint cubRGB, int nWidth, int nHeight);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamScreenshots_AddScreenshotToLibrary", CallingConvention = Platform.CC)]
        internal static extern ScreenshotHandle AddScreenshotToLibrary(void* self, UTF8StringPtr pchFilename, UTF8StringPtr pchThumbnailFilename, int nWidth, int nHeight);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamScreenshots_TriggerScreenshot", CallingConvention = Platform.CC)]
        internal static extern void TriggerScreenshot(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamScreenshots_HookScreenshots", CallingConvention = Platform.CC)]
        internal static extern void HookScreenshots(void* self, bool bHook);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamScreenshots_SetLocation", CallingConvention = Platform.CC)]
        internal static extern bool SetLocation(void* self, ScreenshotHandle hScreenshot, UTF8StringPtr pchLocation);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamScreenshots_TagUser", CallingConvention = Platform.CC)]
        internal static extern bool TagUser(void* self, ScreenshotHandle hScreenshot, SteamId steamID);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamScreenshots_TagPublishedFile", CallingConvention = Platform.CC)]
        internal static extern bool TagPublishedFile(void* self, ScreenshotHandle hScreenshot, PublishedFileId unPublishedFileID);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamScreenshots_IsScreenshotsHooked", CallingConvention = Platform.CC)]
        internal static extern bool IsScreenshotsHooked(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamScreenshots_AddVRScreenshotToLibrary", CallingConvention = Platform.CC)]
        internal static extern ScreenshotHandle AddVRScreenshotToLibrary(void* self, VRScreenshotType eType, UTF8StringPtr pchFilename, UTF8StringPtr pchVRFilename);
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
        public struct Instance : ISteamScreenshots
        {
            public void* self;
            public ScreenshotHandle WriteScreenshot(void* pubRGB, uint cubRGB, int nWidth, int nHeight) => ISteamScreenshots.WriteScreenshot(self, pubRGB, cubRGB, nWidth, nHeight);
            public ScreenshotHandle AddScreenshotToLibrary(UTF8StringPtr pchFilename, UTF8StringPtr pchThumbnailFilename, int nWidth, int nHeight) => ISteamScreenshots.AddScreenshotToLibrary(self, pchFilename, pchThumbnailFilename, nWidth, nHeight);
            public void TriggerScreenshot() => ISteamScreenshots.TriggerScreenshot(self);
            public void HookScreenshots(bool bHook) => ISteamScreenshots.HookScreenshots(self, bHook);
            public bool SetLocation(ScreenshotHandle hScreenshot, UTF8StringPtr pchLocation) => ISteamScreenshots.SetLocation(self, hScreenshot, pchLocation);
            public bool TagUser(ScreenshotHandle hScreenshot, SteamId steamID) => ISteamScreenshots.TagUser(self, hScreenshot, steamID);
            public bool TagPublishedFile(ScreenshotHandle hScreenshot, PublishedFileId unPublishedFileID) => ISteamScreenshots.TagPublishedFile(self, hScreenshot, unPublishedFileID);
            public bool IsScreenshotsHooked() => ISteamScreenshots.IsScreenshotsHooked(self);
            public ScreenshotHandle AddVRScreenshotToLibrary(VRScreenshotType eType, UTF8StringPtr pchFilename, UTF8StringPtr pchVRFilename) => ISteamScreenshots.AddVRScreenshotToLibrary(self, eType, pchFilename, pchVRFilename);
        }
    }
}