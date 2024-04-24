using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>This is used internally in <a href="#CSteamID" class="bb_apilink">CSteamID</a> to represent a specific user account without caring about what steam universe it's in.</summary>
    public unsafe struct AccountID : IEquatable<AccountID>, IComparable<AccountID>
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