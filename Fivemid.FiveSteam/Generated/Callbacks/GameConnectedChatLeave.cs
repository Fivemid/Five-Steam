using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>GameConnectedChatLeave_t</summary>
    public unsafe struct GameConnectedChatLeave : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.GameConnectedChatLeave;
        /// <summary>CSteamID m_steamIDClanChat</summary>
        public SteamId steamIDClanChat;
        /// <summary>CSteamID m_steamIDUser</summary>
        public SteamId steamIDUser;
        /// <summary>bool m_bKicked</summary>
        public bool bKicked;
        /// <summary>bool m_bDropped</summary>
        public bool bDropped;
    }
}