using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>InputDigitalActionHandle_t</summary>
    public unsafe struct InputDigitalActionHandle
    {
        public ulong value;
        public static implicit operator InputDigitalActionHandle(ulong value) => new()
        {
            value = value
        };
        public static implicit operator ulong (InputDigitalActionHandle value) => value.value;
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object p) => this.Equals((InputDigitalActionHandle)p);
        public bool Equals(InputDigitalActionHandle p) => p.value == value;
        public static bool operator ==(InputDigitalActionHandle a, InputDigitalActionHandle b) => a.Equals(b);
        public static bool operator !=(InputDigitalActionHandle a, InputDigitalActionHandle b) => !a.Equals(b);
        public int CompareTo(InputDigitalActionHandle other) => value.CompareTo(other.value);
    }
}