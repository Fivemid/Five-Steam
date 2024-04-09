using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamNetworkingFakeIPResult_t</summary>
    public unsafe struct SteamNetworkingFakeIPResult
    {
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>SteamNetworkingIdentity m_identity</summary>
        public SteamNetworkingIdentity identity;
        /// <summary>uint32 m_unIP</summary>
        public uint unIP;
        /// <summary>uint16 [8] m_unPorts</summary>
        public FixedArray_ushort8 unPorts;
    }
}