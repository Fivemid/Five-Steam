using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamApps
    {
        public static ISteamApps.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamApps_v008", CallingConvention = Platform.CC)]
        private static extern ISteamApps.Instance Accessor();
        /// <summary></summary>
        public static bool BIsSubscribed() => Instance.BIsSubscribed();
        /// <summary></summary>
        public static bool BIsLowViolence() => Instance.BIsLowViolence();
        /// <summary></summary>
        public static bool BIsCybercafe() => Instance.BIsCybercafe();
        /// <summary></summary>
        public static bool BIsVACBanned() => Instance.BIsVACBanned();
        /// <summary></summary>
        public static UTF8StringPtr GetCurrentGameLanguage() => Instance.GetCurrentGameLanguage();
        /// <summary></summary>
        public static UTF8StringPtr GetAvailableGameLanguages() => Instance.GetAvailableGameLanguages();
        /// <summary></summary>
        public static bool BIsSubscribedApp(AppId appID) => Instance.BIsSubscribedApp(appID);
        /// <summary></summary>
        public static bool BIsDlcInstalled(AppId appID) => Instance.BIsDlcInstalled(appID);
        /// <summary></summary>
        public static uint GetEarliestPurchaseUnixTime(AppId nAppID) => Instance.GetEarliestPurchaseUnixTime(nAppID);
        /// <summary></summary>
        public static bool BIsSubscribedFromFreeWeekend() => Instance.BIsSubscribedFromFreeWeekend();
        /// <summary></summary>
        public static int GetDLCCount() => Instance.GetDLCCount();
        /// <summary></summary>
        public static bool BGetDLCDataByIndex(int iDLC, AppId* pAppID, bool* pbAvailable, char* pchName, int cchNameBufferSize) => Instance.BGetDLCDataByIndex(iDLC, pAppID, pbAvailable, pchName, cchNameBufferSize);
        /// <summary></summary>
        public static void InstallDLC(AppId nAppID) => Instance.InstallDLC(nAppID);
        /// <summary></summary>
        public static void UninstallDLC(AppId nAppID) => Instance.UninstallDLC(nAppID);
        /// <summary></summary>
        public static void RequestAppProofOfPurchaseKey(AppId nAppID) => Instance.RequestAppProofOfPurchaseKey(nAppID);
        /// <summary></summary>
        public static bool GetCurrentBetaName(char* pchName, int cchNameBufferSize) => Instance.GetCurrentBetaName(pchName, cchNameBufferSize);
        /// <summary></summary>
        public static bool MarkContentCorrupt(bool bMissingFilesOnly) => Instance.MarkContentCorrupt(bMissingFilesOnly);
        /// <summary></summary>
        public static uint GetInstalledDepots(AppId appID, DepotId* pvecDepots, uint cMaxDepots) => Instance.GetInstalledDepots(appID, pvecDepots, cMaxDepots);
        /// <summary></summary>
        public static uint GetAppInstallDir(AppId appID, char* pchFolder, uint cchFolderBufferSize) => Instance.GetAppInstallDir(appID, pchFolder, cchFolderBufferSize);
        /// <summary></summary>
        public static bool BIsAppInstalled(AppId appID) => Instance.BIsAppInstalled(appID);
        /// <summary></summary>
        public static SteamId GetAppOwner() => Instance.GetAppOwner();
        /// <summary></summary>
        public static UTF8StringPtr GetLaunchQueryParam(UTF8StringPtr pchKey) => Instance.GetLaunchQueryParam(pchKey);
        /// <summary></summary>
        public static bool GetDlcDownloadProgress(AppId nAppID, ulong* punBytesDownloaded, ulong* punBytesTotal) => Instance.GetDlcDownloadProgress(nAppID, punBytesDownloaded, punBytesTotal);
        /// <summary></summary>
        public static int GetAppBuildId() => Instance.GetAppBuildId();
        /// <summary></summary>
        public static void RequestAllProofOfPurchaseKeys() => Instance.RequestAllProofOfPurchaseKeys();
        /// <summary></summary>
        public static SteamAPICall GetFileDetails(UTF8StringPtr pszFileName) => Instance.GetFileDetails(pszFileName);
        /// <summary></summary>
        public static int GetLaunchCommandLine(char* pszCommandLine, int cubCommandLine) => Instance.GetLaunchCommandLine(pszCommandLine, cubCommandLine);
        /// <summary></summary>
        public static bool BIsSubscribedFromFamilySharing() => Instance.BIsSubscribedFromFamilySharing();
        /// <summary></summary>
        public static bool BIsTimedTrial(uint* punSecondsAllowed, uint* punSecondsPlayed) => Instance.BIsTimedTrial(punSecondsAllowed, punSecondsPlayed);
        /// <summary></summary>
        public static bool SetDlcContext(AppId nAppID) => Instance.SetDlcContext(nAppID);
    }
}