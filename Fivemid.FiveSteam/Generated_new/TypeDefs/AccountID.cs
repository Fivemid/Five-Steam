using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>AccountID_t</summary>
    public unsafe struct AccountID
    {
        public uint value;
        public static implicit operator AccountID(uint value) => new()
        {
            value = value
        };
        public static implicit operator uint (AccountID value) => value.value;
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object p) => this.Equals((AccountID)p);
        public bool Equals(AccountID p) => p.value == value;
        public static bool operator ==(AccountID a, AccountID b) => a.Equals(b);
        public static bool operator !=(AccountID a, AccountID b) => !a.Equals(b);
        public int CompareTo(AccountID other) => value.CompareTo(other.value);
    }
}