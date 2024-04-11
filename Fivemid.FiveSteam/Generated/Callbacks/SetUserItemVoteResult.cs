using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SetUserItemVoteResult_t</summary>
    public unsafe struct SetUserItemVoteResult : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SetUserItemVoteResult;
        /// <summary>PublishedFileId_t m_nPublishedFileId</summary>
        public PublishedFileId nPublishedFileId;
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>bool m_bVoteUp</summary>
        public bool bVoteUp;
    }
}