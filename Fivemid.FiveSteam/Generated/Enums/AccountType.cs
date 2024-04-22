using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Steam account types. This is used internally in <a href="#CSteamID" class="bb_apilink">CSteamID</a>.<br />
    /// <br />
    /// </summary>
    public enum AccountType : int
    {
        /// <summary>Used for invalid Steam IDs.</summary>
        Invalid = 0,
        /// <summary>Regular user account.</summary>
        Individual = 1,
        /// <summary>Multiseat (e.g. cybercafe) account.</summary>
        Multiseat = 2,
        /// <summary>Persistent (not anonymous) game server account.</summary>
        GameServer = 3,
        /// <summary>Anonymous game server account.</summary>
        AnonGameServer = 4,
        /// <summary>Pending.</summary>
        Pending = 5,
        /// <summary>Valve internal content server account.</summary>
        ContentServer = 6,
        /// <summary>Steam Group (clan).</summary>
        Clan = 7,
        /// <summary>Steam group chat or lobby.</summary>
        Chat = 8,
        /// <summary>Fake Steam ID for local PSN account on PS3 or Live account on 360, etc.</summary>
        ConsoleUser = 9,
        /// <summary>Anonymous user account. (Used to create an account or reset a password)</summary>
        AnonUser = 10,
        /// <summary>Max of 16 items in this field</summary>
        Max = 11
    }
}