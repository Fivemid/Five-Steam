using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ISteamNetworkingSockets</summary>
    public unsafe interface ISteamNetworkingSockets
    {
        public HSteamListenSocket CreateListenSocketIP(ref SteamNetworkingIPAddr localAddress, int nOptions, SteamNetworkingConfigValue* pOptions);
        public HSteamNetConnection ConnectByIPAddress(ref SteamNetworkingIPAddr address, int nOptions, SteamNetworkingConfigValue* pOptions);
        public HSteamListenSocket CreateListenSocketP2P(int nLocalVirtualPort, int nOptions, SteamNetworkingConfigValue* pOptions);
        public HSteamNetConnection ConnectP2P(ref SteamNetworkingIdentity identityRemote, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue* pOptions);
        public Result AcceptConnection(HSteamNetConnection hConn);
        public bool CloseConnection(HSteamNetConnection hPeer, int nReason, UTF8StringPtr pszDebug, bool bEnableLinger);
        public bool CloseListenSocket(HSteamListenSocket hSocket);
        public bool SetConnectionUserData(HSteamNetConnection hPeer, long nUserData);
        public long GetConnectionUserData(HSteamNetConnection hPeer);
        public void SetConnectionName(HSteamNetConnection hPeer, UTF8StringPtr pszName);
        public bool GetConnectionName(HSteamNetConnection hPeer, char* pszName, int nMaxLen);
        public Result SendMessageToConnection(HSteamNetConnection hConn, void* pData, uint cbData, int nSendFlags, long* pOutMessageNumber);
        public void SendMessages(int nMessages, SteamNetworkingMessage** pMessages, long* pOutMessageNumberOrResult);
        public Result FlushMessagesOnConnection(HSteamNetConnection hConn);
        public int ReceiveMessagesOnConnection(HSteamNetConnection hConn, SteamNetworkingMessage** ppOutMessages, int nMaxMessages);
        public bool GetConnectionInfo(HSteamNetConnection hConn, SteamNetConnectionInfo* pInfo);
        public Result GetConnectionRealTimeStatus(HSteamNetConnection hConn, SteamNetConnectionRealTimeStatus* pStatus, int nLanes, SteamNetConnectionRealTimeLaneStatus* pLanes);
        public int GetDetailedConnectionStatus(HSteamNetConnection hConn, char* pszBuf, int cbBuf);
        public bool GetListenSocketAddress(HSteamListenSocket hSocket, SteamNetworkingIPAddr* address);
        public bool CreateSocketPair(HSteamNetConnection* pOutConnection1, HSteamNetConnection* pOutConnection2, bool bUseNetworkLoopback, SteamNetworkingIdentity* pIdentity1, SteamNetworkingIdentity* pIdentity2);
        public Result ConfigureConnectionLanes(HSteamNetConnection hConn, int nNumLanes, int* pLanePriorities, ushort* pLaneWeights);
        public bool GetIdentity(SteamNetworkingIdentity* pIdentity);
        public SteamNetworkingAvailability InitAuthentication();
        public SteamNetworkingAvailability GetAuthenticationStatus(SteamNetAuthenticationStatus* pDetails);
        public HSteamNetPollGroup CreatePollGroup();
        public bool DestroyPollGroup(HSteamNetPollGroup hPollGroup);
        public bool SetConnectionPollGroup(HSteamNetConnection hConn, HSteamNetPollGroup hPollGroup);
        public int ReceiveMessagesOnPollGroup(HSteamNetPollGroup hPollGroup, SteamNetworkingMessage** ppOutMessages, int nMaxMessages);
        public bool ReceivedRelayAuthTicket(void* pvTicket, int cbTicket, Unknown* pOutParsedTicket);
        public int FindRelayAuthTicketForServer(ref SteamNetworkingIdentity identityGameServer, int nRemoteVirtualPort, Unknown* pOutParsedTicket);
        public HSteamNetConnection ConnectToHostedDedicatedServer(ref SteamNetworkingIdentity identityTarget, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue* pOptions);
        public ushort GetHostedDedicatedServerPort();
        public SteamNetworkingPOPID GetHostedDedicatedServerPOPID();
        public Result GetHostedDedicatedServerAddress(SteamDatagramHostedAddress* pRouting);
        public HSteamListenSocket CreateHostedDedicatedServerListenSocket(int nLocalVirtualPort, int nOptions, SteamNetworkingConfigValue* pOptions);
        public Result GetGameCoordinatorServerLogin(SteamDatagramGameCoordinatorServerLogin* pLoginInfo, int* pcbSignedBlob, void* pBlob);
        public HSteamNetConnection ConnectP2PCustomSignaling(Unknown* pSignaling, SteamNetworkingIdentity* pPeerIdentity, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue* pOptions);
        public bool ReceivedP2PCustomSignal(void* pMsg, int cbMsg, Unknown* pContext);
        public bool GetCertificateRequest(int* pcbBlob, void* pBlob, ref SteamNetworkingErrMsg errMsg);
        public bool SetCertificate(void* pCertificate, int cbCertificate, ref SteamNetworkingErrMsg errMsg);
        public void ResetIdentity(SteamNetworkingIdentity* pIdentity);
        public void RunCallbacks();
        public bool BeginAsyncRequestFakeIP(int nNumPorts);
        public void GetFakeIP(int idxFirstPort, SteamNetworkingFakeIPResult* pInfo);
        public HSteamListenSocket CreateListenSocketP2PFakeIP(int idxFakePort, int nOptions, SteamNetworkingConfigValue* pOptions);
        public Result GetRemoteFakeIPForConnection(HSteamNetConnection hConn, SteamNetworkingIPAddr* pOutAddr);
        public ISteamNetworkingFakeUDPPort.Instance* CreateFakeUDPPort(int idxFakeServerPort);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_CreateListenSocketIP", CallingConvention = Platform.CC)]
        internal static extern HSteamListenSocket CreateListenSocketIP(void* self, ref SteamNetworkingIPAddr localAddress, int nOptions, SteamNetworkingConfigValue* pOptions);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_ConnectByIPAddress", CallingConvention = Platform.CC)]
        internal static extern HSteamNetConnection ConnectByIPAddress(void* self, ref SteamNetworkingIPAddr address, int nOptions, SteamNetworkingConfigValue* pOptions);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_CreateListenSocketP2P", CallingConvention = Platform.CC)]
        internal static extern HSteamListenSocket CreateListenSocketP2P(void* self, int nLocalVirtualPort, int nOptions, SteamNetworkingConfigValue* pOptions);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_ConnectP2P", CallingConvention = Platform.CC)]
        internal static extern HSteamNetConnection ConnectP2P(void* self, ref SteamNetworkingIdentity identityRemote, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue* pOptions);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_AcceptConnection", CallingConvention = Platform.CC)]
        internal static extern Result AcceptConnection(void* self, HSteamNetConnection hConn);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_CloseConnection", CallingConvention = Platform.CC)]
        internal static extern bool CloseConnection(void* self, HSteamNetConnection hPeer, int nReason, UTF8StringPtr pszDebug, bool bEnableLinger);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_CloseListenSocket", CallingConvention = Platform.CC)]
        internal static extern bool CloseListenSocket(void* self, HSteamListenSocket hSocket);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_SetConnectionUserData", CallingConvention = Platform.CC)]
        internal static extern bool SetConnectionUserData(void* self, HSteamNetConnection hPeer, long nUserData);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_GetConnectionUserData", CallingConvention = Platform.CC)]
        internal static extern long GetConnectionUserData(void* self, HSteamNetConnection hPeer);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_SetConnectionName", CallingConvention = Platform.CC)]
        internal static extern void SetConnectionName(void* self, HSteamNetConnection hPeer, UTF8StringPtr pszName);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_GetConnectionName", CallingConvention = Platform.CC)]
        internal static extern bool GetConnectionName(void* self, HSteamNetConnection hPeer, char* pszName, int nMaxLen);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_SendMessageToConnection", CallingConvention = Platform.CC)]
        internal static extern Result SendMessageToConnection(void* self, HSteamNetConnection hConn, void* pData, uint cbData, int nSendFlags, long* pOutMessageNumber);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_SendMessages", CallingConvention = Platform.CC)]
        internal static extern void SendMessages(void* self, int nMessages, SteamNetworkingMessage** pMessages, long* pOutMessageNumberOrResult);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_FlushMessagesOnConnection", CallingConvention = Platform.CC)]
        internal static extern Result FlushMessagesOnConnection(void* self, HSteamNetConnection hConn);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_ReceiveMessagesOnConnection", CallingConvention = Platform.CC)]
        internal static extern int ReceiveMessagesOnConnection(void* self, HSteamNetConnection hConn, SteamNetworkingMessage** ppOutMessages, int nMaxMessages);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_GetConnectionInfo", CallingConvention = Platform.CC)]
        internal static extern bool GetConnectionInfo(void* self, HSteamNetConnection hConn, SteamNetConnectionInfo* pInfo);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_GetConnectionRealTimeStatus", CallingConvention = Platform.CC)]
        internal static extern Result GetConnectionRealTimeStatus(void* self, HSteamNetConnection hConn, SteamNetConnectionRealTimeStatus* pStatus, int nLanes, SteamNetConnectionRealTimeLaneStatus* pLanes);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_GetDetailedConnectionStatus", CallingConvention = Platform.CC)]
        internal static extern int GetDetailedConnectionStatus(void* self, HSteamNetConnection hConn, char* pszBuf, int cbBuf);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_GetListenSocketAddress", CallingConvention = Platform.CC)]
        internal static extern bool GetListenSocketAddress(void* self, HSteamListenSocket hSocket, SteamNetworkingIPAddr* address);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_CreateSocketPair", CallingConvention = Platform.CC)]
        internal static extern bool CreateSocketPair(void* self, HSteamNetConnection* pOutConnection1, HSteamNetConnection* pOutConnection2, bool bUseNetworkLoopback, SteamNetworkingIdentity* pIdentity1, SteamNetworkingIdentity* pIdentity2);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_ConfigureConnectionLanes", CallingConvention = Platform.CC)]
        internal static extern Result ConfigureConnectionLanes(void* self, HSteamNetConnection hConn, int nNumLanes, int* pLanePriorities, ushort* pLaneWeights);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_GetIdentity", CallingConvention = Platform.CC)]
        internal static extern bool GetIdentity(void* self, SteamNetworkingIdentity* pIdentity);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_InitAuthentication", CallingConvention = Platform.CC)]
        internal static extern SteamNetworkingAvailability InitAuthentication(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_GetAuthenticationStatus", CallingConvention = Platform.CC)]
        internal static extern SteamNetworkingAvailability GetAuthenticationStatus(void* self, SteamNetAuthenticationStatus* pDetails);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_CreatePollGroup", CallingConvention = Platform.CC)]
        internal static extern HSteamNetPollGroup CreatePollGroup(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_DestroyPollGroup", CallingConvention = Platform.CC)]
        internal static extern bool DestroyPollGroup(void* self, HSteamNetPollGroup hPollGroup);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_SetConnectionPollGroup", CallingConvention = Platform.CC)]
        internal static extern bool SetConnectionPollGroup(void* self, HSteamNetConnection hConn, HSteamNetPollGroup hPollGroup);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_ReceiveMessagesOnPollGroup", CallingConvention = Platform.CC)]
        internal static extern int ReceiveMessagesOnPollGroup(void* self, HSteamNetPollGroup hPollGroup, SteamNetworkingMessage** ppOutMessages, int nMaxMessages);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_ReceivedRelayAuthTicket", CallingConvention = Platform.CC)]
        internal static extern bool ReceivedRelayAuthTicket(void* self, void* pvTicket, int cbTicket, Unknown* pOutParsedTicket);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_FindRelayAuthTicketForServer", CallingConvention = Platform.CC)]
        internal static extern int FindRelayAuthTicketForServer(void* self, ref SteamNetworkingIdentity identityGameServer, int nRemoteVirtualPort, Unknown* pOutParsedTicket);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_ConnectToHostedDedicatedServer", CallingConvention = Platform.CC)]
        internal static extern HSteamNetConnection ConnectToHostedDedicatedServer(void* self, ref SteamNetworkingIdentity identityTarget, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue* pOptions);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_GetHostedDedicatedServerPort", CallingConvention = Platform.CC)]
        internal static extern ushort GetHostedDedicatedServerPort(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_GetHostedDedicatedServerPOPID", CallingConvention = Platform.CC)]
        internal static extern SteamNetworkingPOPID GetHostedDedicatedServerPOPID(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_GetHostedDedicatedServerAddress", CallingConvention = Platform.CC)]
        internal static extern Result GetHostedDedicatedServerAddress(void* self, SteamDatagramHostedAddress* pRouting);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_CreateHostedDedicatedServerListenSocket", CallingConvention = Platform.CC)]
        internal static extern HSteamListenSocket CreateHostedDedicatedServerListenSocket(void* self, int nLocalVirtualPort, int nOptions, SteamNetworkingConfigValue* pOptions);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_GetGameCoordinatorServerLogin", CallingConvention = Platform.CC)]
        internal static extern Result GetGameCoordinatorServerLogin(void* self, SteamDatagramGameCoordinatorServerLogin* pLoginInfo, int* pcbSignedBlob, void* pBlob);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_ConnectP2PCustomSignaling", CallingConvention = Platform.CC)]
        internal static extern HSteamNetConnection ConnectP2PCustomSignaling(void* self, Unknown* pSignaling, SteamNetworkingIdentity* pPeerIdentity, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue* pOptions);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_ReceivedP2PCustomSignal", CallingConvention = Platform.CC)]
        internal static extern bool ReceivedP2PCustomSignal(void* self, void* pMsg, int cbMsg, Unknown* pContext);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_GetCertificateRequest", CallingConvention = Platform.CC)]
        internal static extern bool GetCertificateRequest(void* self, int* pcbBlob, void* pBlob, ref SteamNetworkingErrMsg errMsg);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_SetCertificate", CallingConvention = Platform.CC)]
        internal static extern bool SetCertificate(void* self, void* pCertificate, int cbCertificate, ref SteamNetworkingErrMsg errMsg);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_ResetIdentity", CallingConvention = Platform.CC)]
        internal static extern void ResetIdentity(void* self, SteamNetworkingIdentity* pIdentity);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_RunCallbacks", CallingConvention = Platform.CC)]
        internal static extern void RunCallbacks(void* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_BeginAsyncRequestFakeIP", CallingConvention = Platform.CC)]
        internal static extern bool BeginAsyncRequestFakeIP(void* self, int nNumPorts);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_GetFakeIP", CallingConvention = Platform.CC)]
        internal static extern void GetFakeIP(void* self, int idxFirstPort, SteamNetworkingFakeIPResult* pInfo);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_CreateListenSocketP2PFakeIP", CallingConvention = Platform.CC)]
        internal static extern HSteamListenSocket CreateListenSocketP2PFakeIP(void* self, int idxFakePort, int nOptions, SteamNetworkingConfigValue* pOptions);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_GetRemoteFakeIPForConnection", CallingConvention = Platform.CC)]
        internal static extern Result GetRemoteFakeIPForConnection(void* self, HSteamNetConnection hConn, SteamNetworkingIPAddr* pOutAddr);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingSockets_CreateFakeUDPPort", CallingConvention = Platform.CC)]
        internal static extern ISteamNetworkingFakeUDPPort.Instance* CreateFakeUDPPort(void* self, int idxFakeServerPort);
        public struct Instance : ISteamNetworkingSockets
        {
            public void* self;
            public HSteamListenSocket CreateListenSocketIP(ref SteamNetworkingIPAddr localAddress, int nOptions, SteamNetworkingConfigValue* pOptions) => ISteamNetworkingSockets.CreateListenSocketIP(self, ref localAddress, nOptions, pOptions);
            public HSteamNetConnection ConnectByIPAddress(ref SteamNetworkingIPAddr address, int nOptions, SteamNetworkingConfigValue* pOptions) => ISteamNetworkingSockets.ConnectByIPAddress(self, ref address, nOptions, pOptions);
            public HSteamListenSocket CreateListenSocketP2P(int nLocalVirtualPort, int nOptions, SteamNetworkingConfigValue* pOptions) => ISteamNetworkingSockets.CreateListenSocketP2P(self, nLocalVirtualPort, nOptions, pOptions);
            public HSteamNetConnection ConnectP2P(ref SteamNetworkingIdentity identityRemote, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue* pOptions) => ISteamNetworkingSockets.ConnectP2P(self, ref identityRemote, nRemoteVirtualPort, nOptions, pOptions);
            public Result AcceptConnection(HSteamNetConnection hConn) => ISteamNetworkingSockets.AcceptConnection(self, hConn);
            public bool CloseConnection(HSteamNetConnection hPeer, int nReason, UTF8StringPtr pszDebug, bool bEnableLinger) => ISteamNetworkingSockets.CloseConnection(self, hPeer, nReason, pszDebug, bEnableLinger);
            public bool CloseListenSocket(HSteamListenSocket hSocket) => ISteamNetworkingSockets.CloseListenSocket(self, hSocket);
            public bool SetConnectionUserData(HSteamNetConnection hPeer, long nUserData) => ISteamNetworkingSockets.SetConnectionUserData(self, hPeer, nUserData);
            public long GetConnectionUserData(HSteamNetConnection hPeer) => ISteamNetworkingSockets.GetConnectionUserData(self, hPeer);
            public void SetConnectionName(HSteamNetConnection hPeer, UTF8StringPtr pszName) => ISteamNetworkingSockets.SetConnectionName(self, hPeer, pszName);
            public bool GetConnectionName(HSteamNetConnection hPeer, char* pszName, int nMaxLen) => ISteamNetworkingSockets.GetConnectionName(self, hPeer, pszName, nMaxLen);
            public Result SendMessageToConnection(HSteamNetConnection hConn, void* pData, uint cbData, int nSendFlags, long* pOutMessageNumber) => ISteamNetworkingSockets.SendMessageToConnection(self, hConn, pData, cbData, nSendFlags, pOutMessageNumber);
            public void SendMessages(int nMessages, SteamNetworkingMessage** pMessages, long* pOutMessageNumberOrResult) => ISteamNetworkingSockets.SendMessages(self, nMessages, pMessages, pOutMessageNumberOrResult);
            public Result FlushMessagesOnConnection(HSteamNetConnection hConn) => ISteamNetworkingSockets.FlushMessagesOnConnection(self, hConn);
            public int ReceiveMessagesOnConnection(HSteamNetConnection hConn, SteamNetworkingMessage** ppOutMessages, int nMaxMessages) => ISteamNetworkingSockets.ReceiveMessagesOnConnection(self, hConn, ppOutMessages, nMaxMessages);
            public bool GetConnectionInfo(HSteamNetConnection hConn, SteamNetConnectionInfo* pInfo) => ISteamNetworkingSockets.GetConnectionInfo(self, hConn, pInfo);
            public Result GetConnectionRealTimeStatus(HSteamNetConnection hConn, SteamNetConnectionRealTimeStatus* pStatus, int nLanes, SteamNetConnectionRealTimeLaneStatus* pLanes) => ISteamNetworkingSockets.GetConnectionRealTimeStatus(self, hConn, pStatus, nLanes, pLanes);
            public int GetDetailedConnectionStatus(HSteamNetConnection hConn, char* pszBuf, int cbBuf) => ISteamNetworkingSockets.GetDetailedConnectionStatus(self, hConn, pszBuf, cbBuf);
            public bool GetListenSocketAddress(HSteamListenSocket hSocket, SteamNetworkingIPAddr* address) => ISteamNetworkingSockets.GetListenSocketAddress(self, hSocket, address);
            public bool CreateSocketPair(HSteamNetConnection* pOutConnection1, HSteamNetConnection* pOutConnection2, bool bUseNetworkLoopback, SteamNetworkingIdentity* pIdentity1, SteamNetworkingIdentity* pIdentity2) => ISteamNetworkingSockets.CreateSocketPair(self, pOutConnection1, pOutConnection2, bUseNetworkLoopback, pIdentity1, pIdentity2);
            public Result ConfigureConnectionLanes(HSteamNetConnection hConn, int nNumLanes, int* pLanePriorities, ushort* pLaneWeights) => ISteamNetworkingSockets.ConfigureConnectionLanes(self, hConn, nNumLanes, pLanePriorities, pLaneWeights);
            public bool GetIdentity(SteamNetworkingIdentity* pIdentity) => ISteamNetworkingSockets.GetIdentity(self, pIdentity);
            public SteamNetworkingAvailability InitAuthentication() => ISteamNetworkingSockets.InitAuthentication(self);
            public SteamNetworkingAvailability GetAuthenticationStatus(SteamNetAuthenticationStatus* pDetails) => ISteamNetworkingSockets.GetAuthenticationStatus(self, pDetails);
            public HSteamNetPollGroup CreatePollGroup() => ISteamNetworkingSockets.CreatePollGroup(self);
            public bool DestroyPollGroup(HSteamNetPollGroup hPollGroup) => ISteamNetworkingSockets.DestroyPollGroup(self, hPollGroup);
            public bool SetConnectionPollGroup(HSteamNetConnection hConn, HSteamNetPollGroup hPollGroup) => ISteamNetworkingSockets.SetConnectionPollGroup(self, hConn, hPollGroup);
            public int ReceiveMessagesOnPollGroup(HSteamNetPollGroup hPollGroup, SteamNetworkingMessage** ppOutMessages, int nMaxMessages) => ISteamNetworkingSockets.ReceiveMessagesOnPollGroup(self, hPollGroup, ppOutMessages, nMaxMessages);
            public bool ReceivedRelayAuthTicket(void* pvTicket, int cbTicket, Unknown* pOutParsedTicket) => ISteamNetworkingSockets.ReceivedRelayAuthTicket(self, pvTicket, cbTicket, pOutParsedTicket);
            public int FindRelayAuthTicketForServer(ref SteamNetworkingIdentity identityGameServer, int nRemoteVirtualPort, Unknown* pOutParsedTicket) => ISteamNetworkingSockets.FindRelayAuthTicketForServer(self, ref identityGameServer, nRemoteVirtualPort, pOutParsedTicket);
            public HSteamNetConnection ConnectToHostedDedicatedServer(ref SteamNetworkingIdentity identityTarget, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue* pOptions) => ISteamNetworkingSockets.ConnectToHostedDedicatedServer(self, ref identityTarget, nRemoteVirtualPort, nOptions, pOptions);
            public ushort GetHostedDedicatedServerPort() => ISteamNetworkingSockets.GetHostedDedicatedServerPort(self);
            public SteamNetworkingPOPID GetHostedDedicatedServerPOPID() => ISteamNetworkingSockets.GetHostedDedicatedServerPOPID(self);
            public Result GetHostedDedicatedServerAddress(SteamDatagramHostedAddress* pRouting) => ISteamNetworkingSockets.GetHostedDedicatedServerAddress(self, pRouting);
            public HSteamListenSocket CreateHostedDedicatedServerListenSocket(int nLocalVirtualPort, int nOptions, SteamNetworkingConfigValue* pOptions) => ISteamNetworkingSockets.CreateHostedDedicatedServerListenSocket(self, nLocalVirtualPort, nOptions, pOptions);
            public Result GetGameCoordinatorServerLogin(SteamDatagramGameCoordinatorServerLogin* pLoginInfo, int* pcbSignedBlob, void* pBlob) => ISteamNetworkingSockets.GetGameCoordinatorServerLogin(self, pLoginInfo, pcbSignedBlob, pBlob);
            public HSteamNetConnection ConnectP2PCustomSignaling(Unknown* pSignaling, SteamNetworkingIdentity* pPeerIdentity, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue* pOptions) => ISteamNetworkingSockets.ConnectP2PCustomSignaling(self, pSignaling, pPeerIdentity, nRemoteVirtualPort, nOptions, pOptions);
            public bool ReceivedP2PCustomSignal(void* pMsg, int cbMsg, Unknown* pContext) => ISteamNetworkingSockets.ReceivedP2PCustomSignal(self, pMsg, cbMsg, pContext);
            public bool GetCertificateRequest(int* pcbBlob, void* pBlob, ref SteamNetworkingErrMsg errMsg) => ISteamNetworkingSockets.GetCertificateRequest(self, pcbBlob, pBlob, ref errMsg);
            public bool SetCertificate(void* pCertificate, int cbCertificate, ref SteamNetworkingErrMsg errMsg) => ISteamNetworkingSockets.SetCertificate(self, pCertificate, cbCertificate, ref errMsg);
            public void ResetIdentity(SteamNetworkingIdentity* pIdentity) => ISteamNetworkingSockets.ResetIdentity(self, pIdentity);
            public void RunCallbacks() => ISteamNetworkingSockets.RunCallbacks(self);
            public bool BeginAsyncRequestFakeIP(int nNumPorts) => ISteamNetworkingSockets.BeginAsyncRequestFakeIP(self, nNumPorts);
            public void GetFakeIP(int idxFirstPort, SteamNetworkingFakeIPResult* pInfo) => ISteamNetworkingSockets.GetFakeIP(self, idxFirstPort, pInfo);
            public HSteamListenSocket CreateListenSocketP2PFakeIP(int idxFakePort, int nOptions, SteamNetworkingConfigValue* pOptions) => ISteamNetworkingSockets.CreateListenSocketP2PFakeIP(self, idxFakePort, nOptions, pOptions);
            public Result GetRemoteFakeIPForConnection(HSteamNetConnection hConn, SteamNetworkingIPAddr* pOutAddr) => ISteamNetworkingSockets.GetRemoteFakeIPForConnection(self, hConn, pOutAddr);
            public ISteamNetworkingFakeUDPPort.Instance* CreateFakeUDPPort(int idxFakeServerPort) => ISteamNetworkingSockets.CreateFakeUDPPort(self, idxFakeServerPort);
        }
    }
}