using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for SteamDatagramGameCoordinatorServerLogin
    public unsafe struct SteamDatagramGameCoordinatorServerLogin
    {
        /// missing documentation for SteamDatagramGameCoordinatorServerLogin.m_identity
        public SteamNetworkingIdentity identity;
        /// missing documentation for SteamDatagramGameCoordinatorServerLogin.m_routing
        public SteamDatagramHostedAddress routing;
        /// missing documentation for SteamDatagramGameCoordinatorServerLogin.m_nAppID
        public AppId nAppID;
        /// missing documentation for SteamDatagramGameCoordinatorServerLogin.m_rtime
        public RTime32 rtime;
        /// missing documentation for SteamDatagramGameCoordinatorServerLogin.m_cbAppData
        public int cbAppData;
        /// missing documentation for SteamDatagramGameCoordinatorServerLogin.m_appData
        public UTF8String2048 appData;
    }
}