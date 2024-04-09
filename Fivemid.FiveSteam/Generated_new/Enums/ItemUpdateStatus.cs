using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EItemUpdateStatus</summary>
    public enum ItemUpdateStatus : int
    {
        /// <summary>k_EItemUpdateStatusInvalid</summary>
        Invalid = 0,
        /// <summary>k_EItemUpdateStatusPreparingConfig</summary>
        PreparingConfig = 1,
        /// <summary>k_EItemUpdateStatusPreparingContent</summary>
        PreparingContent = 2,
        /// <summary>k_EItemUpdateStatusUploadingContent</summary>
        UploadingContent = 3,
        /// <summary>k_EItemUpdateStatusUploadingPreviewFile</summary>
        UploadingPreviewFile = 4,
        /// <summary>k_EItemUpdateStatusCommittingChanges</summary>
        CommittingChanges = 5
    }
}