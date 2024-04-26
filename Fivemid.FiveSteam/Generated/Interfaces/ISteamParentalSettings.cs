using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for ISteamParentalSettings
    public unsafe interface ISteamParentalSettings
    {
        public bool BIsParentalLockEnabled();
        public bool BIsParentalLockLocked();
        public bool BIsAppBlocked(AppId nAppID);
        public bool BIsAppInBlockList(AppId nAppID);
        public bool BIsFeatureBlocked(ParentalFeature eFeature);
        public bool BIsFeatureInBlockList(ParentalFeature eFeature);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamParentalSettings_BIsParentalLockEnabled", CallingConvention = Platform.CC)]
        internal static extern bool BIsParentalLockEnabled(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamParentalSettings_BIsParentalLockLocked", CallingConvention = Platform.CC)]
        internal static extern bool BIsParentalLockLocked(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamParentalSettings_BIsAppBlocked", CallingConvention = Platform.CC)]
        internal static extern bool BIsAppBlocked(void* self, AppId nAppID);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamParentalSettings_BIsAppInBlockList", CallingConvention = Platform.CC)]
        internal static extern bool BIsAppInBlockList(void* self, AppId nAppID);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamParentalSettings_BIsFeatureBlocked", CallingConvention = Platform.CC)]
        internal static extern bool BIsFeatureBlocked(void* self, ParentalFeature eFeature);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamParentalSettings_BIsFeatureInBlockList", CallingConvention = Platform.CC)]
        internal static extern bool BIsFeatureInBlockList(void* self, ParentalFeature eFeature);
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
        public struct Instance : ISteamParentalSettings
        {
            public void* self;
            public bool BIsParentalLockEnabled() => ISteamParentalSettings.BIsParentalLockEnabled(self);
            public bool BIsParentalLockLocked() => ISteamParentalSettings.BIsParentalLockLocked(self);
            public bool BIsAppBlocked(AppId nAppID) => ISteamParentalSettings.BIsAppBlocked(self, nAppID);
            public bool BIsAppInBlockList(AppId nAppID) => ISteamParentalSettings.BIsAppInBlockList(self, nAppID);
            public bool BIsFeatureBlocked(ParentalFeature eFeature) => ISteamParentalSettings.BIsFeatureBlocked(self, eFeature);
            public bool BIsFeatureInBlockList(ParentalFeature eFeature) => ISteamParentalSettings.BIsFeatureInBlockList(self, eFeature);
        }
    }
}