using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>FSteamNetworkingSocketsDebugOutput</summary>
    public unsafe struct FSteamNetworkingSocketsDebugOutput
    {
        public global::Unity.Burst.FunctionPointer<FunctionPointerDelegates.SteamNetworkingSocketsDebugOutputType_UTF8StringPtr> value;
        public static implicit operator FSteamNetworkingSocketsDebugOutput(global::Unity.Burst.FunctionPointer<FunctionPointerDelegates.SteamNetworkingSocketsDebugOutputType_UTF8StringPtr> value) => new()
        {
            value = value
        };
        public static implicit operator global::Unity.Burst.FunctionPointer<FunctionPointerDelegates.SteamNetworkingSocketsDebugOutputType_UTF8StringPtr>(FSteamNetworkingSocketsDebugOutput value) => value.value;
    }
}