using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamLeaderboardEntries_t</summary>
    public unsafe struct SteamLeaderboardEntries
    {
        public ulong value;
        public static implicit operator SteamLeaderboardEntries(ulong value) => new()
        {
            value = value
        };
        public static implicit operator ulong (SteamLeaderboardEntries value) => value.value;
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object p) => this.Equals((SteamLeaderboardEntries)p);
        public bool Equals(SteamLeaderboardEntries p) => p.value == value;
        public static bool operator ==(SteamLeaderboardEntries a, SteamLeaderboardEntries b) => a.Equals(b);
        public static bool operator !=(SteamLeaderboardEntries a, SteamLeaderboardEntries b) => !a.Equals(b);
        public int CompareTo(SteamLeaderboardEntries other) => value.CompareTo(other.value);
    }
}