using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EChatMemberStateChange</summary>
    public enum ChatMemberStateChange : int
    {
        /// <summary>k_EChatMemberStateChangeEntered</summary>
        Entered = 1,
        /// <summary>k_EChatMemberStateChangeLeft</summary>
        Left = 2,
        /// <summary>k_EChatMemberStateChangeDisconnected</summary>
        Disconnected = 4,
        /// <summary>k_EChatMemberStateChangeKicked</summary>
        Kicked = 8,
        /// <summary>k_EChatMemberStateChangeBanned</summary>
        Banned = 16
    }
}