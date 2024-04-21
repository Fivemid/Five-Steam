using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for SteamInputActionEventCallbackPointer
    public unsafe struct SteamInputActionEventCallbackPointer
    {
        public global::Unity.Burst.FunctionPointer<FunctionPointerDelegates.SteamInputActionEventPtr> value;
        public static implicit operator SteamInputActionEventCallbackPointer(global::Unity.Burst.FunctionPointer<FunctionPointerDelegates.SteamInputActionEventPtr> value) => new()
        {
            value = value
        };
        public static implicit operator global::Unity.Burst.FunctionPointer<FunctionPointerDelegates.SteamInputActionEventPtr>(SteamInputActionEventCallbackPointer value) => value.value;
    }
}