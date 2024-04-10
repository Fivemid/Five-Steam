using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ESteamItemFlags</summary>
    public enum SteamItemFlags : int
    {
        /// <summary>k_ESteamItemNoTrade</summary>
        SteamItemNoTrade = 1,
        /// <summary>k_ESteamItemRemoved</summary>
        SteamItemRemoved = 256,
        /// <summary>k_ESteamItemConsumed</summary>
        SteamItemConsumed = 512
    }
}