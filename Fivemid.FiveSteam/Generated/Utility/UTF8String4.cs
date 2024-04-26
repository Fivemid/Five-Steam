using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>char [4]</summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct UTF8String4
    {
        public fixed char values[4];
        public override string ToString()
        {
            fixed (char* ptr = values)
                return Marshal.PtrToStringUTF8((IntPtr)ptr);
        }
    }
}