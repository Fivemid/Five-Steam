using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>These handles are used to refer to a specific in-game action or action set<br />
    /// All action handles should be queried during initialization for performance reasons</summary>
    public unsafe struct InputActionSetHandle
    {
        public ulong value;
        public static implicit operator InputActionSetHandle(ulong value) => new()
        {
            value = value
        };
        public static implicit operator ulong (InputActionSetHandle value) => value.value;
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object p) => this.Equals((InputActionSetHandle)p);
        public bool Equals(InputActionSetHandle p) => p.value == value;
        public static bool operator ==(InputActionSetHandle a, InputActionSetHandle b) => a.Equals(b);
        public static bool operator !=(InputActionSetHandle a, InputActionSetHandle b) => !a.Equals(b);
        public int CompareTo(InputActionSetHandle other) => value.CompareTo(other.value);
    }
}