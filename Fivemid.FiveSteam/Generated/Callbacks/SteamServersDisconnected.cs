using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Called if the client has lost connection to the Steam servers.<br />
    /// Real-time services will be disabled until a matching
    /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#SteamServersConnected_t" class="bb_apilink">SteamServersConnected_t</a>
    /// has been posted.<br />
    /// <br />
    /// 
    /// </summary>
    public unsafe struct SteamServersDisconnected : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SteamServersDisconnected;
        /// <summary>The reason we were disconnected from Steam.</summary>
        public Result eResult;
    }
}