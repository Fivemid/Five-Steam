using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>RequestPlayersForGameFinalResultCallback_t</summary>
    public unsafe struct RequestPlayersForGameFinalResultCallback
    {
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>uint64 m_ullSearchID</summary>
        public ulong ullSearchID;
        /// <summary>uint64 m_ullUniqueGameID</summary>
        public ulong ullUniqueGameID;
    }
}