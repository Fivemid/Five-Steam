using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Recieved upon attempting to enter a lobby. Lobby metadata is available to use immediately after receiving this.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#CreateLobby" class="bb_apilink">ISteamMatchmaking::CreateLobby</a>, <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#JoinLobby" class="bb_apilink">ISteamMatchmaking::JoinLobby</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct LobbyEnter : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.LobbyEnter;
        /// <summary>The steam ID of the Lobby you have entered.</summary>
        public ulong ulSteamIDLobby;
        /// <summary>Unused - Always 0.</summary>
        public uint rgfChatPermissions;
        /// <summary>If true, then only invited users may join.</summary>
        public bool bLocked;
        /// <summary>This is actually a <a href="https://partner.steamgames.com/doc/api/steam_api#EChatRoomEnterResponse" class="bb_apilink">EChatRoomEnterResponse</a> value. This will be set to <a href="https://partner.steamgames.com/doc/api/steam_api#k_EChatRoomEnterResponseSuccess" class="bb_apilink">k_EChatRoomEnterResponseSuccess</a> if the lobby was successfully joined, otherwise it will be <a href="https://partner.steamgames.com/doc/api/steam_api#k_EChatRoomEnterResponseError" class="bb_apilink">k_EChatRoomEnterResponseError</a>.</summary>
        public uint EChatRoomEnterResponse;
    }
}