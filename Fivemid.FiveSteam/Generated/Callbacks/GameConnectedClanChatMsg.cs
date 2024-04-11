using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>GameConnectedClanChatMsg_t</summary>
    public unsafe struct GameConnectedClanChatMsg : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.GameConnectedClanChatMsg;
        /// <summary>CSteamID m_steamIDClanChat</summary>
        public SteamId steamIDClanChat;
        /// <summary>CSteamID m_steamIDUser</summary>
        public SteamId steamIDUser;
        /// <summary>int m_iMessageID</summary>
        public int iMessageID;
    }
}