using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamGameServerNetworkingMessages_SteamAPI
    {
        public static ISteamNetworkingMessages.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamGameServerNetworkingMessages_SteamAPI_v002", CallingConvention = Platform.CC)]
        private static extern ISteamNetworkingMessages.Instance Accessor();
        /// <summary></summary>
        public static Result SendMessageToUser(ref SteamNetworkingIdentity identityRemote, void* pubData, uint cubData, int nSendFlags, int nRemoteChannel) => Instance.SendMessageToUser(ref identityRemote, pubData, cubData, nSendFlags, nRemoteChannel);
        /// <summary></summary>
        public static int ReceiveMessagesOnChannel(int nLocalChannel, SteamNetworkingMessage** ppOutMessages, int nMaxMessages) => Instance.ReceiveMessagesOnChannel(nLocalChannel, ppOutMessages, nMaxMessages);
        /// <summary></summary>
        public static bool AcceptSessionWithUser(ref SteamNetworkingIdentity identityRemote) => Instance.AcceptSessionWithUser(ref identityRemote);
        /// <summary></summary>
        public static bool CloseSessionWithUser(ref SteamNetworkingIdentity identityRemote) => Instance.CloseSessionWithUser(ref identityRemote);
        /// <summary></summary>
        public static bool CloseChannelWithUser(ref SteamNetworkingIdentity identityRemote, int nLocalChannel) => Instance.CloseChannelWithUser(ref identityRemote, nLocalChannel);
        /// <summary></summary>
        public static SteamNetworkingConnectionState GetSessionConnectionInfo(ref SteamNetworkingIdentity identityRemote, SteamNetConnectionInfo* pConnectionInfo, SteamNetConnectionRealTimeStatus* pQuickStatus) => Instance.GetSessionConnectionInfo(ref identityRemote, pConnectionInfo, pQuickStatus);
    }
}