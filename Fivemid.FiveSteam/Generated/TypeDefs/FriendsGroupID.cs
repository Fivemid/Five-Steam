using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Friends group (tags) identifier.</summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct FriendsGroupID : IEquatable<FriendsGroupID>, IComparable<FriendsGroupID>
    {
        public short value;
        public static implicit operator FriendsGroupID(short value) => new()
        {
            value = value
        };
        public static implicit operator short (FriendsGroupID value) => value.value;
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object p) => this.Equals((FriendsGroupID)p);
        public bool Equals(FriendsGroupID p) => p.value == value;
        public static bool operator ==(FriendsGroupID a, FriendsGroupID b) => a.Equals(b);
        public static bool operator !=(FriendsGroupID a, FriendsGroupID b) => !a.Equals(b);
        public int CompareTo(FriendsGroupID other) => value.CompareTo(other.value);
    }
}