using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>The lobby metadata has changed.<br />
    /// <br />
    /// If <code class="bb_code bb_code_inline nohighlight">m_ulSteamIDMember</code> is a user in the lobby, then use <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#GetLobbyMemberData" class="bb_apilink">ISteamMatchmaking::GetLobbyMemberData</a> to access per-user details; otherwise, if <code class="bb_code bb_code_inline nohighlight">m_ulSteamIDMember</code> == <code class="bb_code bb_code_inline nohighlight">m_ulSteamIDLobby</code>, use <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#GetLobbyData" class="bb_apilink">ISteamMatchmaking::GetLobbyData</a> to access the lobby metadata.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#CreateLobby" class="bb_apilink">ISteamMatchmaking::CreateLobby</a>, <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#JoinLobby" class="bb_apilink">ISteamMatchmaking::JoinLobby</a>, <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#SetLobbyMemberData" class="bb_apilink">ISteamMatchmaking::SetLobbyMemberData</a>, <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#RequestLobbyData" class="bb_apilink">ISteamMatchmaking::RequestLobbyData</a>, <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#SetLobbyOwner" class="bb_apilink">ISteamMatchmaking::SetLobbyOwner</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct LobbyDataUpdate : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.LobbyDataUpdate;
        /// <summary>The Steam ID of the Lobby.</summary>
        public ulong ulSteamIDLobby;
        /// <summary>Steam ID of either the member whose data changed, or the room itself.</summary>
        public ulong ulSteamIDMember;
        /// <summary><b>true</b> if the lobby data was successfully changed, otherwise <b>false</b>.</summary>
        public byte bSuccess;
    }
}