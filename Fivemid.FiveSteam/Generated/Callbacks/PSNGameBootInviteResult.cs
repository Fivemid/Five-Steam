using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>PSNGameBootInviteResult_t</summary>
    public unsafe struct PSNGameBootInviteResult
    {
        /// <summary>bool m_bGameBootInviteExists</summary>
        public bool bGameBootInviteExists;
        /// <summary>CSteamID m_steamIDLobby</summary>
        public SteamId steamIDLobby;
    }
}