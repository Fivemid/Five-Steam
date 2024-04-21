using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for RemotePlaySessionID_t
    public unsafe struct RemotePlaySessionID
    {
        public uint value;
        public static implicit operator RemotePlaySessionID(uint value) => new()
        {
            value = value
        };
        public static implicit operator uint (RemotePlaySessionID value) => value.value;
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object p) => this.Equals((RemotePlaySessionID)p);
        public bool Equals(RemotePlaySessionID p) => p.value == value;
        public static bool operator ==(RemotePlaySessionID a, RemotePlaySessionID b) => a.Equals(b);
        public static bool operator !=(RemotePlaySessionID a, RemotePlaySessionID b) => !a.Equals(b);
        public int CompareTo(RemotePlaySessionID other) => value.CompareTo(other.value);
    }
}