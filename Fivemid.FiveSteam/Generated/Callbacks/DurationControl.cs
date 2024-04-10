using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>DurationControl_t</summary>
    public unsafe struct DurationControl
    {
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>AppId_t m_appid</summary>
        public AppId appid;
        /// <summary>bool m_bApplicable</summary>
        public bool bApplicable;
        /// <summary>int32 m_csecsLast5h</summary>
        public int csecsLast5h;
        /// <summary>EDurationControlProgress m_progress</summary>
        public DurationControlProgress progress;
        /// <summary>EDurationControlNotification m_notification</summary>
        public DurationControlNotification notification;
        /// <summary>int32 m_csecsToday</summary>
        public int csecsToday;
        /// <summary>int32 m_csecsRemaining</summary>
        public int csecsRemaining;
    }
}