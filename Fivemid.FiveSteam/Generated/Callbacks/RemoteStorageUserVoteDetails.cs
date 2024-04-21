using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Deprecated - Only used with the deprecated RemoteStorage based Workshop API.<br />
    /// <br />
    /// 
    /// </summary>
    public unsafe struct RemoteStorageUserVoteDetails : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.RemoteStorageUserVoteDetails;
        /// <summary>The result of the operation.</summary>
        public Result eResult;
        /// <summary>The published file id</summary>
        public PublishedFileId nPublishedFileId;
        /// <summary>what the user voted</summary>
        public WorkshopVote eVote;
    }
}