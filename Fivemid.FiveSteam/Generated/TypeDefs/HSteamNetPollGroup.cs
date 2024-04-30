using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for HSteamNetPollGroup
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct HSteamNetPollGroup : IEquatable<HSteamNetPollGroup>, IComparable<HSteamNetPollGroup>
    {
        public uint value;
        public static implicit operator HSteamNetPollGroup(uint value) => new()
        {
            value = value
        };
        public static implicit operator uint (HSteamNetPollGroup value) => value.value;
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object p) => this.Equals((HSteamNetPollGroup)p);
        public bool Equals(HSteamNetPollGroup p) => p.value == value;
        public static bool operator ==(HSteamNetPollGroup a, HSteamNetPollGroup b) => a.Equals(b);
        public static bool operator !=(HSteamNetPollGroup a, HSteamNetPollGroup b) => !a.Equals(b);
        public int CompareTo(HSteamNetPollGroup other) => value.CompareTo(other.value);
    }
}