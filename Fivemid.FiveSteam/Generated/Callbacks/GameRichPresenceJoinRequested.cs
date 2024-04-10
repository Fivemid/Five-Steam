using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>GameRichPresenceJoinRequested_t</summary>
    public unsafe struct GameRichPresenceJoinRequested
    {
        /// <summary>CSteamID m_steamIDFriend</summary>
        public SteamId steamIDFriend;
        /// <summary>char [256] m_rgchConnect</summary>
        public UTF8String256 rgchConnect;
    }
}