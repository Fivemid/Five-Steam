using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// <br />
    /// Posted when a remote host is sending us a message, and we do not already have a session with them<br />
    /// <br />
    /// <code>
    ///     struct SteamNetworkingMessagesSessionRequest_t { /// User who wants to talk to us
    ///     SteamNetworkingIdentity m_identityRemote; };
    /// </code>
    /// </summary>
    public unsafe struct SteamNetworkingMessagesSessionRequest : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SteamNetworkingMessagesSessionRequest;
        /// missing documentation for SteamNetworkingMessagesSessionRequest_t.m_identityRemote
        public SteamNetworkingIdentity identityRemote;
    }
}