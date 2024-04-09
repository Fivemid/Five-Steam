using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>PS3TrophiesInstalled_t</summary>
    public unsafe struct PS3TrophiesInstalled
    {
        /// <summary>uint64 m_nGameID</summary>
        public ulong nGameID;
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>uint64 m_ulRequiredDiskSpace</summary>
        public ulong ulRequiredDiskSpace;
    }
}