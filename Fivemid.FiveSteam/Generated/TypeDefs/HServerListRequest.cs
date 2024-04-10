using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>HServerListRequest</summary>
    public unsafe struct HServerListRequest
    {
        public void* value;
        public static implicit operator HServerListRequest(void* value) => new()
        {
            value = value
        };
        public static implicit operator void*(HServerListRequest value) => value.value;
    }
}