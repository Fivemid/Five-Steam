using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>used in PersonaStateChange_t::m_nChangeFlags to describe what's changed about a user<br />
    /// these flags describe what the client has learned has changed recently, so on startup you'll see a name, avatar &amp; relationship change for every friend<br />
    /// <br />
    /// </summary>
    public enum PersonaChange : int
    {
        /// <summary></summary>
        Name = 1,
        /// <summary></summary>
        Status = 2,
        /// <summary></summary>
        ComeOnline = 4,
        /// <summary></summary>
        GoneOffline = 8,
        /// <summary></summary>
        GamePlayed = 16,
        /// <summary></summary>
        GameServer = 32,
        /// <summary></summary>
        Avatar = 64,
        /// <summary></summary>
        JoinedSource = 128,
        /// <summary></summary>
        LeftSource = 256,
        /// <summary></summary>
        RelationshipChanged = 512,
        /// <summary></summary>
        NameFirstSet = 1024,
        /// missing documentation for EPersonaChange.k_EPersonaChangeBroadcast
        Broadcast = 2048,
        /// <summary></summary>
        Nickname = 4096,
        /// <summary></summary>
        SteamLevel = 8192,
        /// missing documentation for EPersonaChange.k_EPersonaChangeRichPresence
        RichPresence = 16384
    }
}