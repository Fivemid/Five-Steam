using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// List of possible errors returned by
    /// <a href="https://partner.steamgames.com/doc/api/ISteamNetworking#SendP2PPacket" class="bb_apilink">ISteamNetworking::SendP2PPacket</a>, these will be sent in the
    /// <a href="https://partner.steamgames.com/doc/api/ISteamNetworking#P2PSessionConnectFail_t" class="bb_apilink">P2PSessionConnectFail_t</a>
    /// callback.<br />
    /// <br />
    /// 
    /// </summary>
    public enum P2PSessionError : int
    {
        /// <summary>There was no error.</summary>
        None = 0,
        /// <summary>The local user doesn't own the app that is running.</summary>
        NoRightsToApp = 2,
        /// <summary>
        ///             The connection timed out because the target user didn't respond, perhaps they aren't
        ///             calling
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamNetworking#AcceptP2PSessionWithUser" class="bb_apilink">ISteamNetworking::AcceptP2PSessionWithUser</a>.<br />
        ///             Corporate firewalls can also block this (NAT traversal is not firewall traversal), make
        ///             sure that UDP ports 3478, 4379, and 4380 are open in an outbound direction.
        ///         </summary>
        Timeout = 4,
        /// missing documentation for EP2PSessionError.k_EP2PSessionErrorNotRunningApp_DELETED
        NotRunningApp_DELETED = 1,
        /// missing documentation for EP2PSessionError.k_EP2PSessionErrorDestinationNotLoggedIn_DELETED
        DestinationNotLoggedIn_DELETED = 3,
        /// <summary>Unused.</summary>
        Max = 5
    }
}