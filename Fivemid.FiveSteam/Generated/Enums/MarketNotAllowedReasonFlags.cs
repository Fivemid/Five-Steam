using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EMarketNotAllowedReasonFlags</summary>
    public enum MarketNotAllowedReasonFlags : int
    {
        /// <summary>k_EMarketNotAllowedReason_None</summary>
        MarketNotAllowedReason_None = 0,
        /// <summary>k_EMarketNotAllowedReason_TemporaryFailure</summary>
        MarketNotAllowedReason_TemporaryFailure = 1,
        /// <summary>k_EMarketNotAllowedReason_AccountDisabled</summary>
        MarketNotAllowedReason_AccountDisabled = 2,
        /// <summary>k_EMarketNotAllowedReason_AccountLockedDown</summary>
        MarketNotAllowedReason_AccountLockedDown = 4,
        /// <summary>k_EMarketNotAllowedReason_AccountLimited</summary>
        MarketNotAllowedReason_AccountLimited = 8,
        /// <summary>k_EMarketNotAllowedReason_TradeBanned</summary>
        MarketNotAllowedReason_TradeBanned = 16,
        /// <summary>k_EMarketNotAllowedReason_AccountNotTrusted</summary>
        MarketNotAllowedReason_AccountNotTrusted = 32,
        /// <summary>k_EMarketNotAllowedReason_SteamGuardNotEnabled</summary>
        MarketNotAllowedReason_SteamGuardNotEnabled = 64,
        /// <summary>k_EMarketNotAllowedReason_SteamGuardOnlyRecentlyEnabled</summary>
        MarketNotAllowedReason_SteamGuardOnlyRecentlyEnabled = 128,
        /// <summary>k_EMarketNotAllowedReason_RecentPasswordReset</summary>
        MarketNotAllowedReason_RecentPasswordReset = 256,
        /// <summary>k_EMarketNotAllowedReason_NewPaymentMethod</summary>
        MarketNotAllowedReason_NewPaymentMethod = 512,
        /// <summary>k_EMarketNotAllowedReason_InvalidCookie</summary>
        MarketNotAllowedReason_InvalidCookie = 1024,
        /// <summary>k_EMarketNotAllowedReason_UsingNewDevice</summary>
        MarketNotAllowedReason_UsingNewDevice = 2048,
        /// <summary>k_EMarketNotAllowedReason_RecentSelfRefund</summary>
        MarketNotAllowedReason_RecentSelfRefund = 4096,
        /// <summary>k_EMarketNotAllowedReason_NewPaymentMethodCannotBeVerified</summary>
        MarketNotAllowedReason_NewPaymentMethodCannotBeVerified = 8192,
        /// <summary>k_EMarketNotAllowedReason_NoRecentPurchases</summary>
        MarketNotAllowedReason_NoRecentPurchases = 16384,
        /// <summary>k_EMarketNotAllowedReason_AcceptedWalletGift</summary>
        MarketNotAllowedReason_AcceptedWalletGift = 32768
    }
}