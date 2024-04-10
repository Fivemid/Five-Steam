using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamItemDef_t</summary>
    public unsafe struct SteamItemDef
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