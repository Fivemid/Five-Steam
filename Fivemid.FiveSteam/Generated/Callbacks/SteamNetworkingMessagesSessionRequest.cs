using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamNetworkingMessagesSessionRequest_t</summary>
    public unsafe struct SteamNetworkingMessagesSessionRequest : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SteamNetworkingMessagesSessionRequest;
        /// <summary>SteamNetworkingIdentity m_identityRemote</summary>
        public SteamNetworkingIdentity identityRemote;
    }
}