using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Flags that specify the type of preview an item has. Set with
    /// <a href="https://partner.steamgames.com/doc/api/ISteamUGC#AddItemPreviewFile" class="bb_apilink">ISteamUGC::AddItemPreviewFile</a>, and received with
    /// <a href="https://partner.steamgames.com/doc/api/ISteamUGC#GetQueryUGCAdditionalPreview" class="bb_apilink">ISteamUGC::GetQueryUGCAdditionalPreview</a>.<br />
    /// <br />
    /// 
    /// </summary>
    public enum ItemPreviewType : int
    {
        /// <summary>Standard web viewable image file. Supported types: PNG, JPG, and GIF.</summary>
        Image = 0,
        /// <summary>YouTube video ID. (e.g. "jHgZh4GV9G0")</summary>
        YouTubeVideo = 1,
        /// <summary>Sketchfab model ID.</summary>
        Sketchfab = 2,
        /// <summary>
        ///             Standard image file containing a map of an environment in a horizontal cross layout (see
        ///             below). Supported types: PNG, JPG, and GIF.<br />
        ///             <code>
        ///                 +---+---+-------+ | |Up | | +---+---+---+---+ | L | F | R | B | +---+---+---+---+ |
        ///                 |Dn | | +---+---+---+---+
        ///             </code>
        ///             Not currently used in web views.
        ///         </summary>
        EnvironmentMap_HorizontalCross = 3,
        /// <summary>
        ///             Standard image file containing a map of an environment in a LatLong layout. Supported
        ///             types: PNG, JPG, and GIF. Not currently used in web views.
        ///         </summary>
        EnvironmentMap_LatLong = 4,
        /// missing documentation for EItemPreviewType.k_EItemPreviewType_Clip
        Clip = 5,
        /// <summary>Reserved. You can specify your own types above this value.</summary>
        ReservedMax = 255
    }
}