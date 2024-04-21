using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// <br />
    /// 
    /// </summary>
    public unsafe struct SteamRemotePlaySessionConnected : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SteamRemotePlaySessionConnected;
        /// <summary>The session ID of the session that just connected</summary>
        public RemotePlaySessionID unSessionID;
    }
}