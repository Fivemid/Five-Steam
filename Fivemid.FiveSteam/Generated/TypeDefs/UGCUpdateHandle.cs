using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>A unique handle to a single item update. This is used when uploading or updating an item on the workshop.</summary>
    public unsafe struct UGCUpdateHandle : IEquatable<UGCUpdateHandle>, IComparable<UGCUpdateHandle>
    {
        public ulong value;
        public static implicit operator UGCUpdateHandle(ulong value) => new()
        {
            value = value
        };
        public static implicit operator ulong (UGCUpdateHandle value) => value.value;
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object p) => this.Equals((UGCUpdateHandle)p);
        public bool Equals(UGCUpdateHandle p) => p.value == value;
        public static bool operator ==(UGCUpdateHandle a, UGCUpdateHandle b) => a.Equals(b);
        public static bool operator !=(UGCUpdateHandle a, UGCUpdateHandle b) => !a.Equals(b);
        public int CompareTo(UGCUpdateHandle other) => value.CompareTo(other.value);
    }
}