using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamNetworkingSockets_SteamAPI
    {
        public static ISteamNetworkingSockets.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamNetworkingSockets_SteamAPI_v012", CallingConvention = Platform.CC)]
        private static extern ISteamNetworkingSockets.Instance Accessor();
        /// <summary></summary>
        public static HSteamListenSocket CreateListenSocketIP(ref SteamNetworkingIPAddr localAddress, int nOptions, SteamNetworkingConfigValue* pOptions) => Instance.CreateListenSocketIP(ref localAddress, nOptions, pOptions);
        /// <summary></summary>
        public static HSteamNetConnection ConnectByIPAddress(ref SteamNetworkingIPAddr address, int nOptions, SteamNetworkingConfigValue* pOptions) => Instance.ConnectByIPAddress(ref address, nOptions, pOptions);
        /// <summary></summary>
        public static HSteamListenSocket CreateListenSocketP2P(int nLocalVirtualPort, int nOptions, SteamNetworkingConfigValue* pOptions) => Instance.CreateListenSocketP2P(nLocalVirtualPort, nOptions, pOptions);
        /// <summary></summary>
        public static HSteamNetConnection ConnectP2P(ref SteamNetworkingIdentity identityRemote, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue* pOptions) => Instance.ConnectP2P(ref identityRemote, nRemoteVirtualPort, nOptions, pOptions);
        /// <summary></summary>
        public static Result AcceptConnection(HSteamNetConnection hConn) => Instance.AcceptConnection(hConn);
        /// <summary></summary>
        public static bool CloseConnection(HSteamNetConnection hPeer, int nReason, UTF8StringPtr pszDebug, bool bEnableLinger) => Instance.CloseConnection(hPeer, nReason, pszDebug, bEnableLinger);
        /// <summary></summary>
        public static bool CloseListenSocket(HSteamListenSocket hSocket) => Instance.CloseListenSocket(hSocket);
        /// <summary></summary>
        public static bool SetConnectionUserData(HSteamNetConnection hPeer, long nUserData) => Instance.SetConnectionUserData(hPeer, nUserData);
        /// <summary></summary>
        public static long GetConnectionUserData(HSteamNetConnection hPeer) => Instance.GetConnectionUserData(hPeer);
        /// <summary></summary>
        public static void SetConnectionName(HSteamNetConnection hPeer, UTF8StringPtr pszName) => Instance.SetConnectionName(hPeer, pszName);
        /// <summary></summary>
        public static bool GetConnectionName(HSteamNetConnection hPeer, char* pszName, int nMaxLen) => Instance.GetConnectionName(hPeer, pszName, nMaxLen);
        /// <summary></summary>
        public static Result SendMessageToConnection(HSteamNetConnection hConn, void* pData, uint cbData, int nSendFlags, long* pOutMessageNumber) => Instance.SendMessageToConnection(hConn, pData, cbData, nSendFlags, pOutMessageNumber);
        /// <summary></summary>
        public static void SendMessages(int nMessages, SteamNetworkingMessage** pMessages, long* pOutMessageNumberOrResult) => Instance.SendMessages(nMessages, pMessages, pOutMessageNumberOrResult);
        /// <summary></summary>
        public static Result FlushMessagesOnConnection(HSteamNetConnection hConn) => Instance.FlushMessagesOnConnection(hConn);
        /// <summary></summary>
        public static int ReceiveMessagesOnConnection(HSteamNetConnection hConn, SteamNetworkingMessage** ppOutMessages, int nMaxMessages) => Instance.ReceiveMessagesOnConnection(hConn, ppOutMessages, nMaxMessages);
        /// <summary></summary>
        public static bool GetConnectionInfo(HSteamNetConnection hConn, SteamNetConnectionInfo* pInfo) => Instance.GetConnectionInfo(hConn, pInfo);
        /// <summary></summary>
        public static Result GetConnectionRealTimeStatus(HSteamNetConnection hConn, SteamNetConnectionRealTimeStatus* pStatus, int nLanes, SteamNetConnectionRealTimeLaneStatus* pLanes) => Instance.GetConnectionRealTimeStatus(hConn, pStatus, nLanes, pLanes);
        /// <summary></summary>
        public static int GetDetailedConnectionStatus(HSteamNetConnection hConn, char* pszBuf, int cbBuf) => Instance.GetDetailedConnectionStatus(hConn, pszBuf, cbBuf);
        /// <summary></summary>
        public static bool GetListenSocketAddress(HSteamListenSocket hSocket, SteamNetworkingIPAddr* address) => Instance.GetListenSocketAddress(hSocket, address);
        /// <summary></summary>
        public static bool CreateSocketPair(HSteamNetConnection* pOutConnection1, HSteamNetConnection* pOutConnection2, bool bUseNetworkLoopback, SteamNetworkingIdentity* pIdentity1, SteamNetworkingIdentity* pIdentity2) => Instance.CreateSocketPair(pOutConnection1, pOutConnection2, bUseNetworkLoopback, pIdentity1, pIdentity2);
        /// <summary></summary>
        public static Result ConfigureConnectionLanes(HSteamNetConnection hConn, int nNumLanes, int* pLanePriorities, ushort* pLaneWeights) => Instance.ConfigureConnectionLanes(hConn, nNumLanes, pLanePriorities, pLaneWeights);
        /// <summary></summary>
        public static bool GetIdentity(SteamNetworkingIdentity* pIdentity) => Instance.GetIdentity(pIdentity);
        /// <summary></summary>
        public static SteamNetworkingAvailability InitAuthentication() => Instance.InitAuthentication();
        /// <summary></summary>
        public static SteamNetworkingAvailability GetAuthenticationStatus(SteamNetAuthenticationStatus* pDetails) => Instance.GetAuthenticationStatus(pDetails);
        /// <summary></summary>
        public static HSteamNetPollGroup CreatePollGroup() => Instance.CreatePollGroup();
        /// <summary></summary>
        public static bool DestroyPollGroup(HSteamNetPollGroup hPollGroup) => Instance.DestroyPollGroup(hPollGroup);
        /// <summary></summary>
        public static bool SetConnectionPollGroup(HSteamNetConnection hConn, HSteamNetPollGroup hPollGroup) => Instance.SetConnectionPollGroup(hConn, hPollGroup);
        /// <summary></summary>
        public static int ReceiveMessagesOnPollGroup(HSteamNetPollGroup hPollGroup, SteamNetworkingMessage** ppOutMessages, int nMaxMessages) => Instance.ReceiveMessagesOnPollGroup(hPollGroup, ppOutMessages, nMaxMessages);
        /// <summary></summary>
        public static bool ReceivedRelayAuthTicket(void* pvTicket, int cbTicket, Unknown* pOutParsedTicket) => Instance.ReceivedRelayAuthTicket(pvTicket, cbTicket, pOutParsedTicket);
        /// <summary></summary>
        public static int FindRelayAuthTicketForServer(ref SteamNetworkingIdentity identityGameServer, int nRemoteVirtualPort, Unknown* pOutParsedTicket) => Instance.FindRelayAuthTicketForServer(ref identityGameServer, nRemoteVirtualPort, pOutParsedTicket);
        /// <summary></summary>
        public static HSteamNetConnection ConnectToHostedDedicatedServer(ref SteamNetworkingIdentity identityTarget, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue* pOptions) => Instance.ConnectToHostedDedicatedServer(ref identityTarget, nRemoteVirtualPort, nOptions, pOptions);
        /// <summary></summary>
        public static ushort GetHostedDedicatedServerPort() => Instance.GetHostedDedicatedServerPort();
        /// <summary></summary>
        public static SteamNetworkingPOPID GetHostedDedicatedServerPOPID() => Instance.GetHostedDedicatedServerPOPID();
        /// <summary></summary>
        public static Result GetHostedDedicatedServerAddress(SteamDatagramHostedAddress* pRouting) => Instance.GetHostedDedicatedServerAddress(pRouting);
        /// <summary></summary>
        public static HSteamListenSocket CreateHostedDedicatedServerListenSocket(int nLocalVirtualPort, int nOptions, SteamNetworkingConfigValue* pOptions) => Instance.CreateHostedDedicatedServerListenSocket(nLocalVirtualPort, nOptions, pOptions);
        /// <summary></summary>
        public static Result GetGameCoordinatorServerLogin(SteamDatagramGameCoordinatorServerLogin* pLoginInfo, int* pcbSignedBlob, void* pBlob) => Instance.GetGameCoordinatorServerLogin(pLoginInfo, pcbSignedBlob, pBlob);
        /// <summary></summary>
        public static HSteamNetConnection ConnectP2PCustomSignaling(Unknown* pSignaling, SteamNetworkingIdentity* pPeerIdentity, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue* pOptions) => Instance.ConnectP2PCustomSignaling(pSignaling, pPeerIdentity, nRemoteVirtualPort, nOptions, pOptions);
        /// <summary></summary>
        public static bool ReceivedP2PCustomSignal(void* pMsg, int cbMsg, Unknown* pContext) => Instance.ReceivedP2PCustomSignal(pMsg, cbMsg, pContext);
        /// <summary></summary>
        public static bool GetCertificateRequest(int* pcbBlob, void* pBlob, ref SteamNetworkingErrMsg errMsg) => Instance.GetCertificateRequest(pcbBlob, pBlob, ref errMsg);
        /// <summary></summary>
        public static bool SetCertificate(void* pCertificate, int cbCertificate, ref SteamNetworkingErrMsg errMsg) => Instance.SetCertificate(pCertificate, cbCertificate, ref errMsg);
        /// <summary></summary>
        public static void ResetIdentity(SteamNetworkingIdentity* pIdentity) => Instance.ResetIdentity(pIdentity);
        /// <summary></summary>
        public static void RunCallbacks() => Instance.RunCallbacks();
        /// <summary></summary>
        public static bool BeginAsyncRequestFakeIP(int nNumPorts) => Instance.BeginAsyncRequestFakeIP(nNumPorts);
        /// <summary></summary>
        public static void GetFakeIP(int idxFirstPort, SteamNetworkingFakeIPResult* pInfo) => Instance.GetFakeIP(idxFirstPort, pInfo);
        /// <summary></summary>
        public static HSteamListenSocket CreateListenSocketP2PFakeIP(int idxFakePort, int nOptions, SteamNetworkingConfigValue* pOptions) => Instance.CreateListenSocketP2PFakeIP(idxFakePort, nOptions, pOptions);
        /// <summary></summary>
        public static Result GetRemoteFakeIPForConnection(HSteamNetConnection hConn, SteamNetworkingIPAddr* pOutAddr) => Instance.GetRemoteFakeIPForConnection(hConn, pOutAddr);
        /// <summary></summary>
        public static ISteamNetworkingFakeUDPPort.Instance* CreateFakeUDPPort(int idxFakeServerPort) => Instance.CreateFakeUDPPort(idxFakeServerPort);
    }
}