using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamScreenshots
    {
        public static ISteamScreenshots.Instance Instance => Accessor();

        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_SteamScreenshots_v003", CallingConvention = Platform.CC)]
        private static extern ISteamScreenshots.Instance Accessor();
        /// <summary><code>ScreenshotHandle WriteScreenshot( void *pubRGB, uint32 cubRGB, int nWidth, int nHeight );</code><br />
        /// Writes a screenshot to the user's Steam screenshot library given the raw image data, which must be in RGB format.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#ScreenshotHandle" class="bb_apilink">ScreenshotHandle</a><br />
        /// Triggers a <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#ScreenshotReady_t" class="bb_apilink">ScreenshotReady_t</a> callback.<br />
        /// The handle to this screenshot that is valid for the duration of the game process and can be used to apply tags.<br />
        /// Returns <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#INVALID_SCREENSHOT_HANDLE" class="bb_apilink">INVALID_SCREENSHOT_HANDLE</a> if the file could not be saved.<br />
        /// <br />
        /// This call is asynchronous, the <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#ScreenshotReady_t" class="bb_apilink">ScreenshotReady_t</a> callback will be sent when the screenshot has finished writing to disk.</summary>
        /// <param name="pubRGB">void *: The buffer containing the raw RGB data from the screenshot.</param>
        /// <param name="cubRGB"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The size of <code class="bb_code bb_code_inline nohighlight">pubRGB</code> in bytes.</param>
        /// <param name="nWidth">int: The width of the screenshot in pixels.</param>
        /// <param name="nHeight">int: The height of the screenshot in pixels.</param>
        public static ScreenshotHandle WriteScreenshot(void* pubRGB, uint cubRGB, int nWidth, int nHeight) => Instance.WriteScreenshot(pubRGB, cubRGB, nWidth, nHeight);
        /// <summary><code>ScreenshotHandle AddScreenshotToLibrary( const char *pchFilename, const char *pchThumbnailFilename, int nWidth, int nHeight );</code><br />
        /// Adds a screenshot to the user's Steam screenshot library from disk.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#ScreenshotHandle" class="bb_apilink">ScreenshotHandle</a><br />
        /// Triggers a <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#ScreenshotReady_t" class="bb_apilink">ScreenshotReady_t</a> callback.<br />
        /// The handle to this screenshot that is valid for the duration of the game process and can be used to apply tags.<br />
        /// Returns <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#INVALID_SCREENSHOT_HANDLE" class="bb_apilink">INVALID_SCREENSHOT_HANDLE</a> if the file could not be saved.<br />
        /// <br />
        /// This call is asynchronous, a <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#ScreenshotReady_t" class="bb_apilink">ScreenshotReady_t</a> callback will be sent when the screenshot has finished writing to disk.</summary>
        /// <param name="pchFilename">const char *: The absolute file path to the JPG, PNG, or TGA screenshot.</param>
        /// <param name="pchThumbnailFilename">const char *: The absolute file path to an optional thumbnail image. This must be 200px wide, as described by <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#k_ScreenshotThumbWidth" class="bb_apilink">k_ScreenshotThumbWidth</a> and the same aspect ratio. Pass <b>NULL</b> if there is no thumbnail, one will be created automatically.</param>
        /// <param name="nWidth">int: The width of the screenshot.</param>
        /// <param name="nHeight">int: The height of the screenshot.</param>
        public static ScreenshotHandle AddScreenshotToLibrary(UTF8StringPtr pchFilename, UTF8StringPtr pchThumbnailFilename, int nWidth, int nHeight) => Instance.AddScreenshotToLibrary(pchFilename, pchThumbnailFilename, nWidth, nHeight);
        /// <summary><code>void TriggerScreenshot();</code>Either causes the Steam Overlay to take a screenshot, or tells your screenshot manager that a screenshot needs to be taken. Depending on the value of <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#IsScreenshotsHooked" class="bb_apilink">ISteamScreenshots::IsScreenshotsHooked</a>.<br />
        /// <br />
        /// <b>Returns:</b> void<br />
        /// Triggers a <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#ScreenshotRequested_t" class="bb_apilink">ScreenshotRequested_t</a> callback.<br />
        /// Triggers a <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#ScreenshotReady_t" class="bb_apilink">ScreenshotReady_t</a> callback.<br />
        /// Only causes <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#ScreenshotRequested_t" class="bb_apilink">ScreenshotRequested_t</a> if hooking has been enabled with <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#HookScreenshots" class="bb_apilink">ISteamScreenshots::HookScreenshots</a>. Otherwise <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#ScreenshotReady_t" class="bb_apilink">ScreenshotReady_t</a> will be called when the screenshot has been saved and added to the library.</summary>
        /// 
        public static void TriggerScreenshot() => Instance.TriggerScreenshot();
        /// <summary><code>void HookScreenshots( bool bHook );</code><br />
        /// Toggles whether the overlay handles screenshots when the user presses the screenshot hotkey, or if the game handles them.<br />
        /// <br />
        /// Hooking is disabled by default, and only ever enabled if you do so with this function.<br />
        /// <br />
        /// If the hooking is enabled, then the <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#ScreenshotRequested_t" class="bb_apilink">ScreenshotRequested_t</a> callback will be sent if the user presses the hotkey or when <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#TriggerScreenshot" class="bb_apilink">ISteamScreenshots::TriggerScreenshot</a> is called, and then the game is expected to call <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#WriteScreenshot" class="bb_apilink">ISteamScreenshots::WriteScreenshot</a> or <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#AddScreenshotToLibrary" class="bb_apilink">ISteamScreenshots::AddScreenshotToLibrary</a> in response.<br />
        /// <br />
        /// You can check if hooking is enabled with <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#IsScreenshotsHooked" class="bb_apilink">ISteamScreenshots::IsScreenshotsHooked</a>.</summary>
        /// <param name="bHook">bool: Enable (<b>true</b>) or disable (<b>false</b>) hooking?</param>
        public static void HookScreenshots(bool bHook) => Instance.HookScreenshots(bHook);
        /// <summary><code>bool SetLocation( ScreenshotHandle hScreenshot, const char *pchLocation );</code><br />
        /// Sets optional metadata about a screenshot's location. For example, the name of the map it was taken on.<br />
        /// <br />
        /// You can get the handle to tag the screenshot once it has been successfully saved from the <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#ScreenshotReady_t" class="bb_apilink">ScreenshotReady_t</a> callback or via the <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#WriteScreenshot" class="bb_apilink">ISteamScreenshots::WriteScreenshot</a>, <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#AddScreenshotToLibrary" class="bb_apilink">ISteamScreenshots::AddScreenshotToLibrary</a>, <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#AddVRScreenshotToLibrary" class="bb_apilink">ISteamScreenshots::AddVRScreenshotToLibrary</a> calls.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the location was successfully added to the screenshot.<br />
        /// <b>false</b> if <code class="bb_code bb_code_inline nohighlight">hScreenshot</code> was invalid, or <code class="bb_code bb_code_inline nohighlight">pchLocation</code> is invalid or too long.</summary>
        /// <param name="hScreenshot"><a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#ScreenshotHandle" class="bb_apilink">ScreenshotHandle</a>: The handle to the screenshot to tag.</param>
        /// <param name="pchLocation">const char *: The location in the game where this screenshot was taken. This can not be longer than <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#k_cubUFSTagValueMax" class="bb_apilink">k_cubUFSTagValueMax</a>.</param>
        public static bool SetLocation(ScreenshotHandle hScreenshot, UTF8StringPtr pchLocation) => Instance.SetLocation(hScreenshot, pchLocation);
        /// <summary><code>bool TagUser( ScreenshotHandle hScreenshot, CSteamID steamID );</code><br />
        /// Tags a Steam user as being visible in the screenshot.<br />
        /// <br />
        /// You can tag up to the value declared by <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#k_nScreenshotMaxTaggedUsers" class="bb_apilink">k_nScreenshotMaxTaggedUsers</a> in a single screenshot. Tagging more users than that will just be discarded.<br />
        /// <br />
        /// This function has a built in delay before saving the tag which allows you to call it repeatedly for each item.<br />
        /// <br />
        /// You can get the handle to tag the screenshot once it has been successfully saved from the <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#ScreenshotReady_t" class="bb_apilink">ScreenshotReady_t</a> callback or via the <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#WriteScreenshot" class="bb_apilink">ISteamScreenshots::WriteScreenshot</a>, <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#AddScreenshotToLibrary" class="bb_apilink">ISteamScreenshots::AddScreenshotToLibrary</a>, <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#AddVRScreenshotToLibrary" class="bb_apilink">ISteamScreenshots::AddVRScreenshotToLibrary</a> calls.<br />
        /// <br />
        /// <b>Returns:</b> bool</summary>
        /// <param name="hScreenshot"><a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#ScreenshotHandle" class="bb_apilink">ScreenshotHandle</a>: The handle to the screenshot to tag.</param>
        /// <param name="steamID"><a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a>: The Steam ID of a user that is in the screenshot.</param>
        public static bool TagUser(ScreenshotHandle hScreenshot, SteamId steamID) => Instance.TagUser(hScreenshot, steamID);
        /// <summary><code>bool TagPublishedFile( ScreenshotHandle hScreenshot, PublishedFileId_t unPublishedFileID );</code><br />
        /// Tags a published file as being visible in the screenshot.<br />
        /// <br />
        /// You can tag up to the value declared by <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#k_nScreenshotMaxTaggedPublishedFiles" class="bb_apilink">k_nScreenshotMaxTaggedPublishedFiles</a> in a single screenshot. Tagging more items than that will just be discarded.<br />
        /// <br />
        /// This function has a built in delay before saving the tag which allows you to call it repeatedly for each item.<br />
        /// <br />
        /// You can get the handle to tag the screenshot once it has been successfully saved from the <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#ScreenshotReady_t" class="bb_apilink">ScreenshotReady_t</a> callback or via the <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#WriteScreenshot" class="bb_apilink">ISteamScreenshots::WriteScreenshot</a>, <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#AddScreenshotToLibrary" class="bb_apilink">ISteamScreenshots::AddScreenshotToLibrary</a>, <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#AddVRScreenshotToLibrary" class="bb_apilink">ISteamScreenshots::AddVRScreenshotToLibrary</a> calls.<br />
        /// <br />
        /// <b>Returns:</b> bool</summary>
        /// <param name="hScreenshot"><a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#ScreenshotHandle" class="bb_apilink">ScreenshotHandle</a>: The handle to the screenshot to tag.</param>
        /// <param name="unPublishedFileID"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishedFileId_t" class="bb_apilink">PublishedFileId_t</a>: The workshop item ID that is in the screenshot.</param>
        public static bool TagPublishedFile(ScreenshotHandle hScreenshot, PublishedFileId unPublishedFileID) => Instance.TagPublishedFile(hScreenshot, unPublishedFileID);
        /// <summary><code>bool IsScreenshotsHooked();</code>Checks if the app is hooking screenshots, or if the Steam Overlay is handling them.<br />
        /// <br />
        /// This can be toggled with <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#HookScreenshots" class="bb_apilink">ISteamScreenshots::HookScreenshots</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the game is hooking screenshots and is expected to handle them; otherwise, <b>false</b>.</summary>
        /// 
        public static bool IsScreenshotsHooked() => Instance.IsScreenshotsHooked();
        /// <summary><code>ScreenshotHandle AddVRScreenshotToLibrary( EVRScreenshotType eType, const char *pchFilename, const char *pchVRFilename );</code><br />
        /// Adds a VR screenshot to the user's Steam screenshot library from disk in the supported type.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#ScreenshotHandle" class="bb_apilink">ScreenshotHandle</a><br />
        /// Triggers a <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#ScreenshotReady_t" class="bb_apilink">ScreenshotReady_t</a> callback.<br />
        /// The handle to this screenshot that is valid for the duration of the game process and can be used to apply tags.<br />
        /// Returns <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#INVALID_SCREENSHOT_HANDLE" class="bb_apilink">INVALID_SCREENSHOT_HANDLE</a> if the file could not be saved.<br />
        /// <br />
        /// This call is asynchronous, a <a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#ScreenshotReady_t" class="bb_apilink">ScreenshotReady_t</a> callback will be sent when the screenshot has finished writing to disk.</summary>
        /// <param name="eType"><a href="https://partner.steamgames.com/doc/api/ISteamScreenshots#EVRScreenshotType" class="bb_apilink">EVRScreenshotType</a>: The type of VR screenshot that this is.</param>
        /// <param name="pchFilename">const char *: The absolute file path to a 2D JPG, PNG, or TGA version of the screenshot for the library view.</param>
        /// <param name="pchVRFilename">const char *: The absolute file path to the VR screenshot, this should be the same type of screenshot specified in <code class="bb_code bb_code_inline nohighlight">eType</code>.</param>
        public static ScreenshotHandle AddVRScreenshotToLibrary(VRScreenshotType eType, UTF8StringPtr pchFilename, UTF8StringPtr pchVRFilename) => Instance.AddVRScreenshotToLibrary(eType, pchFilename, pchVRFilename);
    }
}