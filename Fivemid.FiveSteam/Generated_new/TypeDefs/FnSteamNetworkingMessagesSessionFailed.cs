using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>FnSteamNetworkingMessagesSessionFailed</summary>
    public unsafe struct FnSteamNetworkingMessagesSessionFailed
    {
        public global::Unity.Burst.FunctionPointer<FunctionPointerDelegates.SteamNetworkingMessagesSessionFailedPtr> value;
        public static implicit operator FnSteamNetworkingMessagesSessionFailed(global::Unity.Burst.FunctionPointer<FunctionPointerDelegates.SteamNetworkingMessagesSessionFailedPtr> value) => new()
        {
            value = value
        };
        public static implicit operator global::Unity.Burst.FunctionPointer<FunctionPointerDelegates.SteamNetworkingMessagesSessionFailedPtr>(FnSteamNetworkingMessagesSessionFailed value) => value.value;
    }
}