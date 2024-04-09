using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>CreateItemResult_t</summary>
    public unsafe struct CreateItemResult
    {
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>PublishedFileId_t m_nPublishedFileId</summary>
        public PublishedFileId nPublishedFileId;
        /// <summary>bool m_bUserNeedsToAcceptWorkshopLegalAgreement</summary>
        public bool bUserNeedsToAcceptWorkshopLegalAgreement;
    }
}