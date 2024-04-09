using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>FriendsIsFollowing_t</summary>
    public unsafe struct FriendsIsFollowing
    {
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>CSteamID m_steamID</summary>
        public SteamId steamID;
        /// <summary>bool m_bIsFollowing</summary>
        public bool bIsFollowing;
    }
}