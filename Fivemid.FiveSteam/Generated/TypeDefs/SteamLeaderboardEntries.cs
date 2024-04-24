using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Handle to a list of downloaded entries in a leaderboard. This is returned by <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#LeaderboardScoresDownloaded_t" class="bb_apilink">LeaderboardScoresDownloaded_t</a> and can be used to iterate through all of the entries with <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetDownloadedLeaderboardEntry" class="bb_apilink">ISteamUserStats::GetDownloadedLeaderboardEntry</a></summary>
    public unsafe struct SteamLeaderboardEntries : IEquatable<SteamLeaderboardEntries>, IComparable<SteamLeaderboardEntries>
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