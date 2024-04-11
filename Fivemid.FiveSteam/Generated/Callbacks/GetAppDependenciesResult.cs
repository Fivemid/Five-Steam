using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>GetAppDependenciesResult_t</summary>
    public unsafe struct GetAppDependenciesResult : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.GetAppDependenciesResult;
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>PublishedFileId_t m_nPublishedFileId</summary>
        public PublishedFileId nPublishedFileId;
        /// <summary>AppId_t [32] m_rgAppIDs</summary>
        public FixedArray_uint32 rgAppIDs;
        /// <summary>uint32 m_nNumAppDependencies</summary>
        public uint nNumAppDependencies;
        /// <summary>uint32 m_nTotalNumAppDependencies</summary>
        public uint nTotalNumAppDependencies;
    }
}