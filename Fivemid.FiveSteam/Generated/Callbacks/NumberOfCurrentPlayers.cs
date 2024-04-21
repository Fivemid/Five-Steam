using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Gets the current number of players for the current AppId.<br />
    /// <br />
    /// 
    /// <br />
    /// <b>Associated Functions:</b>
    /// <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetNumberOfCurrentPlayers" class="bb_apilink">ISteamUserStats::GetNumberOfCurrentPlayers</a>
    /// </summary>
    public unsafe struct NumberOfCurrentPlayers : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.NumberOfCurrentPlayers;
        /// <summary>
        ///             Was the call successful? Returns <b>1</b> if it was; otherwise,
        ///             <b>0</b> on failure.
        ///         </summary>
        public byte bSuccess;
        /// <summary>Number of players currently playing.</summary>
        public int cPlayers;
    }
}