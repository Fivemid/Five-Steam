using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamUGCDetails_t</summary>
    public unsafe struct SteamUGCDetails
    {
        /// <summary>PublishedFileId_t m_nPublishedFileId</summary>
        public PublishedFileId nPublishedFileId;
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>EWorkshopFileType m_eFileType</summary>
        public WorkshopFileType eFileType;
        /// <summary>AppId_t m_nCreatorAppID</summary>
        public AppId nCreatorAppID;
        /// <summary>AppId_t m_nConsumerAppID</summary>
        public AppId nConsumerAppID;
        /// <summary>char [129] m_rgchTitle</summary>
        public UTF8String129 rgchTitle;
        /// <summary>char [8000] m_rgchDescription</summary>
        public UTF8String8000 rgchDescription;
        /// <summary>uint64 m_ulSteamIDOwner</summary>
        public ulong ulSteamIDOwner;
        /// <summary>uint32 m_rtimeCreated</summary>
        public uint rtimeCreated;
        /// <summary>uint32 m_rtimeUpdated</summary>
        public uint rtimeUpdated;
        /// <summary>uint32 m_rtimeAddedToUserList</summary>
        public uint rtimeAddedToUserList;
        /// <summary>ERemoteStoragePublishedFileVisibility m_eVisibility</summary>
        public RemoteStoragePublishedFileVisibility eVisibility;
        /// <summary>bool m_bBanned</summary>
        public bool bBanned;
        /// <summary>bool m_bAcceptedForUse</summary>
        public bool bAcceptedForUse;
        /// <summary>bool m_bTagsTruncated</summary>
        public bool bTagsTruncated;
        /// <summary>char [1025] m_rgchTags</summary>
        public UTF8String1025 rgchTags;
        /// <summary>UGCHandle_t m_hFile</summary>
        public UGCHandle hFile;
        /// <summary>UGCHandle_t m_hPreviewFile</summary>
        public UGCHandle hPreviewFile;
        /// <summary>char [260] m_pchFileName</summary>
        public UTF8String260 pchFileName;
        /// <summary>int32 m_nFileSize</summary>
        public int nFileSize;
        /// <summary>int32 m_nPreviewFileSize</summary>
        public int nPreviewFileSize;
        /// <summary>char [256] m_rgchURL</summary>
        public UTF8String256 rgchURL;
        /// <summary>uint32 m_unVotesUp</summary>
        public uint unVotesUp;
        /// <summary>uint32 m_unVotesDown</summary>
        public uint unVotesDown;
        /// <summary>float m_flScore</summary>
        public float flScore;
        /// <summary>uint32 m_unNumChildren</summary>
        public uint unNumChildren;
    }
}