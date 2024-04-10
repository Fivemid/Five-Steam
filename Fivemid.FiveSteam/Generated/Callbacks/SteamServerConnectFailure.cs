using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamServerConnectFailure_t</summary>
    public unsafe struct SteamServerConnectFailure
    {
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>bool m_bStillRetrying</summary>
        public bool bStillRetrying;
    }
}