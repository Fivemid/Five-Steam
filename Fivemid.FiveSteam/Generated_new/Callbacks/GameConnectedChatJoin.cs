using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>GameConnectedChatJoin_t</summary>
    public unsafe struct GameConnectedChatJoin
    {
        /// <summary>CSteamID m_steamIDClanChat</summary>
        public SteamId steamIDClanChat;
        /// <summary>CSteamID m_steamIDUser</summary>
        public SteamId steamIDUser;
    }
}