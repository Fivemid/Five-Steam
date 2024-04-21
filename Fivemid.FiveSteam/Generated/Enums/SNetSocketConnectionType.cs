using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Describes how the socket is currently connected. Only used by the old networking API.<br />
    /// <br />
    /// 
    /// </summary>
    public enum SNetSocketConnectionType : int
    {
        /// <summary></summary>
        NotConnected = 0,
        /// <summary></summary>
        UDP = 1,
        /// <summary></summary>
        UDPRelay = 2
    }
}