using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>RemoteStorageSetUserPublishedFileActionResult_t</summary>
    public unsafe struct RemoteStorageSetUserPublishedFileActionResult : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.RemoteStorageSetUserPublishedFileActionResult;
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>PublishedFileId_t m_nPublishedFileId</summary>
        public PublishedFileId nPublishedFileId;
        /// <summary>EWorkshopFileAction m_eAction</summary>
        public WorkshopFileAction eAction;
    }
}