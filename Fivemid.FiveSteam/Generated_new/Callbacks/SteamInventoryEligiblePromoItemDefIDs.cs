using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamInventoryEligiblePromoItemDefIDs_t</summary>
    public unsafe struct SteamInventoryEligiblePromoItemDefIDs
    {
        /// <summary>EResult m_result</summary>
        public Result result;
        /// <summary>CSteamID m_steamID</summary>
        public SteamId steamID;
        /// <summary>int m_numEligiblePromoItemDefs</summary>
        public int numEligiblePromoItemDefs;
        /// <summary>bool m_bCachedData</summary>
        public bool bCachedData;
    }
}