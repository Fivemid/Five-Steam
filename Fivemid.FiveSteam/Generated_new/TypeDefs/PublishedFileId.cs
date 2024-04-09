using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>PublishedFileId_t</summary>
    public unsafe struct PublishedFileId
    {
        public ulong value;
        public static implicit operator PublishedFileId(ulong value) => new()
        {
            value = value
        };
        public static implicit operator ulong (PublishedFileId value) => value.value;
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object p) => this.Equals((PublishedFileId)p);
        public bool Equals(PublishedFileId p) => p.value == value;
        public static bool operator ==(PublishedFileId a, PublishedFileId b) => a.Equals(b);
        public static bool operator !=(PublishedFileId a, PublishedFileId b) => !a.Equals(b);
        public int CompareTo(PublishedFileId other) => value.CompareTo(other.value);
    }
}