using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>A handle to an asyncronous inventory result.</summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct SteamInventoryResult : IEquatable<SteamInventoryResult>, IComparable<SteamInventoryResult>
    {
        public int value;
        public static implicit operator SteamInventoryResult(int value) => new()
        {
            value = value
        };
        public static implicit operator int (SteamInventoryResult value) => value.value;
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object p) => this.Equals((SteamInventoryResult)p);
        public bool Equals(SteamInventoryResult p) => p.value == value;
        public static bool operator ==(SteamInventoryResult a, SteamInventoryResult b) => a.Equals(b);
        public static bool operator !=(SteamInventoryResult a, SteamInventoryResult b) => !a.Equals(b);
        public int CompareTo(SteamInventoryResult other) => value.CompareTo(other.value);
    }
}