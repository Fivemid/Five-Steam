using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamParentalSettings
    {
        public static ISteamParentalSettings.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamParentalSettings_v001", CallingConvention = Platform.CC)]
        private static extern ISteamParentalSettings.Instance Accessor();
        /// <summary></summary>
        public static bool BIsParentalLockEnabled() => Instance.BIsParentalLockEnabled();
        /// <summary></summary>
        public static bool BIsParentalLockLocked() => Instance.BIsParentalLockLocked();
        /// <summary></summary>
        public static bool BIsAppBlocked(AppId nAppID) => Instance.BIsAppBlocked(nAppID);
        /// <summary></summary>
        public static bool BIsAppInBlockList(AppId nAppID) => Instance.BIsAppInBlockList(nAppID);
        /// <summary></summary>
        public static bool BIsFeatureBlocked(ParentalFeature eFeature) => Instance.BIsFeatureBlocked(eFeature);
        /// <summary></summary>
        public static bool BIsFeatureInBlockList(ParentalFeature eFeature) => Instance.BIsFeatureInBlockList(eFeature);
    }
}