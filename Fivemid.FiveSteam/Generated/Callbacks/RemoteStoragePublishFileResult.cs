using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Deprecated - Only used with the deprecated RemoteStorage based Workshop API.<br />
    /// <br />
    /// </summary>
    public unsafe struct RemoteStoragePublishFileResult : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.RemoteStoragePublishFileResult;
        /// <summary>The result of the operation.</summary>
        public Result eResult;
        /// <summary></summary>
        public PublishedFileId nPublishedFileId;
        /// <summary></summary>
        public bool bUserNeedsToAcceptWorkshopLegalAgreement;
    }
}