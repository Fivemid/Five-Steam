using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for SteamRemotePlayTogetherGuestInvite_t
    public unsafe struct SteamRemotePlayTogetherGuestInvite : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SteamRemotePlayTogetherGuestInvite;
        /// missing documentation for SteamRemotePlayTogetherGuestInvite_t.m_szConnectURL
        public UTF8String1024 szConnectURL;
    }
}