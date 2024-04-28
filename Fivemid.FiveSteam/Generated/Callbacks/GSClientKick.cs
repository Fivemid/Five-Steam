using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when the game server should kick the user.<br />
    /// <br />
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct GSClientKick
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.GSClientKick;
        /// <summary>The Steam ID of the player that should be kicked.</summary>
        public SteamId SteamID;
        /// <summary>The reason the player is being kicked.</summary>
        public DenyReason eDenyReason;
    }
}