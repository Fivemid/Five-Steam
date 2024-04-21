using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// A user wants to communicate with us over the P2P channel via the
    /// <a href="https://partner.steamgames.com/doc/api/ISteamNetworking#SendP2PPacket" class="bb_apilink">ISteamNetworking::SendP2PPacket</a>. In response, a call to
    /// <a href="https://partner.steamgames.com/doc/api/ISteamNetworking#AcceptP2PSessionWithUser" class="bb_apilink">ISteamNetworking::AcceptP2PSessionWithUser</a>
    /// needs to be made, if you want to open the network channel with them.<br />
    /// <br />
    /// 
    /// <br />
    /// <b>Associated Functions:</b>
    /// <a href="https://partner.steamgames.com/doc/api/ISteamNetworking#SendP2PPacket" class="bb_apilink">ISteamNetworking::SendP2PPacket</a>
    /// </summary>
    public unsafe struct P2PSessionRequest : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.P2PSessionRequest;
        /// <summary>The user who wants to start a P2P session with us.</summary>
        public SteamId steamIDRemote;
    }
}