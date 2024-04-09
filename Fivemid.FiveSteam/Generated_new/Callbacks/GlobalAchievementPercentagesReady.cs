using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>GlobalAchievementPercentagesReady_t</summary>
    public unsafe struct GlobalAchievementPercentagesReady
    {
        /// <summary>uint64 m_nGameID</summary>
        public ulong nGameID;
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
    }
}