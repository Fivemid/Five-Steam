using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>RemoteStorageSubscribePublishedFileResult_t</summary>
    public unsafe struct RemoteStorageSubscribePublishedFileResult
    {
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>PublishedFileId_t m_nPublishedFileId</summary>
        public PublishedFileId nPublishedFileId;
    }
}