using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>This callback is posted whenever a connection is created, destroyed, or changes state.  The m_info field will contain a complete description of the connection at the time the change occurred and the callback was posted.  In particular, m_info.m_eState will have the new connection state.<br />
    /// <br />
    /// You will usually need to listen for this callback to know when:<br />
    /// <ul class="bb_ul "><li> <b>A new connection arrives on a listen socket.</b>  m_info.m_hListenSocket will be set, m_eOldState = k_ESteamNetworkingConnectionState_None, and m_info.m_eState = k_ESteamNetworkingConnectionState_Connecting.  See <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingSockets#AcceptConnection" class="bb_apilink">ISteamNetworkingSockets::AcceptConnection</a>.<br />
    /// </li><li> <b>A connection you initiated has been accepted by the remote host.</b>  m_eOldState = k_ESteamNetworkingConnectionState_Connecting, and m_info.m_eState = k_ESteamNetworkingConnectionState_Connected.  Some connections might transition to k_ESteamNetworkingConnectionState_FindingRoute first.<br />
    /// </li><li> <b>A connection has been actively rejected or closed by the remote host.</b>  m_eOldState = k_ESteamNetworkingConnectionState_Connecting or k_ESteamNetworkingConnectionState_Connected, and m_info.m_eState = k_ESteamNetworkingConnectionState_ClosedByPeer.  m_info.m_eEndReason and m_info.m_szEndDebug will have more details.  NOTE: upon receiving this callback, you <i>must</i> still destroy the connection using <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingSockets#CloseConnection" class="bb_apilink">ISteamNetworkingSockets::CloseConnection</a> to free up local resources.  (The details passed to the function are not used in this case, since the connection is already closed.)<br />
    /// </li><li> <b>A problem was detected with the connection, and it has been closed by the local host.</b>  The most common failure is timeout, but other configuration or authentication failures can cause this.  m_eOldState = k_ESteamNetworkingConnectionState_Connecting or k_ESteamNetworkingConnectionState_Connected, and m_info.m_eState = k_ESteamNetworkingConnectionState_ProblemDetectedLocally.  m_info.m_eEndReason and m_info.m_szEndDebug will have more details.  NOTE: upon receiving this callback, you <i>must</i> still destroy the connection using <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingSockets#CloseConnection" class="bb_apilink">ISteamNetworkingSockets::CloseConnection</a> to free up local resources.  (The details passed to the function are not used in this case, since the connection is already closed.)</li></ul><br />
    /// Remember that callbacks are posted to a queue, and networking connections can change at any time.  It is possible that the connection has already changed state by the time you process this callback.<br />
    /// <br />
    /// Also note that callbacks will be posted when connections are created and destroyed by your own API calls.<br />
    /// <br />
    /// </summary>
    public unsafe struct SteamNetConnectionStatusChangedCallback : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SteamNetConnectionStatusChangedCallback;
        /// <summary>Connection handle</summary>
        public HSteamNetConnection hConn;
        /// <summary>Full connection info</summary>
        public SteamNetConnectionInfo info;
        /// <summary>Previous state.  (Current state is in m_info.m_eState)</summary>
        public SteamNetworkingConnectionState eOldState;
    }
}