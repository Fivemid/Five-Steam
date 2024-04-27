using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>char [8000]</summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct UTF8String8000 : global::Unity.Collections.IUTF8Bytes
    {
        public fixed char values[8000];
        public override string ToString()
        {
            fixed (char* ptr = values)
                return Marshal.PtrToStringUTF8((IntPtr)ptr);
        }

        public bool IsEmpty => values[0] == '\0';

        public byte* GetUnsafePtr()
        {
            fixed (char* ptr = values)
                return (byte*)ptr;
        }

        public bool TryResize(int newLength, global::Unity.Collections.NativeArrayOptions clearOptions = global::Unity.Collections.NativeArrayOptions.ClearMemory) => false;
    }
}