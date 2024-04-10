using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>UserStatsStored_t</summary>
    public unsafe struct UserStatsStored
    {
        /// <summary>uint64 m_nGameID</summary>
        public ulong nGameID;
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
    }
}