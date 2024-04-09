using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamDatagramGameCoordinatorServerLogin</summary>
    public unsafe struct SteamDatagramGameCoordinatorServerLogin
    {
        /// <summary>SteamNetworkingIdentity m_identity</summary>
        public SteamNetworkingIdentity identity;
        /// <summary>SteamDatagramHostedAddress m_routing</summary>
        public SteamDatagramHostedAddress routing;
        /// <summary>AppId_t m_nAppID</summary>
        public AppId nAppID;
        /// <summary>RTime32 m_rtime</summary>
        public RTime32 rtime;
        /// <summary>int m_cbAppData</summary>
        public int cbAppData;
        /// <summary>char [2048] m_appData</summary>
        public UTF8String2048 appData;
    }
}