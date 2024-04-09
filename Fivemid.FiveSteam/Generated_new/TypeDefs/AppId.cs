using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>AppId_t</summary>
    public unsafe struct AppId
    {
        public uint value;
        public static implicit operator AppId(uint value) => new()
        {
            value = value
        };
        public static implicit operator uint (AppId value) => value.value;
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object p) => this.Equals((AppId)p);
        public bool Equals(AppId p) => p.value == value;
        public static bool operator ==(AppId a, AppId b) => a.Equals(b);
        public static bool operator !=(AppId a, AppId b) => !a.Equals(b);
        public int CompareTo(AppId other) => value.CompareTo(other.value);
    }
}