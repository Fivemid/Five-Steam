using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamScreenshots
    {
        public static ISteamScreenshots.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamScreenshots_v003", CallingConvention = Platform.CC)]
        private static extern ISteamScreenshots.Instance Accessor();
        /// <summary></summary>
        public static ScreenshotHandle WriteScreenshot(void* pubRGB, uint cubRGB, int nWidth, int nHeight) => Instance.WriteScreenshot(pubRGB, cubRGB, nWidth, nHeight);
        /// <summary></summary>
        public static ScreenshotHandle AddScreenshotToLibrary(UTF8StringPtr pchFilename, UTF8StringPtr pchThumbnailFilename, int nWidth, int nHeight) => Instance.AddScreenshotToLibrary(pchFilename, pchThumbnailFilename, nWidth, nHeight);
        /// <summary></summary>
        public static void TriggerScreenshot() => Instance.TriggerScreenshot();
        /// <summary></summary>
        public static void HookScreenshots(bool bHook) => Instance.HookScreenshots(bHook);
        /// <summary></summary>
        public static bool SetLocation(ScreenshotHandle hScreenshot, UTF8StringPtr pchLocation) => Instance.SetLocation(hScreenshot, pchLocation);
        /// <summary></summary>
        public static bool TagUser(ScreenshotHandle hScreenshot, SteamId steamID) => Instance.TagUser(hScreenshot, steamID);
        /// <summary></summary>
        public static bool TagPublishedFile(ScreenshotHandle hScreenshot, PublishedFileId unPublishedFileID) => Instance.TagPublishedFile(hScreenshot, unPublishedFileID);
        /// <summary></summary>
        public static bool IsScreenshotsHooked() => Instance.IsScreenshotsHooked();
        /// <summary></summary>
        public static ScreenshotHandle AddVRScreenshotToLibrary(VRScreenshotType eType, UTF8StringPtr pchFilename, UTF8StringPtr pchVRFilename) => Instance.AddVRScreenshotToLibrary(eType, pchFilename, pchVRFilename);
    }
}