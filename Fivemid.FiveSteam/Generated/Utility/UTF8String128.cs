using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>char [128]</summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct UTF8String128
    {
        public fixed char values[128];
        public override string ToString()
        {
            fixed (char* ptr = values)
                return Marshal.PtrToStringUTF8((IntPtr)ptr);
        }
    }
}