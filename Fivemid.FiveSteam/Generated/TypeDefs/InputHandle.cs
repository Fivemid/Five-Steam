using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>This handle will consistently identify a controller, even if it is disconnected and re-connected</summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct InputHandle : IEquatable<InputHandle>, IComparable<InputHandle>
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