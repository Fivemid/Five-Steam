using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamNetworkingConfigValue_t</summary>
    public unsafe struct SteamNetworkingConfigValue
    {
        /// <summary>ESteamNetworkingConfigValue m_eValue</summary>
        public SteamNetworkingConfigValueType eValue;
        /// <summary>ESteamNetworkingConfigDataType m_eDataType</summary>
        public SteamNetworkingConfigDataType eDataType;
        /// <summary>int64_t m_int64</summary>
        public long int64;
    }
}