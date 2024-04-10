using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EPlayerResult_t</summary>
    public enum PlayerResult : int
    {
        /// <summary>k_EPlayerResultFailedToConnect</summary>
        FailedToConnect = 1,
        /// <summary>k_EPlayerResultAbandoned</summary>
        Abandoned = 2,
        /// <summary>k_EPlayerResultKicked</summary>
        Kicked = 3,
        /// <summary>k_EPlayerResultIncomplete</summary>
        Incomplete = 4,
        /// <summary>k_EPlayerResultCompleted</summary>
        Completed = 5
    }
}