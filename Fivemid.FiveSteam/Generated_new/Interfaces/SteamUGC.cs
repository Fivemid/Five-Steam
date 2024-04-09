using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamUGC
    {
        public static ISteamUGC.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamUGC_v018", CallingConvention = Platform.CC)]
        private static extern ISteamUGC.Instance Accessor();
        /// <summary></summary>
        public static UGCQueryHandle CreateQueryUserUGCRequest(AccountID unAccountID, UserUGCList eListType, UGCMatchingUGCType eMatchingUGCType, UserUGCListSortOrder eSortOrder, AppId nCreatorAppID, AppId nConsumerAppID, uint unPage) => Instance.CreateQueryUserUGCRequest(unAccountID, eListType, eMatchingUGCType, eSortOrder, nCreatorAppID, nConsumerAppID, unPage);
        /// <summary></summary>
        public static UGCQueryHandle CreateQueryAllUGCRequest(UGCQuery eQueryType, UGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId nCreatorAppID, AppId nConsumerAppID, uint unPage) => Instance.CreateQueryAllUGCRequest(eQueryType, eMatchingeMatchingUGCTypeFileType, nCreatorAppID, nConsumerAppID, unPage);
        /// <summary></summary>
        public static UGCQueryHandle CreateQueryAllUGCRequest(UGCQuery eQueryType, UGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId nCreatorAppID, AppId nConsumerAppID, UTF8StringPtr pchCursor) => Instance.CreateQueryAllUGCRequest(eQueryType, eMatchingeMatchingUGCTypeFileType, nCreatorAppID, nConsumerAppID, pchCursor);
        /// <summary></summary>
        public static UGCQueryHandle CreateQueryUGCDetailsRequest(PublishedFileId* pvecPublishedFileID, uint unNumPublishedFileIDs) => Instance.CreateQueryUGCDetailsRequest(pvecPublishedFileID, unNumPublishedFileIDs);
        /// <summary></summary>
        public static SteamAPICall SendQueryUGCRequest(UGCQueryHandle handle) => Instance.SendQueryUGCRequest(handle);
        /// <summary></summary>
        public static bool GetQueryUGCResult(UGCQueryHandle handle, uint index, SteamUGCDetails* pDetails) => Instance.GetQueryUGCResult(handle, index, pDetails);
        /// <summary></summary>
        public static uint GetQueryUGCNumTags(UGCQueryHandle handle, uint index) => Instance.GetQueryUGCNumTags(handle, index);
        /// <summary></summary>
        public static bool GetQueryUGCTag(UGCQueryHandle handle, uint index, uint indexTag, char* pchValue, uint cchValueSize) => Instance.GetQueryUGCTag(handle, index, indexTag, pchValue, cchValueSize);
        /// <summary></summary>
        public static bool GetQueryUGCTagDisplayName(UGCQueryHandle handle, uint index, uint indexTag, char* pchValue, uint cchValueSize) => Instance.GetQueryUGCTagDisplayName(handle, index, indexTag, pchValue, cchValueSize);
        /// <summary></summary>
        public static bool GetQueryUGCPreviewURL(UGCQueryHandle handle, uint index, char* pchURL, uint cchURLSize) => Instance.GetQueryUGCPreviewURL(handle, index, pchURL, cchURLSize);
        /// <summary></summary>
        public static bool GetQueryUGCMetadata(UGCQueryHandle handle, uint index, char* pchMetadata, uint cchMetadatasize) => Instance.GetQueryUGCMetadata(handle, index, pchMetadata, cchMetadatasize);
        /// <summary></summary>
        public static bool GetQueryUGCChildren(UGCQueryHandle handle, uint index, PublishedFileId* pvecPublishedFileID, uint cMaxEntries) => Instance.GetQueryUGCChildren(handle, index, pvecPublishedFileID, cMaxEntries);
        /// <summary></summary>
        public static bool GetQueryUGCStatistic(UGCQueryHandle handle, uint index, ItemStatistic eStatType, ulong* pStatValue) => Instance.GetQueryUGCStatistic(handle, index, eStatType, pStatValue);
        /// <summary></summary>
        public static uint GetQueryUGCNumAdditionalPreviews(UGCQueryHandle handle, uint index) => Instance.GetQueryUGCNumAdditionalPreviews(handle, index);
        /// <summary></summary>
        public static bool GetQueryUGCAdditionalPreview(UGCQueryHandle handle, uint index, uint previewIndex, char* pchURLOrVideoID, uint cchURLSize, char* pchOriginalFileName, uint cchOriginalFileNameSize, ItemPreviewType* pPreviewType) => Instance.GetQueryUGCAdditionalPreview(handle, index, previewIndex, pchURLOrVideoID, cchURLSize, pchOriginalFileName, cchOriginalFileNameSize, pPreviewType);
        /// <summary></summary>
        public static uint GetQueryUGCNumKeyValueTags(UGCQueryHandle handle, uint index) => Instance.GetQueryUGCNumKeyValueTags(handle, index);
        /// <summary></summary>
        public static bool GetQueryUGCKeyValueTag(UGCQueryHandle handle, uint index, uint keyValueTagIndex, char* pchKey, uint cchKeySize, char* pchValue, uint cchValueSize) => Instance.GetQueryUGCKeyValueTag(handle, index, keyValueTagIndex, pchKey, cchKeySize, pchValue, cchValueSize);
        /// <summary></summary>
        public static bool GetQueryUGCKeyValueTag(UGCQueryHandle handle, uint index, UTF8StringPtr pchKey, char* pchValue, uint cchValueSize) => Instance.GetQueryUGCKeyValueTag(handle, index, pchKey, pchValue, cchValueSize);
        /// <summary></summary>
        public static uint GetQueryUGCContentDescriptors(UGCQueryHandle handle, uint index, UGCContentDescriptorID* pvecDescriptors, uint cMaxEntries) => Instance.GetQueryUGCContentDescriptors(handle, index, pvecDescriptors, cMaxEntries);
        /// <summary></summary>
        public static bool ReleaseQueryUGCRequest(UGCQueryHandle handle) => Instance.ReleaseQueryUGCRequest(handle);
        /// <summary></summary>
        public static bool AddRequiredTag(UGCQueryHandle handle, UTF8StringPtr pTagName) => Instance.AddRequiredTag(handle, pTagName);
        /// <summary></summary>
        public static bool AddRequiredTagGroup(UGCQueryHandle handle, SteamParamStringArray* pTagGroups) => Instance.AddRequiredTagGroup(handle, pTagGroups);
        /// <summary></summary>
        public static bool AddExcludedTag(UGCQueryHandle handle, UTF8StringPtr pTagName) => Instance.AddExcludedTag(handle, pTagName);
        /// <summary></summary>
        public static bool SetReturnOnlyIDs(UGCQueryHandle handle, bool bReturnOnlyIDs) => Instance.SetReturnOnlyIDs(handle, bReturnOnlyIDs);
        /// <summary></summary>
        public static bool SetReturnKeyValueTags(UGCQueryHandle handle, bool bReturnKeyValueTags) => Instance.SetReturnKeyValueTags(handle, bReturnKeyValueTags);
        /// <summary></summary>
        public static bool SetReturnLongDescription(UGCQueryHandle handle, bool bReturnLongDescription) => Instance.SetReturnLongDescription(handle, bReturnLongDescription);
        /// <summary></summary>
        public static bool SetReturnMetadata(UGCQueryHandle handle, bool bReturnMetadata) => Instance.SetReturnMetadata(handle, bReturnMetadata);
        /// <summary></summary>
        public static bool SetReturnChildren(UGCQueryHandle handle, bool bReturnChildren) => Instance.SetReturnChildren(handle, bReturnChildren);
        /// <summary></summary>
        public static bool SetReturnAdditionalPreviews(UGCQueryHandle handle, bool bReturnAdditionalPreviews) => Instance.SetReturnAdditionalPreviews(handle, bReturnAdditionalPreviews);
        /// <summary></summary>
        public static bool SetReturnTotalOnly(UGCQueryHandle handle, bool bReturnTotalOnly) => Instance.SetReturnTotalOnly(handle, bReturnTotalOnly);
        /// <summary></summary>
        public static bool SetReturnPlaytimeStats(UGCQueryHandle handle, uint unDays) => Instance.SetReturnPlaytimeStats(handle, unDays);
        /// <summary></summary>
        public static bool SetLanguage(UGCQueryHandle handle, UTF8StringPtr pchLanguage) => Instance.SetLanguage(handle, pchLanguage);
        /// <summary></summary>
        public static bool SetAllowCachedResponse(UGCQueryHandle handle, uint unMaxAgeSeconds) => Instance.SetAllowCachedResponse(handle, unMaxAgeSeconds);
        /// <summary></summary>
        public static bool SetCloudFileNameFilter(UGCQueryHandle handle, UTF8StringPtr pMatchCloudFileName) => Instance.SetCloudFileNameFilter(handle, pMatchCloudFileName);
        /// <summary></summary>
        public static bool SetMatchAnyTag(UGCQueryHandle handle, bool bMatchAnyTag) => Instance.SetMatchAnyTag(handle, bMatchAnyTag);
        /// <summary></summary>
        public static bool SetSearchText(UGCQueryHandle handle, UTF8StringPtr pSearchText) => Instance.SetSearchText(handle, pSearchText);
        /// <summary></summary>
        public static bool SetRankedByTrendDays(UGCQueryHandle handle, uint unDays) => Instance.SetRankedByTrendDays(handle, unDays);
        /// <summary></summary>
        public static bool SetTimeCreatedDateRange(UGCQueryHandle handle, RTime32 rtStart, RTime32 rtEnd) => Instance.SetTimeCreatedDateRange(handle, rtStart, rtEnd);
        /// <summary></summary>
        public static bool SetTimeUpdatedDateRange(UGCQueryHandle handle, RTime32 rtStart, RTime32 rtEnd) => Instance.SetTimeUpdatedDateRange(handle, rtStart, rtEnd);
        /// <summary></summary>
        public static bool AddRequiredKeyValueTag(UGCQueryHandle handle, UTF8StringPtr pKey, UTF8StringPtr pValue) => Instance.AddRequiredKeyValueTag(handle, pKey, pValue);
        /// <summary></summary>
        public static SteamAPICall RequestUGCDetails(PublishedFileId nPublishedFileID, uint unMaxAgeSeconds) => Instance.RequestUGCDetails(nPublishedFileID, unMaxAgeSeconds);
        /// <summary></summary>
        public static SteamAPICall CreateItem(AppId nConsumerAppId, WorkshopFileType eFileType) => Instance.CreateItem(nConsumerAppId, eFileType);
        /// <summary></summary>
        public static UGCUpdateHandle StartItemUpdate(AppId nConsumerAppId, PublishedFileId nPublishedFileID) => Instance.StartItemUpdate(nConsumerAppId, nPublishedFileID);
        /// <summary></summary>
        public static bool SetItemTitle(UGCUpdateHandle handle, UTF8StringPtr pchTitle) => Instance.SetItemTitle(handle, pchTitle);
        /// <summary></summary>
        public static bool SetItemDescription(UGCUpdateHandle handle, UTF8StringPtr pchDescription) => Instance.SetItemDescription(handle, pchDescription);
        /// <summary></summary>
        public static bool SetItemUpdateLanguage(UGCUpdateHandle handle, UTF8StringPtr pchLanguage) => Instance.SetItemUpdateLanguage(handle, pchLanguage);
        /// <summary></summary>
        public static bool SetItemMetadata(UGCUpdateHandle handle, UTF8StringPtr pchMetaData) => Instance.SetItemMetadata(handle, pchMetaData);
        /// <summary></summary>
        public static bool SetItemVisibility(UGCUpdateHandle handle, RemoteStoragePublishedFileVisibility eVisibility) => Instance.SetItemVisibility(handle, eVisibility);
        /// <summary></summary>
        public static bool SetItemTags(UGCUpdateHandle updateHandle, SteamParamStringArray* pTags, bool bAllowAdminTags) => Instance.SetItemTags(updateHandle, pTags, bAllowAdminTags);
        /// <summary></summary>
        public static bool SetItemContent(UGCUpdateHandle handle, UTF8StringPtr pszContentFolder) => Instance.SetItemContent(handle, pszContentFolder);
        /// <summary></summary>
        public static bool SetItemPreview(UGCUpdateHandle handle, UTF8StringPtr pszPreviewFile) => Instance.SetItemPreview(handle, pszPreviewFile);
        /// <summary></summary>
        public static bool SetAllowLegacyUpload(UGCUpdateHandle handle, bool bAllowLegacyUpload) => Instance.SetAllowLegacyUpload(handle, bAllowLegacyUpload);
        /// <summary></summary>
        public static bool RemoveAllItemKeyValueTags(UGCUpdateHandle handle) => Instance.RemoveAllItemKeyValueTags(handle);
        /// <summary></summary>
        public static bool RemoveItemKeyValueTags(UGCUpdateHandle handle, UTF8StringPtr pchKey) => Instance.RemoveItemKeyValueTags(handle, pchKey);
        /// <summary></summary>
        public static bool AddItemKeyValueTag(UGCUpdateHandle handle, UTF8StringPtr pchKey, UTF8StringPtr pchValue) => Instance.AddItemKeyValueTag(handle, pchKey, pchValue);
        /// <summary></summary>
        public static bool AddItemPreviewFile(UGCUpdateHandle handle, UTF8StringPtr pszPreviewFile, ItemPreviewType type) => Instance.AddItemPreviewFile(handle, pszPreviewFile, type);
        /// <summary></summary>
        public static bool AddItemPreviewVideo(UGCUpdateHandle handle, UTF8StringPtr pszVideoID) => Instance.AddItemPreviewVideo(handle, pszVideoID);
        /// <summary></summary>
        public static bool UpdateItemPreviewFile(UGCUpdateHandle handle, uint index, UTF8StringPtr pszPreviewFile) => Instance.UpdateItemPreviewFile(handle, index, pszPreviewFile);
        /// <summary></summary>
        public static bool UpdateItemPreviewVideo(UGCUpdateHandle handle, uint index, UTF8StringPtr pszVideoID) => Instance.UpdateItemPreviewVideo(handle, index, pszVideoID);
        /// <summary></summary>
        public static bool RemoveItemPreview(UGCUpdateHandle handle, uint index) => Instance.RemoveItemPreview(handle, index);
        /// <summary></summary>
        public static bool AddContentDescriptor(UGCUpdateHandle handle, UGCContentDescriptorID descid) => Instance.AddContentDescriptor(handle, descid);
        /// <summary></summary>
        public static bool RemoveContentDescriptor(UGCUpdateHandle handle, UGCContentDescriptorID descid) => Instance.RemoveContentDescriptor(handle, descid);
        /// <summary></summary>
        public static SteamAPICall SubmitItemUpdate(UGCUpdateHandle handle, UTF8StringPtr pchChangeNote) => Instance.SubmitItemUpdate(handle, pchChangeNote);
        /// <summary></summary>
        public static ItemUpdateStatus GetItemUpdateProgress(UGCUpdateHandle handle, ulong* punBytesProcessed, ulong* punBytesTotal) => Instance.GetItemUpdateProgress(handle, punBytesProcessed, punBytesTotal);
        /// <summary></summary>
        public static SteamAPICall SetUserItemVote(PublishedFileId nPublishedFileID, bool bVoteUp) => Instance.SetUserItemVote(nPublishedFileID, bVoteUp);
        /// <summary></summary>
        public static SteamAPICall GetUserItemVote(PublishedFileId nPublishedFileID) => Instance.GetUserItemVote(nPublishedFileID);
        /// <summary></summary>
        public static SteamAPICall AddItemToFavorites(AppId nAppId, PublishedFileId nPublishedFileID) => Instance.AddItemToFavorites(nAppId, nPublishedFileID);
        /// <summary></summary>
        public static SteamAPICall RemoveItemFromFavorites(AppId nAppId, PublishedFileId nPublishedFileID) => Instance.RemoveItemFromFavorites(nAppId, nPublishedFileID);
        /// <summary></summary>
        public static SteamAPICall SubscribeItem(PublishedFileId nPublishedFileID) => Instance.SubscribeItem(nPublishedFileID);
        /// <summary></summary>
        public static SteamAPICall UnsubscribeItem(PublishedFileId nPublishedFileID) => Instance.UnsubscribeItem(nPublishedFileID);
        /// <summary></summary>
        public static uint GetNumSubscribedItems() => Instance.GetNumSubscribedItems();
        /// <summary></summary>
        public static uint GetSubscribedItems(PublishedFileId* pvecPublishedFileID, uint cMaxEntries) => Instance.GetSubscribedItems(pvecPublishedFileID, cMaxEntries);
        /// <summary></summary>
        public static uint GetItemState(PublishedFileId nPublishedFileID) => Instance.GetItemState(nPublishedFileID);
        /// <summary></summary>
        public static bool GetItemInstallInfo(PublishedFileId nPublishedFileID, ulong* punSizeOnDisk, char* pchFolder, uint cchFolderSize, uint* punTimeStamp) => Instance.GetItemInstallInfo(nPublishedFileID, punSizeOnDisk, pchFolder, cchFolderSize, punTimeStamp);
        /// <summary></summary>
        public static bool GetItemDownloadInfo(PublishedFileId nPublishedFileID, ulong* punBytesDownloaded, ulong* punBytesTotal) => Instance.GetItemDownloadInfo(nPublishedFileID, punBytesDownloaded, punBytesTotal);
        /// <summary></summary>
        public static bool DownloadItem(PublishedFileId nPublishedFileID, bool bHighPriority) => Instance.DownloadItem(nPublishedFileID, bHighPriority);
        /// <summary></summary>
        public static bool BInitWorkshopForGameServer(DepotId unWorkshopDepotID, UTF8StringPtr pszFolder) => Instance.BInitWorkshopForGameServer(unWorkshopDepotID, pszFolder);
        /// <summary></summary>
        public static void SuspendDownloads(bool bSuspend) => Instance.SuspendDownloads(bSuspend);
        /// <summary></summary>
        public static SteamAPICall StartPlaytimeTracking(PublishedFileId* pvecPublishedFileID, uint unNumPublishedFileIDs) => Instance.StartPlaytimeTracking(pvecPublishedFileID, unNumPublishedFileIDs);
        /// <summary></summary>
        public static SteamAPICall StopPlaytimeTracking(PublishedFileId* pvecPublishedFileID, uint unNumPublishedFileIDs) => Instance.StopPlaytimeTracking(pvecPublishedFileID, unNumPublishedFileIDs);
        /// <summary></summary>
        public static SteamAPICall StopPlaytimeTrackingForAllItems() => Instance.StopPlaytimeTrackingForAllItems();
        /// <summary></summary>
        public static SteamAPICall AddDependency(PublishedFileId nParentPublishedFileID, PublishedFileId nChildPublishedFileID) => Instance.AddDependency(nParentPublishedFileID, nChildPublishedFileID);
        /// <summary></summary>
        public static SteamAPICall RemoveDependency(PublishedFileId nParentPublishedFileID, PublishedFileId nChildPublishedFileID) => Instance.RemoveDependency(nParentPublishedFileID, nChildPublishedFileID);
        /// <summary></summary>
        public static SteamAPICall AddAppDependency(PublishedFileId nPublishedFileID, AppId nAppID) => Instance.AddAppDependency(nPublishedFileID, nAppID);
        /// <summary></summary>
        public static SteamAPICall RemoveAppDependency(PublishedFileId nPublishedFileID, AppId nAppID) => Instance.RemoveAppDependency(nPublishedFileID, nAppID);
        /// <summary></summary>
        public static SteamAPICall GetAppDependencies(PublishedFileId nPublishedFileID) => Instance.GetAppDependencies(nPublishedFileID);
        /// <summary></summary>
        public static SteamAPICall DeleteItem(PublishedFileId nPublishedFileID) => Instance.DeleteItem(nPublishedFileID);
        /// <summary></summary>
        public static bool ShowWorkshopEULA() => Instance.ShowWorkshopEULA();
        /// <summary></summary>
        public static SteamAPICall GetWorkshopEULAStatus() => Instance.GetWorkshopEULAStatus();
        /// <summary></summary>
        public static uint GetUserContentDescriptorPreferences(UGCContentDescriptorID* pvecDescriptors, uint cMaxEntries) => Instance.GetUserContentDescriptorPreferences(pvecDescriptors, cMaxEntries);
    }
}