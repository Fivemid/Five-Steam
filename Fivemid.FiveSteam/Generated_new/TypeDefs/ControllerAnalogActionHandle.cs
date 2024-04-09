using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ControllerAnalogActionHandle_t</summary>
    public unsafe struct ControllerAnalogActionHandle
    {
        public ulong value;
        public static implicit operator ControllerAnalogActionHandle(ulong value) => new()
        {
            value = value
        };
        public static implicit operator ulong (ControllerAnalogActionHandle value) => value.value;
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object p) => this.Equals((ControllerAnalogActionHandle)p);
        public bool Equals(ControllerAnalogActionHandle p) => p.value == value;
        public static bool operator ==(ControllerAnalogActionHandle a, ControllerAnalogActionHandle b) => a.Equals(b);
        public static bool operator !=(ControllerAnalogActionHandle a, ControllerAnalogActionHandle b) => !a.Equals(b);
        public int CompareTo(ControllerAnalogActionHandle other) => value.CompareTo(other.value);
    }
}