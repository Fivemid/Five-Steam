using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamGameServerNetworkingSockets
    {
        public static ISteamNetworkingSockets.Instance Instance => Accessor();

        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_SteamGameServerNetworkingSockets_SteamAPI_v012", CallingConvention = Platform.CC)]
        private static extern ISteamNetworkingSockets.Instance Accessor();
        /// <summary><code>HSteamListenSocket CreateListenSocketIP( const SteamNetworkingIPAddr &amp;localAddress, int nOptions, const SteamNetworkingConfigValue_t *pOptions );</code><br />
        /// Creates a "server" socket that listens for clients to connect to by calling <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingSockets#ConnectByIPAddress" class="bb_apilink">ISteamNetworkingSockets::ConnectByIPAddress</a>, over ordinary UDP (IPv4 or IPv6)<br />
        /// <br />
        /// You must select a specific local port to listen on and set it as the port field of the local address.<br />
        /// <br />
        /// Usually you will set the IP portion of the address to zero, (<a href="https://partner.steamgames.com/doc/api/steamnetworkingtypes#SteamNetworkingIPAddr" class="bb_apilink">SteamNetworkingIPAddr</a>::Clear()).  This means that you will not bind to any particular local interface (i.e. the same as INADDR_ANY in plain socket code).  Furthermore, if possible the socket will be bound in "dual stack" mode, which means that it can accept both IPv4 and IPv6 client connections.  If you really do wish to bind a particular interface, then set the local address to the appropriate IPv4 or IPv6 IP.<br />
        /// <br />
        /// If you need to set any initial config options, pass them here.  See <a href="https://partner.steamgames.com/doc/api/steamnetworkingtypes#SteamNetworkingConfigValue_t" class="bb_apilink">SteamNetworkingConfigValue_t</a> for more about why this is preferable to setting the options "immediately" after creation.<br />
        /// <br />
        /// When a client attempts to connect, a <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingSockets#SteamNetConnectionStatusChangedCallback_t" class="bb_apilink">SteamNetConnectionStatusChangedCallback_t</a> will be posted.  The connection will be in the k_ESteamNetworkingConnectionState_Connecting  state.</summary>
        /// 
        public static HSteamListenSocket CreateListenSocketIP(ref SteamNetworkingIPAddr localAddress, int nOptions, SteamNetworkingConfigValue* pOptions) => Instance.CreateListenSocketIP(ref localAddress, nOptions, pOptions);
        /// <summary><code>HSteamNetConnection ConnectByIPAddress( const SteamNetworkingIPAddr &amp;address, int nOptions, const SteamNetworkingConfigValue_t *pOptions );</code><br />
        /// Creates a connection and begins talking to a "server" over UDP at the given IPv4 or IPv6 address.  The remote host must be listening with a matching call to <a href="https://partner.steamgames.com/doc/api/ISteamnetworkingSockets#CreateListenSocketIP" class="bb_apilink">ISteamnetworkingSockets::CreateListenSocketIP</a> on the specified port.<br />
        /// <br />
        /// A <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingSockets#SteamNetConnectionStatusChangedCallback_t" class="bb_apilink">SteamNetConnectionStatusChangedCallback_t</a> callback will be triggered when we start connecting, and then another one on either timeout or successful connection.<br />
        /// <br />
        /// If the server does not have any identity configured, then their network address will be the only identity in use.  Or, the network host may provide a platform-specific identity with or without a valid certificate to authenticate that identity.  (These details will be contained in the <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingSockets#SteamNetConnectionStatusChangedCallback_t" class="bb_apilink">SteamNetConnectionStatusChangedCallback_t</a>.)  It's up to your application to decide whether to allow the connection.<br />
        /// <br />
        /// If you need to set any initial config options, pass them here.  See <a href="https://partner.steamgames.com/doc/api/steamnetworkingtypes#SteamNetworkingConfigValue_t" class="bb_apilink">SteamNetworkingConfigValue_t</a> for more about why this is preferable to setting the options "immediately" after creation.</summary>
        /// 
        public static HSteamNetConnection ConnectByIPAddress(ref SteamNetworkingIPAddr address, int nOptions, SteamNetworkingConfigValue* pOptions) => Instance.ConnectByIPAddress(ref address, nOptions, pOptions);
        /// <summary><code>HSteamListenSocket CreateListenSocketP2P( int nLocalVirtualPort, int nOptions, const SteamNetworkingConfigValue_t *pOptions );</code><br />
        /// Like <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingSockets#CreateListenSocketIP" class="bb_apilink">ISteamNetworkingSockets::CreateListenSocketIP</a>, but clients will connect using <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingSockets#ConnectP2P" class="bb_apilink">ISteamNetworkingSockets::ConnectP2P</a>.  The connection will be relayed through the Valve network.<br />
        /// <br />
        /// nLocalVirtualPort specifies how clients can connect to this socket using <a href="https://partner.steamgames.com/doc/api/ConnectP2P" class="bb_apilink">ConnectP2P</a>.  It's very common for applications to only have one listening socket; in that case, use zero.  If you need to open multiple listen sockets and have clients be able to connect to one or the other, then nLocalVirtualPort should be a small integer (&lt;1000) unique to each listen socket you create.<br />
        /// <br />
        /// If you are listening on a dedicated servers in known data center, then you can listen using this function instead of <a href="https://partner.steamgames.com/doc/api/CreateHostedDedicatedServerListenSocket" class="bb_apilink">CreateHostedDedicatedServerListenSocket</a>, to allow clients to connect without a ticket.  Any user that owns the app and is signed into Steam will be able to attempt to connect to your server.  Also, a connection attempt may require the client to be connected to Steam, which is one more moving part that may fail.  When tickets are used, then once a ticket is obtained, a client can connect to your server even if they got disconnected from Steam or Steam is offline.<br />
        /// <br />
        /// If you use this, you probably want to call <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingUtils#InitRelayNetworkAccess" class="bb_apilink">ISteamNetworkingUtils::InitRelayNetworkAccess</a> when your app initializes.<br />
        /// <br />
        /// If you need to set any initial config options, pass them here.  See <a href="https://partner.steamgames.com/doc/api/steamnetworkingtypes#SteamNetworkingConfigValue_t" class="bb_apilink">SteamNetworkingConfigValue_t</a> for more about why this is preferable to setting the options "immediately" after creation.</summary>
        /// 
        public static HSteamListenSocket CreateListenSocketP2P(int nLocalVirtualPort, int nOptions, SteamNetworkingConfigValue* pOptions) => Instance.CreateListenSocketP2P(nLocalVirtualPort, nOptions, pOptions);
        /// <summary><code>HSteamNetConnection ConnectP2P( const SteamNetworkingIdentity &amp;identityRemote, int nRemoteVirtualPort, int nOptions, const SteamNetworkingConfigValue_t *pOptions );</code>Begin connecting to a peer that is identified using a platform-specific identifier.  This uses the default rendezvous service, which depends on the platform and library configuration.  (E.g. on Steam, it goes through the steam backend.)  The traffic is relayed over the Steam Datagram Relay network.<br />
        /// <br />
        /// If you use this, you probably want to call <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingUtils#InitRelayNetworkAccess" class="bb_apilink">ISteamNetworkingUtils::InitRelayNetworkAccess</a> when your app initializes.<br />
        /// <br />
        /// If you need to set any initial config options, pass them here.  See <a href="https://partner.steamgames.com/doc/api/steamnetworkingtypes#SteamNetworkingConfigValue_t" class="bb_apilink">SteamNetworkingConfigValue_t</a> for more about why this is preferable to setting the options "immediately" after creation.</summary>
        /// 
        public static HSteamNetConnection ConnectP2P(ref SteamNetworkingIdentity identityRemote, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue* pOptions) => Instance.ConnectP2P(ref identityRemote, nRemoteVirtualPort, nOptions, pOptions);
        /// <summary><code>EResult AcceptConnection( HSteamNetConnection hConn );</code><br />
        /// Accept an incoming connection that has been received on a listen socket.<br />
        /// <br />
        /// When a connection attempt is received (perhaps after a few basic handshake packets have been exchanged to prevent trivial spoofing), a connection interface object is created in the k_ESteamNetworkingConnectionState_Connecting state and a <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingSockets#SteamNetConnectionStatusChangedCallback_t" class="bb_apilink">SteamNetConnectionStatusChangedCallback_t</a> is posted.  At this point, your application MUST either accept or close the connection.  (It may not ignore it.) Accepting the connection will transition it either into the connected state, or the finding route state, depending on the connection type.<br />
        /// <br />
        /// You should take action within a second or two, because accepting the connection is what actually sends the reply notifying the client that they are connected.  If you delay taking action, from the client's perspective it is the same as the network being unresponsive, and the client may timeout the connection attempt.  In other words, the client cannot distinguish between a delay caused by network problems and a delay caused by the application.<br />
        /// <br />
        /// This means that if your application goes for more than a few seconds without processing callbacks (for example, while loading a map), then there is a chance that a client may attempt to connect in that interval and fail due to timeout.<br />
        /// <br />
        /// If the application does not respond to the connection attempt in a timely manner, and we stop receiving communication from the client, the connection attempt will<br />
        /// be timed out locally, transitioning the connection to the k_ESteamNetworkingConnectionState_ProblemDetectedLocally state.  The client may also close the connection before it is accepted, and a transition to the k_ESteamNetworkingConnectionState_ClosedByPeer is also possible depending the exact sequence of events.<br />
        /// <br />
        /// Returns:<br />
        /// <ul class="bb_ul "><li> k_EResultInvalidParam if the handle is invalid.<br />
        /// </li><li> k_EResultInvalidState if the connection is not in the appropriate state. (Remember that the connection state could change in between the time that the notification being posted to the queue and when it is received by the application.)</li></ul><br />
        /// A note about connection configuration options.  If you need to set any configuration options that are common to all connections accepted through a particular listen socket, consider setting the options on the listen socket, since such options are inherited automatically.  If you really do need to set options that are connection specific, it is safe to set them on the connection before accepting the connection.</summary>
        /// 
        public static Result AcceptConnection(HSteamNetConnection hConn) => Instance.AcceptConnection(hConn);
        /// <summary><code>bool CloseConnection( HSteamNetConnection hPeer, int nReason, const char *pszDebug, bool bEnableLinger );</code><br />
        /// Disconnects from the remote host and invalidates the connection handle.  Any unread data on the connection is discarded.<br />
        /// <br />
        /// nReason is an application defined code that will be received on the other end and recorded (when possible) in backend analytics.  The value should come from a restricted range.  (See <a href="https://partner.steamgames.com/doc/api/steamnetworkingtypes#ESteamNetConnectionEnd" class="bb_apilink">ESteamNetConnectionEnd</a>.)  If you don't need to communicate any information to the remote host, and do not want analytics to be able to distinguish "normal" connection terminations from "exceptional" ones, you may pass zero, in which case the generic value of k_ESteamNetConnectionEnd_App_Generic will be used.<br />
        /// <br />
        /// pszDebug is an optional human-readable diagnostic string that will be received by the remote host and recorded (when possible) in backend analytics.<br />
        /// <br />
        /// Optionally, you may put the socket into a "linger" state, which causes the connection to attempt is deliver any remaining outbound reliable messages before actually closing the connection.  Otherwise any unsent reliable data is discarded.  In any case, once you close the connection you will have no further visibility into the status of the connection or any messages.  (In some uses cases, this is acceptable.  If not, then you need to wait to close the connection.)  Remember that this is an application protocol, not a kernel protocol like TCP.  So you need to make sure the application stays running long enough for the data to be flushed out.<br />
        /// <br />
        /// If the connection has already ended (k_ESteamNetworkingConnectionState_ClosedByPeer or k_ESteamNetworkingConnectionState_ProblemDetectedLocally) and you are just freeing up the connection object, then nReason, pszDebug , and bEnableLinger are ignored.</summary>
        /// 
        public static bool CloseConnection(HSteamNetConnection hPeer, int nReason, UTF8StringPtr pszDebug, bool bEnableLinger) => Instance.CloseConnection(hPeer, nReason, pszDebug, bEnableLinger);
        /// <summary><code>bool CloseListenSocket( HSteamListenSocket hSocket );</code><br />
        /// Destroy a listen socket.  All the connections that were accepted on the listen socket are closed ungracefully.</summary>
        /// 
        public static bool CloseListenSocket(HSteamListenSocket hSocket) => Instance.CloseListenSocket(hSocket);
        /// <summary><code>bool SetConnectionUserData( HSteamNetConnection hPeer, int64 nUserData );</code><br />
        /// Set connection user data.  The data is used in the following places:<br />
        /// <ul class="bb_ul "><li> You can query it using <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingSockets#GetConnectionUserData" class="bb_apilink">ISteamNetworkingSockets::GetConnectionUserData</a>.<br />
        /// </li><li> The <a href="https://partner.steamgames.com/doc/api/steamnetworkingtypes#SteamNetworkingMessage_t" class="bb_apilink">SteamNetworkingMessage_t</a> structure.<br />
        /// </li><li> The <a href="https://partner.steamgames.com/doc/api/steamnetworkingtypes#SteamNetConnectionInfo_t" class="bb_apilink">SteamNetConnectionInfo_t</a> structure.  (Which is a member of <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingSockets#SteamNetConnectionStatusChangedCallback_t" class="bb_apilink">SteamNetConnectionStatusChangedCallback_t</a>.)</li></ul><br />
        /// Do you need to set this atomically when the connection is created?  See k_ESteamNetworkingConfig_ConnectionUserData.<br />
        /// <br />
        /// WARNING: Be *very careful* when using the value provided in callbacks structs.  Callbacks are queued, and the value that you will receive in your callback is the userdata that was effective at the time the callback was queued.  There are subtle race conditions that can happen if you<br />
        /// don't understand this!<br />
        /// <br />
        /// If any incoming messages for this connection are queued, the userdata field is updated, so that when when you receive messages (e.g. with ReceiveMessagesOnConnection), they will always have the very latest userdata.  So the tricky race conditions that can happen with callbacks do not apply to retrieving messages.<br />
        /// <br />
        /// Returns false if the handle is invalid.</summary>
        /// 
        public static bool SetConnectionUserData(HSteamNetConnection hPeer, long nUserData) => Instance.SetConnectionUserData(hPeer, nUserData);
        /// <summary><code>int64 GetConnectionUserData( HSteamNetConnection hPeer );</code>Fetch connection user data.  Returns -1 if handle is invalid or if you haven't set any userdata on the connection.</summary>
        /// 
        public static long GetConnectionUserData(HSteamNetConnection hPeer) => Instance.GetConnectionUserData(hPeer);
        /// <summary><code>void SetConnectionName( HSteamNetConnection hPeer, const char *pszName );</code>Set a name for the connection, used mostly for debugging</summary>
        /// 
        public static void SetConnectionName(HSteamNetConnection hPeer, UTF8StringPtr pszName) => Instance.SetConnectionName(hPeer, pszName);
        /// <summary><code>bool GetConnectionName( HSteamNetConnection hPeer, char *pszName, int nMaxLen );</code>Fetch connection name into your buffer, which is at least nMaxLen bytes.  Returns false if handle is invalid.</summary>
        /// 
        public static bool GetConnectionName(HSteamNetConnection hPeer, byte* pszName, int nMaxLen) => Instance.GetConnectionName(hPeer, pszName, nMaxLen);
        /// <summary><code>EResult SendMessageToConnection( HSteamNetConnection hConn, const void *pData, uint32 cbData, int nSendFlags, int64 *pOutMessageNumber );</code>Send a message to the remote host on the specified connection.<br />
        /// <br />
        /// nSendFlags determines the delivery guarantees that will be provided, when data should be buffered, etc.  E.g.:<br />
        /// <ul class="bb_ul "><li> k_nSteamNetworkingSend_Unreliable<br />
        /// </li><li> k_nSteamNetworkingSend_Reliable<br />
        /// </li><li> k_nSteamNetworkingSend_NoNagle<br />
        /// </li><li> k_nSteamNetworkingSend_NoDelay</li></ul><br />
        /// Note that the semantics we use for messages are not precisely the same as the semantics of a standard "stream" socket.  (SOCK_STREAM)  For an ordinary stream socket, the boundaries between chunks are not considered relevant, and the sizes of the chunks of data written will not necessarily match up to the sizes of the chunks that are returned by the reads on the other end.  The remote host might read a partial chunk, or chunks might be coalesced.  For the message semantics used here, however, the sizes WILL match.  Each send call will match a successful read call on the remote host one-for-one.  If you are porting existing stream-oriented code to the semantics of reliable messages, your code should work the same, since reliable message semantics are more strict than stream semantics.  The only caveat is related to performance: there is per-message overhead to retain the message sizes, and so if your code sends many small chunks of data, performance will suffer. Any code based on stream sockets that does not write excessively small chunks will work without any changes. <br />
        /// <br />
        /// The pOutMessageNumber is an optional pointer to receive the message number assigned to the message, if sending was successful.<br />
        /// <br />
        /// Returns:<br />
        /// <ul class="bb_ul "><li> k_EResultInvalidParam: invalid connection handle, or the individual message is too big. (See k_cbMaxSteamNetworkingSocketsMessageSizeSend)<br />
        /// </li><li> k_EResultInvalidState: connection is in an invalid state<br />
        /// </li><li> k_EResultNoConnection: connection has ended<br />
        /// </li><li> k_EResultIgnored: You used k_nSteamNetworkingSend_NoDelay, and the message was dropped because we were not ready to send it.<br />
        /// </li><li> k_EResultLimitExceeded: there was already too much data queued to be sent. (See k_ESteamNetworkingConfig_SendBufferSize)</li></ul></summary>
        /// 
        public static Result SendMessageToConnection(HSteamNetConnection hConn, void* pData, uint cbData, int nSendFlags, long* pOutMessageNumber) => Instance.SendMessageToConnection(hConn, pData, cbData, nSendFlags, pOutMessageNumber);
        /// <summary><code>void SendMessages( int nMessages, SteamNetworkingMessage_t *const *pMessages, int64 *pOutMessageNumberOrResult );</code>Send one or more messages without copying the message payload.  This is the most efficient way to send messages. To use this function, you must first allocate a message object using <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingUtils#AllocateMessage" class="bb_apilink">ISteamNetworkingUtils::AllocateMessage</a>.  (Do not declare one on the stack or allocate your own.)<br />
        /// <br />
        /// You should fill in the message payload.  You can either let it allocate the buffer for you and then fill in the payload, or if you already have a buffer allocated, you can just point m_pData at your buffer and set the callback to the appropriate function to free it.  Note that if you use your own buffer, it MUST remain valid until the callback is executed.  And also note that your callback can be invoked at any time from any thread (perhaps even before SendMessages returns!), so it MUST be fast and threadsafe.<br />
        /// <br />
        /// You MUST also fill in:<br />
        /// <ul class="bb_ul "><li>m_conn - the handle of the connection to send the message to<br />
        /// </li><li>m_nFlags - bitmask of k_nSteamNetworkingSend_xxx flags.</li></ul><br />
        /// All other fields are currently reserved and should not be modified.<br />
        /// <br />
        /// The library will take ownership of the message structures.  They may be modified or become invalid at any time, so you must not read them after passing them to this function.<br />
        /// <br />
        /// pOutMessageNumberOrResult is an optional array that will receive, for each message, the message number that was assigned to the message if sending was successful.  If sending failed, then a negative EResult value is placed into the array.  For example, the array will hold -k_EResultInvalidState if the connection was in an invalid state.  See <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingSockets#SendMessageToConnection" class="bb_apilink">ISteamNetworkingSockets::SendMessageToConnection</a> for possible failure codes.</summary>
        /// 
        public static void SendMessages(int nMessages, SteamNetworkingMessage** pMessages, long* pOutMessageNumberOrResult) => Instance.SendMessages(nMessages, pMessages, pOutMessageNumberOrResult);
        /// <summary><code>EResult FlushMessagesOnConnection( HSteamNetConnection hConn );</code>Flush any messages waiting on the Nagle timer and send them at the next transmission opportunity (often that means right now).<br />
        /// <br />
        /// If Nagle is enabled (it's on by default) then when calling SendMessageToConnection the message will be buffered, up to the Nagle time before being sent, to merge small messages into the same packet.  (See k_ESteamNetworkingConfig_NagleTime)<br />
        /// <br />
        /// Returns:<br />
        /// <ul class="bb_ul "><li> k_EResultInvalidParam: invalid connection handle<br />
        /// </li><li> k_EResultInvalidState: connection is in an invalid state<br />
        /// </li><li> k_EResultNoConnection: connection has ended<br />
        /// </li><li> k_EResultIgnored: We weren't (yet) connected, so this operation has no effect.</li></ul></summary>
        /// 
        public static Result FlushMessagesOnConnection(HSteamNetConnection hConn) => Instance.FlushMessagesOnConnection(hConn);
        /// <summary><code>int ReceiveMessagesOnConnection( HSteamNetConnection hConn, SteamNetworkingMessage_t **ppOutMessages, int nMaxMessages );</code>Fetch the next available message(s) from the connection, if any.  Returns the number of messages returned into your array, up to nMaxMessages.<br />
        /// If the connection handle is invalid, -1 is returned.  If no data is available, 0, is returned.<br />
        /// <br />
        /// The order of the messages returned in the array is relevant.  Reliable messages will be received in the order they were sent (and with the same sizes --- see SendMessageToConnection for on this subtle difference from a stream socket).<br />
        /// <br />
        /// Unreliable messages may be dropped, or delivered out of order with respect to each other or with respect to reliable messages.<br />
        /// <br />
        /// If any messages are returned, you MUST call <a href="https://partner.steamgames.com/doc/api/steamnetworkingtypes#SteamNetworkingMessage_t" class="bb_apilink">SteamNetworkingMessage_t</a>::Release() to each of them free up resources after you are done.  It is safe to keep the object alive for a little while (put it into some queue, etc), and you may call Release() from any thread.</summary>
        /// 
        public static int ReceiveMessagesOnConnection(HSteamNetConnection hConn, SteamNetworkingMessage** ppOutMessages, int nMaxMessages) => Instance.ReceiveMessagesOnConnection(hConn, ppOutMessages, nMaxMessages);
        /// <summary><code>bool GetConnectionInfo( HSteamNetConnection hConn, SteamNetConnectionInfo_t *pInfo );</code>Returns basic information about the high-level state of the connection.<br />
        /// Returns false if the connection handle is invalid.</summary>
        /// 
        public static bool GetConnectionInfo(HSteamNetConnection hConn, SteamNetConnectionInfo* pInfo) => Instance.GetConnectionInfo(hConn, pInfo);
        /// <summary><code>EResult GetConnectionRealTimeStatus( HSteamNetConnection hConn, SteamNetConnectionRealTimeStatus_t *pStatus, int nLanes, SteamNetConnectionRealTimeLaneStatus_t *pLanes );</code><br />
        /// Returns a small set of information about the real-time state of the connection and the queue status of each lane.<br />
        /// <br />
        /// pStatus may be NULL if the information is not desired.  (E.g. you are only interested in the lane information.)<br />
        /// <br />
        /// On entry, nLanes specifies the length of the pLanes array.  This may be 0 if you do not wish to receive any lane data.  It's OK for this to be smaller than the total number of configured lanes.<br />
        /// <br />
        /// pLanes points to an array that will receive lane-specific info.  It can be NULL if this is not needed.<br />
        /// <br />
        /// Return value:<br />
        /// <ul class="bb_ul "><li> k_EResultNoConnection - connection handle is invalid or connection has been closed.<br />
        /// </li><li> k_EResultInvalidParam - nLanes is bad</li></ul></summary>
        /// 
        public static Result GetConnectionRealTimeStatus(HSteamNetConnection hConn, SteamNetConnectionRealTimeStatus* pStatus, int nLanes, SteamNetConnectionRealTimeLaneStatus* pLanes) => Instance.GetConnectionRealTimeStatus(hConn, pStatus, nLanes, pLanes);
        /// <summary><code>int GetDetailedConnectionStatus( HSteamNetConnection hConn, char *pszBuf, int cbBuf );</code>Returns very detailed connection stats in diagnostic text format.  Useful for dumping to a log, etc.  The format of this information is subject to change.<br />
        /// <br />
        /// Returns:<br />
        /// <ul class="bb_ul "><li><b>-1</b>: failure (bad connection handle)<br />
        /// </li><li><b>0</b>: OK, your buffer was filled in and '\0'-terminated<br />
        /// </li><li><b>&gt;0</b>: Your buffer was either nullptr, or it was too small and the text got truncated.  Try again with a buffer of at least N bytes.</li></ul></summary>
        /// 
        public static int GetDetailedConnectionStatus(HSteamNetConnection hConn, byte* pszBuf, int cbBuf) => Instance.GetDetailedConnectionStatus(hConn, pszBuf, cbBuf);
        /// <summary><code>bool GetListenSocketAddress( HSteamListenSocket hSocket, SteamNetworkingIPAddr *address );</code><br />
        /// Returns local IP and port that a listen socket created using CreateListenSocketIP is bound to.<br />
        /// <br />
        /// Specific IPv6/IPv4 addresses may be returned if you bound the socket to a particular interface.<br />
        /// An IPv6 address of ::0 means "any IPv4 or IPv6"<br />
        /// An IPv6 address of ::ffff:0000:0000 means "any IPv4"<br />
        /// <br />
        /// NOTE: This is not how you find out your public IP that clients can connect to.<br />
        /// Try <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#GetPublicIP" class="bb_apilink">ISteamGameServer::GetPublicIP</a>.<br />
        /// <br />
        /// Returns false if the handle is invalid, or the information is not available for that type of listen socket.</summary>
        /// 
        public static bool GetListenSocketAddress(HSteamListenSocket hSocket, SteamNetworkingIPAddr* address) => Instance.GetListenSocketAddress(hSocket, address);
        /// <summary><code>bool CreateSocketPair( HSteamNetConnection *pOutConnection1, HSteamNetConnection *pOutConnection2, bool bUseNetworkLoopback, const SteamNetworkingIdentity *pIdentity1, const SteamNetworkingIdentity *pIdentity2 );</code><br />
        /// Create a pair of connections that are talking to each other, e.g. a loopback connection.  This is very useful for testing, or so that your client/server code can work the same even when you are running a local "server".<br />
        /// <br />
        /// The two connections will immediately be placed into the connected state, and no callbacks will be posted immediately.  After this, if you close either connection, the other connection will receive a callback, exactly as if they were communicating over the network.  You must close *both* sides in order to fully clean up the resources!<br />
        /// <br />
        /// By default, internal buffers are used, completely bypassing the network, the chopping up of messages into packets, encryption, copying the payload, etc.  This means that loopback packets, by default, will not simulate lag or loss.  Passing true for bUseNetworkLoopback will cause the socket pair to send packets through the local network loopback device (127.0.0.1) on ephemeral ports.  Fake lag and loss are supported in this case, and CPU time is expended to encrypt and decrypt.<br />
        /// <br />
        /// If you wish to assign a specific identity to either connection, you may pass a particular identity.  Otherwise, if you pass nullptr, the respective connection will assume a generic "localhost" identity.  If you use real network loopback, this might be translated to the actual bound loopback port.  Otherwise, the port will be zero.</summary>
        /// 
        public static bool CreateSocketPair(HSteamNetConnection* pOutConnection1, HSteamNetConnection* pOutConnection2, bool bUseNetworkLoopback, SteamNetworkingIdentity* pIdentity1, SteamNetworkingIdentity* pIdentity2) => Instance.CreateSocketPair(pOutConnection1, pOutConnection2, bUseNetworkLoopback, pIdentity1, pIdentity2);
        /// <summary><code>EResult ConfigureConnectionLanes( HSteamNetConnection hConn, int nNumLanes, const int *pLanePriorities, const uint16 *pLaneWeights );</code><br />
        /// Configure multiple outbound messages streams ("lanes") on a connection, and control head-of-line blocking between them.  Messages within a given lane are always sent in the order they are queued, but messages from different lanes may be sent out of order.  Each lane has its own message number sequence.  The first message sent on each lane will be assigned the number 1.<br />
        /// <br />
        /// Each lane has a "priority".  Lower priority lanes will only be processed when all higher-priority lanes are empty.  The magnitudes of the priority values are not relevant, only their sort order.  Higher numeric values take priority over lower numeric values.<br />
        /// <br />
        /// Each lane also is assigned a weight, which controls the approximate proportion of the bandwidth that will be consumed by the lane, relative to other lanes of the same priority.  (This is assuming the lane stays busy.  An idle lane does not build up "credits" to be be spent once a message is queued.) This value is only meaningful as a proportion, relative to other lanes with the same priority.  For lanes with different priorities, the strict priority order will prevail, and their weights relative to each other are not relevant.  Thus, if a lane has a unique priority value, the weight value for that lane is not relevant.  <br />
        /// <br />
        /// Example: 3 lanes, with priorities { 0, 10, 10 } and weights { (NA), 20, 5 }.  Messages sent on the first will always be sent first, before messages in the other two lanes.  Its weight value is irrelevant, since there are no other lanes with priority=0.  The other two lanes will share bandwidth, with the second and third lanes sharing bandwidth using a ratio of approximately 4:1.  (The weights { NA, 4, 1 } would be equivalent.)<br />
        /// <br />
        /// Notes:<br />
        /// <ul class="bb_ul "><li> At the time of this writing, some code has performance cost that is linear in the number of lanes, so keep the number of lanes to an absolute minimum. 3 or so is fine; &gt;8 is a lot.  The max number of lanes on Steam is 255, which is a very large number and not recommended!<br />
        /// </li><li> Lane priority values may be any int.  Their absolute value is not relevant, only the order matters.<br />
        /// </li><li> Weights must be positive, and due to implementation details, they are restricted to 16-bit values.  The absolute magnitudes don't matter, just the proportions.<br />
        /// </li><li> Messages sent on a lane index other than 0 have a small overhead on the wire, so for maximum wire efficiency, lane 0 should be the "most common" lane, regardless of priorities or weights.<br />
        /// </li><li> A connection has a single lane by default.  Calling this function with nNumLanes=1 is legal, but pointless, since the priority and weight values are irrelevant in that case.<br />
        /// </li><li> You may reconfigure connection lanes at any time, however reducing the number of lanes is not allowed.<br />
        /// </li><li> Reconfiguring lanes might restart any bandwidth sharing balancing.  Usually you will call this function once, near the start of the connection, perhaps after exchanging a few messages.<br />
        /// </li><li> To assign all lanes the same priority, you may use pLanePriorities=NULL.<br />
        /// </li><li> If you wish all lanes with the same priority to share bandwidth equally (or if no two lanes have the same priority value, and thus priority values are irrelevant), you may use pLaneWeights=NULL<br />
        /// </li><li> Priorities and weights determine the order that messages are SENT on the wire. There are NO GUARANTEES on the order that messages are RECEIVED!  Due to packet loss, out-of-order delivery, and subtle details of packet serialization, messages might still be received slightly out-of-order!  The *only* strong guarantee is that *reliable* messages on the *same lane* will be delivered in the order they are sent.<br />
        /// </li><li> Each host configures the lanes for the packets they send; the lanes for the flow in one direction are completely unrelated to the lanes in the opposite direction.</li></ul><br />
        /// Return value:<br />
        /// <ul class="bb_ul "><li> k_EResultNoConnection - bad hConn<br />
        /// </li><li> k_EResultInvalidParam - Invalid number of lanes, bad weights, or you tried to reduce the number of lanes<br />
        /// </li><li> k_EResultInvalidState - Connection is already dead, etc</li></ul><br />
        /// See also:<br />
        /// <ul class="bb_ul "><li> SteamNetworkingMessage_t::m_idxLane</li></ul></summary>
        /// 
        public static Result ConfigureConnectionLanes(HSteamNetConnection hConn, int nNumLanes, int* pLanePriorities, ushort* pLaneWeights) => Instance.ConfigureConnectionLanes(hConn, nNumLanes, pLanePriorities, pLaneWeights);
        /// <summary><code>bool GetIdentity( SteamNetworkingIdentity *pIdentity );</code>Get the identity assigned to this interface.<br />
        /// <br />
        /// E.g. on Steam, this is the user's SteamID, or for the gameserver interface, the SteamID assigned to the gameserver.  Returns false and sets the result to an invalid identity if we don't know our identity yet.  (E.g. GameServer has not logged in.  On Steam, the user will know their SteamID even if they are not signed into Steam.)</summary>
        /// 
        public static bool GetIdentity(SteamNetworkingIdentity* pIdentity) => Instance.GetIdentity(pIdentity);
        /// <summary><code>ESteamNetworkingAvailability InitAuthentication();</code><br />
        /// Indicate our desire to be ready participate in authenticated communications.  If we are currently not ready, then steps will be taken to obtain the necessary certificates.   (This includes a certificate for us, as well as any CA certificates needed to authenticate peers.)<br />
        /// <br />
        /// You can call this at program init time if you know that you are going to be making authenticated connections, so that we will be ready immediately when those connections are attempted.  (Note that essentially all connections require authentication, with the exception of ordinary UDP connections with authentication disabled using k_ESteamNetworkingConfig_IP_AllowWithoutAuth.)  If you don't call this function, we will wait until a feature is utilized that that necessitates these resources.<br />
        /// <br />
        /// You can also call this function to force a retry, if failure has occurred.  Once we make an attempt and fail, we will not automatically retry.  In this respect, the behavior of the system after trying and failing is the same as before the first attempt: attempting authenticated communication or calling this function will call the system to attempt to acquire the necessary resources.<br />
        /// <br />
        /// You can use <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingSockets#GetAuthenticationStatus" class="bb_apilink">ISteamNetworkingSockets::GetAuthenticationStatus</a> or listen for <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingSockets#SteamNetAuthenticationStatus_t" class="bb_apilink">SteamNetAuthenticationStatus_t</a> to monitor the status.<br />
        /// <br />
        /// Returns the current value that would be returned from <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingSockets#GetAuthenticationStatus" class="bb_apilink">ISteamNetworkingSockets::GetAuthenticationStatus</a>.</summary>
        /// 
        public static SteamNetworkingAvailability InitAuthentication() => Instance.InitAuthentication();
        /// <summary><code>ESteamNetworkingAvailability GetAuthenticationStatus( SteamNetAuthenticationStatus_t *pDetails );</code><br />
        /// Query our readiness to participate in authenticated communications.  A <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingSockets#SteamNetAuthenticationStatus_t" class="bb_apilink">SteamNetAuthenticationStatus_t</a> callback is posted any time this status changes, but you can use this function to query it at any time.<br />
        /// <br />
        /// The value of SteamNetAuthenticationStatus_t::m_eAvail is returned.  If you only want this high level status, you can pass NULL for pDetails.  If you want further details, pass non-NULL to receive them.</summary>
        /// 
        public static SteamNetworkingAvailability GetAuthenticationStatus(SteamNetAuthenticationStatus* pDetails) => Instance.GetAuthenticationStatus(pDetails);
        /// <summary><code>HSteamNetPollGroup CreatePollGroup()</code>Create a new poll group.<br />
        /// <br />
        /// You should destroy the poll group when you are done using <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingSockets#DestroyPollGroup" class="bb_apilink">ISteamNetworkingSockets::DestroyPollGroup</a>.</summary>
        /// 
        public static HSteamNetPollGroup CreatePollGroup() => Instance.CreatePollGroup();
        /// <summary><code>bool DestroyPollGroup( HSteamNetPollGroup hPollGroup )</code>Destroy a poll group created with <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingSockets#CreatePollGroup" class="bb_apilink">ISteamNetworkingSockets::CreatePollGroup</a>.<br />
        /// <br />
        /// If there are any connections in the poll group, they are removed from the group, and left in a state where they are not part of any poll group.  Returns false if passed an invalid poll group handle.</summary>
        /// 
        public static bool DestroyPollGroup(HSteamNetPollGroup hPollGroup) => Instance.DestroyPollGroup(hPollGroup);
        /// <summary><code>bool SetConnectionPollGroup( HSteamNetConnection hConn, HSteamNetPollGroup hPollGroup );</code><br />
        /// Assign a connection to a poll group.  Note that a connection may only belong to a single poll group.  Adding a connection to a poll group implicitly removes it from any other poll group it is in.<br />
        /// <br />
        /// You can pass k_HSteamNetPollGroup_Invalid to remove a connection from its current poll group without adding it to a new poll group.<br />
        /// <br />
        /// If there are received messages currently pending on the connection, an attempt is made to add them to the queue of messages for the poll group in approximately the order that would have applied if the connection was already part of the poll group at the time that the messages were received.<br />
        /// <br />
        /// Returns false if the connection handle is invalid, or if the poll group handle is invalid (and not k_HSteamNetPollGroup_Invalid).</summary>
        /// 
        public static bool SetConnectionPollGroup(HSteamNetConnection hConn, HSteamNetPollGroup hPollGroup) => Instance.SetConnectionPollGroup(hConn, hPollGroup);
        /// <summary><code>int ReceiveMessagesOnPollGroup( HSteamNetPollGroup hPollGroup, SteamNetworkingMessage_t **ppOutMessages, int nMaxMessages );</code><br />
        /// Same as <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingSockets#ReceiveMessagesOnConnection" class="bb_apilink">ISteamNetworkingSockets::ReceiveMessagesOnConnection</a>, but will return the next messages available on any connection in the poll group.  Examine <a href="https://partner.steamgames.com/doc/api/steamnetworkingtypes#SteamNetworkingMessage_t" class="bb_apilink">SteamNetworkingMessage_t</a>::m_conn to know which connection.  (<a href="https://partner.steamgames.com/doc/api/steamnetworkingtypes#SteamNetworkingMessage_t" class="bb_apilink">SteamNetworkingMessage_t</a>::m_nConnUserData might also be useful.)<br />
        /// <br />
        /// Delivery order of messages among different connections will usually match the order that the last packet was received which completed the message.  But this is not a strong guarantee, especially for packets received right as a connection is being assigned to poll group.<br />
        /// <br />
        /// Delivery order of messages on the same connection is well defined and the same guarantees are present as mentioned in <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingSockets#ReceiveMessagesOnConnection" class="bb_apilink">ISteamNetworkingSockets::ReceiveMessagesOnConnection</a>. (But the messages are not grouped by connection, so they will not necessarily appear consecutively in the list; they may be interleaved with messages for other connections.)</summary>
        /// 
        public static int ReceiveMessagesOnPollGroup(HSteamNetPollGroup hPollGroup, SteamNetworkingMessage** ppOutMessages, int nMaxMessages) => Instance.ReceiveMessagesOnPollGroup(hPollGroup, ppOutMessages, nMaxMessages);
        /// <summary><code>bool ReceivedRelayAuthTicket( const void *pvTicket, int cbTicket, SteamDatagramRelayAuthTicket *pOutParsedTicket );</code><br />
        /// Call this when you receive a ticket from your backend / matchmaking system.  Puts the ticket into a persistent cache, and optionally returns the parsed ticket.<br />
        /// <br />
        /// See stamdatagram_gamecoordinator.h for more details.</summary>
        /// 
        public static bool ReceivedRelayAuthTicket(void* pvTicket, int cbTicket, Unknown* pOutParsedTicket) => Instance.ReceivedRelayAuthTicket(pvTicket, cbTicket, pOutParsedTicket);
        /// <summary><code>int FindRelayAuthTicketForServer( const SteamNetworkingIdentity &amp;identityGameServer, int nRemoteVirtualPort, SteamDatagramRelayAuthTicket *pOutParsedTicket );</code><br />
        /// Search cache for a ticket to talk to the server on the specified virtual port.  If found, returns the number of seconds until the ticket expires, and optionally the complete cracked ticket.  Returns 0 if we don't have a ticket.<br />
        /// <br />
        /// Typically this is useful just to confirm that you have a ticket, before you call ConnectToHostedDedicatedServer to connect to the server.</summary>
        /// 
        public static int FindRelayAuthTicketForServer(ref SteamNetworkingIdentity identityGameServer, int nRemoteVirtualPort, Unknown* pOutParsedTicket) => Instance.FindRelayAuthTicketForServer(ref identityGameServer, nRemoteVirtualPort, pOutParsedTicket);
        /// <summary><code>HSteamNetConnection ConnectToHostedDedicatedServer( const SteamNetworkingIdentity &amp;identityTarget, int nRemoteVirtualPort, int nOptions, const SteamNetworkingConfigValue_t *pOptions );</code><br />
        /// Client call to connect to a server hosted in a Valve data center, on the specified virtual port.  You must have placed a ticket for this server into the cache, or else this connect attempt will fail!  If you are not issuing your own tickets, then to connect to a dedicated server via SDR in auto-ticket mode, use <a href="https://partner.steamgames.com/doc/api/ConnectP2P" class="bb_apilink">ConnectP2P</a>.  (The server must be configured to allow this type of connection by listening using <a href="https://partner.steamgames.com/doc/api/CreateListenSocketP2P" class="bb_apilink">CreateListenSocketP2P</a>.)<br />
        /// <br />
        /// You may wonder why tickets are stored in a cache, instead of simply being passed as an argument here.  The reason is to make reconnection to a gameserver robust, even if the client computer loses connection to Steam or the central backend, or the app is restarted or crashes, etc.<br />
        /// <br />
        /// If you use this, you probably want to call <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingUtils#InitRelayNetworkAccess" class="bb_apilink">ISteamNetworkingUtils::InitRelayNetworkAccess</a> when your app initializes.<br />
        /// <br />
        /// If you need to set any initial config options, pass them here.  See <a href="https://partner.steamgames.com/doc/api/steamnetworkingtypes#SteamNetworkingConfigValue_t" class="bb_apilink">SteamNetworkingConfigValue_t</a> for more about why this is preferable to setting the options "immediately" after creation.</summary>
        /// 
        public static HSteamNetConnection ConnectToHostedDedicatedServer(ref SteamNetworkingIdentity identityTarget, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue* pOptions) => Instance.ConnectToHostedDedicatedServer(ref identityTarget, nRemoteVirtualPort, nOptions, pOptions);
        /// <summary><code>uint16 GetHostedDedicatedServerPort();</code>Returns the value of the SDR_LISTEN_PORT environment variable.  This is the UDP server your server will be listening on.  This will configured automatically for you in production environments.<br />
        /// <br />
        /// In development, you'll need to set it yourself.  See <a href="https://partner.steamgames.com/doc/features/multiplayer/steamdatagramrelay" class="bb_doclink">Steam Datagram Relay</a> for more information on how to configure dev environments.</summary>
        /// 
        public static ushort GetHostedDedicatedServerPort() => Instance.GetHostedDedicatedServerPort();
        /// <summary><code>SteamNetworkingPOPID GetHostedDedicatedServerPOPID();</code>Returns 0 if SDR_LISTEN_PORT is not set.  Otherwise, returns the data center the server is running in.  This will be k_SteamDatagramPOPID_dev in non-production envirionment.</summary>
        /// 
        public static SteamNetworkingPOPID GetHostedDedicatedServerPOPID() => Instance.GetHostedDedicatedServerPOPID();
        /// <summary><code>EResult GetHostedDedicatedServerAddress( SteamDatagramHostedAddress *pRouting );</code>Return info about the hosted server.  This contains the PoPID of the server, and opaque routing information that can be used by the relays to send traffic to your server.<br />
        /// <br />
        /// You will need to send this information to your backend, and put it in tickets, so that the relays will know how to forward traffic from clients to your server.  See <a href="https://partner.steamgames.com/doc/api/steamnetworkingtypes#SteamDatagramRelayAuthTicket" class="bb_apilink">SteamDatagramRelayAuthTicket</a> for more info.<br />
        /// <br />
        /// Also, note that the routing information is contained in <a href="https://partner.steamgames.com/doc/api/steamnetworkingtypes#SteamDatagramGameCoordinatorServerLogin" class="bb_apilink">SteamDatagramGameCoordinatorServerLogin</a>, so if possible, it's preferred to use <a href="https://partner.steamgames.com/doc/api/SteamNetworkingSockets#GetGameCoordinatorServerLogin" class="bb_apilink">SteamNetworkingSockets::GetGameCoordinatorServerLogin</a> to send this info to your game coordinator service, and also login securely at the same time.<br />
        /// <br />
        /// On a successful exit, k_EResultOK is returned<br />
        /// <br />
        /// Unsuccessful exit:<br />
        /// <ul class="bb_ul "><li> Something other than k_EResultOK is returned.<br />
        /// </li><li> k_EResultInvalidState: We are not configured to listen for SDR (SDR_LISTEN_SOCKET is not set.)<br />
        /// </li><li> k_EResultPending: we do not (yet) have the authentication information needed.  (See <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingSockets#GetAuthenticationStatus" class="bb_apilink">ISteamNetworkingSockets::GetAuthenticationStatus</a>.)  If you use environment variables to pre-fetch the network config, this data should always be available immediately.<br />
        /// </li><li> A non-localized diagnostic debug message will be placed in m_data that describes the cause of the failure.</li></ul><br />
        /// NOTE: The returned blob is not encrypted.  Send it to your backend, but don't directly share it with clients.</summary>
        /// 
        public static Result GetHostedDedicatedServerAddress(SteamDatagramHostedAddress* pRouting) => Instance.GetHostedDedicatedServerAddress(pRouting);
        /// <summary><code>HSteamListenSocket CreateHostedDedicatedServerListenSocket( int nLocalVirtualPort, int nOptions, const SteamNetworkingConfigValue_t *pOptions );</code>Create a listen socket on the specified virtual port.  The physical UDP port to use will be determined by the SDR_LISTEN_PORT environment variable.  If a UDP port is not configured, this call will fail.<br />
        /// <br />
        /// Note that this call MUST be made through the SteamGameServerNetworkingSockets() interface.<br />
        /// <br />
        /// This function should be used when you are using the ticket generator library to issue your own tickets.  Clients connecting to the server on this virtual port will need a ticket, and they must connect using <a href="https://partner.steamgames.com/doc/api/ConnectToHostedDedicatedServer" class="bb_apilink">ConnectToHostedDedicatedServer</a>.<br />
        /// <br />
        /// If you need to set any initial config options, pass them here.  See <a href="https://partner.steamgames.com/doc/api/steamnetworkingtypes#SteamNetworkingConfigValue_t" class="bb_apilink">SteamNetworkingConfigValue_t</a> for more about why this is preferable to setting the options "immediately" after creation.</summary>
        /// 
        public static HSteamListenSocket CreateHostedDedicatedServerListenSocket(int nLocalVirtualPort, int nOptions, SteamNetworkingConfigValue* pOptions) => Instance.CreateHostedDedicatedServerListenSocket(nLocalVirtualPort, nOptions, pOptions);
        /// <summary><code>EResult GetGameCoordinatorServerLogin( SteamDatagramGameCoordinatorServerLogin *pLoginInfo, int *pcbSignedBlob, void *pBlob );</code><br />
        /// Generate an authentication blob that can be used to securely login with your backend, using SteamDatagram_ParseHostedServerLogin.  (See steamdatagram_gamecoordinator.h)<br />
        /// <br />
        /// Before calling the function:<br />
        /// <ul class="bb_ul "><li> Populate the app data in pLoginInfo (m_cbAppData and m_appData).  You can leave all other fields uninitialized.<br />
        /// </li><li> *pcbSignedBlob contains the size of the buffer at pBlob.  (It should be at least k_cbMaxSteamDatagramGameCoordinatorServerLoginSerialized.)</li></ul><br />
        /// On a successful exit:<br />
        /// <ul class="bb_ul "><li> k_EResultOK is returned<br />
        /// </li><li> All of the remaining fields of pLoginInfo will be filled out.<br />
        /// </li><li> *pcbSignedBlob contains the size of the serialized blob that has been placed into pBlob.</li></ul><br />
        /// Unsuccessful exit:<br />
        /// <ul class="bb_ul "><li> Something other than k_EResultOK is returned.<br />
        /// </li><li> k_EResultNotLoggedOn: you are not logged in (yet)<br />
        /// </li><li> See <a href="https://partner.steamgames.com/doc/api/ISteamNetwrokingSockets#GetHostedDedicatedServerAddress" class="bb_apilink">ISteamNetwrokingSockets::GetHostedDedicatedServerAddress</a> for more potential failure return values.<br />
        /// </li><li> A non-localized diagnostic debug message will be placed in pBlob that describes the cause of the failure.</li></ul><br />
        /// This works by signing the contents of the <a href="https://partner.steamgames.com/doc/api/steamnetwrokingtypes#SteamDatagramGameCoordinatorServerLogin" class="bb_apilink">SteamDatagramGameCoordinatorServerLogin</a> with the cert that is issued to this server.  In dev environments, it's OK if you do not have a cert.  (You will need to enable insecure dev login in SteamDatagram_ParseHostedServerLogin.)<br />
        /// Otherwise, you will need a signed cert.<br />
        /// <br />
        /// NOTE: The routing blob returned here is not encrypted.  Send it to your backend and don't share it directly with clients.</summary>
        /// 
        public static Result GetGameCoordinatorServerLogin(SteamDatagramGameCoordinatorServerLogin* pLoginInfo, int* pcbSignedBlob, void* pBlob) => Instance.GetGameCoordinatorServerLogin(pLoginInfo, pcbSignedBlob, pBlob);
        /// missing documentation
        public static HSteamNetConnection ConnectP2PCustomSignaling(Unknown* pSignaling, SteamNetworkingIdentity* pPeerIdentity, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue* pOptions) => Instance.ConnectP2PCustomSignaling(pSignaling, pPeerIdentity, nRemoteVirtualPort, nOptions, pOptions);
        /// missing documentation
        public static bool ReceivedP2PCustomSignal(void* pMsg, int cbMsg, Unknown* pContext) => Instance.ReceivedP2PCustomSignal(pMsg, cbMsg, pContext);
        /// missing documentation
        public static bool GetCertificateRequest(int* pcbBlob, void* pBlob, ref SteamNetworkingErrMsg errMsg) => Instance.GetCertificateRequest(pcbBlob, pBlob, ref errMsg);
        /// missing documentation
        public static bool SetCertificate(void* pCertificate, int cbCertificate, ref SteamNetworkingErrMsg errMsg) => Instance.SetCertificate(pCertificate, cbCertificate, ref errMsg);
        /// missing documentation
        public static void ResetIdentity(SteamNetworkingIdentity* pIdentity) => Instance.ResetIdentity(pIdentity);
        /// missing documentation
        public static void RunCallbacks() => Instance.RunCallbacks();
        /// <summary><code>bool BeginAsyncRequestFakeIP( int nNumPorts );</code><br />
        /// Begin asynchronous process of allocating a fake IPv4 address that other peers can use to contact us via P2P.  IP addresses returned by this function are globally unique for a given appid.<br />
        /// <br />
        /// nNumPorts is the numbers of ports you wish to reserve.  This is useful for the same reason that listening on multiple UDP ports is useful for different types of traffic.  Because these allocations come from a global namespace, there is a relatively strict limit on the maximum number of ports you may request.  (At the time of this writing, the limit is 4.)  The port assignments are *not* guaranteed to have any particular order or relationship!  Do *not* assume they are contiguous, even though that may often occur in practice.<br />
        /// <br />
        /// Returns false if a request was already in progress, true if a new request was started.  A SteamNetworkingFakeIPResult_t will be posted when the request completes.<br />
        /// <br />
        /// For gameservers, you *must* call this after initializing the SDK but before beginning login.  Steam needs to know in advance that FakeIP will be used. Everywhere your public IP would normally appear (such as the server browser) will be replaced by the FakeIP, and the fake port at index 0.  The request is actually queued until the logon completes, so you must not wait until the allocation completes before logging in.  Except for trivial failures that can be detected locally (e.g. invalid parameter), a SteamNetworkingFakeIPResult_t callback (whether success or failure) will not be posted until after we have logged in.  Furthermore, it is assumed that FakeIP allocation is essential for your application to function, and so failure will not be reported until *several* retries have been attempted.  This process may last several minutes.  It is *highly* recommended to treat failure as fatal.<br />
        /// <br />
        /// To communicate using a connection-oriented (TCP-style) API:<br />
        /// <ul class="bb_ul "><li> Server creates a listen socket using CreateListenSocketP2PFakeIP<br />
        /// </li><li> Client connects using ConnectByIPAddress, passing in the FakeIP address.<br />
        /// </li><li> The connection will behave mostly like a P2P connection.  The identities that appear in SteamNetConnectionInfo_t will be the FakeIP identity until we know the real identity.  Then it will be the real identity.  If the  SteamNetConnectionInfo_t::m_addrRemote is valid, it will be a real IPv4 address of a NAT-punched connection.  Otherwise, it will not be valid.</li></ul><br />
        /// To communicate using an ad-hoc sendto/recv from (UDP-style) API, use <a href="https://partner.steamgames.com/doc/api/CreateFakeUDPPort" class="bb_apilink">CreateFakeUDPPort</a>.</summary>
        /// 
        public static bool BeginAsyncRequestFakeIP(int nNumPorts) => Instance.BeginAsyncRequestFakeIP(nNumPorts);
        /// <summary><code>void GetFakeIP( int idxFirstPort, SteamNetworkingFakeIPResult_t *pInfo );</code><br />
        /// Return info about the FakeIP and port(s) that we have been assigned, if any.  idxFirstPort is currently reserved and must be zero.  Make sure and check SteamNetworkingFakeIPResult_t::m_eResult</summary>
        /// 
        public static void GetFakeIP(int idxFirstPort, SteamNetworkingFakeIPResult* pInfo) => Instance.GetFakeIP(idxFirstPort, pInfo);
        /// <summary><code>HSteamListenSocket CreateListenSocketP2PFakeIP( int idxFakePort, int nOptions, const SteamNetworkingConfigValue_t *pOptions );</code><br />
        /// Create a listen socket that will listen for P2P connections sent to our FakeIP.  A peer can initiate connections to this listen socket by calling <a href="https://partner.steamgames.com/doc/api/ConnectByIPAddress" class="bb_apilink">ConnectByIPAddress</a>.<br />
        /// <br />
        /// idxFakePort refers to the *index* of the fake port requested, not the actual port number.  For example, pass 0 to refer to the first port in the reservation.  You must call this only after calling <a href="https://partner.steamgames.com/doc/api/BeginAsyncRequestFakeIP" class="bb_apilink">BeginAsyncRequestFakeIP</a>.  However, you do not need to wait for the request to complete before creating the listen socket.</summary>
        /// 
        public static HSteamListenSocket CreateListenSocketP2PFakeIP(int idxFakePort, int nOptions, SteamNetworkingConfigValue* pOptions) => Instance.CreateListenSocketP2PFakeIP(idxFakePort, nOptions, pOptions);
        /// <summary><code>EResult GetRemoteFakeIPForConnection( HSteamNetConnection hConn, SteamNetworkingIPAddr *pOutAddr );</code><br />
        /// If the connection was initiated using the "FakeIP" system, then we we can get an IP address for the remote host.  If the remote host had a global FakeIP at the time the connection was established, this function will return that global IP.  Otherwise, a FakeIP that is unique locally will be allocated from the local FakeIP address space, and that will be returned.<br />
        /// <br />
        /// The allocation of local FakeIPs attempts to assign addresses in a consistent manner.  If multiple connections are made to the same remote host, they *probably* will return the same FakeIP.  However, since the namespace is limited, this cannot be guaranteed.<br />
        /// <br />
        /// On failure, returns:<br />
        /// <ul class="bb_ul "><li> k_EResultInvalidParam: invalid connection handle<br />
        /// </li><li> k_EResultIPNotFound: This connection wasn't made using FakeIP system</li></ul></summary>
        /// 
        public static Result GetRemoteFakeIPForConnection(HSteamNetConnection hConn, SteamNetworkingIPAddr* pOutAddr) => Instance.GetRemoteFakeIPForConnection(hConn, pOutAddr);
        /// <summary><code>ISteamNetworkingFakeUDPPort *CreateFakeUDPPort( int idxFakeServerPort );</code><br />
        /// Get an interface that can be used like a UDP port to send/receive datagrams to a FakeIP address.  This is intended to make it easy to port existing UDP-based code to take advantage of SDR.<br />
        /// <br />
        /// idxFakeServerPort refers to the *index* of the port allocated using <a href="https://partner.steamgames.com/doc/api/BeginAsyncRequestFakeIP" class="bb_apilink">BeginAsyncRequestFakeIP</a> and is used to create "server" ports.  You may call this before the allocation has completed.  However, any attempts to send packets will fail until the allocation has succeeded.  When the peer receives packets sent from this interface, the from address of the packet will be the globally-unique FakeIP.  If you call this function multiple times and pass the same (nonnegative) fake port index, the same object will be returned, and this object is not reference counted.<br />
        /// <br />
        /// To create a "client" port (e.g. the equivalent of an ephemeral UDP port) pass -1.  In this case, a distinct object will be returned for each call.  When the peer receives packets sent from this interface, the peer will assign a FakeIP from its own locally-controlled namespace.</summary>
        /// 
        public static ISteamNetworkingFakeUDPPort.Instance* CreateFakeUDPPort(int idxFakeServerPort) => Instance.CreateFakeUDPPort(idxFakeServerPort);
    }
}