using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>uint32 [63]</summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct FixedArray_uint63
    {
        public fixed uint values[63];
    }
}