using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Result indicating that user generated content has been attached to one of the current user's
    /// leaderboard entries.<br />
    /// <br />
    /// 
    /// <br />
    /// <b>Associated Functions:</b>
    /// <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#AttachLeaderboardUGC" class="bb_apilink">ISteamUserStats::AttachLeaderboardUGC</a>
    /// </summary>
    public unsafe struct LeaderboardUGCSet : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.LeaderboardUGCSet;
        /// <summary>
        ///             The result of the operation.Possible Values:<br />
        ///             <ul class="bb_ul">
        ///                 <li>
        ///                     <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultOK" class="bb_apilink">k_EResultOK</a>
        ///                     - The UGC has been successfully attached.<br />
        ///                 </li>
        ///                 <li>
        ///                     <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultTimeout" class="bb_apilink">k_EResultTimeout</a>
        ///                     - The upload took too long, the UGC was not submitted.<br />
        ///                 </li>
        ///                 <li>
        ///                     <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultInvalidParam" class="bb_apilink">k_EResultInvalidParam</a>
        ///                     - The handle passed into
        ///                     <code class="bb_code bb_code_inline nohighlight">m_hSteamLeaderboard</code> is
        ///                     invalid, the UGC was not submitted.
        ///                 </li>
        ///             </ul>
        ///         </summary>
        public Result eResult;
        /// <summary>Handle to the leaderboard that the UGC was attached to.</summary>
        public SteamLeaderboard hSteamLeaderboard;
    }
}