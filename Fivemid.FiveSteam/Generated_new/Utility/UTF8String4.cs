using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>char [4]</summary>
    public unsafe struct UTF8String4
    {
        public fixed char values[4];
    }
}