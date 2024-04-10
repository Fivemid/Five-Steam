using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EItemState</summary>
    public enum ItemState : int
    {
        /// <summary>k_EItemStateNone</summary>
        None = 0,
        /// <summary>k_EItemStateSubscribed</summary>
        Subscribed = 1,
        /// <summary>k_EItemStateLegacyItem</summary>
        LegacyItem = 2,
        /// <summary>k_EItemStateInstalled</summary>
        Installed = 4,
        /// <summary>k_EItemStateNeedsUpdate</summary>
        NeedsUpdate = 8,
        /// <summary>k_EItemStateDownloading</summary>
        Downloading = 16,
        /// <summary>k_EItemStateDownloadPending</summary>
        DownloadPending = 32,
        /// <summary>k_EItemStateDisabledLocally</summary>
        DisabledLocally = 64
    }
}