using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>InputHandle_t</summary>
    public unsafe struct InputHandle
    {
        public ulong value;
        public static implicit operator InputHandle(ulong value) => new()
        {
            value = value
        };
        public static implicit operator ulong (InputHandle value) => value.value;
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object p) => this.Equals((InputHandle)p);
        public bool Equals(InputHandle p) => p.value == value;
        public static bool operator ==(InputHandle a, InputHandle b) => a.Equals(b);
        public static bool operator !=(InputHandle a, InputHandle b) => !a.Equals(b);
        public int CompareTo(InputHandle other) => value.CompareTo(other.value);
    }
}