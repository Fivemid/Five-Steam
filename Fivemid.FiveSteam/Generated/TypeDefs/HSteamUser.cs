using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Handle to single instance of a steam user.</summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct HSteamUser : IEquatable<HSteamUser>, IComparable<HSteamUser>
    {
        public int value;
        public static implicit operator HSteamUser(int value) => new()
        {
            value = value
        };
        public static implicit operator int (HSteamUser value) => value.value;
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object p) => this.Equals((HSteamUser)p);
        public bool Equals(HSteamUser p) => p.value == value;
        public static bool operator ==(HSteamUser a, HSteamUser b) => a.Equals(b);
        public static bool operator !=(HSteamUser a, HSteamUser b) => !a.Equals(b);
        public int CompareTo(HSteamUser other) => value.CompareTo(other.value);
    }
}