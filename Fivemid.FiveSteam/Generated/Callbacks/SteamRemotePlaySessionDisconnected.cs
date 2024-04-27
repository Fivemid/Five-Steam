using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary><br />
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct SteamRemotePlaySessionDisconnected
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SteamRemotePlaySessionDisconnected;
        /// <summary>The session ID of the session that just disconnected</summary>
        public RemotePlaySessionID unSessionID;
    }
}