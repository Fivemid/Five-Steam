using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Every individual instance of an item has a globally-unique instance ID.<br />
    /// This ID is unique to the combination of a player and specific item instance, and will not be transferred to another player or re-used for another item.</summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct SteamItemInstanceID : IEquatable<SteamItemInstanceID>, IComparable<SteamItemInstanceID>
    {
        public ulong value;
        public static implicit operator SteamItemInstanceID(ulong value) => new()
        {
            value = value
        };
        public static implicit operator ulong (SteamItemInstanceID value) => value.value;
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object p) => this.Equals((SteamItemInstanceID)p);
        public bool Equals(SteamItemInstanceID p) => p.value == value;
        public static bool operator ==(SteamItemInstanceID a, SteamItemInstanceID b) => a.Equals(b);
        public static bool operator !=(SteamItemInstanceID a, SteamItemInstanceID b) => !a.Equals(b);
        public int CompareTo(SteamItemInstanceID other) => value.CompareTo(other.value);
    }
}