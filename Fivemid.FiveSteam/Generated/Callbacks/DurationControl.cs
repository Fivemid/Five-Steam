using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// <br />
    /// Sent for games with enabled anti indulgence / duration control, for enabled users. Lets the game
    /// know whether the feature applies to the user, whether the user needs to exit the game soon, and the
    /// remaining daily playtime for the user.<br />
    /// <br />
    /// This callback is fired asynchronously in response to timers triggering. It is also fired in response
    /// to calls to GetDurationControl().<br />
    /// <br />
    /// 
    /// <br />
    /// <b>Associated Functions:</b>
    /// <a href="https://partner.steamgames.com/doc/api/ISteamUser#GetDurationControl" class="bb_apilink">ISteamUser::GetDurationControl</a>
    /// </summary>
    public unsafe struct DurationControl : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.DurationControl;
        /// <summary>result of call (always k_EResultOK for asynchronous timer-based notifications)</summary>
        public Result eResult;
        /// <summary>appid generating playtime</summary>
        public AppId appid;
        /// <summary>is duration control applicable to user + game combination</summary>
        public bool bApplicable;
        /// <summary>playtime in trailing 5 hour window plus current session, in seconds</summary>
        public int csecsLast5h;
        /// <summary>Description of whether the game should exit</summary>
        public DurationControlProgress progress;
        /// <summary>
        ///             notification to show, if any (always k_EDurationControlNotification_None for API calls)
        ///         </summary>
        public DurationControlNotification notification;
        /// missing documentation for DurationControl_t.m_csecsToday
        public int csecsToday;
        /// missing documentation for DurationControl_t.m_csecsRemaining
        public int csecsRemaining;
    }
}