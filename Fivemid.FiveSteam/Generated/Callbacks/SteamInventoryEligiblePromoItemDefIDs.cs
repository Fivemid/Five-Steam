using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Returned when you have requested the list of "eligible" promo items that can be manually granted to the given user. These are promo items of type "manual" that won't be granted automatically. An example usage of this is an item that becomes available every week.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamInventory#RequestEligiblePromoItemDefinitionsIDs" class="bb_apilink">ISteamInventory::RequestEligiblePromoItemDefinitionsIDs</a></summary>
    public unsafe struct SteamInventoryEligiblePromoItemDefIDs : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SteamInventoryEligiblePromoItemDefIDs;
        /// <summary><a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultOK" class="bb_apilink">k_EResultOK</a> upon success, any other value indicates failure.</summary>
        public Result result;
        /// <summary>The Steam ID of the user who these items are for.</summary>
        public SteamId steamID;
        /// <summary>The number of eligible promo items available for this user. You should use this to create a <a href="https://partner.steamgames.com/doc/api/ISteamInventory#SteamItemDef_t" class="bb_apilink">SteamItemDef_t</a> buffer to use with <a href="https://partner.steamgames.com/doc/api/ISteamInventory#GetEligiblePromoItemDefinitionIDs" class="bb_apilink">ISteamInventory::GetEligiblePromoItemDefinitionIDs</a> to get the actual ItemDefs.</summary>
        public int numEligiblePromoItemDefs;
        /// <summary>Indicates that the data was retrieved from the cache and not the server. This happens if the user is not logged on or can not otherwise connect to the Steam servers.</summary>
        public bool bCachedData;
    }
}