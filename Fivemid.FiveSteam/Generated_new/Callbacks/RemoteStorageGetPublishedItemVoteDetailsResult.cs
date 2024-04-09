using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>RemoteStorageGetPublishedItemVoteDetailsResult_t</summary>
    public unsafe struct RemoteStorageGetPublishedItemVoteDetailsResult
    {
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>PublishedFileId_t m_unPublishedFileId</summary>
        public PublishedFileId unPublishedFileId;
        /// <summary>int32 m_nVotesFor</summary>
        public int nVotesFor;
        /// <summary>int32 m_nVotesAgainst</summary>
        public int nVotesAgainst;
        /// <summary>int32 m_nReports</summary>
        public int nReports;
        /// <summary>float m_fScore</summary>
        public float fScore;
    }
}