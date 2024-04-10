using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>WorkshopEULAStatus_t</summary>
    public unsafe struct WorkshopEULAStatus
    {
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>AppId_t m_nAppID</summary>
        public AppId nAppID;
        /// <summary>uint32 m_unVersion</summary>
        public uint unVersion;
        /// <summary>RTime32 m_rtAction</summary>
        public RTime32 rtAction;
        /// <summary>bool m_bAccepted</summary>
        public bool bAccepted;
        /// <summary>bool m_bNeedsAction</summary>
        public bool bNeedsAction;
    }
}