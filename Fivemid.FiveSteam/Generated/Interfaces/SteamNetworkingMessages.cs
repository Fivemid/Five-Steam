using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamNetworkingMessages
    {
        public static ISteamNetworkingMessages.Instance Instance => Accessor();

        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_SteamNetworkingMessages_SteamAPI_v002", CallingConvention = Platform.CC)]
        private static extern ISteamNetworkingMessages.Instance Accessor();
        /// <summary><code>EResult SendMessageToUser( const SteamNetworkingIdentity &amp;identityRemote, const void *pubData, uint32 cubData, int nSendFlags, int nRemoteChannel );</code><br />
        /// Sends a message to the specified host.  If we don't already have a session with that user, a session is implicitly created.  There might be some handshaking that needs to happen before we can actually begin sending message data.  If this handshaking fails and we can't get through, an error will be posted via the callback <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingMessages#SteamNetworkingMessagesSessionFailed_t" class="bb_apilink">SteamNetworkingMessagesSessionFailed_t</a>. <br />
        ///  There is no notification when the operation succeeds.  (You should have the peer send a reply for this purpose.)<br />
        /// <br />
        /// Sending a message to a host will also implicitly accept any incoming connection from that host.<br />
        /// <br />
        /// nSendFlags is a bitmask of <a href="https://partner.steamgames.com/doc/api/steamnetworkingtypes#message_sending_flags" class="bb_doclink">k_nSteamNetworkingSend_xxx</a> options<br />
        /// <br />
        /// nRemoteChannel is a routing number you can use to help route message to different systems. <br />
        /// You'll have to call <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingMessages#ReceiveMessagesOnChannel" class="bb_apilink">ISteamNetworkingMessages::ReceiveMessagesOnChannel</a> with the same channel number in order to retrieve the data on the other end.<br />
        /// <br />
        /// Using different channels to talk to the same user will still use the same underlying connection, saving on resources.  If you don't need this feature, use 0.  Otherwise, small integers are the most efficient.<br />
        /// <br />
        /// It is guaranteed that reliable messages to the same host on the same channel will be be received by the remote host (if they are received at all) exactly once, and in the same order that they were sent.<br />
        /// <br />
        /// NO other order guarantees exist!  In particular, unreliable messages may be dropped, received out of order with respect to each other and with respect to reliable data, or may be received multiple times.  Messages on different channels are *not* guaranteed to be received in the order they were sent.<br />
        /// <br />
        /// A note for those familiar with TCP/IP ports, or converting an existing codebase that opened multiple sockets:  You might notice that there is only one channel, and with TCP/IP each endpoint has a port number.  You can think of the channel number as the <i>destination</i> port.  If you need each message to also include a <i>source port</i> (so the recipient can route the reply), then just put that in your message.  That is essentially how UDP works!<br />
        /// <br />
        /// Returns:<br />
        /// <ul class="bb_ul "><li> k_EREsultOK on success.<br />
        /// </li><li> k_EResultNoConnection, if the session has failed or was closed by the peer and k_nSteamNetworkingSend_AutoRestartBrokenSession was not specified.  (You can<br />
        /// use <a href="https://partner.steamgames.com/doc/api/GetSessionConnectionInfo" class="bb_apilink">GetSessionConnectionInfo</a> to get the details.)  In order to acknowledge the broken session and start a new one, you must call <a href="https://partner.steamgames.com/doc/api/CloseSessionWithUser" class="bb_apilink">CloseSessionWithUser</a>, or you may repeat the call with k_nSteamNetworkingSend_AutoRestartBrokenSession.  See k_nSteamNetworkingSend_AutoRestartBrokenSession for more details.<br />
        /// </li><li> k_EResultNoConnection will be returned if the session has failed or was closed by the peer, and k_nSteamNetworkingSend_AutoRestartBrokenSession is not used.  (You can use <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingMessages#GetSessionConnectionInfo" class="bb_apilink">ISteamNetworkingMessages::GetSessionConnectionInfo</a> to get the details.)  In order to acknowledge the broken session and start a new one, you must call <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingMessages#CloseSessionWithUser" class="bb_apilink">ISteamNetworkingMessages::CloseSessionWithUser</a><br />
        /// </li><li> See <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingSockets#SendMessageToConnection" class="bb_apilink">ISteamNetworkingSockets::SendMessageToConnection</a> for more possible return values.</li></ul></summary>
        /// 
        public static Result SendMessageToUser(ref SteamNetworkingIdentity identityRemote, void* pubData, uint cubData, int nSendFlags, int nRemoteChannel) => Instance.SendMessageToUser(ref identityRemote, pubData, cubData, nSendFlags, nRemoteChannel);
        /// <summary><code>int ReceiveMessagesOnChannel( int nLocalChannel, SteamNetworkingMessage_t **ppOutMessages, int nMaxMessages );</code><br />
        /// Reads the next message that has been sent from another user via SendMessageToUser() on the given channel.  Returns number of messages returned into your list.  (0 if no message are available on that channel.)<br />
        /// <br />
        /// When you're done with the message object(s), make sure and call SteamNetworkingMessage_t::Release!</summary>
        /// 
        public static int ReceiveMessagesOnChannel(int nLocalChannel, SteamNetworkingMessage** ppOutMessages, int nMaxMessages) => Instance.ReceiveMessagesOnChannel(nLocalChannel, ppOutMessages, nMaxMessages);
        /// <summary><code>bool AcceptSessionWithUser( const SteamNetworkingIdentity &amp;identityRemote );</code><br />
        /// Call this in response to a <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingMessages#SteamNetworkingMessagesSessionRequest_t" class="bb_apilink">SteamNetworkingMessagesSessionRequest_t</a> callback.<br />
        /// SteamNetworkingMessagesSessionRequest_t are posted when a user tries to send you a message, and you haven't tried to talk to them first.  If you don't want to talk to them, just ignore the request.  If the user continues to send you messages, SteamNetworkingMessagesSessionRequest_t callbacks will continue to be posted periodically.<br />
        /// <br />
        /// Returns false if there is no session with the user pending or otherwise.  If there is an existing active session, this function will return true, even if it is not pending.<br />
        /// <br />
        /// Calling <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingMessages#SendMessageToUser" class="bb_apilink">ISteamNetworkingMessages::SendMessageToUser</a> will implicitly accepts any pending session request to that user.</summary>
        /// 
        public static bool AcceptSessionWithUser(ref SteamNetworkingIdentity identityRemote) => Instance.AcceptSessionWithUser(ref identityRemote);
        /// <summary><code>bool CloseSessionWithUser( const SteamNetworkingIdentity &amp;identityRemote );</code><br />
        /// <br />
        /// Call this when you're done talking to a user to immediately free up resources under-the-hood.  If the remote user tries to send data to you again, another <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingMessages#SteamNetworkingMessagesSessionRequest_t" class="bb_apilink">SteamNetworkingMessagesSessionRequest_t</a> callback will be posted.<br />
        /// <br />
        /// Note that sessions that go unused for a few minutes are automatically timed out.</summary>
        /// 
        public static bool CloseSessionWithUser(ref SteamNetworkingIdentity identityRemote) => Instance.CloseSessionWithUser(ref identityRemote);
        /// <summary><code>bool CloseChannelWithUser( const SteamNetworkingIdentity &amp;identityRemote, int nLocalChannel );</code><br />
        /// Call this  when you're done talking to a user on a specific channel.  Once all open channels to a user have been closed, the open session to the user will be closed, and any new data from this user will trigger a <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingMessages#SteamNetworkingMessagesSessionRequest_t" class="bb_apilink">SteamNetworkingMessagesSessionRequest_t</a><br />
        /// callback</summary>
        /// 
        public static bool CloseChannelWithUser(ref SteamNetworkingIdentity identityRemote, int nLocalChannel) => Instance.CloseChannelWithUser(ref identityRemote, nLocalChannel);
        /// <summary><code>ESteamNetworkingConnectionState GetSessionConnectionInfo( const SteamNetworkingIdentity &amp;identityRemote, SteamNetConnectionInfo_t *pConnectionInfo, SteamNetConnectionRealTimeStatus_t *pQuickStatus );</code><br />
        /// Returns information about the latest state of a connection, if any, with the given peer.  Primarily intended for debugging purposes, but can also be used to get more detailed failure information.<br />
        /// (See <a href="https://partner.steamgames.com/doc/api/ISteamnetworkingMessages#SendMessageToUser" class="bb_apilink">ISteamnetworkingMessages::SendMessageToUser</a> and k_nSteamNetworkingSend_AutoRestartBrokenSession.)<br />
        /// <br />
        /// Returns the value of <a href="https://partner.steamgames.com/doc/api/steamnetworkingtyupes#SteamNetConnectionInfo_t" class="bb_apilink">SteamNetConnectionInfo_t</a>::m_eState, or k_ESteamNetworkingConnectionState_None if no connection exists with specified peer.  You may pass nullptr for either parameter if you do not need the corresponding details.  Note that sessions time out after a while, so if a connection fails, or <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingMessages#SendMessageToUser" class="bb_apilink">ISteamNetworkingMessages::SendMessageToUser</a> returns k_EResultNoConnection, you cannot wait indefinitely to obtain the reason for failure.</summary>
        /// 
        public static SteamNetworkingConnectionState GetSessionConnectionInfo(ref SteamNetworkingIdentity identityRemote, SteamNetConnectionInfo* pConnectionInfo, SteamNetConnectionRealTimeStatus* pQuickStatus) => Instance.GetSessionConnectionInfo(ref identityRemote, pConnectionInfo, pQuickStatus);
    }
}