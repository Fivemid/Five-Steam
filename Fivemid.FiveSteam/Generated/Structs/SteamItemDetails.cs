using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary><br />
    /// <br />
    /// </summary>
    public unsafe struct SteamItemDetails
    {
        /// <summary>The globally unique item instance handle.</summary>
        public SteamItemInstanceID itemId;
        /// <summary>The item definition number for this item.</summary>
        public SteamItemDef iDefinition;
        /// <summary>The current quantity of the item.</summary>
        public ushort unQuantity;
        /// <summary>This is a bitmasked collection of <a href="https://partner.steamgames.com/doc/api/ISteamInventory#ESteamItemFlags" class="bb_apilink">ESteamItemFlags</a>.</summary>
        public ushort unFlags;
    }
}