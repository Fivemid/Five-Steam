using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamNetworkingMessagesSessionFailed_t</summary>
    public unsafe struct SteamNetworkingMessagesSessionFailed : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SteamNetworkingMessagesSessionFailed;
        /// <summary>SteamNetConnectionInfo_t m_info</summary>
        public SteamNetConnectionInfo info;
    }
}