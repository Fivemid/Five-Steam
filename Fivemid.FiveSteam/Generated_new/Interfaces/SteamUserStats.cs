using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamUserStats
    {
        public static ISteamUserStats.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamUserStats_v012", CallingConvention = Platform.CC)]
        private static extern ISteamUserStats.Instance Accessor();
        /// <summary></summary>
        public static bool RequestCurrentStats() => Instance.RequestCurrentStats();
        /// <summary></summary>
        public static bool GetStat(UTF8StringPtr pchName, int* pData) => Instance.GetStat(pchName, pData);
        /// <summary></summary>
        public static bool GetStat(UTF8StringPtr pchName, float* pData) => Instance.GetStat(pchName, pData);
        /// <summary></summary>
        public static bool SetStat(UTF8StringPtr pchName, int nData) => Instance.SetStat(pchName, nData);
        /// <summary></summary>
        public static bool SetStat(UTF8StringPtr pchName, float fData) => Instance.SetStat(pchName, fData);
        /// <summary></summary>
        public static bool UpdateAvgRateStat(UTF8StringPtr pchName, float flCountThisSession, double dSessionLength) => Instance.UpdateAvgRateStat(pchName, flCountThisSession, dSessionLength);
        /// <summary></summary>
        public static bool GetAchievement(UTF8StringPtr pchName, bool* pbAchieved) => Instance.GetAchievement(pchName, pbAchieved);
        /// <summary></summary>
        public static bool SetAchievement(UTF8StringPtr pchName) => Instance.SetAchievement(pchName);
        /// <summary></summary>
        public static bool ClearAchievement(UTF8StringPtr pchName) => Instance.ClearAchievement(pchName);
        /// <summary></summary>
        public static bool GetAchievementAndUnlockTime(UTF8StringPtr pchName, bool* pbAchieved, uint* punUnlockTime) => Instance.GetAchievementAndUnlockTime(pchName, pbAchieved, punUnlockTime);
        /// <summary></summary>
        public static bool StoreStats() => Instance.StoreStats();
        /// <summary></summary>
        public static int GetAchievementIcon(UTF8StringPtr pchName) => Instance.GetAchievementIcon(pchName);
        /// <summary></summary>
        public static UTF8StringPtr GetAchievementDisplayAttribute(UTF8StringPtr pchName, UTF8StringPtr pchKey) => Instance.GetAchievementDisplayAttribute(pchName, pchKey);
        /// <summary></summary>
        public static bool IndicateAchievementProgress(UTF8StringPtr pchName, uint nCurProgress, uint nMaxProgress) => Instance.IndicateAchievementProgress(pchName, nCurProgress, nMaxProgress);
        /// <summary></summary>
        public static uint GetNumAchievements() => Instance.GetNumAchievements();
        /// <summary></summary>
        public static UTF8StringPtr GetAchievementName(uint iAchievement) => Instance.GetAchievementName(iAchievement);
        /// <summary></summary>
        public static SteamAPICall RequestUserStats(SteamId steamIDUser) => Instance.RequestUserStats(steamIDUser);
        /// <summary></summary>
        public static bool GetUserStat(SteamId steamIDUser, UTF8StringPtr pchName, int* pData) => Instance.GetUserStat(steamIDUser, pchName, pData);
        /// <summary></summary>
        public static bool GetUserStat(SteamId steamIDUser, UTF8StringPtr pchName, float* pData) => Instance.GetUserStat(steamIDUser, pchName, pData);
        /// <summary></summary>
        public static bool GetUserAchievement(SteamId steamIDUser, UTF8StringPtr pchName, bool* pbAchieved) => Instance.GetUserAchievement(steamIDUser, pchName, pbAchieved);
        /// <summary></summary>
        public static bool GetUserAchievementAndUnlockTime(SteamId steamIDUser, UTF8StringPtr pchName, bool* pbAchieved, uint* punUnlockTime) => Instance.GetUserAchievementAndUnlockTime(steamIDUser, pchName, pbAchieved, punUnlockTime);
        /// <summary></summary>
        public static bool ResetAllStats(bool bAchievementsToo) => Instance.ResetAllStats(bAchievementsToo);
        /// <summary></summary>
        public static SteamAPICall FindOrCreateLeaderboard(UTF8StringPtr pchLeaderboardName, LeaderboardSortMethod eLeaderboardSortMethod, LeaderboardDisplayType eLeaderboardDisplayType) => Instance.FindOrCreateLeaderboard(pchLeaderboardName, eLeaderboardSortMethod, eLeaderboardDisplayType);
        /// <summary></summary>
        public static SteamAPICall FindLeaderboard(UTF8StringPtr pchLeaderboardName) => Instance.FindLeaderboard(pchLeaderboardName);
        /// <summary></summary>
        public static UTF8StringPtr GetLeaderboardName(SteamLeaderboard hSteamLeaderboard) => Instance.GetLeaderboardName(hSteamLeaderboard);
        /// <summary></summary>
        public static int GetLeaderboardEntryCount(SteamLeaderboard hSteamLeaderboard) => Instance.GetLeaderboardEntryCount(hSteamLeaderboard);
        /// <summary></summary>
        public static LeaderboardSortMethod GetLeaderboardSortMethod(SteamLeaderboard hSteamLeaderboard) => Instance.GetLeaderboardSortMethod(hSteamLeaderboard);
        /// <summary></summary>
        public static LeaderboardDisplayType GetLeaderboardDisplayType(SteamLeaderboard hSteamLeaderboard) => Instance.GetLeaderboardDisplayType(hSteamLeaderboard);
        /// <summary></summary>
        public static SteamAPICall DownloadLeaderboardEntries(SteamLeaderboard hSteamLeaderboard, LeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd) => Instance.DownloadLeaderboardEntries(hSteamLeaderboard, eLeaderboardDataRequest, nRangeStart, nRangeEnd);
        /// <summary></summary>
        public static SteamAPICall DownloadLeaderboardEntriesForUsers(SteamLeaderboard hSteamLeaderboard, SteamId* prgUsers, int cUsers) => Instance.DownloadLeaderboardEntriesForUsers(hSteamLeaderboard, prgUsers, cUsers);
        /// <summary></summary>
        public static bool GetDownloadedLeaderboardEntry(SteamLeaderboardEntries hSteamLeaderboardEntries, int index, LeaderboardEntry* pLeaderboardEntry, int* pDetails, int cDetailsMax) => Instance.GetDownloadedLeaderboardEntry(hSteamLeaderboardEntries, index, pLeaderboardEntry, pDetails, cDetailsMax);
        /// <summary></summary>
        public static SteamAPICall UploadLeaderboardScore(SteamLeaderboard hSteamLeaderboard, LeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, int* pScoreDetails, int cScoreDetailsCount) => Instance.UploadLeaderboardScore(hSteamLeaderboard, eLeaderboardUploadScoreMethod, nScore, pScoreDetails, cScoreDetailsCount);
        /// <summary></summary>
        public static SteamAPICall AttachLeaderboardUGC(SteamLeaderboard hSteamLeaderboard, UGCHandle hUGC) => Instance.AttachLeaderboardUGC(hSteamLeaderboard, hUGC);
        /// <summary></summary>
        public static SteamAPICall GetNumberOfCurrentPlayers() => Instance.GetNumberOfCurrentPlayers();
        /// <summary></summary>
        public static SteamAPICall RequestGlobalAchievementPercentages() => Instance.RequestGlobalAchievementPercentages();
        /// <summary></summary>
        public static int GetMostAchievedAchievementInfo(char* pchName, uint unNameBufLen, float* pflPercent, bool* pbAchieved) => Instance.GetMostAchievedAchievementInfo(pchName, unNameBufLen, pflPercent, pbAchieved);
        /// <summary></summary>
        public static int GetNextMostAchievedAchievementInfo(int iIteratorPrevious, char* pchName, uint unNameBufLen, float* pflPercent, bool* pbAchieved) => Instance.GetNextMostAchievedAchievementInfo(iIteratorPrevious, pchName, unNameBufLen, pflPercent, pbAchieved);
        /// <summary></summary>
        public static bool GetAchievementAchievedPercent(UTF8StringPtr pchName, float* pflPercent) => Instance.GetAchievementAchievedPercent(pchName, pflPercent);
        /// <summary></summary>
        public static SteamAPICall RequestGlobalStats(int nHistoryDays) => Instance.RequestGlobalStats(nHistoryDays);
        /// <summary></summary>
        public static bool GetGlobalStat(UTF8StringPtr pchStatName, long* pData) => Instance.GetGlobalStat(pchStatName, pData);
        /// <summary></summary>
        public static bool GetGlobalStat(UTF8StringPtr pchStatName, double* pData) => Instance.GetGlobalStat(pchStatName, pData);
        /// <summary></summary>
        public static int GetGlobalStatHistory(UTF8StringPtr pchStatName, long* pData, uint cubData) => Instance.GetGlobalStatHistory(pchStatName, pData, cubData);
        /// <summary></summary>
        public static int GetGlobalStatHistory(UTF8StringPtr pchStatName, double* pData, uint cubData) => Instance.GetGlobalStatHistory(pchStatName, pData, cubData);
        /// <summary></summary>
        public static bool GetAchievementProgressLimits(UTF8StringPtr pchName, int* pnMinProgress, int* pnMaxProgress) => Instance.GetAchievementProgressLimits(pchName, pnMinProgress, pnMaxProgress);
        /// <summary></summary>
        public static bool GetAchievementProgressLimits(UTF8StringPtr pchName, float* pfMinProgress, float* pfMaxProgress) => Instance.GetAchievementProgressLimits(pchName, pfMinProgress, pfMaxProgress);
    }
}