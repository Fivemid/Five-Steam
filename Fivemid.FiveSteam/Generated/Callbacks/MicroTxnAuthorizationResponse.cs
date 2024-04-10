using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>MicroTxnAuthorizationResponse_t</summary>
    public unsafe struct MicroTxnAuthorizationResponse
    {
        /// <summary>uint32 m_unAppID</summary>
        public uint unAppID;
        /// <summary>uint64 m_ulOrderID</summary>
        public ulong ulOrderID;
        /// <summary>uint8 m_bAuthorized</summary>
        public byte bAuthorized;
    }
}