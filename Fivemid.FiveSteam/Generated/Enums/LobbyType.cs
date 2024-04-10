using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ELobbyType</summary>
    public enum LobbyType : int
    {
        /// <summary>k_ELobbyTypePrivate</summary>
        Private = 0,
        /// <summary>k_ELobbyTypeFriendsOnly</summary>
        FriendsOnly = 1,
        /// <summary>k_ELobbyTypePublic</summary>
        Public = 2,
        /// <summary>k_ELobbyTypeInvisible</summary>
        Invisible = 3,
        /// <summary>k_ELobbyTypePrivateUnique</summary>
        PrivateUnique = 4
    }
}