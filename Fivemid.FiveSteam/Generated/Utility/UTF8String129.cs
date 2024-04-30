using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>char [129]</summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct UTF8String129 : global::Unity.Collections.IUTF8Bytes
    {
        public fixed byte values[129];
        public override string ToString()
        {
            fixed (byte* ptr = values)
                return Marshal.PtrToStringUTF8((IntPtr)ptr);
        }

        public bool IsEmpty => values[0] == '\0';

        public byte* GetUnsafePtr()
        {
            fixed (byte* ptr = values)
                return ptr;
        }

        public bool TryResize(int newLength, global::Unity.Collections.NativeArrayOptions clearOptions = global::Unity.Collections.NativeArrayOptions.ClearMemory) => false;
    }
}