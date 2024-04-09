using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamInventoryResultReady_t</summary>
    public unsafe struct SteamInventoryResultReady
    {
        /// <summary>SteamInventoryResult_t m_handle</summary>
        public SteamInventoryResult handle;
        /// <summary>EResult m_result</summary>
        public Result result;
    }
}