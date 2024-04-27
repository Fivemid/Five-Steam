using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Result of a request to store the user stats.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamGameServerStats#StoreUserStats" class="bb_apilink">ISteamGameServerStats::StoreUserStats</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct GSStatsStored
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.GSStatsStored;
        /// <summary>Returns whether the call was successful or not.</summary>
        public Result eResult;
        /// <summary>The user for whom the stats were stored</summary>
        public SteamId steamIDUser;
    }
}