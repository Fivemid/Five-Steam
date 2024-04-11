using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>GameLobbyJoinRequested_t</summary>
    public unsafe struct GameLobbyJoinRequested : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.GameLobbyJoinRequested;
        /// <summary>CSteamID m_steamIDLobby</summary>
        public SteamId steamIDLobby;
        /// <summary>CSteamID m_steamIDFriend</summary>
        public SteamId steamIDFriend;
    }
}