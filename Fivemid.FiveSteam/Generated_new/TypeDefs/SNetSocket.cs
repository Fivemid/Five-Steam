using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SNetSocket_t</summary>
    public unsafe struct SNetSocket
    {
        public uint value;
        public static implicit operator SNetSocket(uint value) => new()
        {
            value = value
        };
        public static implicit operator uint (SNetSocket value) => value.value;
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object p) => this.Equals((SNetSocket)p);
        public bool Equals(SNetSocket p) => p.value == value;
        public static bool operator ==(SNetSocket a, SNetSocket b) => a.Equals(b);
        public static bool operator !=(SNetSocket a, SNetSocket b) => !a.Equals(b);
        public int CompareTo(SNetSocket other) => value.CompareTo(other.value);
    }
}