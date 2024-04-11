using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>RemoveUGCDependencyResult_t</summary>
    public unsafe struct RemoveUGCDependencyResult : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.RemoveUGCDependencyResult;
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>PublishedFileId_t m_nPublishedFileId</summary>
        public PublishedFileId nPublishedFileId;
        /// <summary>PublishedFileId_t m_nChildPublishedFileId</summary>
        public PublishedFileId nChildPublishedFileId;
    }
}