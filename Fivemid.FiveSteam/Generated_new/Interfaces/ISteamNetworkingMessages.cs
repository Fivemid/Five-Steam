using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ISteamNetworkingMessages</summary>
    public unsafe interface ISteamNetworkingMessages
    {
        public Result SendMessageToUser(ref SteamNetworkingIdentity identityRemote, void* pubData, uint cubData, int nSendFlags, int nRemoteChannel);
        public int ReceiveMessagesOnChannel(int nLocalChannel, SteamNetworkingMessage** ppOutMessages, int nMaxMessages);
        public bool AcceptSessionWithUser(ref SteamNetworkingIdentity identityRemote);
        public bool CloseSessionWithUser(ref SteamNetworkingIdentity identityRemote);
        public bool CloseChannelWithUser(ref SteamNetworkingIdentity identityRemote, int nLocalChannel);
        public SteamNetworkingConnectionState GetSessionConnectionInfo(ref SteamNetworkingIdentity identityRemote, SteamNetConnectionInfo* pConnectionInfo, SteamNetConnectionRealTimeStatus* pQuickStatus);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingMessages_SendMessageToUser", CallingConvention = Platform.CC)]
        internal static extern Result SendMessageToUser(void* self, ref SteamNetworkingIdentity identityRemote, void* pubData, uint cubData, int nSendFlags, int nRemoteChannel);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingMessages_ReceiveMessagesOnChannel", CallingConvention = Platform.CC)]
        internal static extern int ReceiveMessagesOnChannel(void* self, int nLocalChannel, SteamNetworkingMessage** ppOutMessages, int nMaxMessages);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingMessages_AcceptSessionWithUser", CallingConvention = Platform.CC)]
        internal static extern bool AcceptSessionWithUser(void* self, ref SteamNetworkingIdentity identityRemote);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingMessages_CloseSessionWithUser", CallingConvention = Platform.CC)]
        internal static extern bool CloseSessionWithUser(void* self, ref SteamNetworkingIdentity identityRemote);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingMessages_CloseChannelWithUser", CallingConvention = Platform.CC)]
        internal static extern bool CloseChannelWithUser(void* self, ref SteamNetworkingIdentity identityRemote, int nLocalChannel);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_ISteamNetworkingMessages_GetSessionConnectionInfo", CallingConvention = Platform.CC)]
        internal static extern SteamNetworkingConnectionState GetSessionConnectionInfo(void* self, ref SteamNetworkingIdentity identityRemote, SteamNetConnectionInfo* pConnectionInfo, SteamNetConnectionRealTimeStatus* pQuickStatus);
        public struct Instance : ISteamNetworkingMessages
        {
            public void* self;
            public Result SendMessageToUser(ref SteamNetworkingIdentity identityRemote, void* pubData, uint cubData, int nSendFlags, int nRemoteChannel) => ISteamNetworkingMessages.SendMessageToUser(self, ref identityRemote, pubData, cubData, nSendFlags, nRemoteChannel);
            public int ReceiveMessagesOnChannel(int nLocalChannel, SteamNetworkingMessage** ppOutMessages, int nMaxMessages) => ISteamNetworkingMessages.ReceiveMessagesOnChannel(self, nLocalChannel, ppOutMessages, nMaxMessages);
            public bool AcceptSessionWithUser(ref SteamNetworkingIdentity identityRemote) => ISteamNetworkingMessages.AcceptSessionWithUser(self, ref identityRemote);
            public bool CloseSessionWithUser(ref SteamNetworkingIdentity identityRemote) => ISteamNetworkingMessages.CloseSessionWithUser(self, ref identityRemote);
            public bool CloseChannelWithUser(ref SteamNetworkingIdentity identityRemote, int nLocalChannel) => ISteamNetworkingMessages.CloseChannelWithUser(self, ref identityRemote, nLocalChannel);
            public SteamNetworkingConnectionState GetSessionConnectionInfo(ref SteamNetworkingIdentity identityRemote, SteamNetConnectionInfo* pConnectionInfo, SteamNetConnectionRealTimeStatus* pQuickStatus) => ISteamNetworkingMessages.GetSessionConnectionInfo(self, ref identityRemote, pConnectionInfo, pQuickStatus);
        }
    }
}