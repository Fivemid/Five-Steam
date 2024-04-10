using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>GetUserItemVoteResult_t</summary>
    public unsafe struct GetUserItemVoteResult
    {
        /// <summary>PublishedFileId_t m_nPublishedFileId</summary>
        public PublishedFileId nPublishedFileId;
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>bool m_bVotedUp</summary>
        public bool bVotedUp;
        /// <summary>bool m_bVotedDown</summary>
        public bool bVotedDown;
        /// <summary>bool m_bVoteSkipped</summary>
        public bool bVoteSkipped;
    }
}