using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>FnSteamRelayNetworkStatusChanged</summary>
    public unsafe struct FnSteamRelayNetworkStatusChanged
    {
        public global::Unity.Burst.FunctionPointer<FunctionPointerDelegates.SteamRelayNetworkStatusPtr> value;
        public static implicit operator FnSteamRelayNetworkStatusChanged(global::Unity.Burst.FunctionPointer<FunctionPointerDelegates.SteamRelayNetworkStatusPtr> value) => new()
        {
            value = value
        };
        public static implicit operator global::Unity.Burst.FunctionPointer<FunctionPointerDelegates.SteamRelayNetworkStatusPtr>(FnSteamRelayNetworkStatusChanged value) => value.value;
    }
}