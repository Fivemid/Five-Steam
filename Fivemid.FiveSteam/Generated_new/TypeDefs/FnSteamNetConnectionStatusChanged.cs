using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>FnSteamNetConnectionStatusChanged</summary>
    public unsafe struct FnSteamNetConnectionStatusChanged
    {
        public global::Unity.Burst.FunctionPointer<FunctionPointerDelegates.SteamNetConnectionStatusChangedCallbackPtr> value;
        public static implicit operator FnSteamNetConnectionStatusChanged(global::Unity.Burst.FunctionPointer<FunctionPointerDelegates.SteamNetConnectionStatusChangedCallbackPtr> value) => new()
        {
            value = value
        };
        public static implicit operator global::Unity.Burst.FunctionPointer<FunctionPointerDelegates.SteamNetConnectionStatusChangedCallbackPtr>(FnSteamNetConnectionStatusChanged value) => value.value;
    }
}