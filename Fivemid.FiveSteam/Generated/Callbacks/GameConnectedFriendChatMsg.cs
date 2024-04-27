using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when chat message has been received from a friend.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamFriends#SetListenForFriendsMessages" class="bb_apilink">ISteamFriends::SetListenForFriendsMessages</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct GameConnectedFriendChatMsg
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.GameConnectedFriendChatMsg;
        /// <summary>The Steam ID of the friend that sent the message.</summary>
        public SteamId steamIDUser;
        /// <summary>The index of the message to get the actual data from with <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetFriendMessage" class="bb_apilink">ISteamFriends::GetFriendMessage</a>.</summary>
        public int iMessageID;
    }
}