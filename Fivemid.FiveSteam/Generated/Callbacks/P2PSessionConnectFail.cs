using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when packets can't get through to the specified user.<br />
    /// All queued packets unsent at this point will be dropped, further attempts to send will retry making the connection (but will be dropped if we fail again).<br />
    /// <br />
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct P2PSessionConnectFail
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.P2PSessionConnectFail;
        /// <summary>User we were trying to send the packets to.</summary>
        public SteamId steamIDRemote;
        /// <summary>Indicates the reason why we're having trouble. Actually a <a href="https://partner.steamgames.com/doc/api/ISteamNetworking#EP2PSessionError" class="bb_apilink">EP2PSessionError</a>.</summary>
        public byte eP2PSessionError;
    }
}