using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>GameConnectedFriendChatMsg_t</summary>
    public unsafe struct GameConnectedFriendChatMsg : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.GameConnectedFriendChatMsg;
        /// <summary>CSteamID m_steamIDUser</summary>
        public SteamId steamIDUser;
        /// <summary>int m_iMessageID</summary>
        public int iMessageID;
    }
}