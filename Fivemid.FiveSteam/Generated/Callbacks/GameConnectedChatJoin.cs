using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when a user has joined a Steam group chat that we are in.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamFriends#JoinClanChatRoom" class="bb_apilink">ISteamFriends::JoinClanChatRoom</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct GameConnectedChatJoin
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.GameConnectedChatJoin;
        /// <summary>The Steam ID of the chat that a user has joined.</summary>
        public SteamId steamIDClanChat;
        /// <summary>The Steam ID of the user that has joined the chat.</summary>
        public SteamId steamIDUser;
    }
}