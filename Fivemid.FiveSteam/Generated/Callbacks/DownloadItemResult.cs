using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>DownloadItemResult_t</summary>
    public unsafe struct DownloadItemResult
    {
        /// <summary>AppId_t m_unAppID</summary>
        public AppId unAppID;
        /// <summary>PublishedFileId_t m_nPublishedFileId</summary>
        public PublishedFileId nPublishedFileId;
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
    }
}