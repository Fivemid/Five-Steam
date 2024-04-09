using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>FriendsGetFollowerCount_t</summary>
    public unsafe struct FriendsGetFollowerCount
    {
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>CSteamID m_steamID</summary>
        public SteamId steamID;
        /// <summary>int m_nCount</summary>
        public int nCount;
    }
}