using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Result of our request to create a Lobby. At this point, the lobby has been joined and is ready for
    /// use, a
    /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#LobbyEnter_t" class="bb_apilink">LobbyEnter_t</a>
    /// callback will also be received (since the local user is joining their own lobby).<br />
    /// <br />
    /// 
    /// <br />
    /// <b>Associated Functions:</b>
    /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#CreateLobby" class="bb_apilink">ISteamMatchmaking::CreateLobby</a>
    /// </summary>
    public unsafe struct LobbyCreated : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.LobbyCreated;
        /// <summary>
        ///             The result of the operation.<br />
        ///             <br />
        ///             Possible values:<br />
        ///             <ul class="bb_ul">
        ///                 <li>
        ///                     <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultOK" class="bb_apilink">k_EResultOK</a>
        ///                     - The lobby was successfully created.<br />
        ///                 </li>
        ///                 <li>
        ///                     <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultFail" class="bb_apilink">k_EResultFail</a>
        ///                     - The server responded, but with an unknown internal error.<br />
        ///                 </li>
        ///                 <li>
        ///                     <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultTimeout" class="bb_apilink">k_EResultTimeout</a>
        ///                     - The message was sent to the Steam servers, but it didn't respond.<br />
        ///                 </li>
        ///                 <li>
        ///                     <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultLimitExceeded" class="bb_apilink">k_EResultLimitExceeded</a>
        ///                     - Your game client has created too many lobbies and is being rate limited.<br />
        ///                 </li>
        ///                 <li>
        ///                     <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultAccessDenied" class="bb_apilink">k_EResultAccessDenied</a>
        ///                     - Your game isn't set to allow lobbies, or your client does haven't rights to
        ///                     play the game<br />
        ///                 </li>
        ///                 <li>
        ///                     <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultNoConnection" class="bb_apilink">k_EResultNoConnection</a>
        ///                     - Your Steam client doesn't have a connection to the back-end.
        ///                 </li>
        ///             </ul>
        ///         </summary>
        public Result eResult;
        /// <summary>The Steam ID of the lobby that was created, 0 if failed.</summary>
        public ulong ulSteamIDLobby;
    }
}