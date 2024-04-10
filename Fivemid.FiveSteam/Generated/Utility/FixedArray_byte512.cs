using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>uint8 [512]</summary>
    public unsafe struct FixedArray_byte512
    {
        public fixed byte values[512];
    }
}