using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Describes playtime restrictions that apply for games with duration control / anti-indulgence enabled for minor Steam China users.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b><br />
    /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#GetDurationControl" class="bb_apilink">ISteamUser::GetDurationControl</a><br />
    /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#BSetDurationControlOnlineState" class="bb_apilink">ISteamUser::BSetDurationControlOnlineState</a></summary>
    public enum DurationControlProgress : int
    {
        /// <summary>Normal play</summary>
        Full = 0,
        /// <summary>(This value is deprecated)</summary>
        Half = 1,
        /// <summary>User's playtime has run out. Steam will terminate the game soon</summary>
        None = 2,
        /// missing documentation for EDurationControlProgress.k_EDurationControl_ExitSoon_3h
        DurationControl_ExitSoon_3h = 3,
        /// missing documentation for EDurationControlProgress.k_EDurationControl_ExitSoon_5h
        DurationControl_ExitSoon_5h = 4,
        /// missing documentation for EDurationControlProgress.k_EDurationControl_ExitSoon_Night
        DurationControl_ExitSoon_Night = 5
    }
}