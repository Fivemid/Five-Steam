using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>P2PSessionRequest_t</summary>
    public unsafe struct P2PSessionRequest
    {
        /// <summary>CSteamID m_steamIDRemote</summary>
        public SteamId steamIDRemote;
    }
}