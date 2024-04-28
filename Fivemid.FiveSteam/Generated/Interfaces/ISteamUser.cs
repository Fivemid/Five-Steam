using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Functions for accessing and manipulating Steam user information.<br />
    /// <br />
    /// This is also where the APIs for <a href="https://partner.steamgames.com/doc/features/voice" class="bb_doclink">Steam Voice</a> are exposed.</summary>
    public unsafe interface ISteamUser
    {
        public HSteamUser GetHSteamUser();
        public bool BLoggedOn();
        public SteamId GetSteamID();
        public int InitiateGameConnection_DEPRECATED(void* pAuthBlob, int cbMaxAuthBlob, SteamId steamIDGameServer, uint unIPServer, ushort usPortServer, bool bSecure);
        public void TerminateGameConnection_DEPRECATED(uint unIPServer, ushort usPortServer);
        public void TrackAppUsageEvent(GameId gameID, int eAppUsageEvent, UTF8StringPtr pchExtraInfo);
        public bool GetUserDataFolder(byte* pchBuffer, int cubBuffer);
        public void StartVoiceRecording();
        public void StopVoiceRecording();
        public VoiceResult GetAvailableVoice(uint* pcbCompressed, uint* pcbUncompressed_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated);
        public VoiceResult GetVoice(bool bWantCompressed, void* pDestBuffer, uint cbDestBufferSize, uint* nBytesWritten, bool bWantUncompressed_Deprecated, void* pUncompressedDestBuffer_Deprecated, uint cbUncompressedDestBufferSize_Deprecated, uint* nUncompressBytesWritten_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated);
        public VoiceResult DecompressVoice(void* pCompressed, uint cbCompressed, void* pDestBuffer, uint cbDestBufferSize, uint* nBytesWritten, uint nDesiredSampleRate);
        public uint GetVoiceOptimalSampleRate();
        public HAuthTicket GetAuthSessionTicket(void* pTicket, int cbMaxTicket, uint* pcbTicket, SteamNetworkingIdentity* pSteamNetworkingIdentity);
        public HAuthTicket GetAuthTicketForWebApi(UTF8StringPtr pchIdentity);
        public BeginAuthSessionResult BeginAuthSession(void* pAuthTicket, int cbAuthTicket, SteamId steamID);
        public void EndAuthSession(SteamId steamID);
        public void CancelAuthTicket(HAuthTicket hAuthTicket);
        public UserHasLicenseForAppResult UserHasLicenseForApp(SteamId steamID, AppId appID);
        public bool BIsBehindNAT();
        public void AdvertiseGame(SteamId steamIDGameServer, uint unIPServer, ushort usPortServer);
        public SteamAPICall RequestEncryptedAppTicket(void* pDataToInclude, int cbDataToInclude);
        public bool GetEncryptedAppTicket(void* pTicket, int cbMaxTicket, uint* pcbTicket);
        public int GetGameBadgeLevel(int nSeries, bool bFoil);
        public int GetPlayerSteamLevel();
        public SteamAPICall RequestStoreAuthURL(UTF8StringPtr pchRedirectURL);
        public bool BIsPhoneVerified();
        public bool BIsTwoFactorEnabled();
        public bool BIsPhoneIdentifying();
        public bool BIsPhoneRequiringVerification();
        public SteamAPICall GetMarketEligibility();
        public SteamAPICall GetDurationControl();
        public bool BSetDurationControlOnlineState(DurationControlOnlineState eNewState);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUser_GetHSteamUser", CallingConvention = Platform.CC)]
        internal static extern HSteamUser GetHSteamUser(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUser_BLoggedOn", CallingConvention = Platform.CC)]
        internal static extern bool BLoggedOn(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUser_GetSteamID", CallingConvention = Platform.CC)]
        internal static extern SteamId GetSteamID(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUser_InitiateGameConnection_DEPRECATED", CallingConvention = Platform.CC)]
        internal static extern int InitiateGameConnection_DEPRECATED(void* self, void* pAuthBlob, int cbMaxAuthBlob, SteamId steamIDGameServer, uint unIPServer, ushort usPortServer, bool bSecure);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUser_TerminateGameConnection_DEPRECATED", CallingConvention = Platform.CC)]
        internal static extern void TerminateGameConnection_DEPRECATED(void* self, uint unIPServer, ushort usPortServer);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUser_TrackAppUsageEvent", CallingConvention = Platform.CC)]
        internal static extern void TrackAppUsageEvent(void* self, GameId gameID, int eAppUsageEvent, UTF8StringPtr pchExtraInfo);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUser_GetUserDataFolder", CallingConvention = Platform.CC)]
        internal static extern bool GetUserDataFolder(void* self, byte* pchBuffer, int cubBuffer);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUser_StartVoiceRecording", CallingConvention = Platform.CC)]
        internal static extern void StartVoiceRecording(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUser_StopVoiceRecording", CallingConvention = Platform.CC)]
        internal static extern void StopVoiceRecording(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUser_GetAvailableVoice", CallingConvention = Platform.CC)]
        internal static extern VoiceResult GetAvailableVoice(void* self, uint* pcbCompressed, uint* pcbUncompressed_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUser_GetVoice", CallingConvention = Platform.CC)]
        internal static extern VoiceResult GetVoice(void* self, bool bWantCompressed, void* pDestBuffer, uint cbDestBufferSize, uint* nBytesWritten, bool bWantUncompressed_Deprecated, void* pUncompressedDestBuffer_Deprecated, uint cbUncompressedDestBufferSize_Deprecated, uint* nUncompressBytesWritten_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUser_DecompressVoice", CallingConvention = Platform.CC)]
        internal static extern VoiceResult DecompressVoice(void* self, void* pCompressed, uint cbCompressed, void* pDestBuffer, uint cbDestBufferSize, uint* nBytesWritten, uint nDesiredSampleRate);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUser_GetVoiceOptimalSampleRate", CallingConvention = Platform.CC)]
        internal static extern uint GetVoiceOptimalSampleRate(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUser_GetAuthSessionTicket", CallingConvention = Platform.CC)]
        internal static extern HAuthTicket GetAuthSessionTicket(void* self, void* pTicket, int cbMaxTicket, uint* pcbTicket, SteamNetworkingIdentity* pSteamNetworkingIdentity);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUser_GetAuthTicketForWebApi", CallingConvention = Platform.CC)]
        internal static extern HAuthTicket GetAuthTicketForWebApi(void* self, UTF8StringPtr pchIdentity);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUser_BeginAuthSession", CallingConvention = Platform.CC)]
        internal static extern BeginAuthSessionResult BeginAuthSession(void* self, void* pAuthTicket, int cbAuthTicket, SteamId steamID);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUser_EndAuthSession", CallingConvention = Platform.CC)]
        internal static extern void EndAuthSession(void* self, SteamId steamID);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUser_CancelAuthTicket", CallingConvention = Platform.CC)]
        internal static extern void CancelAuthTicket(void* self, HAuthTicket hAuthTicket);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUser_UserHasLicenseForApp", CallingConvention = Platform.CC)]
        internal static extern UserHasLicenseForAppResult UserHasLicenseForApp(void* self, SteamId steamID, AppId appID);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUser_BIsBehindNAT", CallingConvention = Platform.CC)]
        internal static extern bool BIsBehindNAT(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUser_AdvertiseGame", CallingConvention = Platform.CC)]
        internal static extern void AdvertiseGame(void* self, SteamId steamIDGameServer, uint unIPServer, ushort usPortServer);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUser_RequestEncryptedAppTicket", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall RequestEncryptedAppTicket(void* self, void* pDataToInclude, int cbDataToInclude);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUser_GetEncryptedAppTicket", CallingConvention = Platform.CC)]
        internal static extern bool GetEncryptedAppTicket(void* self, void* pTicket, int cbMaxTicket, uint* pcbTicket);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUser_GetGameBadgeLevel", CallingConvention = Platform.CC)]
        internal static extern int GetGameBadgeLevel(void* self, int nSeries, bool bFoil);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUser_GetPlayerSteamLevel", CallingConvention = Platform.CC)]
        internal static extern int GetPlayerSteamLevel(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUser_RequestStoreAuthURL", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall RequestStoreAuthURL(void* self, UTF8StringPtr pchRedirectURL);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUser_BIsPhoneVerified", CallingConvention = Platform.CC)]
        internal static extern bool BIsPhoneVerified(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUser_BIsTwoFactorEnabled", CallingConvention = Platform.CC)]
        internal static extern bool BIsTwoFactorEnabled(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUser_BIsPhoneIdentifying", CallingConvention = Platform.CC)]
        internal static extern bool BIsPhoneIdentifying(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUser_BIsPhoneRequiringVerification", CallingConvention = Platform.CC)]
        internal static extern bool BIsPhoneRequiringVerification(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUser_GetMarketEligibility", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall GetMarketEligibility(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUser_GetDurationControl", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall GetDurationControl(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUser_BSetDurationControlOnlineState", CallingConvention = Platform.CC)]
        internal static extern bool BSetDurationControlOnlineState(void* self, DurationControlOnlineState eNewState);
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
        public struct Instance : ISteamUser
        {
            public void* self;
            public HSteamUser GetHSteamUser() => ISteamUser.GetHSteamUser(self);
            public bool BLoggedOn() => ISteamUser.BLoggedOn(self);
            public SteamId GetSteamID() => ISteamUser.GetSteamID(self);
            public int InitiateGameConnection_DEPRECATED(void* pAuthBlob, int cbMaxAuthBlob, SteamId steamIDGameServer, uint unIPServer, ushort usPortServer, bool bSecure) => ISteamUser.InitiateGameConnection_DEPRECATED(self, pAuthBlob, cbMaxAuthBlob, steamIDGameServer, unIPServer, usPortServer, bSecure);
            public void TerminateGameConnection_DEPRECATED(uint unIPServer, ushort usPortServer) => ISteamUser.TerminateGameConnection_DEPRECATED(self, unIPServer, usPortServer);
            public void TrackAppUsageEvent(GameId gameID, int eAppUsageEvent, UTF8StringPtr pchExtraInfo) => ISteamUser.TrackAppUsageEvent(self, gameID, eAppUsageEvent, pchExtraInfo);
            public bool GetUserDataFolder(byte* pchBuffer, int cubBuffer) => ISteamUser.GetUserDataFolder(self, pchBuffer, cubBuffer);
            public void StartVoiceRecording() => ISteamUser.StartVoiceRecording(self);
            public void StopVoiceRecording() => ISteamUser.StopVoiceRecording(self);
            public VoiceResult GetAvailableVoice(uint* pcbCompressed, uint* pcbUncompressed_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) => ISteamUser.GetAvailableVoice(self, pcbCompressed, pcbUncompressed_Deprecated, nUncompressedVoiceDesiredSampleRate_Deprecated);
            public VoiceResult GetVoice(bool bWantCompressed, void* pDestBuffer, uint cbDestBufferSize, uint* nBytesWritten, bool bWantUncompressed_Deprecated, void* pUncompressedDestBuffer_Deprecated, uint cbUncompressedDestBufferSize_Deprecated, uint* nUncompressBytesWritten_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) => ISteamUser.GetVoice(self, bWantCompressed, pDestBuffer, cbDestBufferSize, nBytesWritten, bWantUncompressed_Deprecated, pUncompressedDestBuffer_Deprecated, cbUncompressedDestBufferSize_Deprecated, nUncompressBytesWritten_Deprecated, nUncompressedVoiceDesiredSampleRate_Deprecated);
            public VoiceResult DecompressVoice(void* pCompressed, uint cbCompressed, void* pDestBuffer, uint cbDestBufferSize, uint* nBytesWritten, uint nDesiredSampleRate) => ISteamUser.DecompressVoice(self, pCompressed, cbCompressed, pDestBuffer, cbDestBufferSize, nBytesWritten, nDesiredSampleRate);
            public uint GetVoiceOptimalSampleRate() => ISteamUser.GetVoiceOptimalSampleRate(self);
            public HAuthTicket GetAuthSessionTicket(void* pTicket, int cbMaxTicket, uint* pcbTicket, SteamNetworkingIdentity* pSteamNetworkingIdentity) => ISteamUser.GetAuthSessionTicket(self, pTicket, cbMaxTicket, pcbTicket, pSteamNetworkingIdentity);
            public HAuthTicket GetAuthTicketForWebApi(UTF8StringPtr pchIdentity) => ISteamUser.GetAuthTicketForWebApi(self, pchIdentity);
            public BeginAuthSessionResult BeginAuthSession(void* pAuthTicket, int cbAuthTicket, SteamId steamID) => ISteamUser.BeginAuthSession(self, pAuthTicket, cbAuthTicket, steamID);
            public void EndAuthSession(SteamId steamID) => ISteamUser.EndAuthSession(self, steamID);
            public void CancelAuthTicket(HAuthTicket hAuthTicket) => ISteamUser.CancelAuthTicket(self, hAuthTicket);
            public UserHasLicenseForAppResult UserHasLicenseForApp(SteamId steamID, AppId appID) => ISteamUser.UserHasLicenseForApp(self, steamID, appID);
            public bool BIsBehindNAT() => ISteamUser.BIsBehindNAT(self);
            public void AdvertiseGame(SteamId steamIDGameServer, uint unIPServer, ushort usPortServer) => ISteamUser.AdvertiseGame(self, steamIDGameServer, unIPServer, usPortServer);
            public SteamAPICall RequestEncryptedAppTicket(void* pDataToInclude, int cbDataToInclude) => ISteamUser.RequestEncryptedAppTicket(self, pDataToInclude, cbDataToInclude);
            public bool GetEncryptedAppTicket(void* pTicket, int cbMaxTicket, uint* pcbTicket) => ISteamUser.GetEncryptedAppTicket(self, pTicket, cbMaxTicket, pcbTicket);
            public int GetGameBadgeLevel(int nSeries, bool bFoil) => ISteamUser.GetGameBadgeLevel(self, nSeries, bFoil);
            public int GetPlayerSteamLevel() => ISteamUser.GetPlayerSteamLevel(self);
            public SteamAPICall RequestStoreAuthURL(UTF8StringPtr pchRedirectURL) => ISteamUser.RequestStoreAuthURL(self, pchRedirectURL);
            public bool BIsPhoneVerified() => ISteamUser.BIsPhoneVerified(self);
            public bool BIsTwoFactorEnabled() => ISteamUser.BIsTwoFactorEnabled(self);
            public bool BIsPhoneIdentifying() => ISteamUser.BIsPhoneIdentifying(self);
            public bool BIsPhoneRequiringVerification() => ISteamUser.BIsPhoneRequiringVerification(self);
            public SteamAPICall GetMarketEligibility() => ISteamUser.GetMarketEligibility(self);
            public SteamAPICall GetDurationControl() => ISteamUser.GetDurationControl(self);
            public bool BSetDurationControlOnlineState(DurationControlOnlineState eNewState) => ISteamUser.BSetDurationControlOnlineState(self, eNewState);
        }
    }
}