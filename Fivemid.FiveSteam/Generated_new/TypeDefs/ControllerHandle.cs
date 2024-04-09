using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ControllerHandle_t</summary>
    public unsafe struct ControllerHandle
    {
        public ulong value;
        public static implicit operator ControllerHandle(ulong value) => new()
        {
            value = value
        };
        public static implicit operator ulong (ControllerHandle value) => value.value;
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object p) => this.Equals((ControllerHandle)p);
        public bool Equals(ControllerHandle p) => p.value == value;
        public static bool operator ==(ControllerHandle a, ControllerHandle b) => a.Equals(b);
        public static bool operator !=(ControllerHandle a, ControllerHandle b) => !a.Equals(b);
        public int CompareTo(ControllerHandle other) => value.CompareTo(other.value);
    }
}