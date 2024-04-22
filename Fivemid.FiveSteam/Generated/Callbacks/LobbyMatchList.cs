using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Result when requesting the lobby list. You should iterate over the returned lobbies with <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#GetLobbyByIndex" class="bb_apilink">ISteamMatchmaking::GetLobbyByIndex</a>, from 0 to <code class="bb_code bb_code_inline nohighlight">m_nLobbiesMatching</code>-1.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#RequestLobbyList" class="bb_apilink">ISteamMatchmaking::RequestLobbyList</a></summary>
    public unsafe struct LobbyMatchList : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.LobbyMatchList;
        /// <summary>Number of lobbies that matched search criteria and we have Steam IDs for.</summary>
        public uint nLobbiesMatching;
    }
}