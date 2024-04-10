using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EMatchMakingServerResponse</summary>
    public enum MatchMakingServerResponse : int
    {
        /// <summary>eServerResponded</summary>
        eServerResponded = 0,
        /// <summary>eServerFailedToRespond</summary>
        eServerFailedToRespond = 1,
        /// <summary>eNoServersListedOnMasterServer</summary>
        eNoServersListedOnMasterServer = 2
    }
}