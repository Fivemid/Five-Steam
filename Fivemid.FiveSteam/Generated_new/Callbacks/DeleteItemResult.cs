using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>DeleteItemResult_t</summary>
    public unsafe struct DeleteItemResult
    {
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>PublishedFileId_t m_nPublishedFileId</summary>
        public PublishedFileId nPublishedFileId;
    }
}