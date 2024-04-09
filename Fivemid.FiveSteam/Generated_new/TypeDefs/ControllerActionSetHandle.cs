using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ControllerActionSetHandle_t</summary>
    public unsafe struct ControllerActionSetHandle
    {
        public ulong value;
        public static implicit operator ControllerActionSetHandle(ulong value) => new()
        {
            value = value
        };
        public static implicit operator ulong (ControllerActionSetHandle value) => value.value;
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object p) => this.Equals((ControllerActionSetHandle)p);
        public bool Equals(ControllerActionSetHandle p) => p.value == value;
        public static bool operator ==(ControllerActionSetHandle a, ControllerActionSetHandle b) => a.Equals(b);
        public static bool operator !=(ControllerActionSetHandle a, ControllerActionSetHandle b) => !a.Equals(b);
        public int CompareTo(ControllerActionSetHandle other) => value.CompareTo(other.value);
    }
}