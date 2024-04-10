using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>DepotId_t</summary>
    public unsafe struct DepotId
    {
        public uint value;
        public static implicit operator DepotId(uint value) => new()
        {
            value = value
        };
        public static implicit operator uint (DepotId value) => value.value;
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object p) => this.Equals((DepotId)p);
        public bool Equals(DepotId p) => p.value == value;
        public static bool operator ==(DepotId a, DepotId b) => a.Equals(b);
        public static bool operator !=(DepotId a, DepotId b) => !a.Equals(b);
        public int CompareTo(DepotId other) => value.CompareTo(other.value);
    }
}