using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when a new workshop item has been created.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#CreateItem" class="bb_apilink">ISteamUGC::CreateItem</a></summary>
    public unsafe struct CreateItemResult : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.CreateItemResult;
        /// <summary>The result of the operation. Some of the possible return values include:<br />
        /// <ul class="bb_ul ">        <li> <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultOK" class="bb_apilink">k_EResultOK</a> - The operation completed successfully.<br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultInsufficientPrivilege" class="bb_apilink">k_EResultInsufficientPrivilege</a> - The user is currently restricted from uploading content due to a hub ban, account lock, or community ban. They would need to contact Steam Support.<br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultBanned" class="bb_apilink">k_EResultBanned</a> - The user doesn't have permission to upload content to this hub because they have an active VAC or Game ban.<br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultTimeout" class="bb_apilink">k_EResultTimeout</a> - The operation took longer than expected. Have the user retry the creation process.<br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultNotLoggedOn" class="bb_apilink">k_EResultNotLoggedOn</a> - The user is not currently logged into Steam.<br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultServiceUnavailable" class="bb_apilink">k_EResultServiceUnavailable</a> - The workshop server hosting the content is having issues - have the user retry.<br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultInvalidParam" class="bb_apilink">k_EResultInvalidParam</a> - One of the submission fields contains something not being accepted by that field. <br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultAccessDenied" class="bb_apilink">k_EResultAccessDenied</a> - There was a problem trying to save the title and description.  Access was denied.<br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultLimitExceeded" class="bb_apilink">k_EResultLimitExceeded</a> - The user has exceeded their Steam Cloud quota. Have them remove some items and try again.<br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultFileNotFound" class="bb_apilink">k_EResultFileNotFound</a> - The uploaded file could not be found.<br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultDuplicateRequest" class="bb_apilink">k_EResultDuplicateRequest</a> - The file was already successfully uploaded. The user just needs to refresh.<br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultDuplicateName" class="bb_apilink">k_EResultDuplicateName</a> - The user already has a Steam Workshop item with that name.	<br />
        /// 	</li><li> <a href="https://partner.steamgames.com/doc/api/steam_api#k_EResultServiceReadOnly" class="bb_apilink">k_EResultServiceReadOnly</a> - Due to a recent password or email change, the user is not allowed to upload new content. Usually this restriction will expire in 5 days, but can last up to 30 days if the account has been inactive recently.	</li></ul></summary>
        public Result eResult;
        /// <summary>The new item's unique ID.</summary>
        public PublishedFileId nPublishedFileId;
        /// <summary>Does the user need to accept the Steam Workshop legal agreement (<b>true</b>) or not (<b>false</b>)? See the <a href="https://partner.steamgames.com/doc/features/workshop/implementation#Legal" class="bb_doclink">Workshop Legal Agreement</a> for more information.</summary>
        public bool bUserNeedsToAcceptWorkshopLegalAgreement;
    }
}