using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>char [256]</summary>
    public unsafe struct UTF8String256
    {
        public fixed char values[256];
    }
}