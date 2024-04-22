using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamApps
    {
        public static ISteamApps.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamApps_v008", CallingConvention = Platform.CC)]
        private static extern ISteamApps.Instance Accessor();
        /// <summary><code>bool BIsSubscribed();</code>Checks if the active user is subscribed to the current App ID.<br />
        /// <br />
        /// <b>NOTE:</b> This will always return <b>true</b> if you're using Steam DRM or calling <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPI_RestartAppIfNecessary" class="bb_apilink">SteamAPI_RestartAppIfNecessary</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the active user owns the current AppId, otherwise <b>false</b>.</summary>
        /// 
        public static bool BIsSubscribed() => Instance.BIsSubscribed();
        /// <summary><code>bool BIsLowViolence();</code>Checks if the license owned by the user provides low violence depots.<br />
        /// <br />
        /// Low violence depots are useful for copies sold in countries that have content restrictions.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the license owned by the user provides low violence depots; otherwise, <b>false</b>.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/store/application/depots#depot_mounting_rules" class="bb_doclink">Depot Mounting Rules</a></summary>
        /// 
        public static bool BIsLowViolence() => Instance.BIsLowViolence();
        /// <summary><code>bool BIsCybercafe();</code>Checks whether the current App ID is for Cyber Cafes.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the license if for cyber cafe's; otherwise, <b>false</b>.<br />
        /// Deprecated - No longer used.</summary>
        /// 
        public static bool BIsCybercafe() => Instance.BIsCybercafe();
        /// <summary><code>bool BIsVACBanned();</code>Checks if the user has a VAC ban on their account<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the user has a VAC ban on their account; otherwise, <b>false</b>.</summary>
        /// 
        public static bool BIsVACBanned() => Instance.BIsVACBanned();
        /// <summary><code>const char * GetCurrentGameLanguage();</code>Gets the current language that the user has set.<br />
        /// <br />
        /// This falls back to the Steam UI language if the user hasn't explicitly picked a language for the title.<br />
        /// <br />
        /// For the full list of languages see <a href="https://partner.steamgames.com/doc/store/localization/languages" class="bb_doclink">Supported Languages</a>.<br />
        /// <br />
        /// <b>Returns:</b> const char *<br />
        /// <br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamApps#GetAvailableGameLanguages" class="bb_apilink">ISteamApps::GetAvailableGameLanguages</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUtils#GetSteamUILanguage" class="bb_apilink">ISteamUtils::GetSteamUILanguage</a></summary>
        /// 
        public static UTF8StringPtr GetCurrentGameLanguage() => Instance.GetCurrentGameLanguage();
        /// <summary><code>const char * GetAvailableGameLanguages();</code>Gets a comma separated list of the languages the current app supports.<br />
        /// <br />
        /// For the full list of languages that may be returned see <a href="https://partner.steamgames.com/doc/store/localization" class="bb_doclink">Localization and Languages</a>.<br />
        /// <br />
        /// <b>Returns:</b> const char *<br />
        /// Returns a comma separated list of languages.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamApps#GetCurrentGameLanguage" class="bb_apilink">ISteamApps::GetCurrentGameLanguage</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUtils#GetSteamUILanguage" class="bb_apilink">ISteamUtils::GetSteamUILanguage</a></summary>
        /// 
        public static UTF8StringPtr GetAvailableGameLanguages() => Instance.GetAvailableGameLanguages();
        /// <summary><code>bool BIsSubscribedApp( AppId_t appID );</code><br />
        /// Checks if the active user is subscribed to a specified AppId.<br />
        /// <br />
        /// Only use this if you need to check ownership of another game related to yours, a demo for example.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the active user is subscribed to the specified App ID, otherwise <b>false</b>.</summary>
        /// <param name="appID"><a href="https://partner.steamgames.com/doc/api/steam_api#AppId_t" class="bb_apilink">AppId_t</a>: The App ID to check.</param>
        public static bool BIsSubscribedApp(AppId appID) => Instance.BIsSubscribedApp(appID);
        /// <summary><code>bool BIsDlcInstalled( AppId_t appID );</code><br />
        /// Checks if the user owns a specific DLC and if the DLC is installed<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the user owns the DLC and it's currently installed, otherwise <b>false</b>.<br />
        /// <br />
        /// <b>Note:</b> Should only be used for simple client side checks - not intended for granting in-game items.</summary>
        /// <param name="appID"><a href="https://partner.steamgames.com/doc/api/steam_api#AppId_t" class="bb_apilink">AppId_t</a>: The App ID of the DLC to check.</param>
        public static bool BIsDlcInstalled(AppId appID) => Instance.BIsDlcInstalled(appID);
        /// <summary><code>uint32 GetEarliestPurchaseUnixTime( AppId_t nAppID );</code><br />
        /// Gets the time of purchase of the specified app in Unix epoch format (time since Jan 1st, 1970).<br />
        /// <br />
        /// This is useful for rewarding users based on their initial purchase date.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a><br />
        /// The earliest purchase time in Unix epoch format (seconds since Jan 1st, 1970).</summary>
        /// <param name="nAppID"><a href="https://partner.steamgames.com/doc/api/steam_api#AppId_t" class="bb_apilink">AppId_t</a>: The App ID to get the purchase time for.</param>
        public static uint GetEarliestPurchaseUnixTime(AppId nAppID) => Instance.GetEarliestPurchaseUnixTime(nAppID);
        /// <summary><code>bool BIsSubscribedFromFreeWeekend();</code><br />
        /// Checks if the user is subscribed to the current appID  through a free weekend.<br />
        /// <br />
        /// Before using this please contact a Valve technical account manager via the <a href="http://steamcommunity.com/groups/steamworks/discussions" target="_blank" rel="noreferrer">Steamworks Discussion Board</a> to properly package and secure your free weekend.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the active user is subscribed to the current App Id via a free weekend otherwise <b>false</b> any other type of license.</summary>
        /// 
        public static bool BIsSubscribedFromFreeWeekend() => Instance.BIsSubscribedFromFreeWeekend();
        /// <summary><code>int GetDLCCount();</code>Gets the number of DLC pieces for the current app.<br />
        /// <br />
        /// This is typically used to loop through each piece of DLC and get the info about each one with <a href="https://partner.steamgames.com/doc/api/ISteamApps#BGetDLCDataByIndex" class="bb_apilink">ISteamApps::BGetDLCDataByIndex</a>.<br />
        /// <br />
        /// <b>Returns:</b> int<br />
        /// The number of DLC pieces for the current app. Note that this value may max out at 64, depending on how much unowned DLC the user has. If your app has a large number of DLC, you should set your own internal list of known DLC to check against.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>int32 DLCCount = SteamApps()-&gt;GetDLCCount();
        /// for ( int i = 0; i &lt; DLCCount; ++i ) {
        ///     AppId_t appId;
        ///     bool available;
        ///     char name[128];
        ///     bool success = SteamApps()-&gt;BGetDLCDataByIndex( i, &amp;appId, &amp;available, name, 128 );
        ///     if ( success ) {
        ///         // Do something with the DLC Data
        ///     }
        /// }</code></summary>
        /// 
        public static int GetDLCCount() => Instance.GetDLCCount();
        /// <summary><code>bool BGetDLCDataByIndex( int iDLC, AppId_t *pAppID, bool *pbAvailable, char *pchName, int cchNameBufferSize );</code><br />
        /// Returns metadata for a DLC by index.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the current App ID has DLC's associated with it and <code class="bb_code bb_code_inline nohighlight">iDLC</code> falls between the range of 0 to <a href="https://partner.steamgames.com/doc/api/ISteamApps#GetDLCCount" class="bb_apilink">ISteamApps::GetDLCCount</a>, otherwise <b>false</b>.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>int32 DLCCount = SteamApps()-&gt;GetDLCCount();
        /// for ( int i = 0; i &lt; DLCCount; ++i ) {
        ///     AppId_t appId;
        ///     bool available;
        ///     char name[128];
        ///     bool success = SteamApps()-&gt;BGetDLCDataByIndex( i, &amp;appId, &amp;available, name, 128 );
        ///     if ( success ) {
        ///         // Do something with the DLC Data
        ///     }
        /// }</code></summary>
        /// <param name="iDLC">int: Index of the DLC to get between 0 and <a href="https://partner.steamgames.com/doc/api/ISteamApps#GetDLCCount" class="bb_apilink">ISteamApps::GetDLCCount</a>.</param>
        /// <param name="pAppID"><a href="https://partner.steamgames.com/doc/api/steam_api#AppId_t" class="bb_apilink">AppId_t</a> *: Returns the App ID of the DLC.</param>
        /// <param name="pbAvailable">bool *: Returns whether the DLC is currently available on the Steam store. Will be false if the DLC does not have a visible store page</param>
        /// <param name="pchName">char *: Returns the name of the DLC by copying it into this buffer.</param>
        /// <param name="cchNameBufferSize">int: The length of the <code class="bb_code bb_code_inline nohighlight">pchName</code> buffer.</param>
        public static bool BGetDLCDataByIndex(int iDLC, AppId* pAppID, bool* pbAvailable, char* pchName, int cchNameBufferSize) => Instance.BGetDLCDataByIndex(iDLC, pAppID, pbAvailable, pchName, cchNameBufferSize);
        /// <summary><code>void InstallDLC( AppId_t nAppID );</code><br />
        /// Allows you to install an optional DLC.<br />
        /// <br />
        /// <b>Returns:</b> void<br />
        /// <br />
        /// Triggers a <a href="https://partner.steamgames.com/doc/api/ISteamApps#DlcInstalled_t" class="bb_apilink">DlcInstalled_t</a> callback.</summary>
        /// <param name="nAppID"><a href="https://partner.steamgames.com/doc/api/steam_api#AppId_t" class="bb_apilink">AppId_t</a>: The DLC you want to install.</param>
        public static void InstallDLC(AppId nAppID) => Instance.InstallDLC(nAppID);
        /// <summary><code>void UninstallDLC( AppId_t nAppID );</code><br />
        /// Allows you to uninstall an optional DLC.</summary>
        /// <param name="nAppID"><a href="https://partner.steamgames.com/doc/api/steam_api#AppId_t" class="bb_apilink">AppId_t</a>: The DLC you want to uninstall.</param>
        public static void UninstallDLC(AppId nAppID) => Instance.UninstallDLC(nAppID);
        /// <summary><code>void RequestAppProofOfPurchaseKey( AppId_t nAppID );</code><br />
        /// Deprecated.</summary>
        /// <param name="nAppID"><a href="https://partner.steamgames.com/doc/api/steam_api#AppId_t" class="bb_apilink">AppId_t</a>: </param>
        public static void RequestAppProofOfPurchaseKey(AppId nAppID) => Instance.RequestAppProofOfPurchaseKey(nAppID);
        /// <summary><code>bool GetCurrentBetaName( char *pchName, int cchNameBufferSize );</code><br />
        /// Checks if the user is running from a beta branch, and gets the name of the branch if they are.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the user is on a beta branch; otherwise, <b>false</b>.</summary>
        /// <param name="pchName">char *: The buffer where the beta name will be copied in to.</param>
        /// <param name="cchNameBufferSize">int: The total size of the pchName buffer.</param>
        public static bool GetCurrentBetaName(char* pchName, int cchNameBufferSize) => Instance.GetCurrentBetaName(pchName, cchNameBufferSize);
        /// <summary><code>bool MarkContentCorrupt( bool bMissingFilesOnly );</code><br />
        /// Allows you to force verify game content on next launch.<br />
        /// <br />
        /// If you detect the game is out-of-date (for example, by having the client detect a version mismatch with a server),<br />
        /// you can call use MarkContentCorrupt to force a verify, show a message to the user, and then quit.<br />
        /// <br />
        /// <b>Returns:</b> bool</summary>
        /// <param name="bMissingFilesOnly">bool: Only scan for missing files, don't verify the checksum of each file.</param>
        public static bool MarkContentCorrupt(bool bMissingFilesOnly) => Instance.MarkContentCorrupt(bMissingFilesOnly);
        /// <summary><code>uint32 GetInstalledDepots( AppId_t appID, DepotId_t *pvecDepots, uint32 cMaxDepots );</code><br />
        /// Gets a list of all installed depots for a given App ID in mount order.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a><br />
        /// The number of depots returned.</summary>
        /// <param name="appID"><a href="https://partner.steamgames.com/doc/api/steam_api#AppId_t" class="bb_apilink">AppId_t</a>: The App to list the depots for.</param>
        /// <param name="pvecDepots"><a href="https://partner.steamgames.com/doc/api/steam_api#DepotId_t" class="bb_apilink">DepotId_t</a> *: A preallocated array that will be filled with the list of depots.</param>
        /// <param name="cMaxDepots"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The maximum number of depots to obtain, typically the size of pvecDepots.</param>
        public static uint GetInstalledDepots(AppId appID, DepotId* pvecDepots, uint cMaxDepots) => Instance.GetInstalledDepots(appID, pvecDepots, cMaxDepots);
        /// <summary><code>uint32 GetAppInstallDir( AppId_t appID, char *pchFolder, uint32 cchFolderBufferSize );</code><br />
        /// Gets the install folder for a specific AppID.<br />
        /// <br />
        /// This works even if the application is not installed, based on where the game would be installed with the default Steam library location.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a><br />
        /// Returns the install directory path as a string into the buffer provided in pchFolder and returns the number of bytes that were copied into that buffer.</summary>
        /// <param name="appID"><a href="https://partner.steamgames.com/doc/api/steam_api#AppId_t" class="bb_apilink">AppId_t</a>: The App ID to get the install dir for.</param>
        /// <param name="pchFolder">char *: The string buffer that the folder path will be copied into.</param>
        /// <param name="cchFolderBufferSize"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The size in bytes of the <code class="bb_code bb_code_inline nohighlight">pchFolder</code> buffer.</param>
        public static uint GetAppInstallDir(AppId appID, char* pchFolder, uint cchFolderBufferSize) => Instance.GetAppInstallDir(appID, pchFolder, cchFolderBufferSize);
        /// <summary><code>bool BIsAppInstalled( AppId_t appID );</code><br />
        /// Checks if a specific app is installed.<br />
        /// <br />
        /// The app may not actually be owned by the current user, they may have it left over from a free weekend, etc.<br />
        /// <br />
        /// This only works for base applications, not <a href="https://partner.steamgames.com/doc/store/application/dlc" class="bb_doclink">Downloadable Content (DLC)</a>. Use <a href="https://partner.steamgames.com/doc/api/ISteamApps#BIsDlcInstalled" class="bb_apilink">ISteamApps::BIsDlcInstalled</a> for DLC instead.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the specified App ID is installed; otherwise, <b>false</b>.</summary>
        /// <param name="appID"><a href="https://partner.steamgames.com/doc/api/steam_api#AppId_t" class="bb_apilink">AppId_t</a>: The App ID of the application to check.</param>
        public static bool BIsAppInstalled(AppId appID) => Instance.BIsAppInstalled(appID);
        /// <summary><code>CSteamID GetAppOwner();</code>Gets the Steam ID of the true owner of the current app. This is different from the current user if they are accessing this app via Family Sharing<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#CSteamID" class="bb_apilink">CSteamID</a><br />
        /// The original owner of the current app.</summary>
        /// 
        public static SteamId GetAppOwner() => Instance.GetAppOwner();
        /// <summary><code>const char * GetLaunchQueryParam( const char *pchKey );</code><br />
        /// Gets the associated launch parameter if the game is run via steam://run/&lt;appid&gt;/?param1=value1;param2=value2;param3=value3 etc.<br />
        /// <br />
        /// Parameter names starting with the character '@' are reserved for internal use and will always return an empty string.<br />
        /// Parameter names starting with an underscore '_' are reserved for steam features -- they can be queried by the game, but it is advised that you not param names beginning with an underscore for your own features.<br />
        /// <br />
        /// <b>Returns:</b> const char *<br />
        /// The value associated with the key provided. Returns an empty string ("") if the specified key does not exist.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamApps#NewLaunchQueryParameters_t" class="bb_apilink">ISteamApps::NewLaunchQueryParameters_t</a></summary>
        /// <param name="pchKey">const char *: The launch key to test for. Ex: param1</param>
        public static UTF8StringPtr GetLaunchQueryParam(UTF8StringPtr pchKey) => Instance.GetLaunchQueryParam(pchKey);
        /// <summary><code>bool GetDlcDownloadProgress( AppId_t nAppID, uint64 *punBytesDownloaded, uint64 *punBytesTotal );</code><br />
        /// Gets the download progress for optional DLC.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the specified DLC exists and is currently downloading; otherwise, <b>false</b>.</summary>
        /// <param name="nAppID"><a href="https://partner.steamgames.com/doc/api/steam_api#AppId_t" class="bb_apilink">AppId_t</a>: The App ID of the DLC to monitor</param>
        /// <param name="punBytesDownloaded"><a href="https://partner.steamgames.com/doc/api/steam_api#uint64" class="bb_apilink">uint64</a> *: Returns the number of bytes downloaded.</param>
        /// <param name="punBytesTotal"><a href="https://partner.steamgames.com/doc/api/steam_api#uint64" class="bb_apilink">uint64</a> *: Returns the total size of the download in bytes.</param>
        public static bool GetDlcDownloadProgress(AppId nAppID, ulong* punBytesDownloaded, ulong* punBytesTotal) => Instance.GetDlcDownloadProgress(nAppID, punBytesDownloaded, punBytesTotal);
        /// <summary><code>int GetAppBuildId();</code>Gets the buildid of this app, may change at any time based on backend updates to the game.<br />
        /// <br />
        /// <b>Returns:</b> int<br />
        /// The current Build Id of this App. Defaults to 0 if you're not running a build downloaded from steam.</summary>
        /// 
        public static int GetAppBuildId() => Instance.GetAppBuildId();
        /// <summary><code>void RequestAllProofOfPurchaseKeys();</code>Deprecated.</summary>
        /// 
        public static void RequestAllProofOfPurchaseKeys() => Instance.RequestAllProofOfPurchaseKeys();
        /// <summary><code>SteamAPICall_t GetFileDetails( const char*pszFileName );</code><br />
        /// Asynchronously retrieves metadata details about a specific file in the depot manifest.<br />
        /// <br />
        /// Currently provides:<br />
        /// The file size in bytes.<br />
        /// The file's SHA1 hash.<br />
        /// The file's flags.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamApps#FileDetailsResult_t" class="bb_apilink">FileDetailsResult_t</a> call result.</summary>
        /// <param name="pszFileName">const char*: The absolute path and name to the file.</param>
        public static SteamAPICall GetFileDetails(UTF8StringPtr pszFileName) => Instance.GetFileDetails(pszFileName);
        /// <summary><code>int GetLaunchCommandLine( char *pszCommandLine, int cubCommandLine );</code><br />
        /// Gets the command line if the game was launched via Steam URL, e.g. steam://run/&lt;appid&gt;//&lt;command line&gt;/. This method is preferable to launching with a command line via the operating system, which can be a security risk. In order for rich presence joins to go through this and not be placed on the OS command line, you must enable "Use launch command line" from the Installation &gt; General page on your app.<br />
        /// <br />
        /// <b>Returns:</b> int<br />
        /// Returns the command line as a string into the buffer provided in pszCommandLine and returns the number of bytes that were copied into that buffer.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamApps#NewUrlLaunchParameters_t" class="bb_apilink">ISteamApps::NewUrlLaunchParameters_t</a></summary>
        /// <param name="pszCommandLine">char *: The string buffer that the command line will be copied into.</param>
        /// <param name="cubCommandLine ">int: The size in bytes of the <code class="bb_code bb_code_inline nohighlight">pszCommandLine</code> buffer.</param>
        public static int GetLaunchCommandLine(char* pszCommandLine, int cubCommandLine) => Instance.GetLaunchCommandLine(pszCommandLine, cubCommandLine);
        /// <summary><code>bool BIsSubscribedFromFamilySharing();</code><br />
        /// Checks if the active user is accessing the current appID via a temporary Family Shared license owned by another user. <br />
        /// <br />
        /// If you need to determine the steamID of the permanent owner of the license, use <a href="https://partner.steamgames.com/doc/api/ISteamApps#GetAppOwner" class="bb_doclink">GetAppOwner</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the active user is accessing the current appID via family sharing, otherwise <b>false</b>.</summary>
        /// 
        public static bool BIsSubscribedFromFamilySharing() => Instance.BIsSubscribedFromFamilySharing();
        /// <summary><code>bool BIsTimedTrial(uint32* punSecondsAllowed, uint32* punSecondsPlayed);</code><br />
        /// Checks if the user is subscribed to the current appID through a timed trial. If so, returns true and gives back the total time the timed trial is allowed to play, along with the current amount of time the user has played.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the active user is subscribed to the current appID via a timed trial otherwise <b>false</b> any other type of license.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamApps#TimedTrialStatus_t" class="bb_apilink">ISteamApps::TimedTrialStatus_t</a></summary>
        /// <param name="punSecondsAllowed"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a> *: Returns the number of seconds the timed trial will list.</param>
        /// <param name="punSecondsPlayed"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a> *: Returns the number of seconds that the user has played so far.</param>
        public static bool BIsTimedTrial(uint* punSecondsAllowed, uint* punSecondsPlayed) => Instance.BIsTimedTrial(punSecondsAllowed, punSecondsPlayed);
        /// missing documentation
        public static bool SetDlcContext(AppId nAppID) => Instance.SetDlcContext(nAppID);
    }
}