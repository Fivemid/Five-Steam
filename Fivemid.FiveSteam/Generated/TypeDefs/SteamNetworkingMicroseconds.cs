using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for SteamNetworkingMicroseconds
    public unsafe struct SteamNetworkingMicroseconds
    {
        public long value;
        public static implicit operator SteamNetworkingMicroseconds(long value) => new()
        {
            value = value
        };
        public static implicit operator long (SteamNetworkingMicroseconds value) => value.value;
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object p) => this.Equals((SteamNetworkingMicroseconds)p);
        public bool Equals(SteamNetworkingMicroseconds p) => p.value == value;
        public static bool operator ==(SteamNetworkingMicroseconds a, SteamNetworkingMicroseconds b) => a.Equals(b);
        public static bool operator !=(SteamNetworkingMicroseconds a, SteamNetworkingMicroseconds b) => !a.Equals(b);
        public int CompareTo(SteamNetworkingMicroseconds other) => value.CompareTo(other.value);
    }
}