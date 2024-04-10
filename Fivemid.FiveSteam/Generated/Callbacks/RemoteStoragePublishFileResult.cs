using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>RemoteStoragePublishFileResult_t</summary>
    public unsafe struct RemoteStoragePublishFileResult
    {
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>PublishedFileId_t m_nPublishedFileId</summary>
        public PublishedFileId nPublishedFileId;
        /// <summary>bool m_bUserNeedsToAcceptWorkshopLegalAgreement</summary>
        public bool bUserNeedsToAcceptWorkshopLegalAgreement;
    }
}