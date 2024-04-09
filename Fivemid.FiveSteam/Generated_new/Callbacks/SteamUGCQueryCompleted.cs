using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamUGCQueryCompleted_t</summary>
    public unsafe struct SteamUGCQueryCompleted
    {
        /// <summary>UGCQueryHandle_t m_handle</summary>
        public UGCQueryHandle handle;
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>uint32 m_unNumResultsReturned</summary>
        public uint unNumResultsReturned;
        /// <summary>uint32 m_unTotalMatchingResults</summary>
        public uint unTotalMatchingResults;
        /// <summary>bool m_bCachedData</summary>
        public bool bCachedData;
        /// <summary>char [256] m_rgchNextCursor</summary>
        public UTF8String256 rgchNextCursor;
    }
}