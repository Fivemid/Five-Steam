using System;

namespace Fivemid.FiveSteam {
    [Flags]
    public enum SteamNetworkingSendFlags : int {
        /// <inheritdoc cref="FiveSteamConstants.k_nSteamNetworkingSend_Unreliable" />
        Unreliable = FiveSteamConstants.k_nSteamNetworkingSend_Unreliable,
        /// <inheritdoc cref="FiveSteamConstants.k_nSteamNetworkingSend_NoNagle" />
        NoNagle = FiveSteamConstants.k_nSteamNetworkingSend_NoNagle,
        /// <inheritdoc cref="FiveSteamConstants.k_nSteamNetworkingSend_UnreliableNoNagle" />
        UnreliableNoNagle = FiveSteamConstants.k_nSteamNetworkingSend_UnreliableNoNagle,
        /// <inheritdoc cref="FiveSteamConstants.k_nSteamNetworkingSend_NoDelay" />
        NoDelay = FiveSteamConstants.k_nSteamNetworkingSend_NoDelay,
        /// <inheritdoc cref="FiveSteamConstants.k_nSteamNetworkingSend_UnreliableNoDelay" />
        UnreliableNoDelay = FiveSteamConstants.k_nSteamNetworkingSend_UnreliableNoDelay,
        /// <inheritdoc cref="FiveSteamConstants.k_nSteamNetworkingSend_Reliable" />
        Reliable = FiveSteamConstants.k_nSteamNetworkingSend_Reliable,
        /// <inheritdoc cref="FiveSteamConstants.k_nSteamNetworkingSend_ReliableNoNagle" />
        ReliableNoNagle = FiveSteamConstants.k_nSteamNetworkingSend_ReliableNoNagle,
        /// <inheritdoc cref="FiveSteamConstants.k_nSteamNetworkingSend_UseCurrentThread" />
        UseCurrentThread = FiveSteamConstants.k_nSteamNetworkingSend_UseCurrentThread,
        /// <inheritdoc cref="FiveSteamConstants.k_nSteamNetworkingSend_AutoRestartBrokenSession" />
        AutoRestartBrokenSession = FiveSteamConstants.k_nSteamNetworkingSend_AutoRestartBrokenSession
    }
}