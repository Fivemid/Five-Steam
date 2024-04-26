using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when a user has left a Steam group chat that the we are in.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamFriends#LeaveClanChatRoom" class="bb_apilink">ISteamFriends::LeaveClanChatRoom</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct GameConnectedChatLeave : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.GameConnectedChatLeave;
        /// <summary>The Steam ID of the chat that a user has left.</summary>
        public SteamId steamIDClanChat;
        /// <summary>The Steam ID of the user that has left the chat.</summary>
        public SteamId steamIDUser;
        /// <summary>Was the user kicked by an officer (<b>true</b>), or not (<b>false</b>)?</summary>
        public bool bKicked;
        /// <summary>Was the user's connection to Steam dropped (<b>true</b>), or did they leave via other means (<b>false</b>)?</summary>
        public bool bDropped;
    }
}