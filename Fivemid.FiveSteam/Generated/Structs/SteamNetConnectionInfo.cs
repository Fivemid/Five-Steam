using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// <br />
    /// Describe the state of a connection.<br />
    /// <code>
    ///     struct SteamNetConnectionInfo_t { /// Who is on the other end? Depending on the connection type
    ///     and phase of the connection, we might not know SteamNetworkingIdentity m_identityRemote; ///
    ///     Arbitrary user data set by the local application code int64 m_nUserData; /// Handle to listen
    ///     socket this was connected on, or k_HSteamListenSocket_Invalid if we initiated the connection
    ///     HSteamListenSocket m_hListenSocket; /// Remote address. Might be all 0's if we don't know it, or
    ///     if this is N/A. /// (E.g. Basically everything except direct UDP connection.)
    ///     SteamNetworkingIPAddr m_addrRemote; uint16 m__pad1; /// What data center is the remote host in?
    ///     (0 if we don't know.) SteamNetworkingPOPID m_idPOPRemote; /// What relay are we using to
    ///     communicate with the remote host? /// (0 if not applicable.) SteamNetworkingPOPID m_idPOPRelay;
    ///     /// High level state of the connection ESteamNetworkingConnectionState m_eState; /// Basic cause
    ///     of the connection termination or problem. /// See ESteamNetConnectionEnd for the values used int
    ///     m_eEndReason; /// Human-readable, but non-localized explanation for connection /// termination
    ///     or problem. This is intended for debugging / /// diagnostic purposes only, not to display to
    ///     users. It might /// have some details specific to the issue. char m_szEndDebug[]; /// Debug
    ///     description. This includes the connection handle, /// connection type (and peer information),
    ///     and the app name. /// This string is used in various internal logging messages char
    ///     m_szConnectionDescription[]; /// Internal stuff, room to change API easily uint32 reserved[64];
    ///     };
    /// </code>
    /// </summary>
    public unsafe struct SteamNetConnectionInfo
    {
        /// missing documentation for SteamNetConnectionInfo_t.m_identityRemote
        public SteamNetworkingIdentity identityRemote;
        /// missing documentation for SteamNetConnectionInfo_t.m_nUserData
        public long nUserData;
        /// missing documentation for SteamNetConnectionInfo_t.m_hListenSocket
        public HSteamListenSocket hListenSocket;
        /// missing documentation for SteamNetConnectionInfo_t.m_addrRemote
        public SteamNetworkingIPAddr addrRemote;
        /// missing documentation for SteamNetConnectionInfo_t.m__pad1
        public ushort _pad1;
        /// missing documentation for SteamNetConnectionInfo_t.m_idPOPRemote
        public SteamNetworkingPOPID idPOPRemote;
        /// missing documentation for SteamNetConnectionInfo_t.m_idPOPRelay
        public SteamNetworkingPOPID idPOPRelay;
        /// missing documentation for SteamNetConnectionInfo_t.m_eState
        public SteamNetworkingConnectionState eState;
        /// missing documentation for SteamNetConnectionInfo_t.m_eEndReason
        public int eEndReason;
        /// missing documentation for SteamNetConnectionInfo_t.m_szEndDebug
        public UTF8String128 szEndDebug;
        /// missing documentation for SteamNetConnectionInfo_t.m_szConnectionDescription
        public UTF8String128 szConnectionDescription;
        /// missing documentation for SteamNetConnectionInfo_t.m_nFlags
        public int nFlags;
        /// missing documentation for SteamNetConnectionInfo_t.reserved
        public FixedArray_uint63 reserved;
    }
}