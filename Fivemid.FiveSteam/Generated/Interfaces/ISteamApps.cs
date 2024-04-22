using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Exposes a wide range of information and actions for applications and <a href="https://partner.steamgames.com/doc/store/application/dlc" class="bb_doclink">Downloadable Content (DLC)</a>.</summary>
    public unsafe interface ISteamApps
    {
        public bool BIsSubscribed();
        public bool BIsLowViolence();
        public bool BIsCybercafe();
        public bool BIsVACBanned();
        public UTF8StringPtr GetCurrentGameLanguage();
        public UTF8StringPtr GetAvailableGameLanguages();
        public bool BIsSubscribedApp(AppId appID);
        public bool BIsDlcInstalled(AppId appID);
        public uint GetEarliestPurchaseUnixTime(AppId nAppID);
        public bool BIsSubscribedFromFreeWeekend();
        public int GetDLCCount();
        public bool BGetDLCDataByIndex(int iDLC, AppId* pAppID, bool* pbAvailable, char* pchName, int cchNameBufferSize);
        public void InstallDLC(AppId nAppID);
        public void UninstallDLC(AppId nAppID);
        public void RequestAppProofOfPurchaseKey(AppId nAppID);
        public bool GetCurrentBetaName(char* pchName, int cchNameBufferSize);
        public bool MarkContentCorrupt(bool bMissingFilesOnly);
        public uint GetInstalledDepots(AppId appID, DepotId* pvecDepots, uint cMaxDepots);
        public uint GetAppInstallDir(AppId appID, char* pchFolder, uint cchFolderBufferSize);
        public bool BIsAppInstalled(AppId appID);
        public SteamId GetAppOwner();
        public UTF8StringPtr GetLaunchQueryParam(UTF8StringPtr pchKey);
        public bool GetDlcDownloadProgress(AppId nAppID, ulong* punBytesDownloaded, ulong* punBytesTotal);
        public int GetAppBuildId();
        public void RequestAllProofOfPurchaseKeys();
        public SteamAPICall GetFileDetails(UTF8StringPtr pszFileName);
        public int GetLaunchCommandLine(char* pszCommandLine, int cubCommandLine);
        public bool BIsSubscribedFromFamilySharing();
        public bool BIsTimedTrial(uint* punSecondsAllowed, uint* punSecondsPlayed);
        public bool SetDlcContext(AppId nAppID);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_BIsSubscribed", CallingConvention = Platform.CC)]
        internal static extern bool BIsSubscribed(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_BIsLowViolence", CallingConvention = Platform.CC)]
        internal static extern bool BIsLowViolence(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_BIsCybercafe", CallingConvention = Platform.CC)]
        internal static extern bool BIsCybercafe(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_BIsVACBanned", CallingConvention = Platform.CC)]
        internal static extern bool BIsVACBanned(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_GetCurrentGameLanguage", CallingConvention = Platform.CC)]
        internal static extern UTF8StringPtr GetCurrentGameLanguage(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_GetAvailableGameLanguages", CallingConvention = Platform.CC)]
        internal static extern UTF8StringPtr GetAvailableGameLanguages(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_BIsSubscribedApp", CallingConvention = Platform.CC)]
        internal static extern bool BIsSubscribedApp(void* self, AppId appID);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_BIsDlcInstalled", CallingConvention = Platform.CC)]
        internal static extern bool BIsDlcInstalled(void* self, AppId appID);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_GetEarliestPurchaseUnixTime", CallingConvention = Platform.CC)]
        internal static extern uint GetEarliestPurchaseUnixTime(void* self, AppId nAppID);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_BIsSubscribedFromFreeWeekend", CallingConvention = Platform.CC)]
        internal static extern bool BIsSubscribedFromFreeWeekend(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_GetDLCCount", CallingConvention = Platform.CC)]
        internal static extern int GetDLCCount(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_BGetDLCDataByIndex", CallingConvention = Platform.CC)]
        internal static extern bool BGetDLCDataByIndex(void* self, int iDLC, AppId* pAppID, bool* pbAvailable, char* pchName, int cchNameBufferSize);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_InstallDLC", CallingConvention = Platform.CC)]
        internal static extern void InstallDLC(void* self, AppId nAppID);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_UninstallDLC", CallingConvention = Platform.CC)]
        internal static extern void UninstallDLC(void* self, AppId nAppID);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_RequestAppProofOfPurchaseKey", CallingConvention = Platform.CC)]
        internal static extern void RequestAppProofOfPurchaseKey(void* self, AppId nAppID);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_GetCurrentBetaName", CallingConvention = Platform.CC)]
        internal static extern bool GetCurrentBetaName(void* self, char* pchName, int cchNameBufferSize);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_MarkContentCorrupt", CallingConvention = Platform.CC)]
        internal static extern bool MarkContentCorrupt(void* self, bool bMissingFilesOnly);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_GetInstalledDepots", CallingConvention = Platform.CC)]
        internal static extern uint GetInstalledDepots(void* self, AppId appID, DepotId* pvecDepots, uint cMaxDepots);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_GetAppInstallDir", CallingConvention = Platform.CC)]
        internal static extern uint GetAppInstallDir(void* self, AppId appID, char* pchFolder, uint cchFolderBufferSize);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_BIsAppInstalled", CallingConvention = Platform.CC)]
        internal static extern bool BIsAppInstalled(void* self, AppId appID);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_GetAppOwner", CallingConvention = Platform.CC)]
        internal static extern SteamId GetAppOwner(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_GetLaunchQueryParam", CallingConvention = Platform.CC)]
        internal static extern UTF8StringPtr GetLaunchQueryParam(void* self, UTF8StringPtr pchKey);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_GetDlcDownloadProgress", CallingConvention = Platform.CC)]
        internal static extern bool GetDlcDownloadProgress(void* self, AppId nAppID, ulong* punBytesDownloaded, ulong* punBytesTotal);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_GetAppBuildId", CallingConvention = Platform.CC)]
        internal static extern int GetAppBuildId(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_RequestAllProofOfPurchaseKeys", CallingConvention = Platform.CC)]
        internal static extern void RequestAllProofOfPurchaseKeys(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_GetFileDetails", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall GetFileDetails(void* self, UTF8StringPtr pszFileName);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_GetLaunchCommandLine", CallingConvention = Platform.CC)]
        internal static extern int GetLaunchCommandLine(void* self, char* pszCommandLine, int cubCommandLine);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_BIsSubscribedFromFamilySharing", CallingConvention = Platform.CC)]
        internal static extern bool BIsSubscribedFromFamilySharing(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_BIsTimedTrial", CallingConvention = Platform.CC)]
        internal static extern bool BIsTimedTrial(void* self, uint* punSecondsAllowed, uint* punSecondsPlayed);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamApps_SetDlcContext", CallingConvention = Platform.CC)]
        internal static extern bool SetDlcContext(void* self, AppId nAppID);
        public struct Instance : ISteamApps
        {
            public void* self;
            public bool BIsSubscribed() => ISteamApps.BIsSubscribed(self);
            public bool BIsLowViolence() => ISteamApps.BIsLowViolence(self);
            public bool BIsCybercafe() => ISteamApps.BIsCybercafe(self);
            public bool BIsVACBanned() => ISteamApps.BIsVACBanned(self);
            public UTF8StringPtr GetCurrentGameLanguage() => ISteamApps.GetCurrentGameLanguage(self);
            public UTF8StringPtr GetAvailableGameLanguages() => ISteamApps.GetAvailableGameLanguages(self);
            public bool BIsSubscribedApp(AppId appID) => ISteamApps.BIsSubscribedApp(self, appID);
            public bool BIsDlcInstalled(AppId appID) => ISteamApps.BIsDlcInstalled(self, appID);
            public uint GetEarliestPurchaseUnixTime(AppId nAppID) => ISteamApps.GetEarliestPurchaseUnixTime(self, nAppID);
            public bool BIsSubscribedFromFreeWeekend() => ISteamApps.BIsSubscribedFromFreeWeekend(self);
            public int GetDLCCount() => ISteamApps.GetDLCCount(self);
            public bool BGetDLCDataByIndex(int iDLC, AppId* pAppID, bool* pbAvailable, char* pchName, int cchNameBufferSize) => ISteamApps.BGetDLCDataByIndex(self, iDLC, pAppID, pbAvailable, pchName, cchNameBufferSize);
            public void InstallDLC(AppId nAppID) => ISteamApps.InstallDLC(self, nAppID);
            public void UninstallDLC(AppId nAppID) => ISteamApps.UninstallDLC(self, nAppID);
            public void RequestAppProofOfPurchaseKey(AppId nAppID) => ISteamApps.RequestAppProofOfPurchaseKey(self, nAppID);
            public bool GetCurrentBetaName(char* pchName, int cchNameBufferSize) => ISteamApps.GetCurrentBetaName(self, pchName, cchNameBufferSize);
            public bool MarkContentCorrupt(bool bMissingFilesOnly) => ISteamApps.MarkContentCorrupt(self, bMissingFilesOnly);
            public uint GetInstalledDepots(AppId appID, DepotId* pvecDepots, uint cMaxDepots) => ISteamApps.GetInstalledDepots(self, appID, pvecDepots, cMaxDepots);
            public uint GetAppInstallDir(AppId appID, char* pchFolder, uint cchFolderBufferSize) => ISteamApps.GetAppInstallDir(self, appID, pchFolder, cchFolderBufferSize);
            public bool BIsAppInstalled(AppId appID) => ISteamApps.BIsAppInstalled(self, appID);
            public SteamId GetAppOwner() => ISteamApps.GetAppOwner(self);
            public UTF8StringPtr GetLaunchQueryParam(UTF8StringPtr pchKey) => ISteamApps.GetLaunchQueryParam(self, pchKey);
            public bool GetDlcDownloadProgress(AppId nAppID, ulong* punBytesDownloaded, ulong* punBytesTotal) => ISteamApps.GetDlcDownloadProgress(self, nAppID, punBytesDownloaded, punBytesTotal);
            public int GetAppBuildId() => ISteamApps.GetAppBuildId(self);
            public void RequestAllProofOfPurchaseKeys() => ISteamApps.RequestAllProofOfPurchaseKeys(self);
            public SteamAPICall GetFileDetails(UTF8StringPtr pszFileName) => ISteamApps.GetFileDetails(self, pszFileName);
            public int GetLaunchCommandLine(char* pszCommandLine, int cubCommandLine) => ISteamApps.GetLaunchCommandLine(self, pszCommandLine, cubCommandLine);
            public bool BIsSubscribedFromFamilySharing() => ISteamApps.BIsSubscribedFromFamilySharing(self);
            public bool BIsTimedTrial(uint* punSecondsAllowed, uint* punSecondsPlayed) => ISteamApps.BIsTimedTrial(self, punSecondsAllowed, punSecondsPlayed);
            public bool SetDlcContext(AppId nAppID) => ISteamApps.SetDlcContext(self, nAppID);
        }
    }
}