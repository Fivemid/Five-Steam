using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Only used internally in Steam.</summary>
    public unsafe struct lint64 : IEquatable<lint64>, IComparable<lint64>
    {
        public long value;
        public static implicit operator lint64(long value) => new()
        {
            value = value
        };
        public static implicit operator long (lint64 value) => value.value;
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object p) => this.Equals((lint64)p);
        public bool Equals(lint64 p) => p.value == value;
        public static bool operator ==(lint64 a, lint64 b) => a.Equals(b);
        public static bool operator !=(lint64 a, lint64 b) => !a.Equals(b);
        public int CompareTo(lint64 other) => value.CompareTo(other.value);
    }
}