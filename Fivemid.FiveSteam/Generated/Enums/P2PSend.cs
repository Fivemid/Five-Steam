using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EP2PSend</summary>
    public enum P2PSend : int
    {
        /// <summary>k_EP2PSendUnreliable</summary>
        Unreliable = 0,
        /// <summary>k_EP2PSendUnreliableNoDelay</summary>
        UnreliableNoDelay = 1,
        /// <summary>k_EP2PSendReliable</summary>
        Reliable = 2,
        /// <summary>k_EP2PSendReliableWithBuffering</summary>
        ReliableWithBuffering = 3
    }
}