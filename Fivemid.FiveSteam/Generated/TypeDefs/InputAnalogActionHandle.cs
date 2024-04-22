using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>A handle to an analog action. This can be obtained from <a href="https://partner.steamgames.com/doc/api/ISteamInput#GetAnalogActionHandle" class="bb_apilink">ISteamInput::GetAnalogActionHandle</a>.</summary>
    public unsafe struct InputAnalogActionHandle
    {
        public ulong value;
        public static implicit operator InputAnalogActionHandle(ulong value) => new()
        {
            value = value
        };
        public static implicit operator ulong (InputAnalogActionHandle value) => value.value;
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object p) => this.Equals((InputAnalogActionHandle)p);
        public bool Equals(InputAnalogActionHandle p) => p.value == value;
        public static bool operator ==(InputAnalogActionHandle a, InputAnalogActionHandle b) => a.Equals(b);
        public static bool operator !=(InputAnalogActionHandle a, InputAnalogActionHandle b) => !a.Equals(b);
        public int CompareTo(InputAnalogActionHandle other) => value.CompareTo(other.value);
    }
}