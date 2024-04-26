using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Provides functions for accessing and submitting stats, achievements, and leaderboards.</summary>
    public unsafe interface ISteamUserStats
    {
        public bool RequestCurrentStats();
        public bool GetStat(UTF8StringPtr pchName, int* pData);
        public bool GetStat(UTF8StringPtr pchName, float* pData);
        public bool SetStat(UTF8StringPtr pchName, int nData);
        public bool SetStat(UTF8StringPtr pchName, float fData);
        public bool UpdateAvgRateStat(UTF8StringPtr pchName, float flCountThisSession, double dSessionLength);
        public bool GetAchievement(UTF8StringPtr pchName, bool* pbAchieved);
        public bool SetAchievement(UTF8StringPtr pchName);
        public bool ClearAchievement(UTF8StringPtr pchName);
        public bool GetAchievementAndUnlockTime(UTF8StringPtr pchName, bool* pbAchieved, uint* punUnlockTime);
        public bool StoreStats();
        public int GetAchievementIcon(UTF8StringPtr pchName);
        public UTF8StringPtr GetAchievementDisplayAttribute(UTF8StringPtr pchName, UTF8StringPtr pchKey);
        public bool IndicateAchievementProgress(UTF8StringPtr pchName, uint nCurProgress, uint nMaxProgress);
        public uint GetNumAchievements();
        public UTF8StringPtr GetAchievementName(uint iAchievement);
        public SteamAPICall RequestUserStats(SteamId steamIDUser);
        public bool GetUserStat(SteamId steamIDUser, UTF8StringPtr pchName, int* pData);
        public bool GetUserStat(SteamId steamIDUser, UTF8StringPtr pchName, float* pData);
        public bool GetUserAchievement(SteamId steamIDUser, UTF8StringPtr pchName, bool* pbAchieved);
        public bool GetUserAchievementAndUnlockTime(SteamId steamIDUser, UTF8StringPtr pchName, bool* pbAchieved, uint* punUnlockTime);
        public bool ResetAllStats(bool bAchievementsToo);
        public SteamAPICall FindOrCreateLeaderboard(UTF8StringPtr pchLeaderboardName, LeaderboardSortMethod eLeaderboardSortMethod, LeaderboardDisplayType eLeaderboardDisplayType);
        public SteamAPICall FindLeaderboard(UTF8StringPtr pchLeaderboardName);
        public UTF8StringPtr GetLeaderboardName(SteamLeaderboard hSteamLeaderboard);
        public int GetLeaderboardEntryCount(SteamLeaderboard hSteamLeaderboard);
        public LeaderboardSortMethod GetLeaderboardSortMethod(SteamLeaderboard hSteamLeaderboard);
        public LeaderboardDisplayType GetLeaderboardDisplayType(SteamLeaderboard hSteamLeaderboard);
        public SteamAPICall DownloadLeaderboardEntries(SteamLeaderboard hSteamLeaderboard, LeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd);
        public SteamAPICall DownloadLeaderboardEntriesForUsers(SteamLeaderboard hSteamLeaderboard, SteamId* prgUsers, int cUsers);
        public bool GetDownloadedLeaderboardEntry(SteamLeaderboardEntries hSteamLeaderboardEntries, int index, LeaderboardEntry* pLeaderboardEntry, int* pDetails, int cDetailsMax);
        public SteamAPICall UploadLeaderboardScore(SteamLeaderboard hSteamLeaderboard, LeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, int* pScoreDetails, int cScoreDetailsCount);
        public SteamAPICall AttachLeaderboardUGC(SteamLeaderboard hSteamLeaderboard, UGCHandle hUGC);
        public SteamAPICall GetNumberOfCurrentPlayers();
        public SteamAPICall RequestGlobalAchievementPercentages();
        public int GetMostAchievedAchievementInfo(char* pchName, uint unNameBufLen, float* pflPercent, bool* pbAchieved);
        public int GetNextMostAchievedAchievementInfo(int iIteratorPrevious, char* pchName, uint unNameBufLen, float* pflPercent, bool* pbAchieved);
        public bool GetAchievementAchievedPercent(UTF8StringPtr pchName, float* pflPercent);
        public SteamAPICall RequestGlobalStats(int nHistoryDays);
        public bool GetGlobalStat(UTF8StringPtr pchStatName, long* pData);
        public bool GetGlobalStat(UTF8StringPtr pchStatName, double* pData);
        public int GetGlobalStatHistory(UTF8StringPtr pchStatName, long* pData, uint cubData);
        public int GetGlobalStatHistory(UTF8StringPtr pchStatName, double* pData, uint cubData);
        public bool GetAchievementProgressLimits(UTF8StringPtr pchName, int* pnMinProgress, int* pnMaxProgress);
        public bool GetAchievementProgressLimits(UTF8StringPtr pchName, float* pfMinProgress, float* pfMaxProgress);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUserStats_RequestCurrentStats", CallingConvention = Platform.CC)]
        internal static extern bool RequestCurrentStats(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUserStats_GetStatInt32", CallingConvention = Platform.CC)]
        internal static extern bool GetStat(void* self, UTF8StringPtr pchName, int* pData);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUserStats_GetStatFloat", CallingConvention = Platform.CC)]
        internal static extern bool GetStat(void* self, UTF8StringPtr pchName, float* pData);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUserStats_SetStatInt32", CallingConvention = Platform.CC)]
        internal static extern bool SetStat(void* self, UTF8StringPtr pchName, int nData);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUserStats_SetStatFloat", CallingConvention = Platform.CC)]
        internal static extern bool SetStat(void* self, UTF8StringPtr pchName, float fData);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUserStats_UpdateAvgRateStat", CallingConvention = Platform.CC)]
        internal static extern bool UpdateAvgRateStat(void* self, UTF8StringPtr pchName, float flCountThisSession, double dSessionLength);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUserStats_GetAchievement", CallingConvention = Platform.CC)]
        internal static extern bool GetAchievement(void* self, UTF8StringPtr pchName, bool* pbAchieved);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUserStats_SetAchievement", CallingConvention = Platform.CC)]
        internal static extern bool SetAchievement(void* self, UTF8StringPtr pchName);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUserStats_ClearAchievement", CallingConvention = Platform.CC)]
        internal static extern bool ClearAchievement(void* self, UTF8StringPtr pchName);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUserStats_GetAchievementAndUnlockTime", CallingConvention = Platform.CC)]
        internal static extern bool GetAchievementAndUnlockTime(void* self, UTF8StringPtr pchName, bool* pbAchieved, uint* punUnlockTime);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUserStats_StoreStats", CallingConvention = Platform.CC)]
        internal static extern bool StoreStats(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUserStats_GetAchievementIcon", CallingConvention = Platform.CC)]
        internal static extern int GetAchievementIcon(void* self, UTF8StringPtr pchName);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUserStats_GetAchievementDisplayAttribute", CallingConvention = Platform.CC)]
        internal static extern UTF8StringPtr GetAchievementDisplayAttribute(void* self, UTF8StringPtr pchName, UTF8StringPtr pchKey);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUserStats_IndicateAchievementProgress", CallingConvention = Platform.CC)]
        internal static extern bool IndicateAchievementProgress(void* self, UTF8StringPtr pchName, uint nCurProgress, uint nMaxProgress);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUserStats_GetNumAchievements", CallingConvention = Platform.CC)]
        internal static extern uint GetNumAchievements(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUserStats_GetAchievementName", CallingConvention = Platform.CC)]
        internal static extern UTF8StringPtr GetAchievementName(void* self, uint iAchievement);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUserStats_RequestUserStats", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall RequestUserStats(void* self, SteamId steamIDUser);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUserStats_GetUserStatInt32", CallingConvention = Platform.CC)]
        internal static extern bool GetUserStat(void* self, SteamId steamIDUser, UTF8StringPtr pchName, int* pData);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUserStats_GetUserStatFloat", CallingConvention = Platform.CC)]
        internal static extern bool GetUserStat(void* self, SteamId steamIDUser, UTF8StringPtr pchName, float* pData);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUserStats_GetUserAchievement", CallingConvention = Platform.CC)]
        internal static extern bool GetUserAchievement(void* self, SteamId steamIDUser, UTF8StringPtr pchName, bool* pbAchieved);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUserStats_GetUserAchievementAndUnlockTime", CallingConvention = Platform.CC)]
        internal static extern bool GetUserAchievementAndUnlockTime(void* self, SteamId steamIDUser, UTF8StringPtr pchName, bool* pbAchieved, uint* punUnlockTime);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUserStats_ResetAllStats", CallingConvention = Platform.CC)]
        internal static extern bool ResetAllStats(void* self, bool bAchievementsToo);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUserStats_FindOrCreateLeaderboard", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall FindOrCreateLeaderboard(void* self, UTF8StringPtr pchLeaderboardName, LeaderboardSortMethod eLeaderboardSortMethod, LeaderboardDisplayType eLeaderboardDisplayType);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUserStats_FindLeaderboard", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall FindLeaderboard(void* self, UTF8StringPtr pchLeaderboardName);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUserStats_GetLeaderboardName", CallingConvention = Platform.CC)]
        internal static extern UTF8StringPtr GetLeaderboardName(void* self, SteamLeaderboard hSteamLeaderboard);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUserStats_GetLeaderboardEntryCount", CallingConvention = Platform.CC)]
        internal static extern int GetLeaderboardEntryCount(void* self, SteamLeaderboard hSteamLeaderboard);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUserStats_GetLeaderboardSortMethod", CallingConvention = Platform.CC)]
        internal static extern LeaderboardSortMethod GetLeaderboardSortMethod(void* self, SteamLeaderboard hSteamLeaderboard);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUserStats_GetLeaderboardDisplayType", CallingConvention = Platform.CC)]
        internal static extern LeaderboardDisplayType GetLeaderboardDisplayType(void* self, SteamLeaderboard hSteamLeaderboard);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUserStats_DownloadLeaderboardEntries", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall DownloadLeaderboardEntries(void* self, SteamLeaderboard hSteamLeaderboard, LeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUserStats_DownloadLeaderboardEntriesForUsers", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall DownloadLeaderboardEntriesForUsers(void* self, SteamLeaderboard hSteamLeaderboard, SteamId* prgUsers, int cUsers);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUserStats_GetDownloadedLeaderboardEntry", CallingConvention = Platform.CC)]
        internal static extern bool GetDownloadedLeaderboardEntry(void* self, SteamLeaderboardEntries hSteamLeaderboardEntries, int index, LeaderboardEntry* pLeaderboardEntry, int* pDetails, int cDetailsMax);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUserStats_UploadLeaderboardScore", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall UploadLeaderboardScore(void* self, SteamLeaderboard hSteamLeaderboard, LeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, int* pScoreDetails, int cScoreDetailsCount);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUserStats_AttachLeaderboardUGC", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall AttachLeaderboardUGC(void* self, SteamLeaderboard hSteamLeaderboard, UGCHandle hUGC);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUserStats_GetNumberOfCurrentPlayers", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall GetNumberOfCurrentPlayers(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUserStats_RequestGlobalAchievementPercentages", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall RequestGlobalAchievementPercentages(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUserStats_GetMostAchievedAchievementInfo", CallingConvention = Platform.CC)]
        internal static extern int GetMostAchievedAchievementInfo(void* self, char* pchName, uint unNameBufLen, float* pflPercent, bool* pbAchieved);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUserStats_GetNextMostAchievedAchievementInfo", CallingConvention = Platform.CC)]
        internal static extern int GetNextMostAchievedAchievementInfo(void* self, int iIteratorPrevious, char* pchName, uint unNameBufLen, float* pflPercent, bool* pbAchieved);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUserStats_GetAchievementAchievedPercent", CallingConvention = Platform.CC)]
        internal static extern bool GetAchievementAchievedPercent(void* self, UTF8StringPtr pchName, float* pflPercent);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUserStats_RequestGlobalStats", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall RequestGlobalStats(void* self, int nHistoryDays);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUserStats_GetGlobalStatInt64", CallingConvention = Platform.CC)]
        internal static extern bool GetGlobalStat(void* self, UTF8StringPtr pchStatName, long* pData);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUserStats_GetGlobalStatDouble", CallingConvention = Platform.CC)]
        internal static extern bool GetGlobalStat(void* self, UTF8StringPtr pchStatName, double* pData);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUserStats_GetGlobalStatHistoryInt64", CallingConvention = Platform.CC)]
        internal static extern int GetGlobalStatHistory(void* self, UTF8StringPtr pchStatName, long* pData, uint cubData);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUserStats_GetGlobalStatHistoryDouble", CallingConvention = Platform.CC)]
        internal static extern int GetGlobalStatHistory(void* self, UTF8StringPtr pchStatName, double* pData, uint cubData);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUserStats_GetAchievementProgressLimitsInt32", CallingConvention = Platform.CC)]
        internal static extern bool GetAchievementProgressLimits(void* self, UTF8StringPtr pchName, int* pnMinProgress, int* pnMaxProgress);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUserStats_GetAchievementProgressLimitsFloat", CallingConvention = Platform.CC)]
        internal static extern bool GetAchievementProgressLimits(void* self, UTF8StringPtr pchName, float* pfMinProgress, float* pfMaxProgress);
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
        public struct Instance : ISteamUserStats
        {
            public void* self;
            public bool RequestCurrentStats() => ISteamUserStats.RequestCurrentStats(self);
            public bool GetStat(UTF8StringPtr pchName, int* pData) => ISteamUserStats.GetStat(self, pchName, pData);
            public bool GetStat(UTF8StringPtr pchName, float* pData) => ISteamUserStats.GetStat(self, pchName, pData);
            public bool SetStat(UTF8StringPtr pchName, int nData) => ISteamUserStats.SetStat(self, pchName, nData);
            public bool SetStat(UTF8StringPtr pchName, float fData) => ISteamUserStats.SetStat(self, pchName, fData);
            public bool UpdateAvgRateStat(UTF8StringPtr pchName, float flCountThisSession, double dSessionLength) => ISteamUserStats.UpdateAvgRateStat(self, pchName, flCountThisSession, dSessionLength);
            public bool GetAchievement(UTF8StringPtr pchName, bool* pbAchieved) => ISteamUserStats.GetAchievement(self, pchName, pbAchieved);
            public bool SetAchievement(UTF8StringPtr pchName) => ISteamUserStats.SetAchievement(self, pchName);
            public bool ClearAchievement(UTF8StringPtr pchName) => ISteamUserStats.ClearAchievement(self, pchName);
            public bool GetAchievementAndUnlockTime(UTF8StringPtr pchName, bool* pbAchieved, uint* punUnlockTime) => ISteamUserStats.GetAchievementAndUnlockTime(self, pchName, pbAchieved, punUnlockTime);
            public bool StoreStats() => ISteamUserStats.StoreStats(self);
            public int GetAchievementIcon(UTF8StringPtr pchName) => ISteamUserStats.GetAchievementIcon(self, pchName);
            public UTF8StringPtr GetAchievementDisplayAttribute(UTF8StringPtr pchName, UTF8StringPtr pchKey) => ISteamUserStats.GetAchievementDisplayAttribute(self, pchName, pchKey);
            public bool IndicateAchievementProgress(UTF8StringPtr pchName, uint nCurProgress, uint nMaxProgress) => ISteamUserStats.IndicateAchievementProgress(self, pchName, nCurProgress, nMaxProgress);
            public uint GetNumAchievements() => ISteamUserStats.GetNumAchievements(self);
            public UTF8StringPtr GetAchievementName(uint iAchievement) => ISteamUserStats.GetAchievementName(self, iAchievement);
            public SteamAPICall RequestUserStats(SteamId steamIDUser) => ISteamUserStats.RequestUserStats(self, steamIDUser);
            public bool GetUserStat(SteamId steamIDUser, UTF8StringPtr pchName, int* pData) => ISteamUserStats.GetUserStat(self, steamIDUser, pchName, pData);
            public bool GetUserStat(SteamId steamIDUser, UTF8StringPtr pchName, float* pData) => ISteamUserStats.GetUserStat(self, steamIDUser, pchName, pData);
            public bool GetUserAchievement(SteamId steamIDUser, UTF8StringPtr pchName, bool* pbAchieved) => ISteamUserStats.GetUserAchievement(self, steamIDUser, pchName, pbAchieved);
            public bool GetUserAchievementAndUnlockTime(SteamId steamIDUser, UTF8StringPtr pchName, bool* pbAchieved, uint* punUnlockTime) => ISteamUserStats.GetUserAchievementAndUnlockTime(self, steamIDUser, pchName, pbAchieved, punUnlockTime);
            public bool ResetAllStats(bool bAchievementsToo) => ISteamUserStats.ResetAllStats(self, bAchievementsToo);
            public SteamAPICall FindOrCreateLeaderboard(UTF8StringPtr pchLeaderboardName, LeaderboardSortMethod eLeaderboardSortMethod, LeaderboardDisplayType eLeaderboardDisplayType) => ISteamUserStats.FindOrCreateLeaderboard(self, pchLeaderboardName, eLeaderboardSortMethod, eLeaderboardDisplayType);
            public SteamAPICall FindLeaderboard(UTF8StringPtr pchLeaderboardName) => ISteamUserStats.FindLeaderboard(self, pchLeaderboardName);
            public UTF8StringPtr GetLeaderboardName(SteamLeaderboard hSteamLeaderboard) => ISteamUserStats.GetLeaderboardName(self, hSteamLeaderboard);
            public int GetLeaderboardEntryCount(SteamLeaderboard hSteamLeaderboard) => ISteamUserStats.GetLeaderboardEntryCount(self, hSteamLeaderboard);
            public LeaderboardSortMethod GetLeaderboardSortMethod(SteamLeaderboard hSteamLeaderboard) => ISteamUserStats.GetLeaderboardSortMethod(self, hSteamLeaderboard);
            public LeaderboardDisplayType GetLeaderboardDisplayType(SteamLeaderboard hSteamLeaderboard) => ISteamUserStats.GetLeaderboardDisplayType(self, hSteamLeaderboard);
            public SteamAPICall DownloadLeaderboardEntries(SteamLeaderboard hSteamLeaderboard, LeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd) => ISteamUserStats.DownloadLeaderboardEntries(self, hSteamLeaderboard, eLeaderboardDataRequest, nRangeStart, nRangeEnd);
            public SteamAPICall DownloadLeaderboardEntriesForUsers(SteamLeaderboard hSteamLeaderboard, SteamId* prgUsers, int cUsers) => ISteamUserStats.DownloadLeaderboardEntriesForUsers(self, hSteamLeaderboard, prgUsers, cUsers);
            public bool GetDownloadedLeaderboardEntry(SteamLeaderboardEntries hSteamLeaderboardEntries, int index, LeaderboardEntry* pLeaderboardEntry, int* pDetails, int cDetailsMax) => ISteamUserStats.GetDownloadedLeaderboardEntry(self, hSteamLeaderboardEntries, index, pLeaderboardEntry, pDetails, cDetailsMax);
            public SteamAPICall UploadLeaderboardScore(SteamLeaderboard hSteamLeaderboard, LeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, int* pScoreDetails, int cScoreDetailsCount) => ISteamUserStats.UploadLeaderboardScore(self, hSteamLeaderboard, eLeaderboardUploadScoreMethod, nScore, pScoreDetails, cScoreDetailsCount);
            public SteamAPICall AttachLeaderboardUGC(SteamLeaderboard hSteamLeaderboard, UGCHandle hUGC) => ISteamUserStats.AttachLeaderboardUGC(self, hSteamLeaderboard, hUGC);
            public SteamAPICall GetNumberOfCurrentPlayers() => ISteamUserStats.GetNumberOfCurrentPlayers(self);
            public SteamAPICall RequestGlobalAchievementPercentages() => ISteamUserStats.RequestGlobalAchievementPercentages(self);
            public int GetMostAchievedAchievementInfo(char* pchName, uint unNameBufLen, float* pflPercent, bool* pbAchieved) => ISteamUserStats.GetMostAchievedAchievementInfo(self, pchName, unNameBufLen, pflPercent, pbAchieved);
            public int GetNextMostAchievedAchievementInfo(int iIteratorPrevious, char* pchName, uint unNameBufLen, float* pflPercent, bool* pbAchieved) => ISteamUserStats.GetNextMostAchievedAchievementInfo(self, iIteratorPrevious, pchName, unNameBufLen, pflPercent, pbAchieved);
            public bool GetAchievementAchievedPercent(UTF8StringPtr pchName, float* pflPercent) => ISteamUserStats.GetAchievementAchievedPercent(self, pchName, pflPercent);
            public SteamAPICall RequestGlobalStats(int nHistoryDays) => ISteamUserStats.RequestGlobalStats(self, nHistoryDays);
            public bool GetGlobalStat(UTF8StringPtr pchStatName, long* pData) => ISteamUserStats.GetGlobalStat(self, pchStatName, pData);
            public bool GetGlobalStat(UTF8StringPtr pchStatName, double* pData) => ISteamUserStats.GetGlobalStat(self, pchStatName, pData);
            public int GetGlobalStatHistory(UTF8StringPtr pchStatName, long* pData, uint cubData) => ISteamUserStats.GetGlobalStatHistory(self, pchStatName, pData, cubData);
            public int GetGlobalStatHistory(UTF8StringPtr pchStatName, double* pData, uint cubData) => ISteamUserStats.GetGlobalStatHistory(self, pchStatName, pData, cubData);
            public bool GetAchievementProgressLimits(UTF8StringPtr pchName, int* pnMinProgress, int* pnMaxProgress) => ISteamUserStats.GetAchievementProgressLimits(self, pchName, pnMinProgress, pnMaxProgress);
            public bool GetAchievementProgressLimits(UTF8StringPtr pchName, float* pfMinProgress, float* pfMaxProgress) => ISteamUserStats.GetAchievementProgressLimits(self, pchName, pfMinProgress, pfMaxProgress);
        }
    }
}