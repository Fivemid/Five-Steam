using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Handle that you will receive when requesting server list.</summary>
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