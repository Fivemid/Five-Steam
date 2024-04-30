using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Networking API intended to make it easy to port non-connection-oriented code to take advantage of P2P connectivity and <a href="https://partner.steamgames.com/doc/features/multiplayer/steamdatagramrelay" class="bb_doclink">Steam Datagram Relay</a>. <br />
    /// <br />
    /// <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingSockets" class="bb_apilink">ISteamNetworkingSockets</a> is connection-oriented (like TCP), meaning you need to listen and connect, and then you send messages using a connection handle.  ISteamNetworkingMessages, on the other hand, is more like UDP, in that you can just send messages to arbitrary peers at any time.  The underlying connections are established implicitly.<br />
    /// <br />
    /// Under the hood ISteamNetworkingMessages works on top of the <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingSockets" class="bb_apilink">ISteamNetworkingSockets</a> code, so you get the same routing and messaging efficiency.  The difference is mainly in your responsibility to explicitly establish a connection and the type of feedback you get about the state of the connection.  Both interfaces can do "P2P" communications, both support both unreliable and reliable messages, fragmentation and reassembly, and both can be used to take advantage of <a href="https://partner.steamgames.com/doc/features/multiplayer/steamdatagramrelay" class="bb_doclink">Steam Datagram Relay</a> to talk to dedicated servers.<br />
    /// <br />
    /// The primary purpose of this interface is to be "like UDP", so that UDP-based code can be ported easily to take advantage of relayed connections.  If you find yourself needing more low level information or control, or to be able to better handle failure, then you probably need to use <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingSockets" class="bb_apilink">ISteamNetworkingSockets</a> directly.  Also, note that if your main goal is to obtain a connection between two peers without concerning yourself with assigning roles of "client" and "server", you may find the symmetric connection mode of ISteamNetworkingSockets useful.<br />
    /// (See k_ESteamNetworkingConfig_SymmetricConnect.)<br />
    /// <br />
    /// Member functions for ISteamNetworkingMessages are called through the global accessor function SteamNetworkingMessages().</summary>
    public unsafe interface ISteamNetworkingMessages
    {
        public Result SendMessageToUser(ref SteamNetworkingIdentity identityRemote, void* pubData, uint cubData, int nSendFlags, int nRemoteChannel);
        public int ReceiveMessagesOnChannel(int nLocalChannel, SteamNetworkingMessage** ppOutMessages, int nMaxMessages);
        public bool AcceptSessionWithUser(ref SteamNetworkingIdentity identityRemote);
        public bool CloseSessionWithUser(ref SteamNetworkingIdentity identityRemote);
        public bool CloseChannelWithUser(ref SteamNetworkingIdentity identityRemote, int nLocalChannel);
        public SteamNetworkingConnectionState GetSessionConnectionInfo(ref SteamNetworkingIdentity identityRemote, SteamNetConnectionInfo* pConnectionInfo, SteamNetConnectionRealTimeStatus* pQuickStatus);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingMessages_SendMessageToUser", CallingConvention = Platform.CC)]
        internal static extern Result SendMessageToUser(void* self, ref SteamNetworkingIdentity identityRemote, void* pubData, uint cubData, int nSendFlags, int nRemoteChannel);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingMessages_ReceiveMessagesOnChannel", CallingConvention = Platform.CC)]
        internal static extern int ReceiveMessagesOnChannel(void* self, int nLocalChannel, SteamNetworkingMessage** ppOutMessages, int nMaxMessages);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingMessages_AcceptSessionWithUser", CallingConvention = Platform.CC)]
        internal static extern bool AcceptSessionWithUser(void* self, ref SteamNetworkingIdentity identityRemote);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingMessages_CloseSessionWithUser", CallingConvention = Platform.CC)]
        internal static extern bool CloseSessionWithUser(void* self, ref SteamNetworkingIdentity identityRemote);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingMessages_CloseChannelWithUser", CallingConvention = Platform.CC)]
        internal static extern bool CloseChannelWithUser(void* self, ref SteamNetworkingIdentity identityRemote, int nLocalChannel);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamNetworkingMessages_GetSessionConnectionInfo", CallingConvention = Platform.CC)]
        internal static extern SteamNetworkingConnectionState GetSessionConnectionInfo(void* self, ref SteamNetworkingIdentity identityRemote, SteamNetConnectionInfo* pConnectionInfo, SteamNetConnectionRealTimeStatus* pQuickStatus);
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
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