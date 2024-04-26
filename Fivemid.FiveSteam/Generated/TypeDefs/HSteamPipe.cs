using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Handle to a communication pipe to the Steam client.</summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct HSteamPipe : IEquatable<HSteamPipe>, IComparable<HSteamPipe>
    {
        public int value;
        public static implicit operator HSteamPipe(int value) => new()
        {
            value = value
        };
        public static implicit operator int (HSteamPipe value) => value.value;
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object p) => this.Equals((HSteamPipe)p);
        public bool Equals(HSteamPipe p) => p.value == value;
        public static bool operator ==(HSteamPipe a, HSteamPipe b) => a.Equals(b);
        public static bool operator !=(HSteamPipe a, HSteamPipe b) => !a.Equals(b);
        public int CompareTo(HSteamPipe other) => value.CompareTo(other.value);
    }
}