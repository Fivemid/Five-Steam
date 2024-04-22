using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Specifies an items state. These are flags that can be combined. Returned by <a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetItemState" class="bb_apilink">ISteamUGC::GetItemState</a>.<br />
    /// <br />
    /// </summary>
    public enum ItemState : int
    {
        /// <summary>The item is not tracked on client.</summary>
        None = 0,
        /// <summary>The current user is subscribed to this item. Not just cached.</summary>
        Subscribed = 1,
        /// <summary>The item was created with the old workshop functions in <a href="https://partner.steamgames.com/doc/api/ISteamRemoteStorage" class="bb_apilink">ISteamRemoteStorage</a>.</summary>
        LegacyItem = 2,
        /// <summary>Item is installed and usable (but maybe out of date).</summary>
        Installed = 4,
        /// <summary>The item needs an update. Either because it's not installed yet or creator updated the content.</summary>
        NeedsUpdate = 8,
        /// <summary>The item update is currently downloading.</summary>
        Downloading = 16,
        /// <summary><a href="https://partner.steamgames.com/doc/api/ISteamUGC#DownloadItem" class="bb_apilink">ISteamUGC::DownloadItem</a> was called for this item, the content isn't available until <a href="https://partner.steamgames.com/doc/api/ISteamUGC#DownloadItemResult_t" class="bb_apilink">DownloadItemResult_t</a> is fired.</summary>
        DownloadPending = 32,
        /// missing documentation for EItemState.k_EItemStateDisabledLocally
        DisabledLocally = 64
    }
}