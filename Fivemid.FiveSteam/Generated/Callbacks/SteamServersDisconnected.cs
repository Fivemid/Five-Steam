using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamServersDisconnected_t</summary>
    public unsafe struct SteamServersDisconnected : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SteamServersDisconnected;
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
    }
}