using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Returned after <a href="https://partner.steamgames.com/doc/api/ISteamInventory#StartPurchase" class="bb_apilink">ISteamInventory::StartPurchase</a> is called.<br />
    /// <br />
    /// </summary>
    public unsafe struct SteamInventoryStartPurchaseResult : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SteamInventoryStartPurchaseResult;
        /// <summary><a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultOK" class="bb_apilink">k_EResultOK</a> upon success, any other value indicates failure.</summary>
        public Result result;
        /// <summary>The auto-generated order id for the initiated purchase.</summary>
        public ulong ulOrderID;
        /// <summary>The auto-generated transaction id for the initiated purchase.</summary>
        public ulong ulTransID;
    }
}