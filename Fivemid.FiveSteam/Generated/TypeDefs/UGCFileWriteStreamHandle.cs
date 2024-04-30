using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Handle used when asynchronously writing to Steam Cloud.</summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct UGCFileWriteStreamHandle : IEquatable<UGCFileWriteStreamHandle>, IComparable<UGCFileWriteStreamHandle>
    {
        public ulong value;
        public static implicit operator UGCFileWriteStreamHandle(ulong value) => new()
        {
            value = value
        };
        public static implicit operator ulong (UGCFileWriteStreamHandle value) => value.value;
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object p) => this.Equals((UGCFileWriteStreamHandle)p);
        public bool Equals(UGCFileWriteStreamHandle p) => p.value == value;
        public static bool operator ==(UGCFileWriteStreamHandle a, UGCFileWriteStreamHandle b) => a.Equals(b);
        public static bool operator !=(UGCFileWriteStreamHandle a, UGCFileWriteStreamHandle b) => !a.Equals(b);
        public int CompareTo(UGCFileWriteStreamHandle other) => value.CompareTo(other.value);
    }
}