using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>RemoteStorageUserVoteDetails_t</summary>
    public unsafe struct RemoteStorageUserVoteDetails
    {
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>PublishedFileId_t m_nPublishedFileId</summary>
        public PublishedFileId nPublishedFileId;
        /// <summary>EWorkshopVote m_eVote</summary>
        public WorkshopVote eVote;
    }
}