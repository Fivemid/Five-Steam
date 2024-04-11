using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamInventoryFullUpdate_t</summary>
    public unsafe struct SteamInventoryFullUpdate : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SteamInventoryFullUpdate;
        /// <summary>SteamInventoryResult_t m_handle</summary>
        public SteamInventoryResult handle;
    }
}