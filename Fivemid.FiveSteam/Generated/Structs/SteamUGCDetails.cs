using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Details for a single published item/UGC. This is returned by
    /// <a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetQueryUGCResult" class="bb_apilink">ISteamUGC::GetQueryUGCResult</a>.<br />
    /// <br />
    /// 
    /// </summary>
    public unsafe struct SteamUGCDetails
    {
        /// <summary>The globally unique item handle to this piece of UGC.</summary>
        public PublishedFileId nPublishedFileId;
        /// <summary>The result of the operation.</summary>
        public Result eResult;
        /// <summary>The type of the item.</summary>
        public WorkshopFileType eFileType;
        /// <summary>App Id of the app that created this item.</summary>
        public AppId nCreatorAppID;
        /// <summary>App Id of the app that will consume this item.</summary>
        public AppId nConsumerAppID;
        /// <summary>The title of the item.</summary>
        public UTF8String129 rgchTitle;
        /// <summary>The description of the item.</summary>
        public UTF8String8000 rgchDescription;
        /// <summary>Steam ID of the user who created this content.</summary>
        public ulong ulSteamIDOwner;
        /// <summary>
        ///             Time when the published item was created, provided in Unix epoch format (time since Jan
        ///             1st, 1970).
        ///         </summary>
        public uint rtimeCreated;
        /// <summary>
        ///             Time when the published item was last updated, provided in Unix epoch format (time since
        ///             Jan 1st, 1970).
        ///         </summary>
        public uint rtimeUpdated;
        /// <summary>
        ///             Time when the user added the published item to their list (not always applicable),
        ///             provided in Unix epoch format (time since Jan 1st, 1970).
        ///         </summary>
        public uint rtimeAddedToUserList;
        /// <summary>The visibility of the item.</summary>
        public RemoteStoragePublishedFileVisibility eVisibility;
        /// <summary>Whether the item was banned.</summary>
        public bool bBanned;
        /// <summary>
        ///             Whether the developer of this app has specifically flagged this item as accepted in the
        ///             Workshop. (See:
        ///             <a href="https://partner.steamgames.com/doc/features/workshop#curated_workshop" class="bb_doclink">Curated Workshop</a>)
        ///         </summary>
        public bool bAcceptedForUse;
        /// <summary>
        ///             Whether the list of tags was too long to be returned in the provided buffer, and were
        ///             therefore truncated.
        ///         </summary>
        public bool bTagsTruncated;
        /// <summary>Comma separated list of all tags associated with this item.</summary>
        public UTF8String1025 rgchTags;
        /// <summary>The handle of the primary file.</summary>
        public UGCHandle hFile;
        /// <summary>The handle of the preview file.</summary>
        public UGCHandle hPreviewFile;
        /// <summary>The cloud filename of the primary file.</summary>
        public UTF8String260 pchFileName;
        /// <summary>The file size of the primary file.</summary>
        public int nFileSize;
        /// <summary>The file size of the preview file.</summary>
        public int nPreviewFileSize;
        /// <summary>The URL associated with this item. (For a video or a website.)</summary>
        public UTF8String256 rgchURL;
        /// <summary>Number of votes up.</summary>
        public uint unVotesUp;
        /// <summary>Number of votes down.</summary>
        public uint unVotesDown;
        /// <summary>The bayesian average for up votes / total votes, between [0,1].</summary>
        public float flScore;
        /// <summary>
        ///             The number of items in the collection if <b>m_eFileType</b> is
        ///             <code class="bb_code bb_code_inline nohighlight">k_EWorkshopFileTypeCollection</code>,
        ///             or the number of items this specific item has a dependency on (see
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamUGC#AddDependency" class="bb_apilink">ISteamUGC::AddDependency</a>).
        ///         </summary>
        public uint unNumChildren;
    }
}