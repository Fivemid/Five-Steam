using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamGameServerStats
    {
        public static ISteamGameServerStats.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamGameServerStats_v001", CallingConvention = Platform.CC)]
        private static extern ISteamGameServerStats.Instance Accessor();
        /// <summary></summary>
        public static SteamAPICall RequestUserStats(SteamId steamIDUser) => Instance.RequestUserStats(steamIDUser);
        /// <summary></summary>
        public static bool GetUserStat(SteamId steamIDUser, UTF8StringPtr pchName, int* pData) => Instance.GetUserStat(steamIDUser, pchName, pData);
        /// <summary></summary>
        public static bool GetUserStat(SteamId steamIDUser, UTF8StringPtr pchName, float* pData) => Instance.GetUserStat(steamIDUser, pchName, pData);
        /// <summary></summary>
        public static bool GetUserAchievement(SteamId steamIDUser, UTF8StringPtr pchName, bool* pbAchieved) => Instance.GetUserAchievement(steamIDUser, pchName, pbAchieved);
        /// <summary></summary>
        public static bool SetUserStat(SteamId steamIDUser, UTF8StringPtr pchName, int nData) => Instance.SetUserStat(steamIDUser, pchName, nData);
        /// <summary></summary>
        public static bool SetUserStat(SteamId steamIDUser, UTF8StringPtr pchName, float fData) => Instance.SetUserStat(steamIDUser, pchName, fData);
        /// <summary></summary>
        public static bool UpdateUserAvgRateStat(SteamId steamIDUser, UTF8StringPtr pchName, float flCountThisSession, double dSessionLength) => Instance.UpdateUserAvgRateStat(steamIDUser, pchName, flCountThisSession, dSessionLength);
        /// <summary></summary>
        public static bool SetUserAchievement(SteamId steamIDUser, UTF8StringPtr pchName) => Instance.SetUserAchievement(steamIDUser, pchName);
        /// <summary></summary>
        public static bool ClearUserAchievement(SteamId steamIDUser, UTF8StringPtr pchName) => Instance.ClearUserAchievement(steamIDUser, pchName);
        /// <summary></summary>
        public static SteamAPICall StoreUserStats(SteamId steamIDUser) => Instance.StoreUserStats(steamIDUser);
    }
}