using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary><br />
    /// </summary>
    public unsafe struct SteamRemotePlaySessionDisconnected : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SteamRemotePlaySessionDisconnected;
        /// <summary>The session ID of the session that just disconnected</summary>
        public RemotePlaySessionID unSessionID;
    }
}