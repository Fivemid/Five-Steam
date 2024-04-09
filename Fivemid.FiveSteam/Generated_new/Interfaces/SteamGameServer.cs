using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamGameServer
    {
        public static ISteamGameServer.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamGameServer_v015", CallingConvention = Platform.CC)]
        private static extern ISteamGameServer.Instance Accessor();
        /// <summary></summary>
        public static void SetProduct(UTF8StringPtr pszProduct) => Instance.SetProduct(pszProduct);
        /// <summary></summary>
        public static void SetGameDescription(UTF8StringPtr pszGameDescription) => Instance.SetGameDescription(pszGameDescription);
        /// <summary></summary>
        public static void SetModDir(UTF8StringPtr pszModDir) => Instance.SetModDir(pszModDir);
        /// <summary></summary>
        public static void SetDedicatedServer(bool bDedicated) => Instance.SetDedicatedServer(bDedicated);
        /// <summary></summary>
        public static void LogOn(UTF8StringPtr pszToken) => Instance.LogOn(pszToken);
        /// <summary></summary>
        public static void LogOnAnonymous() => Instance.LogOnAnonymous();
        /// <summary></summary>
        public static void LogOff() => Instance.LogOff();
        /// <summary></summary>
        public static bool BLoggedOn() => Instance.BLoggedOn();
        /// <summary></summary>
        public static bool BSecure() => Instance.BSecure();
        /// <summary></summary>
        public static SteamId GetSteamID() => Instance.GetSteamID();
        /// <summary></summary>
        public static bool WasRestartRequested() => Instance.WasRestartRequested();
        /// <summary></summary>
        public static void SetMaxPlayerCount(int cPlayersMax) => Instance.SetMaxPlayerCount(cPlayersMax);
        /// <summary></summary>
        public static void SetBotPlayerCount(int cBotplayers) => Instance.SetBotPlayerCount(cBotplayers);
        /// <summary></summary>
        public static void SetServerName(UTF8StringPtr pszServerName) => Instance.SetServerName(pszServerName);
        /// <summary></summary>
        public static void SetMapName(UTF8StringPtr pszMapName) => Instance.SetMapName(pszMapName);
        /// <summary></summary>
        public static void SetPasswordProtected(bool bPasswordProtected) => Instance.SetPasswordProtected(bPasswordProtected);
        /// <summary></summary>
        public static void SetSpectatorPort(ushort unSpectatorPort) => Instance.SetSpectatorPort(unSpectatorPort);
        /// <summary></summary>
        public static void SetSpectatorServerName(UTF8StringPtr pszSpectatorServerName) => Instance.SetSpectatorServerName(pszSpectatorServerName);
        /// <summary></summary>
        public static void ClearAllKeyValues() => Instance.ClearAllKeyValues();
        /// <summary></summary>
        public static void SetKeyValue(UTF8StringPtr pKey, UTF8StringPtr pValue) => Instance.SetKeyValue(pKey, pValue);
        /// <summary></summary>
        public static void SetGameTags(UTF8StringPtr pchGameTags) => Instance.SetGameTags(pchGameTags);
        /// <summary></summary>
        public static void SetGameData(UTF8StringPtr pchGameData) => Instance.SetGameData(pchGameData);
        /// <summary></summary>
        public static void SetRegion(UTF8StringPtr pszRegion) => Instance.SetRegion(pszRegion);
        /// <summary></summary>
        public static void SetAdvertiseServerActive(bool bActive) => Instance.SetAdvertiseServerActive(bActive);
        /// <summary></summary>
        public static HAuthTicket GetAuthSessionTicket(void* pTicket, int cbMaxTicket, uint* pcbTicket, SteamNetworkingIdentity* pSnid) => Instance.GetAuthSessionTicket(pTicket, cbMaxTicket, pcbTicket, pSnid);
        /// <summary></summary>
        public static BeginAuthSessionResult BeginAuthSession(void* pAuthTicket, int cbAuthTicket, SteamId steamID) => Instance.BeginAuthSession(pAuthTicket, cbAuthTicket, steamID);
        /// <summary></summary>
        public static void EndAuthSession(SteamId steamID) => Instance.EndAuthSession(steamID);
        /// <summary></summary>
        public static void CancelAuthTicket(HAuthTicket hAuthTicket) => Instance.CancelAuthTicket(hAuthTicket);
        /// <summary></summary>
        public static UserHasLicenseForAppResult UserHasLicenseForApp(SteamId steamID, AppId appID) => Instance.UserHasLicenseForApp(steamID, appID);
        /// <summary></summary>
        public static bool RequestUserGroupStatus(SteamId steamIDUser, SteamId steamIDGroup) => Instance.RequestUserGroupStatus(steamIDUser, steamIDGroup);
        /// <summary></summary>
        public static void GetGameplayStats() => Instance.GetGameplayStats();
        /// <summary></summary>
        public static SteamAPICall GetServerReputation() => Instance.GetServerReputation();
        /// <summary></summary>
        public static SteamIPAddress GetPublicIP() => Instance.GetPublicIP();
        /// <summary></summary>
        public static bool HandleIncomingPacket(void* pData, int cbData, uint srcIP, ushort srcPort) => Instance.HandleIncomingPacket(pData, cbData, srcIP, srcPort);
        /// <summary></summary>
        public static int GetNextOutgoingPacket(void* pOut, int cbMaxOut, uint* pNetAdr, ushort* pPort) => Instance.GetNextOutgoingPacket(pOut, cbMaxOut, pNetAdr, pPort);
        /// <summary></summary>
        public static SteamAPICall AssociateWithClan(SteamId steamIDClan) => Instance.AssociateWithClan(steamIDClan);
        /// <summary></summary>
        public static SteamAPICall ComputeNewPlayerCompatibility(SteamId steamIDNewPlayer) => Instance.ComputeNewPlayerCompatibility(steamIDNewPlayer);
        /// <summary></summary>
        public static bool SendUserConnectAndAuthenticate_DEPRECATED(uint unIPClient, void* pvAuthBlob, uint cubAuthBlobSize, SteamId* pSteamIDUser) => Instance.SendUserConnectAndAuthenticate_DEPRECATED(unIPClient, pvAuthBlob, cubAuthBlobSize, pSteamIDUser);
        /// <summary></summary>
        public static SteamId CreateUnauthenticatedUserConnection() => Instance.CreateUnauthenticatedUserConnection();
        /// <summary></summary>
        public static void SendUserDisconnect_DEPRECATED(SteamId steamIDUser) => Instance.SendUserDisconnect_DEPRECATED(steamIDUser);
        /// <summary></summary>
        public static bool BUpdateUserData(SteamId steamIDUser, UTF8StringPtr pchPlayerName, uint uScore) => Instance.BUpdateUserData(steamIDUser, pchPlayerName, uScore);
    }
}