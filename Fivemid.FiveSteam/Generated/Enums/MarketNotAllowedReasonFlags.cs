using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for EMarketNotAllowedReasonFlags
    public enum MarketNotAllowedReasonFlags : int
    {
        /// missing documentation for EMarketNotAllowedReasonFlags.k_EMarketNotAllowedReason_None
        MarketNotAllowedReason_None = 0,
        /// missing documentation for EMarketNotAllowedReasonFlags.k_EMarketNotAllowedReason_TemporaryFailure
        MarketNotAllowedReason_TemporaryFailure = 1,
        /// missing documentation for EMarketNotAllowedReasonFlags.k_EMarketNotAllowedReason_AccountDisabled
        MarketNotAllowedReason_AccountDisabled = 2,
        /// missing documentation for EMarketNotAllowedReasonFlags.k_EMarketNotAllowedReason_AccountLockedDown
        MarketNotAllowedReason_AccountLockedDown = 4,
        /// missing documentation for EMarketNotAllowedReasonFlags.k_EMarketNotAllowedReason_AccountLimited
        MarketNotAllowedReason_AccountLimited = 8,
        /// missing documentation for EMarketNotAllowedReasonFlags.k_EMarketNotAllowedReason_TradeBanned
        MarketNotAllowedReason_TradeBanned = 16,
        /// missing documentation for EMarketNotAllowedReasonFlags.k_EMarketNotAllowedReason_AccountNotTrusted
        MarketNotAllowedReason_AccountNotTrusted = 32,
        /// missing documentation for EMarketNotAllowedReasonFlags.k_EMarketNotAllowedReason_SteamGuardNotEnabled
        MarketNotAllowedReason_SteamGuardNotEnabled = 64,
        /// missing documentation for EMarketNotAllowedReasonFlags.k_EMarketNotAllowedReason_SteamGuardOnlyRecentlyEnabled
        MarketNotAllowedReason_SteamGuardOnlyRecentlyEnabled = 128,
        /// missing documentation for EMarketNotAllowedReasonFlags.k_EMarketNotAllowedReason_RecentPasswordReset
        MarketNotAllowedReason_RecentPasswordReset = 256,
        /// missing documentation for EMarketNotAllowedReasonFlags.k_EMarketNotAllowedReason_NewPaymentMethod
        MarketNotAllowedReason_NewPaymentMethod = 512,
        /// missing documentation for EMarketNotAllowedReasonFlags.k_EMarketNotAllowedReason_InvalidCookie
        MarketNotAllowedReason_InvalidCookie = 1024,
        /// missing documentation for EMarketNotAllowedReasonFlags.k_EMarketNotAllowedReason_UsingNewDevice
        MarketNotAllowedReason_UsingNewDevice = 2048,
        /// missing documentation for EMarketNotAllowedReasonFlags.k_EMarketNotAllowedReason_RecentSelfRefund
        MarketNotAllowedReason_RecentSelfRefund = 4096,
        /// missing documentation for EMarketNotAllowedReasonFlags.k_EMarketNotAllowedReason_NewPaymentMethodCannotBeVerified
        MarketNotAllowedReason_NewPaymentMethodCannotBeVerified = 8192,
        /// missing documentation for EMarketNotAllowedReasonFlags.k_EMarketNotAllowedReason_NoRecentPurchases
        MarketNotAllowedReason_NoRecentPurchases = 16384,
        /// missing documentation for EMarketNotAllowedReasonFlags.k_EMarketNotAllowedReason_AcceptedWalletGift
        MarketNotAllowedReason_AcceptedWalletGift = 32768
    }
}