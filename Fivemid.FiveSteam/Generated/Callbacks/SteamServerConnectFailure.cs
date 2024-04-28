using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when a connection attempt has failed.<br />
    /// This will occur periodically if the Steam client is not connected, and has failed when retrying to establish a connection.<br />
    /// <br />
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct SteamServerConnectFailure
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SteamServerConnectFailure;
        /// <summary>The reason why the connection failed.</summary>
        public Result eResult;
        /// <summary>Is the Steam client still trying to connect to the server?</summary>
        public bool bStillRetrying;
    }
}