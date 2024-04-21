using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Called when the global stats have been received from the server.<br />
    /// <br />
    /// 
    /// <br />
    /// <b>Associated Functions:</b>
    /// <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestGlobalStats" class="bb_apilink">ISteamUserStats::RequestGlobalStats</a>
    /// </summary>
    public unsafe struct GlobalStatsReceived : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.GlobalStatsReceived;
        /// <summary>Game ID which these global stats are for.</summary>
        public ulong nGameID;
        /// <summary>
        ///             The result of the request. Returns:<br />
        ///             <ul class="bb_ul">
        ///                 <li>
        ///                     <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultOK" class="bb_apilink">k_EResultOK</a>
        ///                     indicating success.<br />
        ///                 </li>
        ///                 <li>
        ///                     <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultInvalidState" class="bb_apilink">k_EResultInvalidState</a>
        ///                     Stats haven't been loaded yet, Call
        ///                     <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestCurrentStats" class="bb_apilink">ISteamUserStats::RequestCurrentStats</a>.<br />
        ///                 </li>
        ///                 <li>
        ///                     <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultFail" class="bb_apilink">k_EResultFail</a>
        ///                     if the remote call fails.
        ///                 </li>
        ///             </ul>
        ///         </summary>
        public Result eResult;
    }
}