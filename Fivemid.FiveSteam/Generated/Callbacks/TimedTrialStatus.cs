using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>TimedTrialStatus_t</summary>
    public unsafe struct TimedTrialStatus
    {
        /// <summary>AppId_t m_unAppID</summary>
        public AppId unAppID;
        /// <summary>bool m_bIsOffline</summary>
        public bool bIsOffline;
        /// <summary>uint32 m_unSecondsAllowed</summary>
        public uint unSecondsAllowed;
        /// <summary>uint32 m_unSecondsPlayed</summary>
        public uint unSecondsPlayed;
    }
}