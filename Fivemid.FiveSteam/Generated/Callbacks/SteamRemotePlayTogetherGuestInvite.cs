using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for SteamRemotePlayTogetherGuestInvite_t
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct SteamRemotePlayTogetherGuestInvite
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SteamRemotePlayTogetherGuestInvite;
        /// missing documentation for SteamRemotePlayTogetherGuestInvite_t.m_szConnectURL
        public UTF8String1024 szConnectURL;
    }
}