using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>RemoteStorageEnumerateUserSubscribedFilesResult_t</summary>
    public unsafe struct RemoteStorageEnumerateUserSubscribedFilesResult
    {
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>int32 m_nResultsReturned</summary>
        public int nResultsReturned;
        /// <summary>int32 m_nTotalResultCount</summary>
        public int nTotalResultCount;
        /// <summary>PublishedFileId_t [50] m_rgPublishedFileId</summary>
        public FixedArray_ulong50 rgPublishedFileId;
        /// <summary>uint32 [50] m_rgRTimeSubscribed</summary>
        public FixedArray_uint50 rgRTimeSubscribed;
    }
}