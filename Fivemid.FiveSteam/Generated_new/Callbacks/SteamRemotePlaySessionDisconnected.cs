using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamRemotePlaySessionDisconnected_t</summary>
    public unsafe struct SteamRemotePlaySessionDisconnected
    {
        /// <summary>RemotePlaySessionID_t m_unSessionID</summary>
        public RemotePlaySessionID unSessionID;
    }
}