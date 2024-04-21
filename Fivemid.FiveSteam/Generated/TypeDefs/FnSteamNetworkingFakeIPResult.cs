using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for FnSteamNetworkingFakeIPResult
    public unsafe struct FnSteamNetworkingFakeIPResult
    {
        public global::Unity.Burst.FunctionPointer<FunctionPointerDelegates.SteamNetworkingFakeIPResultPtr> value;
        public static implicit operator FnSteamNetworkingFakeIPResult(global::Unity.Burst.FunctionPointer<FunctionPointerDelegates.SteamNetworkingFakeIPResultPtr> value) => new()
        {
            value = value
        };
        public static implicit operator global::Unity.Burst.FunctionPointer<FunctionPointerDelegates.SteamNetworkingFakeIPResultPtr>(FnSteamNetworkingFakeIPResult value) => value.value;
    }
}