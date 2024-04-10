using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>HAuthTicket</summary>
    public unsafe struct HAuthTicket
    {
        public uint value;
        public static implicit operator HAuthTicket(uint value) => new()
        {
            value = value
        };
        public static implicit operator uint (HAuthTicket value) => value.value;
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object p) => this.Equals((HAuthTicket)p);
        public bool Equals(HAuthTicket p) => p.value == value;
        public static bool operator ==(HAuthTicket a, HAuthTicket b) => a.Equals(b);
        public static bool operator !=(HAuthTicket a, HAuthTicket b) => !a.Equals(b);
        public int CompareTo(HAuthTicket other) => value.CompareTo(other.value);
    }
}