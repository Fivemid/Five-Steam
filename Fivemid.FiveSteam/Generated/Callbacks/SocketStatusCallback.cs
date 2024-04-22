using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when the status of a socket has changed, used as part of the <a href="https://partner.steamgames.com/doc/api/ISteamNetworking#CreateListenSocket" class="bb_apilink">ISteamNetworking::CreateListenSocket</a> and <a href="https://partner.steamgames.com/doc/api/ISteamNetworking#CreateP2PConnectionSocket" class="bb_apilink">ISteamNetworking::CreateP2PConnectionSocket</a> calls.<br />
    /// <br />
    /// This is part of an older set of functions designed around the Berkeley TCP sockets model. It's preferential that you use the P2P functions, they're more robust and these older functions will be removed eventually.<br />
    /// <br />
    /// </summary>
    public unsafe struct SocketStatusCallback : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SocketStatusCallback;
        /// <summary>the socket used to send/receive data to the remote host</summary>
        public SNetSocket hSocket;
        /// <summary>this is the server socket that we were listening on; NULL if this was an outgoing connection</summary>
        public SNetListenSocket hListenSocket;
        /// <summary>remote Steam ID we have connected to, if it has one</summary>
        public SteamId steamIDRemote;
        /// <summary>socket state, ESNetSocketState</summary>
        public int eSNetSocketState;
    }
}