using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamInventoryResultReady_t</summary>
    public unsafe struct SteamInventoryResultReady : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SteamInventoryResultReady;
        /// <summary>SteamInventoryResult_t m_handle</summary>
        public SteamInventoryResult handle;
        /// <summary>EResult m_result</summary>
        public Result result;
    }
}