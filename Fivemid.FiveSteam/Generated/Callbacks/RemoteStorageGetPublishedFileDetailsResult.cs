using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>RemoteStorageGetPublishedFileDetailsResult_t</summary>
    public unsafe struct RemoteStorageGetPublishedFileDetailsResult : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.RemoteStorageGetPublishedFileDetailsResult;
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>PublishedFileId_t m_nPublishedFileId</summary>
        public PublishedFileId nPublishedFileId;
        /// <summary>AppId_t m_nCreatorAppID</summary>
        public AppId nCreatorAppID;
        /// <summary>AppId_t m_nConsumerAppID</summary>
        public AppId nConsumerAppID;
        /// <summary>char [129] m_rgchTitle</summary>
        public UTF8String129 rgchTitle;
        /// <summary>char [8000] m_rgchDescription</summary>
        public UTF8String8000 rgchDescription;
        /// <summary>UGCHandle_t m_hFile</summary>
        public UGCHandle hFile;
        /// <summary>UGCHandle_t m_hPreviewFile</summary>
        public UGCHandle hPreviewFile;
        /// <summary>uint64 m_ulSteamIDOwner</summary>
        public ulong ulSteamIDOwner;
        /// <summary>uint32 m_rtimeCreated</summary>
        public uint rtimeCreated;
        /// <summary>uint32 m_rtimeUpdated</summary>
        public uint rtimeUpdated;
        /// <summary>ERemoteStoragePublishedFileVisibility m_eVisibility</summary>
        public RemoteStoragePublishedFileVisibility eVisibility;
        /// <summary>bool m_bBanned</summary>
        public bool bBanned;
        /// <summary>char [1025] m_rgchTags</summary>
        public UTF8String1025 rgchTags;
        /// <summary>bool m_bTagsTruncated</summary>
        public bool bTagsTruncated;
        /// <summary>char [260] m_pchFileName</summary>
        public UTF8String260 pchFileName;
        /// <summary>int32 m_nFileSize</summary>
        public int nFileSize;
        /// <summary>int32 m_nPreviewFileSize</summary>
        public int nPreviewFileSize;
        /// <summary>char [256] m_rgchURL</summary>
        public UTF8String256 rgchURL;
        /// <summary>EWorkshopFileType m_eFileType</summary>
        public WorkshopFileType eFileType;
        /// <summary>bool m_bAcceptedForUse</summary>
        public bool bAcceptedForUse;
    }
}