using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for SteamNetworkingErrMsg
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct SteamNetworkingErrMsg
    {
        public UTF8String1024 value;
        public static implicit operator SteamNetworkingErrMsg(UTF8String1024 value) => new()
        {
            value = value
        };
        public static implicit operator UTF8String1024(SteamNetworkingErrMsg value) => value.value;
    }
}