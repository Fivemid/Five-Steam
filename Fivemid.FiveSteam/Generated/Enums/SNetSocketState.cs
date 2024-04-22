using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Connection progress indicators, used by <a href="https://partner.steamgames.com/doc/api/ISteamNetworking#CreateP2PConnectionSocket" class="bb_apilink">ISteamNetworking::CreateP2PConnectionSocket</a>.<br />
    /// <br />
    /// </summary>
    public enum SNetSocketState : int
    {
        /// <summary></summary>
        Invalid = 0,
        /// <summary>communication is valid</summary>
        Connected = 1,
        /// <summary>states while establishing a connection<br />
        /// the connection state machine has started</summary>
        Initiated = 10,
        /// <summary>p2p connections<br />
        /// we've found our local IP info</summary>
        LocalCandidatesFound = 11,
        /// <summary>we've received information from the remote machine, via the Steam back-end, about their IP info</summary>
        ReceivedRemoteCandidates = 12,
        /// <summary>direct connections<br />
        /// we've received a challenge packet from the server</summary>
        ChallengeHandshake = 15,
        /// <summary>failure states<br />
        /// the API shut it down, and we're in the process of telling the other end</summary>
        Disconnecting = 21,
        /// <summary>the API shut it down, and we've completed shutdown</summary>
        LocalDisconnect = 22,
        /// <summary>we timed out while trying to creating the connection</summary>
        TimeoutDuringConnect = 23,
        /// <summary>the remote end has disconnected from us</summary>
        RemoteEndDisconnected = 24,
        /// <summary>connection has been broken; either the other end has disappeared or our local network connection has broke</summary>
        ConnectionBroken = 25
    }
}