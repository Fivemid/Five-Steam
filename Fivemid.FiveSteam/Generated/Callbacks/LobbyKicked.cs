using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Currently unused! If you want to implement kicking at this time then do it with a special packet sent with <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#SendLobbyChatMsg" class="bb_apilink">ISteamMatchmaking::SendLobbyChatMsg</a>, when the user gets the packet they should call <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#LeaveLobby" class="bb_apilink">ISteamMatchmaking::LeaveLobby</a>.<br />
    /// <br />
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct LobbyKicked
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.LobbyKicked;
        /// <summary></summary>
        public ulong ulSteamIDLobby;
        /// <summary></summary>
        public ulong ulSteamIDAdmin;
        /// <summary></summary>
        public byte bKickedDueToDisconnect;
    }
}