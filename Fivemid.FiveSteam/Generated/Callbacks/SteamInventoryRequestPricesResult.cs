using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Returned after <a href="https://partner.steamgames.com/doc/api/ISteamInventory#RequestPrices" class="bb_apilink">ISteamInventory::RequestPrices</a> is called.<br />
    /// <br />
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct SteamInventoryRequestPricesResult : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SteamInventoryRequestPricesResult;
        /// <summary><a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultOK" class="bb_apilink">k_EResultOK</a> upon success, any other value indicates failure.</summary>
        public Result result;
        /// <summary>The string representing the user's <a href="https://partner.steamgames.com/doc/store/pricing/currencies" class="bb_doclink">local currency</a> code.</summary>
        public UTF8String4 rgchCurrency;
    }
}