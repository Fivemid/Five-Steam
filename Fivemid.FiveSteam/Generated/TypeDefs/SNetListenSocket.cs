using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>CreateListenSocket()</summary>
    public unsafe struct SNetListenSocket : IEquatable<SNetListenSocket>, IComparable<SNetListenSocket>
    {
        public uint value;
        public static implicit operator SNetListenSocket(uint value) => new()
        {
            value = value
        };
        public static implicit operator uint (SNetListenSocket value) => value.value;
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object p) => this.Equals((SNetListenSocket)p);
        public bool Equals(SNetListenSocket p) => p.value == value;
        public static bool operator ==(SNetListenSocket a, SNetListenSocket b) => a.Equals(b);
        public static bool operator !=(SNetListenSocket a, SNetListenSocket b) => !a.Equals(b);
        public int CompareTo(SNetListenSocket other) => value.CompareTo(other.value);
    }
}