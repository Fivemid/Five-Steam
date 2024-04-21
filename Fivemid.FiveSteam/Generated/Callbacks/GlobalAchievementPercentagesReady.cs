using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Called when the global achievement percentages have been received from the server.<br />
    /// <br />
    /// 
    /// <br />
    /// <b>Associated Functions:</b>
    /// <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestGlobalAchievementPercentages" class="bb_apilink">ISteamUserStats::RequestGlobalAchievementPercentages</a>
    /// </summary>
    public unsafe struct GlobalAchievementPercentagesReady : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.GlobalAchievementPercentagesReady;
        /// <summary>Game ID which these achievement percentages are for.</summary>
        public ulong nGameID;
        /// <summary>
        ///             Result of the request. Returns:<br />
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultOK" class="bb_apilink">k_EResultOK</a>
        ///             indicating success.<br />
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultInvalidState" class="bb_apilink">k_EResultInvalidState</a>
        ///             Stats haven't been loaded yet, Call
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestCurrentStats" class="bb_apilink">ISteamUserStats::RequestCurrentStats</a>.<br />
        ///             <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultFail" class="bb_apilink">k_EResultFail</a>
        ///             if the remote call fails or there are no global achievement percentages for the current
        ///             AppId.
        ///         </summary>
        public Result eResult;
    }
}