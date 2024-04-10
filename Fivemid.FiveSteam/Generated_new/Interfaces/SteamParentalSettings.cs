using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamParentalSettings
    {
        public static ISteamParentalSettings.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamParentalSettings_v001", CallingConvention = Platform.CC)]
        private static extern ISteamParentalSettings.Instance Accessor();
        /// missing documentation
        public static bool BIsParentalLockEnabled() => Instance.BIsParentalLockEnabled();
        /// missing documentation
        public static bool BIsParentalLockLocked() => Instance.BIsParentalLockLocked();
        /// missing documentation
        public static bool BIsAppBlocked(AppId nAppID) => Instance.BIsAppBlocked(nAppID);
        /// missing documentation
        public static bool BIsAppInBlockList(AppId nAppID) => Instance.BIsAppInBlockList(nAppID);
        /// missing documentation
        public static bool BIsFeatureBlocked(ParentalFeature eFeature) => Instance.BIsFeatureBlocked(eFeature);
        /// missing documentation
        public static bool BIsFeatureInBlockList(ParentalFeature eFeature) => Instance.BIsFeatureInBlockList(eFeature);
    }
}