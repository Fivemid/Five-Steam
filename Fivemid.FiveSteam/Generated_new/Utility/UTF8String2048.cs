using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>char [2048]</summary>
    public unsafe struct UTF8String2048
    {
        public fixed char values[2048];
    }
}