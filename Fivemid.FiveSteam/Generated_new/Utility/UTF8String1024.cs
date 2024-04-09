using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>char [1024]</summary>
    public unsafe struct UTF8String1024
    {
        public fixed char values[1024];
    }
}