using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for FnSteamNetAuthenticationStatusChanged
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct FnSteamNetAuthenticationStatusChanged
    {
        public global::Unity.Burst.FunctionPointer<FunctionPointerDelegates.SteamNetAuthenticationStatusPtr> value;
        public static implicit operator FnSteamNetAuthenticationStatusChanged(global::Unity.Burst.FunctionPointer<FunctionPointerDelegates.SteamNetAuthenticationStatusPtr> value) => new()
        {
            value = value
        };
        public static implicit operator global::Unity.Burst.FunctionPointer<FunctionPointerDelegates.SteamNetAuthenticationStatusPtr>(FnSteamNetAuthenticationStatusChanged value) => value.value;
    }
}