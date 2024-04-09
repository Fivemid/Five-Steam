using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>FnSteamNetworkingMessagesSessionRequest</summary>
    public unsafe struct FnSteamNetworkingMessagesSessionRequest
    {
        public global::Unity.Burst.FunctionPointer<FunctionPointerDelegates.SteamNetworkingMessagesSessionRequestPtr> value;
        public static implicit operator FnSteamNetworkingMessagesSessionRequest(global::Unity.Burst.FunctionPointer<FunctionPointerDelegates.SteamNetworkingMessagesSessionRequestPtr> value) => new()
        {
            value = value
        };
        public static implicit operator global::Unity.Burst.FunctionPointer<FunctionPointerDelegates.SteamNetworkingMessagesSessionRequestPtr>(FnSteamNetworkingMessagesSessionRequest value) => value.value;
    }
}