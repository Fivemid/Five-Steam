using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>RemoteStorageEnumeratePublishedFilesByUserActionResult_t</summary>
    public unsafe struct RemoteStorageEnumeratePublishedFilesByUserActionResult : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.RemoteStorageEnumeratePublishedFilesByUserActionResult;
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>EWorkshopFileAction m_eAction</summary>
        public WorkshopFileAction eAction;
        /// <summary>int32 m_nResultsReturned</summary>
        public int nResultsReturned;
        /// <summary>int32 m_nTotalResultCount</summary>
        public int nTotalResultCount;
        /// <summary>PublishedFileId_t [50] m_rgPublishedFileId</summary>
        public FixedArray_ulong50 rgPublishedFileId;
        /// <summary>uint32 [50] m_rgRTimeUpdated</summary>
        public FixedArray_uint50 rgRTimeUpdated;
    }
}