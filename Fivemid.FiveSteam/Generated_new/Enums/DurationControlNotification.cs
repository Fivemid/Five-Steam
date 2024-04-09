using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EDurationControlNotification</summary>
    public enum DurationControlNotification : int
    {
        /// <summary>k_EDurationControlNotification_None</summary>
        None = 0,
        /// <summary>k_EDurationControlNotification_1Hour</summary>
        _1Hour = 1,
        /// <summary>k_EDurationControlNotification_3Hours</summary>
        _3Hours = 2,
        /// <summary>k_EDurationControlNotification_HalfProgress</summary>
        HalfProgress = 3,
        /// <summary>k_EDurationControlNotification_NoProgress</summary>
        NoProgress = 4,
        /// <summary>k_EDurationControlNotification_ExitSoon_3h</summary>
        ExitSoon_3h = 5,
        /// <summary>k_EDurationControlNotification_ExitSoon_5h</summary>
        ExitSoon_5h = 6,
        /// <summary>k_EDurationControlNotification_ExitSoon_Night</summary>
        ExitSoon_Night = 7
    }
}