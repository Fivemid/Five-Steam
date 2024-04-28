using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for SteamErrMsg
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
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