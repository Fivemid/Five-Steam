using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamNetConnectionInfo_t</summary>
    public unsafe struct SteamNetConnectionInfo
    {
        /// <summary>SteamNetworkingIdentity m_identityRemote</summary>
        public SteamNetworkingIdentity identityRemote;
        /// <summary>int64 m_nUserData</summary>
        public long nUserData;
        /// <summary>HSteamListenSocket m_hListenSocket</summary>
        public HSteamListenSocket hListenSocket;
        /// <summary>SteamNetworkingIPAddr m_addrRemote</summary>
        public SteamNetworkingIPAddr addrRemote;
        /// <summary>uint16 m__pad1</summary>
        public ushort _pad1;
        /// <summary>SteamNetworkingPOPID m_idPOPRemote</summary>
        public SteamNetworkingPOPID idPOPRemote;
        /// <summary>SteamNetworkingPOPID m_idPOPRelay</summary>
        public SteamNetworkingPOPID idPOPRelay;
        /// <summary>ESteamNetworkingConnectionState m_eState</summary>
        public SteamNetworkingConnectionState eState;
        /// <summary>int m_eEndReason</summary>
        public int eEndReason;
        /// <summary>char [128] m_szEndDebug</summary>
        public UTF8String128 szEndDebug;
        /// <summary>char [128] m_szConnectionDescription</summary>
        public UTF8String128 szConnectionDescription;
        /// <summary>int m_nFlags</summary>
        public int nFlags;
        /// <summary>uint32 [63] reserved</summary>
        public FixedArray_uint63 reserved;
    }
}