using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>This handle will consistently identify a controller, even if it is disconnected and re-connected</summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct ControllerHandle : IEquatable<ControllerHandle>, IComparable<ControllerHandle>
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