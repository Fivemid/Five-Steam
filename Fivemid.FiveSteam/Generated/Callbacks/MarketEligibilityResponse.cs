using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>MarketEligibilityResponse_t</summary>
    public unsafe struct MarketEligibilityResponse : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.MarketEligibilityResponse;
        /// <summary>bool m_bAllowed</summary>
        public bool bAllowed;
        /// <summary>EMarketNotAllowedReasonFlags m_eNotAllowedReason</summary>
        public MarketNotAllowedReasonFlags eNotAllowedReason;
        /// <summary>RTime32 m_rtAllowedAtTime</summary>
        public RTime32 rtAllowedAtTime;
        /// <summary>int m_cdaySteamGuardRequiredDays</summary>
        public int cdaySteamGuardRequiredDays;
        /// <summary>int m_cdayNewDeviceCooldown</summary>
        public int cdayNewDeviceCooldown;
    }
}