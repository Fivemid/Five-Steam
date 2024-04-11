using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SubmitItemUpdateResult_t</summary>
    public unsafe struct SubmitItemUpdateResult : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SubmitItemUpdateResult;
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>bool m_bUserNeedsToAcceptWorkshopLegalAgreement</summary>
        public bool bUserNeedsToAcceptWorkshopLegalAgreement;
        /// <summary>PublishedFileId_t m_nPublishedFileId</summary>
        public PublishedFileId nPublishedFileId;
    }
}