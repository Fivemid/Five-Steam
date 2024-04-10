using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamNetworking
    {
        public static ISteamNetworking.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamNetworking_v006", CallingConvention = Platform.CC)]
        private static extern ISteamNetworking.Instance Accessor();
        /// <summary>
        /// <code>
        ///     bool SendP2PPacket( CSteamID steamIDRemote, const void *pubData, uint32 cubData, EP2PSend
        ///     eP2PSendType, int nChannel = 0 );
        /// </code>
        /// 
        /// <br />
        /// Sends a P2P packet to the specified user.<br />
        /// <br />
        /// This is a session-less API which automatically establishes NAT-traversing or Steam relay server
        /// connections.<br />
        /// <br />
        /// <b>NOTE:</b> The first packet send may be delayed as the NAT-traversal code runs.<br />
        /// <br />
        /// See
        /// <a href="https://partner.steamgames.com/doc/api/ISteamNetworking#EP2PSend" class="bb_apilink">EP2PSend</a>
        /// for descriptions of the different ways of sending packets.<br />
        /// <br />
        /// The type of data you send is arbitrary, you can use an off the shelf system like
        /// <a href="https://developers.google.com/protocol-buffers/" target="_blank" rel="noreferrer">Protocol Buffers</a>
        /// or <a href="https://capnproto.org" target="_blank" rel="noreferrer">Cap'n Proto</a> to encode your
        /// packets in an efficient way, or you can create your own messaging system.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// Triggers a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamNetworking#P2PSessionRequest_t" class="bb_apilink">P2PSessionRequest_t</a>
        /// callback.<br />
        /// <b>true</b> if the packet was successfully sent.<br />
        /// Note that this does not mean successfully received, if we can't get through to the user after a
        /// timeout of 20 seconds, then an error will be posted via the
        /// <a href="https://partner.steamgames.com/doc/api/ISteamNetworking#P2PSessionConnectFail_t" class="bb_apilink">P2PSessionConnectFail_t</a>
        /// callback.<br />
        /// <br />
        /// <b>false</b> upon the following conditions:<br />
        /// <ul class="bb_ul">
        ///     <li>The packet is too large for the send type.<br /></li>
        ///     <li>The target Steam ID is not valid.<br /></li>
        ///     <li>There are too many bytes queued up to be sent.</li>
        /// </ul>
        /// </summary>
        /// <param name="steamIDRemote">CSteamID: The target user to send the packet to.</param>
        /// <param name="pubData">const void *: 
        ///             The raw byte array for the packet data to send. The maximum size of this packet is
        ///             defined by <code class="bb_code bb_code_inline nohighlight">eP2PSendType</code>.
        ///         </param>
        /// <param name="cubData">uint32: 
        ///             The size in bytes of <code class="bb_code bb_code_inline nohighlight">pubData</code>.
        ///         </param>
        /// <param name="eP2PSendType">EP2PSend: 
        ///             Specifies how you want the data to be transmitted, such as reliably, unreliable,
        ///             buffered, etc.
        ///         </param>
        /// <param name="nChannel">int: 
        ///             The channel which acts as a virtual port to send this packet on and allows you help
        ///             route message to different systems.<br />
        ///             You'll have to call
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamNetworking#ReadP2PPacket" class="bb_apilink">ISteamNetworking::ReadP2PPacket</a>
        ///             on the other end with the same channel number in order to retrieve the data on the other
        ///             end. Using different channels to talk to the same user will still use the same
        ///             underlying P2P connection, saving on resources.<br />
        ///             Use <b>0</b> for the primary channel, or if you do not use this feature.
        ///         </param>
        public static bool SendP2PPacket(SteamId steamIDRemote, void* pubData, uint cubData, P2PSend eP2PSendType, int nChannel) => Instance.SendP2PPacket(steamIDRemote, pubData, cubData, eP2PSendType, nChannel);
        /// <summary>
        /// <code>bool IsP2PPacketAvailable( uint32 *pcubMsgSize, int nChannel = 0 );</code>
        /// 
        /// <br />
        /// Checks if a P2P packet is available to read, and gets the size of the message if there is one.<br />
        /// <br />
        /// This should be called in a loop for each channel that you use. If there is a packet available you
        /// should call
        /// <a href="https://partner.steamgames.com/doc/api/ISteamNetworking#ReadP2PPacket" class="bb_apilink">ISteamNetworking::ReadP2PPacket</a>
        /// to get the packet data.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if there is a packet available; otherwise, <b>false</b>.
        /// </summary>
        /// <param name="pcubMsgSize">uint32
        ///             *: Returns the size of the packet.</param>
        /// <param name="nChannel">int: The channel to check if a packet is available in.</param>
        public static bool IsP2PPacketAvailable(uint* pcubMsgSize, int nChannel) => Instance.IsP2PPacketAvailable(pcubMsgSize, nChannel);
        /// <summary>
        /// <code>
        ///     bool ReadP2PPacket( void *pubDest, uint32 cubDest, uint32 *pcubMsgSize, CSteamID
        ///     *psteamIDRemote, int nChannel = 0 );
        /// </code>
        /// 
        /// <br />
        /// Reads in a packet that has been sent from another user via
        /// <a href="https://partner.steamgames.com/doc/api/ISteamNetworking#SendP2PPacket" class="bb_apilink">ISteamNetworking::SendP2PPacket</a>.<br />
        /// <br />
        /// <br />
        /// If the <code class="bb_code bb_code_inline nohighlight">cubDest</code> buffer is too small for the
        /// packet, then the message will be truncated.<br />
        /// <br />
        /// This call is not blocking, and will return false if no data is available.<br />
        /// <br />
        /// Before calling this you should have called
        /// <a href="https://partner.steamgames.com/doc/api/ISteamNetworking#IsP2PPacketAvailable" class="bb_apilink">ISteamNetworking::IsP2PPacketAvailable</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if a packet was successfully read; otherwise, <b>false</b> if no
        /// packet was available.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     uint32 msgSize = 0; while ( SteamNetworking()-&gt;IsP2PPacketAvailable( &amp;msgSize ) ) { void
        ///     *packet = malloc( msgSize ); CSteamID steamIDRemote; uint32 bytesRead = 0; if (
        ///     SteamNetworking()-&gt;ReadP2PPacket( packet, msgSize, &amp;bytesRead, &amp;steamIDRemote ) ) {
        ///     // message dispatch code goes here } free( packet ); }
        /// </code>
        /// </summary>
        /// <param name="pubDest">void *: Returns the packet data by copying it into this buffer.</param>
        /// <param name="cubDest">uint32: 
        ///             The size allocated for <code class="bb_code bb_code_inline nohighlight">pubDest</code>.
        ///             This should be either the same size returned by
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamNetworking#IsP2PPacketAvailable" class="bb_apilink">ISteamNetworking::IsP2PPacketAvailable</a>, or the size of your largest packet.
        ///         </param>
        /// <param name="pcubMsgSize">uint32
        ///             *: Returns the size of the packet.</param>
        /// <param name="psteamIDRemote">CSteamID
        ///             *: Returns the Steam ID of the user that sent this packet.</param>
        /// <param name="nChannel">int: The channel the packet was sent over.</param>
        public static bool ReadP2PPacket(void* pubDest, uint cubDest, uint* pcubMsgSize, SteamId* psteamIDRemote, int nChannel) => Instance.ReadP2PPacket(pubDest, cubDest, pcubMsgSize, psteamIDRemote, nChannel);
        /// <summary>
        /// <code>bool AcceptP2PSessionWithUser( CSteamID steamIDRemote );</code>
        /// 
        /// <br />
        /// This allows the game to specify accept an incoming packet. This needs to be called before a real
        /// connection is established to a remote host, the game will get a chance to say whether or not the
        /// remote user is allowed to talk to them.<br />
        /// <br />
        /// When a remote user that you haven't sent a packet to recently, tries to first send you a packet,
        /// your game will receive a callback
        /// <a href="https://partner.steamgames.com/doc/api/ISteamNetworking#P2PSessionRequest_t" class="bb_apilink">P2PSessionRequest_t</a>. This callback contains the Steam ID of the user who wants to send you a packet. In response to
        /// this callback, you'll want to see if it's someone you want to talk to (for example, if they're in a
        /// lobby with you), and if so, accept the connection; otherwise if you don't want to talk to the user,
        /// just ignore the request. If the user continues to send you packets, another
        /// <a href="https://partner.steamgames.com/doc/api/ISteamNetworking#P2PSessionRequest_t" class="bb_apilink">P2PSessionRequest_t</a>
        /// will be posted periodically. If you've called
        /// <a href="https://partner.steamgames.com/doc/api/ISteamNetworking#SendP2PPacket" class="bb_apilink">ISteamNetworking::SendP2PPacket</a>
        /// on the other user, this implicitly accepts the session request.<br />
        /// <br />
        /// Note that this call should only be made in response to a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamNetworking#P2PSessionRequest_t" class="bb_apilink">P2PSessionRequest_t</a>
        /// callback!<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success; <b>false</b> only if
        /// <code class="bb_code bb_code_inline nohighlight">steamIDRemote</code> is invalid.
        /// </summary>
        /// <param name="steamIDRemote">CSteamID: The Steam ID of the user that sent the initial packet to us.</param>
        public static bool AcceptP2PSessionWithUser(SteamId steamIDRemote) => Instance.AcceptP2PSessionWithUser(steamIDRemote);
        /// <summary>
        /// <code>bool CloseP2PSessionWithUser( CSteamID steamIDRemote );</code>
        /// 
        /// <br />
        /// This should be called when you're done communicating with a user, as this will free up all of the
        /// resources allocated for the connection under-the-hood.<br />
        /// <br />
        /// If the remote user tries to send data to you again, a new
        /// <a href="https://partner.steamgames.com/doc/api/ISteamNetworking#P2PSessionRequest_t" class="bb_apilink">P2PSessionRequest_t</a>
        /// callback will be posted.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the session was successfully closed; otherwise, <b>false</b> if
        /// no connection was open with <code class="bb_code bb_code_inline nohighlight">steamIDRemote</code>.
        /// </summary>
        /// <param name="steamIDRemote">CSteamID: The Steam ID of the user to close the connection with.</param>
        public static bool CloseP2PSessionWithUser(SteamId steamIDRemote) => Instance.CloseP2PSessionWithUser(steamIDRemote);
        /// <summary>
        /// <code>bool CloseP2PChannelWithUser( CSteamID steamIDRemote, int nChannel );</code>
        /// 
        /// <br />
        /// Closes a P2P channel when you're done talking to a user on the specific channel.<br />
        /// <br />
        /// Once all channels to a user have been closed, the open session to the user will be closed and new
        /// data from this user will trigger a new
        /// <a href="https://partner.steamgames.com/doc/api/ISteamNetworking#P2PSessionRequest_t" class="bb_apilink">P2PSessionRequest_t</a>
        /// callback.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the channel was successfully closed; otherwise, <b>false</b> if
        /// there was no active session or channel with the user.
        /// </summary>
        /// <param name="steamIDRemote">CSteamID: The Steam ID of the user to close the connection with.</param>
        /// <param name="nChannel">int: The channel to close.</param>
        public static bool CloseP2PChannelWithUser(SteamId steamIDRemote, int nChannel) => Instance.CloseP2PChannelWithUser(steamIDRemote, nChannel);
        /// <summary>
        /// <code>
        ///     bool GetP2PSessionState( CSteamID steamIDRemote, P2PSessionState_t *pConnectionState );
        /// </code>
        /// 
        /// <br />
        /// Fills out a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamNetworking#P2PSessionState_t" class="bb_apilink">P2PSessionState_t</a>
        /// structure with details about the connection like whether or not there is an active connection;
        /// number of bytes queued on the connection; the last error code, if any; whether or not a relay server
        /// is being used; and the IP and Port of the remote user, if known<br />
        /// <br />
        /// This should only needed for debugging purposes.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if
        /// <code class="bb_code bb_code_inline nohighlight">pConnectionState</code> was filled out; otherwise,
        /// <b>false</b> if there was no open session with the specified user.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>
        ///     P2PSessionState_t p2pSessionState; SteamNetworking()-&gt;GetP2PSessionState( steamIDremote,
        ///     &amp;p2pSessionState );
        /// </code>
        /// </summary>
        /// <param name="steamIDRemote">CSteamID: The user to get the active session state information of.</param>
        /// <param name="pConnectionState">P2PSessionState_t
        ///             *: Returns the state.</param>
        public static bool GetP2PSessionState(SteamId steamIDRemote, P2PSessionState* pConnectionState) => Instance.GetP2PSessionState(steamIDRemote, pConnectionState);
        /// <summary>
        /// <code>bool AllowP2PPacketRelay( bool bAllow );</code>
        /// 
        /// <br />
        /// Allow or disallow P2P connections to fall back to being relayed through the Steam servers if a
        /// direct connection or NAT-traversal cannot be established.<br />
        /// <br />
        /// This only applies to connections created after setting this value, or to existing connections that
        /// need to automatically reconnect after this value is set.<br />
        /// <br />
        /// P2P packet relay is allowed by default.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// This function always returns <b>true</b>.
        /// </summary>
        /// <param name="bAllow">bool: </param>
        public static bool AllowP2PPacketRelay(bool bAllow) => Instance.AllowP2PPacketRelay(bAllow);
        /// <summary>
        /// <code>
        ///     SNetListenSocket_t CreateListenSocket( int nVirtualP2PPort, uint32 nIP, uint16 nPort, bool
        ///     bAllowUseOfPacketRelay );
        /// </code>
        /// 
        /// <br />
        /// Creates a socket and listens others to connect.<br />
        /// <br />
        /// Will trigger a
        /// <a href="https://partner.steamgames.com/doc/api/ISteamNetworking#SocketStatusCallback_t" class="bb_apilink">SocketStatusCallback_t</a>
        /// callback on another client connecting.<br />
        /// <br />
        /// nVirtualP2PPort is the unique ID that the client will connect to, in case you have multiple ports<br />
        /// this can usually just be 0 unless you want multiple sets of connections<br />
        /// unIP is the local IP address to bind to<br />
        /// pass in 0 if you just want the default local IP<br />
        /// unPort is the port to use<br />
        /// pass in 0 if you don't want users to be able to connect via IP/Port, but expect to be always
        /// peer-to-peer connections only<br />
        /// <br />
        /// This is part of an older set of functions designed around the Berkeley TCP sockets model. It's
        /// preferential that you use the P2P functions, they're more robust and these older functions will be
        /// removed eventually.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamNetworking#SNetListenSocket_t" class="bb_apilink">SNetListenSocket_t</a>
        /// </summary>
        /// <param name="nVirtualP2PPort">int: </param>
        /// <param name="nIP">uint32: </param>
        /// <param name="nPort">uint16: </param>
        /// <param name="bAllowUseOfPacketRelay">bool: </param>
        public static SNetListenSocket CreateListenSocket(int nVirtualP2PPort, SteamIPAddress nIP, ushort nPort, bool bAllowUseOfPacketRelay) => Instance.CreateListenSocket(nVirtualP2PPort, nIP, nPort, bAllowUseOfPacketRelay);
        /// <summary>
        /// <code>
        ///     SNetSocket_t CreateP2PConnectionSocket( CSteamID steamIDTarget, int nVirtualPort, int
        ///     nTimeoutSec, bool bAllowUseOfPacketRelay );
        /// </code>
        /// 
        /// <br />
        /// Creates a socket and begin connection to a remote destination.<br />
        /// <br />
        /// can connect via a known Steam ID (client or game server), or directly to an IP<br />
        /// on success will trigger a SocketStatusCallback_t callback<br />
        /// on failure or timeout will trigger a SocketStatusCallback_t callback with a failure code in
        /// m_eSNetSocketState<br />
        /// <br />
        /// This is part of an older set of functions designed around the Berkeley TCP sockets model it's
        /// preferential that you use the P2P functions, they're more robust and these older functions will be
        /// removed eventually.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamNetworking#SNetSocket_t" class="bb_apilink">SNetSocket_t</a>
        /// </summary>
        /// <param name="steamIDTarget">CSteamID: </param>
        /// <param name="nVirtualPort">int: </param>
        /// <param name="nTimeoutSec">int: </param>
        /// <param name="bAllowUseOfPacketRelay">bool: </param>
        public static SNetSocket CreateP2PConnectionSocket(SteamId steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay) => Instance.CreateP2PConnectionSocket(steamIDTarget, nVirtualPort, nTimeoutSec, bAllowUseOfPacketRelay);
        /// <summary>
        /// <code>
        ///     SNetSocket_t CreateConnectionSocket( uint32 nIP, uint16 nPort, int nTimeoutSec );
        /// </code>
        /// 
        /// <br />
        /// Creates a socket and begin connection to a remote destination.<br />
        /// <br />
        /// This is part of an older set of functions designed around the Berkeley TCP sockets model. It's
        /// preferential that you use the P2P functions, they're more robust and these older functions will be
        /// removed eventually.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamNetworking#SNetSocket_t" class="bb_apilink">SNetSocket_t</a>
        /// </summary>
        /// <param name="nIP">uint32: </param>
        /// <param name="nPort">uint16: </param>
        /// <param name="nTimeoutSec">int: </param>
        public static SNetSocket CreateConnectionSocket(SteamIPAddress nIP, ushort nPort, int nTimeoutSec) => Instance.CreateConnectionSocket(nIP, nPort, nTimeoutSec);
        /// <summary>
        /// <code>bool DestroySocket( SNetSocket_t hSocket, bool bNotifyRemoteEnd );</code>
        /// 
        /// <br />
        /// Disconnects the connection to the socket, if any, and invalidates the handle.<br />
        /// <br />
        /// any unread data on the socket will be thrown away<br />
        /// if bNotifyRemoteEnd is set, socket will not be completely destroyed until the remote end
        /// acknowledges the disconnect<br />
        /// <br />
        /// This is part of an older set of functions designed around the Berkeley TCP sockets model it's
        /// preferential that you use the P2P functions, they're more robust and these older functions will be
        /// removed eventually.<br />
        /// <br />
        /// <b>Returns:</b> bool
        /// </summary>
        /// <param name="hSocket">SNetSocket_t: </param>
        /// <param name="bNotifyRemoteEnd">bool: </param>
        public static bool DestroySocket(SNetSocket hSocket, bool bNotifyRemoteEnd) => Instance.DestroySocket(hSocket, bNotifyRemoteEnd);
        /// <summary>
        /// <code>
        ///     bool DestroyListenSocket( SNetListenSocket_t hSocket, bool bNotifyRemoteEnd );
        /// </code>
        /// 
        /// <br />
        /// Destroying a listen socket will automatically kill all the regular sockets generated from it.<br />
        /// <br />
        /// This is part of an older set of functions designed around the Berkeley TCP sockets model. It's
        /// preferential that you use the P2P functions, they're more robust and these older functions will be
        /// removed eventually.<br />
        /// <br />
        /// <b>Returns:</b> bool
        /// </summary>
        /// <param name="hSocket">SNetListenSocket_t: </param>
        /// <param name="bNotifyRemoteEnd">bool: </param>
        public static bool DestroyListenSocket(SNetListenSocket hSocket, bool bNotifyRemoteEnd) => Instance.DestroyListenSocket(hSocket, bNotifyRemoteEnd);
        /// <summary>
        /// <code>
        ///     bool SendDataOnSocket( SNetSocket_t hSocket, void *pubData, uint32 cubData, bool bReliable );
        /// </code>
        /// 
        /// <br />
        /// sending data<br />
        /// must be a handle to a connected socket<br />
        /// data is all sent via UDP, and thus send sizes are limited to 1200 bytes; after this, many routers
        /// will start dropping packets<br />
        /// use the reliable flag with caution; although the resend rate is pretty aggressive,<br />
        /// it can still cause stalls in receiving data (like TCP)<br />
        /// <br />
        /// <b>Returns:</b> bool
        /// </summary>
        /// <param name="hSocket">SNetSocket_t: </param>
        /// <param name="pubData">void *: </param>
        /// <param name="cubData">uint32: </param>
        /// <param name="bReliable">bool: </param>
        public static bool SendDataOnSocket(SNetSocket hSocket, void* pubData, uint cubData, bool bReliable) => Instance.SendDataOnSocket(hSocket, pubData, cubData, bReliable);
        /// <summary>
        /// <code>
        ///     bool IsDataAvailableOnSocket( SNetSocket_t hSocket, uint32 *pcubMsgSize );
        /// </code>
        /// 
        /// <br />
        /// Returns false if there is no data remaining.<br />
        /// <br />
        /// fills out *pcubMsgSize with the size of the next message, in bytes<br />
        /// <br />
        /// This is part of an older set of functions designed around the Berkeley TCP sockets model it's
        /// preferential that you use the P2P functions, they're more robust and these older functions will be
        /// removed eventually.<br />
        /// <br />
        /// <b>Returns:</b> bool
        /// </summary>
        /// <param name="hSocket">SNetSocket_t: </param>
        /// <param name="pcubMsgSize">uint32
        ///             *: </param>
        public static bool IsDataAvailableOnSocket(SNetSocket hSocket, uint* pcubMsgSize) => Instance.IsDataAvailableOnSocket(hSocket, pcubMsgSize);
        /// <summary>
        /// <code>
        ///     bool RetrieveDataFromSocket( SNetSocket_t hSocket, void *pubDest, uint32 cubDest, uint32
        ///     *pcubMsgSize );
        /// </code>
        /// 
        /// <br />
        /// Fills in pubDest with the contents of the message.<br />
        /// <br />
        /// messages are always complete, of the same size as was sent (i.e. packetized, not streaming)<br />
        /// if *pcubMsgSize &lt; cubDest, only partial data is written<br />
        /// returns false if no data is available<br />
        /// <br />
        /// This is part of an older set of functions designed around the Berkeley TCP sockets model it's
        /// preferential that you use the P2P functions, they're more robust and these older functions will be
        /// removed eventually.<br />
        /// <br />
        /// <b>Returns:</b> bool
        /// </summary>
        /// <param name="hSocket">SNetSocket_t: </param>
        /// <param name="pubDest">void *: </param>
        /// <param name="cubDest">uint32: </param>
        /// <param name="pcubMsgSize">uint32
        ///             *: </param>
        public static bool RetrieveDataFromSocket(SNetSocket hSocket, void* pubDest, uint cubDest, uint* pcubMsgSize) => Instance.RetrieveDataFromSocket(hSocket, pubDest, cubDest, pcubMsgSize);
        /// <summary>
        /// <code>
        ///     bool IsDataAvailable( SNetListenSocket_t hListenSocket, uint32 *pcubMsgSize, SNetSocket_t
        ///     *phSocket );
        /// </code>
        /// 
        /// <br />
        /// Checks for data from any socket that has been connected off this listen socket.<br />
        /// <br />
        /// returns false if there is no data remaining<br />
        /// fills out *pcubMsgSize with the size of the next message, in bytes<br />
        /// fills out *phSocket with the socket that data is available on<br />
        /// <br />
        /// This is part of an older set of functions designed around the Berkeley TCP sockets model. It's
        /// preferential that you use the P2P functions, they're more robust and these older functions will be
        /// removed eventually.<br />
        /// <br />
        /// <b>Returns:</b> bool
        /// </summary>
        /// <param name="hListenSocket">SNetListenSocket_t: </param>
        /// <param name="pcubMsgSize">uint32
        ///             *: </param>
        /// <param name="phSocket">SNetSocket_t
        ///             *: </param>
        public static bool IsDataAvailable(SNetListenSocket hListenSocket, uint* pcubMsgSize, SNetSocket* phSocket) => Instance.IsDataAvailable(hListenSocket, pcubMsgSize, phSocket);
        /// <summary>
        /// <code>
        ///     bool RetrieveData( SNetListenSocket_t hListenSocket, void *pubDest, uint32 cubDest, uint32
        ///     *pcubMsgSize, SNetSocket_t *phSocket );
        /// </code>
        /// 
        /// <br />
        /// Retrieves data from any socket that has been connected off this listen socket.<br />
        /// <br />
        /// fills in pubDest with the contents of the message<br />
        /// messages are always complete, of the same size as was sent (i.e. packetized, not streaming)<br />
        /// if *pcubMsgSize &lt; cubDest, only partial data is written<br />
        /// returns false if no data is available<br />
        /// fills out *phSocket with the socket that data is available on<br />
        /// <br />
        /// This is part of an older set of functions designed around the Berkeley TCP sockets model. It's
        /// preferential that you use the P2P functions, they're more robust and these older functions will be
        /// removed eventually.<br />
        /// <br />
        /// <b>Returns:</b> bool
        /// </summary>
        /// <param name="hListenSocket">SNetListenSocket_t: </param>
        /// <param name="pubDest">void *: </param>
        /// <param name="cubDest">uint32: </param>
        /// <param name="pcubMsgSize">uint32
        ///             *: </param>
        /// <param name="phSocket">SNetSocket_t
        ///             *: </param>
        public static bool RetrieveData(SNetListenSocket hListenSocket, void* pubDest, uint cubDest, uint* pcubMsgSize, SNetSocket* phSocket) => Instance.RetrieveData(hListenSocket, pubDest, cubDest, pcubMsgSize, phSocket);
        /// <summary>
        /// <code>
        ///     bool GetSocketInfo( SNetSocket_t hSocket, CSteamID *pSteamIDRemote, int *peSocketStatus, uint32
        ///     *punIPRemote, uint16 *punPortRemote );
        /// </code>
        /// 
        /// <br />
        /// Returns information about the specified socket, filling out the contents of the pointers.<br />
        /// <br />
        /// This is part of an older set of functions designed around the Berkeley TCP sockets model it's
        /// preferential that you use the P2P functions, they're more robust and these older functions will be
        /// removed eventually.<br />
        /// <br />
        /// <b>Returns:</b> bool
        /// </summary>
        /// <param name="hSocket">SNetSocket_t: </param>
        /// <param name="pSteamIDRemote">CSteamID
        ///             *: </param>
        /// <param name="peSocketStatus">int *: </param>
        /// <param name="punIPRemote">uint32
        ///             *: </param>
        /// <param name="punPortRemote">uint16
        ///             *: </param>
        public static bool GetSocketInfo(SNetSocket hSocket, SteamId* pSteamIDRemote, int* peSocketStatus, SteamIPAddress* punIPRemote, ushort* punPortRemote) => Instance.GetSocketInfo(hSocket, pSteamIDRemote, peSocketStatus, punIPRemote, punPortRemote);
        /// <summary>
        /// <code>
        ///     bool GetListenSocketInfo( SNetListenSocket_t hListenSocket, uint32 *pnIP, uint16 *pnPort );
        /// </code>
        /// 
        /// <br />
        /// Returns which local port the listen socket is bound to.<br />
        /// <br />
        /// *pnIP and *pnPort will be 0 if the socket is set to listen for P2P connections only<br />
        /// <br />
        /// This is part of an older set of functions designed around the Berkeley TCP sockets model. It's
        /// preferential that you use the P2P functions, they're more robust and these older functions will be
        /// removed eventually.<br />
        /// <br />
        /// <b>Returns:</b> bool
        /// </summary>
        /// <param name="hListenSocket">SNetListenSocket_t: </param>
        /// <param name="pnIP">uint32
        ///             *: </param>
        /// <param name="pnPort">uint16
        ///             *: </param>
        public static bool GetListenSocketInfo(SNetListenSocket hListenSocket, SteamIPAddress* pnIP, ushort* pnPort) => Instance.GetListenSocketInfo(hListenSocket, pnIP, pnPort);
        /// <summary>
        /// <code>
        ///     ESNetSocketConnectionType GetSocketConnectionType( SNetSocket_t hSocket );
        /// </code>
        /// 
        /// <br />
        /// Returns true to describe how the socket ended up connecting.<br />
        /// <br />
        /// This is part of an older set of functions designed around the Berkeley TCP sockets model. It's
        /// preferential that you use the P2P functions, they're more robust and these older functions will be
        /// removed eventually.<br />
        /// <br />
        /// <b>Returns:</b>
        /// <a href="https://partner.steamgames.com/doc/api/ISteamNetworking#ESNetSocketConnectionType" class="bb_apilink">ESNetSocketConnectionType</a>
        /// </summary>
        /// <param name="hSocket">SNetSocket_t: </param>
        public static SNetSocketConnectionType GetSocketConnectionType(SNetSocket hSocket) => Instance.GetSocketConnectionType(hSocket);
        /// <summary>
        /// <code>int GetMaxPacketSize( SNetSocket_t hSocket );</code>
        /// 
        /// <br />
        /// Gets the max packet size, in bytes.<br />
        /// <br />
        /// This is part of an older set of functions designed around the Berkeley TCP sockets model it's
        /// preferential that you use the P2P functions, they're more robust and these older functions will be
        /// removed eventually.<br />
        /// <br />
        /// <b>Returns:</b> int
        /// </summary>
        /// <param name="hSocket">SNetSocket_t: </param>
        public static int GetMaxPacketSize(SNetSocket hSocket) => Instance.GetMaxPacketSize(hSocket);
    }
}