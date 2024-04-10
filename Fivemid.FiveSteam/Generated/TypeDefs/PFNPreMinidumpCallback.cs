using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>PFNPreMinidumpCallback</summary>
    public unsafe struct PFNPreMinidumpCallback
    {
        public global::Unity.Burst.FunctionPointer<FunctionPointerDelegates.void_Ptr> value;
        public static implicit operator PFNPreMinidumpCallback(global::Unity.Burst.FunctionPointer<FunctionPointerDelegates.void_Ptr> value) => new()
        {
            value = value
        };
        public static implicit operator global::Unity.Burst.FunctionPointer<FunctionPointerDelegates.void_Ptr>(PFNPreMinidumpCallback value) => value.value;
    }
}