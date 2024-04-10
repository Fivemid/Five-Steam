using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EndGameResultCallback_t</summary>
    public unsafe struct EndGameResultCallback
    {
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>uint64 ullUniqueGameID</summary>
        public ulong ullUniqueGameID;
    }
}