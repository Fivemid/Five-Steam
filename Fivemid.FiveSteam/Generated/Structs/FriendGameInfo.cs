using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Information about the game a friend is playing.<br />
    /// Obtainable from: <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetFriendGamePlayed" class="bb_apilink">ISteamFriends::GetFriendGamePlayed</a>.<br />
    /// <br />
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct FriendGameInfo
    {
        /// <summary>The game ID that the friend is playing.</summary>
        public GameId gameID;
        /// <summary>The IP of the server the friend is playing on.</summary>
        public uint unGameIP;
        /// <summary>The port of the server the friend is playing on.</summary>
        public ushort usGamePort;
        /// <summary>The query port of the server the friend is playing on.</summary>
        public ushort usQueryPort;
        /// <summary>The Steam ID of the lobby the friend is in.</summary>
        public SteamId steamIDLobby;
    }
}