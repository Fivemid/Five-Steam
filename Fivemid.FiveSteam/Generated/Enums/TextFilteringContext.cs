using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Parameter to <a href="https://partner.steamgames.com/doc/api/ISteamUtils#FilterText" class="bb_apilink">ISteamUtils::FilterText</a>.<br />
    /// <br />
    /// </summary>
    public enum TextFilteringContext : int
    {
        /// <summary>Unknown context.</summary>
        Unknown = 0,
        /// <summary>Game content, only legally required filtering is performed.</summary>
        GameContent = 1,
        /// <summary>Chat from another player.</summary>
        Chat = 2,
        /// <summary>Character or item name.</summary>
        Name = 3
    }
}