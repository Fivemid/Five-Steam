using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>UserAchievementIconFetched_t</summary>
    public unsafe struct UserAchievementIconFetched
    {
        /// <summary>CGameID m_nGameID</summary>
        public GameId nGameID;
        /// <summary>char [128] m_rgchAchievementName</summary>
        public UTF8String128 rgchAchievementName;
        /// <summary>bool m_bAchieved</summary>
        public bool bAchieved;
        /// <summary>int m_nIconHandle</summary>
        public int nIconHandle;
    }
}