using System;
using System.Runtime.InteropServices;
using Unity.Collections;

namespace Fivemid.FiveSteam {
    public unsafe struct UTF8StringPtr : IUTF8Bytes {
        public byte* value;
        
        public override string ToString() =>
            Marshal.PtrToStringUTF8((IntPtr)value);
        
        public bool IsEmpty => value[0] == '\0';
        
        public byte* GetUnsafePtr() =>
            (byte*)value;
        
        public bool TryResize(int newLength, NativeArrayOptions clearOptions = NativeArrayOptions.ClearMemory) =>
            false;
    }
}