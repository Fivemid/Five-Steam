using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for SteamNetworkingPOPID
    public unsafe struct SteamNetworkingPOPID : IEquatable<SteamNetworkingPOPID>, IComparable<SteamNetworkingPOPID>
    {
        public uint value;
        public static implicit operator SteamNetworkingPOPID(uint value) => new()
        {
            value = value
        };
        public static implicit operator uint (SteamNetworkingPOPID value) => value.value;
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object p) => this.Equals((SteamNetworkingPOPID)p);
        public bool Equals(SteamNetworkingPOPID p) => p.value == value;
        public static bool operator ==(SteamNetworkingPOPID a, SteamNetworkingPOPID b) => a.Equals(b);
        public static bool operator !=(SteamNetworkingPOPID a, SteamNetworkingPOPID b) => !a.Equals(b);
        public int CompareTo(SteamNetworkingPOPID other) => value.CompareTo(other.value);
    }
}