using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary></summary>
    public unsafe struct HTTPCookieContainerHandle : IEquatable<HTTPCookieContainerHandle>, IComparable<HTTPCookieContainerHandle>
    {
        public uint value;
        public static implicit operator HTTPCookieContainerHandle(uint value) => new()
        {
            value = value
        };
        public static implicit operator uint (HTTPCookieContainerHandle value) => value.value;
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object p) => this.Equals((HTTPCookieContainerHandle)p);
        public bool Equals(HTTPCookieContainerHandle p) => p.value == value;
        public static bool operator ==(HTTPCookieContainerHandle a, HTTPCookieContainerHandle b) => a.Equals(b);
        public static bool operator !=(HTTPCookieContainerHandle a, HTTPCookieContainerHandle b) => !a.Equals(b);
        public int CompareTo(HTTPCookieContainerHandle other) => value.CompareTo(other.value);
    }
}