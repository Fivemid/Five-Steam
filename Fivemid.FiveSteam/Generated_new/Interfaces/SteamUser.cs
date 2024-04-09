using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamUser
    {
        public static ISteamUser.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamUser_v023", CallingConvention = Platform.CC)]
        private static extern ISteamUser.Instance Accessor();
        /// <summary></summary>
        public static HSteamUser GetHSteamUser() => Instance.GetHSteamUser();
        /// <summary></summary>
        public static bool BLoggedOn() => Instance.BLoggedOn();
        /// <summary></summary>
        public static SteamId GetSteamID() => Instance.GetSteamID();
        /// <summary></summary>
        public static int InitiateGameConnection_DEPRECATED(void* pAuthBlob, int cbMaxAuthBlob, SteamId steamIDGameServer, uint unIPServer, ushort usPortServer, bool bSecure) => Instance.InitiateGameConnection_DEPRECATED(pAuthBlob, cbMaxAuthBlob, steamIDGameServer, unIPServer, usPortServer, bSecure);
        /// <summary></summary>
        public static void TerminateGameConnection_DEPRECATED(uint unIPServer, ushort usPortServer) => Instance.TerminateGameConnection_DEPRECATED(unIPServer, usPortServer);
        /// <summary></summary>
        public static void TrackAppUsageEvent(GameId gameID, int eAppUsageEvent, UTF8StringPtr pchExtraInfo) => Instance.TrackAppUsageEvent(gameID, eAppUsageEvent, pchExtraInfo);
        /// <summary></summary>
        public static bool GetUserDataFolder(char* pchBuffer, int cubBuffer) => Instance.GetUserDataFolder(pchBuffer, cubBuffer);
        /// <summary></summary>
        public static void StartVoiceRecording() => Instance.StartVoiceRecording();
        /// <summary></summary>
        public static void StopVoiceRecording() => Instance.StopVoiceRecording();
        /// <summary></summary>
        public static VoiceResult GetAvailableVoice(uint* pcbCompressed, uint* pcbUncompressed_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) => Instance.GetAvailableVoice(pcbCompressed, pcbUncompressed_Deprecated, nUncompressedVoiceDesiredSampleRate_Deprecated);
        /// <summary></summary>
        public static VoiceResult GetVoice(bool bWantCompressed, void* pDestBuffer, uint cbDestBufferSize, uint* nBytesWritten, bool bWantUncompressed_Deprecated, void* pUncompressedDestBuffer_Deprecated, uint cbUncompressedDestBufferSize_Deprecated, uint* nUncompressBytesWritten_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) => Instance.GetVoice(bWantCompressed, pDestBuffer, cbDestBufferSize, nBytesWritten, bWantUncompressed_Deprecated, pUncompressedDestBuffer_Deprecated, cbUncompressedDestBufferSize_Deprecated, nUncompressBytesWritten_Deprecated, nUncompressedVoiceDesiredSampleRate_Deprecated);
        /// <summary></summary>
        public static VoiceResult DecompressVoice(void* pCompressed, uint cbCompressed, void* pDestBuffer, uint cbDestBufferSize, uint* nBytesWritten, uint nDesiredSampleRate) => Instance.DecompressVoice(pCompressed, cbCompressed, pDestBuffer, cbDestBufferSize, nBytesWritten, nDesiredSampleRate);
        /// <summary></summary>
        public static uint GetVoiceOptimalSampleRate() => Instance.GetVoiceOptimalSampleRate();
        /// <summary></summary>
        public static HAuthTicket GetAuthSessionTicket(void* pTicket, int cbMaxTicket, uint* pcbTicket, SteamNetworkingIdentity* pSteamNetworkingIdentity) => Instance.GetAuthSessionTicket(pTicket, cbMaxTicket, pcbTicket, pSteamNetworkingIdentity);
        /// <summary></summary>
        public static HAuthTicket GetAuthTicketForWebApi(UTF8StringPtr pchIdentity) => Instance.GetAuthTicketForWebApi(pchIdentity);
        /// <summary></summary>
        public static BeginAuthSessionResult BeginAuthSession(void* pAuthTicket, int cbAuthTicket, SteamId steamID) => Instance.BeginAuthSession(pAuthTicket, cbAuthTicket, steamID);
        /// <summary></summary>
        public static void EndAuthSession(SteamId steamID) => Instance.EndAuthSession(steamID);
        /// <summary></summary>
        public static void CancelAuthTicket(HAuthTicket hAuthTicket) => Instance.CancelAuthTicket(hAuthTicket);
        /// <summary></summary>
        public static UserHasLicenseForAppResult UserHasLicenseForApp(SteamId steamID, AppId appID) => Instance.UserHasLicenseForApp(steamID, appID);
        /// <summary></summary>
        public static bool BIsBehindNAT() => Instance.BIsBehindNAT();
        /// <summary></summary>
        public static void AdvertiseGame(SteamId steamIDGameServer, uint unIPServer, ushort usPortServer) => Instance.AdvertiseGame(steamIDGameServer, unIPServer, usPortServer);
        /// <summary></summary>
        public static SteamAPICall RequestEncryptedAppTicket(void* pDataToInclude, int cbDataToInclude) => Instance.RequestEncryptedAppTicket(pDataToInclude, cbDataToInclude);
        /// <summary></summary>
        public static bool GetEncryptedAppTicket(void* pTicket, int cbMaxTicket, uint* pcbTicket) => Instance.GetEncryptedAppTicket(pTicket, cbMaxTicket, pcbTicket);
        /// <summary></summary>
        public static int GetGameBadgeLevel(int nSeries, bool bFoil) => Instance.GetGameBadgeLevel(nSeries, bFoil);
        /// <summary></summary>
        public static int GetPlayerSteamLevel() => Instance.GetPlayerSteamLevel();
        /// <summary></summary>
        public static SteamAPICall RequestStoreAuthURL(UTF8StringPtr pchRedirectURL) => Instance.RequestStoreAuthURL(pchRedirectURL);
        /// <summary></summary>
        public static bool BIsPhoneVerified() => Instance.BIsPhoneVerified();
        /// <summary></summary>
        public static bool BIsTwoFactorEnabled() => Instance.BIsTwoFactorEnabled();
        /// <summary></summary>
        public static bool BIsPhoneIdentifying() => Instance.BIsPhoneIdentifying();
        /// <summary></summary>
        public static bool BIsPhoneRequiringVerification() => Instance.BIsPhoneRequiringVerification();
        /// <summary></summary>
        public static SteamAPICall GetMarketEligibility() => Instance.GetMarketEligibility();
        /// <summary></summary>
        public static SteamAPICall GetDurationControl() => Instance.GetDurationControl();
        /// <summary></summary>
        public static bool BSetDurationControlOnlineState(DurationControlOnlineState eNewState) => Instance.BSetDurationControlOnlineState(eNewState);
    }
}