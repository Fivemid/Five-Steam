using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Returned from the call <a href="https://partner.steamgames.com/doc/api/ISteamInventory#StartUpdateProperties" class="bb_apilink">ISteamInventory::StartUpdateProperties</a>, which starts a transaction request to modify dynamic properties on items for the current user.</summary>
    public unsafe struct SteamInventoryUpdateHandle
    {
        public ulong value;
        public static implicit operator SteamInventoryUpdateHandle(ulong value) => new()
        {
            value = value
        };
        public static implicit operator ulong (SteamInventoryUpdateHandle value) => value.value;
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object p) => this.Equals((SteamInventoryUpdateHandle)p);
        public bool Equals(SteamInventoryUpdateHandle p) => p.value == value;
        public static bool operator ==(SteamInventoryUpdateHandle a, SteamInventoryUpdateHandle b) => a.Equals(b);
        public static bool operator !=(SteamInventoryUpdateHandle a, SteamInventoryUpdateHandle b) => !a.Equals(b);
        public int CompareTo(SteamInventoryUpdateHandle other) => value.CompareTo(other.value);
    }
}