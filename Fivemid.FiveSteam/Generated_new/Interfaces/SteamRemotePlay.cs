using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamRemotePlay
    {
        public static ISteamRemotePlay.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamRemotePlay_v002", CallingConvention = Platform.CC)]
        private static extern ISteamRemotePlay.Instance Accessor();
        /// <summary></summary>
        public static uint GetSessionCount() => Instance.GetSessionCount();
        /// <summary></summary>
        public static RemotePlaySessionID GetSessionID(int iSessionIndex) => Instance.GetSessionID(iSessionIndex);
        /// <summary></summary>
        public static SteamId GetSessionSteamID(RemotePlaySessionID unSessionID) => Instance.GetSessionSteamID(unSessionID);
        /// <summary></summary>
        public static UTF8StringPtr GetSessionClientName(RemotePlaySessionID unSessionID) => Instance.GetSessionClientName(unSessionID);
        /// <summary></summary>
        public static SteamDeviceFormFactor GetSessionClientFormFactor(RemotePlaySessionID unSessionID) => Instance.GetSessionClientFormFactor(unSessionID);
        /// <summary></summary>
        public static bool BGetSessionClientResolution(RemotePlaySessionID unSessionID, int* pnResolutionX, int* pnResolutionY) => Instance.BGetSessionClientResolution(unSessionID, pnResolutionX, pnResolutionY);
        /// <summary></summary>
        public static bool BStartRemotePlayTogether(bool bShowOverlay) => Instance.BStartRemotePlayTogether(bShowOverlay);
        /// <summary></summary>
        public static bool BSendRemotePlayTogetherInvite(SteamId steamIDFriend) => Instance.BSendRemotePlayTogetherInvite(steamIDFriend);
    }
}