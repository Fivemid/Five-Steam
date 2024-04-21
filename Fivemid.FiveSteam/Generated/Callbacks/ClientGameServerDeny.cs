using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Sent by the Steam server to the client telling it to disconnect from the specified game server,
    /// which it may be in the process of or already connected to.<br />
    /// The game client should immediately disconnect upon receiving this message.<br />
    /// This can usually occur if the user doesn't have rights to play on the game server.<br />
    /// <br />
    /// 
    /// </summary>
    public unsafe struct ClientGameServerDeny : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.ClientGameServerDeny;
        /// <summary>
        ///             The App ID this call is for. Verify that it's the same as the current App ID with
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamUtils#GetAppID" class="bb_apilink">ISteamUtils::GetAppID</a>.
        ///         </summary>
        public uint uAppID;
        /// <summary>
        ///             The IP of the game server that is telling us to disconnect, in host order, i.e 127.0.0.1
        ///             == 0x7f000001.
        ///         </summary>
        public uint unGameServerIP;
        /// <summary>The port of the game server that is telling us to disconnect, in host order.</summary>
        public ushort usGameServerPort;
        /// <summary>
        ///             Is the game server VAC secure (<b>true</b>) or not (<b>false</b>)?
        ///         </summary>
        public ushort bSecure;
        /// <summary></summary>
        public uint uReason;
    }
}