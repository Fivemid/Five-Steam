using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// <br />
    /// A message that has been received<br />
    /// <code>
    ///     struct SteamNetworkingMessage_t { /// Message payload void *m_pData; /// Size of the payload.
    ///     int m_cbSize; /// For messages received on connections: what connection did this come from? ///
    ///     For outgoing messages: what connection to send it to? /// Not used when using the
    ///     ISteamNetworkingMessages interface HSteamNetConnection m_conn; /// For inbound messages: Who
    ///     sent this to us? /// For outbound messages on connections: not used. /// For outbound messages
    ///     on the ad-hoc ISteamNetworkingMessages interface: who should we send this to?
    ///     SteamNetworkingIdentity m_identityPeer; /// For messages received on connections, this is the
    ///     user data /// associated with the connection. /// /// This is *usually* the same as calling
    ///     GetConnection() and then /// fetching the user data associated with that connection, but for ///
    ///     the following subtle differences: /// /// - This user data will match the connection's user data
    ///     at the time /// is captured at the time the message is returned by the API. /// If you
    ///     subsequently change the userdata on the connection, /// this won't be updated. /// - This is an
    ///     inline call, so it's *much* faster. /// - You might have closed the connection, so fetching the
    ///     user data /// would not be possible. /// /// Not used when sending messages, int64
    ///     m_nConnUserData; /// Local timestamp when the message was received /// Not used for outbound
    ///     messages. SteamNetworkingMicroseconds m_usecTimeReceived; /// Message number assigned by the
    ///     sender. /// This is not used for outbound messages int64 m_nMessageNumber; /// Function used to
    ///     free up m_pData. This mechanism exists so that /// apps can create messages with buffers
    ///     allocated from their own /// heap, and pass them into the library. This function will ///
    ///     usually be something like: /// /// free( pMsg-&gt;m_pData ); void (*m_pfnFreeData)(
    ///     SteamNetworkingMessage_t *pMsg ); /// Function to used to decrement the internal reference count
    ///     and, if /// it's zero, release the message. You should not set this function pointer, /// or
    ///     need to access this directly! Use the Release() function instead! void (*m_pfnRelease)(
    ///     SteamNetworkingMessage_t *pMsg ); /// When using ISteamNetworkingMessages, the channel number
    ///     the message was received on /// (Not used for messages sent or received on "connections") int
    ///     m_nChannel; /// Bitmask of k_nSteamNetworkingSend_xxx flags. /// For received messages, only the
    ///     k_nSteamNetworkingSend_Reliable bit is valid. /// For outbound messages, all bits are relevant
    ///     int m_nFlags; /// Arbitrary user data that you can use when sending messages using ///
    ///     ISteamNetworkingUtils::AllocateMessage and ISteamNetworkingSockets::SendMessage. /// (The
    ///     callback you set in m_pfnFreeData might use this field.) /// /// Not used for received messages.
    ///     int64 m_nUserData; /// You MUST call this when you're done with the object, /// to free up
    ///     memory, etc. inline void Release(); };
    /// </code>
    /// </summary>
    public unsafe struct SteamNetworkingMessage
    {
        /// missing documentation for SteamNetworkingMessage_t.m_pData
        public void* pData;
        /// missing documentation for SteamNetworkingMessage_t.m_cbSize
        public int cbSize;
        /// missing documentation for SteamNetworkingMessage_t.m_conn
        public HSteamNetConnection conn;
        /// missing documentation for SteamNetworkingMessage_t.m_identityPeer
        public SteamNetworkingIdentity identityPeer;
        /// missing documentation for SteamNetworkingMessage_t.m_nConnUserData
        public long nConnUserData;
        /// missing documentation for SteamNetworkingMessage_t.m_usecTimeReceived
        public SteamNetworkingMicroseconds usecTimeReceived;
        /// missing documentation for SteamNetworkingMessage_t.m_nMessageNumber
        public long nMessageNumber;
        /// missing documentation for SteamNetworkingMessage_t.m_pfnFreeData
        public global::Unity.Burst.FunctionPointer<FunctionPointerDelegates.SteamNetworkingMessagePtr> pfnFreeData;
        /// missing documentation for SteamNetworkingMessage_t.m_pfnRelease
        public global::Unity.Burst.FunctionPointer<FunctionPointerDelegates.SteamNetworkingMessagePtr> pfnRelease;
        /// missing documentation for SteamNetworkingMessage_t.m_nChannel
        public int nChannel;
        /// missing documentation for SteamNetworkingMessage_t.m_nFlags
        public int nFlags;
        /// missing documentation for SteamNetworkingMessage_t.m_nUserData
        public long nUserData;
        /// missing documentation for SteamNetworkingMessage_t.m_idxLane
        public ushort idxLane;
        /// missing documentation for SteamNetworkingMessage_t._pad1__
        public ushort _pad1__;
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamNetworkingMessage_t_Release", CallingConvention = Platform.CC)]
        internal static extern void Release(SteamNetworkingMessage* self);
        public void Release()
        {
            fixed (SteamNetworkingMessage* self = &this)
                Release(self);
        }
    }
}