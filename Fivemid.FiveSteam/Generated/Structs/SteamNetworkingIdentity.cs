using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamNetworkingIdentity</summary>
    public unsafe struct SteamNetworkingIdentity
    {
        /// <summary>ESteamNetworkingIdentityType m_eType</summary>
        public SteamNetworkingIdentityType eType;
        /// <summary>int m_cbSize</summary>
        public int cbSize;
        /// <summary>char [128] m_szUnknownRawString</summary>
        public UTF8String128 szUnknownRawString;
    }
}