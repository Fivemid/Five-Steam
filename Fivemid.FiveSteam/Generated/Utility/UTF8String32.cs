using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>char [32]</summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct UTF8String32
    {
        public fixed char values[32];
        public override string ToString()
        {
            fixed (char* ptr = values)
                return Marshal.PtrToStringUTF8((IntPtr)ptr);
        }
    }
}