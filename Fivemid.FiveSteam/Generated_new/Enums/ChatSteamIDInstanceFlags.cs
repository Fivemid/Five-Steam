using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EChatSteamIDInstanceFlags</summary>
    public enum ChatSteamIDInstanceFlags : int
    {
        /// <summary>k_EChatAccountInstanceMask</summary>
        ChatAccountInstanceMask = 4095,
        /// <summary>k_EChatInstanceFlagClan</summary>
        ChatInstanceFlagClan = 524288,
        /// <summary>k_EChatInstanceFlagLobby</summary>
        ChatInstanceFlagLobby = 262144,
        /// <summary>k_EChatInstanceFlagMMSLobby</summary>
        ChatInstanceFlagMMSLobby = 131072
    }
}