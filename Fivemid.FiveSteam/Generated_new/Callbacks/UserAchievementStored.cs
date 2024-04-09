using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>UserAchievementStored_t</summary>
    public unsafe struct UserAchievementStored
    {
        /// <summary>uint64 m_nGameID</summary>
        public ulong nGameID;
        /// <summary>bool m_bGroupAchievement</summary>
        public bool bGroupAchievement;
        /// <summary>char [128] m_rgchAchievementName</summary>
        public UTF8String128 rgchAchievementName;
        /// <summary>uint32 m_nCurProgress</summary>
        public uint nCurProgress;
        /// <summary>uint32 m_nMaxProgress</summary>
        public uint nMaxProgress;
    }
}