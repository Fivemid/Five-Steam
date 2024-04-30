using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Handle that you will receive when querying details on an individual server.</summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct HServerQuery : IEquatable<HServerQuery>, IComparable<HServerQuery>
    {
        public int value;
        public static implicit operator HServerQuery(int value) => new()
        {
            value = value
        };
        public static implicit operator int (HServerQuery value) => value.value;
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object p) => this.Equals((HServerQuery)p);
        public bool Equals(HServerQuery p) => p.value == value;
        public static bool operator ==(HServerQuery a, HServerQuery b) => a.Equals(b);
        public static bool operator !=(HServerQuery a, HServerQuery b) => !a.Equals(b);
        public int CompareTo(HServerQuery other) => value.CompareTo(other.value);
    }
}