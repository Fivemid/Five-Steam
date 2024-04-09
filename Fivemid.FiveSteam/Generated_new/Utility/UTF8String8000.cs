using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>char [8000]</summary>
    public unsafe struct UTF8String8000
    {
        public fixed char values[8000];
    }
}