using System;

namespace Fivemid.FiveSteam {
    [Flags]
    public enum SteamNetworkingSendFlags : int {
        Unreliable               = FiveSteamConstants.k_nSteamNetworkingSend_Unreliable,
        NoNagle                  = FiveSteamConstants.k_nSteamNetworkingSend_NoNagle,
        UnreliableNoNagle        = FiveSteamConstants.k_nSteamNetworkingSend_UnreliableNoNagle,
        NoDelay                  = FiveSteamConstants.k_nSteamNetworkingSend_NoDelay,
        UnreliableNoDelay        = FiveSteamConstants.k_nSteamNetworkingSend_UnreliableNoDelay,
        Reliable                 = FiveSteamConstants.k_nSteamNetworkingSend_Reliable,
        ReliableNoNagle          = FiveSteamConstants.k_nSteamNetworkingSend_ReliableNoNagle,
        UseCurrentThread         = FiveSteamConstants.k_nSteamNetworkingSend_UseCurrentThread,
        AutoRestartBrokenSession = FiveSteamConstants.k_nSteamNetworkingSend_AutoRestartBrokenSession
    }
}