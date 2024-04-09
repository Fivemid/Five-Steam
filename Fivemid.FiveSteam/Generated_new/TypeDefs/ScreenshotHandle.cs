using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ScreenshotHandle</summary>
    public unsafe struct ScreenshotHandle
    {
        public uint value;
        public static implicit operator ScreenshotHandle(uint value) => new()
        {
            value = value
        };
        public static implicit operator uint (ScreenshotHandle value) => value.value;
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object p) => this.Equals((ScreenshotHandle)p);
        public bool Equals(ScreenshotHandle p) => p.value == value;
        public static bool operator ==(ScreenshotHandle a, ScreenshotHandle b) => a.Equals(b);
        public static bool operator !=(ScreenshotHandle a, ScreenshotHandle b) => !a.Equals(b);
        public int CompareTo(ScreenshotHandle other) => value.CompareTo(other.value);
    }
}