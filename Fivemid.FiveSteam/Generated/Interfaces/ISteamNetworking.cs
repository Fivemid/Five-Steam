using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Networking functions for making connections and sending data between clients, traversing NATs when possible.<br />
    /// <br />
    /// <b>NOTE</b>: This API is deprecated and may be removed in a future Steamworks SDK release.  Please use <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingSockets" class="bb_apilink">ISteamNetworkingSockets</a> or <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingMessages" class="bb_apilink">ISteamNetworkingMessages</a> instead.  See the <a href="https://partner.steamgames.com/doc/features/multiplayer/networking" class="bb_doclink">Steam Networking</a> overview for more information.</summary>
    public unsafe interface ISteamNetworking
    {
        public bool SendP2PPacket(SteamId steamIDRemote, void* pubData, uint cubData, P2PSend eP2PSendType, int nChannel);
        public bool IsP2PPacketAvailable(uint* pcubMsgSize, int nChannel);
        public bool ReadP2PPacket(void* pubDest, uint cubDest, uint* pcubMsgSize, SteamId* psteamIDRemote, int nChannel);
        public bool AcceptP2PSessionWithUser(SteamId steamIDRemote);
        public bool CloseP2PSessionWithUser(SteamId steamIDRemote);
        public bool CloseP2PChannelWithUser(SteamId steamIDRemote, int nChannel);
        public bool GetP2PSessionState(SteamId steamIDRemote, P2PSessionState* pConnectionState);
        public bool AllowP2PPacketRelay(bool bAllow);
        public SNetListenSocket CreateListenSocket(int nVirtualP2PPort, SteamIPAddress nIP, ushort nPort, bool bAllowUseOfPacketRelay);
        public SNetSocket CreateP2PConnectionSocket(SteamId steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay);
        public SNetSocket CreateConnectionSocket(SteamIPAddress nIP, ushort nPort, int nTimeoutSec);
        public bool DestroySocket(SNetSocket hSocket, bool bNotifyRemoteEnd);
        public bool DestroyListenSocket(SNetListenSocket hSocket, bool bNotifyRemoteEnd);
        public bool SendDataOnSocket(SNetSocket hSocket, void* pubData, uint cubData, bool bReliable);
        public bool IsDataAvailableOnSocket(SNetSocket hSocket, uint* pcubMsgSize);
        public bool RetrieveDataFromSocket(SNetSocket hSocket, void* pubDest, uint cubDest, uint* pcubMsgSize);
        public bool IsDataAvailable(SNetListenSocket hListenSocket, uint* pcubMsgSize, SNetSocket* phSocket);
        public bool RetrieveData(SNetListenSocket hListenSocket, void* pubDest, uint cubDest, uint* pcubMsgSize, SNetSocket* phSocket);
        public bool GetSocketInfo(SNetSocket hSocket, SteamId* pSteamIDRemote, int* peSocketStatus, SteamIPAddress* punIPRemote, ushort* punPortRemote);
        public bool GetListenSocketInfo(SNetListenSocket hListenSocket, SteamIPAddress* pnIP, ushort* pnPort);
        public SNetSocketConnectionType GetSocketConnectionType(SNetSocket hSocket);
        public int GetMaxPacketSize(SNetSocket hSocket);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworking_SendP2PPacket", CallingConvention = Platform.CC)]
        internal static extern bool SendP2PPacket(void* self, SteamId steamIDRemote, void* pubData, uint cubData, P2PSend eP2PSendType, int nChannel);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworking_IsP2PPacketAvailable", CallingConvention = Platform.CC)]
        internal static extern bool IsP2PPacketAvailable(void* self, uint* pcubMsgSize, int nChannel);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworking_ReadP2PPacket", CallingConvention = Platform.CC)]
        internal static extern bool ReadP2PPacket(void* self, void* pubDest, uint cubDest, uint* pcubMsgSize, SteamId* psteamIDRemote, int nChannel);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworking_AcceptP2PSessionWithUser", CallingConvention = Platform.CC)]
        internal static extern bool AcceptP2PSessionWithUser(void* self, SteamId steamIDRemote);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworking_CloseP2PSessionWithUser", CallingConvention = Platform.CC)]
        internal static extern bool CloseP2PSessionWithUser(void* self, SteamId steamIDRemote);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworking_CloseP2PChannelWithUser", CallingConvention = Platform.CC)]
        internal static extern bool CloseP2PChannelWithUser(void* self, SteamId steamIDRemote, int nChannel);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworking_GetP2PSessionState", CallingConvention = Platform.CC)]
        internal static extern bool GetP2PSessionState(void* self, SteamId steamIDRemote, P2PSessionState* pConnectionState);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworking_AllowP2PPacketRelay", CallingConvention = Platform.CC)]
        internal static extern bool AllowP2PPacketRelay(void* self, bool bAllow);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworking_CreateListenSocket", CallingConvention = Platform.CC)]
        internal static extern SNetListenSocket CreateListenSocket(void* self, int nVirtualP2PPort, SteamIPAddress nIP, ushort nPort, bool bAllowUseOfPacketRelay);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworking_CreateP2PConnectionSocket", CallingConvention = Platform.CC)]
        internal static extern SNetSocket CreateP2PConnectionSocket(void* self, SteamId steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworking_CreateConnectionSocket", CallingConvention = Platform.CC)]
        internal static extern SNetSocket CreateConnectionSocket(void* self, SteamIPAddress nIP, ushort nPort, int nTimeoutSec);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworking_DestroySocket", CallingConvention = Platform.CC)]
        internal static extern bool DestroySocket(void* self, SNetSocket hSocket, bool bNotifyRemoteEnd);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworking_DestroyListenSocket", CallingConvention = Platform.CC)]
        internal static extern bool DestroyListenSocket(void* self, SNetListenSocket hSocket, bool bNotifyRemoteEnd);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworking_SendDataOnSocket", CallingConvention = Platform.CC)]
        internal static extern bool SendDataOnSocket(void* self, SNetSocket hSocket, void* pubData, uint cubData, bool bReliable);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworking_IsDataAvailableOnSocket", CallingConvention = Platform.CC)]
        internal static extern bool IsDataAvailableOnSocket(void* self, SNetSocket hSocket, uint* pcubMsgSize);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworking_RetrieveDataFromSocket", CallingConvention = Platform.CC)]
        internal static extern bool RetrieveDataFromSocket(void* self, SNetSocket hSocket, void* pubDest, uint cubDest, uint* pcubMsgSize);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworking_IsDataAvailable", CallingConvention = Platform.CC)]
        internal static extern bool IsDataAvailable(void* self, SNetListenSocket hListenSocket, uint* pcubMsgSize, SNetSocket* phSocket);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworking_RetrieveData", CallingConvention = Platform.CC)]
        internal static extern bool RetrieveData(void* self, SNetListenSocket hListenSocket, void* pubDest, uint cubDest, uint* pcubMsgSize, SNetSocket* phSocket);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworking_GetSocketInfo", CallingConvention = Platform.CC)]
        internal static extern bool GetSocketInfo(void* self, SNetSocket hSocket, SteamId* pSteamIDRemote, int* peSocketStatus, SteamIPAddress* punIPRemote, ushort* punPortRemote);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworking_GetListenSocketInfo", CallingConvention = Platform.CC)]
        internal static extern bool GetListenSocketInfo(void* self, SNetListenSocket hListenSocket, SteamIPAddress* pnIP, ushort* pnPort);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworking_GetSocketConnectionType", CallingConvention = Platform.CC)]
        internal static extern SNetSocketConnectionType GetSocketConnectionType(void* self, SNetSocket hSocket);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworking_GetMaxPacketSize", CallingConvention = Platform.CC)]
        internal static extern int GetMaxPacketSize(void* self, SNetSocket hSocket);
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct Instance : ISteamNetworking
        {
            public void* self;
            public bool SendP2PPacket(SteamId steamIDRemote, void* pubData, uint cubData, P2PSend eP2PSendType, int nChannel) => ISteamNetworking.SendP2PPacket(self, steamIDRemote, pubData, cubData, eP2PSendType, nChannel);
            public bool IsP2PPacketAvailable(uint* pcubMsgSize, int nChannel) => ISteamNetworking.IsP2PPacketAvailable(self, pcubMsgSize, nChannel);
            public bool ReadP2PPacket(void* pubDest, uint cubDest, uint* pcubMsgSize, SteamId* psteamIDRemote, int nChannel) => ISteamNetworking.ReadP2PPacket(self, pubDest, cubDest, pcubMsgSize, psteamIDRemote, nChannel);
            public bool AcceptP2PSessionWithUser(SteamId steamIDRemote) => ISteamNetworking.AcceptP2PSessionWithUser(self, steamIDRemote);
            public bool CloseP2PSessionWithUser(SteamId steamIDRemote) => ISteamNetworking.CloseP2PSessionWithUser(self, steamIDRemote);
            public bool CloseP2PChannelWithUser(SteamId steamIDRemote, int nChannel) => ISteamNetworking.CloseP2PChannelWithUser(self, steamIDRemote, nChannel);
            public bool GetP2PSessionState(SteamId steamIDRemote, P2PSessionState* pConnectionState) => ISteamNetworking.GetP2PSessionState(self, steamIDRemote, pConnectionState);
            public bool AllowP2PPacketRelay(bool bAllow) => ISteamNetworking.AllowP2PPacketRelay(self, bAllow);
            public SNetListenSocket CreateListenSocket(int nVirtualP2PPort, SteamIPAddress nIP, ushort nPort, bool bAllowUseOfPacketRelay) => ISteamNetworking.CreateListenSocket(self, nVirtualP2PPort, nIP, nPort, bAllowUseOfPacketRelay);
            public SNetSocket CreateP2PConnectionSocket(SteamId steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay) => ISteamNetworking.CreateP2PConnectionSocket(self, steamIDTarget, nVirtualPort, nTimeoutSec, bAllowUseOfPacketRelay);
            public SNetSocket CreateConnectionSocket(SteamIPAddress nIP, ushort nPort, int nTimeoutSec) => ISteamNetworking.CreateConnectionSocket(self, nIP, nPort, nTimeoutSec);
            public bool DestroySocket(SNetSocket hSocket, bool bNotifyRemoteEnd) => ISteamNetworking.DestroySocket(self, hSocket, bNotifyRemoteEnd);
            public bool DestroyListenSocket(SNetListenSocket hSocket, bool bNotifyRemoteEnd) => ISteamNetworking.DestroyListenSocket(self, hSocket, bNotifyRemoteEnd);
            public bool SendDataOnSocket(SNetSocket hSocket, void* pubData, uint cubData, bool bReliable) => ISteamNetworking.SendDataOnSocket(self, hSocket, pubData, cubData, bReliable);
            public bool IsDataAvailableOnSocket(SNetSocket hSocket, uint* pcubMsgSize) => ISteamNetworking.IsDataAvailableOnSocket(self, hSocket, pcubMsgSize);
            public bool RetrieveDataFromSocket(SNetSocket hSocket, void* pubDest, uint cubDest, uint* pcubMsgSize) => ISteamNetworking.RetrieveDataFromSocket(self, hSocket, pubDest, cubDest, pcubMsgSize);
            public bool IsDataAvailable(SNetListenSocket hListenSocket, uint* pcubMsgSize, SNetSocket* phSocket) => ISteamNetworking.IsDataAvailable(self, hListenSocket, pcubMsgSize, phSocket);
            public bool RetrieveData(SNetListenSocket hListenSocket, void* pubDest, uint cubDest, uint* pcubMsgSize, SNetSocket* phSocket) => ISteamNetworking.RetrieveData(self, hListenSocket, pubDest, cubDest, pcubMsgSize, phSocket);
            public bool GetSocketInfo(SNetSocket hSocket, SteamId* pSteamIDRemote, int* peSocketStatus, SteamIPAddress* punIPRemote, ushort* punPortRemote) => ISteamNetworking.GetSocketInfo(self, hSocket, pSteamIDRemote, peSocketStatus, punIPRemote, punPortRemote);
            public bool GetListenSocketInfo(SNetListenSocket hListenSocket, SteamIPAddress* pnIP, ushort* pnPort) => ISteamNetworking.GetListenSocketInfo(self, hListenSocket, pnIP, pnPort);
            public SNetSocketConnectionType GetSocketConnectionType(SNetSocket hSocket) => ISteamNetworking.GetSocketConnectionType(self, hSocket);
            public int GetMaxPacketSize(SNetSocket hSocket) => ISteamNetworking.GetMaxPacketSize(self, hSocket);
        }
    }
}