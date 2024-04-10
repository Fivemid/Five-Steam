using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamInventoryStartPurchaseResult_t</summary>
    public unsafe struct SteamInventoryStartPurchaseResult
    {
        /// <summary>EResult m_result</summary>
        public Result result;
        /// <summary>uint64 m_ulOrderID</summary>
        public ulong ulOrderID;
        /// <summary>uint64 m_ulTransID</summary>
        public ulong ulTransID;
    }
}