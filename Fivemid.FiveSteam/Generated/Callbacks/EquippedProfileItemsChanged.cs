using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EquippedProfileItemsChanged_t</summary>
    public unsafe struct EquippedProfileItemsChanged : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.EquippedProfileItemsChanged;
        /// <summary>CSteamID m_steamID</summary>
        public SteamId steamID;
    }
}