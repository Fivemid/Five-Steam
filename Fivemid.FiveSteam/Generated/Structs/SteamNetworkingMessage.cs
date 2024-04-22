using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary><br />
    /// A message that has been received<br />
    /// </summary>
    public unsafe struct SteamNetworkingMessage
    {
        /// <summary>Message payload</summary>
        public void* pData;
        /// <summary>Size of the payload.</summary>
        public int cbSize;
        /// <summary>For messages received on connections: what connection did this come from?
        /// For outgoing messages: what connection to send it to?
        /// Not used when using the ISteamNetworkingMessages interface</summary>
        public HSteamNetConnection conn;
        /// <summary>For inbound messages: Who sent this to us?
        /// For outbound messages on connections: not used.
        /// For outbound messages on the ad-hoc ISteamNetworkingMessages interface: who should we send this to?</summary>
        public SteamNetworkingIdentity identityPeer;
        /// <summary>For messages received on connections, this is the user data
        /// associated with the connection.
        /// 
        /// This is *usually* the same as calling GetConnection() and then
        /// fetching the user data associated with that connection, but for
        /// the following subtle differences:
        /// 
        /// - This user data will match the connection's user data at the time
        /// is captured at the time the message is returned by the API.
        /// If you subsequently change the userdata on the connection,
        /// this won't be updated.
        /// - This is an inline call, so it's *much* faster.
        /// - You might have closed the connection, so fetching the user data
        /// would not be possible.
        /// 
        /// Not used when sending messages,</summary>
        public long nConnUserData;
        /// <summary>Local timestamp when the message was received
        /// Not used for outbound messages.</summary>
        public SteamNetworkingMicroseconds usecTimeReceived;
        /// <summary>Message number assigned by the sender.
        /// This is not used for outbound messages</summary>
        public long nMessageNumber;
        /// missing documentation for SteamNetworkingMessage_t.m_pfnFreeData
        public global::Unity.Burst.FunctionPointer<FunctionPointerDelegates.SteamNetworkingMessagePtr> pfnFreeData;
        /// missing documentation for SteamNetworkingMessage_t.m_pfnRelease
        public global::Unity.Burst.FunctionPointer<FunctionPointerDelegates.SteamNetworkingMessagePtr> pfnRelease;
        /// <summary>When using ISteamNetworkingMessages, the channel number the message was received on
        /// (Not used for messages sent or received on "connections")</summary>
        public int nChannel;
        /// <summary>Bitmask of k_nSteamNetworkingSend_xxx flags.
        /// For received messages, only the k_nSteamNetworkingSend_Reliable bit is valid.
        /// For outbound messages, all bits are relevant</summary>
        public int nFlags;
        /// <summary>Arbitrary user data that you can use when sending messages using
        /// ISteamNetworkingUtils::AllocateMessage and ISteamNetworkingSockets::SendMessage.
        /// (The callback you set in m_pfnFreeData might use this field.)
        /// 
        /// Not used for received messages.</summary>
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