using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Triggered when GetAllItems successfully returns a result which is newer / fresher than the last known result. (It will not trigger if the inventory hasn't changed, or if results from two overlapping calls are reversed in flight and the earlier result is already known to be stale/out-of-date.)<br />
    /// The regular <a href="https://partner.steamgames.com/doc/api/ISteamInventory#SteamInventoryResultReady_t" class="bb_apilink">SteamInventoryResultReady_t</a> callback will still be triggered immediately afterwards; this is an additional notification for your convenience.<br />
    /// <br />
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct SteamInventoryFullUpdate : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SteamInventoryFullUpdate;
        /// <summary>A new inventory result handle.</summary>
        public SteamInventoryResult handle;
    }
}