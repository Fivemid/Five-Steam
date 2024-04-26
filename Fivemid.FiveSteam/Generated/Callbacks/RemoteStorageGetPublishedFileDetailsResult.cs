using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Deprecated - Only used with the deprecated RemoteStorage based Workshop API.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#GetPublishedFileDetails" class="bb_apilink">ISteamRemoteStorage::GetPublishedFileDetails</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct RemoteStorageGetPublishedFileDetailsResult : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.RemoteStorageGetPublishedFileDetailsResult;
        /// <summary>The result of the operation.</summary>
        public Result eResult;
        /// <summary></summary>
        public PublishedFileId nPublishedFileId;
        /// <summary>ID of the app that created this file.</summary>
        public AppId nCreatorAppID;
        /// <summary>ID of the app that will consume this file.</summary>
        public AppId nConsumerAppID;
        /// <summary>title of document</summary>
        public UTF8String129 rgchTitle;
        /// <summary>description of document</summary>
        public UTF8String8000 rgchDescription;
        /// <summary>The handle of the primary file</summary>
        public UGCHandle hFile;
        /// <summary>The handle of the preview file</summary>
        public UGCHandle hPreviewFile;
        /// <summary>Steam ID of the user who created this content.</summary>
        public ulong ulSteamIDOwner;
        /// <summary>time when the published file was created</summary>
        public uint rtimeCreated;
        /// <summary>time when the published file was last updated</summary>
        public uint rtimeUpdated;
        /// <summary></summary>
        public RemoteStoragePublishedFileVisibility eVisibility;
        /// <summary></summary>
        public bool bBanned;
        /// <summary>comma separated list of all tags associated with this file</summary>
        public UTF8String1025 rgchTags;
        /// <summary>whether the list of tags was too long to be returned in the provided buffer</summary>
        public bool bTagsTruncated;
        /// <summary>The name of the primary file</summary>
        public UTF8String260 pchFileName;
        /// <summary>Size of the primary file</summary>
        public int nFileSize;
        /// <summary>Size of the preview file</summary>
        public int nPreviewFileSize;
        /// <summary>URL (for a video or a website)</summary>
        public UTF8String256 rgchURL;
        /// <summary>Type of the file</summary>
        public WorkshopFileType eFileType;
        /// <summary>developer has specifically flagged this item as accepted in the Workshop</summary>
        public bool bAcceptedForUse;
    }
}