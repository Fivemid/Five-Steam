using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for MarketEligibilityResponse_t
    public unsafe struct MarketEligibilityResponse : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.MarketEligibilityResponse;
        /// missing documentation for MarketEligibilityResponse_t.m_bAllowed
        public bool bAllowed;
        /// missing documentation for MarketEligibilityResponse_t.m_eNotAllowedReason
        public MarketNotAllowedReasonFlags eNotAllowedReason;
        /// missing documentation for MarketEligibilityResponse_t.m_rtAllowedAtTime
        public RTime32 rtAllowedAtTime;
        /// missing documentation for MarketEligibilityResponse_t.m_cdaySteamGuardRequiredDays
        public int cdaySteamGuardRequiredDays;
        /// missing documentation for MarketEligibilityResponse_t.m_cdayNewDeviceCooldown
        public int cdayNewDeviceCooldown;
    }
}