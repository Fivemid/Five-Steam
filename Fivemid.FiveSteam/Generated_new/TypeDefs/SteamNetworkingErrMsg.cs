using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamNetworkingErrMsg</summary>
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