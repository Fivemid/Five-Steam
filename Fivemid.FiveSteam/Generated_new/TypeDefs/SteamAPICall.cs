using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamAPICall_t</summary>
    public unsafe struct SteamAPICall
    {
        public ulong value;
        public static implicit operator SteamAPICall(ulong value) => new()
        {
            value = value
        };
        public static implicit operator ulong (SteamAPICall value) => value.value;
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object p) => this.Equals((SteamAPICall)p);
        public bool Equals(SteamAPICall p) => p.value == value;
        public static bool operator ==(SteamAPICall a, SteamAPICall b) => a.Equals(b);
        public static bool operator !=(SteamAPICall a, SteamAPICall b) => !a.Equals(b);
        public int CompareTo(SteamAPICall other) => value.CompareTo(other.value);
    }
}