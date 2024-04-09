using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamRemotePlayTogetherGuestInvite_t</summary>
    public unsafe struct SteamRemotePlayTogetherGuestInvite
    {
        /// <summary>char [1024] m_szConnectURL</summary>
        public UTF8String1024 szConnectURL;
    }
}