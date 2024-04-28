using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Provides functions for reading, writing, and accessing files which can be stored remotely in the Steam Cloud.<br />
    /// <br />
    /// See <a href="https://partner.steamgames.com/doc/features/cloud" class="bb_doclink">Steam Cloud</a> for more information.</summary>
    public unsafe interface ISteamRemoteStorage
    {
        public bool FileWrite(UTF8StringPtr pchFile, void* pvData, int cubData);
        public int FileRead(UTF8StringPtr pchFile, void* pvData, int cubDataToRead);
        public SteamAPICall FileWriteAsync(UTF8StringPtr pchFile, void* pvData, uint cubData);
        public SteamAPICall FileReadAsync(UTF8StringPtr pchFile, uint nOffset, uint cubToRead);
        public bool FileReadAsyncComplete(SteamAPICall hReadCall, void* pvBuffer, uint cubToRead);
        public bool FileForget(UTF8StringPtr pchFile);
        public bool FileDelete(UTF8StringPtr pchFile);
        public SteamAPICall FileShare(UTF8StringPtr pchFile);
        public bool SetSyncPlatforms(UTF8StringPtr pchFile, RemoteStoragePlatform eRemoteStoragePlatform);
        public UGCFileWriteStreamHandle FileWriteStreamOpen(UTF8StringPtr pchFile);
        public bool FileWriteStreamWriteChunk(UGCFileWriteStreamHandle writeHandle, void* pvData, int cubData);
        public bool FileWriteStreamClose(UGCFileWriteStreamHandle writeHandle);
        public bool FileWriteStreamCancel(UGCFileWriteStreamHandle writeHandle);
        public bool FileExists(UTF8StringPtr pchFile);
        public bool FilePersisted(UTF8StringPtr pchFile);
        public int GetFileSize(UTF8StringPtr pchFile);
        public long GetFileTimestamp(UTF8StringPtr pchFile);
        public RemoteStoragePlatform GetSyncPlatforms(UTF8StringPtr pchFile);
        public int GetFileCount();
        public UTF8StringPtr GetFileNameAndSize(int iFile, int* pnFileSizeInBytes);
        public bool GetQuota(ulong* pnTotalBytes, ulong* puAvailableBytes);
        public bool IsCloudEnabledForAccount();
        public bool IsCloudEnabledForApp();
        public void SetCloudEnabledForApp(bool bEnabled);
        public SteamAPICall UGCDownload(UGCHandle hContent, uint unPriority);
        public bool GetUGCDownloadProgress(UGCHandle hContent, int* pnBytesDownloaded, int* pnBytesExpected);
        public bool GetUGCDetails(UGCHandle hContent, AppId* pnAppID, byte** ppchName, int* pnFileSizeInBytes, SteamId* pSteamIDOwner);
        public int UGCRead(UGCHandle hContent, void* pvData, int cubDataToRead, uint cOffset, UGCReadAction eAction);
        public int GetCachedUGCCount();
        public UGCHandle GetCachedUGCHandle(int iCachedContent);
        public SteamAPICall PublishWorkshopFile(UTF8StringPtr pchFile, UTF8StringPtr pchPreviewFile, AppId nConsumerAppId, UTF8StringPtr pchTitle, UTF8StringPtr pchDescription, RemoteStoragePublishedFileVisibility eVisibility, SteamParamStringArray* pTags, WorkshopFileType eWorkshopFileType);
        public PublishedFileUpdateHandle CreatePublishedFileUpdateRequest(PublishedFileId unPublishedFileId);
        public bool UpdatePublishedFileFile(PublishedFileUpdateHandle updateHandle, UTF8StringPtr pchFile);
        public bool UpdatePublishedFilePreviewFile(PublishedFileUpdateHandle updateHandle, UTF8StringPtr pchPreviewFile);
        public bool UpdatePublishedFileTitle(PublishedFileUpdateHandle updateHandle, UTF8StringPtr pchTitle);
        public bool UpdatePublishedFileDescription(PublishedFileUpdateHandle updateHandle, UTF8StringPtr pchDescription);
        public bool UpdatePublishedFileVisibility(PublishedFileUpdateHandle updateHandle, RemoteStoragePublishedFileVisibility eVisibility);
        public bool UpdatePublishedFileTags(PublishedFileUpdateHandle updateHandle, SteamParamStringArray* pTags);
        public SteamAPICall CommitPublishedFileUpdate(PublishedFileUpdateHandle updateHandle);
        public SteamAPICall GetPublishedFileDetails(PublishedFileId unPublishedFileId, uint unMaxSecondsOld);
        public SteamAPICall DeletePublishedFile(PublishedFileId unPublishedFileId);
        public SteamAPICall EnumerateUserPublishedFiles(uint unStartIndex);
        public SteamAPICall SubscribePublishedFile(PublishedFileId unPublishedFileId);
        public SteamAPICall EnumerateUserSubscribedFiles(uint unStartIndex);
        public SteamAPICall UnsubscribePublishedFile(PublishedFileId unPublishedFileId);
        public bool UpdatePublishedFileSetChangeDescription(PublishedFileUpdateHandle updateHandle, UTF8StringPtr pchChangeDescription);
        public SteamAPICall GetPublishedItemVoteDetails(PublishedFileId unPublishedFileId);
        public SteamAPICall UpdateUserPublishedItemVote(PublishedFileId unPublishedFileId, bool bVoteUp);
        public SteamAPICall GetUserPublishedItemVoteDetails(PublishedFileId unPublishedFileId);
        public SteamAPICall EnumerateUserSharedWorkshopFiles(SteamId steamId, uint unStartIndex, SteamParamStringArray* pRequiredTags, SteamParamStringArray* pExcludedTags);
        public SteamAPICall PublishVideo(WorkshopVideoProvider eVideoProvider, UTF8StringPtr pchVideoAccount, UTF8StringPtr pchVideoIdentifier, UTF8StringPtr pchPreviewFile, AppId nConsumerAppId, UTF8StringPtr pchTitle, UTF8StringPtr pchDescription, RemoteStoragePublishedFileVisibility eVisibility, SteamParamStringArray* pTags);
        public SteamAPICall SetUserPublishedFileAction(PublishedFileId unPublishedFileId, WorkshopFileAction eAction);
        public SteamAPICall EnumeratePublishedFilesByUserAction(WorkshopFileAction eAction, uint unStartIndex);
        public SteamAPICall EnumeratePublishedWorkshopFiles(WorkshopEnumerationType eEnumerationType, uint unStartIndex, uint unCount, uint unDays, SteamParamStringArray* pTags, SteamParamStringArray* pUserTags);
        public SteamAPICall UGCDownloadToLocation(UGCHandle hContent, UTF8StringPtr pchLocation, uint unPriority);
        public int GetLocalFileChangeCount();
        public UTF8StringPtr GetLocalFileChange(int iFile, RemoteStorageLocalFileChangeType* pEChangeType, RemoteStorageFilePathType* pEFilePathType);
        public bool BeginFileWriteBatch();
        public bool EndFileWriteBatch();
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileWrite", CallingConvention = Platform.CC)]
        internal static extern bool FileWrite(void* self, UTF8StringPtr pchFile, void* pvData, int cubData);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileRead", CallingConvention = Platform.CC)]
        internal static extern int FileRead(void* self, UTF8StringPtr pchFile, void* pvData, int cubDataToRead);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileWriteAsync", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall FileWriteAsync(void* self, UTF8StringPtr pchFile, void* pvData, uint cubData);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileReadAsync", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall FileReadAsync(void* self, UTF8StringPtr pchFile, uint nOffset, uint cubToRead);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileReadAsyncComplete", CallingConvention = Platform.CC)]
        internal static extern bool FileReadAsyncComplete(void* self, SteamAPICall hReadCall, void* pvBuffer, uint cubToRead);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileForget", CallingConvention = Platform.CC)]
        internal static extern bool FileForget(void* self, UTF8StringPtr pchFile);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileDelete", CallingConvention = Platform.CC)]
        internal static extern bool FileDelete(void* self, UTF8StringPtr pchFile);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileShare", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall FileShare(void* self, UTF8StringPtr pchFile);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_SetSyncPlatforms", CallingConvention = Platform.CC)]
        internal static extern bool SetSyncPlatforms(void* self, UTF8StringPtr pchFile, RemoteStoragePlatform eRemoteStoragePlatform);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileWriteStreamOpen", CallingConvention = Platform.CC)]
        internal static extern UGCFileWriteStreamHandle FileWriteStreamOpen(void* self, UTF8StringPtr pchFile);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileWriteStreamWriteChunk", CallingConvention = Platform.CC)]
        internal static extern bool FileWriteStreamWriteChunk(void* self, UGCFileWriteStreamHandle writeHandle, void* pvData, int cubData);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileWriteStreamClose", CallingConvention = Platform.CC)]
        internal static extern bool FileWriteStreamClose(void* self, UGCFileWriteStreamHandle writeHandle);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileWriteStreamCancel", CallingConvention = Platform.CC)]
        internal static extern bool FileWriteStreamCancel(void* self, UGCFileWriteStreamHandle writeHandle);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_FileExists", CallingConvention = Platform.CC)]
        internal static extern bool FileExists(void* self, UTF8StringPtr pchFile);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_FilePersisted", CallingConvention = Platform.CC)]
        internal static extern bool FilePersisted(void* self, UTF8StringPtr pchFile);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetFileSize", CallingConvention = Platform.CC)]
        internal static extern int GetFileSize(void* self, UTF8StringPtr pchFile);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetFileTimestamp", CallingConvention = Platform.CC)]
        internal static extern long GetFileTimestamp(void* self, UTF8StringPtr pchFile);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetSyncPlatforms", CallingConvention = Platform.CC)]
        internal static extern RemoteStoragePlatform GetSyncPlatforms(void* self, UTF8StringPtr pchFile);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetFileCount", CallingConvention = Platform.CC)]
        internal static extern int GetFileCount(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetFileNameAndSize", CallingConvention = Platform.CC)]
        internal static extern UTF8StringPtr GetFileNameAndSize(void* self, int iFile, int* pnFileSizeInBytes);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetQuota", CallingConvention = Platform.CC)]
        internal static extern bool GetQuota(void* self, ulong* pnTotalBytes, ulong* puAvailableBytes);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_IsCloudEnabledForAccount", CallingConvention = Platform.CC)]
        internal static extern bool IsCloudEnabledForAccount(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_IsCloudEnabledForApp", CallingConvention = Platform.CC)]
        internal static extern bool IsCloudEnabledForApp(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_SetCloudEnabledForApp", CallingConvention = Platform.CC)]
        internal static extern void SetCloudEnabledForApp(void* self, bool bEnabled);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_UGCDownload", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall UGCDownload(void* self, UGCHandle hContent, uint unPriority);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetUGCDownloadProgress", CallingConvention = Platform.CC)]
        internal static extern bool GetUGCDownloadProgress(void* self, UGCHandle hContent, int* pnBytesDownloaded, int* pnBytesExpected);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetUGCDetails", CallingConvention = Platform.CC)]
        internal static extern bool GetUGCDetails(void* self, UGCHandle hContent, AppId* pnAppID, byte** ppchName, int* pnFileSizeInBytes, SteamId* pSteamIDOwner);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_UGCRead", CallingConvention = Platform.CC)]
        internal static extern int UGCRead(void* self, UGCHandle hContent, void* pvData, int cubDataToRead, uint cOffset, UGCReadAction eAction);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetCachedUGCCount", CallingConvention = Platform.CC)]
        internal static extern int GetCachedUGCCount(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetCachedUGCHandle", CallingConvention = Platform.CC)]
        internal static extern UGCHandle GetCachedUGCHandle(void* self, int iCachedContent);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_PublishWorkshopFile", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall PublishWorkshopFile(void* self, UTF8StringPtr pchFile, UTF8StringPtr pchPreviewFile, AppId nConsumerAppId, UTF8StringPtr pchTitle, UTF8StringPtr pchDescription, RemoteStoragePublishedFileVisibility eVisibility, SteamParamStringArray* pTags, WorkshopFileType eWorkshopFileType);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_CreatePublishedFileUpdateRequest", CallingConvention = Platform.CC)]
        internal static extern PublishedFileUpdateHandle CreatePublishedFileUpdateRequest(void* self, PublishedFileId unPublishedFileId);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_UpdatePublishedFileFile", CallingConvention = Platform.CC)]
        internal static extern bool UpdatePublishedFileFile(void* self, PublishedFileUpdateHandle updateHandle, UTF8StringPtr pchFile);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_UpdatePublishedFilePreviewFile", CallingConvention = Platform.CC)]
        internal static extern bool UpdatePublishedFilePreviewFile(void* self, PublishedFileUpdateHandle updateHandle, UTF8StringPtr pchPreviewFile);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_UpdatePublishedFileTitle", CallingConvention = Platform.CC)]
        internal static extern bool UpdatePublishedFileTitle(void* self, PublishedFileUpdateHandle updateHandle, UTF8StringPtr pchTitle);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_UpdatePublishedFileDescription", CallingConvention = Platform.CC)]
        internal static extern bool UpdatePublishedFileDescription(void* self, PublishedFileUpdateHandle updateHandle, UTF8StringPtr pchDescription);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_UpdatePublishedFileVisibility", CallingConvention = Platform.CC)]
        internal static extern bool UpdatePublishedFileVisibility(void* self, PublishedFileUpdateHandle updateHandle, RemoteStoragePublishedFileVisibility eVisibility);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_UpdatePublishedFileTags", CallingConvention = Platform.CC)]
        internal static extern bool UpdatePublishedFileTags(void* self, PublishedFileUpdateHandle updateHandle, SteamParamStringArray* pTags);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_CommitPublishedFileUpdate", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall CommitPublishedFileUpdate(void* self, PublishedFileUpdateHandle updateHandle);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetPublishedFileDetails", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall GetPublishedFileDetails(void* self, PublishedFileId unPublishedFileId, uint unMaxSecondsOld);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_DeletePublishedFile", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall DeletePublishedFile(void* self, PublishedFileId unPublishedFileId);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_EnumerateUserPublishedFiles", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall EnumerateUserPublishedFiles(void* self, uint unStartIndex);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_SubscribePublishedFile", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall SubscribePublishedFile(void* self, PublishedFileId unPublishedFileId);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_EnumerateUserSubscribedFiles", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall EnumerateUserSubscribedFiles(void* self, uint unStartIndex);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_UnsubscribePublishedFile", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall UnsubscribePublishedFile(void* self, PublishedFileId unPublishedFileId);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_UpdatePublishedFileSetChangeDescription", CallingConvention = Platform.CC)]
        internal static extern bool UpdatePublishedFileSetChangeDescription(void* self, PublishedFileUpdateHandle updateHandle, UTF8StringPtr pchChangeDescription);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetPublishedItemVoteDetails", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall GetPublishedItemVoteDetails(void* self, PublishedFileId unPublishedFileId);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_UpdateUserPublishedItemVote", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall UpdateUserPublishedItemVote(void* self, PublishedFileId unPublishedFileId, bool bVoteUp);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetUserPublishedItemVoteDetails", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall GetUserPublishedItemVoteDetails(void* self, PublishedFileId unPublishedFileId);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_EnumerateUserSharedWorkshopFiles", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall EnumerateUserSharedWorkshopFiles(void* self, SteamId steamId, uint unStartIndex, SteamParamStringArray* pRequiredTags, SteamParamStringArray* pExcludedTags);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_PublishVideo", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall PublishVideo(void* self, WorkshopVideoProvider eVideoProvider, UTF8StringPtr pchVideoAccount, UTF8StringPtr pchVideoIdentifier, UTF8StringPtr pchPreviewFile, AppId nConsumerAppId, UTF8StringPtr pchTitle, UTF8StringPtr pchDescription, RemoteStoragePublishedFileVisibility eVisibility, SteamParamStringArray* pTags);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_SetUserPublishedFileAction", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall SetUserPublishedFileAction(void* self, PublishedFileId unPublishedFileId, WorkshopFileAction eAction);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_EnumeratePublishedFilesByUserAction", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall EnumeratePublishedFilesByUserAction(void* self, WorkshopFileAction eAction, uint unStartIndex);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_EnumeratePublishedWorkshopFiles", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall EnumeratePublishedWorkshopFiles(void* self, WorkshopEnumerationType eEnumerationType, uint unStartIndex, uint unCount, uint unDays, SteamParamStringArray* pTags, SteamParamStringArray* pUserTags);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_UGCDownloadToLocation", CallingConvention = Platform.CC)]
        internal static extern SteamAPICall UGCDownloadToLocation(void* self, UGCHandle hContent, UTF8StringPtr pchLocation, uint unPriority);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetLocalFileChangeCount", CallingConvention = Platform.CC)]
        internal static extern int GetLocalFileChangeCount(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_GetLocalFileChange", CallingConvention = Platform.CC)]
        internal static extern UTF8StringPtr GetLocalFileChange(void* self, int iFile, RemoteStorageLocalFileChangeType* pEChangeType, RemoteStorageFilePathType* pEFilePathType);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_BeginFileWriteBatch", CallingConvention = Platform.CC)]
        internal static extern bool BeginFileWriteBatch(void* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_ISteamRemoteStorage_EndFileWriteBatch", CallingConvention = Platform.CC)]
        internal static extern bool EndFileWriteBatch(void* self);
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
        public struct Instance : ISteamRemoteStorage
        {
            public void* self;
            public bool FileWrite(UTF8StringPtr pchFile, void* pvData, int cubData) => ISteamRemoteStorage.FileWrite(self, pchFile, pvData, cubData);
            public int FileRead(UTF8StringPtr pchFile, void* pvData, int cubDataToRead) => ISteamRemoteStorage.FileRead(self, pchFile, pvData, cubDataToRead);
            public SteamAPICall FileWriteAsync(UTF8StringPtr pchFile, void* pvData, uint cubData) => ISteamRemoteStorage.FileWriteAsync(self, pchFile, pvData, cubData);
            public SteamAPICall FileReadAsync(UTF8StringPtr pchFile, uint nOffset, uint cubToRead) => ISteamRemoteStorage.FileReadAsync(self, pchFile, nOffset, cubToRead);
            public bool FileReadAsyncComplete(SteamAPICall hReadCall, void* pvBuffer, uint cubToRead) => ISteamRemoteStorage.FileReadAsyncComplete(self, hReadCall, pvBuffer, cubToRead);
            public bool FileForget(UTF8StringPtr pchFile) => ISteamRemoteStorage.FileForget(self, pchFile);
            public bool FileDelete(UTF8StringPtr pchFile) => ISteamRemoteStorage.FileDelete(self, pchFile);
            public SteamAPICall FileShare(UTF8StringPtr pchFile) => ISteamRemoteStorage.FileShare(self, pchFile);
            public bool SetSyncPlatforms(UTF8StringPtr pchFile, RemoteStoragePlatform eRemoteStoragePlatform) => ISteamRemoteStorage.SetSyncPlatforms(self, pchFile, eRemoteStoragePlatform);
            public UGCFileWriteStreamHandle FileWriteStreamOpen(UTF8StringPtr pchFile) => ISteamRemoteStorage.FileWriteStreamOpen(self, pchFile);
            public bool FileWriteStreamWriteChunk(UGCFileWriteStreamHandle writeHandle, void* pvData, int cubData) => ISteamRemoteStorage.FileWriteStreamWriteChunk(self, writeHandle, pvData, cubData);
            public bool FileWriteStreamClose(UGCFileWriteStreamHandle writeHandle) => ISteamRemoteStorage.FileWriteStreamClose(self, writeHandle);
            public bool FileWriteStreamCancel(UGCFileWriteStreamHandle writeHandle) => ISteamRemoteStorage.FileWriteStreamCancel(self, writeHandle);
            public bool FileExists(UTF8StringPtr pchFile) => ISteamRemoteStorage.FileExists(self, pchFile);
            public bool FilePersisted(UTF8StringPtr pchFile) => ISteamRemoteStorage.FilePersisted(self, pchFile);
            public int GetFileSize(UTF8StringPtr pchFile) => ISteamRemoteStorage.GetFileSize(self, pchFile);
            public long GetFileTimestamp(UTF8StringPtr pchFile) => ISteamRemoteStorage.GetFileTimestamp(self, pchFile);
            public RemoteStoragePlatform GetSyncPlatforms(UTF8StringPtr pchFile) => ISteamRemoteStorage.GetSyncPlatforms(self, pchFile);
            public int GetFileCount() => ISteamRemoteStorage.GetFileCount(self);
            public UTF8StringPtr GetFileNameAndSize(int iFile, int* pnFileSizeInBytes) => ISteamRemoteStorage.GetFileNameAndSize(self, iFile, pnFileSizeInBytes);
            public bool GetQuota(ulong* pnTotalBytes, ulong* puAvailableBytes) => ISteamRemoteStorage.GetQuota(self, pnTotalBytes, puAvailableBytes);
            public bool IsCloudEnabledForAccount() => ISteamRemoteStorage.IsCloudEnabledForAccount(self);
            public bool IsCloudEnabledForApp() => ISteamRemoteStorage.IsCloudEnabledForApp(self);
            public void SetCloudEnabledForApp(bool bEnabled) => ISteamRemoteStorage.SetCloudEnabledForApp(self, bEnabled);
            public SteamAPICall UGCDownload(UGCHandle hContent, uint unPriority) => ISteamRemoteStorage.UGCDownload(self, hContent, unPriority);
            public bool GetUGCDownloadProgress(UGCHandle hContent, int* pnBytesDownloaded, int* pnBytesExpected) => ISteamRemoteStorage.GetUGCDownloadProgress(self, hContent, pnBytesDownloaded, pnBytesExpected);
            public bool GetUGCDetails(UGCHandle hContent, AppId* pnAppID, byte** ppchName, int* pnFileSizeInBytes, SteamId* pSteamIDOwner) => ISteamRemoteStorage.GetUGCDetails(self, hContent, pnAppID, ppchName, pnFileSizeInBytes, pSteamIDOwner);
            public int UGCRead(UGCHandle hContent, void* pvData, int cubDataToRead, uint cOffset, UGCReadAction eAction) => ISteamRemoteStorage.UGCRead(self, hContent, pvData, cubDataToRead, cOffset, eAction);
            public int GetCachedUGCCount() => ISteamRemoteStorage.GetCachedUGCCount(self);
            public UGCHandle GetCachedUGCHandle(int iCachedContent) => ISteamRemoteStorage.GetCachedUGCHandle(self, iCachedContent);
            public SteamAPICall PublishWorkshopFile(UTF8StringPtr pchFile, UTF8StringPtr pchPreviewFile, AppId nConsumerAppId, UTF8StringPtr pchTitle, UTF8StringPtr pchDescription, RemoteStoragePublishedFileVisibility eVisibility, SteamParamStringArray* pTags, WorkshopFileType eWorkshopFileType) => ISteamRemoteStorage.PublishWorkshopFile(self, pchFile, pchPreviewFile, nConsumerAppId, pchTitle, pchDescription, eVisibility, pTags, eWorkshopFileType);
            public PublishedFileUpdateHandle CreatePublishedFileUpdateRequest(PublishedFileId unPublishedFileId) => ISteamRemoteStorage.CreatePublishedFileUpdateRequest(self, unPublishedFileId);
            public bool UpdatePublishedFileFile(PublishedFileUpdateHandle updateHandle, UTF8StringPtr pchFile) => ISteamRemoteStorage.UpdatePublishedFileFile(self, updateHandle, pchFile);
            public bool UpdatePublishedFilePreviewFile(PublishedFileUpdateHandle updateHandle, UTF8StringPtr pchPreviewFile) => ISteamRemoteStorage.UpdatePublishedFilePreviewFile(self, updateHandle, pchPreviewFile);
            public bool UpdatePublishedFileTitle(PublishedFileUpdateHandle updateHandle, UTF8StringPtr pchTitle) => ISteamRemoteStorage.UpdatePublishedFileTitle(self, updateHandle, pchTitle);
            public bool UpdatePublishedFileDescription(PublishedFileUpdateHandle updateHandle, UTF8StringPtr pchDescription) => ISteamRemoteStorage.UpdatePublishedFileDescription(self, updateHandle, pchDescription);
            public bool UpdatePublishedFileVisibility(PublishedFileUpdateHandle updateHandle, RemoteStoragePublishedFileVisibility eVisibility) => ISteamRemoteStorage.UpdatePublishedFileVisibility(self, updateHandle, eVisibility);
            public bool UpdatePublishedFileTags(PublishedFileUpdateHandle updateHandle, SteamParamStringArray* pTags) => ISteamRemoteStorage.UpdatePublishedFileTags(self, updateHandle, pTags);
            public SteamAPICall CommitPublishedFileUpdate(PublishedFileUpdateHandle updateHandle) => ISteamRemoteStorage.CommitPublishedFileUpdate(self, updateHandle);
            public SteamAPICall GetPublishedFileDetails(PublishedFileId unPublishedFileId, uint unMaxSecondsOld) => ISteamRemoteStorage.GetPublishedFileDetails(self, unPublishedFileId, unMaxSecondsOld);
            public SteamAPICall DeletePublishedFile(PublishedFileId unPublishedFileId) => ISteamRemoteStorage.DeletePublishedFile(self, unPublishedFileId);
            public SteamAPICall EnumerateUserPublishedFiles(uint unStartIndex) => ISteamRemoteStorage.EnumerateUserPublishedFiles(self, unStartIndex);
            public SteamAPICall SubscribePublishedFile(PublishedFileId unPublishedFileId) => ISteamRemoteStorage.SubscribePublishedFile(self, unPublishedFileId);
            public SteamAPICall EnumerateUserSubscribedFiles(uint unStartIndex) => ISteamRemoteStorage.EnumerateUserSubscribedFiles(self, unStartIndex);
            public SteamAPICall UnsubscribePublishedFile(PublishedFileId unPublishedFileId) => ISteamRemoteStorage.UnsubscribePublishedFile(self, unPublishedFileId);
            public bool UpdatePublishedFileSetChangeDescription(PublishedFileUpdateHandle updateHandle, UTF8StringPtr pchChangeDescription) => ISteamRemoteStorage.UpdatePublishedFileSetChangeDescription(self, updateHandle, pchChangeDescription);
            public SteamAPICall GetPublishedItemVoteDetails(PublishedFileId unPublishedFileId) => ISteamRemoteStorage.GetPublishedItemVoteDetails(self, unPublishedFileId);
            public SteamAPICall UpdateUserPublishedItemVote(PublishedFileId unPublishedFileId, bool bVoteUp) => ISteamRemoteStorage.UpdateUserPublishedItemVote(self, unPublishedFileId, bVoteUp);
            public SteamAPICall GetUserPublishedItemVoteDetails(PublishedFileId unPublishedFileId) => ISteamRemoteStorage.GetUserPublishedItemVoteDetails(self, unPublishedFileId);
            public SteamAPICall EnumerateUserSharedWorkshopFiles(SteamId steamId, uint unStartIndex, SteamParamStringArray* pRequiredTags, SteamParamStringArray* pExcludedTags) => ISteamRemoteStorage.EnumerateUserSharedWorkshopFiles(self, steamId, unStartIndex, pRequiredTags, pExcludedTags);
            public SteamAPICall PublishVideo(WorkshopVideoProvider eVideoProvider, UTF8StringPtr pchVideoAccount, UTF8StringPtr pchVideoIdentifier, UTF8StringPtr pchPreviewFile, AppId nConsumerAppId, UTF8StringPtr pchTitle, UTF8StringPtr pchDescription, RemoteStoragePublishedFileVisibility eVisibility, SteamParamStringArray* pTags) => ISteamRemoteStorage.PublishVideo(self, eVideoProvider, pchVideoAccount, pchVideoIdentifier, pchPreviewFile, nConsumerAppId, pchTitle, pchDescription, eVisibility, pTags);
            public SteamAPICall SetUserPublishedFileAction(PublishedFileId unPublishedFileId, WorkshopFileAction eAction) => ISteamRemoteStorage.SetUserPublishedFileAction(self, unPublishedFileId, eAction);
            public SteamAPICall EnumeratePublishedFilesByUserAction(WorkshopFileAction eAction, uint unStartIndex) => ISteamRemoteStorage.EnumeratePublishedFilesByUserAction(self, eAction, unStartIndex);
            public SteamAPICall EnumeratePublishedWorkshopFiles(WorkshopEnumerationType eEnumerationType, uint unStartIndex, uint unCount, uint unDays, SteamParamStringArray* pTags, SteamParamStringArray* pUserTags) => ISteamRemoteStorage.EnumeratePublishedWorkshopFiles(self, eEnumerationType, unStartIndex, unCount, unDays, pTags, pUserTags);
            public SteamAPICall UGCDownloadToLocation(UGCHandle hContent, UTF8StringPtr pchLocation, uint unPriority) => ISteamRemoteStorage.UGCDownloadToLocation(self, hContent, pchLocation, unPriority);
            public int GetLocalFileChangeCount() => ISteamRemoteStorage.GetLocalFileChangeCount(self);
            public UTF8StringPtr GetLocalFileChange(int iFile, RemoteStorageLocalFileChangeType* pEChangeType, RemoteStorageFilePathType* pEFilePathType) => ISteamRemoteStorage.GetLocalFileChange(self, iFile, pEChangeType, pEFilePathType);
            public bool BeginFileWriteBatch() => ISteamRemoteStorage.BeginFileWriteBatch(self);
            public bool EndFileWriteBatch() => ISteamRemoteStorage.EndFileWriteBatch(self);
        }
    }
}