using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// A lobby chat room state has changed, this is usually sent when a user has joined or left the
    /// lobby.<br />
    /// <br />
    /// 
    /// </summary>
    public unsafe struct LobbyChatUpdate : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.LobbyChatUpdate;
        /// <summary>The Steam ID of the lobby.</summary>
        public ulong ulSteamIDLobby;
        /// <summary>The user who's status in the lobby just changed - can be recipient.</summary>
        public ulong ulSteamIDUserChanged;
        /// <summary>
        ///             Chat member who made the change. This can be different from
        ///             <code class="bb_code bb_code_inline nohighlight">m_ulSteamIDUserChanged</code> if
        ///             kicking, muting, etc. For example, if one user kicks another from the lobby, this will
        ///             be set to the id of the user who initiated the kick.
        ///         </summary>
        public ulong ulSteamIDMakingChange;
        /// <summary>
        ///             Bitfield of
        ///             <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#EChatMemberStateChange" class="bb_apilink">EChatMemberStateChange</a>
        ///             values.
        ///         </summary>
        public uint rgfChatMemberStateChange;
    }
}