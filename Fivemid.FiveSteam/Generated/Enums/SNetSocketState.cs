using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ESNetSocketState</summary>
    public enum SNetSocketState : int
    {
        /// <summary>k_ESNetSocketStateInvalid</summary>
        Invalid = 0,
        /// <summary>k_ESNetSocketStateConnected</summary>
        Connected = 1,
        /// <summary>k_ESNetSocketStateInitiated</summary>
        Initiated = 10,
        /// <summary>k_ESNetSocketStateLocalCandidatesFound</summary>
        LocalCandidatesFound = 11,
        /// <summary>k_ESNetSocketStateReceivedRemoteCandidates</summary>
        ReceivedRemoteCandidates = 12,
        /// <summary>k_ESNetSocketStateChallengeHandshake</summary>
        ChallengeHandshake = 15,
        /// <summary>k_ESNetSocketStateDisconnecting</summary>
        Disconnecting = 21,
        /// <summary>k_ESNetSocketStateLocalDisconnect</summary>
        LocalDisconnect = 22,
        /// <summary>k_ESNetSocketStateTimeoutDuringConnect</summary>
        TimeoutDuringConnect = 23,
        /// <summary>k_ESNetSocketStateRemoteEndDisconnected</summary>
        RemoteEndDisconnected = 24,
        /// <summary>k_ESNetSocketStateConnectionBroken</summary>
        ConnectionBroken = 25
    }
}