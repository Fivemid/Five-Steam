using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SocketStatusCallback_t</summary>
    public unsafe struct SocketStatusCallback : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SocketStatusCallback;
        /// <summary>SNetSocket_t m_hSocket</summary>
        public SNetSocket hSocket;
        /// <summary>SNetListenSocket_t m_hListenSocket</summary>
        public SNetListenSocket hListenSocket;
        /// <summary>CSteamID m_steamIDRemote</summary>
        public SteamId steamIDRemote;
        /// <summary>int m_eSNetSocketState</summary>
        public int eSNetSocketState;
    }
}