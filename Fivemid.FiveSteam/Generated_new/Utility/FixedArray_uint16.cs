using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>uint32 [16]</summary>
    public unsafe struct FixedArray_uint16
    {
        public fixed uint values[16];
    }
}