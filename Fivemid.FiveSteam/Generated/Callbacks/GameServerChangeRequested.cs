using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when the user tries to join a different game server from their friends list. The game client should attempt to connect to the specified server when this is received.<br />
    /// <br />
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct GameServerChangeRequested
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.GameServerChangeRequested;
        /// <summary>Server address (e.g. "127.0.0.1:27015", <a href="http://%22tf2.valvesoftware.com%22)" target="_blank" rel="noreferrer">"tf2.valvesoftware.com")</a></summary>
        public UTF8String64 rgchServer;
        /// <summary>Server password, if any.</summary>
        public UTF8String64 rgchPassword;
    }
}