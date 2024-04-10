using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ESNetSocketConnectionType</summary>
    public enum SNetSocketConnectionType : int
    {
        /// <summary>k_ESNetSocketConnectionTypeNotConnected</summary>
        NotConnected = 0,
        /// <summary>k_ESNetSocketConnectionTypeUDP</summary>
        UDP = 1,
        /// <summary>k_ESNetSocketConnectionTypeUDPRelay</summary>
        UDPRelay = 2
    }
}