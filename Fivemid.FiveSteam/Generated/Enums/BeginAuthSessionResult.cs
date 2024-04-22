using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Results returned from <a href="https://partner.steamgames.com/doc/api/ISteamUser#BeginAuthSession" class="bb_apilink">ISteamUser::BeginAuthSession</a> and <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#BeginAuthSession" class="bb_apilink">ISteamGameServer::BeginAuthSession</a>.<br />
    /// <br />
    /// </summary>
    public enum BeginAuthSessionResult : int
    {
        /// <summary>Ticket is valid for this game and this Steam ID.</summary>
        OK = 0,
        /// <summary>The ticket is invalid.</summary>
        InvalidTicket = 1,
        /// <summary>A ticket has already been submitted for this Steam ID.</summary>
        DuplicateRequest = 2,
        /// <summary>Ticket is from an incompatible interface version.</summary>
        InvalidVersion = 3,
        /// <summary>Ticket is not for this game.</summary>
        GameMismatch = 4,
        /// <summary>Ticket has expired.</summary>
        ExpiredTicket = 5
    }
}