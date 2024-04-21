using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Called when an item update has been completed.<br />
    /// <br />
    /// 
    /// <br />
    /// <b>Associated Functions:</b>
    /// <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SubmitItemUpdate" class="bb_apilink">ISteamUGC::SubmitItemUpdate</a>
    /// </summary>
    public unsafe struct SubmitItemUpdateResult : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SubmitItemUpdateResult;
        /// <summary>
        ///             The result of the operation. Some of the possible return values include:<br />
        ///             <ul class="bb_ul">
        ///                 <li>
        ///                     <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultOK" class="bb_apilink">k_EResultOK</a>
        ///                     - The operation completed successfully.<br />
        ///                 </li>
        ///                 <li>
        ///                     <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultFail" class="bb_apilink">k_EResultFail</a>
        ///                     - Generic failure.<br />
        ///                 </li>
        ///                 <li>
        ///                     <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultInvalidParam" class="bb_apilink">k_EResultInvalidParam</a>
        ///                     - Either the provided app ID is invalid or doesn't match the consumer app ID of
        ///                     the item or, you have not enabled ISteamUGC for the provided app ID on the
        ///                     <a href="https://partner.steamgames.com/apps/workshop/" target="_blank" rel="noreferrer">Steam Workshop Configuration</a>
        ///                     App Admin page.<br />
        ///                     The preview file is smaller than 16 bytes.<br />
        ///                 </li>
        ///                 <li>
        ///                     <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultAccessDenied" class="bb_apilink">k_EResultAccessDenied</a>
        ///                     - The user doesn't own a license for the provided app ID.<br />
        ///                 </li>
        ///                 <li>
        ///                     <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultFileNotFound" class="bb_apilink">k_EResultFileNotFound</a>
        ///                     - Failed to get the workshop info for the item or failed to read the preview
        ///                     file.<br />
        ///                 </li>
        ///                 <li>
        ///                     <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultLockingFailed" class="bb_apilink">k_EResultLockingFailed</a>
        ///                     - Failed to aquire UGC Lock.<br />
        ///                 </li>
        ///                 <li>
        ///                     <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultFileNotFound" class="bb_apilink">k_EResultFileNotFound</a>
        ///                     - The provided content folder is not valid.<br />
        ///                 </li>
        ///                 <li>
        ///                     <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultLimitExceeded" class="bb_apilink">k_EResultLimitExceeded</a>
        ///                     - The preview image is too large, it must be less than 1 Megabyte; or there is
        ///                     not enough space available on the user's
        ///                     <a href="https://partner.steamgames.com/doc/features/cloud" class="bb_doclink">Steam Cloud</a>.
        ///                 </li>
        ///             </ul>
        ///         </summary>
        public Result eResult;
        /// <summary>
        ///             Does the user need to accept the Steam Workshop legal agreement? See the
        ///             <a href="https://partner.steamgames.com/doc/features/workshop/implementation#Legal" class="bb_doclink">Workshop Legal Agreement</a>
        ///             for more information.
        ///         </summary>
        public bool bUserNeedsToAcceptWorkshopLegalAgreement;
        /// missing documentation for SubmitItemUpdateResult_t.m_nPublishedFileId
        public PublishedFileId nPublishedFileId;
    }
}