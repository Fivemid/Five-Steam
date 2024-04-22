using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamUGC
    {
        public static ISteamUGC.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamUGC_v018", CallingConvention = Platform.CC)]
        private static extern ISteamUGC.Instance Accessor();
        /// <summary><code>UGCQueryHandle_t CreateQueryUserUGCRequest( AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint32 unPage );</code><br />
        /// Query UGC associated with a user. You can use this to list the UGC the user is subscribed to amongst other things.<br />
        /// <br />
        /// This will return up to 50 results as declared by <a href="https://partner.steamgames.com/doc/api/ISteamUGC#kNumUGCResultsPerPage" class="bb_apilink">kNumUGCResultsPerPage</a>. You can make subsequent calls to this function, increasing the <code class="bb_code bb_code_inline nohighlight">unPage</code> each time to get the next set of results.<br />
        /// <br />
        /// <b>NOTE:</b> Either <code class="bb_code bb_code_inline nohighlight">nConsumerAppID</code> or <code class="bb_code bb_code_inline nohighlight">nCreatorAppID</code> must have a valid AppID!<br />
        /// <br />
        /// <b>NOTE:</b> You must release the handle returned by this function by calling <a href="https://partner.steamgames.com/doc/api/ISteamUGC#ReleaseQueryUGCRequest" class="bb_apilink">ISteamUGC::ReleaseQueryUGCRequest</a> when you are done with it!<br />
        /// <br />
        /// To query all the UGC for your app you can use <a href="https://partner.steamgames.com/doc/api/ISteamUGC#CreateQueryAllUGCRequest" class="bb_apilink">ISteamUGC::CreateQueryAllUGCRequest</a> instead.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCQueryHandle_t" class="bb_apilink">UGCQueryHandle_t</a><br />
        /// Returns a new <a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCQueryHandle_t" class="bb_apilink">UGCQueryHandle_t</a> upon success, and <a href="https://partner.steamgames.com/doc/api/ISteamUGC#k_UGCQueryHandleInvalid" class="bb_apilink">k_UGCQueryHandleInvalid</a> in the following situations:<br />
        /// <ul class="bb_ul ">	<li> Either <code class="bb_code bb_code_inline nohighlight">nCreatorAppID</code> or <code class="bb_code bb_code_inline nohighlight">nConsumerAppID</code> is not set to the currently running app.<br />
        /// 	</li><li> <code class="bb_code bb_code_inline nohighlight">unPage</code> was less than <b>1</b>.<br />
        /// 	</li><li> The given <code class="bb_code bb_code_inline nohighlight">eListType</code> is not supported for users other than the one requesting the details.<br />
        /// 	</li><li> An internal error occurred.</li></ul><br />
        /// This handle can be used to further customize the query before sending it out with <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SendQueryUGCRequest" class="bb_apilink">ISteamUGC::SendQueryUGCRequest</a>.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUtils#GetAppID" class="bb_apilink">ISteamUtils::GetAppID</a></summary>
        /// <param name="unAccountID"><a href="https://partner.steamgames.com/doc/api/steam_api#AccountID_t" class="bb_apilink">AccountID_t</a>: The Account ID to query the UGC for. You can use <code class="bb_code bb_code_inline nohighlight">CSteamID.GetAccountID</code> to get the Account ID from a Steam ID.</param>
        /// <param name="eListType"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#EUserUGCList" class="bb_apilink">EUserUGCList</a>: Used to specify the type of list to get.<br />
        /// If the currently logged in user is different than the user specified in <code class="bb_code bb_code_inline nohighlight">unAccountID</code>, then some options are not allowed. (<a href="https://partner.steamgames.com/doc/api/ISteamUGC#k_EUserUGCList_VotedOn" class="bb_apilink">k_EUserUGCList_VotedOn</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#k_EUserUGCList_VotedUp" class="bb_apilink">k_EUserUGCList_VotedUp</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#k_EUserUGCList_VotedDown" class="bb_apilink">k_EUserUGCList_VotedDown</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#k_EUserUGCList_WillVoteLater" class="bb_apilink">k_EUserUGCList_WillVoteLater</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#k_EUserUGCList_Subscribed" class="bb_apilink">k_EUserUGCList_Subscribed</a>)</param>
        /// <param name="eMatchingUGCType"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#EUGCMatchingUGCType" class="bb_apilink">EUGCMatchingUGCType</a>: Used to specify the type of UGC queried for.</param>
        /// <param name="eSortOrder"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#EUserUGCListSortOrder" class="bb_apilink">EUserUGCListSortOrder</a>: Used to specify the order that the list will be sorted in.</param>
        /// <param name="nCreatorAppID"><a href="https://partner.steamgames.com/doc/api/steam_api#AppId_t" class="bb_apilink">AppId_t</a>: This should contain the App ID of the app where the item was created. This may be different than <code class="bb_code bb_code_inline nohighlight">nConsumerAppID</code> if your item creation tool is a separate App ID.</param>
        /// <param name="nConsumerAppID"><a href="https://partner.steamgames.com/doc/api/steam_api#AppId_t" class="bb_apilink">AppId_t</a>: This should contain the App ID for the current game or application. Do not pass the App ID of the workshop item creation tool if that is a separate App ID!</param>
        /// <param name="unPage"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The page number of the results to receive. This should start at 1 on the first call.</param>
        public static UGCQueryHandle CreateQueryUserUGCRequest(AccountID unAccountID, UserUGCList eListType, UGCMatchingUGCType eMatchingUGCType, UserUGCListSortOrder eSortOrder, AppId nCreatorAppID, AppId nConsumerAppID, uint unPage) => Instance.CreateQueryUserUGCRequest(unAccountID, eListType, eMatchingUGCType, eSortOrder, nCreatorAppID, nConsumerAppID, unPage);
        /// <summary><code>UGCQueryHandle_t CreateQueryAllUGCRequest( EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint32 unPage );</code><br />
        /// Query for all matching UGC. You can use this to list all of the available UGC for your app.<br />
        /// <br />
        /// This will return up to 50 results as declared by <a href="https://partner.steamgames.com/doc/api/ISteamUGC#kNumUGCResultsPerPage" class="bb_apilink">kNumUGCResultsPerPage</a>. You can make subsequent calls to this function, increasing the <code class="bb_code bb_code_inline nohighlight">unPage</code> each time to get the next set of results.<br />
        /// <br />
        /// <b>NOTE:</b> Either <code class="bb_code bb_code_inline nohighlight">nConsumerAppID</code> or <code class="bb_code bb_code_inline nohighlight">nCreatorAppID</code> must have a valid AppID!<br />
        /// <br />
        /// <b>NOTE:</b> You must release the handle returned by this function by calling <a href="https://partner.steamgames.com/doc/api/ISteamUGC#ReleaseQueryUGCRequest" class="bb_apilink">ISteamUGC::ReleaseQueryUGCRequest</a> when you are done with it!<br />
        /// <br />
        /// To query for the UGC associated with a single user you can use <a href="https://partner.steamgames.com/doc/api/ISteamUGC#CreateQueryUserUGCRequest" class="bb_apilink">ISteamUGC::CreateQueryUserUGCRequest</a> instead.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCQueryHandle_t" class="bb_apilink">UGCQueryHandle_t</a><br />
        /// Returns a new <a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCQueryHandle_t" class="bb_apilink">UGCQueryHandle_t</a> upon success, and <a href="https://partner.steamgames.com/doc/api/ISteamUGC#k_UGCQueryHandleInvalid" class="bb_apilink">k_UGCQueryHandleInvalid</a> in the following situations:<br />
        /// <ul class="bb_ul ">	<li> Either <code class="bb_code bb_code_inline nohighlight">nCreatorAppID</code> or <code class="bb_code bb_code_inline nohighlight">nConsumerAppID</code> is not set to the currently running app.<br />
        /// 	</li><li> <code class="bb_code bb_code_inline nohighlight">unPage</code> was less than <b>1</b>.<br />
        /// 	</li><li> An internal error occurred.</li></ul><br />
        /// This handle can be used to further customize the query before sending it out with <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SendQueryUGCRequest" class="bb_apilink">ISteamUGC::SendQueryUGCRequest</a>.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUtils#GetAppID" class="bb_apilink">ISteamUtils::GetAppID</a></summary>
        /// <param name="eQueryType"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#EUGCQuery" class="bb_apilink">EUGCQuery</a>: Used to specify the sorting and filtering for this call.</param>
        /// <param name="eMatchingeMatchingUGCTypeFileType"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#EUGCMatchingUGCType" class="bb_apilink">EUGCMatchingUGCType</a>: Used to specify the type of UGC queried for.</param>
        /// <param name="nCreatorAppID"><a href="https://partner.steamgames.com/doc/api/steam_api#AppId_t" class="bb_apilink">AppId_t</a>: This should contain the App ID of the app where the item was created. This may be different than <code class="bb_code bb_code_inline nohighlight">nConsumerAppID</code> if your item creation tool is a separate App ID.</param>
        /// <param name="nConsumerAppID"><a href="https://partner.steamgames.com/doc/api/steam_api#AppId_t" class="bb_apilink">AppId_t</a>: This should contain the App ID for the current game or application. Do not pass the App ID of the workshop item creation tool if that is a separate App ID!</param>
        /// <param name="unPage"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The page number of the results to receive. This should start at 1 on the first call.</param>
        public static UGCQueryHandle CreateQueryAllUGCRequest(UGCQuery eQueryType, UGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId nCreatorAppID, AppId nConsumerAppID, uint unPage) => Instance.CreateQueryAllUGCRequest(eQueryType, eMatchingeMatchingUGCTypeFileType, nCreatorAppID, nConsumerAppID, unPage);
        /// <summary><code>UGCQueryHandle_t CreateQueryAllUGCRequest( EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint32 unPage );</code><br />
        /// Query for all matching UGC. You can use this to list all of the available UGC for your app.<br />
        /// <br />
        /// This will return up to 50 results as declared by <a href="https://partner.steamgames.com/doc/api/ISteamUGC#kNumUGCResultsPerPage" class="bb_apilink">kNumUGCResultsPerPage</a>. You can make subsequent calls to this function, increasing the <code class="bb_code bb_code_inline nohighlight">unPage</code> each time to get the next set of results.<br />
        /// <br />
        /// <b>NOTE:</b> Either <code class="bb_code bb_code_inline nohighlight">nConsumerAppID</code> or <code class="bb_code bb_code_inline nohighlight">nCreatorAppID</code> must have a valid AppID!<br />
        /// <br />
        /// <b>NOTE:</b> You must release the handle returned by this function by calling <a href="https://partner.steamgames.com/doc/api/ISteamUGC#ReleaseQueryUGCRequest" class="bb_apilink">ISteamUGC::ReleaseQueryUGCRequest</a> when you are done with it!<br />
        /// <br />
        /// To query for the UGC associated with a single user you can use <a href="https://partner.steamgames.com/doc/api/ISteamUGC#CreateQueryUserUGCRequest" class="bb_apilink">ISteamUGC::CreateQueryUserUGCRequest</a> instead.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCQueryHandle_t" class="bb_apilink">UGCQueryHandle_t</a><br />
        /// Returns a new <a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCQueryHandle_t" class="bb_apilink">UGCQueryHandle_t</a> upon success, and <a href="https://partner.steamgames.com/doc/api/ISteamUGC#k_UGCQueryHandleInvalid" class="bb_apilink">k_UGCQueryHandleInvalid</a> in the following situations:<br />
        /// <ul class="bb_ul ">	<li> Either <code class="bb_code bb_code_inline nohighlight">nCreatorAppID</code> or <code class="bb_code bb_code_inline nohighlight">nConsumerAppID</code> is not set to the currently running app.<br />
        /// 	</li><li> <code class="bb_code bb_code_inline nohighlight">unPage</code> was less than <b>1</b>.<br />
        /// 	</li><li> An internal error occurred.</li></ul><br />
        /// This handle can be used to further customize the query before sending it out with <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SendQueryUGCRequest" class="bb_apilink">ISteamUGC::SendQueryUGCRequest</a>.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUtils#GetAppID" class="bb_apilink">ISteamUtils::GetAppID</a></summary>
        /// <param name="eQueryType"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#EUGCQuery" class="bb_apilink">EUGCQuery</a>: Used to specify the sorting and filtering for this call.</param>
        /// <param name="eMatchingeMatchingUGCTypeFileType"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#EUGCMatchingUGCType" class="bb_apilink">EUGCMatchingUGCType</a>: Used to specify the type of UGC queried for.</param>
        /// <param name="nCreatorAppID"><a href="https://partner.steamgames.com/doc/api/steam_api#AppId_t" class="bb_apilink">AppId_t</a>: This should contain the App ID of the app where the item was created. This may be different than <code class="bb_code bb_code_inline nohighlight">nConsumerAppID</code> if your item creation tool is a separate App ID.</param>
        /// <param name="nConsumerAppID"><a href="https://partner.steamgames.com/doc/api/steam_api#AppId_t" class="bb_apilink">AppId_t</a>: This should contain the App ID for the current game or application. Do not pass the App ID of the workshop item creation tool if that is a separate App ID!</param>
        /// <param name="unPage"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The page number of the results to receive. This should start at 1 on the first call.</param>
        public static UGCQueryHandle CreateQueryAllUGCRequest(UGCQuery eQueryType, UGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId nCreatorAppID, AppId nConsumerAppID, UTF8StringPtr pchCursor) => Instance.CreateQueryAllUGCRequest(eQueryType, eMatchingeMatchingUGCTypeFileType, nCreatorAppID, nConsumerAppID, pchCursor);
        /// <summary><code>UGCQueryHandle_t CreateQueryUGCDetailsRequest( PublishedFileId_t *pvecPublishedFileID, uint32 unNumPublishedFileIDs );</code><br />
        /// Query for the details of specific UGC items.  There is currently a 1,000 limit for the number of items you can request, but this may be lifted in the future.<br />
        /// <br />
        /// Note: this API is normally used to retrieve metadata about UGC for display purposes, so it is a good practice to keep the list of items small to match your UI.  Subscribed items should have enough information to be used, available through:<br />
        /// <ul class="bb_ul "><li><a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetNumSubscribedItems" class="bb_apilink">ISteamUGC::GetNumSubscribedItems</a><br />
        /// </li><li><a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetSubscribedItems" class="bb_apilink">ISteamUGC::GetSubscribedItems</a><br />
        /// </li><li><a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetItemState" class="bb_apilink">ISteamUGC::GetItemState</a><br />
        /// </li><li><a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetItemInstallInfo" class="bb_apilink">ISteamUGC::GetItemInstallInfo</a></li></ul><br />
        /// <b>NOTE:</b> Either <code class="bb_code bb_code_inline nohighlight">nConsumerAppID</code> or <code class="bb_code bb_code_inline nohighlight">nCreatorAppID</code> must have a valid AppID!<br />
        /// <br />
        /// <b>NOTE:</b> You must release the handle returned by this function by calling <a href="https://partner.steamgames.com/doc/api/ISteamUGC#ReleaseQueryUGCRequest" class="bb_apilink">ISteamUGC::ReleaseQueryUGCRequest</a> when you are done with it!<br />
        /// <br />
        /// To query all the UGC for your app you can use <a href="https://partner.steamgames.com/doc/api/ISteamUGC#CreateQueryAllUGCRequest" class="bb_apilink">ISteamUGC::CreateQueryAllUGCRequest</a> instead.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCQueryHandle_t" class="bb_apilink">UGCQueryHandle_t</a><br />
        /// Returns a new <a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCQueryHandle_t" class="bb_apilink">UGCQueryHandle_t</a> upon success, and <a href="https://partner.steamgames.com/doc/api/ISteamUGC#k_UGCQueryHandleInvalid" class="bb_apilink">k_UGCQueryHandleInvalid</a> in the following situations:<br />
        /// <ul class="bb_ul ">	<li> <code class="bb_code bb_code_inline nohighlight">unNumPublishedFileIDs</code> is less than 1.<br />
        /// 	</li><li> An internal error occurred.</li></ul><br />
        /// This handle can be used to further customize the query before sending it out with <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SendQueryUGCRequest" class="bb_apilink">ISteamUGC::SendQueryUGCRequest</a>.</summary>
        /// <param name="pvecPublishedFileID"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishedFileId_t" class="bb_apilink">PublishedFileId_t</a> *: The list of workshop items to get the details for.</param>
        /// <param name="unNumPublishedFileIDs"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The number of items in <code class="bb_code bb_code_inline nohighlight">pvecPublishedFileID</code>.</param>
        public static UGCQueryHandle CreateQueryUGCDetailsRequest(PublishedFileId* pvecPublishedFileID, uint unNumPublishedFileIDs) => Instance.CreateQueryUGCDetailsRequest(pvecPublishedFileID, unNumPublishedFileIDs);
        /// <summary><code>SteamAPICall_t SendQueryUGCRequest( UGCQueryHandle_t handle );</code><br />
        /// Send a UGC query to Steam.<br />
        /// <br />
        /// This must be called with a handle obtained from <a href="https://partner.steamgames.com/doc/api/ISteamUGC#CreateQueryUserUGCRequest" class="bb_apilink">ISteamUGC::CreateQueryUserUGCRequest</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#CreateQueryAllUGCRequest" class="bb_apilink">ISteamUGC::CreateQueryAllUGCRequest</a>, or <a href="https://partner.steamgames.com/doc/api/ISteamUGC#CreateQueryUGCDetailsRequest" class="bb_apilink">ISteamUGC::CreateQueryUGCDetailsRequest</a> to actually send the request to Steam. Before calling this you should use one or more of the following APIs to customize your query:<br />
        /// <a href="https://partner.steamgames.com/doc/api/ISteamUGC#AddRequiredTag" class="bb_apilink">ISteamUGC::AddRequiredTag</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#AddExcludedTag" class="bb_apilink">ISteamUGC::AddExcludedTag</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetReturnOnlyIDs" class="bb_apilink">ISteamUGC::SetReturnOnlyIDs</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetReturnKeyValueTags" class="bb_apilink">ISteamUGC::SetReturnKeyValueTags</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetReturnLongDescription" class="bb_apilink">ISteamUGC::SetReturnLongDescription</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetReturnMetadata" class="bb_apilink">ISteamUGC::SetReturnMetadata</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetReturnChildren" class="bb_apilink">ISteamUGC::SetReturnChildren</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetReturnAdditionalPreviews" class="bb_apilink">ISteamUGC::SetReturnAdditionalPreviews</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetReturnTotalOnly" class="bb_apilink">ISteamUGC::SetReturnTotalOnly</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetLanguage" class="bb_apilink">ISteamUGC::SetLanguage</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetAllowCachedResponse" class="bb_apilink">ISteamUGC::SetAllowCachedResponse</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetCloudFileNameFilter" class="bb_apilink">ISteamUGC::SetCloudFileNameFilter</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetMatchAnyTag" class="bb_apilink">ISteamUGC::SetMatchAnyTag</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetSearchText" class="bb_apilink">ISteamUGC::SetSearchText</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetRankedByTrendDays" class="bb_apilink">ISteamUGC::SetRankedByTrendDays</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#AddRequiredKeyValueTag" class="bb_apilink">ISteamUGC::AddRequiredKeyValueTag</a><br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SteamUGCQueryCompleted_t" class="bb_apilink">SteamUGCQueryCompleted_t</a> call result.<br />
        /// Returns <a href="https://partner.steamgames.com/doc/api/steam_api#k_uAPICallInvalid" class="bb_apilink">k_uAPICallInvalid</a> if the UGC query <code class="bb_code bb_code_inline nohighlight">handle</code> was invalid.</summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCQueryHandle_t" class="bb_apilink">UGCQueryHandle_t</a>: The UGC query request handle to send.</param>
        public static SteamAPICall SendQueryUGCRequest(UGCQueryHandle handle) => Instance.SendQueryUGCRequest(handle);
        /// <summary><code>bool GetQueryUGCResult( UGCQueryHandle_t handle, uint32 index, SteamUGCDetails_t *pDetails );</code><br />
        /// Retrieve the details of an individual workshop item after receiving a querying UGC call result.<br />
        /// <br />
        /// You should call this in a loop to get the details of all the workshop items returned.<br />
        /// <br />
        /// <b>NOTE:</b> This must only be called with the handle obtained from a successful <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SteamUGCQueryCompleted_t" class="bb_apilink">SteamUGCQueryCompleted_t</a> call result.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success, indicates that <code class="bb_code bb_code_inline nohighlight">pDetails</code> has been filled out.<br />
        /// Otherwise, <b>false</b> if the UGC query <code class="bb_code bb_code_inline nohighlight">handle</code> is invalid or the <code class="bb_code bb_code_inline nohighlight">index</code> is out of bounds.</summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCQueryHandle_t" class="bb_apilink">UGCQueryHandle_t</a>: The UGC query handle to get the results from.</param>
        /// <param name="index"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The index of the item to get the details of.</param>
        /// <param name="pDetails"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#SteamUGCDetails_t" class="bb_apilink">SteamUGCDetails_t</a> *: Returns the the UGC details.</param>
        public static bool GetQueryUGCResult(UGCQueryHandle handle, uint index, SteamUGCDetails* pDetails) => Instance.GetQueryUGCResult(handle, index, pDetails);
        /// <summary><code>uint32 GetQueryUGCNumTags( UGCQueryHandle_t handle, uint32 index );</code><br />
        /// Available in SDK v1.51.<br />
        /// <br />
        /// Retrieve the number of tags for an individual workshop item after receiving a querying UGC call result.<br />
        /// <br />
        /// You should call this in a loop to get the details of all the workshop items returned.<br />
        /// <br />
        /// <b>NOTE:</b> This must only be called with the handle obtained from a successful <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SteamUGCQueryCompleted_t" class="bb_apilink">SteamUGCQueryCompleted_t</a> call result.<br />
        /// <br />
        /// You can then call <a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetQueryUGCTag" class="bb_apilink">ISteamUGC::GetQueryUGCTag</a> to get the tag name or <a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetQueryUGCTagDisplayName" class="bb_apilink">ISteamUGC::GetQueryUGCTagDisplayName</a> to get the localized tag string (if any).<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a><br />
        /// The number of key-value tags associated with the specified workshop item.<br />
        /// Returns <b>0</b> if the UGC query <code class="bb_code bb_code_inline nohighlight">handle</code> is invalid or the <code class="bb_code bb_code_inline nohighlight">index</code> is out of bounds.</summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCQueryHandle_t" class="bb_apilink">UGCQueryHandle_t</a>: The UGC query handle to get the results from.</param>
        /// <param name="index"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The index of the item to get the details of.</param>
        public static uint GetQueryUGCNumTags(UGCQueryHandle handle, uint index) => Instance.GetQueryUGCNumTags(handle, index);
        /// <summary><code>bool GetQueryUGCTag( UGCQueryHandle_t handle, uint32 index, uint32 tagIndex, char *pchValue, uint32 cchValueSize );</code><br />
        /// Available in SDK v1.51.<br />
        /// <br />
        /// Retrieve the "nth" tag associated with an individual workshop item after receiving a querying UGC call result.<br />
        /// <br />
        /// You should call this in a loop to get the details of all the workshop items returned.<br />
        /// <br />
        /// <b>NOTE:</b> This must only be called with the handle obtained from a successful <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SteamUGCQueryCompleted_t" class="bb_apilink">SteamUGCQueryCompleted_t</a> call result.<br />
        /// <br />
        /// Before calling this you should call <a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetQueryUGCNumTags" class="bb_apilink">ISteamUGC::GetQueryUGCNumTags</a> to get number of tags.</summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCQueryHandle_t" class="bb_apilink">UGCQueryHandle_t</a>: The UGC query handle to get the results from.</param>
        /// <param name="index"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The index of the item to get the details of.</param>
        /// <param name="tagIndex"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The index of the tag.</param>
        /// <param name="pchValue">char *: Returns the value by copying it into this string.</param>
        /// <param name="cchValueSize"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The size of <code class="bb_code bb_code_inline nohighlight">pchValue</code> in bytes (allocate at least 64 bytes).</param>
        public static bool GetQueryUGCTag(UGCQueryHandle handle, uint index, uint indexTag, char* pchValue, uint cchValueSize) => Instance.GetQueryUGCTag(handle, index, indexTag, pchValue, cchValueSize);
        /// <summary><code>bool GetQueryUGCTagDisplayName( UGCQueryHandle_t handle, uint32 index, uint32 tagIndex, char *pchValue, uint32 cchValueSize );</code><br />
        /// Available in SDK v1.51.<br />
        /// <br />
        /// Retrieve the "nth" display string (usually localized) for a tag, which is associated with an individual workshop item after receiving a querying UGC call result.<br />
        /// <br />
        /// You should call this in a loop to get the details of all the workshop items returned.<br />
        /// <br />
        /// <b>NOTE:</b> This must only be called with the handle obtained from a successful <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SteamUGCQueryCompleted_t" class="bb_apilink">SteamUGCQueryCompleted_t</a> call result.<br />
        /// <br />
        /// Before calling this you should call <a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetQueryUGCNumTags" class="bb_apilink">ISteamUGC::GetQueryUGCNumTags</a> to get number of tags.</summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCQueryHandle_t" class="bb_apilink">UGCQueryHandle_t</a>: The UGC query handle to get the results from.</param>
        /// <param name="index"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The index of the item to get the details of.</param>
        /// <param name="tagIndex"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The index of the tag.</param>
        /// <param name="pchValue">char *: Returns the value by copying it into this string.</param>
        /// <param name="cchValueSize"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The size of <code class="bb_code bb_code_inline nohighlight">pchValue</code> in bytes (allocate at least 256 bytes).</param>
        public static bool GetQueryUGCTagDisplayName(UGCQueryHandle handle, uint index, uint indexTag, char* pchValue, uint cchValueSize) => Instance.GetQueryUGCTagDisplayName(handle, index, indexTag, pchValue, cchValueSize);
        /// <summary><code>bool GetQueryUGCPreviewURL( UGCQueryHandle_t handle, uint32 index, char *pchURL, uint32 cchURLSize );</code><br />
        /// Retrieve the URL to the preview image of an individual workshop item after receiving a querying UGC call result.<br />
        /// <br />
        /// You should call this in a loop to get the details of all the workshop items returned.<br />
        /// <br />
        /// <b>NOTE:</b> This must only be called with the handle obtained from a successful <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SteamUGCQueryCompleted_t" class="bb_apilink">SteamUGCQueryCompleted_t</a> call result.<br />
        /// <br />
        /// You can use this URL to download and display the preview image instead of having to download it using the <code class="bb_code bb_code_inline nohighlight">m_hPreviewFile</code> in the <code class="bb_code bb_code_inline nohighlight">ISteamUGC::SteamUGCDetails_t</code> struct.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success, indicates that <code class="bb_code bb_code_inline nohighlight">pchURL</code> has been filled out.<br />
        /// Otherwise, <b>false</b> if the UGC query <code class="bb_code bb_code_inline nohighlight">handle</code> is invalid or the <code class="bb_code bb_code_inline nohighlight">index</code> is out of bounds.</summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCQueryHandle_t" class="bb_apilink">UGCQueryHandle_t</a>: The UGC query handle to get the results from.</param>
        /// <param name="index"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The index of the item to get the details of.</param>
        /// <param name="pchURL">char *: Returns the Metadata by copying it into this string.</param>
        /// <param name="cchURLSize"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The size of <code class="bb_code bb_code_inline nohighlight">pchURL</code> in bytes.</param>
        public static bool GetQueryUGCPreviewURL(UGCQueryHandle handle, uint index, char* pchURL, uint cchURLSize) => Instance.GetQueryUGCPreviewURL(handle, index, pchURL, cchURLSize);
        /// <summary><code>bool GetQueryUGCMetadata( UGCQueryHandle_t handle, uint32 index, char *pchMetadata, uint32 cchMetadatasize );</code><br />
        /// Retrieve the developer set metadata of an individual workshop item after receiving a querying UGC call result.<br />
        /// <br />
        /// You should call this in a loop to get the details of all the workshop items returned.<br />
        /// <br />
        /// <b>NOTE:</b> This must only be called with the handle obtained from a successful <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SteamUGCQueryCompleted_t" class="bb_apilink">SteamUGCQueryCompleted_t</a> call result.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success, indicates that <code class="bb_code bb_code_inline nohighlight">pchMetadata</code> has been filled out.<br />
        /// Otherwise, <b>false</b> if the UGC query <code class="bb_code bb_code_inline nohighlight">handle</code> is invalid or the <code class="bb_code bb_code_inline nohighlight">index</code> is out of bounds.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetItemMetadata" class="bb_apilink">ISteamUGC::SetItemMetadata</a></summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCQueryHandle_t" class="bb_apilink">UGCQueryHandle_t</a>: The UGC query handle to get the results from.</param>
        /// <param name="index"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The index of the item to get the details of.</param>
        /// <param name="pchMetadata">char *: Returns the url by copying it into this string.</param>
        /// <param name="cchMetadatasize"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The size of <code class="bb_code bb_code_inline nohighlight">pchMetadata</code> in bytes.</param>
        public static bool GetQueryUGCMetadata(UGCQueryHandle handle, uint index, char* pchMetadata, uint cchMetadatasize) => Instance.GetQueryUGCMetadata(handle, index, pchMetadata, cchMetadatasize);
        /// <summary><code>bool GetQueryUGCChildren( UGCQueryHandle_t handle, uint32 index, PublishedFileId_t*pvecPublishedFileID, uint32 cMaxEntries );</code><br />
        /// Retrieve the ids of any child items of an individual workshop item after receiving a querying UGC call result.  These items can either be a part of a collection or some other dependency (see <a href="https://partner.steamgames.com/doc/api/ISteamUGC#AddDependency" class="bb_apilink">ISteamUGC::AddDependency</a>).<br />
        /// <br />
        /// You should call this in a loop to get the details of all the workshop items returned.<br />
        /// <br />
        /// <b>NOTE:</b> This must only be called with the handle obtained from a successful <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SteamUGCQueryCompleted_t" class="bb_apilink">SteamUGCQueryCompleted_t</a> call result.<br />
        /// <br />
        /// You should create <code class="bb_code bb_code_inline nohighlight">pvecPublishedFileID</code> with <code class="bb_code bb_code_inline nohighlight">m_unNumChildren</code> provided in <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SteamUGCDetails_t" class="bb_apilink">SteamUGCDetails_t</a> after getting the UGC details with <a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetQueryUGCResult" class="bb_apilink">ISteamUGC::GetQueryUGCResult</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success, indicates that <code class="bb_code bb_code_inline nohighlight">pvecPublishedFileID</code> has been filled out.<br />
        /// Otherwise, <b>false</b> if the UGC query <code class="bb_code bb_code_inline nohighlight">handle</code> is invalid or the <code class="bb_code bb_code_inline nohighlight">index</code> is out of bounds.</summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCQueryHandle_t" class="bb_apilink">UGCQueryHandle_t</a>: The UGC query handle to get the results from.</param>
        /// <param name="index"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The index of the item to get the details of.</param>
        /// <param name="pvecPublishedFileID"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishedFileId_t" class="bb_apilink">PublishedFileId_t</a> *: Returns the UGC children by setting this array.</param>
        /// <param name="cMaxEntries"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The length of <code class="bb_code bb_code_inline nohighlight">pvecPublishedFileID</code>.</param>
        public static bool GetQueryUGCChildren(UGCQueryHandle handle, uint index, PublishedFileId* pvecPublishedFileID, uint cMaxEntries) => Instance.GetQueryUGCChildren(handle, index, pvecPublishedFileID, cMaxEntries);
        /// <summary><code>bool GetQueryUGCStatistic( UGCQueryHandle_t handle, uint32 index, EItemStatistic eStatType, uint64 *pStatValue );</code><br />
        /// Retrieve various statistics of an individual workshop item after receiving a querying UGC call result.<br />
        /// <br />
        /// You should call this in a loop to get the details of all the workshop items returned.<br />
        /// <br />
        /// <b>NOTE:</b> This must only be called with the handle obtained from a successful <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SteamUGCQueryCompleted_t" class="bb_apilink">SteamUGCQueryCompleted_t</a> call result.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success, indicates that <code class="bb_code bb_code_inline nohighlight">pStatValue</code> has been filled out.<br />
        /// Otherwise, <b>false</b> if the UGC query <code class="bb_code bb_code_inline nohighlight">handle</code> is invalid, the <code class="bb_code bb_code_inline nohighlight">index</code> is out of bounds, or <code class="bb_code bb_code_inline nohighlight">eStatType</code> was invalid.</summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCQueryHandle_t" class="bb_apilink">UGCQueryHandle_t</a>: The UGC query handle to get the results from.</param>
        /// <param name="index"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The index of the item to get the details of.</param>
        /// <param name="eStatType"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#EItemStatistic" class="bb_apilink">EItemStatistic</a>: The statistic to retrieve.</param>
        /// <param name="pStatValue"><a href="https://partner.steamgames.com/doc/api/steam_api#uint64" class="bb_apilink">uint64</a> *: Returns the value associated with the specified statistic.</param>
        public static bool GetQueryUGCStatistic(UGCQueryHandle handle, uint index, ItemStatistic eStatType, ulong* pStatValue) => Instance.GetQueryUGCStatistic(handle, index, eStatType, pStatValue);
        /// <summary><code>uint32 GetQueryUGCNumAdditionalPreviews( UGCQueryHandle_t handle, uint32 index );</code><br />
        /// Retrieve the number of additional previews of an individual workshop item after receiving a querying UGC call result.<br />
        /// <br />
        /// You should call this in a loop to get the details of all the workshop items returned.<br />
        /// <br />
        /// <b>NOTE:</b> This must only be called with the handle obtained from a successful <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SteamUGCQueryCompleted_t" class="bb_apilink">SteamUGCQueryCompleted_t</a> call result.<br />
        /// <br />
        /// You can then call <a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetQueryUGCAdditionalPreview" class="bb_apilink">ISteamUGC::GetQueryUGCAdditionalPreview</a> to get the details of each additional preview.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a><br />
        /// The number of additional previews associated with the specified workshop item.<br />
        /// Returns <b>0</b> if the UGC query <code class="bb_code bb_code_inline nohighlight">handle</code> is invalid or the <code class="bb_code bb_code_inline nohighlight">index</code> is out of bounds.</summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCQueryHandle_t" class="bb_apilink">UGCQueryHandle_t</a>: The UGC query handle to get the results from.</param>
        /// <param name="index"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The index of the item to get the details of.</param>
        public static uint GetQueryUGCNumAdditionalPreviews(UGCQueryHandle handle, uint index) => Instance.GetQueryUGCNumAdditionalPreviews(handle, index);
        /// <summary><code>bool GetQueryUGCAdditionalPreview( UGCQueryHandle_t handle, uint32 index, uint32 previewIndex, char *pchURLOrVideoID, uint32 cchURLSize, char *pchOriginalFileName, uint32 cchOriginalFileNameSize, EItemPreviewType *pPreviewType );</code><br />
        /// Retrieve the details of an additional preview associated with an individual workshop item after receiving a querying UGC call result.<br />
        /// <br />
        /// You should call this in a loop to get the details of all the workshop items returned.<br />
        /// <br />
        /// <b>NOTE:</b> This must only be called with the handle obtained from a successful <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SteamUGCQueryCompleted_t" class="bb_apilink">SteamUGCQueryCompleted_t</a> call result.<br />
        /// <br />
        /// Before calling this you should call <a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetQueryUGCNumAdditionalPreviews" class="bb_apilink">ISteamUGC::GetQueryUGCNumAdditionalPreviews</a> to get number of additional previews.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success, indicates that <code class="bb_code bb_code_inline nohighlight">pchURLOrVideoID</code> and <code class="bb_code bb_code_inline nohighlight">pPreviewType</code> have been filled out.<br />
        /// Otherwise, <b>false</b> if the UGC query <code class="bb_code bb_code_inline nohighlight">handle</code> is invalid, the <code class="bb_code bb_code_inline nohighlight">index</code> is out of bounds, or <code class="bb_code bb_code_inline nohighlight">previewIndex</code> is out of bounds.</summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCQueryHandle_t" class="bb_apilink">UGCQueryHandle_t</a>: The UGC query handle to get the results from.</param>
        /// <param name="index"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The index of the item to get the details of.</param>
        /// <param name="previewIndex"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The index of the additional preview to get the details of.</param>
        /// <param name="pchURLOrVideoID">char *: Returns a URL or Video ID by copying it into this string.</param>
        /// <param name="cchURLSize"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The size of <code class="bb_code bb_code_inline nohighlight">pchURLOrVideoID</code> in bytes.</param>
        /// <param name="pchOriginalFileName">char *: Returns the original file name. May be set to <b>NULL</b> to not receive this.</param>
        /// <param name="cchOriginalFileNameSize"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The size of <code class="bb_code bb_code_inline nohighlight">pchOriginalFileName</code> in bytes.</param>
        /// <param name="pPreviewType"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#EItemPreviewType" class="bb_apilink">EItemPreviewType</a> *: The type of preview that was returned.</param>
        public static bool GetQueryUGCAdditionalPreview(UGCQueryHandle handle, uint index, uint previewIndex, char* pchURLOrVideoID, uint cchURLSize, char* pchOriginalFileName, uint cchOriginalFileNameSize, ItemPreviewType* pPreviewType) => Instance.GetQueryUGCAdditionalPreview(handle, index, previewIndex, pchURLOrVideoID, cchURLSize, pchOriginalFileName, cchOriginalFileNameSize, pPreviewType);
        /// <summary><code>uint32 GetQueryUGCNumKeyValueTags( UGCQueryHandle_t handle, uint32 index );</code><br />
        /// Retrieve the number of key-value tags of an individual workshop item after receiving a querying UGC call result.<br />
        /// <br />
        /// You should call this in a loop to get the details of all the workshop items returned.<br />
        /// <br />
        /// <b>NOTE:</b> This must only be called with the handle obtained from a successful <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SteamUGCQueryCompleted_t" class="bb_apilink">SteamUGCQueryCompleted_t</a> call result.<br />
        /// <br />
        /// You can then call <a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetQueryUGCKeyValueTag" class="bb_apilink">ISteamUGC::GetQueryUGCKeyValueTag</a> to get the details of each tag.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a><br />
        /// The number of key-value tags associated with the specified workshop item.<br />
        /// Returns <b>0</b> if the UGC query <code class="bb_code bb_code_inline nohighlight">handle</code> is invalid or the <code class="bb_code bb_code_inline nohighlight">index</code> is out of bounds.</summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCQueryHandle_t" class="bb_apilink">UGCQueryHandle_t</a>: The UGC query handle to get the results from.</param>
        /// <param name="index"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The index of the item to get the details of.</param>
        public static uint GetQueryUGCNumKeyValueTags(UGCQueryHandle handle, uint index) => Instance.GetQueryUGCNumKeyValueTags(handle, index);
        /// <summary><code>bool GetQueryUGCKeyValueTag( UGCQueryHandle_t handle, uint32 index, uint32 keyValueTagIndex, char *pchKey, uint32 cchKeySize, char *pchValue, uint32 cchValueSize );</code><br />
        /// Retrieve the details of a key-value tag associated with an individual workshop item after receiving a querying UGC call result.<br />
        /// <br />
        /// You should call this in a loop to get the details of all the workshop items returned.<br />
        /// <br />
        /// <b>NOTE:</b> This must only be called with the handle obtained from a successful <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SteamUGCQueryCompleted_t" class="bb_apilink">SteamUGCQueryCompleted_t</a> call result.<br />
        /// <br />
        /// Before calling this you should call <a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetQueryUGCNumKeyValueTags" class="bb_apilink">ISteamUGC::GetQueryUGCNumKeyValueTags</a> to get number of tags.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success, indicates that <code class="bb_code bb_code_inline nohighlight">pchKey</code> and <code class="bb_code bb_code_inline nohighlight">pchValue</code> have been filled out.<br />
        /// Otherwise, <b>false</b> if the UGC query <code class="bb_code bb_code_inline nohighlight">handle</code> is invalid, the <code class="bb_code bb_code_inline nohighlight">index</code> is out of bounds, or <code class="bb_code bb_code_inline nohighlight">keyValueTagIndex</code> is out of bounds.</summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCQueryHandle_t" class="bb_apilink">UGCQueryHandle_t</a>: The UGC query handle to get the results from.</param>
        /// <param name="index"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The index of the item to get the details of.</param>
        /// <param name="keyValueTagIndex"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The index of the tag to get the details of.</param>
        /// <param name="pchKey">char *: Returns the key by copying it into this string.</param>
        /// <param name="cchKeySize"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The size of <code class="bb_code bb_code_inline nohighlight">pchKey</code> in bytes.</param>
        /// <param name="pchValue">char *: Returns the value by copying it into this string.</param>
        /// <param name="cchValueSize"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The size of <code class="bb_code bb_code_inline nohighlight">pchValue</code> in bytes.</param>
        public static bool GetQueryUGCKeyValueTag(UGCQueryHandle handle, uint index, uint keyValueTagIndex, char* pchKey, uint cchKeySize, char* pchValue, uint cchValueSize) => Instance.GetQueryUGCKeyValueTag(handle, index, keyValueTagIndex, pchKey, cchKeySize, pchValue, cchValueSize);
        /// <summary><code>bool GetQueryUGCKeyValueTag( UGCQueryHandle_t handle, uint32 index, uint32 keyValueTagIndex, char *pchKey, uint32 cchKeySize, char *pchValue, uint32 cchValueSize );</code><br />
        /// Retrieve the details of a key-value tag associated with an individual workshop item after receiving a querying UGC call result.<br />
        /// <br />
        /// You should call this in a loop to get the details of all the workshop items returned.<br />
        /// <br />
        /// <b>NOTE:</b> This must only be called with the handle obtained from a successful <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SteamUGCQueryCompleted_t" class="bb_apilink">SteamUGCQueryCompleted_t</a> call result.<br />
        /// <br />
        /// Before calling this you should call <a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetQueryUGCNumKeyValueTags" class="bb_apilink">ISteamUGC::GetQueryUGCNumKeyValueTags</a> to get number of tags.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success, indicates that <code class="bb_code bb_code_inline nohighlight">pchKey</code> and <code class="bb_code bb_code_inline nohighlight">pchValue</code> have been filled out.<br />
        /// Otherwise, <b>false</b> if the UGC query <code class="bb_code bb_code_inline nohighlight">handle</code> is invalid, the <code class="bb_code bb_code_inline nohighlight">index</code> is out of bounds, or <code class="bb_code bb_code_inline nohighlight">keyValueTagIndex</code> is out of bounds.</summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCQueryHandle_t" class="bb_apilink">UGCQueryHandle_t</a>: The UGC query handle to get the results from.</param>
        /// <param name="index"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The index of the item to get the details of.</param>
        /// <param name="keyValueTagIndex"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The index of the tag to get the details of.</param>
        /// <param name="pchKey">char *: Returns the key by copying it into this string.</param>
        /// <param name="cchKeySize"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The size of <code class="bb_code bb_code_inline nohighlight">pchKey</code> in bytes.</param>
        /// <param name="pchValue">char *: Returns the value by copying it into this string.</param>
        /// <param name="cchValueSize"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The size of <code class="bb_code bb_code_inline nohighlight">pchValue</code> in bytes.</param>
        public static bool GetQueryUGCKeyValueTag(UGCQueryHandle handle, uint index, UTF8StringPtr pchKey, char* pchValue, uint cchValueSize) => Instance.GetQueryUGCKeyValueTag(handle, index, pchKey, pchValue, cchValueSize);
        /// <summary><code>uint32 GetQueryUGCContentDescriptors( UGCQueryHandle_t handle, uint32 index, EUGCContentDescriptorID *pvecDescriptors, uint32 cMaxEntries );</code><br />
        /// Retrieve an array of <a href="https://partner.steamgames.com/doc/api/ISteamUGC#EUGCContentDescriptorID" class="bb_apilink">EUGCContentDescriptorID</a> set on the item.  <br />
        /// <br />
        /// <b>NOTE:</b> This must only be called with the handle obtained from a successful <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SteamUGCQueryCompleted_t" class="bb_apilink">SteamUGCQueryCompleted_t</a> call result.<br />
        /// <br />
        /// <b>Returns:</b> uint32<br />
        /// Returns the number of <a href="https://partner.steamgames.com/doc/api/ISteamUGC#EUGCContentDescriptorID" class="bb_apilink">EUGCContentDescriptorID</a> set on the item.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#AddContentDescriptor" class="bb_apilink">ISteamUGC::AddContentDescriptor</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#RemoveContentDescriptor" class="bb_apilink">ISteamUGC::RemoveContentDescriptor</a></summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCQueryHandle_t" class="bb_apilink">UGCQueryHandle_t</a>: The UGC query handle to get the results from.</param>
        /// <param name="index"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The index of the item to get the details of.</param>
        /// <param name="pvecDescriptors"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#EUGCContentDescriptorID" class="bb_apilink">EUGCContentDescriptorID</a>: An array of EUGCContentDescriptorID to fill in.</param>
        /// <param name="cMaxEntries"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: Size of the pvecDescriptors array</param>
        public static uint GetQueryUGCContentDescriptors(UGCQueryHandle handle, uint index, UGCContentDescriptorID* pvecDescriptors, uint cMaxEntries) => Instance.GetQueryUGCContentDescriptors(handle, index, pvecDescriptors, cMaxEntries);
        /// <summary><code>bool ReleaseQueryUGCRequest( UGCQueryHandle_t handle );</code><br />
        /// Releases a UGC query handle when you are done with it to free up memory.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// Always returns <b>true</b>.</summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCQueryHandle_t" class="bb_apilink">UGCQueryHandle_t</a>: The UGC query handle to release.</param>
        public static bool ReleaseQueryUGCRequest(UGCQueryHandle handle) => Instance.ReleaseQueryUGCRequest(handle);
        /// <summary><code>bool AddRequiredTag( UGCQueryHandle_t handle, const char *pTagName );</code><br />
        /// Adds a required tag to a pending UGC Query. This will only return UGC with the specified tag.<br />
        /// <br />
        /// <b>NOTE:</b> This must be set before you send a UGC Query handle using <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SendQueryUGCRequest" class="bb_apilink">ISteamUGC::SendQueryUGCRequest</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success.<br />
        /// <b>false</b> if the UGC query <code class="bb_code bb_code_inline nohighlight">handle</code> is invalid, if the UGC query handle is from <a href="https://partner.steamgames.com/doc/api/ISteamUGC#CreateQueryUGCDetailsRequest" class="bb_apilink">ISteamUGC::CreateQueryUGCDetailsRequest</a>, or <code class="bb_code bb_code_inline nohighlight">pTagName</code> was <b>NULL</b>.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#AddExcludedTag" class="bb_apilink">ISteamUGC::AddExcludedTag</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetMatchAnyTag" class="bb_apilink">ISteamUGC::SetMatchAnyTag</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetItemTags" class="bb_apilink">ISteamUGC::SetItemTags</a></summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCQueryHandle_t" class="bb_apilink">UGCQueryHandle_t</a>: The UGC query handle to customize.</param>
        /// <param name="pTagName">const char *: The tag must be attached to the UGC to receive it.</param>
        public static bool AddRequiredTag(UGCQueryHandle handle, UTF8StringPtr pTagName) => Instance.AddRequiredTag(handle, pTagName);
        /// <summary><code>bool AddRequiredTagGroup( UGCQueryHandle_t handle, const SteamParamStringArray_t *pTags );</code><br />
        /// Adds the requirement that the returned items from the pending UGC Query have at least one of the tags in the given set (logical "or").  For each tag group that is added, at least one tag from each group is required to be on the matching items.<br />
        /// <br />
        /// <b>NOTE:</b> This must be set before you send a UGC Query handle using <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SendQueryUGCRequest" class="bb_apilink">ISteamUGC::SendQueryUGCRequest</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success.<br />
        /// <b>false</b> if the UGC query <code class="bb_code bb_code_inline nohighlight">handle</code> is invalid, if the UGC query handle is from <a href="https://partner.steamgames.com/doc/api/ISteamUGC#CreateQueryUGCDetailsRequest" class="bb_apilink">ISteamUGC::CreateQueryUGCDetailsRequest</a>, or <code class="bb_code bb_code_inline nohighlight">pTagName</code> was <b>NULL</b>.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#AddRequiredTag" class="bb_apilink">ISteamUGC::AddRequiredTag</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#AddExcludedTag" class="bb_apilink">ISteamUGC::AddExcludedTag</a></summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCQueryHandle_t" class="bb_apilink">UGCQueryHandle_t</a>: The UGC query handle to customize.</param>
        /// <param name="pTags">const <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#SteamParamStringArray_t" class="bb_apilink">SteamParamStringArray_t</a> *: A set of tags where at least one of the tags must attach to the UGC.</param>
        public static bool AddRequiredTagGroup(UGCQueryHandle handle, SteamParamStringArray* pTagGroups) => Instance.AddRequiredTagGroup(handle, pTagGroups);
        /// <summary><code>bool AddExcludedTag( UGCQueryHandle_t handle, const char *pTagName );</code><br />
        /// Adds a excluded tag to a pending UGC Query. This will only return UGC without the specified tag.<br />
        /// <br />
        /// <b>NOTE:</b> This must be set before you send a UGC Query handle using <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SendQueryUGCRequest" class="bb_apilink">ISteamUGC::SendQueryUGCRequest</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success.<br />
        /// <b>false</b> if the UGC query <code class="bb_code bb_code_inline nohighlight">handle</code> is invalid, if the UGC query handle is from <a href="https://partner.steamgames.com/doc/api/ISteamUGC#CreateQueryUGCDetailsRequest" class="bb_apilink">ISteamUGC::CreateQueryUGCDetailsRequest</a>, or <code class="bb_code bb_code_inline nohighlight">pTagName</code> was <b>NULL</b>.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#AddRequiredTag" class="bb_apilink">ISteamUGC::AddRequiredTag</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetMatchAnyTag" class="bb_apilink">ISteamUGC::SetMatchAnyTag</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetItemTags" class="bb_apilink">ISteamUGC::SetItemTags</a></summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCQueryHandle_t" class="bb_apilink">UGCQueryHandle_t</a>: The UGC query handle to customize.</param>
        /// <param name="pTagName">const char *: The tag must NOT be attached to the UGC to receive it.</param>
        public static bool AddExcludedTag(UGCQueryHandle handle, UTF8StringPtr pTagName) => Instance.AddExcludedTag(handle, pTagName);
        /// <summary><code>bool SetReturnOnlyIDs( UGCQueryHandle_t handle, bool bReturnOnlyIDs );</code><br />
        /// Sets whether to only return IDs instead of all the details on a pending UGC Query.<br />
        /// <br />
        /// This is useful for when you don't need all the information (e.g. you just want to get the IDs of the items a user has in their favorites list.)<br />
        /// <br />
        /// <b>NOTE:</b> This must be set before you send a UGC Query handle using <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SendQueryUGCRequest" class="bb_apilink">ISteamUGC::SendQueryUGCRequest</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success.<br />
        /// <b>false</b> if the UGC query <code class="bb_code bb_code_inline nohighlight">handle</code> is invalid or if the UGC query handle is from <a href="https://partner.steamgames.com/doc/api/ISteamUGC#CreateQueryUGCDetailsRequest" class="bb_apilink">ISteamUGC::CreateQueryUGCDetailsRequest</a>.</summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCQueryHandle_t" class="bb_apilink">UGCQueryHandle_t</a>: The UGC query handle to customize.</param>
        /// <param name="bReturnOnlyIDs">bool: Return only the IDs of items?</param>
        public static bool SetReturnOnlyIDs(UGCQueryHandle handle, bool bReturnOnlyIDs) => Instance.SetReturnOnlyIDs(handle, bReturnOnlyIDs);
        /// <summary><code>bool SetReturnKeyValueTags( UGCQueryHandle_t handle, bool bReturnKeyValueTags );</code><br />
        /// Sets whether to return any key-value tags for the items on a pending UGC Query.<br />
        /// <br />
        /// <b>NOTE:</b> This must be set before you send a UGC Query handle using <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SendQueryUGCRequest" class="bb_apilink">ISteamUGC::SendQueryUGCRequest</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success.<br />
        /// <b>false</b> if the UGC query <code class="bb_code bb_code_inline nohighlight">handle</code> is invalid.</summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCQueryHandle_t" class="bb_apilink">UGCQueryHandle_t</a>: The UGC query handle to customize.</param>
        /// <param name="bReturnKeyValueTags">bool: Return any key-value tags for the items?</param>
        public static bool SetReturnKeyValueTags(UGCQueryHandle handle, bool bReturnKeyValueTags) => Instance.SetReturnKeyValueTags(handle, bReturnKeyValueTags);
        /// <summary><code>bool SetReturnLongDescription( UGCQueryHandle_t handle, bool bReturnLongDescription );</code><br />
        /// Sets whether to return the full description for the items on a pending UGC Query.<br />
        /// <br />
        /// If you don't set this then you only receive the summary which is the description truncated at 255 bytes.<br />
        /// <br />
        /// <b>NOTE:</b> This must be set before you send a UGC Query handle using <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SendQueryUGCRequest" class="bb_apilink">ISteamUGC::SendQueryUGCRequest</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success.<br />
        /// <b>false</b> if the UGC query <code class="bb_code bb_code_inline nohighlight">handle</code> is invalid.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetItemDescription" class="bb_apilink">ISteamUGC::SetItemDescription</a></summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCQueryHandle_t" class="bb_apilink">UGCQueryHandle_t</a>: The UGC query handle to customize.</param>
        /// <param name="bReturnLongDescription">bool: Return the long description for the items?</param>
        public static bool SetReturnLongDescription(UGCQueryHandle handle, bool bReturnLongDescription) => Instance.SetReturnLongDescription(handle, bReturnLongDescription);
        /// <summary><code>bool SetReturnMetadata( UGCQueryHandle_t handle, bool bReturnMetadata );</code><br />
        /// Sets whether to return the developer-specified metadata for the items on a pending UGC Query.<br />
        /// <br />
        /// <b>NOTE:</b> This must be set before you send a UGC Query handle using <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SendQueryUGCRequest" class="bb_apilink">ISteamUGC::SendQueryUGCRequest</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success.<br />
        /// <b>false</b> if the UGC query <code class="bb_code bb_code_inline nohighlight">handle</code> is invalid.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetItemMetadata" class="bb_apilink">ISteamUGC::SetItemMetadata</a></summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCQueryHandle_t" class="bb_apilink">UGCQueryHandle_t</a>: The UGC query handle to customize.</param>
        /// <param name="bReturnMetadata">bool: Return the metadata for the items?</param>
        public static bool SetReturnMetadata(UGCQueryHandle handle, bool bReturnMetadata) => Instance.SetReturnMetadata(handle, bReturnMetadata);
        /// <summary><code>bool SetReturnChildren( UGCQueryHandle_t handle, bool bReturnChildren );</code><br />
        /// Sets whether to return the IDs of the child items of the item on a pending UGC Query.<br />
        /// <br />
        /// <b>NOTE:</b> This must be set before you send a UGC Query handle using <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SendQueryUGCRequest" class="bb_apilink">ISteamUGC::SendQueryUGCRequest</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success.<br />
        /// <b>false</b> if the UGC query <code class="bb_code bb_code_inline nohighlight">handle</code> is invalid.</summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCQueryHandle_t" class="bb_apilink">UGCQueryHandle_t</a>: The UGC query handle to customize.</param>
        /// <param name="bReturnChildren">bool: Return the IDs of children of the items?</param>
        public static bool SetReturnChildren(UGCQueryHandle handle, bool bReturnChildren) => Instance.SetReturnChildren(handle, bReturnChildren);
        /// <summary><code>bool SetReturnAdditionalPreviews( UGCQueryHandle_t handle, bool bReturnAdditionalPreviews );</code><br />
        /// Sets whether to return any additional images/videos attached to the items on a pending UGC Query.<br />
        /// <br />
        /// <b>NOTE:</b> This must be set before you send a UGC Query handle using <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SendQueryUGCRequest" class="bb_apilink">ISteamUGC::SendQueryUGCRequest</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success.<br />
        /// <b>false</b> if the UGC query <code class="bb_code bb_code_inline nohighlight">handle</code> is invalid.</summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCQueryHandle_t" class="bb_apilink">UGCQueryHandle_t</a>: The UGC query handle to customize.</param>
        /// <param name="bReturnAdditionalPreviews">bool: Return the additional previews for the items?</param>
        public static bool SetReturnAdditionalPreviews(UGCQueryHandle handle, bool bReturnAdditionalPreviews) => Instance.SetReturnAdditionalPreviews(handle, bReturnAdditionalPreviews);
        /// <summary><code>bool SetReturnTotalOnly( UGCQueryHandle_t handle, bool bReturnTotalOnly );</code><br />
        /// Sets whether to only return the total number of matching items on a pending UGC Query.<br />
        /// <br />
        /// The actual items will not be returned when <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SteamUGCQueryCompleted_t" class="bb_apilink">SteamUGCQueryCompleted_t</a> is called.<br />
        /// <br />
        /// <b>NOTE:</b> This must be set before you send a UGC Query handle using <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SendQueryUGCRequest" class="bb_apilink">ISteamUGC::SendQueryUGCRequest</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success.<br />
        /// <b>false</b> if the UGC query <code class="bb_code bb_code_inline nohighlight">handle</code> is invalid or if the UGC query handle is from <a href="https://partner.steamgames.com/doc/api/ISteamUGC#CreateQueryUGCDetailsRequest" class="bb_apilink">ISteamUGC::CreateQueryUGCDetailsRequest</a></summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCQueryHandle_t" class="bb_apilink">UGCQueryHandle_t</a>: The UGC query handle to customize.</param>
        /// <param name="bReturnTotalOnly">bool: Only return the total number of items?</param>
        public static bool SetReturnTotalOnly(UGCQueryHandle handle, bool bReturnTotalOnly) => Instance.SetReturnTotalOnly(handle, bReturnTotalOnly);
        /// <summary><code>bool SetReturnPlaytimeStats( UGCQueryHandle_t handle, uint32 unDays );</code><br />
        /// Sets whether to return the playtime stats on a pending UGC Query.<br />
        /// <br />
        /// <b>NOTE:</b> This must be set before you send a UGC Query handle using <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SendQueryUGCRequest" class="bb_apilink">ISteamUGC::SendQueryUGCRequest</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success.<br />
        /// <b>false</b> if the UGC query <code class="bb_code bb_code_inline nohighlight">handle</code> is invalid.</summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCQueryHandle_t" class="bb_apilink">UGCQueryHandle_t</a>: The UGC query handle to customize.</param>
        /// <param name="unDays"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The number of days worth of playtime stats to return.</param>
        public static bool SetReturnPlaytimeStats(UGCQueryHandle handle, uint unDays) => Instance.SetReturnPlaytimeStats(handle, unDays);
        /// <summary><code>bool SetLanguage( UGCQueryHandle_t handle, const char *pchLanguage );</code><br />
        /// Sets the language to return the title and description in for the items on a pending UGC Query.<br />
        /// <br />
        /// This must be in the format of the <a href="https://partner.steamgames.com/doc/store/localization#supported_languages" class="bb_doclink">API Language code</a>.<br />
        /// <br />
        /// If this is not set then "english" is assumed.<br />
        /// <br />
        /// <b>NOTE:</b> This must be set before you send a UGC Query handle using <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SendQueryUGCRequest" class="bb_apilink">ISteamUGC::SendQueryUGCRequest</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success.<br />
        /// <b>false</b> if the UGC query <code class="bb_code bb_code_inline nohighlight">handle</code> is invalid.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetItemUpdateLanguage" class="bb_apilink">ISteamUGC::SetItemUpdateLanguage</a></summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCQueryHandle_t" class="bb_apilink">UGCQueryHandle_t</a>: The UGC query handle to customize.</param>
        /// <param name="pchLanguage">const char *: The language to return.</param>
        public static bool SetLanguage(UGCQueryHandle handle, UTF8StringPtr pchLanguage) => Instance.SetLanguage(handle, pchLanguage);
        /// <summary><code>bool SetAllowCachedResponse( UGCQueryHandle_t handle, uint32 unMaxAgeSeconds );</code><br />
        /// Sets whether results will be returned from the cache for the specific period of time on a pending UGC Query.<br />
        /// <br />
        /// <b>NOTE:</b> This must be set before you send a UGC Query handle using <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SendQueryUGCRequest" class="bb_apilink">ISteamUGC::SendQueryUGCRequest</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success.<br />
        /// <b>false</b> if the UGC query <code class="bb_code bb_code_inline nohighlight">handle</code> is invalid.</summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCQueryHandle_t" class="bb_apilink">UGCQueryHandle_t</a>: The UGC query handle to customize.</param>
        /// <param name="unMaxAgeSeconds"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The maximum amount of time that an item can be returned without a cache invalidation.</param>
        public static bool SetAllowCachedResponse(UGCQueryHandle handle, uint unMaxAgeSeconds) => Instance.SetAllowCachedResponse(handle, unMaxAgeSeconds);
        /// <summary><code>bool SetCloudFileNameFilter( UGCQueryHandle_t handle, const char *pMatchCloudFileName );</code><br />
        /// Sets to only return items that have a specific filename on a pending UGC Query.<br />
        /// <br />
        /// <b>NOTE:</b> This can only be used with <a href="https://partner.steamgames.com/doc/api/ISteamUGC#CreateQueryUserUGCRequest" class="bb_apilink">ISteamUGC::CreateQueryUserUGCRequest</a>!<br />
        /// <br />
        /// <b>NOTE:</b> This must be set before you send a UGC Query handle using <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SendQueryUGCRequest" class="bb_apilink">ISteamUGC::SendQueryUGCRequest</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success.<br />
        /// <b>false</b> if the UGC query <code class="bb_code bb_code_inline nohighlight">handle</code> is invalid, if the UGC query handle is not from <a href="https://partner.steamgames.com/doc/api/ISteamUGC#CreateQueryUserUGCRequest" class="bb_apilink">ISteamUGC::CreateQueryUserUGCRequest</a> or if <code class="bb_code bb_code_inline nohighlight">pMatchCloudFileName</code> is <b>NULL</b>.</summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCQueryHandle_t" class="bb_apilink">UGCQueryHandle_t</a>: The UGC query handle to customize.</param>
        /// <param name="pMatchCloudFileName">const char *: The filename to match.</param>
        public static bool SetCloudFileNameFilter(UGCQueryHandle handle, UTF8StringPtr pMatchCloudFileName) => Instance.SetCloudFileNameFilter(handle, pMatchCloudFileName);
        /// <summary><code>bool SetMatchAnyTag( UGCQueryHandle_t handle, bool bMatchAnyTag );</code><br />
        /// Sets whether workshop items will be returned if they have one or more matching tags, or if all tags need to match on a pending UGC Query.<br />
        /// <br />
        /// <b>NOTE:</b> This can only be used with <a href="https://partner.steamgames.com/doc/api/ISteamUGC#CreateQueryAllUGCRequest" class="bb_apilink">ISteamUGC::CreateQueryAllUGCRequest</a>!<br />
        /// <br />
        /// <b>NOTE:</b> This must be set before you send a UGC Query handle using <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SendQueryUGCRequest" class="bb_apilink">ISteamUGC::SendQueryUGCRequest</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success.<br />
        /// <b>false</b> if the UGC query <code class="bb_code bb_code_inline nohighlight">handle</code> is invalid or if the UGC query handle is not from <a href="https://partner.steamgames.com/doc/api/ISteamUGC#CreateQueryAllUGCRequest" class="bb_apilink">ISteamUGC::CreateQueryAllUGCRequest</a>.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#AddRequiredTag" class="bb_apilink">ISteamUGC::AddRequiredTag</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#AddExcludedTag" class="bb_apilink">ISteamUGC::AddExcludedTag</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetItemTags" class="bb_apilink">ISteamUGC::SetItemTags</a></summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCQueryHandle_t" class="bb_apilink">UGCQueryHandle_t</a>: The UGC query handle to customize.</param>
        /// <param name="bMatchAnyTag">bool: Should the item just need to have one required tag (<b>true</b>), or all of them? (<b>false</b>)</param>
        public static bool SetMatchAnyTag(UGCQueryHandle handle, bool bMatchAnyTag) => Instance.SetMatchAnyTag(handle, bMatchAnyTag);
        /// <summary><code>bool SetSearchText( UGCQueryHandle_t handle, const char *pSearchText );</code><br />
        /// Sets a string to that items need to match in either the title or the description on a pending UGC Query.<br />
        /// <br />
        /// <b>NOTE:</b> This can only be used with <a href="https://partner.steamgames.com/doc/api/ISteamUGC#CreateQueryAllUGCRequest" class="bb_apilink">ISteamUGC::CreateQueryAllUGCRequest</a>!<br />
        /// <br />
        /// <b>NOTE:</b> This must be set before you send a UGC Query handle using <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SendQueryUGCRequest" class="bb_apilink">ISteamUGC::SendQueryUGCRequest</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success.<br />
        /// <b>false</b> if the UGC query <code class="bb_code bb_code_inline nohighlight">handle</code> is invalid, if the UGC query handle is not from <a href="https://partner.steamgames.com/doc/api/ISteamUGC#CreateQueryAllUGCRequest" class="bb_apilink">ISteamUGC::CreateQueryAllUGCRequest</a> or if <code class="bb_code bb_code_inline nohighlight">pSearchText</code> is <b>NULL</b>.</summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCQueryHandle_t" class="bb_apilink">UGCQueryHandle_t</a>: The UGC query handle to customize.</param>
        /// <param name="pSearchText">const char *: The text to be searched for.</param>
        public static bool SetSearchText(UGCQueryHandle handle, UTF8StringPtr pSearchText) => Instance.SetSearchText(handle, pSearchText);
        /// <summary><code>bool SetRankedByTrendDays( UGCQueryHandle_t handle, uint32 unDays );</code><br />
        /// Sets whether the order of the results will be updated based on the rank of items over a number of days on a pending UGC Query.<br />
        /// <br />
        /// <b>NOTE:</b> This can only be used with <a href="https://partner.steamgames.com/doc/api/ISteamUGC#CreateQueryAllUGCRequest" class="bb_apilink">ISteamUGC::CreateQueryAllUGCRequest</a>!<br />
        /// <br />
        /// <b>NOTE:</b> This must be set before you send a UGC Query handle using <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SendQueryUGCRequest" class="bb_apilink">ISteamUGC::SendQueryUGCRequest</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success.<br />
        /// <b>false</b> if the UGC query <code class="bb_code bb_code_inline nohighlight">handle</code> is invalid, if the UGC query handle is not from <a href="https://partner.steamgames.com/doc/api/ISteamUGC#CreateQueryAllUGCRequest" class="bb_apilink">ISteamUGC::CreateQueryAllUGCRequest</a> or if the <a href="https://partner.steamgames.com/doc/api/ISteamUGC#EUGCQuery" class="bb_apilink">EUGCQuery</a> of the query is not one of:<br />
        /// <code class="bb_code bb_code_inline nohighlight">k_PublishedFileQueryType_RankedByTrend</code>, <code class="bb_code bb_code_inline nohighlight">k_PublishedFileQueryType_RankedByPlaytimeTrend</code>, <code class="bb_code bb_code_inline nohighlight">k_PublishedFileQueryType_RankedByAveragePlaytimeTrend</code>, <code class="bb_code bb_code_inline nohighlight">k_PublishedFileQueryType_RankedByVotesUp</code>, or <code class="bb_code bb_code_inline nohighlight">k_PublishedFileQueryType_RankedByPlaytimeSessionsTrend</code></summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCQueryHandle_t" class="bb_apilink">UGCQueryHandle_t</a>: The UGC query handle to customize.</param>
        /// <param name="unDays"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: Sets the number of days to rank items over.  Valid values are 1-365 inclusive.</param>
        public static bool SetRankedByTrendDays(UGCQueryHandle handle, uint unDays) => Instance.SetRankedByTrendDays(handle, unDays);
        /// missing documentation
        public static bool SetTimeCreatedDateRange(UGCQueryHandle handle, RTime32 rtStart, RTime32 rtEnd) => Instance.SetTimeCreatedDateRange(handle, rtStart, rtEnd);
        /// missing documentation
        public static bool SetTimeUpdatedDateRange(UGCQueryHandle handle, RTime32 rtStart, RTime32 rtEnd) => Instance.SetTimeUpdatedDateRange(handle, rtStart, rtEnd);
        /// <summary><code>bool AddRequiredKeyValueTag( UGCQueryHandle_t handle, const char *pKey, const char *pValue );</code><br />
        /// Adds a required key-value tag to a pending UGC Query. This will only return workshop items that have a key = <code class="bb_code bb_code_inline nohighlight">pKey</code> and a value = <code class="bb_code bb_code_inline nohighlight">pValue</code>.<br />
        /// <br />
        /// <b>NOTE:</b> This must be set before you send a UGC Query handle using <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SendQueryUGCRequest" class="bb_apilink">ISteamUGC::SendQueryUGCRequest</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success.<br />
        /// <b>false</b> if the UGC query <code class="bb_code bb_code_inline nohighlight">handle</code> is invalid or if <code class="bb_code bb_code_inline nohighlight">pKey</code> or <code class="bb_code bb_code_inline nohighlight">pValue</code> are <b>NULL</b>.</summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCQueryHandle_t" class="bb_apilink">UGCQueryHandle_t</a>: The UGC query handle to customize.</param>
        /// <param name="pKey">const char *: The key-value key that must be attached to the UGC to receive it.</param>
        /// <param name="pValue">const char *: The key-value value associated with <code class="bb_code bb_code_inline nohighlight">pKey</code> that must be attached to the UGC to receive it.</param>
        public static bool AddRequiredKeyValueTag(UGCQueryHandle handle, UTF8StringPtr pKey, UTF8StringPtr pValue) => Instance.AddRequiredKeyValueTag(handle, pKey, pValue);
        /// <summary><code>SteamAPICall_t RequestUGCDetails( PublishedFileId_t nPublishedFileID, uint32 unMaxAgeSeconds );</code><br />
        /// <b>DEPRECATED</b>! Use <a href="https://partner.steamgames.com/doc/api/ISteamUGC#CreateQueryUGCDetailsRequest" class="bb_apilink">ISteamUGC::CreateQueryUGCDetailsRequest</a> instead!<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SteamUGCRequestUGCDetailsResult_t" class="bb_apilink">SteamUGCRequestUGCDetailsResult_t</a> call result.</summary>
        /// <param name="nPublishedFileID"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishedFileId_t" class="bb_apilink">PublishedFileId_t</a>: Deprecated!</param>
        /// <param name="unMaxAgeSeconds"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: Deprecated!</param>
        public static SteamAPICall RequestUGCDetails(PublishedFileId nPublishedFileID, uint unMaxAgeSeconds) => Instance.RequestUGCDetails(nPublishedFileID, unMaxAgeSeconds);
        /// <summary><code>SteamAPICall_t CreateItem( AppId_t nConsumerAppId, EWorkshopFileType eFileType );</code><br />
        /// Creates a new workshop item with no content attached yet.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamUGC#CreateItemResult_t" class="bb_apilink">CreateItemResult_t</a> call result.<br />
        /// <br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/features/workshop/implementation#creating_a_workshop_item" class="bb_doclink">Creating a Workshop Item</a></summary>
        /// <param name="nConsumerAppId"><a href="https://partner.steamgames.com/doc/api/steam_api#AppId_t" class="bb_apilink">AppId_t</a>: The App ID that will be using this item.</param>
        /// <param name="eFileType"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#EWorkshopFileType" class="bb_apilink">EWorkshopFileType</a>: The type of UGC to create.</param>
        public static SteamAPICall CreateItem(AppId nConsumerAppId, WorkshopFileType eFileType) => Instance.CreateItem(nConsumerAppId, eFileType);
        /// <summary><code>UGCUpdateHandle_t StartItemUpdate( AppId_t nConsumerAppId, PublishedFileId_t nPublishedFileID );</code><br />
        /// Starts the item update process.<br />
        /// <br />
        /// This gets you a handle that you can use to modify the item before finally sending off the update to the server with <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SubmitItemUpdate" class="bb_apilink">ISteamUGC::SubmitItemUpdate</a>.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCUpdateHandle_t" class="bb_apilink">UGCUpdateHandle_t</a><br />
        /// A handle that you can use with future calls to modify the item before finally sending the update.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/features/workshop/implementation#uploading_a_workshop_item" class="bb_doclink">Uploading a Workshop Item</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetItemTitle" class="bb_apilink">ISteamUGC::SetItemTitle</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetItemDescription" class="bb_apilink">ISteamUGC::SetItemDescription</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetItemUpdateLanguage" class="bb_apilink">ISteamUGC::SetItemUpdateLanguage</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetItemMetadata" class="bb_apilink">ISteamUGC::SetItemMetadata</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetItemVisibility" class="bb_apilink">ISteamUGC::SetItemVisibility</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetItemTags" class="bb_apilink">ISteamUGC::SetItemTags</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetItemContent" class="bb_apilink">ISteamUGC::SetItemContent</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetItemPreview" class="bb_apilink">ISteamUGC::SetItemPreview</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#RemoveItemKeyValueTags" class="bb_apilink">ISteamUGC::RemoveItemKeyValueTags</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#AddItemKeyValueTag" class="bb_apilink">ISteamUGC::AddItemKeyValueTag</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#AddItemPreviewFile" class="bb_apilink">ISteamUGC::AddItemPreviewFile</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#AddItemPreviewVideo" class="bb_apilink">ISteamUGC::AddItemPreviewVideo</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#UpdateItemPreviewFile" class="bb_apilink">ISteamUGC::UpdateItemPreviewFile</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#UpdateItemPreviewVideo" class="bb_apilink">ISteamUGC::UpdateItemPreviewVideo</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#RemoveItemPreview" class="bb_apilink">ISteamUGC::RemoveItemPreview</a></summary>
        /// <param name="nConsumerAppId"><a href="https://partner.steamgames.com/doc/api/steam_api#AppId_t" class="bb_apilink">AppId_t</a>: The App ID that will be using this item.</param>
        /// <param name="nPublishedFileID"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishedFileId_t" class="bb_apilink">PublishedFileId_t</a>: The item to update.</param>
        public static UGCUpdateHandle StartItemUpdate(AppId nConsumerAppId, PublishedFileId nPublishedFileID) => Instance.StartItemUpdate(nConsumerAppId, nPublishedFileID);
        /// <summary><code>bool SetItemTitle( UGCUpdateHandle_t handle, const char *pchTitle );</code><br />
        /// Sets a new title for an item.<br />
        /// <br />
        /// The title must be limited to the size defined by <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#k_cchPublishedDocumentTitleMax" class="bb_apilink">k_cchPublishedDocumentTitleMax</a>.<br />
        /// <br />
        /// You can set what language this is for by using <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetItemUpdateLanguage" class="bb_apilink">ISteamUGC::SetItemUpdateLanguage</a>, if no language is set then "english" is assumed.<br />
        /// <br />
        /// <b>NOTE:</b> This must be set before you submit the UGC update handle using <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SubmitItemUpdate" class="bb_apilink">ISteamUGC::SubmitItemUpdate</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success.<br />
        /// <b>false</b> if the UGC update <code class="bb_code bb_code_inline nohighlight">handle</code> is invalid.</summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCUpdateHandle_t" class="bb_apilink">UGCUpdateHandle_t</a>: The workshop item update handle to customize.</param>
        /// <param name="pchTitle">const char *: The new title of the item.</param>
        public static bool SetItemTitle(UGCUpdateHandle handle, UTF8StringPtr pchTitle) => Instance.SetItemTitle(handle, pchTitle);
        /// <summary><code>bool SetItemDescription( UGCUpdateHandle_t handle, const char *pchDescription );</code><br />
        /// Sets a new description for an item.<br />
        /// <br />
        /// The description must be limited to the length defined by <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#k_cchPublishedDocumentDescriptionMax" class="bb_apilink">k_cchPublishedDocumentDescriptionMax</a>.<br />
        /// <br />
        /// You can set what language this is for by using <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetItemUpdateLanguage" class="bb_apilink">ISteamUGC::SetItemUpdateLanguage</a>, if no language is set then "english" is assumed.<br />
        /// <br />
        /// <b>NOTE:</b> This must be set before you submit the UGC update handle using <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SubmitItemUpdate" class="bb_apilink">ISteamUGC::SubmitItemUpdate</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success.<br />
        /// <b>false</b> if the UGC update <code class="bb_code bb_code_inline nohighlight">handle</code> is invalid.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetReturnLongDescription" class="bb_apilink">ISteamUGC::SetReturnLongDescription</a></summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCUpdateHandle_t" class="bb_apilink">UGCUpdateHandle_t</a>: The workshop item update handle to customize.</param>
        /// <param name="pchDescription">const char *: The new description of the item.</param>
        public static bool SetItemDescription(UGCUpdateHandle handle, UTF8StringPtr pchDescription) => Instance.SetItemDescription(handle, pchDescription);
        /// <summary><code>bool SetItemUpdateLanguage( UGCUpdateHandle_t handle, const char *pchLanguage );</code><br />
        /// Sets the language of the title and description that will be set in this item update.<br />
        /// <br />
        /// This must be in the format of the <a href="https://partner.steamgames.com/doc/store/localization#supported_languages" class="bb_doclink">API language code</a>.<br />
        /// <br />
        /// If this is not set then "english" is assumed.<br />
        /// <br />
        /// <b>NOTE:</b> This must be set before you submit the UGC update handle using <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SubmitItemUpdate" class="bb_apilink">ISteamUGC::SubmitItemUpdate</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success.<br />
        /// <b>false</b> if the UGC update <code class="bb_code bb_code_inline nohighlight">handle</code> is invalid.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetItemTitle" class="bb_apilink">ISteamUGC::SetItemTitle</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetItemDescription" class="bb_apilink">ISteamUGC::SetItemDescription</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetLanguage" class="bb_apilink">ISteamUGC::SetLanguage</a></summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCUpdateHandle_t" class="bb_apilink">UGCUpdateHandle_t</a>: The workshop item update handle to customize.</param>
        /// <param name="pchLanguage">const char *: The language of the title and description that will be set in this update.</param>
        public static bool SetItemUpdateLanguage(UGCUpdateHandle handle, UTF8StringPtr pchLanguage) => Instance.SetItemUpdateLanguage(handle, pchLanguage);
        /// <summary><code>bool SetItemMetadata( UGCUpdateHandle_t handle, const char *pchMetaData );</code><br />
        /// Sets arbitrary metadata for an item. This metadata can be returned from queries without having to download and install the actual content.<br />
        /// <br />
        /// The metadata must be limited to the size defined by <a href="https://partner.steamgames.com/doc/api/ISteamUGC#k_cchDeveloperMetadataMax" class="bb_apilink">k_cchDeveloperMetadataMax</a>.<br />
        /// <br />
        /// <b>NOTE:</b> This must be set before you submit the UGC update handle using <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SubmitItemUpdate" class="bb_apilink">ISteamUGC::SubmitItemUpdate</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success.<br />
        /// <b>false</b> if the UGC update <code class="bb_code bb_code_inline nohighlight">handle</code> is invalid, or if <code class="bb_code bb_code_inline nohighlight">pchMetadata</code> is longer than <a href="https://partner.steamgames.com/doc/api/ISteamUGC#k_cchDeveloperMetadataMax" class="bb_apilink">k_cchDeveloperMetadataMax</a>.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetReturnMetadata" class="bb_apilink">ISteamUGC::SetReturnMetadata</a></summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCUpdateHandle_t" class="bb_apilink">UGCUpdateHandle_t</a>: The workshop item update handle to customize.</param>
        /// <param name="pchMetaData">const char *: The new metadata for this item.</param>
        public static bool SetItemMetadata(UGCUpdateHandle handle, UTF8StringPtr pchMetaData) => Instance.SetItemMetadata(handle, pchMetaData);
        /// <summary><code>bool SetItemVisibility( UGCUpdateHandle_t handle, ERemoteStoragePublishedFileVisibility eVisibility );</code><br />
        /// Sets the visibility of an item.<br />
        /// <br />
        /// <b>NOTE:</b> This must be set before you submit the UGC update handle using <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SubmitItemUpdate" class="bb_apilink">ISteamUGC::SubmitItemUpdate</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success.<br />
        /// <b>false</b> if the UGC update <code class="bb_code bb_code_inline nohighlight">handle</code> is invalid.</summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCUpdateHandle_t" class="bb_apilink">UGCUpdateHandle_t</a>: The workshop item update handle to customize.</param>
        /// <param name="eVisibility"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#ERemoteStoragePublishedFileVisibility" class="bb_apilink">ERemoteStoragePublishedFileVisibility</a>: The visibility to set.</param>
        public static bool SetItemVisibility(UGCUpdateHandle handle, RemoteStoragePublishedFileVisibility eVisibility) => Instance.SetItemVisibility(handle, eVisibility);
        /// <summary><code>bool SetItemTags( UGCUpdateHandle_t updateHandle, const SteamParamStringArray_t *pTags );</code><br />
        /// Sets arbitrary developer specified tags on an item.<br />
        /// <br />
        /// Each tag must be limited to 255 characters. Tag names can only include printable characters, excluding ','. For reference on what characters are allowed, refer to <a href="http://en.cppreference.com/w/c/string/byte/isprint" target="_blank" rel="noreferrer">http://en.cppreference.com/w/c/string/byte/isprint</a><br />
        /// <br />
        /// <b>NOTE:</b> This must be set before you submit the UGC update handle using <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SubmitItemUpdate" class="bb_apilink">ISteamUGC::SubmitItemUpdate</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success.<br />
        /// <b>false</b> if the UGC update <code class="bb_code bb_code_inline nohighlight">handle</code> is invalid, or if one of the tags is invalid either due to exceeding the maximum length or because it is <b>NULL</b>.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#AddRequiredTag" class="bb_apilink">ISteamUGC::AddRequiredTag</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#AddExcludedTag" class="bb_apilink">ISteamUGC::AddExcludedTag</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetMatchAnyTag" class="bb_apilink">ISteamUGC::SetMatchAnyTag</a></summary>
        /// <param name="updateHandle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCUpdateHandle_t" class="bb_apilink">UGCUpdateHandle_t</a>: The workshop item update handle to customize.</param>
        /// <param name="pTags">const <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#SteamParamStringArray_t" class="bb_apilink">SteamParamStringArray_t</a> *: The list of tags to set on this item.</param>
        public static bool SetItemTags(UGCUpdateHandle updateHandle, SteamParamStringArray* pTags, bool bAllowAdminTags) => Instance.SetItemTags(updateHandle, pTags, bAllowAdminTags);
        /// <summary><code>bool SetItemContent( UGCUpdateHandle_t handle, const char *pszContentFolder );</code><br />
        /// Sets the folder that will be stored as the content for an item.<br />
        /// <br />
        /// For efficient upload and download, files should not be merged or compressed into single files (e.g. zip files).<br />
        /// <br />
        /// <b>NOTE:</b> This must be set before you submit the UGC update handle using <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SubmitItemUpdate" class="bb_apilink">ISteamUGC::SubmitItemUpdate</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success.<br />
        /// <b>false</b> if the UGC update <code class="bb_code bb_code_inline nohighlight">handle</code> is invalid.</summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCUpdateHandle_t" class="bb_apilink">UGCUpdateHandle_t</a>: The workshop item update handle to customize.</param>
        /// <param name="pszContentFolder">const char *: The absolute path to a local folder containing the content for the item.</param>
        public static bool SetItemContent(UGCUpdateHandle handle, UTF8StringPtr pszContentFolder) => Instance.SetItemContent(handle, pszContentFolder);
        /// <summary><code>bool SetItemPreview( UGCUpdateHandle_t handle, const char *pszPreviewFile );</code><br />
        /// Sets the primary preview image for the item.<br />
        /// <br />
        /// The format should be one that both the web and the application (if necessary) can render. Suggested formats include JPG, PNG and GIF.<br />
        /// <br />
        /// Be sure your app has its Steam Cloud quota and number of files set, as preview images are stored under the user's Cloud. If your app has no Cloud values set, this call will fail.<br />
        /// <br />
        /// <b>NOTE:</b> This must be set before you submit the UGC update handle using <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SubmitItemUpdate" class="bb_apilink">ISteamUGC::SubmitItemUpdate</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success.<br />
        /// <b>false</b> if the UGC update <code class="bb_code bb_code_inline nohighlight">handle</code> is invalid.</summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCUpdateHandle_t" class="bb_apilink">UGCUpdateHandle_t</a>: The workshop item update handle to customize.</param>
        /// <param name="pszPreviewFile">const char *: The absolute path to a local preview image file for the item.</param>
        public static bool SetItemPreview(UGCUpdateHandle handle, UTF8StringPtr pszPreviewFile) => Instance.SetItemPreview(handle, pszPreviewFile);
        /// missing documentation
        public static bool SetAllowLegacyUpload(UGCUpdateHandle handle, bool bAllowLegacyUpload) => Instance.SetAllowLegacyUpload(handle, bAllowLegacyUpload);
        /// missing documentation
        public static bool RemoveAllItemKeyValueTags(UGCUpdateHandle handle) => Instance.RemoveAllItemKeyValueTags(handle);
        /// <summary><code>bool RemoveItemKeyValueTags( UGCUpdateHandle_t handle, const char *pchKey );</code><br />
        /// Removes an existing key-value tag from an item.<br />
        /// <br />
        /// You can only call this up to 100 times per item update. If you need to remove more tags than that you'll need to make subsequent item updates.<br />
        /// <br />
        /// <b>NOTE:</b> This must be set before you submit the UGC update handle using <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SubmitItemUpdate" class="bb_apilink">ISteamUGC::SubmitItemUpdate</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success.<br />
        /// <b>false</b> if the UGC update <code class="bb_code bb_code_inline nohighlight">handle</code> is invalid or if you are trying to remove more than 100 key-value tags in a single update.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#AddItemKeyValueTag" class="bb_apilink">ISteamUGC::AddItemKeyValueTag</a></summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCUpdateHandle_t" class="bb_apilink">UGCUpdateHandle_t</a>: The workshop item update handle to customize.</param>
        /// <param name="pchKey">const char *: The key to remove from the item.</param>
        public static bool RemoveItemKeyValueTags(UGCUpdateHandle handle, UTF8StringPtr pchKey) => Instance.RemoveItemKeyValueTags(handle, pchKey);
        /// <summary><code>bool AddItemKeyValueTag( UGCUpdateHandle_t handle, const char *pchKey, const char *pchValue );</code><br />
        /// Adds a key-value tag pair to an item. Keys can map to multiple different values (1-to-many relationship).<br />
        /// <br />
        /// Key names are restricted to alpha-numeric characters and the '_' character.<br />
        /// <br />
        /// Both keys and values cannot exceed 255 characters in length.<br />
        /// <br />
        /// Key-value tags are searchable by exact match only.<br />
        /// <br />
        /// <b>NOTE:</b> This must be set before you submit the UGC update handle using <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SubmitItemUpdate" class="bb_apilink">ISteamUGC::SubmitItemUpdate</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success.<br />
        /// <b>false</b> if the UGC update <code class="bb_code bb_code_inline nohighlight">handle</code> is invalid, if <code class="bb_code bb_code_inline nohighlight">pchKey</code> or <code class="bb_code bb_code_inline nohighlight">pchValue</code> invalid because they are <b>NULL</b> or have exceeded the maximum length, or if you are trying to add more than 100 key-value tags in a single update.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#RemoveItemKeyValueTags" class="bb_apilink">ISteamUGC::RemoveItemKeyValueTags</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetReturnKeyValueTags" class="bb_apilink">ISteamUGC::SetReturnKeyValueTags</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetQueryUGCNumKeyValueTags" class="bb_apilink">ISteamUGC::GetQueryUGCNumKeyValueTags</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetQueryUGCKeyValueTag" class="bb_apilink">ISteamUGC::GetQueryUGCKeyValueTag</a></summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCUpdateHandle_t" class="bb_apilink">UGCUpdateHandle_t</a>: The workshop item update handle to customize.</param>
        /// <param name="pchKey">const char *: The key to set on the item.</param>
        /// <param name="pchValue">const char *: A value to map to the key.</param>
        public static bool AddItemKeyValueTag(UGCUpdateHandle handle, UTF8StringPtr pchKey, UTF8StringPtr pchValue) => Instance.AddItemKeyValueTag(handle, pchKey, pchValue);
        /// <summary><code>bool AddItemPreviewFile( UGCUpdateHandle_t handle, const char *pszPreviewFile, EItemPreviewType type );</code><br />
        /// Adds an additional preview file for the item.<br />
        /// <br />
        /// Then the format of the image should be one that both the web and the application (if necessary) can render and must be under 1MB. Suggested formats include JPG, PNG and GIF.<br />
        /// <br />
        /// <b>NOTE:</b> Using <a href="https://partner.steamgames.com/doc/api/ISteamUGC#k_EItemPreviewType_YouTubeVideo" class="bb_apilink">k_EItemPreviewType_YouTubeVideo</a> or <a href="https://partner.steamgames.com/doc/api/ISteamUGC#k_EItemPreviewType_Sketchfab" class="bb_apilink">k_EItemPreviewType_Sketchfab</a> are not currently supported with this API. For YouTube videos, you should use <a href="https://partner.steamgames.com/doc/api/ISteamUGC#AddItemPreviewVideo" class="bb_apilink">ISteamUGC::AddItemPreviewVideo</a>.<br />
        /// <br />
        /// <b>NOTE:</b> This must be set before you submit the UGC update handle using <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SubmitItemUpdate" class="bb_apilink">ISteamUGC::SubmitItemUpdate</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success.<br />
        /// <b>false</b> if the UGC update <code class="bb_code bb_code_inline nohighlight">handle</code> is invalid.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetQueryUGCNumAdditionalPreviews" class="bb_apilink">ISteamUGC::GetQueryUGCNumAdditionalPreviews</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetQueryUGCAdditionalPreview" class="bb_apilink">ISteamUGC::GetQueryUGCAdditionalPreview</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetReturnAdditionalPreviews" class="bb_apilink">ISteamUGC::SetReturnAdditionalPreviews</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#UpdateItemPreviewFile" class="bb_apilink">ISteamUGC::UpdateItemPreviewFile</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#AddItemPreviewVideo" class="bb_apilink">ISteamUGC::AddItemPreviewVideo</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#RemoveItemPreview" class="bb_apilink">ISteamUGC::RemoveItemPreview</a></summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCUpdateHandle_t" class="bb_apilink">UGCUpdateHandle_t</a>: The workshop item update handle to customize.</param>
        /// <param name="pszPreviewFile">const char *: Absolute path to the local image.</param>
        /// <param name="type"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#EItemPreviewType" class="bb_apilink">EItemPreviewType</a>: The type of this preview.</param>
        public static bool AddItemPreviewFile(UGCUpdateHandle handle, UTF8StringPtr pszPreviewFile, ItemPreviewType type) => Instance.AddItemPreviewFile(handle, pszPreviewFile, type);
        /// <summary><code>bool AddItemPreviewVideo( UGCUpdateHandle_t handle, const char *pszVideoID );</code><br />
        /// Adds an additional video preview from YouTube for the item.<br />
        /// <br />
        /// <b>NOTE:</b> This must be set before you submit the UGC update handle using <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SubmitItemUpdate" class="bb_apilink">ISteamUGC::SubmitItemUpdate</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success.<br />
        /// <b>false</b> if the UGC update <code class="bb_code bb_code_inline nohighlight">handle</code> is invalid.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetQueryUGCNumAdditionalPreviews" class="bb_apilink">ISteamUGC::GetQueryUGCNumAdditionalPreviews</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetQueryUGCAdditionalPreview" class="bb_apilink">ISteamUGC::GetQueryUGCAdditionalPreview</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetReturnAdditionalPreviews" class="bb_apilink">ISteamUGC::SetReturnAdditionalPreviews</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#UpdateItemPreviewVideo" class="bb_apilink">ISteamUGC::UpdateItemPreviewVideo</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#AddItemPreviewFile" class="bb_apilink">ISteamUGC::AddItemPreviewFile</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#RemoveItemPreview" class="bb_apilink">ISteamUGC::RemoveItemPreview</a></summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCUpdateHandle_t" class="bb_apilink">UGCUpdateHandle_t</a>: The workshop item update handle to customize.</param>
        /// <param name="pszVideoID">const char *: The YouTube video ID to add. (e.g. "jHgZh4GV9G0")</param>
        public static bool AddItemPreviewVideo(UGCUpdateHandle handle, UTF8StringPtr pszVideoID) => Instance.AddItemPreviewVideo(handle, pszVideoID);
        /// <summary><code>bool UpdateItemPreviewFile( UGCUpdateHandle_t handle, uint32 index, const char *pszPreviewFile );</code><br />
        /// Updates an existing additional preview file for the item.<br />
        /// <br />
        /// If the preview type is an image then the format should be one that both the web and the application (if necessary) can render, and must be under 1MB. Suggested formats include JPG, PNG and GIF.<br />
        /// <br />
        /// <b>NOTE:</b> This must be set before you submit the UGC update handle using <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SubmitItemUpdate" class="bb_apilink">ISteamUGC::SubmitItemUpdate</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success.<br />
        /// <b>false</b> if the UGC update <code class="bb_code bb_code_inline nohighlight">handle</code> is invalid.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#AddItemPreviewFile" class="bb_apilink">ISteamUGC::AddItemPreviewFile</a></summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCUpdateHandle_t" class="bb_apilink">UGCUpdateHandle_t</a>: The workshop item update handle to customize.</param>
        /// <param name="index"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The index of the preview file from 0 to <a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetQueryUGCNumAdditionalPreviews" class="bb_apilink">ISteamUGC::GetQueryUGCNumAdditionalPreviews</a>.</param>
        /// <param name="pszPreviewFile">const char *: Absolute path to the local image.</param>
        public static bool UpdateItemPreviewFile(UGCUpdateHandle handle, uint index, UTF8StringPtr pszPreviewFile) => Instance.UpdateItemPreviewFile(handle, index, pszPreviewFile);
        /// <summary><code>bool UpdateItemPreviewVideo( UGCUpdateHandle_t handle, uint32 index, const char *pszVideoID );</code><br />
        /// Updates an additional video preview from YouTube for the item.<br />
        /// <br />
        /// <b>NOTE:</b> This must be set before you submit the UGC update handle using <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SubmitItemUpdate" class="bb_apilink">ISteamUGC::SubmitItemUpdate</a>.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success.<br />
        /// <b>false</b> if the UGC update <code class="bb_code bb_code_inline nohighlight">handle</code> is invalid.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#AddItemPreviewVideo" class="bb_apilink">ISteamUGC::AddItemPreviewVideo</a></summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCUpdateHandle_t" class="bb_apilink">UGCUpdateHandle_t</a>: The workshop item update handle to customize.</param>
        /// <param name="index"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The index of the preview file from 0 to <a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetQueryUGCNumAdditionalPreviews" class="bb_apilink">ISteamUGC::GetQueryUGCNumAdditionalPreviews</a>.</param>
        /// <param name="pszVideoID">const char *: The YouTube video to add. (e.g. "jHgZh4GV9G0")</param>
        public static bool UpdateItemPreviewVideo(UGCUpdateHandle handle, uint index, UTF8StringPtr pszVideoID) => Instance.UpdateItemPreviewVideo(handle, index, pszVideoID);
        /// <summary><code>bool RemoveItemPreview( UGCUpdateHandle_t handle, uint32 index );</code><br />
        /// <b>Returns:</b> bool</summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCUpdateHandle_t" class="bb_apilink">UGCUpdateHandle_t</a>: </param>
        /// <param name="index"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: </param>
        public static bool RemoveItemPreview(UGCUpdateHandle handle, uint index) => Instance.RemoveItemPreview(handle, index);
        /// <summary><code>bool AddContentDescriptor( UGCUpdateHandle_t handle, EUGCContentDescriptorID descid );</code><br />
        /// Sets the given <a href="https://partner.steamgames.com/doc/api/ISteamUGC#EUGCContentDescriptorID" class="bb_apilink">EUGCContentDescriptorID</a> on the item.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetQueryUGCContentDescriptors" class="bb_apilink">ISteamUGC::GetQueryUGCContentDescriptors</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#RemoveContentDescriptor" class="bb_apilink">ISteamUGC::RemoveContentDescriptor</a></summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCUpdateHandle_t" class="bb_apilink">UGCUpdateHandle_t</a>: </param>
        /// <param name="descid"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#EUGCContentDescriptorID" class="bb_apilink">EUGCContentDescriptorID</a>: </param>
        public static bool AddContentDescriptor(UGCUpdateHandle handle, UGCContentDescriptorID descid) => Instance.AddContentDescriptor(handle, descid);
        /// <summary><code>bool RemoveContentDescriptor( UGCUpdateHandle_t handle, EUGCContentDescriptorID descid );</code><br />
        /// Removes the given <a href="https://partner.steamgames.com/doc/api/ISteamUGC#EUGCContentDescriptorID" class="bb_apilink">EUGCContentDescriptorID</a> from the item.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetQueryUGCContentDescriptors" class="bb_apilink">ISteamUGC::GetQueryUGCContentDescriptors</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#AddContentDescriptor" class="bb_apilink">ISteamUGC::AddContentDescriptor</a></summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCUpdateHandle_t" class="bb_apilink">UGCUpdateHandle_t</a>: </param>
        /// <param name="descid"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#EUGCContentDescriptorID" class="bb_apilink">EUGCContentDescriptorID</a>: </param>
        public static bool RemoveContentDescriptor(UGCUpdateHandle handle, UGCContentDescriptorID descid) => Instance.RemoveContentDescriptor(handle, descid);
        /// <summary><code>SteamAPICall_t SubmitItemUpdate( UGCUpdateHandle_t handle, const char *pchChangeNote );</code><br />
        /// Uploads the changes made to an item to the Steam Workshop.<br />
        /// <br />
        /// You can track the progress of an item update with <a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetItemUpdateProgress" class="bb_apilink">ISteamUGC::GetItemUpdateProgress</a>.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SubmitItemUpdateResult_t" class="bb_apilink">SubmitItemUpdateResult_t</a> call result.<br />
        /// Returns <a href="https://partner.steamgames.com/doc/api/steam_api#k_uAPICallInvalid" class="bb_apilink">k_uAPICallInvalid</a> if <code class="bb_code bb_code_inline nohighlight">handle</code> is invalid.</summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCUpdateHandle_t" class="bb_apilink">UGCUpdateHandle_t</a>: The update handle to submit.</param>
        /// <param name="pchChangeNote">const char *: A brief description of the changes made. (Optional, set to <b>NULL</b> for no change note)</param>
        public static SteamAPICall SubmitItemUpdate(UGCUpdateHandle handle, UTF8StringPtr pchChangeNote) => Instance.SubmitItemUpdate(handle, pchChangeNote);
        /// <summary><code>EItemUpdateStatus GetItemUpdateProgress( UGCUpdateHandle_t handle, uint64 *punBytesProcessed, uint64*punBytesTotal );</code><br />
        /// Gets the progress of an item update.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#EItemUpdateStatus" class="bb_apilink">EItemUpdateStatus</a><br />
        /// The current status.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SubmitItemUpdate" class="bb_apilink">ISteamUGC::SubmitItemUpdate</a></summary>
        /// <param name="handle"><a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCUpdateHandle_t" class="bb_apilink">UGCUpdateHandle_t</a>: The update handle to get the progress for.</param>
        /// <param name="punBytesProcessed"><a href="https://partner.steamgames.com/doc/api/steam_api#uint64" class="bb_apilink">uint64</a> *: Returns the current number of bytes uploaded.</param>
        /// <param name="punBytesTotal"><a href="https://partner.steamgames.com/doc/api/steam_api#uint64" class="bb_apilink">uint64</a> *: Returns the total number of bytes that will be uploaded.</param>
        public static ItemUpdateStatus GetItemUpdateProgress(UGCUpdateHandle handle, ulong* punBytesProcessed, ulong* punBytesTotal) => Instance.GetItemUpdateProgress(handle, punBytesProcessed, punBytesTotal);
        /// <summary><code>SteamAPICall_t SetUserItemVote( PublishedFileId_t nPublishedFileID, bool bVoteUp );</code><br />
        /// Allows the user to rate a workshop item up or down.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetUserItemVoteResult_t" class="bb_apilink">SetUserItemVoteResult_t</a> call result.<br />
        /// <br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetUserItemVote" class="bb_apilink">ISteamUGC::GetUserItemVote</a></summary>
        /// <param name="nPublishedFileID"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishedFileId_t" class="bb_apilink">PublishedFileId_t</a>: The workshop item ID to vote on.</param>
        /// <param name="bVoteUp">bool: Vote up (<b>true</b>) or down (<b>false</b>)?</param>
        public static SteamAPICall SetUserItemVote(PublishedFileId nPublishedFileID, bool bVoteUp) => Instance.SetUserItemVote(nPublishedFileID, bVoteUp);
        /// <summary><code>SteamAPICall_t GetUserItemVote( PublishedFileId_t nPublishedFileID );</code><br />
        /// Gets the user's vote status on a workshop item.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetUserItemVoteResult_t" class="bb_apilink">GetUserItemVoteResult_t</a> call result.<br />
        /// <br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SetUserItemVote" class="bb_apilink">ISteamUGC::SetUserItemVote</a></summary>
        /// <param name="nPublishedFileID"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishedFileId_t" class="bb_apilink">PublishedFileId_t</a>: The workshop item ID to get the user's vote.</param>
        public static SteamAPICall GetUserItemVote(PublishedFileId nPublishedFileID) => Instance.GetUserItemVote(nPublishedFileID);
        /// <summary><code>SteamAPICall_t AddItemToFavorites( AppId_t nAppId, PublishedFileId_t nPublishedFileID );</code><br />
        /// Adds a workshop item to the user's favorites list.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamUGC#UserFavoriteItemsListChanged_t" class="bb_apilink">UserFavoriteItemsListChanged_t</a> call result.<br />
        /// <br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#RemoveItemFromFavorites" class="bb_apilink">ISteamUGC::RemoveItemFromFavorites</a></summary>
        /// <param name="nAppId"><a href="https://partner.steamgames.com/doc/api/steam_api#AppId_t" class="bb_apilink">AppId_t</a>: The app ID that this item belongs to.</param>
        /// <param name="nPublishedFileID"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishedFileId_t" class="bb_apilink">PublishedFileId_t</a>: The workshop item to add to the user's favorites list.</param>
        public static SteamAPICall AddItemToFavorites(AppId nAppId, PublishedFileId nPublishedFileID) => Instance.AddItemToFavorites(nAppId, nPublishedFileID);
        /// <summary><code>SteamAPICall_t RemoveItemFromFavorites( AppId_t nAppId, PublishedFileId_t nPublishedFileID );</code><br />
        /// Removes a workshop item from the user's favorites list.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamUGC#UserFavoriteItemsListChanged_t" class="bb_apilink">UserFavoriteItemsListChanged_t</a> call result.<br />
        /// <br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#AddItemToFavorites" class="bb_apilink">ISteamUGC::AddItemToFavorites</a></summary>
        /// <param name="nAppId"><a href="https://partner.steamgames.com/doc/api/steam_api#AppId_t" class="bb_apilink">AppId_t</a>: The app ID that this item belongs to.</param>
        /// <param name="nPublishedFileID"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishedFileId_t" class="bb_apilink">PublishedFileId_t</a>: The workshop item to remove from the user's favorites list.</param>
        public static SteamAPICall RemoveItemFromFavorites(AppId nAppId, PublishedFileId nPublishedFileID) => Instance.RemoveItemFromFavorites(nAppId, nPublishedFileID);
        /// <summary><code>SteamAPICall_t SubscribeItem( PublishedFileId_t nPublishedFileID );</code><br />
        /// Subscribe to a workshop item. It will be downloaded and installed as soon as possible.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#RemoteStorageSubscribePublishedFileResult_t" class="bb_apilink">RemoteStorageSubscribePublishedFileResult_t</a> call result.<br />
        /// <br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SubscribeItem" class="bb_apilink">ISteamUGC::SubscribeItem</a></summary>
        /// <param name="nPublishedFileID"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishedFileId_t" class="bb_apilink">PublishedFileId_t</a>: The workshop item to subscribe to.</param>
        public static SteamAPICall SubscribeItem(PublishedFileId nPublishedFileID) => Instance.SubscribeItem(nPublishedFileID);
        /// <summary><code>SteamAPICall_t UnsubscribeItem( PublishedFileId_t nPublishedFileID );</code><br />
        /// Unsubscribe from a workshop item. This will result in the item being removed after the game quits.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#RemoteStorageUnsubscribePublishedFileResult_t" class="bb_apilink">RemoteStorageUnsubscribePublishedFileResult_t</a> call result.<br />
        /// <br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#UnsubscribeItem" class="bb_apilink">ISteamUGC::UnsubscribeItem</a></summary>
        /// <param name="nPublishedFileID"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishedFileId_t" class="bb_apilink">PublishedFileId_t</a>: The workshop item to unsubscribe from.</param>
        public static SteamAPICall UnsubscribeItem(PublishedFileId nPublishedFileID) => Instance.UnsubscribeItem(nPublishedFileID);
        /// <summary><code>uint32 GetNumSubscribedItems();</code>Gets the total number of items the current user is subscribed to for the game or application.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a><br />
        /// Returns <b>0</b> if called from a game server.</summary>
        /// 
        public static uint GetNumSubscribedItems() => Instance.GetNumSubscribedItems();
        /// <summary><code>uint32 GetSubscribedItems( PublishedFileId_t*pvecPublishedFileID, uint32 cMaxEntries );</code><br />
        /// Gets a list of all of the items the current user is subscribed to for the current game.<br />
        /// <br />
        /// You create an array with the size provided by <code class="bb_code bb_code_inline nohighlight">GetNumSubscribedItems</code> before calling this.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a><br />
        /// The number of subscribed workshop items that were populated into <code class="bb_code bb_code_inline nohighlight">pvecPublishedFileID</code>.<br />
        /// Returns <b>0</b> if called from a game server.</summary>
        /// <param name="pvecPublishedFileID"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishedFileId_t" class="bb_apilink">PublishedFileId_t</a> *: The array where the item ids will be copied into.</param>
        /// <param name="cMaxEntries"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The maximum number of items to return. This should typically be the same as <a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetNumSubscribedItems" class="bb_apilink">ISteamUGC::GetNumSubscribedItems</a> and the same size as <code class="bb_code bb_code_inline nohighlight">pvecPublishedFileID</code>.</param>
        public static uint GetSubscribedItems(PublishedFileId* pvecPublishedFileID, uint cMaxEntries) => Instance.GetSubscribedItems(pvecPublishedFileID, cMaxEntries);
        /// <summary><code>uint32 GetItemState( PublishedFileId_t nPublishedFileID );</code><br />
        /// Gets the current state of a workshop item on this client.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a><br />
        /// Returns the item state. Should be used with the <a href="https://partner.steamgames.com/doc/api/ISteamUGC#EItemState" class="bb_apilink">EItemState</a> flags to determine the state of the workshop item.<br />
        /// <br />
        /// <b>Example:</b><br />
        /// <code>uint32 unItemState = GetItemState( 280762427 );
        /// if ( unItemState &amp; k_EItemStateDownloading )
        /// {
        /// 	// indicates the item is currently downloading to the client
        /// }
        /// else if ( ( unItemState &amp; k_EItemStateInstalled ) &amp;&amp; ( unItemState &amp; k_EItemStateNeedsUpdate ) )
        /// {
        /// 	// indicates the item is installed but needs to be updated
        /// }</code></summary>
        /// <param name="nPublishedFileID"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishedFileId_t" class="bb_apilink">PublishedFileId_t</a>: The workshop item to get the state for.</param>
        public static uint GetItemState(PublishedFileId nPublishedFileID) => Instance.GetItemState(nPublishedFileID);
        /// <summary><code>bool GetItemInstallInfo( PublishedFileId_t nPublishedFileID, uint64 *punSizeOnDisk, char *pchFolder, uint32 cchFolderSize, uint32 *punTimeStamp );</code><br />
        /// Gets info about currently installed content on the disc for workshop items that have <code class="bb_code bb_code_inline nohighlight">k_EItemStateInstalled</code> set.<br />
        /// <br />
        /// Calling this sets the "used" flag on the workshop item for the current player and adds it to their <code class="bb_code bb_code_inline nohighlight">k_EUserUGCList_UsedOrPlayed</code> list.<br />
        /// <br />
        /// If <code class="bb_code bb_code_inline nohighlight">k_EItemStateLegacyItem</code> is set then <code class="bb_code bb_code_inline nohighlight">pchFolder</code> contains the path to the legacy file itself, not a folder.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the workshop item is already installed.<br />
        /// <b>false</b> in the following cases:<br />
        /// <ul class="bb_ul ">	<li> <code class="bb_code bb_code_inline nohighlight">cchFolderSize</code> is <b>0</b>.<br />
        /// 	</li><li> The workshop item has no content.<br />
        /// 	</li><li> The workshop item is not installed.</li></ul></summary>
        /// <param name="nPublishedFileID"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishedFileId_t" class="bb_apilink">PublishedFileId_t</a>: The workshop item to get the install info for.</param>
        /// <param name="punSizeOnDisk"><a href="https://partner.steamgames.com/doc/api/steam_api#uint64" class="bb_apilink">uint64</a> *: Returns the size of the workshop item in bytes.</param>
        /// <param name="pchFolder">char *: Returns the absolute path to the folder containing the content by copying it.</param>
        /// <param name="cchFolderSize"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The size of <code class="bb_code bb_code_inline nohighlight">pchFolder</code> in bytes.</param>
        /// <param name="punTimeStamp"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a> *: Returns the time when the workshop item was last updated.</param>
        public static bool GetItemInstallInfo(PublishedFileId nPublishedFileID, ulong* punSizeOnDisk, char* pchFolder, uint cchFolderSize, uint* punTimeStamp) => Instance.GetItemInstallInfo(nPublishedFileID, punSizeOnDisk, pchFolder, cchFolderSize, punTimeStamp);
        /// <summary><code>bool GetItemDownloadInfo( PublishedFileId_t nPublishedFileID, uint64 *punBytesDownloaded, uint64 *punBytesTotal );</code><br />
        /// Get info about a pending download of a workshop item that has <code class="bb_code bb_code_inline nohighlight">k_EItemStateNeedsUpdate</code> set.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> if the download information was available; otherwise, <b>false</b>.</summary>
        /// <param name="nPublishedFileID"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishedFileId_t" class="bb_apilink">PublishedFileId_t</a>: The workshop item to get the download info for.</param>
        /// <param name="punBytesDownloaded"><a href="https://partner.steamgames.com/doc/api/steam_api#uint64" class="bb_apilink">uint64</a> *: Returns the current bytes downloaded.</param>
        /// <param name="punBytesTotal"><a href="https://partner.steamgames.com/doc/api/steam_api#uint64" class="bb_apilink">uint64</a> *: Returns the total bytes. This is only valid after the download has started.</param>
        public static bool GetItemDownloadInfo(PublishedFileId nPublishedFileID, ulong* punBytesDownloaded, ulong* punBytesTotal) => Instance.GetItemDownloadInfo(nPublishedFileID, punBytesDownloaded, punBytesTotal);
        /// <summary><code>bool DownloadItem( PublishedFileId_t nPublishedFileID, bool bHighPriority );</code><br />
        /// Download or update a workshop item.<br />
        /// <br />
        /// If the return value is <b>true</b> then register and wait for the Callback <a href="https://partner.steamgames.com/doc/api/ISteamUGC#DownloadItemResult_t" class="bb_apilink">DownloadItemResult_t</a> before calling <a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetItemInstallInfo" class="bb_apilink">ISteamUGC::GetItemInstallInfo</a> or accessing the workshop item on disk.<br />
        /// <br />
        /// If the user is not subscribed to the item (e.g. a Game Server using anonymous login), the workshop item will be downloaded and cached temporarily.<br />
        /// <br />
        /// If the workshop item has an item state of <code class="bb_code bb_code_inline nohighlight">k_EItemStateNeedsUpdate</code>, then this function can be called to initiate the update. Do not access the workshop item on disk until the Callback <a href="https://partner.steamgames.com/doc/api/ISteamUGC#DownloadItemResult_t" class="bb_apilink">DownloadItemResult_t</a> is called.<br />
        /// <br />
        /// The <a href="https://partner.steamgames.com/doc/api/ISteamUGC#DownloadItemResult_t" class="bb_apilink">DownloadItemResult_t</a> callback contains the app ID associated with the workshop item. It should be compared against the running app ID as the handler will be called for all item downloads regardless of the running application.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// Triggers a <a href="https://partner.steamgames.com/doc/api/ISteamUGC#DownloadItemResult_t" class="bb_apilink">DownloadItemResult_t</a> callback.<br />
        /// <b>true</b> if the download was successfully started; otherwise, <b>false</b> if <code class="bb_code bb_code_inline nohighlight">nPublishedFileID</code> is invalid or the user is not logged on.</summary>
        /// <param name="nPublishedFileID"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishedFileId_t" class="bb_apilink">PublishedFileId_t</a>: The workshop item to download.</param>
        /// <param name="bHighPriority">bool: Start the download in high priority mode, pausing any existing in-progress Steam downloads and immediately begin downloading this workshop item.</param>
        public static bool DownloadItem(PublishedFileId nPublishedFileID, bool bHighPriority) => Instance.DownloadItem(nPublishedFileID, bHighPriority);
        /// <summary><code>bool BInitWorkshopForGameServer( DepotId_t unWorkshopDepotID, const char *pszFolder );</code><br />
        /// Lets game servers set a specific workshop folder before issuing any UGC commands.<br />
        /// <br />
        /// This is helpful if you want to support multiple game servers running out of the same install folder.<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success; otherwise, <b>false</b> if the calling user is not a game server or if the workshop is currently updating its content.</summary>
        /// <param name="unWorkshopDepotID"><a href="https://partner.steamgames.com/doc/api/steam_api#DepotId_t" class="bb_apilink">DepotId_t</a>: The depot ID of the game server.</param>
        /// <param name="pszFolder">const char *: The absolute path to store the workshop content.</param>
        public static bool BInitWorkshopForGameServer(DepotId unWorkshopDepotID, UTF8StringPtr pszFolder) => Instance.BInitWorkshopForGameServer(unWorkshopDepotID, pszFolder);
        /// <summary><code>void SuspendDownloads( bool bSuspend );</code><br />
        /// Suspends and resumes all workshop downloads.<br />
        /// <br />
        /// If you call this with <code class="bb_code bb_code_inline nohighlight">bSuspend</code> set to <b>true</b> then downloads will be suspended until you resume them by setting <code class="bb_code bb_code_inline nohighlight">bSuspend</code> to <b>false</b> or when the game ends.</summary>
        /// <param name="bSuspend">bool: Suspend (<b>true</b>) or Resume (<b>false</b>) workshop downloads?</param>
        public static void SuspendDownloads(bool bSuspend) => Instance.SuspendDownloads(bSuspend);
        /// <summary><code>SteamAPICall_t StartPlaytimeTracking( PublishedFileId_t *pvecPublishedFileID, uint32 unNumPublishedFileIDs );</code><br />
        /// Start tracking playtime on a set of workshop items.<br />
        /// <br />
        /// When your app shuts down, playtime tracking will automatically stop.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamUGC#StartPlaytimeTrackingResult_t" class="bb_apilink">StartPlaytimeTrackingResult_t</a> call result.<br />
        /// Returns <a href="https://partner.steamgames.com/doc/api/steam_api#k_uAPICallInvalid" class="bb_apilink">k_uAPICallInvalid</a> if <code class="bb_code bb_code_inline nohighlight">pvecPublishedFileID</code> is <b>NULL</b>, or <code class="bb_code bb_code_inline nohighlight">unNumPublishedFileIDs</code> is less than <b>1</b> or greater than <b>100</b>.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#StopPlaytimeTracking" class="bb_apilink">ISteamUGC::StopPlaytimeTracking</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#StopPlaytimeTrackingForAllItems" class="bb_apilink">ISteamUGC::StopPlaytimeTrackingForAllItems</a></summary>
        /// <param name="pvecPublishedFileID"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishedFileId_t" class="bb_apilink">PublishedFileId_t</a> *: The array of workshop items you want to start tracking. (Maximum of 100 items.)</param>
        /// <param name="unNumPublishedFileIDs"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The number of elements in <code class="bb_code bb_code_inline nohighlight">pvecPublishedFileID</code>.</param>
        public static SteamAPICall StartPlaytimeTracking(PublishedFileId* pvecPublishedFileID, uint unNumPublishedFileIDs) => Instance.StartPlaytimeTracking(pvecPublishedFileID, unNumPublishedFileIDs);
        /// <summary><code>SteamAPICall_t StopPlaytimeTracking( PublishedFileId_t *pvecPublishedFileID, uint32 unNumPublishedFileIDs );</code><br />
        /// Stop tracking playtime on a set of workshop items.<br />
        /// <br />
        /// When your app shuts down, playtime tracking will automatically stop.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamUGC#StopPlaytimeTrackingResult_t" class="bb_apilink">StopPlaytimeTrackingResult_t</a> call result.</summary>
        /// <param name="pvecPublishedFileID"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishedFileId_t" class="bb_apilink">PublishedFileId_t</a> *: The array of workshop items you want to stop tracking. (Maximum of 100 items.)</param>
        /// <param name="unNumPublishedFileIDs"><a href="https://partner.steamgames.com/doc/api/steam_api#uint32" class="bb_apilink">uint32</a>: The number of elements in <code class="bb_code bb_code_inline nohighlight">pvecPublishedFileID</code>.</param>
        public static SteamAPICall StopPlaytimeTracking(PublishedFileId* pvecPublishedFileID, uint unNumPublishedFileIDs) => Instance.StopPlaytimeTracking(pvecPublishedFileID, unNumPublishedFileIDs);
        /// <summary><code>SteamAPICall_t StopPlaytimeTrackingForAllItems();</code>Stop tracking playtime of all workshop items.<br />
        /// <br />
        /// When your app shuts down, playtime tracking will automatically stop.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamUGC#StopPlaytimeTrackingResult_t" class="bb_apilink">StopPlaytimeTrackingResult_t</a> call result.<br />
        /// Returns <a href="https://partner.steamgames.com/doc/api/steam_api#k_uAPICallInvalid" class="bb_apilink">k_uAPICallInvalid</a> if <code class="bb_code bb_code_inline nohighlight">pvecPublishedFileID</code> is <b>NULL</b> or <code class="bb_code bb_code_inline nohighlight">unNumPublishedFileIDs</code> is less than <b>1</b> or greater than <b>100</b>.</summary>
        /// 
        public static SteamAPICall StopPlaytimeTrackingForAllItems() => Instance.StopPlaytimeTrackingForAllItems();
        /// <summary><code>SteamAPICall_t AddDependency( PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID );</code><br />
        /// Adds a workshop item as a dependency to the specified item.  If the <code class="bb_code bb_code_inline nohighlight">nParentPublishedFileID</code> item is of type <code class="bb_code bb_code_inline nohighlight">k_EWorkshopFileTypeCollection</code>, then the <code class="bb_code bb_code_inline nohighlight">nChildPublishedFileID</code> is simply added to that collection.  Otherwise, the <i>dependency</i> is a soft one that is displayed on the web and can be retrieved via the <a href="https://partner.steamgames.com/doc/api/ISteamUGC" class="bb_apilink">ISteamUGC</a> API using a combination of the m_unNumChildren member variable of the <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SteamUGCDetails_t" class="bb_apilink">SteamUGCDetails_t</a> struct and <a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetQueryUGCChildren" class="bb_apilink">ISteamUGC::GetQueryUGCChildren</a>.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamUGC#AddUGCDependencyResult_t" class="bb_apilink">AddUGCDependencyResult_t</a> call result.<br />
        /// <br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#RemoveDependency" class="bb_apilink">ISteamUGC::RemoveDependency</a></summary>
        /// <param name="nParentPublishedFileID"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishedFileId_t" class="bb_apilink">PublishedFileId_t</a>: The workshop item to add a dependency to.</param>
        /// <param name="nChildPublishedFileID"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishedFileId_t" class="bb_apilink">PublishedFileId_t</a>: The dependency to add to the parent.</param>
        public static SteamAPICall AddDependency(PublishedFileId nParentPublishedFileID, PublishedFileId nChildPublishedFileID) => Instance.AddDependency(nParentPublishedFileID, nChildPublishedFileID);
        /// <summary><code>SteamAPICall_t RemoveDependency( PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID );</code><br />
        /// Removes a workshop item as a dependency from the specified item.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamUGC#RemoveUGCDependencyResult_t" class="bb_apilink">RemoveUGCDependencyResult_t</a> call result.<br />
        /// <br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#AddDependency" class="bb_apilink">ISteamUGC::AddDependency</a></summary>
        /// <param name="nParentPublishedFileID"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishedFileId_t" class="bb_apilink">PublishedFileId_t</a>: The workshop item to remove a dependency from.</param>
        /// <param name="nChildPublishedFileID"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishedFileId_t" class="bb_apilink">PublishedFileId_t</a>: The dependency to remove from the parent.</param>
        public static SteamAPICall RemoveDependency(PublishedFileId nParentPublishedFileID, PublishedFileId nChildPublishedFileID) => Instance.RemoveDependency(nParentPublishedFileID, nChildPublishedFileID);
        /// <summary><code>SteamAPICall_t AddAppDependency( PublishedFileId_t nPublishedFileID, AppId_t nAppID );</code><br />
        /// Adds a dependency between the given item and the appid.  This list of dependencies can be retrieved by calling <a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetAppDependencies" class="bb_apilink">ISteamUGC::GetAppDependencies</a>.  This is a soft-dependency that is displayed on the web.  It is up to the application to determine whether the item can actually be used or not.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamUGC#AddAppDependencyResult_t" class="bb_apilink">AddAppDependencyResult_t</a> call result.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#RemoveAppDependency" class="bb_apilink">ISteamUGC::RemoveAppDependency</a></summary>
        /// <param name="nPublishedFileID"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishedFileId_t" class="bb_apilink">PublishedFileId_t</a>: The item.</param>
        /// <param name="nAppID"><a href="https://partner.steamgames.com/doc/api/steam_api#AppId_t" class="bb_apilink">AppId_t</a>: The required app/dlc.</param>
        public static SteamAPICall AddAppDependency(PublishedFileId nPublishedFileID, AppId nAppID) => Instance.AddAppDependency(nPublishedFileID, nAppID);
        /// <summary><code>SteamAPICall_t RemoveAppDependency( PublishedFileId_t nPublishedFileID, AppId_t nAppID );</code><br />
        /// Removes the dependency between the given item and the appid.  This list of dependencies can be retrieved by calling <a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetAppDependencies" class="bb_apilink">ISteamUGC::GetAppDependencies</a>.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamUGC#RemoveAppDependencyResult_t" class="bb_apilink">RemoveAppDependencyResult_t</a> call result.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#AddAppDependency" class="bb_apilink">ISteamUGC::AddAppDependency</a></summary>
        /// <param name="nPublishedFileID"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishedFileId_t" class="bb_apilink">PublishedFileId_t</a>: The item.</param>
        /// <param name="nAppID"><a href="https://partner.steamgames.com/doc/api/steam_api#AppId_t" class="bb_apilink">AppId_t</a>: The app/dlc.</param>
        public static SteamAPICall RemoveAppDependency(PublishedFileId nPublishedFileID, AppId nAppID) => Instance.RemoveAppDependency(nPublishedFileID, nAppID);
        /// <summary><code>bool GetAppDependencies( PublishedFileId_t nPublishedFileID );</code><br />
        /// Get the app dependencies associated with the given <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishedFileId_t" class="bb_apilink">PublishedFileId_t</a>.  These are "soft" dependencies that are shown on the web.  It is up to the application to determine whether an item can be used or not.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetAppDependenciesResult_t" class="bb_apilink">GetAppDependenciesResult_t</a> call result.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#AddAppDependency" class="bb_apilink">ISteamUGC::AddAppDependency</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#RemoveAppDependency" class="bb_apilink">ISteamUGC::RemoveAppDependency</a></summary>
        /// <param name="nPublishedFileID"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishedFileId_t" class="bb_apilink">PublishedFileId_t</a>: The workshop item to get app dependencies for.</param>
        public static SteamAPICall GetAppDependencies(PublishedFileId nPublishedFileID) => Instance.GetAppDependencies(nPublishedFileID);
        /// <summary><code>SteamAPICall_t DeleteItem( PublishedFileId_t nPublishedFileID );</code><br />
        /// Deletes the item without prompting the user.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a> to be used with a <a href="https://partner.steamgames.com/doc/api/ISteamUGC#DeleteItemResult_t" class="bb_apilink">DeleteItemResult_t</a> call result.</summary>
        /// <param name="nPublishedFileID"><a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#PublishedFileId_t" class="bb_apilink">PublishedFileId_t</a>: The item to delete.</param>
        public static SteamAPICall DeleteItem(PublishedFileId nPublishedFileID) => Instance.DeleteItem(nPublishedFileID);
        /// <summary><code>bool ShowWorkshopEULA();</code><br />
        /// Show the app's latest Workshop EULA to the user in an overlay window, where they can accept it or not<br />
        /// <br />
        /// <b>Returns:</b> bool<br />
        /// <b>true</b> upon success.<br />
        /// <b>false</b> if the overlay cannot be shown.<br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetWorkshopEULAStatus" class="bb_apilink">ISteamUGC::GetWorkshopEULAStatus</a></summary>
        /// 
        public static bool ShowWorkshopEULA() => Instance.ShowWorkshopEULA();
        /// <summary><code>SteamAPICall_t GetWorkshopEULAStatus();</code><br />
        /// Asynchronously retrieves data about whether the user accepted the Workshop EULA for the current app.<br />
        /// <br />
        /// <b>Returns:</b> <a href="https://partner.steamgames.com/doc/api/steam_api#SteamAPICall_t" class="bb_apilink">SteamAPICall_t</a><br />
        /// <br />
        /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#WorkshopEULAStatus_t" class="bb_apilink">ISteamUGC::WorkshopEULAStatus_t</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#ShowWorkshopEULA" class="bb_apilink">ISteamUGC::ShowWorkshopEULA</a></summary>
        /// 
        public static SteamAPICall GetWorkshopEULAStatus() => Instance.GetWorkshopEULAStatus();
        /// missing documentation
        public static uint GetUserContentDescriptorPreferences(UGCContentDescriptorID* pvecDescriptors, uint cMaxEntries) => Instance.GetUserContentDescriptorPreferences(pvecDescriptors, cMaxEntries);
    }
}