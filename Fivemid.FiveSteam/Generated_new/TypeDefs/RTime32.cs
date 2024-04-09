using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>RTime32</summary>
    public unsafe struct RTime32
    {
        public uint value;
        public static implicit operator RTime32(uint value) => new()
        {
            value = value
        };
        public static implicit operator uint (RTime32 value) => value.value;
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object p) => this.Equals((RTime32)p);
        public bool Equals(RTime32 p) => p.value == value;
        public static bool operator ==(RTime32 a, RTime32 b) => a.Equals(b);
        public static bool operator !=(RTime32 a, RTime32 b) => !a.Equals(b);
        public int CompareTo(RTime32 other) => value.CompareTo(other.value);
    }
}