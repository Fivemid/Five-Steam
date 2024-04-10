using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>RequestPlayersForGameProgressCallback_t</summary>
    public unsafe struct RequestPlayersForGameProgressCallback
    {
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>uint64 m_ullSearchID</summary>
        public ulong ullSearchID;
    }
}