using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamItemInstanceID_t</summary>
    public unsafe struct SteamItemInstanceID
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