using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Functions that provide information about Steam Remote Play sessions, streaming your game content to another computer or to a Steam Link app or hardware.<br />
    /// <br />
    /// See <a href="https://partner.steamgames.com/doc/features/remoteplay" class="bb_doclink">Steam Remote Play</a> for more information.</summary>
    public unsafe interface ISteamRemotePlay
    {
        public uint GetSessionCount();
        public RemotePlaySessionID GetSessionID(int iSessionIndex);
        public SteamId GetSessionSteamID(RemotePlaySessionID unSessionID);
        public UTF8StringPtr GetSessionClientName(RemotePlaySessionID unSessionID);
        public SteamDeviceFormFactor GetSessionClientFormFactor(RemotePlaySessionID unSessionID);
        public bool BGetSessionClientResolution(RemotePlaySessionID unSessionID, int* pnResolutionX, int* pnResolutionY);
        public bool BStartRemotePlayTogether(bool bShowOverlay);
        public bool BSendRemotePlayTogetherInvite(SteamId steamIDFriend);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamRemotePlay_GetSessionCount", CallingConvention = Platform.CC)]
        internal static extern uint GetSessionCount(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamRemotePlay_GetSessionID", CallingConvention = Platform.CC)]
        internal static extern RemotePlaySessionID GetSessionID(void* self, int iSessionIndex);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamRemotePlay_GetSessionSteamID", CallingConvention = Platform.CC)]
        internal static extern SteamId GetSessionSteamID(void* self, RemotePlaySessionID unSessionID);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamRemotePlay_GetSessionClientName", CallingConvention = Platform.CC)]
        internal static extern UTF8StringPtr GetSessionClientName(void* self, RemotePlaySessionID unSessionID);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamRemotePlay_GetSessionClientFormFactor", CallingConvention = Platform.CC)]
        internal static extern SteamDeviceFormFactor GetSessionClientFormFactor(void* self, RemotePlaySessionID unSessionID);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamRemotePlay_BGetSessionClientResolution", CallingConvention = Platform.CC)]
        internal static extern bool BGetSessionClientResolution(void* self, RemotePlaySessionID unSessionID, int* pnResolutionX, int* pnResolutionY);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamRemotePlay_BStartRemotePlayTogether", CallingConvention = Platform.CC)]
        internal static extern bool BStartRemotePlayTogether(void* self, bool bShowOverlay);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamRemotePlay_BSendRemotePlayTogetherInvite", CallingConvention = Platform.CC)]
        internal static extern bool BSendRemotePlayTogetherInvite(void* self, SteamId steamIDFriend);
        public struct Instance : ISteamRemotePlay
        {
            public void* self;
            public uint GetSessionCount() => ISteamRemotePlay.GetSessionCount(self);
            public RemotePlaySessionID GetSessionID(int iSessionIndex) => ISteamRemotePlay.GetSessionID(self, iSessionIndex);
            public SteamId GetSessionSteamID(RemotePlaySessionID unSessionID) => ISteamRemotePlay.GetSessionSteamID(self, unSessionID);
            public UTF8StringPtr GetSessionClientName(RemotePlaySessionID unSessionID) => ISteamRemotePlay.GetSessionClientName(self, unSessionID);
            public SteamDeviceFormFactor GetSessionClientFormFactor(RemotePlaySessionID unSessionID) => ISteamRemotePlay.GetSessionClientFormFactor(self, unSessionID);
            public bool BGetSessionClientResolution(RemotePlaySessionID unSessionID, int* pnResolutionX, int* pnResolutionY) => ISteamRemotePlay.BGetSessionClientResolution(self, unSessionID, pnResolutionX, pnResolutionY);
            public bool BStartRemotePlayTogether(bool bShowOverlay) => ISteamRemotePlay.BStartRemotePlayTogether(self, bShowOverlay);
            public bool BSendRemotePlayTogetherInvite(SteamId steamIDFriend) => ISteamRemotePlay.BSendRemotePlayTogetherInvite(self, steamIDFriend);
        }
    }
}