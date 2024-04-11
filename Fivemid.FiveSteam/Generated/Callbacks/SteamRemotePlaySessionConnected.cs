using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamRemotePlaySessionConnected_t</summary>
    public unsafe struct SteamRemotePlaySessionConnected : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SteamRemotePlaySessionConnected;
        /// <summary>RemotePlaySessionID_t m_unSessionID</summary>
        public RemotePlaySessionID unSessionID;
    }
}