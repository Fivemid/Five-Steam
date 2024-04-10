using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>FriendRichPresenceUpdate_t</summary>
    public unsafe struct FriendRichPresenceUpdate
    {
        /// <summary>CSteamID m_steamIDFriend</summary>
        public SteamId steamIDFriend;
        /// <summary>AppId_t m_nAppID</summary>
        public AppId nAppID;
    }
}