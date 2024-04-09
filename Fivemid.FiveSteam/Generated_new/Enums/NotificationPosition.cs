using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ENotificationPosition</summary>
    public enum NotificationPosition : int
    {
        /// <summary>k_EPositionInvalid</summary>
        PositionInvalid = -1,
        /// <summary>k_EPositionTopLeft</summary>
        PositionTopLeft = 0,
        /// <summary>k_EPositionTopRight</summary>
        PositionTopRight = 1,
        /// <summary>k_EPositionBottomLeft</summary>
        PositionBottomLeft = 2,
        /// <summary>k_EPositionBottomRight</summary>
        PositionBottomRight = 3
    }
}