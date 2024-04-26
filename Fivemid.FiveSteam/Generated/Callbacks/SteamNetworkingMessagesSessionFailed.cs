using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary><br />
    /// Posted when we fail to establish a connection, or we detect that communications have been disrupted it an unusual way.  There is no notification when a peer proactively closes the session.  ("Closed by peer" is not a concept of UDP-style communications, and ISteamNetworkingMessages is primarily intended to make porting UDP code easy.)<br />
    /// <br />
    /// Remember: callbacks are asynchronous.   See notes on <a href="https://partner.steamgames.com/doc/api/ISteamNetworkingMessages#SendMessageToUser" class="bb_apilink">ISteamNetworkingMessages::SendMessageToUser</a>, and k_nSteamNetworkingSend_AutoRestartBrokenSession in particular.<br />
    /// <br />
    /// Also, if a session times out due to inactivity, no callbacks will be posted.  The only way to detect that this is happening is that querying the session state may return none, connecting, and findingroute again.<br />
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct SteamNetworkingMessagesSessionFailed : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SteamNetworkingMessagesSessionFailed;
        /// <summary>Detailed info about the session that failed.
        /// SteamNetConnectionInfo_t::m_identityRemote indicates who this session
        /// was with.</summary>
        public SteamNetConnectionInfo info;
    }
}