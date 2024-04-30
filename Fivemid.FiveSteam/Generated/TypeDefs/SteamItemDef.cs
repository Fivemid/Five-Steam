using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Types of items in your game are identified by a 32-bit "item definition number".<br />
    /// Valid definition numbers are between 1 and 999999999; numbers less than or equal to zero are invalid, and numbers greater than or equal to one billion (1x10^9) are reserved for internal Steam use.</summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct SteamItemDef : IEquatable<SteamItemDef>, IComparable<SteamItemDef>
    {
        public int value;
        public static implicit operator SteamItemDef(int value) => new()
        {
            value = value
        };
        public static implicit operator int (SteamItemDef value) => value.value;
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object p) => this.Equals((SteamItemDef)p);
        public bool Equals(SteamItemDef p) => p.value == value;
        public static bool operator ==(SteamItemDef a, SteamItemDef b) => a.Equals(b);
        public static bool operator !=(SteamItemDef a, SteamItemDef b) => !a.Equals(b);
        public int CompareTo(SteamItemDef other) => value.CompareTo(other.value);
    }
}