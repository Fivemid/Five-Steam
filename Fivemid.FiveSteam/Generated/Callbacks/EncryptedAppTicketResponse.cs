using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Called when an encrypted application ticket has been received.<br />
    /// <br />
    /// 
    /// <br />
    /// <b>Associated Functions:</b>
    /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#RequestEncryptedAppTicket" class="bb_apilink">ISteamUser::RequestEncryptedAppTicket</a>
    /// </summary>
    public unsafe struct EncryptedAppTicketResponse : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.EncryptedAppTicketResponse;
        /// <summary>
        ///             Was the call successful?<br />
        ///             Possible results:<br />
        ///             <ul class="bb_ul">
        ///                 <li>
        ///                     <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultOK" class="bb_apilink">k_EResultOK</a>
        ///                     - Success!<br />
        ///                 </li>
        ///                 <li>
        ///                     <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultNoConnection" class="bb_apilink">k_EResultNoConnection</a>
        ///                     - A connection to Steam could not be established.<br />
        ///                 </li>
        ///                 <li>
        ///                     <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultDuplicateRequest" class="bb_apilink">k_EResultDuplicateRequest</a>
        ///                     - There is already a pending request.<br />
        ///                 </li>
        ///                 <li>
        ///                     <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultLimitExceeded" class="bb_apilink">k_EResultLimitExceeded</a>
        ///                     - This call is subject to a 60 second rate limit, and you have exceeded that.
        ///                 </li>
        ///             </ul>
        ///         </summary>
        public Result eResult;
    }
}