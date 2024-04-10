using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>RemoteStorageEnumerateWorkshopFilesResult_t</summary>
    public unsafe struct RemoteStorageEnumerateWorkshopFilesResult
    {
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>int32 m_nResultsReturned</summary>
        public int nResultsReturned;
        /// <summary>int32 m_nTotalResultCount</summary>
        public int nTotalResultCount;
        /// <summary>PublishedFileId_t [50] m_rgPublishedFileId</summary>
        public FixedArray_ulong50 rgPublishedFileId;
        /// <summary>float [50] m_rgScore</summary>
        public FixedArray_float50 rgScore;
        /// <summary>AppId_t m_nAppId</summary>
        public AppId nAppId;
        /// <summary>uint32 m_unStartIndex</summary>
        public uint unStartIndex;
    }
}