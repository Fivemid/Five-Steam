using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when a user has been denied to connection to this game server.<br />
    /// <br />
    /// </summary>
    public unsafe struct GSClientDeny : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.GSClientDeny;
        /// <summary>The Steam ID of the user that attempted to connect.</summary>
        public SteamId SteamID;
        /// <summary>The reason the player was denied.</summary>
        public DenyReason eDenyReason;
        /// <summary>An optional text message explaining the deny reason. Typically unused except for logging.</summary>
        public UTF8String128 rgchOptionalText;
    }
}