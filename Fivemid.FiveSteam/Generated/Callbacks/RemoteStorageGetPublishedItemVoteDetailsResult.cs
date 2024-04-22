using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Deprecated - Only used with the deprecated RemoteStorage based Workshop API.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#GetPublishedItemVoteDetails" class="bb_apilink">ISteamRemoteStorage::GetPublishedItemVoteDetails</a>, <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage#GetUserPublishedItemVoteDetails" class="bb_apilink">ISteamRemoteStorage::GetUserPublishedItemVoteDetails</a></summary>
    public unsafe struct RemoteStorageGetPublishedItemVoteDetailsResult : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.RemoteStorageGetPublishedItemVoteDetailsResult;
        /// <summary></summary>
        public Result eResult;
        /// <summary></summary>
        public PublishedFileId unPublishedFileId;
        /// <summary></summary>
        public int nVotesFor;
        /// <summary></summary>
        public int nVotesAgainst;
        /// <summary></summary>
        public int nReports;
        /// <summary></summary>
        public float fScore;
    }
}