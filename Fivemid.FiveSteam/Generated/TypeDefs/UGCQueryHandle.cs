using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>UGCQueryHandle_t</summary>
    public unsafe struct UGCQueryHandle
    {
        public ulong value;
        public static implicit operator UGCQueryHandle(ulong value) => new()
        {
            value = value
        };
        public static implicit operator ulong (UGCQueryHandle value) => value.value;
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object p) => this.Equals((UGCQueryHandle)p);
        public bool Equals(UGCQueryHandle p) => p.value == value;
        public static bool operator ==(UGCQueryHandle a, UGCQueryHandle b) => a.Equals(b);
        public static bool operator !=(UGCQueryHandle a, UGCQueryHandle b) => !a.Equals(b);
        public int CompareTo(UGCQueryHandle other) => value.CompareTo(other.value);
    }
}