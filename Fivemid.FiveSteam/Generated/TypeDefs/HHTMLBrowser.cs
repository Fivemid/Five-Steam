using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Represents a unique handle to an HTML surface.</summary>
    public unsafe struct HHTMLBrowser
    {
        public uint value;
        public static implicit operator HHTMLBrowser(uint value) => new()
        {
            value = value
        };
        public static implicit operator uint (HHTMLBrowser value) => value.value;
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object p) => this.Equals((HHTMLBrowser)p);
        public bool Equals(HHTMLBrowser p) => p.value == value;
        public static bool operator ==(HHTMLBrowser a, HHTMLBrowser b) => a.Equals(b);
        public static bool operator !=(HHTMLBrowser a, HHTMLBrowser b) => !a.Equals(b);
        public int CompareTo(HHTMLBrowser other) => value.CompareTo(other.value);
    }
}