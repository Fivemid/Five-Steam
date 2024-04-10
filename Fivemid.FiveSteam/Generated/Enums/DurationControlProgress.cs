using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EDurationControlProgress</summary>
    public enum DurationControlProgress : int
    {
        /// <summary>k_EDurationControlProgress_Full</summary>
        Full = 0,
        /// <summary>k_EDurationControlProgress_Half</summary>
        Half = 1,
        /// <summary>k_EDurationControlProgress_None</summary>
        None = 2,
        /// <summary>k_EDurationControl_ExitSoon_3h</summary>
        DurationControl_ExitSoon_3h = 3,
        /// <summary>k_EDurationControl_ExitSoon_5h</summary>
        DurationControl_ExitSoon_5h = 4,
        /// <summary>k_EDurationControl_ExitSoon_Night</summary>
        DurationControl_ExitSoon_Night = 5
    }
}