using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>A client has been approved to connect to this game server.<br />
    /// <br />
    /// </summary>
    public unsafe struct GSClientApprove : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.GSClientApprove;
        /// <summary>The Steam ID of the user that is wanting to connect.</summary>
        public SteamId SteamID;
        /// <summary>The Steam ID that owns the game, this will be different from <code class="bb_code bb_code_inline nohighlight">m_SteamID</code> if the game is accessed via Steam Family Sharing.</summary>
        public SteamId OwnerSteamID;
    }
}