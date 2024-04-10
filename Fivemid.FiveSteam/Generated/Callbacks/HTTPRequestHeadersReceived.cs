using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>HTTPRequestHeadersReceived_t</summary>
    public unsafe struct HTTPRequestHeadersReceived
    {
        /// <summary>HTTPRequestHandle m_hRequest</summary>
        public HTTPRequestHandle hRequest;
        /// <summary>uint64 m_ulContextValue</summary>
        public ulong ulContextValue;
    }
}