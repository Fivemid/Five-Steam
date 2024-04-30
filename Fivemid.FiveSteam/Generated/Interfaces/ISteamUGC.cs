using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Functions to create, consume, and interact with the <a href="https://partner.steamgames.com/doc/features/workshop" class="bb_doclink">Steam Workshop</a>.</summary>
    public unsafe interface ISteamUGC
    {
        public UGCQueryHandle CreateQueryUserUGCRequest(AccountID unAccountID, UserUGCList eListType, UGCMatchingUGCType eMatchingUGCType, UserUGCListSortOrder eSortOrder, AppId nCreatorAppID, AppId nConsumerAppID, uint unPage);
        public UGCQueryHandle CreateQueryAllUGCRequest(UGCQuery eQueryType, UGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId nCreatorAppID, AppId nConsumerAppID, uint unPage);
        public UGCQueryHandle CreateQueryAllUGCRequest(UGCQuery eQueryType, UGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId nCreatorAppID, AppId nConsumerAppID, UTF8StringPtr pchCursor);
        public UGCQueryHandle CreateQueryUGCDetailsRequest(PublishedFileId* pvecPublishedFileID, uint unNumPublishedFileIDs);
        public SteamAPICall SendQueryUGCRequest(UGCQueryHandle handle);
        public bool GetQueryUGCResult(UGCQueryHandle handle, uint index, SteamUGCDetails* pDetails);
        public uint GetQueryUGCNumTags(UGCQueryHandle handle, uint index);
        public bool GetQueryUGCTag(UGCQueryHandle handle, uint index, uint indexTag, byte* pchValue, uint cchValueSize);
        public bool GetQueryUGCTagDisplayName(UGCQueryHandle handle, uint index, uint indexTag, byte* pchValue, uint cchValueSize);
        public bool GetQueryUGCPreviewURL(UGCQueryHandle handle, uint index, byte* pchURL, uint cchURLSize);
        public bool GetQueryUGCMetadata(UGCQueryHandle handle, uint index, byte* pchMetadata, uint cchMetadatasize);
        public bool GetQueryUGCChildren(UGCQueryHandle handle, uint index, PublishedFileId* pvecPublishedFileID, uint cMaxEntries);
        public bool GetQueryUGCStatistic(UGCQueryHandle handle, uint index, ItemStatistic eStatType, ulong* pStatValue);
        public uint GetQueryUGCNumAdditionalPreviews(UGCQueryHandle handle, uint index);
        public bool GetQueryUGCAdditionalPreview(UGCQueryHandle handle, uint index, uint previewIndex, byte* pchURLOrVideoID, uint cchURLSize, byte* pchOriginalFileName, uint cchOriginalFileNameSize, ItemPreviewType* pPreviewType);
        public uint GetQueryUGCNumKeyValueTags(UGCQueryHandle handle, uint index);
        public bool GetQueryUGCKeyValueTag(UGCQueryHandle handle, uint index, uint keyValueTagIndex, byte* pchKey, uint cchKeySize, byte* pchValue, uint cchValueSize);
        public bool GetQueryUGCKeyValueTag(UGCQueryHandle handle, uint index, UTF8StringPtr pchKey, byte* pchValue, uint cchValueSize);
        public uint GetQueryUGCContentDescriptors(UGCQueryHandle handle, uint index, UGCContentDescriptorID* pvecDescriptors, uint cMaxEntries);
        public bool ReleaseQueryUGCRequest(UGCQueryHandle handle);
        public bool AddRequiredTag(UGCQueryHandle handle, UTF8StringPtr pTagName);
        public bool AddRequiredTagGroup(UGCQueryHandle handle, SteamParamStringArray* pTagGroups);
        public bool AddExcludedTag(UGCQueryHandle handle, UTF8StringPtr pTagName);
        public bool SetReturnOnlyIDs(UGCQueryHandle handle, bool bReturnOnlyIDs);
        public bool SetReturnKeyValueTags(UGCQueryHandle handle, bool bReturnKeyValueTags);
        public bool SetReturnLongDescription(UGCQueryHandle handle, bool bReturnLongDescription);
        public bool SetReturnMetadata(UGCQueryHandle handle, bool bReturnMetadata);
        public bool SetReturnChildren(UGCQueryHandle handle, bool bReturnChildren);
        public bool SetReturnAdditionalPreviews(UGCQueryHandle handle, bool bReturnAdditionalPreviews);
        public bool SetReturnTotalOnly(UGCQueryHandle handle, bool bReturnTotalOnly);
        public bool SetReturnPlaytimeStats(UGCQueryHandle handle, uint unDays);
        public bool SetLanguage(UGCQueryHandle handle, UTF8StringPtr pchLanguage);
        public bool SetAllowCachedResponse(UGCQueryHandle handle, uint unMaxAgeSeconds);
        public bool SetCloudFileNameFilter(UGCQueryHandle handle, UTF8StringPtr pMatchCloudFileName);
        public bool SetMatchAnyTag(UGCQueryHandle handle, bool bMatchAnyTag);
        public bool SetSearchText(UGCQueryHandle handle, UTF8StringPtr pSearchText);
        public bool SetRankedByTrendDays(UGCQueryHandle handle, uint unDays);
        public bool SetTimeCreatedDateRange(UGCQueryHandle handle, RTime32 rtStart, RTime32 rtEnd);
        public bool SetTimeUpdatedDateRange(UGCQueryHandle handle, RTime32 rtStart, RTime32 rtEnd);
        public bool AddRequiredKeyValueTag(UGCQueryHandle handle, UTF8StringPtr pKey, UTF8StringPtr pValue);
        public SteamAPICall RequestUGCDetails(PublishedFileId nPublishedFileID, uint unMaxAgeSeconds);
        public SteamAPICall CreateItem(AppId nConsumerAppId, WorkshopFileType eFileType);
        public UGCUpdateHandle StartItemUpdate(AppId nConsumerAppId, PublishedFileId nPublishedFileID);
        public bool SetItemTitle(UGCUpdateHandle handle, UTF8StringPtr pchTitle);
        public bool SetItemDescription(UGCUpdateHandle handle, UTF8StringPtr pchDescription);
        public bool SetItemUpdateLanguage(UGCUpdateHandle handle, UTF8StringPtr pchLanguage);
        public bool SetItemMetadata(UGCUpdateHandle handle, UTF8StringPtr pchMetaData);
        public bool SetItemVisibility(UGCUpdateHandle handle, RemoteStoragePublishedFileVisibility eVisibility);
        public bool SetItemTags(UGCUpdateHandle updateHandle, SteamParamStringArray* pTags, bool bAllowAdminTags);
        public bool SetItemContent(UGCUpdateHandle handle, UTF8StringPtr pszContentFolder);
        public bool SetItemPreview(UGCUpdateHandle handle, UTF8StringPtr pszPreviewFile);
        public bool SetAllowLegacyUpload(UGCUpdateHandle handle, bool bAllowLegacyUpload);
        public bool RemoveAllItemKeyValueTags(UGCUpdateHandle handle);
        public bool RemoveItemKeyValueTags(UGCUpdateHandle handle, UTF8StringPtr pchKey);
        public bool AddItemKeyValueTag(UGCUpdateHandle handle, UTF8StringPtr pchKey, UTF8StringPtr pchValue);
        public bool AddItemPreviewFile(UGCUpdateHandle handle, UTF8StringPtr pszPreviewFile, ItemPreviewType type);
        public bool AddItemPreviewVideo(UGCUpdateHandle handle, UTF8StringPtr pszVideoID);
        public bool UpdateItemPreviewFile(UGCUpdateHandle handle, uint index, UTF8StringPtr pszPreviewFile);
        public bool UpdateItemPreviewVideo(UGCUpdateHandle handle, uint index, UTF8StringPtr pszVideoID);
        public bool RemoveItemPreview(UGCUpdateHandle handle, uint index);
        public bool AddContentDescriptor(UGCUpdateHandle handle, UGCContentDescriptorID descid);
        public bool RemoveContentDescriptor(UGCUpdateHandle handle, UGCContentDescriptorID descid);
        public SteamAPICall SubmitItemUpdate(UGCUpdateHandle handle, UTF8StringPtr pchChangeNote);
        public ItemUpdateStatus GetItemUpdateProgress(UGCUpdateHandle handle, ulong* punBytesProcessed, ulong* punBytesTotal);
        public SteamAPICall SetUserItemVote(PublishedFileId nPublishedFileID, bool bVoteUp);
        public SteamAPICall GetUserItemVote(PublishedFileId nPublishedFileID);
        public SteamAPICall AddItemToFavorites(AppId nAppId, PublishedFileId nPublishedFileID);
        public SteamAPICall RemoveItemFromFavorites(AppId nAppId, PublishedFileId nPublishedFileID);
        public SteamAPICall SubscribeItem(PublishedFileId nPublishedFileID);
        public SteamAPICall UnsubscribeItem(PublishedFileId nPublishedFileID);
        public uint GetNumSubscribedItems();
        public uint GetSubscribedItems(PublishedFileId* pvecPublishedFileID, uint cMaxEntries);
        public uint GetItemState(PublishedFileId nPublishedFileID);
        public bool GetItemInstallInfo(PublishedFileId nPublishedFileID, ulong* punSizeOnDisk, byte* pchFolder, uint cchFolderSize, uint* punTimeStamp);
        public bool GetItemDownloadInfo(PublishedFileId nPublishedFileID, ulong* punBytesDownloaded, ulong* punBytesTotal);
        public bool DownloadItem(PublishedFileId nPublishedFileID, bool bHighPriority);
        public bool BInitWorkshopForGameServer(DepotId unWorkshopDepotID, UTF8StringPtr pszFolder);
        public void SuspendDownloads(bool bSuspend);
        public SteamAPICall StartPlaytimeTracking(PublishedFileId* pvecPublishedFileID, uint unNumPublishedFileIDs);
        public SteamAPICall StopPlaytimeTracking(PublishedFileId* pvecPublishedFileID, uint unNumPublishedFileIDs);
        public SteamAPICall StopPlaytimeTrackingForAllItems();
        public SteamAPICall AddDependency(PublishedFileId nParentPublishedFileID, PublishedFileId nChildPublishedFileID);
        public SteamAPICall RemoveDependency(PublishedFileId nParentPublishedFileID, PublishedFileId nChildPublishedFileID);
        public SteamAPICall AddAppDependency(PublishedFileId nPublishedFileID, AppId nAppID);
        public SteamAPICall RemoveAppDependency(PublishedFileId nPublishedFileID, AppId nAppID);
        public SteamAPICall GetAppDependencies(PublishedFileId nPublishedFileID);
        public SteamAPICall DeleteItem(PublishedFileId nPublishedFileID);
        public bool ShowWorkshopEULA();
        public SteamAPICall GetWorkshopEULAStatus();
        public uint GetUserContentDescriptorPreferences(UGCContentDescriptorID* pvecDescriptors, uint cMaxEntries);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_CreateQueryUserUGCRequest", CallingConvention = Platform.CC)]
        internal static extern UGCQueryHandle CreateQueryUserUGCRequest(void* self, AccountID unAccountID, UserUGCList eListType, UGCMatchingUGCType eMatchingUGCType, UserUGCListSortOrder eSortOrder, AppId nCreatorAppID, AppId nConsumerAppID, uint unPage);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_CreateQueryAllUGCRequestPage", CallingConvention = Platform.CC)]
        internal static extern UGCQueryHandle CreateQueryAllUGCRequest(void* self, UGCQuery eQueryType, UGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId nCreatorAppID, AppId nConsumerAppID, uint unPage);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_CreateQueryAllUGCRequestCursor", CallingConvention = Platform.CC)]
        internal static extern UGCQueryHandle CreateQueryAllUGCRequest(void* self, UGCQuery eQueryType, UGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId nCreatorAppID, AppId nConsumerAppID, UTF8StringPtr pchCursor);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_CreateQueryUGCDetailsRequest", CallingConvention = Platform.CC)]
        internal static extern UGCQueryHandle CreateQueryUGCDetailsRequest(void* self, PublishedFileId* pvecPublishedFileID, uint unNumPublishedFileIDs);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_SendQueryUGCRequest", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall SendQueryUGCRequest(void* self, UGCQueryHandle handle);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_GetQueryUGCResult", CallingConvention = Platform.CC)]
        internal static extern bool GetQueryUGCResult(void* self, UGCQueryHandle handle, uint index, SteamUGCDetails* pDetails);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_GetQueryUGCNumTags", CallingConvention = Platform.CC)]
        internal static extern uint GetQueryUGCNumTags(void* self, UGCQueryHandle handle, uint index);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_GetQueryUGCTag", CallingConvention = Platform.CC)]
        internal static extern bool GetQueryUGCTag(void* self, UGCQueryHandle handle, uint index, uint indexTag, byte* pchValue, uint cchValueSize);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_GetQueryUGCTagDisplayName", CallingConvention = Platform.CC)]
        internal static extern bool GetQueryUGCTagDisplayName(void* self, UGCQueryHandle handle, uint index, uint indexTag, byte* pchValue, uint cchValueSize);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_GetQueryUGCPreviewURL", CallingConvention = Platform.CC)]
        internal static extern bool GetQueryUGCPreviewURL(void* self, UGCQueryHandle handle, uint index, byte* pchURL, uint cchURLSize);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_GetQueryUGCMetadata", CallingConvention = Platform.CC)]
        internal static extern bool GetQueryUGCMetadata(void* self, UGCQueryHandle handle, uint index, byte* pchMetadata, uint cchMetadatasize);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_GetQueryUGCChildren", CallingConvention = Platform.CC)]
        internal static extern bool GetQueryUGCChildren(void* self, UGCQueryHandle handle, uint index, PublishedFileId* pvecPublishedFileID, uint cMaxEntries);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_GetQueryUGCStatistic", CallingConvention = Platform.CC)]
        internal static extern bool GetQueryUGCStatistic(void* self, UGCQueryHandle handle, uint index, ItemStatistic eStatType, ulong* pStatValue);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_GetQueryUGCNumAdditionalPreviews", CallingConvention = Platform.CC)]
        internal static extern uint GetQueryUGCNumAdditionalPreviews(void* self, UGCQueryHandle handle, uint index);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_GetQueryUGCAdditionalPreview", CallingConvention = Platform.CC)]
        internal static extern bool GetQueryUGCAdditionalPreview(void* self, UGCQueryHandle handle, uint index, uint previewIndex, byte* pchURLOrVideoID, uint cchURLSize, byte* pchOriginalFileName, uint cchOriginalFileNameSize, ItemPreviewType* pPreviewType);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_GetQueryUGCNumKeyValueTags", CallingConvention = Platform.CC)]
        internal static extern uint GetQueryUGCNumKeyValueTags(void* self, UGCQueryHandle handle, uint index);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_GetQueryUGCKeyValueTag", CallingConvention = Platform.CC)]
        internal static extern bool GetQueryUGCKeyValueTag(void* self, UGCQueryHandle handle, uint index, uint keyValueTagIndex, byte* pchKey, uint cchKeySize, byte* pchValue, uint cchValueSize);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_GetQueryFirstUGCKeyValueTag", CallingConvention = Platform.CC)]
        internal static extern bool GetQueryUGCKeyValueTag(void* self, UGCQueryHandle handle, uint index, UTF8StringPtr pchKey, byte* pchValue, uint cchValueSize);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_GetQueryUGCContentDescriptors", CallingConvention = Platform.CC)]
        internal static extern uint GetQueryUGCContentDescriptors(void* self, UGCQueryHandle handle, uint index, UGCContentDescriptorID* pvecDescriptors, uint cMaxEntries);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_ReleaseQueryUGCRequest", CallingConvention = Platform.CC)]
        internal static extern bool ReleaseQueryUGCRequest(void* self, UGCQueryHandle handle);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_AddRequiredTag", CallingConvention = Platform.CC)]
        internal static extern bool AddRequiredTag(void* self, UGCQueryHandle handle, UTF8StringPtr pTagName);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_AddRequiredTagGroup", CallingConvention = Platform.CC)]
        internal static extern bool AddRequiredTagGroup(void* self, UGCQueryHandle handle, SteamParamStringArray* pTagGroups);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_AddExcludedTag", CallingConvention = Platform.CC)]
        internal static extern bool AddExcludedTag(void* self, UGCQueryHandle handle, UTF8StringPtr pTagName);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_SetReturnOnlyIDs", CallingConvention = Platform.CC)]
        internal static extern bool SetReturnOnlyIDs(void* self, UGCQueryHandle handle, bool bReturnOnlyIDs);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_SetReturnKeyValueTags", CallingConvention = Platform.CC)]
        internal static extern bool SetReturnKeyValueTags(void* self, UGCQueryHandle handle, bool bReturnKeyValueTags);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_SetReturnLongDescription", CallingConvention = Platform.CC)]
        internal static extern bool SetReturnLongDescription(void* self, UGCQueryHandle handle, bool bReturnLongDescription);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_SetReturnMetadata", CallingConvention = Platform.CC)]
        internal static extern bool SetReturnMetadata(void* self, UGCQueryHandle handle, bool bReturnMetadata);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_SetReturnChildren", CallingConvention = Platform.CC)]
        internal static extern bool SetReturnChildren(void* self, UGCQueryHandle handle, bool bReturnChildren);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_SetReturnAdditionalPreviews", CallingConvention = Platform.CC)]
        internal static extern bool SetReturnAdditionalPreviews(void* self, UGCQueryHandle handle, bool bReturnAdditionalPreviews);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_SetReturnTotalOnly", CallingConvention = Platform.CC)]
        internal static extern bool SetReturnTotalOnly(void* self, UGCQueryHandle handle, bool bReturnTotalOnly);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_SetReturnPlaytimeStats", CallingConvention = Platform.CC)]
        internal static extern bool SetReturnPlaytimeStats(void* self, UGCQueryHandle handle, uint unDays);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_SetLanguage", CallingConvention = Platform.CC)]
        internal static extern bool SetLanguage(void* self, UGCQueryHandle handle, UTF8StringPtr pchLanguage);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_SetAllowCachedResponse", CallingConvention = Platform.CC)]
        internal static extern bool SetAllowCachedResponse(void* self, UGCQueryHandle handle, uint unMaxAgeSeconds);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_SetCloudFileNameFilter", CallingConvention = Platform.CC)]
        internal static extern bool SetCloudFileNameFilter(void* self, UGCQueryHandle handle, UTF8StringPtr pMatchCloudFileName);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_SetMatchAnyTag", CallingConvention = Platform.CC)]
        internal static extern bool SetMatchAnyTag(void* self, UGCQueryHandle handle, bool bMatchAnyTag);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_SetSearchText", CallingConvention = Platform.CC)]
        internal static extern bool SetSearchText(void* self, UGCQueryHandle handle, UTF8StringPtr pSearchText);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_SetRankedByTrendDays", CallingConvention = Platform.CC)]
        internal static extern bool SetRankedByTrendDays(void* self, UGCQueryHandle handle, uint unDays);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_SetTimeCreatedDateRange", CallingConvention = Platform.CC)]
        internal static extern bool SetTimeCreatedDateRange(void* self, UGCQueryHandle handle, RTime32 rtStart, RTime32 rtEnd);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_SetTimeUpdatedDateRange", CallingConvention = Platform.CC)]
        internal static extern bool SetTimeUpdatedDateRange(void* self, UGCQueryHandle handle, RTime32 rtStart, RTime32 rtEnd);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_AddRequiredKeyValueTag", CallingConvention = Platform.CC)]
        internal static extern bool AddRequiredKeyValueTag(void* self, UGCQueryHandle handle, UTF8StringPtr pKey, UTF8StringPtr pValue);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_RequestUGCDetails", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall RequestUGCDetails(void* self, PublishedFileId nPublishedFileID, uint unMaxAgeSeconds);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_CreateItem", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall CreateItem(void* self, AppId nConsumerAppId, WorkshopFileType eFileType);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_StartItemUpdate", CallingConvention = Platform.CC)]
        internal static extern UGCUpdateHandle StartItemUpdate(void* self, AppId nConsumerAppId, PublishedFileId nPublishedFileID);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_SetItemTitle", CallingConvention = Platform.CC)]
        internal static extern bool SetItemTitle(void* self, UGCUpdateHandle handle, UTF8StringPtr pchTitle);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_SetItemDescription", CallingConvention = Platform.CC)]
        internal static extern bool SetItemDescription(void* self, UGCUpdateHandle handle, UTF8StringPtr pchDescription);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_SetItemUpdateLanguage", CallingConvention = Platform.CC)]
        internal static extern bool SetItemUpdateLanguage(void* self, UGCUpdateHandle handle, UTF8StringPtr pchLanguage);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_SetItemMetadata", CallingConvention = Platform.CC)]
        internal static extern bool SetItemMetadata(void* self, UGCUpdateHandle handle, UTF8StringPtr pchMetaData);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_SetItemVisibility", CallingConvention = Platform.CC)]
        internal static extern bool SetItemVisibility(void* self, UGCUpdateHandle handle, RemoteStoragePublishedFileVisibility eVisibility);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_SetItemTags", CallingConvention = Platform.CC)]
        internal static extern bool SetItemTags(void* self, UGCUpdateHandle updateHandle, SteamParamStringArray* pTags, bool bAllowAdminTags);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_SetItemContent", CallingConvention = Platform.CC)]
        internal static extern bool SetItemContent(void* self, UGCUpdateHandle handle, UTF8StringPtr pszContentFolder);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_SetItemPreview", CallingConvention = Platform.CC)]
        internal static extern bool SetItemPreview(void* self, UGCUpdateHandle handle, UTF8StringPtr pszPreviewFile);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_SetAllowLegacyUpload", CallingConvention = Platform.CC)]
        internal static extern bool SetAllowLegacyUpload(void* self, UGCUpdateHandle handle, bool bAllowLegacyUpload);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_RemoveAllItemKeyValueTags", CallingConvention = Platform.CC)]
        internal static extern bool RemoveAllItemKeyValueTags(void* self, UGCUpdateHandle handle);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_RemoveItemKeyValueTags", CallingConvention = Platform.CC)]
        internal static extern bool RemoveItemKeyValueTags(void* self, UGCUpdateHandle handle, UTF8StringPtr pchKey);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_AddItemKeyValueTag", CallingConvention = Platform.CC)]
        internal static extern bool AddItemKeyValueTag(void* self, UGCUpdateHandle handle, UTF8StringPtr pchKey, UTF8StringPtr pchValue);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_AddItemPreviewFile", CallingConvention = Platform.CC)]
        internal static extern bool AddItemPreviewFile(void* self, UGCUpdateHandle handle, UTF8StringPtr pszPreviewFile, ItemPreviewType type);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_AddItemPreviewVideo", CallingConvention = Platform.CC)]
        internal static extern bool AddItemPreviewVideo(void* self, UGCUpdateHandle handle, UTF8StringPtr pszVideoID);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_UpdateItemPreviewFile", CallingConvention = Platform.CC)]
        internal static extern bool UpdateItemPreviewFile(void* self, UGCUpdateHandle handle, uint index, UTF8StringPtr pszPreviewFile);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_UpdateItemPreviewVideo", CallingConvention = Platform.CC)]
        internal static extern bool UpdateItemPreviewVideo(void* self, UGCUpdateHandle handle, uint index, UTF8StringPtr pszVideoID);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_RemoveItemPreview", CallingConvention = Platform.CC)]
        internal static extern bool RemoveItemPreview(void* self, UGCUpdateHandle handle, uint index);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_AddContentDescriptor", CallingConvention = Platform.CC)]
        internal static extern bool AddContentDescriptor(void* self, UGCUpdateHandle handle, UGCContentDescriptorID descid);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_RemoveContentDescriptor", CallingConvention = Platform.CC)]
        internal static extern bool RemoveContentDescriptor(void* self, UGCUpdateHandle handle, UGCContentDescriptorID descid);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_SubmitItemUpdate", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall SubmitItemUpdate(void* self, UGCUpdateHandle handle, UTF8StringPtr pchChangeNote);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_GetItemUpdateProgress", CallingConvention = Platform.CC)]
        internal static extern ItemUpdateStatus GetItemUpdateProgress(void* self, UGCUpdateHandle handle, ulong* punBytesProcessed, ulong* punBytesTotal);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_SetUserItemVote", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall SetUserItemVote(void* self, PublishedFileId nPublishedFileID, bool bVoteUp);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_GetUserItemVote", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall GetUserItemVote(void* self, PublishedFileId nPublishedFileID);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_AddItemToFavorites", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall AddItemToFavorites(void* self, AppId nAppId, PublishedFileId nPublishedFileID);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_RemoveItemFromFavorites", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall RemoveItemFromFavorites(void* self, AppId nAppId, PublishedFileId nPublishedFileID);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_SubscribeItem", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall SubscribeItem(void* self, PublishedFileId nPublishedFileID);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_UnsubscribeItem", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall UnsubscribeItem(void* self, PublishedFileId nPublishedFileID);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_GetNumSubscribedItems", CallingConvention = Platform.CC)]
        internal static extern uint GetNumSubscribedItems(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_GetSubscribedItems", CallingConvention = Platform.CC)]
        internal static extern uint GetSubscribedItems(void* self, PublishedFileId* pvecPublishedFileID, uint cMaxEntries);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_GetItemState", CallingConvention = Platform.CC)]
        internal static extern uint GetItemState(void* self, PublishedFileId nPublishedFileID);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_GetItemInstallInfo", CallingConvention = Platform.CC)]
        internal static extern bool GetItemInstallInfo(void* self, PublishedFileId nPublishedFileID, ulong* punSizeOnDisk, byte* pchFolder, uint cchFolderSize, uint* punTimeStamp);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_GetItemDownloadInfo", CallingConvention = Platform.CC)]
        internal static extern bool GetItemDownloadInfo(void* self, PublishedFileId nPublishedFileID, ulong* punBytesDownloaded, ulong* punBytesTotal);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_DownloadItem", CallingConvention = Platform.CC)]
        internal static extern bool DownloadItem(void* self, PublishedFileId nPublishedFileID, bool bHighPriority);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_BInitWorkshopForGameServer", CallingConvention = Platform.CC)]
        internal static extern bool BInitWorkshopForGameServer(void* self, DepotId unWorkshopDepotID, UTF8StringPtr pszFolder);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_SuspendDownloads", CallingConvention = Platform.CC)]
        internal static extern void SuspendDownloads(void* self, bool bSuspend);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_StartPlaytimeTracking", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall StartPlaytimeTracking(void* self, PublishedFileId* pvecPublishedFileID, uint unNumPublishedFileIDs);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_StopPlaytimeTracking", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall StopPlaytimeTracking(void* self, PublishedFileId* pvecPublishedFileID, uint unNumPublishedFileIDs);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_StopPlaytimeTrackingForAllItems", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall StopPlaytimeTrackingForAllItems(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_AddDependency", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall AddDependency(void* self, PublishedFileId nParentPublishedFileID, PublishedFileId nChildPublishedFileID);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_RemoveDependency", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall RemoveDependency(void* self, PublishedFileId nParentPublishedFileID, PublishedFileId nChildPublishedFileID);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_AddAppDependency", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall AddAppDependency(void* self, PublishedFileId nPublishedFileID, AppId nAppID);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_RemoveAppDependency", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall RemoveAppDependency(void* self, PublishedFileId nPublishedFileID, AppId nAppID);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_GetAppDependencies", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall GetAppDependencies(void* self, PublishedFileId nPublishedFileID);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_DeleteItem", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall DeleteItem(void* self, PublishedFileId nPublishedFileID);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_ShowWorkshopEULA", CallingConvention = Platform.CC)]
        internal static extern bool ShowWorkshopEULA(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_GetWorkshopEULAStatus", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall GetWorkshopEULAStatus(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamUGC_GetUserContentDescriptorPreferences", CallingConvention = Platform.CC)]
        internal static extern uint GetUserContentDescriptorPreferences(void* self, UGCContentDescriptorID* pvecDescriptors, uint cMaxEntries);
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct Instance : ISteamUGC
        {
            public void* self;
            public UGCQueryHandle CreateQueryUserUGCRequest(AccountID unAccountID, UserUGCList eListType, UGCMatchingUGCType eMatchingUGCType, UserUGCListSortOrder eSortOrder, AppId nCreatorAppID, AppId nConsumerAppID, uint unPage) => ISteamUGC.CreateQueryUserUGCRequest(self, unAccountID, eListType, eMatchingUGCType, eSortOrder, nCreatorAppID, nConsumerAppID, unPage);
            public UGCQueryHandle CreateQueryAllUGCRequest(UGCQuery eQueryType, UGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId nCreatorAppID, AppId nConsumerAppID, uint unPage) => ISteamUGC.CreateQueryAllUGCRequest(self, eQueryType, eMatchingeMatchingUGCTypeFileType, nCreatorAppID, nConsumerAppID, unPage);
            public UGCQueryHandle CreateQueryAllUGCRequest(UGCQuery eQueryType, UGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId nCreatorAppID, AppId nConsumerAppID, UTF8StringPtr pchCursor) => ISteamUGC.CreateQueryAllUGCRequest(self, eQueryType, eMatchingeMatchingUGCTypeFileType, nCreatorAppID, nConsumerAppID, pchCursor);
            public UGCQueryHandle CreateQueryUGCDetailsRequest(PublishedFileId* pvecPublishedFileID, uint unNumPublishedFileIDs) => ISteamUGC.CreateQueryUGCDetailsRequest(self, pvecPublishedFileID, unNumPublishedFileIDs);
            public SteamAPICall SendQueryUGCRequest(UGCQueryHandle handle) => ISteamUGC.SendQueryUGCRequest(self, handle);
            public bool GetQueryUGCResult(UGCQueryHandle handle, uint index, SteamUGCDetails* pDetails) => ISteamUGC.GetQueryUGCResult(self, handle, index, pDetails);
            public uint GetQueryUGCNumTags(UGCQueryHandle handle, uint index) => ISteamUGC.GetQueryUGCNumTags(self, handle, index);
            public bool GetQueryUGCTag(UGCQueryHandle handle, uint index, uint indexTag, byte* pchValue, uint cchValueSize) => ISteamUGC.GetQueryUGCTag(self, handle, index, indexTag, pchValue, cchValueSize);
            public bool GetQueryUGCTagDisplayName(UGCQueryHandle handle, uint index, uint indexTag, byte* pchValue, uint cchValueSize) => ISteamUGC.GetQueryUGCTagDisplayName(self, handle, index, indexTag, pchValue, cchValueSize);
            public bool GetQueryUGCPreviewURL(UGCQueryHandle handle, uint index, byte* pchURL, uint cchURLSize) => ISteamUGC.GetQueryUGCPreviewURL(self, handle, index, pchURL, cchURLSize);
            public bool GetQueryUGCMetadata(UGCQueryHandle handle, uint index, byte* pchMetadata, uint cchMetadatasize) => ISteamUGC.GetQueryUGCMetadata(self, handle, index, pchMetadata, cchMetadatasize);
            public bool GetQueryUGCChildren(UGCQueryHandle handle, uint index, PublishedFileId* pvecPublishedFileID, uint cMaxEntries) => ISteamUGC.GetQueryUGCChildren(self, handle, index, pvecPublishedFileID, cMaxEntries);
            public bool GetQueryUGCStatistic(UGCQueryHandle handle, uint index, ItemStatistic eStatType, ulong* pStatValue) => ISteamUGC.GetQueryUGCStatistic(self, handle, index, eStatType, pStatValue);
            public uint GetQueryUGCNumAdditionalPreviews(UGCQueryHandle handle, uint index) => ISteamUGC.GetQueryUGCNumAdditionalPreviews(self, handle, index);
            public bool GetQueryUGCAdditionalPreview(UGCQueryHandle handle, uint index, uint previewIndex, byte* pchURLOrVideoID, uint cchURLSize, byte* pchOriginalFileName, uint cchOriginalFileNameSize, ItemPreviewType* pPreviewType) => ISteamUGC.GetQueryUGCAdditionalPreview(self, handle, index, previewIndex, pchURLOrVideoID, cchURLSize, pchOriginalFileName, cchOriginalFileNameSize, pPreviewType);
            public uint GetQueryUGCNumKeyValueTags(UGCQueryHandle handle, uint index) => ISteamUGC.GetQueryUGCNumKeyValueTags(self, handle, index);
            public bool GetQueryUGCKeyValueTag(UGCQueryHandle handle, uint index, uint keyValueTagIndex, byte* pchKey, uint cchKeySize, byte* pchValue, uint cchValueSize) => ISteamUGC.GetQueryUGCKeyValueTag(self, handle, index, keyValueTagIndex, pchKey, cchKeySize, pchValue, cchValueSize);
            public bool GetQueryUGCKeyValueTag(UGCQueryHandle handle, uint index, UTF8StringPtr pchKey, byte* pchValue, uint cchValueSize) => ISteamUGC.GetQueryUGCKeyValueTag(self, handle, index, pchKey, pchValue, cchValueSize);
            public uint GetQueryUGCContentDescriptors(UGCQueryHandle handle, uint index, UGCContentDescriptorID* pvecDescriptors, uint cMaxEntries) => ISteamUGC.GetQueryUGCContentDescriptors(self, handle, index, pvecDescriptors, cMaxEntries);
            public bool ReleaseQueryUGCRequest(UGCQueryHandle handle) => ISteamUGC.ReleaseQueryUGCRequest(self, handle);
            public bool AddRequiredTag(UGCQueryHandle handle, UTF8StringPtr pTagName) => ISteamUGC.AddRequiredTag(self, handle, pTagName);
            public bool AddRequiredTagGroup(UGCQueryHandle handle, SteamParamStringArray* pTagGroups) => ISteamUGC.AddRequiredTagGroup(self, handle, pTagGroups);
            public bool AddExcludedTag(UGCQueryHandle handle, UTF8StringPtr pTagName) => ISteamUGC.AddExcludedTag(self, handle, pTagName);
            public bool SetReturnOnlyIDs(UGCQueryHandle handle, bool bReturnOnlyIDs) => ISteamUGC.SetReturnOnlyIDs(self, handle, bReturnOnlyIDs);
            public bool SetReturnKeyValueTags(UGCQueryHandle handle, bool bReturnKeyValueTags) => ISteamUGC.SetReturnKeyValueTags(self, handle, bReturnKeyValueTags);
            public bool SetReturnLongDescription(UGCQueryHandle handle, bool bReturnLongDescription) => ISteamUGC.SetReturnLongDescription(self, handle, bReturnLongDescription);
            public bool SetReturnMetadata(UGCQueryHandle handle, bool bReturnMetadata) => ISteamUGC.SetReturnMetadata(self, handle, bReturnMetadata);
            public bool SetReturnChildren(UGCQueryHandle handle, bool bReturnChildren) => ISteamUGC.SetReturnChildren(self, handle, bReturnChildren);
            public bool SetReturnAdditionalPreviews(UGCQueryHandle handle, bool bReturnAdditionalPreviews) => ISteamUGC.SetReturnAdditionalPreviews(self, handle, bReturnAdditionalPreviews);
            public bool SetReturnTotalOnly(UGCQueryHandle handle, bool bReturnTotalOnly) => ISteamUGC.SetReturnTotalOnly(self, handle, bReturnTotalOnly);
            public bool SetReturnPlaytimeStats(UGCQueryHandle handle, uint unDays) => ISteamUGC.SetReturnPlaytimeStats(self, handle, unDays);
            public bool SetLanguage(UGCQueryHandle handle, UTF8StringPtr pchLanguage) => ISteamUGC.SetLanguage(self, handle, pchLanguage);
            public bool SetAllowCachedResponse(UGCQueryHandle handle, uint unMaxAgeSeconds) => ISteamUGC.SetAllowCachedResponse(self, handle, unMaxAgeSeconds);
            public bool SetCloudFileNameFilter(UGCQueryHandle handle, UTF8StringPtr pMatchCloudFileName) => ISteamUGC.SetCloudFileNameFilter(self, handle, pMatchCloudFileName);
            public bool SetMatchAnyTag(UGCQueryHandle handle, bool bMatchAnyTag) => ISteamUGC.SetMatchAnyTag(self, handle, bMatchAnyTag);
            public bool SetSearchText(UGCQueryHandle handle, UTF8StringPtr pSearchText) => ISteamUGC.SetSearchText(self, handle, pSearchText);
            public bool SetRankedByTrendDays(UGCQueryHandle handle, uint unDays) => ISteamUGC.SetRankedByTrendDays(self, handle, unDays);
            public bool SetTimeCreatedDateRange(UGCQueryHandle handle, RTime32 rtStart, RTime32 rtEnd) => ISteamUGC.SetTimeCreatedDateRange(self, handle, rtStart, rtEnd);
            public bool SetTimeUpdatedDateRange(UGCQueryHandle handle, RTime32 rtStart, RTime32 rtEnd) => ISteamUGC.SetTimeUpdatedDateRange(self, handle, rtStart, rtEnd);
            public bool AddRequiredKeyValueTag(UGCQueryHandle handle, UTF8StringPtr pKey, UTF8StringPtr pValue) => ISteamUGC.AddRequiredKeyValueTag(self, handle, pKey, pValue);
            public SteamAPICall RequestUGCDetails(PublishedFileId nPublishedFileID, uint unMaxAgeSeconds) => ISteamUGC.RequestUGCDetails(self, nPublishedFileID, unMaxAgeSeconds);
            public SteamAPICall CreateItem(AppId nConsumerAppId, WorkshopFileType eFileType) => ISteamUGC.CreateItem(self, nConsumerAppId, eFileType);
            public UGCUpdateHandle StartItemUpdate(AppId nConsumerAppId, PublishedFileId nPublishedFileID) => ISteamUGC.StartItemUpdate(self, nConsumerAppId, nPublishedFileID);
            public bool SetItemTitle(UGCUpdateHandle handle, UTF8StringPtr pchTitle) => ISteamUGC.SetItemTitle(self, handle, pchTitle);
            public bool SetItemDescription(UGCUpdateHandle handle, UTF8StringPtr pchDescription) => ISteamUGC.SetItemDescription(self, handle, pchDescription);
            public bool SetItemUpdateLanguage(UGCUpdateHandle handle, UTF8StringPtr pchLanguage) => ISteamUGC.SetItemUpdateLanguage(self, handle, pchLanguage);
            public bool SetItemMetadata(UGCUpdateHandle handle, UTF8StringPtr pchMetaData) => ISteamUGC.SetItemMetadata(self, handle, pchMetaData);
            public bool SetItemVisibility(UGCUpdateHandle handle, RemoteStoragePublishedFileVisibility eVisibility) => ISteamUGC.SetItemVisibility(self, handle, eVisibility);
            public bool SetItemTags(UGCUpdateHandle updateHandle, SteamParamStringArray* pTags, bool bAllowAdminTags) => ISteamUGC.SetItemTags(self, updateHandle, pTags, bAllowAdminTags);
            public bool SetItemContent(UGCUpdateHandle handle, UTF8StringPtr pszContentFolder) => ISteamUGC.SetItemContent(self, handle, pszContentFolder);
            public bool SetItemPreview(UGCUpdateHandle handle, UTF8StringPtr pszPreviewFile) => ISteamUGC.SetItemPreview(self, handle, pszPreviewFile);
            public bool SetAllowLegacyUpload(UGCUpdateHandle handle, bool bAllowLegacyUpload) => ISteamUGC.SetAllowLegacyUpload(self, handle, bAllowLegacyUpload);
            public bool RemoveAllItemKeyValueTags(UGCUpdateHandle handle) => ISteamUGC.RemoveAllItemKeyValueTags(self, handle);
            public bool RemoveItemKeyValueTags(UGCUpdateHandle handle, UTF8StringPtr pchKey) => ISteamUGC.RemoveItemKeyValueTags(self, handle, pchKey);
            public bool AddItemKeyValueTag(UGCUpdateHandle handle, UTF8StringPtr pchKey, UTF8StringPtr pchValue) => ISteamUGC.AddItemKeyValueTag(self, handle, pchKey, pchValue);
            public bool AddItemPreviewFile(UGCUpdateHandle handle, UTF8StringPtr pszPreviewFile, ItemPreviewType type) => ISteamUGC.AddItemPreviewFile(self, handle, pszPreviewFile, type);
            public bool AddItemPreviewVideo(UGCUpdateHandle handle, UTF8StringPtr pszVideoID) => ISteamUGC.AddItemPreviewVideo(self, handle, pszVideoID);
            public bool UpdateItemPreviewFile(UGCUpdateHandle handle, uint index, UTF8StringPtr pszPreviewFile) => ISteamUGC.UpdateItemPreviewFile(self, handle, index, pszPreviewFile);
            public bool UpdateItemPreviewVideo(UGCUpdateHandle handle, uint index, UTF8StringPtr pszVideoID) => ISteamUGC.UpdateItemPreviewVideo(self, handle, index, pszVideoID);
            public bool RemoveItemPreview(UGCUpdateHandle handle, uint index) => ISteamUGC.RemoveItemPreview(self, handle, index);
            public bool AddContentDescriptor(UGCUpdateHandle handle, UGCContentDescriptorID descid) => ISteamUGC.AddContentDescriptor(self, handle, descid);
            public bool RemoveContentDescriptor(UGCUpdateHandle handle, UGCContentDescriptorID descid) => ISteamUGC.RemoveContentDescriptor(self, handle, descid);
            public SteamAPICall SubmitItemUpdate(UGCUpdateHandle handle, UTF8StringPtr pchChangeNote) => ISteamUGC.SubmitItemUpdate(self, handle, pchChangeNote);
            public ItemUpdateStatus GetItemUpdateProgress(UGCUpdateHandle handle, ulong* punBytesProcessed, ulong* punBytesTotal) => ISteamUGC.GetItemUpdateProgress(self, handle, punBytesProcessed, punBytesTotal);
            public SteamAPICall SetUserItemVote(PublishedFileId nPublishedFileID, bool bVoteUp) => ISteamUGC.SetUserItemVote(self, nPublishedFileID, bVoteUp);
            public SteamAPICall GetUserItemVote(PublishedFileId nPublishedFileID) => ISteamUGC.GetUserItemVote(self, nPublishedFileID);
            public SteamAPICall AddItemToFavorites(AppId nAppId, PublishedFileId nPublishedFileID) => ISteamUGC.AddItemToFavorites(self, nAppId, nPublishedFileID);
            public SteamAPICall RemoveItemFromFavorites(AppId nAppId, PublishedFileId nPublishedFileID) => ISteamUGC.RemoveItemFromFavorites(self, nAppId, nPublishedFileID);
            public SteamAPICall SubscribeItem(PublishedFileId nPublishedFileID) => ISteamUGC.SubscribeItem(self, nPublishedFileID);
            public SteamAPICall UnsubscribeItem(PublishedFileId nPublishedFileID) => ISteamUGC.UnsubscribeItem(self, nPublishedFileID);
            public uint GetNumSubscribedItems() => ISteamUGC.GetNumSubscribedItems(self);
            public uint GetSubscribedItems(PublishedFileId* pvecPublishedFileID, uint cMaxEntries) => ISteamUGC.GetSubscribedItems(self, pvecPublishedFileID, cMaxEntries);
            public uint GetItemState(PublishedFileId nPublishedFileID) => ISteamUGC.GetItemState(self, nPublishedFileID);
            public bool GetItemInstallInfo(PublishedFileId nPublishedFileID, ulong* punSizeOnDisk, byte* pchFolder, uint cchFolderSize, uint* punTimeStamp) => ISteamUGC.GetItemInstallInfo(self, nPublishedFileID, punSizeOnDisk, pchFolder, cchFolderSize, punTimeStamp);
            public bool GetItemDownloadInfo(PublishedFileId nPublishedFileID, ulong* punBytesDownloaded, ulong* punBytesTotal) => ISteamUGC.GetItemDownloadInfo(self, nPublishedFileID, punBytesDownloaded, punBytesTotal);
            public bool DownloadItem(PublishedFileId nPublishedFileID, bool bHighPriority) => ISteamUGC.DownloadItem(self, nPublishedFileID, bHighPriority);
            public bool BInitWorkshopForGameServer(DepotId unWorkshopDepotID, UTF8StringPtr pszFolder) => ISteamUGC.BInitWorkshopForGameServer(self, unWorkshopDepotID, pszFolder);
            public void SuspendDownloads(bool bSuspend) => ISteamUGC.SuspendDownloads(self, bSuspend);
            public SteamAPICall StartPlaytimeTracking(PublishedFileId* pvecPublishedFileID, uint unNumPublishedFileIDs) => ISteamUGC.StartPlaytimeTracking(self, pvecPublishedFileID, unNumPublishedFileIDs);
            public SteamAPICall StopPlaytimeTracking(PublishedFileId* pvecPublishedFileID, uint unNumPublishedFileIDs) => ISteamUGC.StopPlaytimeTracking(self, pvecPublishedFileID, unNumPublishedFileIDs);
            public SteamAPICall StopPlaytimeTrackingForAllItems() => ISteamUGC.StopPlaytimeTrackingForAllItems(self);
            public SteamAPICall AddDependency(PublishedFileId nParentPublishedFileID, PublishedFileId nChildPublishedFileID) => ISteamUGC.AddDependency(self, nParentPublishedFileID, nChildPublishedFileID);
            public SteamAPICall RemoveDependency(PublishedFileId nParentPublishedFileID, PublishedFileId nChildPublishedFileID) => ISteamUGC.RemoveDependency(self, nParentPublishedFileID, nChildPublishedFileID);
            public SteamAPICall AddAppDependency(PublishedFileId nPublishedFileID, AppId nAppID) => ISteamUGC.AddAppDependency(self, nPublishedFileID, nAppID);
            public SteamAPICall RemoveAppDependency(PublishedFileId nPublishedFileID, AppId nAppID) => ISteamUGC.RemoveAppDependency(self, nPublishedFileID, nAppID);
            public SteamAPICall GetAppDependencies(PublishedFileId nPublishedFileID) => ISteamUGC.GetAppDependencies(self, nPublishedFileID);
            public SteamAPICall DeleteItem(PublishedFileId nPublishedFileID) => ISteamUGC.DeleteItem(self, nPublishedFileID);
            public bool ShowWorkshopEULA() => ISteamUGC.ShowWorkshopEULA(self);
            public SteamAPICall GetWorkshopEULAStatus() => ISteamUGC.GetWorkshopEULAStatus(self);
            public uint GetUserContentDescriptorPreferences(UGCContentDescriptorID* pvecDescriptors, uint cMaxEntries) => ISteamUGC.GetUserContentDescriptorPreferences(self, pvecDescriptors, cMaxEntries);
        }
    }
}