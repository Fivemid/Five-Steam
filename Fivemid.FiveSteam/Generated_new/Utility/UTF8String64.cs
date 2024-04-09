using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>char [64]</summary>
    public unsafe struct UTF8String64
    {
        public fixed char values[64];
    }
}