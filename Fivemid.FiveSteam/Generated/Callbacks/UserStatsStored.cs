using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Result of a request to store the user stats.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#StoreStats" class="bb_apilink">ISteamUserStats::StoreStats</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#IndicateAchievementProgress" class="bb_apilink">ISteamUserStats::IndicateAchievementProgress</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct UserStatsStored
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.UserStatsStored;
        /// <summary>Game ID that these stats are for.</summary>
        public ulong nGameID;
        /// <summary>Returns whether the call was successful or not.</summary>
        public Result eResult;
    }
}