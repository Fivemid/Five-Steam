using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Functions to allow game servers to set stats and achievements on players.</summary>
    public unsafe interface ISteamGameServerStats
    {
        public SteamAPICall RequestUserStats(SteamId steamIDUser);
        public bool GetUserStat(SteamId steamIDUser, UTF8StringPtr pchName, int* pData);
        public bool GetUserStat(SteamId steamIDUser, UTF8StringPtr pchName, float* pData);
        public bool GetUserAchievement(SteamId steamIDUser, UTF8StringPtr pchName, bool* pbAchieved);
        public bool SetUserStat(SteamId steamIDUser, UTF8StringPtr pchName, int nData);
        public bool SetUserStat(SteamId steamIDUser, UTF8StringPtr pchName, float fData);
        public bool UpdateUserAvgRateStat(SteamId steamIDUser, UTF8StringPtr pchName, float flCountThisSession, double dSessionLength);
        public bool SetUserAchievement(SteamId steamIDUser, UTF8StringPtr pchName);
        public bool ClearUserAchievement(SteamId steamIDUser, UTF8StringPtr pchName);
        public SteamAPICall StoreUserStats(SteamId steamIDUser);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamGameServerStats_RequestUserStats", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall RequestUserStats(void* self, SteamId steamIDUser);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamGameServerStats_GetUserStatInt32", CallingConvention = Platform.CC)]
        internal static extern bool GetUserStat(void* self, SteamId steamIDUser, UTF8StringPtr pchName, int* pData);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamGameServerStats_GetUserStatFloat", CallingConvention = Platform.CC)]
        internal static extern bool GetUserStat(void* self, SteamId steamIDUser, UTF8StringPtr pchName, float* pData);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamGameServerStats_GetUserAchievement", CallingConvention = Platform.CC)]
        internal static extern bool GetUserAchievement(void* self, SteamId steamIDUser, UTF8StringPtr pchName, bool* pbAchieved);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamGameServerStats_SetUserStatInt32", CallingConvention = Platform.CC)]
        internal static extern bool SetUserStat(void* self, SteamId steamIDUser, UTF8StringPtr pchName, int nData);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamGameServerStats_SetUserStatFloat", CallingConvention = Platform.CC)]
        internal static extern bool SetUserStat(void* self, SteamId steamIDUser, UTF8StringPtr pchName, float fData);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamGameServerStats_UpdateUserAvgRateStat", CallingConvention = Platform.CC)]
        internal static extern bool UpdateUserAvgRateStat(void* self, SteamId steamIDUser, UTF8StringPtr pchName, float flCountThisSession, double dSessionLength);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamGameServerStats_SetUserAchievement", CallingConvention = Platform.CC)]
        internal static extern bool SetUserAchievement(void* self, SteamId steamIDUser, UTF8StringPtr pchName);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamGameServerStats_ClearUserAchievement", CallingConvention = Platform.CC)]
        internal static extern bool ClearUserAchievement(void* self, SteamId steamIDUser, UTF8StringPtr pchName);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamGameServerStats_StoreUserStats", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall StoreUserStats(void* self, SteamId steamIDUser);
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct Instance : ISteamGameServerStats
        {
            public void* self;
            public SteamAPICall RequestUserStats(SteamId steamIDUser) => ISteamGameServerStats.RequestUserStats(self, steamIDUser);
            public bool GetUserStat(SteamId steamIDUser, UTF8StringPtr pchName, int* pData) => ISteamGameServerStats.GetUserStat(self, steamIDUser, pchName, pData);
            public bool GetUserStat(SteamId steamIDUser, UTF8StringPtr pchName, float* pData) => ISteamGameServerStats.GetUserStat(self, steamIDUser, pchName, pData);
            public bool GetUserAchievement(SteamId steamIDUser, UTF8StringPtr pchName, bool* pbAchieved) => ISteamGameServerStats.GetUserAchievement(self, steamIDUser, pchName, pbAchieved);
            public bool SetUserStat(SteamId steamIDUser, UTF8StringPtr pchName, int nData) => ISteamGameServerStats.SetUserStat(self, steamIDUser, pchName, nData);
            public bool SetUserStat(SteamId steamIDUser, UTF8StringPtr pchName, float fData) => ISteamGameServerStats.SetUserStat(self, steamIDUser, pchName, fData);
            public bool UpdateUserAvgRateStat(SteamId steamIDUser, UTF8StringPtr pchName, float flCountThisSession, double dSessionLength) => ISteamGameServerStats.UpdateUserAvgRateStat(self, steamIDUser, pchName, flCountThisSession, dSessionLength);
            public bool SetUserAchievement(SteamId steamIDUser, UTF8StringPtr pchName) => ISteamGameServerStats.SetUserAchievement(self, steamIDUser, pchName);
            public bool ClearUserAchievement(SteamId steamIDUser, UTF8StringPtr pchName) => ISteamGameServerStats.ClearUserAchievement(self, steamIDUser, pchName);
            public SteamAPICall StoreUserStats(SteamId steamIDUser) => ISteamGameServerStats.StoreUserStats(self, steamIDUser);
        }
    }
}