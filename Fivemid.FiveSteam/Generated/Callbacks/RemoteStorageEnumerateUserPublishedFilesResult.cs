using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>RemoteStorageEnumerateUserPublishedFilesResult_t</summary>
    public unsafe struct RemoteStorageEnumerateUserPublishedFilesResult
    {
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>int32 m_nResultsReturned</summary>
        public int nResultsReturned;
        /// <summary>int32 m_nTotalResultCount</summary>
        public int nTotalResultCount;
        /// <summary>PublishedFileId_t [50] m_rgPublishedFileId</summary>
        public FixedArray_ulong50 rgPublishedFileId;
    }
}