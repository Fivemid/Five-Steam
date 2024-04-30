using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for HSteamNetConnection
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct HSteamNetConnection : IEquatable<HSteamNetConnection>, IComparable<HSteamNetConnection>
    {
        public uint value;
        public static implicit operator HSteamNetConnection(uint value) => new()
        {
            value = value
        };
        public static implicit operator uint (HSteamNetConnection value) => value.value;
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object p) => this.Equals((HSteamNetConnection)p);
        public bool Equals(HSteamNetConnection p) => p.value == value;
        public static bool operator ==(HSteamNetConnection a, HSteamNetConnection b) => a.Equals(b);
        public static bool operator !=(HSteamNetConnection a, HSteamNetConnection b) => !a.Equals(b);
        public int CompareTo(HSteamNetConnection other) => value.CompareTo(other.value);
    }
}