using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary><br />
    /// Posted when a remote host is sending us a message, and we do not already have a session with them<br />
    /// <br />
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct SteamNetworkingMessagesSessionRequest
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SteamNetworkingMessagesSessionRequest;
        /// <summary>User who wants to talk to us</summary>
        public SteamNetworkingIdentity identityRemote;
    }
}