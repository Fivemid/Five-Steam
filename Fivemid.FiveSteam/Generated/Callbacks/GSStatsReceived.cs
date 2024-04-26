using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Result when getting the latests stats and achievements for a user from the server.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamGameServerStats#RequestUserStats" class="bb_apilink">ISteamGameServerStats::RequestUserStats</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct GSStatsReceived : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.GSStatsReceived;
        /// <summary>Returns whether the call was successful or not. If the user has no stats, this will be set to <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultFail" class="bb_apilink">k_EResultFail</a>.</summary>
        public Result eResult;
        /// <summary>The user whose stats were retrieved.</summary>
        public SteamId steamIDUser;
    }
}