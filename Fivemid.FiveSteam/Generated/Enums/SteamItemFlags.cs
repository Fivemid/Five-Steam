using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>These are bitflags that are set in <a href="https://partner.steamgames.com/doc/api/ISteamInventory#SteamItemDetails_t" class="bb_apilink">SteamItemDetails_t</a>.<br />
    /// <br />
    /// </summary>
    public enum SteamItemFlags : int
    {
        /// <summary>This item is account-locked and cannot be traded or given away. This is an item status flag which is permanently attached to specific item instances.</summary>
        SteamItemNoTrade = 1,
        /// <summary>The item has been destroyed, traded away, expired, or otherwise invalidated. This is an action confirmation flag which is only set one time, as part of a result set.</summary>
        SteamItemRemoved = 256,
        /// <summary>The item quantity has been decreased by 1 via <a href="https://partner.steamgames.com/doc/api/ISteamInventory#ConsumeItem" class="bb_apilink">ISteamInventory::ConsumeItem</a> API. This is an action confirmation flag which is only set one time, as part of a result set.</summary>
        SteamItemConsumed = 512
    }
}