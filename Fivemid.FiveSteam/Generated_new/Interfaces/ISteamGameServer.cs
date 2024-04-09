using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ISteamGameServer</summary>
    public unsafe interface ISteamGameServer
    {
        public void SetProduct(UTF8StringPtr pszProduct);
        public void SetGameDescription(UTF8StringPtr pszGameDescription);
        public void SetModDir(UTF8StringPtr pszModDir);
        public void SetDedicatedServer(bool bDedicated);
        public void LogOn(UTF8StringPtr pszToken);
        public void LogOnAnonymous();
        public void LogOff();
        public bool BLoggedOn();
        public bool BSecure();
        public SteamId GetSteamID();
        public bool WasRestartRequested();
        public void SetMaxPlayerCount(int cPlayersMax);
        public void SetBotPlayerCount(int cBotplayers);
        public void SetServerName(UTF8StringPtr pszServerName);
        public void SetMapName(UTF8StringPtr pszMapName);
        public void SetPasswordProtected(bool bPasswordProtected);
        public void SetSpectatorPort(ushort unSpectatorPort);
        public void SetSpectatorServerName(UTF8StringPtr pszSpectatorServerName);
        public void ClearAllKeyValues();
        public void SetKeyValue(UTF8StringPtr pKey, UTF8StringPtr pValue);
        public void SetGameTags(UTF8StringPtr pchGameTags);
        public void SetGameData(UTF8StringPtr pchGameData);
        public void SetRegion(UTF8StringPtr pszRegion);
        public void SetAdvertiseServerActive(bool bActive);
        public HAuthTicket GetAuthSessionTicket(void* pTicket, int cbMaxTicket, uint* pcbTicket, SteamNetworkingIdentity* pSnid);
        public BeginAuthSessionResult BeginAuthSession(void* pAuthTicket, int cbAuthTicket, SteamId steamID);
        public void EndAuthSession(SteamId steamID);
        public void CancelAuthTicket(HAuthTicket hAuthTicket);
        public UserHasLicenseForAppResult UserHasLicenseForApp(SteamId steamID, AppId appID);
        public bool RequestUserGroupStatus(SteamId steamIDUser, SteamId steamIDGroup);
        public void GetGameplayStats();
        public SteamAPICall GetServerReputation();
        public SteamIPAddress GetPublicIP();
        public bool HandleIncomingPacket(void* pData, int cbData, uint srcIP, ushort srcPort);
        public int GetNextOutgoingPacket(void* pOut, int cbMaxOut, uint* pNetAdr, ushort* pPort);
        public SteamAPICall AssociateWithClan(SteamId steamIDClan);
        public SteamAPICall ComputeNewPlayerCompatibility(SteamId steamIDNewPlayer);
        public bool SendUserConnectAndAuthenticate_DEPRECATED(uint unIPClient, void* pvAuthBlob, uint cubAuthBlobSize, SteamId* pSteamIDUser);
        public SteamId CreateUnauthenticatedUserConnection();
        public void SendUserDisconnect_DEPRECATED(SteamId steamIDUser);
        public bool BUpdateUserData(SteamId steamIDUser, UTF8StringPtr pchPlayerName, uint uScore);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServer_SetProduct", CallingConvention = Platform.CC)]
        internal static extern void SetProduct(void* self, UTF8StringPtr pszProduct);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServer_SetGameDescription", CallingConvention = Platform.CC)]
        internal static extern void SetGameDescription(void* self, UTF8StringPtr pszGameDescription);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServer_SetModDir", CallingConvention = Platform.CC)]
        internal static extern void SetModDir(void* self, UTF8StringPtr pszModDir);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServer_SetDedicatedServer", CallingConvention = Platform.CC)]
        internal static extern void SetDedicatedServer(void* self, bool bDedicated);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServer_LogOn", CallingConvention = Platform.CC)]
        internal static extern void LogOn(void* self, UTF8StringPtr pszToken);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServer_LogOnAnonymous", CallingConvention = Platform.CC)]
        internal static extern void LogOnAnonymous(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServer_LogOff", CallingConvention = Platform.CC)]
        internal static extern void LogOff(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServer_BLoggedOn", CallingConvention = Platform.CC)]
        internal static extern bool BLoggedOn(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServer_BSecure", CallingConvention = Platform.CC)]
        internal static extern bool BSecure(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServer_GetSteamID", CallingConvention = Platform.CC)]
        internal static extern SteamId GetSteamID(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServer_WasRestartRequested", CallingConvention = Platform.CC)]
        internal static extern bool WasRestartRequested(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServer_SetMaxPlayerCount", CallingConvention = Platform.CC)]
        internal static extern void SetMaxPlayerCount(void* self, int cPlayersMax);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServer_SetBotPlayerCount", CallingConvention = Platform.CC)]
        internal static extern void SetBotPlayerCount(void* self, int cBotplayers);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServer_SetServerName", CallingConvention = Platform.CC)]
        internal static extern void SetServerName(void* self, UTF8StringPtr pszServerName);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServer_SetMapName", CallingConvention = Platform.CC)]
        internal static extern void SetMapName(void* self, UTF8StringPtr pszMapName);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServer_SetPasswordProtected", CallingConvention = Platform.CC)]
        internal static extern void SetPasswordProtected(void* self, bool bPasswordProtected);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServer_SetSpectatorPort", CallingConvention = Platform.CC)]
        internal static extern void SetSpectatorPort(void* self, ushort unSpectatorPort);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServer_SetSpectatorServerName", CallingConvention = Platform.CC)]
        internal static extern void SetSpectatorServerName(void* self, UTF8StringPtr pszSpectatorServerName);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServer_ClearAllKeyValues", CallingConvention = Platform.CC)]
        internal static extern void ClearAllKeyValues(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServer_SetKeyValue", CallingConvention = Platform.CC)]
        internal static extern void SetKeyValue(void* self, UTF8StringPtr pKey, UTF8StringPtr pValue);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServer_SetGameTags", CallingConvention = Platform.CC)]
        internal static extern void SetGameTags(void* self, UTF8StringPtr pchGameTags);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServer_SetGameData", CallingConvention = Platform.CC)]
        internal static extern void SetGameData(void* self, UTF8StringPtr pchGameData);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServer_SetRegion", CallingConvention = Platform.CC)]
        internal static extern void SetRegion(void* self, UTF8StringPtr pszRegion);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServer_SetAdvertiseServerActive", CallingConvention = Platform.CC)]
        internal static extern void SetAdvertiseServerActive(void* self, bool bActive);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServer_GetAuthSessionTicket", CallingConvention = Platform.CC)]
        internal static extern HAuthTicket GetAuthSessionTicket(void* self, void* pTicket, int cbMaxTicket, uint* pcbTicket, SteamNetworkingIdentity* pSnid);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServer_BeginAuthSession", CallingConvention = Platform.CC)]
        internal static extern BeginAuthSessionResult BeginAuthSession(void* self, void* pAuthTicket, int cbAuthTicket, SteamId steamID);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServer_EndAuthSession", CallingConvention = Platform.CC)]
        internal static extern void EndAuthSession(void* self, SteamId steamID);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServer_CancelAuthTicket", CallingConvention = Platform.CC)]
        internal static extern void CancelAuthTicket(void* self, HAuthTicket hAuthTicket);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServer_UserHasLicenseForApp", CallingConvention = Platform.CC)]
        internal static extern UserHasLicenseForAppResult UserHasLicenseForApp(void* self, SteamId steamID, AppId appID);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServer_RequestUserGroupStatus", CallingConvention = Platform.CC)]
        internal static extern bool RequestUserGroupStatus(void* self, SteamId steamIDUser, SteamId steamIDGroup);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServer_GetGameplayStats", CallingConvention = Platform.CC)]
        internal static extern void GetGameplayStats(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServer_GetServerReputation", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall GetServerReputation(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServer_GetPublicIP", CallingConvention = Platform.CC)]
        internal static extern SteamIPAddress GetPublicIP(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServer_HandleIncomingPacket", CallingConvention = Platform.CC)]
        internal static extern bool HandleIncomingPacket(void* self, void* pData, int cbData, uint srcIP, ushort srcPort);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServer_GetNextOutgoingPacket", CallingConvention = Platform.CC)]
        internal static extern int GetNextOutgoingPacket(void* self, void* pOut, int cbMaxOut, uint* pNetAdr, ushort* pPort);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServer_AssociateWithClan", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall AssociateWithClan(void* self, SteamId steamIDClan);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServer_ComputeNewPlayerCompatibility", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall ComputeNewPlayerCompatibility(void* self, SteamId steamIDNewPlayer);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServer_SendUserConnectAndAuthenticate_DEPRECATED", CallingConvention = Platform.CC)]
        internal static extern bool SendUserConnectAndAuthenticate_DEPRECATED(void* self, uint unIPClient, void* pvAuthBlob, uint cubAuthBlobSize, SteamId* pSteamIDUser);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServer_CreateUnauthenticatedUserConnection", CallingConvention = Platform.CC)]
        internal static extern SteamId CreateUnauthenticatedUserConnection(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServer_SendUserDisconnect_DEPRECATED", CallingConvention = Platform.CC)]
        internal static extern void SendUserDisconnect_DEPRECATED(void* self, SteamId steamIDUser);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameServer_BUpdateUserData", CallingConvention = Platform.CC)]
        internal static extern bool BUpdateUserData(void* self, SteamId steamIDUser, UTF8StringPtr pchPlayerName, uint uScore);
        public struct Instance : ISteamGameServer
        {
            public void* self;
            public void SetProduct(UTF8StringPtr pszProduct) => ISteamGameServer.SetProduct(self, pszProduct);
            public void SetGameDescription(UTF8StringPtr pszGameDescription) => ISteamGameServer.SetGameDescription(self, pszGameDescription);
            public void SetModDir(UTF8StringPtr pszModDir) => ISteamGameServer.SetModDir(self, pszModDir);
            public void SetDedicatedServer(bool bDedicated) => ISteamGameServer.SetDedicatedServer(self, bDedicated);
            public void LogOn(UTF8StringPtr pszToken) => ISteamGameServer.LogOn(self, pszToken);
            public void LogOnAnonymous() => ISteamGameServer.LogOnAnonymous(self);
            public void LogOff() => ISteamGameServer.LogOff(self);
            public bool BLoggedOn() => ISteamGameServer.BLoggedOn(self);
            public bool BSecure() => ISteamGameServer.BSecure(self);
            public SteamId GetSteamID() => ISteamGameServer.GetSteamID(self);
            public bool WasRestartRequested() => ISteamGameServer.WasRestartRequested(self);
            public void SetMaxPlayerCount(int cPlayersMax) => ISteamGameServer.SetMaxPlayerCount(self, cPlayersMax);
            public void SetBotPlayerCount(int cBotplayers) => ISteamGameServer.SetBotPlayerCount(self, cBotplayers);
            public void SetServerName(UTF8StringPtr pszServerName) => ISteamGameServer.SetServerName(self, pszServerName);
            public void SetMapName(UTF8StringPtr pszMapName) => ISteamGameServer.SetMapName(self, pszMapName);
            public void SetPasswordProtected(bool bPasswordProtected) => ISteamGameServer.SetPasswordProtected(self, bPasswordProtected);
            public void SetSpectatorPort(ushort unSpectatorPort) => ISteamGameServer.SetSpectatorPort(self, unSpectatorPort);
            public void SetSpectatorServerName(UTF8StringPtr pszSpectatorServerName) => ISteamGameServer.SetSpectatorServerName(self, pszSpectatorServerName);
            public void ClearAllKeyValues() => ISteamGameServer.ClearAllKeyValues(self);
            public void SetKeyValue(UTF8StringPtr pKey, UTF8StringPtr pValue) => ISteamGameServer.SetKeyValue(self, pKey, pValue);
            public void SetGameTags(UTF8StringPtr pchGameTags) => ISteamGameServer.SetGameTags(self, pchGameTags);
            public void SetGameData(UTF8StringPtr pchGameData) => ISteamGameServer.SetGameData(self, pchGameData);
            public void SetRegion(UTF8StringPtr pszRegion) => ISteamGameServer.SetRegion(self, pszRegion);
            public void SetAdvertiseServerActive(bool bActive) => ISteamGameServer.SetAdvertiseServerActive(self, bActive);
            public HAuthTicket GetAuthSessionTicket(void* pTicket, int cbMaxTicket, uint* pcbTicket, SteamNetworkingIdentity* pSnid) => ISteamGameServer.GetAuthSessionTicket(self, pTicket, cbMaxTicket, pcbTicket, pSnid);
            public BeginAuthSessionResult BeginAuthSession(void* pAuthTicket, int cbAuthTicket, SteamId steamID) => ISteamGameServer.BeginAuthSession(self, pAuthTicket, cbAuthTicket, steamID);
            public void EndAuthSession(SteamId steamID) => ISteamGameServer.EndAuthSession(self, steamID);
            public void CancelAuthTicket(HAuthTicket hAuthTicket) => ISteamGameServer.CancelAuthTicket(self, hAuthTicket);
            public UserHasLicenseForAppResult UserHasLicenseForApp(SteamId steamID, AppId appID) => ISteamGameServer.UserHasLicenseForApp(self, steamID, appID);
            public bool RequestUserGroupStatus(SteamId steamIDUser, SteamId steamIDGroup) => ISteamGameServer.RequestUserGroupStatus(self, steamIDUser, steamIDGroup);
            public void GetGameplayStats() => ISteamGameServer.GetGameplayStats(self);
            public SteamAPICall GetServerReputation() => ISteamGameServer.GetServerReputation(self);
            public SteamIPAddress GetPublicIP() => ISteamGameServer.GetPublicIP(self);
            public bool HandleIncomingPacket(void* pData, int cbData, uint srcIP, ushort srcPort) => ISteamGameServer.HandleIncomingPacket(self, pData, cbData, srcIP, srcPort);
            public int GetNextOutgoingPacket(void* pOut, int cbMaxOut, uint* pNetAdr, ushort* pPort) => ISteamGameServer.GetNextOutgoingPacket(self, pOut, cbMaxOut, pNetAdr, pPort);
            public SteamAPICall AssociateWithClan(SteamId steamIDClan) => ISteamGameServer.AssociateWithClan(self, steamIDClan);
            public SteamAPICall ComputeNewPlayerCompatibility(SteamId steamIDNewPlayer) => ISteamGameServer.ComputeNewPlayerCompatibility(self, steamIDNewPlayer);
            public bool SendUserConnectAndAuthenticate_DEPRECATED(uint unIPClient, void* pvAuthBlob, uint cubAuthBlobSize, SteamId* pSteamIDUser) => ISteamGameServer.SendUserConnectAndAuthenticate_DEPRECATED(self, unIPClient, pvAuthBlob, cubAuthBlobSize, pSteamIDUser);
            public SteamId CreateUnauthenticatedUserConnection() => ISteamGameServer.CreateUnauthenticatedUserConnection(self);
            public void SendUserDisconnect_DEPRECATED(SteamId steamIDUser) => ISteamGameServer.SendUserDisconnect_DEPRECATED(self, steamIDUser);
            public bool BUpdateUserData(SteamId steamIDUser, UTF8StringPtr pchPlayerName, uint uScore) => ISteamGameServer.BUpdateUserData(self, steamIDUser, pchPlayerName, uScore);
        }
    }
}