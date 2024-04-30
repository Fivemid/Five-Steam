using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>A handle to a digital action. This can be obtained from <a href="https://partner.steamgames.com/doc/api/ISteamController#GetDigitalActionHandle" class="bb_apilink">ISteamController::GetDigitalActionHandle</a>.</summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct ControllerDigitalActionHandle : IEquatable<ControllerDigitalActionHandle>, IComparable<ControllerDigitalActionHandle>
    {
        public ulong value;
        public static implicit operator ControllerDigitalActionHandle(ulong value) => new()
        {
            value = value
        };
        public static implicit operator ulong (ControllerDigitalActionHandle value) => value.value;
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object p) => this.Equals((ControllerDigitalActionHandle)p);
        public bool Equals(ControllerDigitalActionHandle p) => p.value == value;
        public static bool operator ==(ControllerDigitalActionHandle a, ControllerDigitalActionHandle b) => a.Equals(b);
        public static bool operator !=(ControllerDigitalActionHandle a, ControllerDigitalActionHandle b) => !a.Equals(b);
        public int CompareTo(ControllerDigitalActionHandle other) => value.CompareTo(other.value);
    }
}