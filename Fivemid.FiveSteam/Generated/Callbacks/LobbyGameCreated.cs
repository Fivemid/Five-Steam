using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>A game server has been set via <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#SetLobbyGameServer" class="bb_apilink">ISteamMatchmaking::SetLobbyGameServer</a> for all of the members of the lobby to join. It's up to the individual clients to take action on this; the typical game behavior is to leave the lobby and connect to the specified game server; but the lobby may stay open throughout the session if desired.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#SetLobbyGameServer" class="bb_apilink">ISteamMatchmaking::SetLobbyGameServer</a></summary>
    public unsafe struct LobbyGameCreated : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.LobbyGameCreated;
        /// <summary>The lobby that set the game server.</summary>
        public ulong ulSteamIDLobby;
        /// <summary>The Steam ID of the game server, if it's set.</summary>
        public ulong ulSteamIDGameServer;
        /// <summary>The IP address of the game server in host order, i.e 127.0.0.1 == 0x7f000001, if it's set.</summary>
        public uint unIP;
        /// <summary>The connection port of the game server, in host order, if it's set.</summary>
        public ushort usPort;
    }
}