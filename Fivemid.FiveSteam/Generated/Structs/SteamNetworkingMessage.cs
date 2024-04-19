using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamNetworkingMessage_t</summary>
    public unsafe struct SteamNetworkingMessage
    {
        /// <summary>void * m_pData</summary>
        public void* pData;
        /// <summary>int m_cbSize</summary>
        public int cbSize;
        /// <summary>HSteamNetConnection m_conn</summary>
        public HSteamNetConnection conn;
        /// <summary>SteamNetworkingIdentity m_identityPeer</summary>
        public SteamNetworkingIdentity identityPeer;
        /// <summary>int64 m_nConnUserData</summary>
        public long nConnUserData;
        /// <summary>SteamNetworkingMicroseconds m_usecTimeReceived</summary>
        public SteamNetworkingMicroseconds usecTimeReceived;
        /// <summary>int64 m_nMessageNumber</summary>
        public long nMessageNumber;
        /// <summary>void (*)(SteamNetworkingMessage_t *) m_pfnFreeData</summary>
        public global::Unity.Burst.FunctionPointer<FunctionPointerDelegates.SteamNetworkingMessagePtr> pfnFreeData;
        /// <summary>void (*)(SteamNetworkingMessage_t *) m_pfnRelease</summary>
        public global::Unity.Burst.FunctionPointer<FunctionPointerDelegates.SteamNetworkingMessagePtr> pfnRelease;
        /// <summary>int m_nChannel</summary>
        public int nChannel;
        /// <summary>int m_nFlags</summary>
        public int nFlags;
        /// <summary>int64 m_nUserData</summary>
        public long nUserData;
        /// <summary>uint16 m_idxLane</summary>
        public ushort idxLane;
        /// <summary>uint16 _pad1__</summary>
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