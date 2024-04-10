using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EItemPreviewType</summary>
    public enum ItemPreviewType : int
    {
        /// <summary>k_EItemPreviewType_Image</summary>
        Image = 0,
        /// <summary>k_EItemPreviewType_YouTubeVideo</summary>
        YouTubeVideo = 1,
        /// <summary>k_EItemPreviewType_Sketchfab</summary>
        Sketchfab = 2,
        /// <summary>k_EItemPreviewType_EnvironmentMap_HorizontalCross</summary>
        EnvironmentMap_HorizontalCross = 3,
        /// <summary>k_EItemPreviewType_EnvironmentMap_LatLong</summary>
        EnvironmentMap_LatLong = 4,
        /// <summary>k_EItemPreviewType_Clip</summary>
        Clip = 5,
        /// <summary>k_EItemPreviewType_ReservedMax</summary>
        ReservedMax = 255
    }
}