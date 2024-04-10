using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamErrMsg</summary>
    public unsafe struct SteamErrMsg
    {
        public UTF8String1024 value;
        public static implicit operator SteamErrMsg(UTF8String1024 value) => new()
        {
            value = value
        };
        public static implicit operator UTF8String1024(SteamErrMsg value) => value.value;
    }
}