using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>RemoveAppDependencyResult_t</summary>
    public unsafe struct RemoveAppDependencyResult
    {
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>PublishedFileId_t m_nPublishedFileId</summary>
        public PublishedFileId nPublishedFileId;
        /// <summary>AppId_t m_nAppID</summary>
        public AppId nAppID;
    }
}