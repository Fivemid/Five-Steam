using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>GameWebCallback_t</summary>
    public unsafe struct GameWebCallback
    {
        /// <summary>char [256] m_szURL</summary>
        public UTF8String256 szURL;
    }
}