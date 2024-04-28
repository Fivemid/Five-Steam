using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>This callback is triggered whenever item definitions have been updated, which could be in response to <a href="https://partner.steamgames.com/doc/api/ISteamInventory#LoadItemDefinitions" class="bb_apilink">ISteamInventory::LoadItemDefinitions</a> or any time new item definitions are available (eg, from the dynamic addition of new item types while players are still in-game).<br />
    /// <br />
    /// This callback has no fields.<br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamInventory#LoadItemDefinitions" class="bb_apilink">ISteamInventory::LoadItemDefinitions</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE, Size = 1)]
    public unsafe struct SteamInventoryDefinitionUpdate
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SteamInventoryDefinitionUpdate;
    }
}