using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>RemoteStorageDeletePublishedFileResult_t</summary>
    public unsafe struct RemoteStorageDeletePublishedFileResult
    {
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>PublishedFileId_t m_nPublishedFileId</summary>
        public PublishedFileId nPublishedFileId;
    }
}