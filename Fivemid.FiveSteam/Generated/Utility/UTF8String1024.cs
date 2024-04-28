using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>char [1024]</summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct UTF8String1024 : global::Unity.Collections.IUTF8Bytes
    {
        public fixed byte values[1024];
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