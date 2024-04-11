using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>GSClientApprove_t</summary>
    public unsafe struct GSClientApprove : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.GSClientApprove;
        /// <summary>CSteamID m_SteamID</summary>
        public SteamId SteamID;
        /// <summary>CSteamID m_OwnerSteamID</summary>
        public SteamId OwnerSteamID;
    }
}