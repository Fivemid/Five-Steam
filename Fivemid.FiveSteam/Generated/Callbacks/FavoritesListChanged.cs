using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>A server was added/removed from the favorites list, you should refresh now.<br />
    /// <br />
    /// </summary>
    public unsafe struct FavoritesListChanged : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.FavoritesListChanged;
        /// <summary>An IP of 0 means reload the whole list, any other value means just one server. This is host order, i.e 127.0.0.1 == 0x7f000001.</summary>
        public uint nIP;
        /// <summary>If <code class="bb_code bb_code_inline nohighlight">m_nIP</code> is set then this is the new servers query port, in host order.</summary>
        public uint nQueryPort;
        /// <summary>If <code class="bb_code bb_code_inline nohighlight">m_nIP</code> is set then this is the new servers connection port, in host order.</summary>
        public uint nConnPort;
        /// <summary>If <code class="bb_code bb_code_inline nohighlight">m_nIP</code> is set then this is the App ID the game server belongs to.</summary>
        public uint nAppID;
        /// <summary>If <code class="bb_code bb_code_inline nohighlight">m_nIP</code> is set then this returns whether the the server is on the favorites list or the history list. See <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#k_unFavoriteFlagNone" class="bb_apilink">k_unFavoriteFlagNone</a> for more information.</summary>
        public uint nFlags;
        /// <summary>If <code class="bb_code bb_code_inline nohighlight">m_nIP</code> is set then this is whether the server was added to the list (<b>true</b>) or removed (<b>false</b>) from it.</summary>
        public bool bAdd;
        /// <summary></summary>
        public AccountID unAccountId;
    }
}