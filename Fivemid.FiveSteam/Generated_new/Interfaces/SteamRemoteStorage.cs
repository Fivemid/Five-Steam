using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    public unsafe static class SteamRemoteStorage
    {
        public static ISteamRemoteStorage.Instance Instance => Accessor();

        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamRemoteStorage_v016", CallingConvention = Platform.CC)]
        private static extern ISteamRemoteStorage.Instance Accessor();
        /// <summary></summary>
        public static bool FileWrite(UTF8StringPtr pchFile, void* pvData, int cubData) => Instance.FileWrite(pchFile, pvData, cubData);
        /// <summary></summary>
        public static int FileRead(UTF8StringPtr pchFile, void* pvData, int cubDataToRead) => Instance.FileRead(pchFile, pvData, cubDataToRead);
        /// <summary></summary>
        public static SteamAPICall FileWriteAsync(UTF8StringPtr pchFile, void* pvData, uint cubData) => Instance.FileWriteAsync(pchFile, pvData, cubData);
        /// <summary></summary>
        public static SteamAPICall FileReadAsync(UTF8StringPtr pchFile, uint nOffset, uint cubToRead) => Instance.FileReadAsync(pchFile, nOffset, cubToRead);
        /// <summary></summary>
        public static bool FileReadAsyncComplete(SteamAPICall hReadCall, void* pvBuffer, uint cubToRead) => Instance.FileReadAsyncComplete(hReadCall, pvBuffer, cubToRead);
        /// <summary></summary>
        public static bool FileForget(UTF8StringPtr pchFile) => Instance.FileForget(pchFile);
        /// <summary></summary>
        public static bool FileDelete(UTF8StringPtr pchFile) => Instance.FileDelete(pchFile);
        /// <summary></summary>
        public static SteamAPICall FileShare(UTF8StringPtr pchFile) => Instance.FileShare(pchFile);
        /// <summary></summary>
        public static bool SetSyncPlatforms(UTF8StringPtr pchFile, RemoteStoragePlatform eRemoteStoragePlatform) => Instance.SetSyncPlatforms(pchFile, eRemoteStoragePlatform);
        /// <summary></summary>
        public static UGCFileWriteStreamHandle FileWriteStreamOpen(UTF8StringPtr pchFile) => Instance.FileWriteStreamOpen(pchFile);
        /// <summary></summary>
        public static bool FileWriteStreamWriteChunk(UGCFileWriteStreamHandle writeHandle, void* pvData, int cubData) => Instance.FileWriteStreamWriteChunk(writeHandle, pvData, cubData);
        /// <summary></summary>
        public static bool FileWriteStreamClose(UGCFileWriteStreamHandle writeHandle) => Instance.FileWriteStreamClose(writeHandle);
        /// <summary></summary>
        public static bool FileWriteStreamCancel(UGCFileWriteStreamHandle writeHandle) => Instance.FileWriteStreamCancel(writeHandle);
        /// <summary></summary>
        public static bool FileExists(UTF8StringPtr pchFile) => Instance.FileExists(pchFile);
        /// <summary></summary>
        public static bool FilePersisted(UTF8StringPtr pchFile) => Instance.FilePersisted(pchFile);
        /// <summary></summary>
        public static int GetFileSize(UTF8StringPtr pchFile) => Instance.GetFileSize(pchFile);
        /// <summary></summary>
        public static long GetFileTimestamp(UTF8StringPtr pchFile) => Instance.GetFileTimestamp(pchFile);
        /// <summary></summary>
        public static RemoteStoragePlatform GetSyncPlatforms(UTF8StringPtr pchFile) => Instance.GetSyncPlatforms(pchFile);
        /// <summary></summary>
        public static int GetFileCount() => Instance.GetFileCount();
        /// <summary></summary>
        public static UTF8StringPtr GetFileNameAndSize(int iFile, int* pnFileSizeInBytes) => Instance.GetFileNameAndSize(iFile, pnFileSizeInBytes);
        /// <summary></summary>
        public static bool GetQuota(ulong* pnTotalBytes, ulong* puAvailableBytes) => Instance.GetQuota(pnTotalBytes, puAvailableBytes);
        /// <summary></summary>
        public static bool IsCloudEnabledForAccount() => Instance.IsCloudEnabledForAccount();
        /// <summary></summary>
        public static bool IsCloudEnabledForApp() => Instance.IsCloudEnabledForApp();
        /// <summary></summary>
        public static void SetCloudEnabledForApp(bool bEnabled) => Instance.SetCloudEnabledForApp(bEnabled);
        /// <summary></summary>
        public static SteamAPICall UGCDownload(UGCHandle hContent, uint unPriority) => Instance.UGCDownload(hContent, unPriority);
        /// <summary></summary>
        public static bool GetUGCDownloadProgress(UGCHandle hContent, int* pnBytesDownloaded, int* pnBytesExpected) => Instance.GetUGCDownloadProgress(hContent, pnBytesDownloaded, pnBytesExpected);
        /// <summary></summary>
        public static bool GetUGCDetails(UGCHandle hContent, AppId* pnAppID, char** ppchName, int* pnFileSizeInBytes, SteamId* pSteamIDOwner) => Instance.GetUGCDetails(hContent, pnAppID, ppchName, pnFileSizeInBytes, pSteamIDOwner);
        /// <summary></summary>
        public static int UGCRead(UGCHandle hContent, void* pvData, int cubDataToRead, uint cOffset, UGCReadAction eAction) => Instance.UGCRead(hContent, pvData, cubDataToRead, cOffset, eAction);
        /// <summary></summary>
        public static int GetCachedUGCCount() => Instance.GetCachedUGCCount();
        /// <summary></summary>
        public static UGCHandle GetCachedUGCHandle(int iCachedContent) => Instance.GetCachedUGCHandle(iCachedContent);
        /// <summary></summary>
        public static SteamAPICall PublishWorkshopFile(UTF8StringPtr pchFile, UTF8StringPtr pchPreviewFile, AppId nConsumerAppId, UTF8StringPtr pchTitle, UTF8StringPtr pchDescription, RemoteStoragePublishedFileVisibility eVisibility, SteamParamStringArray* pTags, WorkshopFileType eWorkshopFileType) => Instance.PublishWorkshopFile(pchFile, pchPreviewFile, nConsumerAppId, pchTitle, pchDescription, eVisibility, pTags, eWorkshopFileType);
        /// <summary></summary>
        public static PublishedFileUpdateHandle CreatePublishedFileUpdateRequest(PublishedFileId unPublishedFileId) => Instance.CreatePublishedFileUpdateRequest(unPublishedFileId);
        /// <summary></summary>
        public static bool UpdatePublishedFileFile(PublishedFileUpdateHandle updateHandle, UTF8StringPtr pchFile) => Instance.UpdatePublishedFileFile(updateHandle, pchFile);
        /// <summary></summary>
        public static bool UpdatePublishedFilePreviewFile(PublishedFileUpdateHandle updateHandle, UTF8StringPtr pchPreviewFile) => Instance.UpdatePublishedFilePreviewFile(updateHandle, pchPreviewFile);
        /// <summary></summary>
        public static bool UpdatePublishedFileTitle(PublishedFileUpdateHandle updateHandle, UTF8StringPtr pchTitle) => Instance.UpdatePublishedFileTitle(updateHandle, pchTitle);
        /// <summary></summary>
        public static bool UpdatePublishedFileDescription(PublishedFileUpdateHandle updateHandle, UTF8StringPtr pchDescription) => Instance.UpdatePublishedFileDescription(updateHandle, pchDescription);
        /// <summary></summary>
        public static bool UpdatePublishedFileVisibility(PublishedFileUpdateHandle updateHandle, RemoteStoragePublishedFileVisibility eVisibility) => Instance.UpdatePublishedFileVisibility(updateHandle, eVisibility);
        /// <summary></summary>
        public static bool UpdatePublishedFileTags(PublishedFileUpdateHandle updateHandle, SteamParamStringArray* pTags) => Instance.UpdatePublishedFileTags(updateHandle, pTags);
        /// <summary></summary>
        public static SteamAPICall CommitPublishedFileUpdate(PublishedFileUpdateHandle updateHandle) => Instance.CommitPublishedFileUpdate(updateHandle);
        /// <summary></summary>
        public static SteamAPICall GetPublishedFileDetails(PublishedFileId unPublishedFileId, uint unMaxSecondsOld) => Instance.GetPublishedFileDetails(unPublishedFileId, unMaxSecondsOld);
        /// <summary></summary>
        public static SteamAPICall DeletePublishedFile(PublishedFileId unPublishedFileId) => Instance.DeletePublishedFile(unPublishedFileId);
        /// <summary></summary>
        public static SteamAPICall EnumerateUserPublishedFiles(uint unStartIndex) => Instance.EnumerateUserPublishedFiles(unStartIndex);
        /// <summary></summary>
        public static SteamAPICall SubscribePublishedFile(PublishedFileId unPublishedFileId) => Instance.SubscribePublishedFile(unPublishedFileId);
        /// <summary></summary>
        public static SteamAPICall EnumerateUserSubscribedFiles(uint unStartIndex) => Instance.EnumerateUserSubscribedFiles(unStartIndex);
        /// <summary></summary>
        public static SteamAPICall UnsubscribePublishedFile(PublishedFileId unPublishedFileId) => Instance.UnsubscribePublishedFile(unPublishedFileId);
        /// <summary></summary>
        public static bool UpdatePublishedFileSetChangeDescription(PublishedFileUpdateHandle updateHandle, UTF8StringPtr pchChangeDescription) => Instance.UpdatePublishedFileSetChangeDescription(updateHandle, pchChangeDescription);
        /// <summary></summary>
        public static SteamAPICall GetPublishedItemVoteDetails(PublishedFileId unPublishedFileId) => Instance.GetPublishedItemVoteDetails(unPublishedFileId);
        /// <summary></summary>
        public static SteamAPICall UpdateUserPublishedItemVote(PublishedFileId unPublishedFileId, bool bVoteUp) => Instance.UpdateUserPublishedItemVote(unPublishedFileId, bVoteUp);
        /// <summary></summary>
        public static SteamAPICall GetUserPublishedItemVoteDetails(PublishedFileId unPublishedFileId) => Instance.GetUserPublishedItemVoteDetails(unPublishedFileId);
        /// <summary></summary>
        public static SteamAPICall EnumerateUserSharedWorkshopFiles(SteamId steamId, uint unStartIndex, SteamParamStringArray* pRequiredTags, SteamParamStringArray* pExcludedTags) => Instance.EnumerateUserSharedWorkshopFiles(steamId, unStartIndex, pRequiredTags, pExcludedTags);
        /// <summary></summary>
        public static SteamAPICall PublishVideo(WorkshopVideoProvider eVideoProvider, UTF8StringPtr pchVideoAccount, UTF8StringPtr pchVideoIdentifier, UTF8StringPtr pchPreviewFile, AppId nConsumerAppId, UTF8StringPtr pchTitle, UTF8StringPtr pchDescription, RemoteStoragePublishedFileVisibility eVisibility, SteamParamStringArray* pTags) => Instance.PublishVideo(eVideoProvider, pchVideoAccount, pchVideoIdentifier, pchPreviewFile, nConsumerAppId, pchTitle, pchDescription, eVisibility, pTags);
        /// <summary></summary>
        public static SteamAPICall SetUserPublishedFileAction(PublishedFileId unPublishedFileId, WorkshopFileAction eAction) => Instance.SetUserPublishedFileAction(unPublishedFileId, eAction);
        /// <summary></summary>
        public static SteamAPICall EnumeratePublishedFilesByUserAction(WorkshopFileAction eAction, uint unStartIndex) => Instance.EnumeratePublishedFilesByUserAction(eAction, unStartIndex);
        /// <summary></summary>
        public static SteamAPICall EnumeratePublishedWorkshopFiles(WorkshopEnumerationType eEnumerationType, uint unStartIndex, uint unCount, uint unDays, SteamParamStringArray* pTags, SteamParamStringArray* pUserTags) => Instance.EnumeratePublishedWorkshopFiles(eEnumerationType, unStartIndex, unCount, unDays, pTags, pUserTags);
        /// <summary></summary>
        public static SteamAPICall UGCDownloadToLocation(UGCHandle hContent, UTF8StringPtr pchLocation, uint unPriority) => Instance.UGCDownloadToLocation(hContent, pchLocation, unPriority);
        /// <summary></summary>
        public static int GetLocalFileChangeCount() => Instance.GetLocalFileChangeCount();
        /// <summary></summary>
        public static UTF8StringPtr GetLocalFileChange(int iFile, RemoteStorageLocalFileChangeType* pEChangeType, RemoteStorageFilePathType* pEFilePathType) => Instance.GetLocalFileChange(iFile, pEChangeType, pEFilePathType);
        /// <summary></summary>
        public static bool BeginFileWriteBatch() => Instance.BeginFileWriteBatch();
        /// <summary></summary>
        public static bool EndFileWriteBatch() => Instance.EndFileWriteBatch();
    }
}