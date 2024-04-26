using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when the latest stats and achievements for a specific user (including the local user) have been received from the server.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestCurrentStats" class="bb_apilink">ISteamUserStats::RequestCurrentStats</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestUserStats" class="bb_apilink">ISteamUserStats::RequestUserStats</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct UserStatsReceived : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.UserStatsReceived;
        /// <summary>Game ID that these stats are for.</summary>
        public ulong nGameID;
        /// <summary>Returns whether the call was successful or not. If the user has no stats, this will be set to <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultFail" class="bb_apilink">k_EResultFail</a>.</summary>
        public Result eResult;
        /// <summary>The user whose stats were retrieved.</summary>
        public SteamId steamIDUser;
    }
}