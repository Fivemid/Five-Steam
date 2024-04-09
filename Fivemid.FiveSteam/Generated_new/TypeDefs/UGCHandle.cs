using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>UGCHandle_t</summary>
    public unsafe struct UGCHandle
    {
        public ulong value;
        public static implicit operator UGCHandle(ulong value) => new()
        {
            value = value
        };
        public static implicit operator ulong (UGCHandle value) => value.value;
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object p) => this.Equals((UGCHandle)p);
        public bool Equals(UGCHandle p) => p.value == value;
        public static bool operator ==(UGCHandle a, UGCHandle b) => a.Equals(b);
        public static bool operator !=(UGCHandle a, UGCHandle b) => !a.Equals(b);
        public int CompareTo(UGCHandle other) => value.CompareTo(other.value);
    }
}