using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Handle to a single leaderboard.</summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct SteamLeaderboard : IEquatable<SteamLeaderboard>, IComparable<SteamLeaderboard>
    {
        public ulong value;
        public static implicit operator SteamLeaderboard(ulong value) => new()
        {
            value = value
        };
        public static implicit operator ulong (SteamLeaderboard value) => value.value;
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object p) => this.Equals((SteamLeaderboard)p);
        public bool Equals(SteamLeaderboard p) => p.value == value;
        public static bool operator ==(SteamLeaderboard a, SteamLeaderboard b) => a.Equals(b);
        public static bool operator !=(SteamLeaderboard a, SteamLeaderboard b) => !a.Equals(b);
        public int CompareTo(SteamLeaderboard other) => value.CompareTo(other.value);
    }
}