using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>FnSteamNetAuthenticationStatusChanged</summary>
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