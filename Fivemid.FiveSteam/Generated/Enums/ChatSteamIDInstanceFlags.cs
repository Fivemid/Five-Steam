using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Special flags for Chat accounts - they go in the top 8 bits of the Steam ID's "instance", leaving 12 for the actual instances<br />
    /// <br />
    /// </summary>
    public enum ChatSteamIDInstanceFlags : int
    {
        /// <summary>Top 8 bits are flags.</summary>
        ChatAccountInstanceMask = 4095,
        /// <summary>The Steam ID is for a Steam group.</summary>
        ChatInstanceFlagClan = 524288,
        /// <summary>The Steam ID is for a Lobby.</summary>
        ChatInstanceFlagLobby = 262144,
        /// <summary>The Steam ID is for a MMS Lobby.</summary>
        ChatInstanceFlagMMSLobby = 131072
    }
}