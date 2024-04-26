using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>This is fired whenever an inventory result transitions from <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultPending" class="bb_apilink">k_EResultPending</a> to any other completed state, see <a href="https://partner.steamgames.com/doc/api/ISteamInventory#GetResultStatus" class="bb_apilink">ISteamInventory::GetResultStatus</a> for the complete list of states. There will always be exactly one callback per handle.<br />
    /// <br />
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct SteamInventoryResultReady : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SteamInventoryResultReady;
        /// <summary>The inventory result which is now ready.</summary>
        public SteamInventoryResult handle;
        /// <summary>The new status of the handle. This is equivalent to calling <a href="https://partner.steamgames.com/doc/api/ISteamInventory#GetResultStatus" class="bb_apilink">ISteamInventory::GetResultStatus</a>.</summary>
        public Result result;
    }
}