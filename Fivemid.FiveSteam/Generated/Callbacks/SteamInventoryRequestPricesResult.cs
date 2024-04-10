using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamInventoryRequestPricesResult_t</summary>
    public unsafe struct SteamInventoryRequestPricesResult
    {
        /// <summary>EResult m_result</summary>
        public Result result;
        /// <summary>char [4] m_rgchCurrency</summary>
        public UTF8String4 rgchCurrency;
    }
}