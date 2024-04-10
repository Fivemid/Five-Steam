using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>HTTPRequestCompleted_t</summary>
    public unsafe struct HTTPRequestCompleted
    {
        /// <summary>HTTPRequestHandle m_hRequest</summary>
        public HTTPRequestHandle hRequest;
        /// <summary>uint64 m_ulContextValue</summary>
        public ulong ulContextValue;
        /// <summary>bool m_bRequestSuccessful</summary>
        public bool bRequestSuccessful;
        /// <summary>EHTTPStatusCode m_eStatusCode</summary>
        public HTTPStatusCode eStatusCode;
        /// <summary>uint32 m_unBodySize</summary>
        public uint unBodySize;
    }
}