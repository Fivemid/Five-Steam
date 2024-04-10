using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>P2PSessionState_t</summary>
    public unsafe struct P2PSessionState
    {
        /// <summary>uint8 m_bConnectionActive</summary>
        public byte bConnectionActive;
        /// <summary>uint8 m_bConnecting</summary>
        public byte bConnecting;
        /// <summary>uint8 m_eP2PSessionError</summary>
        public byte eP2PSessionError;
        /// <summary>uint8 m_bUsingRelay</summary>
        public byte bUsingRelay;
        /// <summary>int32 m_nBytesQueuedForSend</summary>
        public int nBytesQueuedForSend;
        /// <summary>int32 m_nPacketsQueuedForSend</summary>
        public int nPacketsQueuedForSend;
        /// <summary>uint32 m_nRemoteIP</summary>
        public uint nRemoteIP;
        /// <summary>uint16 m_nRemotePort</summary>
        public ushort nRemotePort;
    }
}