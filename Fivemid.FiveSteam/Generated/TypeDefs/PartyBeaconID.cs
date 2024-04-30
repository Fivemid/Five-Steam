using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>A handle to a Steam Party Beacon.</summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct PartyBeaconID : IEquatable<PartyBeaconID>, IComparable<PartyBeaconID>
    {
        public ulong value;
        public static implicit operator PartyBeaconID(ulong value) => new()
        {
            value = value
        };
        public static implicit operator ulong (PartyBeaconID value) => value.value;
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object p) => this.Equals((PartyBeaconID)p);
        public bool Equals(PartyBeaconID p) => p.value == value;
        public static bool operator ==(PartyBeaconID a, PartyBeaconID b) => a.Equals(b);
        public static bool operator !=(PartyBeaconID a, PartyBeaconID b) => !a.Equals(b);
        public int CompareTo(PartyBeaconID other) => value.CompareTo(other.value);
    }
}