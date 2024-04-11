using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>GSClientAchievementStatus_t</summary>
    public unsafe struct GSClientAchievementStatus : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.GSClientAchievementStatus;
        /// <summary>uint64 m_SteamID</summary>
        public ulong SteamID;
        /// <summary>char [128] m_pchAchievement</summary>
        public UTF8String128 pchAchievement;
        /// <summary>bool m_bUnlocked</summary>
        public bool bUnlocked;
    }
}