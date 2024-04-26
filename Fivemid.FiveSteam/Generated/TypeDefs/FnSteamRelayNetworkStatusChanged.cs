using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for FnSteamRelayNetworkStatusChanged
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
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