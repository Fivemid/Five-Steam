using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for SteamNetworkingFakeIPResult_t
    public unsafe struct SteamNetworkingFakeIPResult : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SteamNetworkingFakeIPResult;
        /// missing documentation for SteamNetworkingFakeIPResult_t.m_eResult
        public Result eResult;
        /// missing documentation for SteamNetworkingFakeIPResult_t.m_identity
        public SteamNetworkingIdentity identity;
        /// missing documentation for SteamNetworkingFakeIPResult_t.m_unIP
        public uint unIP;
        /// missing documentation for SteamNetworkingFakeIPResult_t.m_unPorts
        public FixedArray_ushort8 unPorts;
    }
}