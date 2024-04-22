using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Describes the online/offline play state of a game. Currently this is only used to support the game being able to prevent steam from exiting the game automatically when the user's playtime is consumed. If the game calls BSetDurationControlOnlineState(k_EDurationControlOnlineState_OnlineHighPri) then Steam will not force exit the game - in this case it is up to the game to do so! Steam will continue to send DurationControl_t notifications to the game. If the game later calls BSetDurationControlOnlineState to remove the OnlineHighPri state, then Steam will force exit the game soon thereafter.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b><br />
    /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#GetDurationControl" class="bb_apilink">ISteamUser::GetDurationControl</a><br />
    /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#BSetDurationControlOnlineState" class="bb_apilink">ISteamUser::BSetDurationControlOnlineState</a></summary>
    public enum DurationControlOnlineState : int
    {
        /// missing documentation for EDurationControlOnlineState.k_EDurationControlOnlineState_Invalid
        Invalid = 0,
        /// <summary>Offline play</summary>
        Offline = 1,
        /// <summary>Online play</summary>
        Online = 2,
        /// <summary>Online play - game requests that steam not force exit the game</summary>
        OnlineHighPri = 3
    }
}