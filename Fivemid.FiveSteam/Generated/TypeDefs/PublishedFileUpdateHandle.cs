using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Deprecated - Only used with the deprecated RemoteStorage based Workshop API.</summary>
    public unsafe struct PublishedFileUpdateHandle : IEquatable<PublishedFileUpdateHandle>, IComparable<PublishedFileUpdateHandle>
    {
        public ulong value;
        public static implicit operator PublishedFileUpdateHandle(ulong value) => new()
        {
            value = value
        };
        public static implicit operator ulong (PublishedFileUpdateHandle value) => value.value;
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object p) => this.Equals((PublishedFileUpdateHandle)p);
        public bool Equals(PublishedFileUpdateHandle p) => p.value == value;
        public static bool operator ==(PublishedFileUpdateHandle a, PublishedFileUpdateHandle b) => a.Equals(b);
        public static bool operator !=(PublishedFileUpdateHandle a, PublishedFileUpdateHandle b) => !a.Equals(b);
        public int CompareTo(PublishedFileUpdateHandle other) => value.CompareTo(other.value);
    }
}