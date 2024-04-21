using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Describes which notification timer has expired, for steam china duration control feature. Some of
    /// these notifications are deprecated and are no longer sent.<br />
    /// <br />
    /// 
    /// <br />
    /// <b>Associated Functions:</b><br />
    /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#GetDurationControl" class="bb_apilink">ISteamUser::GetDurationControl</a><br />
    /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#BSetDurationControlOnlineState" class="bb_apilink">ISteamUser::BSetDurationControlOnlineState</a>
    /// </summary>
    public enum DurationControlNotification : int
    {
        /// <summary>Callback is just informing you about progress, no notification to show</summary>
        None = 0,
        /// <summary>
        ///             player has been playing for an hour - game can show something at this time if desired
        ///         </summary>
        _1Hour = 1,
        /// <summary>(deprecated)</summary>
        _3Hours = 2,
        /// <summary>(deprecated)</summary>
        HalfProgress = 3,
        /// missing documentation for EDurationControlNotification.k_EDurationControlNotification_NoProgress
        NoProgress = 4,
        /// <summary>player has been playing for the allowed time and should exit the game</summary>
        ExitSoon_3h = 5,
        /// <summary>player has been playing for the allowed time and should exit the game</summary>
        ExitSoon_5h = 6,
        /// <summary>
        ///             player has been playing until the locally allowed time of day (10PM) and should exit the
        ///             game
        ///         </summary>
        ExitSoon_Night = 7
    }
}