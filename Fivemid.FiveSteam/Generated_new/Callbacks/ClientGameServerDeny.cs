using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ClientGameServerDeny_t</summary>
    public unsafe struct ClientGameServerDeny
    {
        /// <summary>uint32 m_uAppID</summary>
        public uint uAppID;
        /// <summary>uint32 m_unGameServerIP</summary>
        public uint unGameServerIP;
        /// <summary>uint16 m_usGameServerPort</summary>
        public ushort usGameServerPort;
        /// <summary>uint16 m_bSecure</summary>
        public ushort bSecure;
        /// <summary>uint32 m_uReason</summary>
        public uint uReason;
    }
}