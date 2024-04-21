using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Flags describing how a users lobby state has changed. This is provided from
    /// <a href="https://partner.steamgames.com/doc/api/ISteamMatchmaking#LobbyChatUpdate_t" class="bb_apilink">LobbyChatUpdate_t</a>.<br />
    /// <br />
    /// 
    /// </summary>
    public enum ChatMemberStateChange : int
    {
        /// <summary>This user has joined or is joining the lobby.</summary>
        Entered = 1,
        /// <summary>This user has left or is leaving the lobby.</summary>
        Left = 2,
        /// <summary>User disconnected without leaving the lobby first.</summary>
        Disconnected = 4,
        /// <summary>The user has been kicked.</summary>
        Kicked = 8,
        /// <summary>The user has been kicked and banned.</summary>
        Banned = 16
    }
}