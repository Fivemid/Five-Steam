using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>GameConnectedClanChatMsg_t</summary>
    public unsafe struct GameConnectedClanChatMsg
    {
        /// <summary>CSteamID m_steamIDClanChat</summary>
        public SteamId steamIDClanChat;
        /// <summary>CSteamID m_steamIDUser</summary>
        public SteamId steamIDUser;
        /// <summary>int m_iMessageID</summary>
        public int iMessageID;
    }
}