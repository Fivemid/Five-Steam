using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamNetConnectionStatusChangedCallback_t</summary>
    public unsafe struct SteamNetConnectionStatusChangedCallback
    {
        /// <summary>HSteamNetConnection m_hConn</summary>
        public HSteamNetConnection hConn;
        /// <summary>SteamNetConnectionInfo_t m_info</summary>
        public SteamNetConnectionInfo info;
        /// <summary>ESteamNetworkingConnectionState m_eOldState</summary>
        public SteamNetworkingConnectionState eOldState;
    }
}