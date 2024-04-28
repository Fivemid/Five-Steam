using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for HSteamListenSocket
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct HSteamListenSocket : IEquatable<HSteamListenSocket>, IComparable<HSteamListenSocket>
    {
        public uint value;
        public static implicit operator HSteamListenSocket(uint value) => new()
        {
            value = value
        };
        public static implicit operator uint (HSteamListenSocket value) => value.value;
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object p) => this.Equals((HSteamListenSocket)p);
        public bool Equals(HSteamListenSocket p) => p.value == value;
        public static bool operator ==(HSteamListenSocket a, HSteamListenSocket b) => a.Equals(b);
        public static bool operator !=(HSteamListenSocket a, HSteamListenSocket b) => !a.Equals(b);
        public int CompareTo(HSteamListenSocket other) => value.CompareTo(other.value);
    }
}