using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>P2PSessionConnectFail_t</summary>
    public unsafe struct P2PSessionConnectFail
    {
        /// <summary>CSteamID m_steamIDRemote</summary>
        public SteamId steamIDRemote;
        /// <summary>uint8 m_eP2PSessionError</summary>
        public byte eP2PSessionError;
    }
}