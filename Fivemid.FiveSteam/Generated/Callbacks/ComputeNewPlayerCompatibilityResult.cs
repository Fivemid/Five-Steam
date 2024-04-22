using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Sent when the game server is checking if the new player is a good fit for the server based on the frenemy system.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#ComputeNewPlayerCompatibility" class="bb_apilink">ISteamGameServer::ComputeNewPlayerCompatibility</a></summary>
    public unsafe struct ComputeNewPlayerCompatibilityResult : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.ComputeNewPlayerCompatibilityResult;
        /// <summary>The result of the operation. Possible values:<br />
        /// <ul class="bb_ul ">	<li> <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultOK" class="bb_apilink">k_EResultOK</a> - Success<br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultFail" class="bb_apilink">k_EResultFail</a> - Generic failure.<br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultTimeout" class="bb_apilink">k_EResultTimeout</a> - The message was sent to the Steam servers, but it didn't respond.<br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultNoConnection" class="bb_apilink">k_EResultNoConnection</a> - Your Steam client doesn't have a connection to the back-end.</li></ul></summary>
        public Result eResult;
        /// <summary>The number of current players that don't like playing with the specified player.</summary>
        public int cPlayersThatDontLikeCandidate;
        /// <summary>The number of players on the server that the specified player doesn't like playing with.</summary>
        public int cPlayersThatCandidateDoesntLike;
        /// <summary>The number of players in the associated Steam group that don't like playing with the player.</summary>
        public int cClanPlayersThatDontLikeCandidate;
        /// <summary>The Steam ID of the specified player.</summary>
        public SteamId SteamIDCandidate;
    }
}