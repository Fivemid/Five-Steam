using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>char [32]</summary>
    public unsafe struct UTF8String32
    {
        public fixed char values[32];
    }
}