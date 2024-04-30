using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Only used internally in Steam.</summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct ulint64 : IEquatable<ulint64>, IComparable<ulint64>
    {
        public ulong value;
        public static implicit operator ulint64(ulong value) => new()
        {
            value = value
        };
        public static implicit operator ulong (ulint64 value) => value.value;
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object p) => this.Equals((ulint64)p);
        public bool Equals(ulint64 p) => p.value == value;
        public static bool operator ==(ulint64 a, ulint64 b) => a.Equals(b);
        public static bool operator !=(ulint64 a, ulint64 b) => !a.Equals(b);
        public int CompareTo(ulint64 other) => value.CompareTo(other.value);
    }
}