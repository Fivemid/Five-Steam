using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>char [512]</summary>
    public unsafe struct UTF8String512
    {
        public fixed char values[512];
    }
}