using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamGameServerNetworking
    {
        public static ISteamNetworking.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamGameServerNetworking_v006", CallingConvention = Platform.CC)]
        private static extern ISteamNetworking.Instance Accessor();
        /// <summary></summary>
        public static bool SendP2PPacket(SteamId steamIDRemote, void* pubData, uint cubData, P2PSend eP2PSendType, int nChannel) => Instance.SendP2PPacket(steamIDRemote, pubData, cubData, eP2PSendType, nChannel);
        /// <summary></summary>
        public static bool IsP2PPacketAvailable(uint* pcubMsgSize, int nChannel) => Instance.IsP2PPacketAvailable(pcubMsgSize, nChannel);
        /// <summary></summary>
        public static bool ReadP2PPacket(void* pubDest, uint cubDest, uint* pcubMsgSize, SteamId* psteamIDRemote, int nChannel) => Instance.ReadP2PPacket(pubDest, cubDest, pcubMsgSize, psteamIDRemote, nChannel);
        /// <summary></summary>
        public static bool AcceptP2PSessionWithUser(SteamId steamIDRemote) => Instance.AcceptP2PSessionWithUser(steamIDRemote);
        /// <summary></summary>
        public static bool CloseP2PSessionWithUser(SteamId steamIDRemote) => Instance.CloseP2PSessionWithUser(steamIDRemote);
        /// <summary></summary>
        public static bool CloseP2PChannelWithUser(SteamId steamIDRemote, int nChannel) => Instance.CloseP2PChannelWithUser(steamIDRemote, nChannel);
        /// <summary></summary>
        public static bool GetP2PSessionState(SteamId steamIDRemote, P2PSessionState* pConnectionState) => Instance.GetP2PSessionState(steamIDRemote, pConnectionState);
        /// <summary></summary>
        public static bool AllowP2PPacketRelay(bool bAllow) => Instance.AllowP2PPacketRelay(bAllow);
        /// <summary></summary>
        public static SNetListenSocket CreateListenSocket(int nVirtualP2PPort, SteamIPAddress nIP, ushort nPort, bool bAllowUseOfPacketRelay) => Instance.CreateListenSocket(nVirtualP2PPort, nIP, nPort, bAllowUseOfPacketRelay);
        /// <summary></summary>
        public static SNetSocket CreateP2PConnectionSocket(SteamId steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay) => Instance.CreateP2PConnectionSocket(steamIDTarget, nVirtualPort, nTimeoutSec, bAllowUseOfPacketRelay);
        /// <summary></summary>
        public static SNetSocket CreateConnectionSocket(SteamIPAddress nIP, ushort nPort, int nTimeoutSec) => Instance.CreateConnectionSocket(nIP, nPort, nTimeoutSec);
        /// <summary></summary>
        public static bool DestroySocket(SNetSocket hSocket, bool bNotifyRemoteEnd) => Instance.DestroySocket(hSocket, bNotifyRemoteEnd);
        /// <summary></summary>
        public static bool DestroyListenSocket(SNetListenSocket hSocket, bool bNotifyRemoteEnd) => Instance.DestroyListenSocket(hSocket, bNotifyRemoteEnd);
        /// <summary></summary>
        public static bool SendDataOnSocket(SNetSocket hSocket, void* pubData, uint cubData, bool bReliable) => Instance.SendDataOnSocket(hSocket, pubData, cubData, bReliable);
        /// <summary></summary>
        public static bool IsDataAvailableOnSocket(SNetSocket hSocket, uint* pcubMsgSize) => Instance.IsDataAvailableOnSocket(hSocket, pcubMsgSize);
        /// <summary></summary>
        public static bool RetrieveDataFromSocket(SNetSocket hSocket, void* pubDest, uint cubDest, uint* pcubMsgSize) => Instance.RetrieveDataFromSocket(hSocket, pubDest, cubDest, pcubMsgSize);
        /// <summary></summary>
        public static bool IsDataAvailable(SNetListenSocket hListenSocket, uint* pcubMsgSize, SNetSocket* phSocket) => Instance.IsDataAvailable(hListenSocket, pcubMsgSize, phSocket);
        /// <summary></summary>
        public static bool RetrieveData(SNetListenSocket hListenSocket, void* pubDest, uint cubDest, uint* pcubMsgSize, SNetSocket* phSocket) => Instance.RetrieveData(hListenSocket, pubDest, cubDest, pcubMsgSize, phSocket);
        /// <summary></summary>
        public static bool GetSocketInfo(SNetSocket hSocket, SteamId* pSteamIDRemote, int* peSocketStatus, SteamIPAddress* punIPRemote, ushort* punPortRemote) => Instance.GetSocketInfo(hSocket, pSteamIDRemote, peSocketStatus, punIPRemote, punPortRemote);
        /// <summary></summary>
        public static bool GetListenSocketInfo(SNetListenSocket hListenSocket, SteamIPAddress* pnIP, ushort* pnPort) => Instance.GetListenSocketInfo(hListenSocket, pnIP, pnPort);
        /// <summary></summary>
        public static SNetSocketConnectionType GetSocketConnectionType(SNetSocket hSocket) => Instance.GetSocketConnectionType(hSocket);
        /// <summary></summary>
        public static int GetMaxPacketSize(SNetSocket hSocket) => Instance.GetMaxPacketSize(hSocket);
    }
}