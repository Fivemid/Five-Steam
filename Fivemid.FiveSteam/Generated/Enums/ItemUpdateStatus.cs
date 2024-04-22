using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Specifies the status of a <a href="https://partner.steamgames.com/doc/api/ISteamUGC#UGCUpdateHandle_t" class="bb_apilink">UGCUpdateHandle_t</a> after a call to <a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetItemUpdateProgress" class="bb_apilink">ISteamUGC::GetItemUpdateProgress</a>, returned by <a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetItemUpdateProgress" class="bb_apilink">ISteamUGC::GetItemUpdateProgress</a>.<br />
    /// <br />
    /// </summary>
    public enum ItemUpdateStatus : int
    {
        /// <summary>The item update handle was invalid, the job might be finished, a <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SubmitItemUpdateResult_t" class="bb_apilink">SubmitItemUpdateResult_t</a> call result should have been returned for it.</summary>
        Invalid = 0,
        /// <summary>The item update is processing configuration data.</summary>
        PreparingConfig = 1,
        /// <summary>The item update is reading and processing content files.</summary>
        PreparingContent = 2,
        /// <summary>The item update is uploading content changes to Steam.</summary>
        UploadingContent = 3,
        /// <summary>The item update is uploading new preview file image.</summary>
        UploadingPreviewFile = 4,
        /// <summary>The item update is committing all changes.</summary>
        CommittingChanges = 5
    }
}