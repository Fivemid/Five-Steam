using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Possible positions to have the overlay show notifications in. Used with <a href="https://partner.steamgames.com/doc/api/ISteamUtils#SetOverlayNotificationPosition" class="bb_apilink">ISteamUtils::SetOverlayNotificationPosition</a>.<br />
    /// <br />
    /// </summary>
    public enum NotificationPosition : int
    {
        /// missing documentation for ENotificationPosition.k_EPositionInvalid
        PositionInvalid = -1,
        /// <summary>Top left corner.</summary>
        PositionTopLeft = 0,
        /// <summary>Top right corner.</summary>
        PositionTopRight = 1,
        /// <summary>Bottom left corner.</summary>
        PositionBottomLeft = 2,
        /// <summary>Bottom right corner.</summary>
        PositionBottomRight = 3
    }
}