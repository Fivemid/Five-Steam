using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Deprecated - Only used with the deprecated RemoteStorage based Workshop API.<br />
    /// <br />
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct RemoteStorageUserVoteDetails
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