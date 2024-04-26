using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>char [2048]</summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct UTF8String2048
    {
        public fixed char values[2048];
        public override string ToString()
        {
            fixed (char* ptr = values)
                return Marshal.PtrToStringUTF8((IntPtr)ptr);
        }
    }
}