using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>AppId_t [32]</summary>
    public unsafe struct FixedArray_uint32
    {
        public fixed uint values[32];
    }
}