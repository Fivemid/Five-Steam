using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Handle to a HTTP Request handle</summary>
    public unsafe struct HTTPRequestHandle
    {
        public uint value;
        public static implicit operator HTTPRequestHandle(uint value) => new()
        {
            value = value
        };
        public static implicit operator uint (HTTPRequestHandle value) => value.value;
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object p) => this.Equals((HTTPRequestHandle)p);
        public bool Equals(HTTPRequestHandle p) => p.value == value;
        public static bool operator ==(HTTPRequestHandle a, HTTPRequestHandle b) => a.Equals(b);
        public static bool operator !=(HTTPRequestHandle a, HTTPRequestHandle b) => !a.Equals(b);
        public int CompareTo(HTTPRequestHandle other) => value.CompareTo(other.value);
    }
}