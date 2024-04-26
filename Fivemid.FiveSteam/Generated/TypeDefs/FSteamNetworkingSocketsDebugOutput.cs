using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for FSteamNetworkingSocketsDebugOutput
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
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