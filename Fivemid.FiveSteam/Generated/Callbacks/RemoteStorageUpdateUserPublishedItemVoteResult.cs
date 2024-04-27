using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Deprecated - Only used with the deprecated RemoteStorage based Workshop API.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#UpdateUserPublishedItemVote" class="bb_apilink">ISteamRemoteStorage::UpdateUserPublishedItemVote</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct RemoteStorageUpdateUserPublishedItemVoteResult
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.RemoteStorageUpdateUserPublishedItemVoteResult;
        /// <summary>The result of the operation.</summary>
        public Result eResult;
        /// <summary>The published file id</summary>
        public PublishedFileId nPublishedFileId;
    }
}