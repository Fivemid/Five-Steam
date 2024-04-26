using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary><br />
    /// Describe the state of a connection.<br />
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct SteamNetConnectionInfo
    {
        /// <summary>Who is on the other end?  Depending on the connection type and phase of the connection, we might not know</summary>
        public SteamNetworkingIdentity identityRemote;
        /// <summary>Arbitrary user data set by the local application code</summary>
        public long nUserData;
        /// <summary>Handle to listen socket this was connected on, or k_HSteamListenSocket_Invalid if we initiated the connection</summary>
        public HSteamListenSocket hListenSocket;
        /// <summary>Remote address.  Might be all 0's if we don't know it, or if this is N/A.
        /// (E.g. Basically everything except direct UDP connection.)</summary>
        public SteamNetworkingIPAddr addrRemote;
        /// <summary></summary>
        public ushort _pad1;
        /// <summary>What data center is the remote host in?  (0 if we don't know.)</summary>
        public SteamNetworkingPOPID idPOPRemote;
        /// <summary>What relay are we using to communicate with the remote host?
        /// (0 if not applicable.)</summary>
        public SteamNetworkingPOPID idPOPRelay;
        /// <summary>High level state of the connection</summary>
        public SteamNetworkingConnectionState eState;
        /// <summary>Basic cause of the connection termination or problem.
        /// See ESteamNetConnectionEnd for the values used</summary>
        public int eEndReason;
        /// <summary>Human-readable, but non-localized explanation for connection
        /// termination or problem.  This is intended for debugging /
        /// diagnostic purposes only, not to display to users.  It might
        /// have some details specific to the issue.</summary>
        public UTF8String128 szEndDebug;
        /// <summary>Debug description.  This includes the connection handle,
        /// connection type (and peer information), and the app name.
        /// This string is used in various internal logging messages</summary>
        public UTF8String128 szConnectionDescription;
        /// missing documentation for SteamNetConnectionInfo_t.m_nFlags
        public int nFlags;
        /// <summary>Internal stuff, room to change API easily</summary>
        public FixedArray_uint63 reserved;
    }
}