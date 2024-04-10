using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>GameConnectedFriendChatMsg_t</summary>
    public unsafe struct GameConnectedFriendChatMsg
    {
        /// <summary>CSteamID m_steamIDUser</summary>
        public SteamId steamIDUser;
        /// <summary>int m_iMessageID</summary>
        public int iMessageID;
    }
}