using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ETimelineGameMode</summary>
    public enum TimelineGameMode : int
    {
        /// <summary>k_ETimelineGameMode_Invalid</summary>
        Invalid = 0,
        /// <summary>k_ETimelineGameMode_Playing</summary>
        Playing = 1,
        /// <summary>k_ETimelineGameMode_Staging</summary>
        Staging = 2,
        /// <summary>k_ETimelineGameMode_Menus</summary>
        Menus = 3,
        /// <summary>k_ETimelineGameMode_LoadingScreen</summary>
        LoadingScreen = 4,
        /// <summary>k_ETimelineGameMode_Max</summary>
        Max = 5
    }
}