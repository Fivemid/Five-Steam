using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>char [128]</summary>
    public unsafe struct UTF8String128
    {
        public fixed char values[128];
    }
}